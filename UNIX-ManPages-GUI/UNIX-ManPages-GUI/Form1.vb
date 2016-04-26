Imports System.Xml
Public Class Form1
    Dim filename As String = "manpages_content.xml"
    Dim moveStack As Stack(Of String)

    Private Sub PrintCmd(ByVal targetCmd As String)
        CmdTitle.Clear()
        SynopsisTextBox.Clear()
        descriptionTextBox.Clear()
        usageTextBox.Clear()

        Dim reader As XmlTextReader = New XmlTextReader(filename)
        Dim focus As RichTextBox

        Dim loopCounter As Integer = 0
        Do
            reader.Read()
            loopCounter = loopCounter + 1
            If (loopCounter = 10000) Then 'loop counter to avoid endless cycling (a bit hacky but I waited last minute so oops)
                CmdTitle.Text = "Error 404: Not Found"
                SynopsisTextBox.Text = "Command " + targetCmd + " was not found :("
                Exit Do
            End If
        Loop Until (reader.MoveToAttribute("name") And reader.Value Like targetCmd)

        Do
            If (loopCounter = 10000) Then
                Exit Do
            End If
            MoveToNextElement(reader)
            Select Case reader.Name
                Case "cmdname"
                    If reader.NodeType = XmlNodeType.Element Then
                        MoveToNextText(reader)
                        CmdTitle.Text = reader.Value
                    End If
                Case "synopsis"
                    If reader.NodeType = XmlNodeType.Element Then
                        focus = SynopsisTextBox
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

                        focus.Select(focus.Find(reader.Value), reader.Value.Length)
                        focus.SelectionFont = New Font(focus.Font, FontStyle.Regular)
                    End If
                Case "p"
                    If reader.NodeType = XmlNodeType.Element Then
                        MoveToNextText(reader)
                        focus.Text &= reader.Value
                        focus.Text &= Environment.NewLine

                        focus.Select(focus.Find(reader.Value), reader.Value.Length)
                        focus.SelectionFont = New Font(focus.Font, FontStyle.Regular)
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

    Private Sub CmdDirectory_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles CmdDirectory.NodeMouseClick
        If e.Node.Text Like "Directories" Or e.Node.Text Like "Files" Then
        Else
            PrintCmd(e.Node.Text)
        End If
    End Sub

    Private Sub TextSizeSlider_ValueChanged(sender As Object, e As EventArgs) Handles TextSizeSlider.ValueChanged
        descriptionTextBox.Font = New Font(descriptionTextBox.Font.FontFamily, 16 + 4 * TextSizeSlider.Value, descriptionTextBox.Font.Style)
        usageTextBox.Font = New Font(usageTextBox.Font.FontFamily, 16 + 4 * TextSizeSlider.Value, usageTextBox.Font.Style)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        PrintCmd(searchText.Text)
    End Sub
End Class
