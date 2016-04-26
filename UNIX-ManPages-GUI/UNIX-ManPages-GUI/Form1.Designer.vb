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
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("mkdir")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("cd")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Directories", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("mv")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("cp")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("cat")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Files", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12, TreeNode13})
        Me.Title = New System.Windows.Forms.TextBox()
        Me.CmdDirectory = New System.Windows.Forms.TreeView()
        Me.searchText = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.CmdTextArea = New System.Windows.Forms.TabControl()
        Me.DescriptionTab = New System.Windows.Forms.TabPage()
        Me.descriptionTextBox = New System.Windows.Forms.RichTextBox()
        Me.UsageTab = New System.Windows.Forms.TabPage()
        Me.usageTextBox = New System.Windows.Forms.RichTextBox()
        Me.TextSizeSlider = New System.Windows.Forms.TrackBar()
        Me.Credits = New System.Windows.Forms.TextBox()
        Me.CommonPanel = New System.Windows.Forms.Panel()
        Me.SynopsisTextBox = New System.Windows.Forms.RichTextBox()
        Me.CmdTitle = New System.Windows.Forms.RichTextBox()
        Me.CmdTextArea.SuspendLayout()
        Me.DescriptionTab.SuspendLayout()
        Me.UsageTab.SuspendLayout()
        CType(Me.TextSizeSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CommonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.White
        Me.Title.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Title.Cursor = System.Windows.Forms.Cursors.No
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.Black
        Me.Title.Location = New System.Drawing.Point(12, 12)
        Me.Title.Name = "Title"
        Me.Title.ReadOnly = True
        Me.Title.Size = New System.Drawing.Size(455, 69)
        Me.Title.TabIndex = 0
        Me.Title.Text = "UNIX Man Pages"
        '
        'CmdDirectory
        '
        Me.CmdDirectory.BackColor = System.Drawing.Color.White
        Me.CmdDirectory.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDirectory.ForeColor = System.Drawing.Color.Black
        Me.CmdDirectory.Location = New System.Drawing.Point(863, 12)
        Me.CmdDirectory.Name = "CmdDirectory"
        TreeNode8.Name = "mkdirNode"
        TreeNode8.Text = "mkdir"
        TreeNode9.Name = "cdNode"
        TreeNode9.Text = "cd"
        TreeNode10.Name = "DirectoriesRoot"
        TreeNode10.Text = "Directories"
        TreeNode11.Name = "mvNode"
        TreeNode11.Text = "mv"
        TreeNode12.Name = "cpNode"
        TreeNode12.Text = "cp"
        TreeNode13.Name = "catNode"
        TreeNode13.Text = "cat"
        TreeNode14.Name = "FilesRoot"
        TreeNode14.Text = "Files"
        Me.CmdDirectory.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode14})
        Me.CmdDirectory.Size = New System.Drawing.Size(251, 629)
        Me.CmdDirectory.TabIndex = 1
        '
        'searchText
        '
        Me.searchText.Location = New System.Drawing.Point(908, 491)
        Me.searchText.Name = "searchText"
        Me.searchText.Size = New System.Drawing.Size(160, 22)
        Me.searchText.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(950, 519)
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
        Me.CmdTextArea.Location = New System.Drawing.Point(12, 284)
        Me.CmdTextArea.Multiline = True
        Me.CmdTextArea.Name = "CmdTextArea"
        Me.CmdTextArea.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdTextArea.SelectedIndex = 0
        Me.CmdTextArea.Size = New System.Drawing.Size(845, 357)
        Me.CmdTextArea.TabIndex = 4
        '
        'DescriptionTab
        '
        Me.DescriptionTab.Controls.Add(Me.descriptionTextBox)
        Me.DescriptionTab.Location = New System.Drawing.Point(4, 4)
        Me.DescriptionTab.Name = "DescriptionTab"
        Me.DescriptionTab.Padding = New System.Windows.Forms.Padding(3)
        Me.DescriptionTab.Size = New System.Drawing.Size(837, 329)
        Me.DescriptionTab.TabIndex = 1
        Me.DescriptionTab.Text = "Description"
        Me.DescriptionTab.UseVisualStyleBackColor = True
        '
        'descriptionTextBox
        '
        Me.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.descriptionTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptionTextBox.Location = New System.Drawing.Point(13, -4)
        Me.descriptionTextBox.Name = "descriptionTextBox"
        Me.descriptionTextBox.Size = New System.Drawing.Size(828, 333)
        Me.descriptionTextBox.TabIndex = 11
        Me.descriptionTextBox.Text = ""
        '
        'UsageTab
        '
        Me.UsageTab.Controls.Add(Me.usageTextBox)
        Me.UsageTab.Location = New System.Drawing.Point(4, 4)
        Me.UsageTab.Name = "UsageTab"
        Me.UsageTab.Padding = New System.Windows.Forms.Padding(3)
        Me.UsageTab.Size = New System.Drawing.Size(837, 305)
        Me.UsageTab.TabIndex = 0
        Me.UsageTab.Text = "Usage"
        Me.UsageTab.UseVisualStyleBackColor = True
        '
        'usageTextBox
        '
        Me.usageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.usageTextBox.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usageTextBox.Location = New System.Drawing.Point(13, -4)
        Me.usageTextBox.Name = "usageTextBox"
        Me.usageTextBox.Size = New System.Drawing.Size(828, 333)
        Me.usageTextBox.TabIndex = 12
        Me.usageTextBox.Text = ""
        '
        'TextSizeSlider
        '
        Me.TextSizeSlider.BackColor = System.Drawing.Color.White
        Me.TextSizeSlider.LargeChange = 2
        Me.TextSizeSlider.Location = New System.Drawing.Point(639, 623)
        Me.TextSizeSlider.Maximum = 2
        Me.TextSizeSlider.Name = "TextSizeSlider"
        Me.TextSizeSlider.Size = New System.Drawing.Size(218, 56)
        Me.TextSizeSlider.TabIndex = 0
        '
        'Credits
        '
        Me.Credits.BackColor = System.Drawing.Color.White
        Me.Credits.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Credits.ForeColor = System.Drawing.Color.Black
        Me.Credits.Location = New System.Drawing.Point(681, 12)
        Me.Credits.Name = "Credits"
        Me.Credits.ReadOnly = True
        Me.Credits.Size = New System.Drawing.Size(176, 30)
        Me.Credits.TabIndex = 5
        Me.Credits.Text = "(c) 2016 Tanuj Sane" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'CommonPanel
        '
        Me.CommonPanel.BackColor = System.Drawing.Color.White
        Me.CommonPanel.Controls.Add(Me.SynopsisTextBox)
        Me.CommonPanel.Controls.Add(Me.CmdTitle)
        Me.CommonPanel.Location = New System.Drawing.Point(12, 87)
        Me.CommonPanel.Name = "CommonPanel"
        Me.CommonPanel.Size = New System.Drawing.Size(845, 191)
        Me.CommonPanel.TabIndex = 6
        '
        'SynopsisTextBox
        '
        Me.SynopsisTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SynopsisTextBox.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SynopsisTextBox.Location = New System.Drawing.Point(17, 42)
        Me.SynopsisTextBox.Name = "SynopsisTextBox"
        Me.SynopsisTextBox.Size = New System.Drawing.Size(827, 146)
        Me.SynopsisTextBox.TabIndex = 11
        Me.SynopsisTextBox.Text = ""
        '
        'CmdTitle
        '
        Me.CmdTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CmdTitle.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdTitle.Location = New System.Drawing.Point(17, 1)
        Me.CmdTitle.Name = "CmdTitle"
        Me.CmdTitle.Size = New System.Drawing.Size(824, 35)
        Me.CmdTitle.TabIndex = 10
        Me.CmdTitle.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1126, 653)
        Me.Controls.Add(Me.CommonPanel)
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
        Me.UsageTab.ResumeLayout(False)
        CType(Me.TextSizeSlider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CommonPanel.ResumeLayout(False)
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
    Friend WithEvents descriptionTextBox As RichTextBox
    Friend WithEvents usageTextBox As RichTextBox
    Friend WithEvents CommonPanel As Panel
    Friend WithEvents SynopsisTextBox As RichTextBox
    Friend WithEvents CmdTitle As RichTextBox
End Class
