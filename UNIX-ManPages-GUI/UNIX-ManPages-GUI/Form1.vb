Imports System.Xml
Public Class Form1
    Dim filename As String = "manpages_content.xml"
    Dim reader As XmlTextReader = New XmlTextReader(filename)

    Private Sub FindNextNode(ByVal type As Integer)
        Do
            reader.Read()
        Loop Until (reader.NodeType = type)
    End Sub

    Private Sub FindAttr(ByVal name As String, ByVal value As String)
        Dim flag As Boolean = False
        Do
            Do
                FindNextNode(XmlNodeType.Element)
            Loop Until (reader.Name Like name)
            flag = reader.MoveToAttribute("name") And reader.Value = value
        Loop Until (flag)
    End Sub

    Private Sub PrintCmd(ByVal cmd As String)
        FindAttr("cmd", cmd)
        Do
            FindNextNode(XmlNodeType.Element)
            Select Case reader.Name
                Case "cmdname"
                    FindNextNode(XmlNodeType.Text)
                    cmdNameBox.Text = reader.Value
                    cmdNameBox2.Text = reader.Value
                Case "synopsis"
                    PrintToMulti(synopsis, synopsis2)
                Case "info"
                    FindAttr("info", "description")
                    PrintToMulti(descriptionText)
                    FindAttr("info", "usage")
                    PrintToMulti(usageText)
                Case Else
                    Exit Do
            End Select
        Loop
    End Sub

    Private Sub PrintToMulti(ByRef txtbox As TextBox)
        Do
            FindNextNode(XmlNodeType.Element)
            Select Case reader.Name
                Case "title"
                    FindNextNode(XmlNodeType.Text)
                    txtbox.Font = New Font(txtbox.Font.FontFamily, txtbox.Font.SizeInPoints, FontStyle.Bold)
                    txtbox.Text += reader.Value
                    txtbox.Text += Environment.NewLine
                Case "p"
                    FindNextNode(XmlNodeType.Text)
                    txtbox.Font = New Font(txtbox.Font.FontFamily, txtbox.Font.SizeInPoints, FontStyle.Regular)
                    txtbox.Text += reader.Value
                    txtbox.Text += Environment.NewLine
                Case Else
                    Exit Do
            End Select
        Loop
    End Sub
    Private Sub PrintToMulti(ByRef txtbox As TextBox, ByRef txtbox2 As TextBox)
        Do
            FindNextNode(XmlNodeType.Element)
            Select Case reader.Name
                Case "title"
                    FindNextNode(XmlNodeType.Text)
                    txtbox.Font = New Font(txtbox.Font.FontFamily, txtbox.Font.SizeInPoints, FontStyle.Bold)
                    txtbox.Text += reader.Value
                    txtbox.Text += Environment.NewLine
                    txtbox2.Font = New Font(txtbox2.Font.FontFamily, txtbox.Font.SizeInPoints, FontStyle.Bold)
                    txtbox2.Text += reader.Value
                    txtbox2.Text += Environment.NewLine
                Case "p"
                    FindNextNode(XmlNodeType.Text)
                    txtbox.Font = New Font(txtbox.Font.FontFamily, txtbox.Font.SizeInPoints, FontStyle.Regular)
                    txtbox.Text += reader.Value
                    txtbox.Text += Environment.NewLine
                    txtbox2.Font = New Font(txtbox2.Font.FontFamily, txtbox.Font.SizeInPoints, FontStyle.Regular)
                    txtbox2.Text += reader.Value
                    txtbox2.Text += Environment.NewLine
                Case Else
                    Exit Do
            End Select
        Loop
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        PrintCmd("mkdir")
    End Sub
End Class
