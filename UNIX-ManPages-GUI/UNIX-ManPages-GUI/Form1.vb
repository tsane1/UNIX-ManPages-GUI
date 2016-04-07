﻿Imports System.Xml
Public Class manpage_gui
    Private Sub XMLParse()
        Dim reader As XmlTextReader = New XmlTextReader("books.xml")

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
End Class
