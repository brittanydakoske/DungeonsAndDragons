<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateDeleteCharacterForm
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
        LevelLabel = New Label()
        LevelTextBox = New TextBox()
        ClassTextBox = New TextBox()
        ClassLabel = New Label()
        PlayerNameTextBox = New TextBox()
        PlayerNameLabel = New Label()
        AlignmentLabel = New Label()
        AlignmentTextBox = New TextBox()
        ExperiencePointsTextBox = New TextBox()
        ExperiencePointsLabel = New Label()
        RaceTextBox = New TextBox()
        RaceLabel = New Label()
        BackgroundTextBox = New TextBox()
        BackgroundLabel = New Label()
        CharacterNameLabel = New Label()
        CharacterNameTextBox = New TextBox()
        CancelButton = New Button()
        SaveButton = New Button()
        DeleteButton = New Button()
        IdTextBox = New TextBox()
        IdLabel = New Label()
        SuspendLayout()
        ' 
        ' LevelLabel
        ' 
        LevelLabel.AutoSize = True
        LevelLabel.Location = New Point(207, 160)
        LevelLabel.Name = "LevelLabel"
        LevelLabel.Size = New Size(48, 23)
        LevelLabel.TabIndex = 26
        LevelLabel.Text = "Level"
        ' 
        ' LevelTextBox
        ' 
        LevelTextBox.Location = New Point(207, 186)
        LevelTextBox.Name = "LevelTextBox"
        LevelTextBox.Size = New Size(90, 30)
        LevelTextBox.TabIndex = 4
        ' 
        ' ClassTextBox
        ' 
        ClassTextBox.Location = New Point(12, 186)
        ClassTextBox.Name = "ClassTextBox"
        ClassTextBox.Size = New Size(185, 30)
        ClassTextBox.TabIndex = 3
        ' 
        ' ClassLabel
        ' 
        ClassLabel.AutoSize = True
        ClassLabel.Location = New Point(12, 160)
        ClassLabel.Name = "ClassLabel"
        ClassLabel.Size = New Size(48, 23)
        ClassLabel.TabIndex = 25
        ClassLabel.Text = "Class"
        ' 
        ' PlayerNameTextBox
        ' 
        PlayerNameTextBox.Location = New Point(12, 257)
        PlayerNameTextBox.Name = "PlayerNameTextBox"
        PlayerNameTextBox.Size = New Size(285, 30)
        PlayerNameTextBox.TabIndex = 6
        ' 
        ' PlayerNameLabel
        ' 
        PlayerNameLabel.AutoSize = True
        PlayerNameLabel.Location = New Point(12, 231)
        PlayerNameLabel.Name = "PlayerNameLabel"
        PlayerNameLabel.Size = New Size(107, 23)
        PlayerNameLabel.TabIndex = 28
        PlayerNameLabel.Text = "Player Name"
        ' 
        ' AlignmentLabel
        ' 
        AlignmentLabel.AutoSize = True
        AlignmentLabel.Location = New Point(12, 304)
        AlignmentLabel.Name = "AlignmentLabel"
        AlignmentLabel.Size = New Size(89, 23)
        AlignmentLabel.TabIndex = 30
        AlignmentLabel.Text = "Alignment"
        ' 
        ' AlignmentTextBox
        ' 
        AlignmentTextBox.Location = New Point(12, 330)
        AlignmentTextBox.Name = "AlignmentTextBox"
        AlignmentTextBox.Size = New Size(285, 30)
        AlignmentTextBox.TabIndex = 8
        ' 
        ' ExperiencePointsTextBox
        ' 
        ExperiencePointsTextBox.Location = New Point(307, 330)
        ExperiencePointsTextBox.Name = "ExperiencePointsTextBox"
        ExperiencePointsTextBox.Size = New Size(285, 30)
        ExperiencePointsTextBox.TabIndex = 9
        ' 
        ' ExperiencePointsLabel
        ' 
        ExperiencePointsLabel.AutoSize = True
        ExperiencePointsLabel.Location = New Point(307, 304)
        ExperiencePointsLabel.Name = "ExperiencePointsLabel"
        ExperiencePointsLabel.Size = New Size(143, 23)
        ExperiencePointsLabel.TabIndex = 31
        ExperiencePointsLabel.Text = "Experience Points"
        ' 
        ' RaceTextBox
        ' 
        RaceTextBox.Location = New Point(307, 257)
        RaceTextBox.Name = "RaceTextBox"
        RaceTextBox.Size = New Size(285, 30)
        RaceTextBox.TabIndex = 7
        ' 
        ' RaceLabel
        ' 
        RaceLabel.AutoSize = True
        RaceLabel.Location = New Point(307, 231)
        RaceLabel.Name = "RaceLabel"
        RaceLabel.Size = New Size(46, 23)
        RaceLabel.TabIndex = 29
        RaceLabel.Text = "Race"
        ' 
        ' BackgroundTextBox
        ' 
        BackgroundTextBox.Location = New Point(307, 186)
        BackgroundTextBox.Name = "BackgroundTextBox"
        BackgroundTextBox.Size = New Size(285, 30)
        BackgroundTextBox.TabIndex = 5
        ' 
        ' BackgroundLabel
        ' 
        BackgroundLabel.AutoSize = True
        BackgroundLabel.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BackgroundLabel.Location = New Point(307, 160)
        BackgroundLabel.Name = "BackgroundLabel"
        BackgroundLabel.Size = New Size(101, 23)
        BackgroundLabel.TabIndex = 27
        BackgroundLabel.Text = "Background"
        ' 
        ' CharacterNameLabel
        ' 
        CharacterNameLabel.AutoSize = True
        CharacterNameLabel.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        CharacterNameLabel.Location = New Point(112, 85)
        CharacterNameLabel.Name = "CharacterNameLabel"
        CharacterNameLabel.Size = New Size(135, 23)
        CharacterNameLabel.TabIndex = 24
        CharacterNameLabel.Text = "Character Name"
        ' 
        ' CharacterNameTextBox
        ' 
        CharacterNameTextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        CharacterNameTextBox.Location = New Point(112, 111)
        CharacterNameTextBox.Name = "CharacterNameTextBox"
        CharacterNameTextBox.Size = New Size(480, 30)
        CharacterNameTextBox.TabIndex = 1
        ' 
        ' CancelButton
        ' 
        CancelButton.Location = New Point(368, 378)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(105, 40)
        CancelButton.TabIndex = 11
        CancelButton.Text = "Cancel"
        CancelButton.UseVisualStyleBackColor = True
        ' 
        ' SaveButton
        ' 
        SaveButton.Location = New Point(479, 378)
        SaveButton.Name = "SaveButton"
        SaveButton.Size = New Size(113, 40)
        SaveButton.TabIndex = 10
        SaveButton.Text = "Save"
        SaveButton.UseVisualStyleBackColor = True
        ' 
        ' DeleteButton
        ' 
        DeleteButton.Location = New Point(257, 378)
        DeleteButton.Name = "DeleteButton"
        DeleteButton.Size = New Size(105, 40)
        DeleteButton.TabIndex = 12
        DeleteButton.Text = "Delete"
        DeleteButton.UseVisualStyleBackColor = True
        ' 
        ' IdTextBox
        ' 
        IdTextBox.Location = New Point(12, 111)
        IdTextBox.Name = "IdTextBox"
        IdTextBox.ReadOnly = True
        IdTextBox.Size = New Size(90, 30)
        IdTextBox.TabIndex = 0
        ' 
        ' IdLabel
        ' 
        IdLabel.AutoSize = True
        IdLabel.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        IdLabel.Location = New Point(12, 85)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New Size(25, 23)
        IdLabel.TabIndex = 24
        IdLabel.Text = "Id"
        ' 
        ' UpdateDeleteCharacterForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(604, 429)
        Controls.Add(IdTextBox)
        Controls.Add(DeleteButton)
        Controls.Add(CancelButton)
        Controls.Add(SaveButton)
        Controls.Add(LevelLabel)
        Controls.Add(LevelTextBox)
        Controls.Add(ClassTextBox)
        Controls.Add(ClassLabel)
        Controls.Add(PlayerNameTextBox)
        Controls.Add(PlayerNameLabel)
        Controls.Add(AlignmentLabel)
        Controls.Add(AlignmentTextBox)
        Controls.Add(ExperiencePointsTextBox)
        Controls.Add(ExperiencePointsLabel)
        Controls.Add(RaceTextBox)
        Controls.Add(RaceLabel)
        Controls.Add(BackgroundTextBox)
        Controls.Add(BackgroundLabel)
        Controls.Add(IdLabel)
        Controls.Add(CharacterNameLabel)
        Controls.Add(CharacterNameTextBox)
        Name = "UpdateDeleteCharacterForm"
        Text = "UpdateDeleteCharacterForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LevelLabel As Label
    Friend WithEvents LevelTextBox As TextBox
    Friend WithEvents ClassTextBox As TextBox
    Friend WithEvents ClassLabel As Label
    Friend WithEvents PlayerNameTextBox As TextBox
    Friend WithEvents PlayerNameLabel As Label
    Friend WithEvents AlignmentLabel As Label
    Friend WithEvents AlignmentTextBox As TextBox
    Friend WithEvents ExperiencePointsTextBox As TextBox
    Friend WithEvents ExperiencePointsLabel As Label
    Friend WithEvents RaceTextBox As TextBox
    Friend WithEvents RaceLabel As Label
    Friend WithEvents BackgroundTextBox As TextBox
    Friend WithEvents BackgroundLabel As Label
    Friend WithEvents CharacterNameLabel As Label
    Friend WithEvents CharacterNameTextBox As TextBox
    Friend WithEvents CancelButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents IdLabel As Label
End Class
