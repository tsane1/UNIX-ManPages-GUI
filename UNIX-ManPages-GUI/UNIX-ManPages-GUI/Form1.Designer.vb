<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("mkdir")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ls")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("cd")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Directories", New System.Windows.Forms.TreeNode() {TreeNode22, TreeNode23, TreeNode24})
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("mv")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("scp")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Files", New System.Windows.Forms.TreeNode() {TreeNode26, TreeNode27})
        Me.Title = New System.Windows.Forms.TextBox()
        Me.CmdDirectory = New System.Windows.Forms.TreeView()
        Me.searchText = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.CmdTextArea = New System.Windows.Forms.TabControl()
        Me.DescriptionTab = New System.Windows.Forms.TabPage()
        Me.backBtn2 = New System.Windows.Forms.Button()
        Me.descriptionText = New System.Windows.Forms.TextBox()
        Me.cmdNameBox2 = New System.Windows.Forms.TextBox()
        Me.UsageTab = New System.Windows.Forms.TabPage()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.usageText = New System.Windows.Forms.TextBox()
        Me.cmdNameBox = New System.Windows.Forms.TextBox()
        Me.TextSizeSlider = New System.Windows.Forms.TrackBar()
        Me.Credits = New System.Windows.Forms.TextBox()
        Me.synopsis = New System.Windows.Forms.TextBox()
        Me.synopsis2 = New System.Windows.Forms.TextBox()
        Me.CmdTextArea.SuspendLayout()
        Me.DescriptionTab.SuspendLayout()
        Me.UsageTab.SuspendLayout()
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
        TreeNode22.Name = "mkdirNode"
        TreeNode22.Text = "mkdir"
        TreeNode23.Name = "lsNode"
        TreeNode23.Text = "ls"
        TreeNode24.Name = "cdNode"
        TreeNode24.Text = "cd"
        TreeNode25.Name = "DirectoriesNode"
        TreeNode25.Text = "Directories"
        TreeNode26.Name = "mvNode"
        TreeNode26.Text = "mv"
        TreeNode27.Name = "scpNode"
        TreeNode27.Text = "scp"
        TreeNode28.Name = "FilesNode"
        TreeNode28.Text = "Files"
        Me.CmdDirectory.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode25, TreeNode28})
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
        Me.CmdTextArea.Controls.Add(Me.DescriptionTab)
        Me.CmdTextArea.Controls.Add(Me.UsageTab)
        Me.CmdTextArea.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdTextArea.Location = New System.Drawing.Point(12, 93)
        Me.CmdTextArea.Multiline = True
        Me.CmdTextArea.Name = "CmdTextArea"
        Me.CmdTextArea.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdTextArea.SelectedIndex = 0
        Me.CmdTextArea.Size = New System.Drawing.Size(651, 548)
        Me.CmdTextArea.TabIndex = 4
        '
        'DescriptionTab
        '
        Me.DescriptionTab.Controls.Add(Me.synopsis)
        Me.DescriptionTab.Controls.Add(Me.backBtn2)
        Me.DescriptionTab.Controls.Add(Me.descriptionText)
        Me.DescriptionTab.Controls.Add(Me.cmdNameBox2)
        Me.DescriptionTab.Location = New System.Drawing.Point(4, 4)
        Me.DescriptionTab.Name = "DescriptionTab"
        Me.DescriptionTab.Padding = New System.Windows.Forms.Padding(3)
        Me.DescriptionTab.Size = New System.Drawing.Size(643, 520)
        Me.DescriptionTab.TabIndex = 1
        Me.DescriptionTab.Text = "Description"
        Me.DescriptionTab.UseVisualStyleBackColor = True
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
        'descriptionText
        '
        Me.descriptionText.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptionText.Location = New System.Drawing.Point(0, 115)
        Me.descriptionText.Multiline = True
        Me.descriptionText.Name = "descriptionText"
        Me.descriptionText.Size = New System.Drawing.Size(643, 402)
        Me.descriptionText.TabIndex = 8
        Me.descriptionText.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmdNameBox2
        '
        Me.cmdNameBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cmdNameBox2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNameBox2.Location = New System.Drawing.Point(6, 3)
        Me.cmdNameBox2.Name = "cmdNameBox2"
        Me.cmdNameBox2.Size = New System.Drawing.Size(538, 35)
        Me.cmdNameBox2.TabIndex = 7
        '
        'UsageTab
        '
        Me.UsageTab.Controls.Add(Me.synopsis2)
        Me.UsageTab.Controls.Add(Me.backBtn)
        Me.UsageTab.Controls.Add(Me.usageText)
        Me.UsageTab.Controls.Add(Me.cmdNameBox)
        Me.UsageTab.Location = New System.Drawing.Point(4, 4)
        Me.UsageTab.Name = "UsageTab"
        Me.UsageTab.Padding = New System.Windows.Forms.Padding(3)
        Me.UsageTab.Size = New System.Drawing.Size(643, 520)
        Me.UsageTab.TabIndex = 0
        Me.UsageTab.Text = "Usage"
        Me.UsageTab.UseVisualStyleBackColor = True
        '
        'backBtn
        '
        Me.backBtn.BackColor = System.Drawing.Color.White
        Me.backBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backBtn.ForeColor = System.Drawing.Color.Black
        Me.backBtn.Location = New System.Drawing.Point(550, 7)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(76, 28)
        Me.backBtn.TabIndex = 6
        Me.backBtn.Text = "< Back"
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'usageText
        '
        Me.usageText.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usageText.Location = New System.Drawing.Point(0, 115)
        Me.usageText.Multiline = True
        Me.usageText.Name = "usageText"
        Me.usageText.Size = New System.Drawing.Size(643, 402)
        Me.usageText.TabIndex = 1
        Me.usageText.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmdNameBox
        '
        Me.cmdNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cmdNameBox.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNameBox.Location = New System.Drawing.Point(6, 3)
        Me.cmdNameBox.Name = "cmdNameBox"
        Me.cmdNameBox.Size = New System.Drawing.Size(538, 35)
        Me.cmdNameBox.TabIndex = 0
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
        'synopsis
        '
        Me.synopsis.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.synopsis.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.synopsis.Location = New System.Drawing.Point(4, 45)
        Me.synopsis.Multiline = True
        Me.synopsis.Name = "synopsis"
        Me.synopsis.Size = New System.Drawing.Size(638, 70)
        Me.synopsis.TabIndex = 10
        '
        'synopsis2
        '
        Me.synopsis2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.synopsis2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.synopsis2.Location = New System.Drawing.Point(4, 45)
        Me.synopsis2.Multiline = True
        Me.synopsis2.Name = "synopsis2"
        Me.synopsis2.Size = New System.Drawing.Size(638, 70)
        Me.synopsis2.TabIndex = 11
        '
        'Form1
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
        Me.Name = "Form1"
        Me.Text = "UNIX Man Pages"
        Me.CmdTextArea.ResumeLayout(False)
        Me.DescriptionTab.ResumeLayout(False)
        Me.DescriptionTab.PerformLayout()
        Me.UsageTab.ResumeLayout(False)
        Me.UsageTab.PerformLayout()
        CType(Me.TextSizeSlider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As TextBox
    Friend WithEvents CmdDirectory As TreeView
    Friend WithEvents searchText As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents CmdTextArea As TabControl
    Friend WithEvents UsageTab As TabPage
    Friend WithEvents DescriptionTab As TabPage
    Friend WithEvents TextSizeSlider As TrackBar
    Friend WithEvents Credits As TextBox
    Friend WithEvents usageText As TextBox
    Friend WithEvents cmdNameBox As TextBox
    Friend WithEvents backBtn As Button
    Friend WithEvents backBtn2 As Button
    Friend WithEvents descriptionText As TextBox
    Friend WithEvents cmdNameBox2 As TextBox
    Friend WithEvents synopsis As TextBox
    Friend WithEvents synopsis2 As TextBox
End Class
