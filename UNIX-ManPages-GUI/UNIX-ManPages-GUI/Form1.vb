Imports System.Xml
Public Class Form1
    Private Sub XMLParse(ByVal cmd As String, ByVal filename As String)
        Dim reader As XmlTextReader = New XmlTextReader(filename)
        Dim found As Boolean = False
        ' main parser loop
        Do
            reader.Read()
            Do
                reader.Read()
            Loop Until (reader.NodeType = XmlNodeType.Element AndAlso reader.Name Like "cmd")
            If reader.HasAttributes Then
                reader.MoveToAttribute("name")
                found = reader.Value Like cmd
            End If
        Loop While (Not (found))
        Console.WriteLine("xml works yo")
    End Sub

    Private Sub testXml(ByVal filename As String)
        Dim reader As XmlTextReader = New XmlTextReader(filename)

        Do While (reader.Read())
            Select Case reader.NodeType
                Case XmlNodeType.Element 'Display beginning of element.
                    Console.Write("<" + reader.Name)
                    If reader.HasAttributes Then 'If attributes exist
                        While reader.MoveToNextAttribute()
                            'Display attribute name and value.
                            Console.Write(" {0}='{1}'", reader.Name, reader.Value)
                        End While
                    End If
                    Console.WriteLine(">")
                Case XmlNodeType.Text 'Display the text in each element.
                    Console.WriteLine(reader.Value)
                Case XmlNodeType.EndElement 'Display end of element.
                    Console.Write("</" + reader.Name)
                    Console.WriteLine(">")
            End Select
        Loop
        Console.ReadLine()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        XMLParse("mkdir", "manpages_content.xml")
    End Sub
End Class
