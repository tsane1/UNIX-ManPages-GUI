<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manpage_gui
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("mkdir")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ls")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("cd")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Directories", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9, TreeNode10})
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("mv")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("scp")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Files", New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode13})
        Me.Title = New System.Windows.Forms.TextBox()
        Me.CmdDirectory = New System.Windows.Forms.TreeView()
        Me.searchText = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.CmdTextArea = New System.Windows.Forms.TabControl()
        Me.SummaryTab = New System.Windows.Forms.TabPage()
        Me.DetailsTab = New System.Windows.Forms.TabPage()
        Me.TextSizeSlider = New System.Windows.Forms.TrackBar()
        Me.Credits = New System.Windows.Forms.TextBox()
        Me.cmdNameBox = New System.Windows.Forms.TextBox()
        Me.summaryTextBox = New System.Windows.Forms.TextBox()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.backBtn2 = New System.Windows.Forms.Button()
        Me.detailsTextBox = New System.Windows.Forms.TextBox()
        Me.cmdNameBox2 = New System.Windows.Forms.TextBox()
        Me.CmdTextArea.SuspendLayout()
        Me.SummaryTab.SuspendLayout()
        Me.DetailsTab.SuspendLayout()
        CType(Me.TextSizeSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Black
        Me.Title.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Title.Cursor = System.Windows.Forms.Cursors.No
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.White
        Me.Title.Location = New System.Drawing.Point(12, 12)
        Me.Title.Name = "Title"
        Me.Title.ReadOnly = True
        Me.Title.Size = New System.Drawing.Size(455, 69)
        Me.Title.TabIndex = 0
        Me.Title.Text = "UNIX Man Pages"
        '
        'CmdDirectory
        '
        Me.CmdDirectory.BackColor = System.Drawing.Color.Black
        Me.CmdDirectory.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDirectory.ForeColor = System.Drawing.Color.White
        Me.CmdDirectory.Location = New System.Drawing.Point(669, 8)
        Me.CmdDirectory.Name = "CmdDirectory"
        TreeNode8.Name = "mkdirNode"
        TreeNode8.Text = "mkdir"
        TreeNode9.Name = "lsNode"
        TreeNode9.Text = "ls"
        TreeNode10.Name = "cdNode"
        TreeNode10.Text = "cd"
        TreeNode11.Name = "DirectoriesNode"
        TreeNode11.Text = "Directories"
        TreeNode12.Name = "mvNode"
        TreeNode12.Text = "mv"
        TreeNode13.Name = "scpNode"
        TreeNode13.Text = "scp"
        TreeNode14.Name = "FilesNode"
        TreeNode14.Text = "Files"
        Me.CmdDirectory.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode14})
        Me.CmdDirectory.Size = New System.Drawing.Size(251, 629)
        Me.CmdDirectory.TabIndex = 1
        '
        'searchText
        '
        Me.searchText.Location = New System.Drawing.Point(714, 487)
        Me.searchText.Name = "searchText"
        Me.searchText.Size = New System.Drawing.Size(160, 22)
        Me.searchText.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(756, 515)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(76, 28)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'CmdTextArea
        '
        Me.CmdTextArea.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.CmdTextArea.Controls.Add(Me.SummaryTab)
        Me.CmdTextArea.Controls.Add(Me.DetailsTab)
        Me.CmdTextArea.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdTextArea.Location = New System.Drawing.Point(12, 93)
        Me.CmdTextArea.Multiline = True
        Me.CmdTextArea.Name = "CmdTextArea"
        Me.CmdTextArea.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdTextArea.SelectedIndex = 0
        Me.CmdTextArea.Size = New System.Drawing.Size(651, 548)
        Me.CmdTextArea.TabIndex = 4
        '
        'SummaryTab
        '
        Me.SummaryTab.Controls.Add(Me.backBtn)
        Me.SummaryTab.Controls.Add(Me.summaryTextBox)
        Me.SummaryTab.Controls.Add(Me.cmdNameBox)
        Me.SummaryTab.Location = New System.Drawing.Point(4, 4)
        Me.SummaryTab.Name = "SummaryTab"
        Me.SummaryTab.Padding = New System.Windows.Forms.Padding(3)
        Me.SummaryTab.Size = New System.Drawing.Size(643, 520)
        Me.SummaryTab.TabIndex = 0
        Me.SummaryTab.Text = "Summary"
        Me.SummaryTab.UseVisualStyleBackColor = True
        '
        'DetailsTab
        '
        Me.DetailsTab.Controls.Add(Me.backBtn2)
        Me.DetailsTab.Controls.Add(Me.detailsTextBox)
        Me.DetailsTab.Controls.Add(Me.cmdNameBox2)
        Me.DetailsTab.Location = New System.Drawing.Point(4, 4)
        Me.DetailsTab.Name = "DetailsTab"
        Me.DetailsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.DetailsTab.Size = New System.Drawing.Size(643, 520)
        Me.DetailsTab.TabIndex = 1
        Me.DetailsTab.Text = "Details"
        Me.DetailsTab.UseVisualStyleBackColor = True
        '
        'TextSizeSlider
        '
        Me.TextSizeSlider.BackColor = System.Drawing.Color.Black
        Me.TextSizeSlider.LargeChange = 2
        Me.TextSizeSlider.Location = New System.Drawing.Point(424, 622)
        Me.TextSizeSlider.Maximum = 2
        Me.TextSizeSlider.Name = "TextSizeSlider"
        Me.TextSizeSlider.Size = New System.Drawing.Size(218, 56)
        Me.TextSizeSlider.TabIndex = 0
        '
        'Credits
        '
        Me.Credits.BackColor = System.Drawing.Color.Black
        Me.Credits.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Credits.ForeColor = System.Drawing.Color.White
        Me.Credits.Location = New System.Drawing.Point(483, 32)
        Me.Credits.Name = "Credits"
        Me.Credits.ReadOnly = True
        Me.Credits.Size = New System.Drawing.Size(176, 30)
        Me.Credits.TabIndex = 5
        Me.Credits.Text = "(c) 2016 Tanuj Sane" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmdNameBox
        '
        Me.cmdNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cmdNameBox.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNameBox.Location = New System.Drawing.Point(6, 6)
        Me.cmdNameBox.Name = "cmdNameBox"
        Me.cmdNameBox.Size = New System.Drawing.Size(538, 32)
        Me.cmdNameBox.TabIndex = 0
        '
        'summaryTextBox
        '
        Me.summaryTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.summaryTextBox.Location = New System.Drawing.Point(0, 46)
        Me.summaryTextBox.Multiline = True
        Me.summaryTextBox.Name = "summaryTextBox"
        Me.summaryTextBox.Size = New System.Drawing.Size(643, 474)
        Me.summaryTextBox.TabIndex = 1
        Me.summaryTextBox.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'backBtn
        '
        Me.backBtn.BackColor = System.Drawing.Color.White
        Me.backBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backBtn.ForeColor = System.Drawing.Color.Black
        Me.backBtn.Location = New System.Drawing.Point(550, 10)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(76, 28)
        Me.backBtn.TabIndex = 6
        Me.backBtn.Text = "< Back"
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'backBtn2
        '
        Me.backBtn2.BackColor = System.Drawing.Color.White
        Me.backBtn2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backBtn2.ForeColor = System.Drawing.Color.Black
        Me.backBtn2.Location = New System.Drawing.Point(550, 7)
        Me.backBtn2.Name = "backBtn2"
        Me.backBtn2.Size = New System.Drawing.Size(76, 28)
        Me.backBtn2.TabIndex = 9
        Me.backBtn2.Text = "< Back"
        Me.backBtn2.UseVisualStyleBackColor = False
        '
        'detailsTextBox
        '
        Me.detailsTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailsTextBox.Location = New System.Drawing.Point(0, 43)
        Me.detailsTextBox.Multiline = True
        Me.detailsTextBox.Name = "detailsTextBox"
        Me.detailsTextBox.Size = New System.Drawing.Size(643, 474)
        Me.detailsTextBox.TabIndex = 8
        Me.detailsTextBox.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmdNameBox2
        '
        Me.cmdNameBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cmdNameBox2.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNameBox2.Location = New System.Drawing.Point(6, 3)
        Me.cmdNameBox2.Name = "cmdNameBox2"
        Me.cmdNameBox2.Size = New System.Drawing.Size(538, 32)
        Me.cmdNameBox2.TabIndex = 7
        '
        'manpage_gui
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(932, 653)
        Me.Controls.Add(Me.Credits)
        Me.Controls.Add(Me.TextSizeSlider)
        Me.Controls.Add(Me.CmdTextArea)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.searchText)
        Me.Controls.Add(Me.CmdDirectory)
        Me.Controls.Add(Me.Title)
        Me.Name = "manpage_gui"
        Me.Text = "UNIX Man Pages"
        Me.CmdTextArea.ResumeLayout(False)
        Me.SummaryTab.ResumeLayout(False)
        Me.SummaryTab.PerformLayout()
        Me.DetailsTab.ResumeLayout(False)
        Me.DetailsTab.PerformLayout()
        CType(Me.TextSizeSlider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As TextBox
    Friend WithEvents CmdDirectory As TreeView
    Friend WithEvents searchText As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents CmdTextArea As TabControl
    Friend WithEvents SummaryTab As TabPage
    Friend WithEvents DetailsTab As TabPage
    Friend WithEvents TextSizeSlider As TrackBar
    Friend WithEvents Credits As TextBox
    Friend WithEvents summaryTextBox As TextBox
    Friend WithEvents cmdNameBox As TextBox
    Friend WithEvents backBtn As Button
    Friend WithEvents backBtn2 As Button
    Friend WithEvents detailsTextBox As TextBox
    Friend WithEvents cmdNameBox2 As TextBox
End Class
