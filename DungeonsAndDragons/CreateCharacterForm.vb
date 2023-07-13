Imports System.Text.RegularExpressions ' Regular Expressions Namespace
Imports MySql.Data.MySqlClient

Public Class CreateCharacterForm
    Private Function NumbersOnly(e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Function

    Private Sub LevelTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LevelTextBox.KeyPress
        NumbersOnly(e)
    End Sub

    Private Sub ExperienceTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ExperiencePointsTextBox.KeyPress
        NumbersOnly(e)
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        'Declare Variables'
        Dim character As New GAME_CHARACTER()
        Dim stCharName As String
        Dim stClass As String
        Dim iLevel As Integer
        Dim stBackground As String
        Dim stPlayerName As String
        Dim stRace As String
        Dim stAlignment As String
        Dim iXP As Integer
        Dim stErrors As String 'Store Errors to display to users

        'Validate Input Format'
        stErrors = ""


        'Set Variables'
        stCharName = CharacterNameTextBox.Text
        stClass = ClassTextBox.Text
        iLevel = LevelTextBox.Text
        stBackground = BackgroundTextBox.Text
        stPlayerName = PlayerNameTextBox.Text
        stRace = RaceTextBox.Text
        stAlignment = AlignmentTextBox.Text
        iXP = ExperiencePointsTextBox.Text

        'Input Validation'
        If stCharName.Trim() = "" Or stClass.Trim() = "" Or LevelTextBox.Text.Trim() = "" Or stBackground.Trim() = "" _
            Or stPlayerName.Trim() = "" Or stRace.Trim() = "" Or stAlignment.Trim() = "" _
            Or ExperiencePointsTextBox.Text.Trim() = "" Then
            stErrors = "Make sure you've filled out every field."
        End If

        If stErrors = "" Then
            If character.InsertGameCharacter(stCharName, stClass, iLevel, stBackground, stPlayerName, stRace, stAlignment, iXP) Then
                MessageBox.Show("Character successfully created!")

                'Close Character Creation Form'
                Me.Close()
            Else
                MessageBox.Show("Error creating character.")
            End If
        Else
            MessageBox.Show(stErrors)
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class