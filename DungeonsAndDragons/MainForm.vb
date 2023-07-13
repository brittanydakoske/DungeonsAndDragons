Public Class MainForm
    Private Sub AddNewCharacterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewCharacterToolStripMenuItem.Click
        Dim fCreateCharacter As New CreateCharacterForm()
        fCreateCharacter.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim character As New GAME_CHARACTER()

        CharactersDataGridView.ReadOnly = True
        CharactersDataGridView.RowTemplate.Height = 80
        CharactersDataGridView.DataSource = character.GetAllCharacters()
        CharactersDataGridView.AllowUserToAddRows = False
    End Sub

    Private Sub CharactersDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles CharactersDataGridView.DoubleClick
        'Update/Delete form with selected character'
        Dim fUpdateDeleteCharacter As New UpdateDeleteCharacterForm()

        'Data order => id, character_name, class, level, background, player_name, race, alignment, experience_points
        fUpdateDeleteCharacter.IdTextBox.Text = CharactersDataGridView.CurrentRow.Cells(0).Value.ToString
        fUpdateDeleteCharacter.CharacterNameTextBox.Text = CharactersDataGridView.CurrentRow.Cells(1).Value.ToString
        fUpdateDeleteCharacter.ClassTextBox.Text = CharactersDataGridView.CurrentRow.Cells(2).Value.ToString
        fUpdateDeleteCharacter.LevelTextBox.Text = CharactersDataGridView.CurrentRow.Cells(3).Value.ToString
        fUpdateDeleteCharacter.BackgroundTextBox.Text = CharactersDataGridView.CurrentRow.Cells(4).Value.ToString
        fUpdateDeleteCharacter.PlayerNameTextBox.Text = CharactersDataGridView.CurrentRow.Cells(5).Value.ToString
        fUpdateDeleteCharacter.RaceTextBox.Text = CharactersDataGridView.CurrentRow.Cells(6).Value.ToString
        fUpdateDeleteCharacter.AlignmentTextBox.Text = CharactersDataGridView.CurrentRow.Cells(7).Value.ToString
        fUpdateDeleteCharacter.ExperiencePointsTextBox.Text = CharactersDataGridView.CurrentRow.Cells(8).Value.ToString

        fUpdateDeleteCharacter.Show()
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        Dim character As New GAME_CHARACTER()

        CharactersDataGridView.ReadOnly = True
        CharactersDataGridView.RowTemplate.Height = 80
        CharactersDataGridView.DataSource = character.GetAllCharacters()
        CharactersDataGridView.AllowUserToAddRows = False
    End Sub
End Class