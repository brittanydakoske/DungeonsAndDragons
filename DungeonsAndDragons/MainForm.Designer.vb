<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        MenuStrip1 = New MenuStrip()
        CharactersToolStripMenuItem = New ToolStripMenuItem()
        AddNewCharacterToolStripMenuItem = New ToolStripMenuItem()
        CharactersDataGridView = New DataGridView()
        RefreshButton = New Button()
        MenuStrip1.SuspendLayout()
        CType(CharactersDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {CharactersToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1330, 31)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' CharactersToolStripMenuItem
        ' 
        CharactersToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddNewCharacterToolStripMenuItem})
        CharactersToolStripMenuItem.Name = "CharactersToolStripMenuItem"
        CharactersToolStripMenuItem.Size = New Size(105, 27)
        CharactersToolStripMenuItem.Text = "Characters"
        ' 
        ' AddNewCharacterToolStripMenuItem
        ' 
        AddNewCharacterToolStripMenuItem.Name = "AddNewCharacterToolStripMenuItem"
        AddNewCharacterToolStripMenuItem.Size = New Size(243, 28)
        AddNewCharacterToolStripMenuItem.Text = "Add New Character"
        ' 
        ' CharactersDataGridView
        ' 
        CharactersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        CharactersDataGridView.Location = New Point(12, 47)
        CharactersDataGridView.Name = "CharactersDataGridView"
        CharactersDataGridView.RowHeadersWidth = 51
        CharactersDataGridView.RowTemplate.Height = 32
        CharactersDataGridView.Size = New Size(1306, 362)
        CharactersDataGridView.TabIndex = 1
        ' 
        ' RefreshButton
        ' 
        RefreshButton.Location = New Point(588, 424)
        RefreshButton.Name = "RefreshButton"
        RefreshButton.Size = New Size(139, 53)
        RefreshButton.TabIndex = 2
        RefreshButton.Text = "Refresh"
        RefreshButton.UseVisualStyleBackColor = True
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1330, 489)
        Controls.Add(RefreshButton)
        Controls.Add(CharactersDataGridView)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "MainForm"
        Text = "MainForm"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(CharactersDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CharactersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewCharacterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CharactersDataGridView As DataGridView
    Friend WithEvents RefreshButton As Button
End Class
