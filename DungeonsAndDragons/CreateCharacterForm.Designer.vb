<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateCharacterForm
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
        CharacterNameTextBox = New TextBox()
        CharacterNameLabel = New Label()
        BackgroundLabel = New Label()
        BackgroundTextBox = New TextBox()
        RaceLabel = New Label()
        RaceTextBox = New TextBox()
        ExperiencePointsLabel = New Label()
        ExperiencePointsTextBox = New TextBox()
        AlignmentTextBox = New TextBox()
        AlignmentLabel = New Label()
        PlayerNameLabel = New Label()
        PlayerNameTextBox = New TextBox()
        ClassLabel = New Label()
        ClassTextBox = New TextBox()
        LevelTextBox = New TextBox()
        LevelLabel = New Label()
        SaveButton = New Button()
        CancelButton = New Button()
        SuspendLayout()
        ' 
        ' CharacterNameTextBox
        ' 
        CharacterNameTextBox.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        CharacterNameTextBox.Location = New Point(12, 99)
        CharacterNameTextBox.Name = "CharacterNameTextBox"
        CharacterNameTextBox.Size = New Size(580, 30)
        CharacterNameTextBox.TabIndex = 0
        ' 
        ' CharacterNameLabel
        ' 
        CharacterNameLabel.AutoSize = True
        CharacterNameLabel.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        CharacterNameLabel.Location = New Point(12, 73)
        CharacterNameLabel.Name = "CharacterNameLabel"
        CharacterNameLabel.Size = New Size(135, 23)
        CharacterNameLabel.TabIndex = 8
        CharacterNameLabel.Text = "Character Name"
        ' 
        ' BackgroundLabel
        ' 
        BackgroundLabel.AutoSize = True
        BackgroundLabel.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        BackgroundLabel.Location = New Point(307, 148)
        BackgroundLabel.Name = "BackgroundLabel"
        BackgroundLabel.Size = New Size(101, 23)
        BackgroundLabel.TabIndex = 11
        BackgroundLabel.Text = "Background"
        ' 
        ' BackgroundTextBox
        ' 
        BackgroundTextBox.Location = New Point(307, 174)
        BackgroundTextBox.Name = "BackgroundTextBox"
        BackgroundTextBox.Size = New Size(285, 30)
        BackgroundTextBox.TabIndex = 3
        ' 
        ' RaceLabel
        ' 
        RaceLabel.AutoSize = True
        RaceLabel.Location = New Point(307, 219)
        RaceLabel.Name = "RaceLabel"
        RaceLabel.Size = New Size(46, 23)
        RaceLabel.TabIndex = 13
        RaceLabel.Text = "Race"
        ' 
        ' RaceTextBox
        ' 
        RaceTextBox.Location = New Point(307, 245)
        RaceTextBox.Name = "RaceTextBox"
        RaceTextBox.Size = New Size(285, 30)
        RaceTextBox.TabIndex = 5
        ' 
        ' ExperiencePointsLabel
        ' 
        ExperiencePointsLabel.AutoSize = True
        ExperiencePointsLabel.Location = New Point(307, 292)
        ExperiencePointsLabel.Name = "ExperiencePointsLabel"
        ExperiencePointsLabel.Size = New Size(143, 23)
        ExperiencePointsLabel.TabIndex = 15
        ExperiencePointsLabel.Text = "Experience Points"
        ' 
        ' ExperiencePointsTextBox
        ' 
        ExperiencePointsTextBox.Location = New Point(307, 318)
        ExperiencePointsTextBox.Name = "ExperiencePointsTextBox"
        ExperiencePointsTextBox.Size = New Size(285, 30)
        ExperiencePointsTextBox.TabIndex = 7
        ' 
        ' AlignmentTextBox
        ' 
        AlignmentTextBox.Location = New Point(12, 318)
        AlignmentTextBox.Name = "AlignmentTextBox"
        AlignmentTextBox.Size = New Size(285, 30)
        AlignmentTextBox.TabIndex = 6
        ' 
        ' AlignmentLabel
        ' 
        AlignmentLabel.AutoSize = True
        AlignmentLabel.Location = New Point(12, 292)
        AlignmentLabel.Name = "AlignmentLabel"
        AlignmentLabel.Size = New Size(89, 23)
        AlignmentLabel.TabIndex = 14
        AlignmentLabel.Text = "Alignment"
        ' 
        ' PlayerNameLabel
        ' 
        PlayerNameLabel.AutoSize = True
        PlayerNameLabel.Location = New Point(12, 219)
        PlayerNameLabel.Name = "PlayerNameLabel"
        PlayerNameLabel.Size = New Size(107, 23)
        PlayerNameLabel.TabIndex = 12
        PlayerNameLabel.Text = "Player Name"
        ' 
        ' PlayerNameTextBox
        ' 
        PlayerNameTextBox.Location = New Point(12, 245)
        PlayerNameTextBox.Name = "PlayerNameTextBox"
        PlayerNameTextBox.Size = New Size(285, 30)
        PlayerNameTextBox.TabIndex = 4
        ' 
        ' ClassLabel
        ' 
        ClassLabel.AutoSize = True
        ClassLabel.Location = New Point(12, 148)
        ClassLabel.Name = "ClassLabel"
        ClassLabel.Size = New Size(48, 23)
        ClassLabel.TabIndex = 9
        ClassLabel.Text = "Class"
        ' 
        ' ClassTextBox
        ' 
        ClassTextBox.Location = New Point(12, 174)
        ClassTextBox.Name = "ClassTextBox"
        ClassTextBox.Size = New Size(185, 30)
        ClassTextBox.TabIndex = 1
        ' 
        ' LevelTextBox
        ' 
        LevelTextBox.Location = New Point(207, 174)
        LevelTextBox.Name = "LevelTextBox"
        LevelTextBox.Size = New Size(90, 30)
        LevelTextBox.TabIndex = 2
        ' 
        ' LevelLabel
        ' 
        LevelLabel.AutoSize = True
        LevelLabel.Location = New Point(207, 148)
        LevelLabel.Name = "LevelLabel"
        LevelLabel.Size = New Size(48, 23)
        LevelLabel.TabIndex = 10
        LevelLabel.Text = "Level"
        ' 
        ' SaveButton
        ' 
        SaveButton.Location = New Point(479, 368)
        SaveButton.Name = "SaveButton"
        SaveButton.Size = New Size(113, 40)
        SaveButton.TabIndex = 8
        SaveButton.Text = "Save"
        SaveButton.UseVisualStyleBackColor = True
        ' 
        ' CancelButton
        ' 
        CancelButton.Location = New Point(368, 368)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(105, 40)
        CancelButton.TabIndex = 9
        CancelButton.Text = "Cancel"
        CancelButton.UseVisualStyleBackColor = True
        ' 
        ' CreateCharacter
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(604, 437)
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
        Controls.Add(CharacterNameLabel)
        Controls.Add(CharacterNameTextBox)
        Name = "CreateCharacter"
        Text = "CreateCharacter"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CharacterNameTextBox As TextBox
    Friend WithEvents CharacterNameLabel As Label
    Friend WithEvents BackgroundLabel As Label
    Friend WithEvents BackgroundTextBox As TextBox
    Friend WithEvents RaceLabel As Label
    Friend WithEvents RaceTextBox As TextBox
    Friend WithEvents ExperiencePointsLabel As Label
    Friend WithEvents ExperiencePointsTextBox As TextBox
    Friend WithEvents AlignmentTextBox As TextBox
    Friend WithEvents AlignmentLabel As Label
    Friend WithEvents PlayerNameLabel As Label
    Friend WithEvents PlayerNameTextBox As TextBox
    Friend WithEvents ClassLabel As Label
    Friend WithEvents ClassTextBox As TextBox
    Friend WithEvents LevelTextBox As TextBox
    Friend WithEvents LevelLabel As Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents CancelButton As Button
End Class
