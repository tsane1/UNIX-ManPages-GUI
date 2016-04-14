Imports System.Xml
Public Class Form1
    Dim filename As String = "manpages_content.xml"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        PrintCmd("mkdir")
    End Sub

    Private Sub PrintCmd(ByVal targetCmd As String)
        Dim reader As XmlTextReader = New XmlTextReader(filename)
        Dim focus As RichTextBox
        Dim focus2 As RichTextBox

        Do
            reader.Read()
        Loop Until (reader.MoveToAttribute("name") And reader.Value Like targetCmd)

        Do
            MoveToNextElement(reader)
            Select Case reader.Name
                Case "cmdname"
                    If reader.NodeType = XmlNodeType.Element Then
                        MoveToNextText(reader)
                        cmdNameBox.Text = reader.Value
                        cmdNameBox2.Text = reader.Value
                    End If
                Case "synopsis"
                    If reader.NodeType = XmlNodeType.Element Then
                        focus = synopsis
                    End If
                Case "description"
                    If reader.NodeType = XmlNodeType.Element Then
                        focus = descriptionTextBox
                    End If
                Case "usage"
                    If reader.NodeType = XmlNodeType.Element Then
                        focus = usageTextBox
                    End If
                Case "title"
                    If reader.NodeType = XmlNodeType.Element Then
                        MoveToNextText(reader)
                        focus.Text &= reader.Value
                        focus.Text &= Environment.NewLine
                    End If
                Case "p"
                    If reader.NodeType = XmlNodeType.Element Then
                        MoveToNextText(reader)
                        focus.Text &= reader.Value
                        focus.Text &= Environment.NewLine
                        focus.Text &= Environment.NewLine
                    End If
            End Select
        Loop Until (reader.NodeType = XmlNodeType.EndElement And reader.Name Like "cmd")
    End Sub

    Private Sub MoveToNextElement(ByRef reader As XmlTextReader)
        Do
            reader.Read()
        Loop Until (reader.NodeType = XmlNodeType.Element Or reader.NodeType = XmlNodeType.EndElement)
    End Sub

    Private Sub MoveToNextText(ByRef reader As XmlTextReader)
        Do
            reader.Read()
        Loop Until (reader.NodeType = XmlNodeType.Text)
    End Sub
End Class
