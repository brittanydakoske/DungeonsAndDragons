Imports System.Numerics
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify
Imports MySql.Data.MySqlClient

Public Class GAME_CHARACTER
    Dim db As New MY_DB()

    'Insert a new character'
    Public Function InsertGameCharacter(ByVal charname As String, ByVal charclass As String, ByVal level As Integer,
                                        ByVal background As String, ByVal pname As String, ByVal race As String,
                                        ByVal alignment As String, ByVal xp As Integer) As Boolean
        Dim sInsertCommand As String

        sInsertCommand = "INSERT INTO `game_character`(`character_name`, `class`, `level`, `background`, `player_name`, `race`, `alignment`, `experience_points`) VALUES (@cn, @cls, @lvl, @bg, @pn, @rc, @aln, @xp)"
        Dim command As New MySqlCommand(sInsertCommand, db.getConnection)

        '@cn, @cls, @lvl, @bg, @pn, @rc, @aln, @xp'
        command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = charname
        command.Parameters.Add("@cls", MySqlDbType.VarChar).Value = charclass
        command.Parameters.Add("@lvl", MySqlDbType.Int32).Value = level
        command.Parameters.Add("@bg", MySqlDbType.VarChar).Value = background
        command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = pname
        command.Parameters.Add("@rc", MySqlDbType.VarChar).Value = race
        command.Parameters.Add("@aln", MySqlDbType.VarChar).Value = alignment
        command.Parameters.Add("@xp", MySqlDbType.Int32).Value = xp

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If

        db.closeConnection()
    End Function

    'Get all characters'
    Function GetAllCharacters() As DataTable
        Dim command As New MySqlCommand("SELECT * FROM `game_character`")
        command.Connection = db.getConnection()

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        Return table

        db.closeConnection()
    End Function

    'Delete character by id'
    Function DeleteCharacter(ByVal id As Integer) As Boolean
        Dim sInsertCommand As String

        sInsertCommand = "DELETE FROM `game_character` WHERE `id` = @characterID"
        Dim command As New MySqlCommand(sInsertCommand, db.getConnection)

        '@cn, @cls, @lvl, @bg, @pn, @rc, @aln, @xp'
        command.Parameters.Add("@characterID", MySqlDbType.Int32).Value = id

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If

        db.closeConnection()
    End Function

    'Update a character'
    Public Function UpdateGameCharacter(ByVal id As Integer, ByVal charname As String, ByVal charclass As String,
                                        ByVal level As Integer, ByVal background As String, ByVal pname As String,
                                        ByVal race As String, ByVal alignment As String, ByVal xp As Integer) As Boolean
        Dim sInsertCommand As String

        sInsertCommand = "UPDATE `game_character` SET `character_name`=@cn,`class`=@cls,`level`=@lvl,`background`=@bg,`player_name`=@pn,`race`=@rc,`alignment`=@aln,`experience_points`=@xp WHERE `id`=@id"
        Dim command As New MySqlCommand(sInsertCommand, db.getConnection)

        '@cn, @cls, @lvl, @bg, @pn, @rc, @aln, @xp'
        command.Parameters.Add("@id", MySqlDbType.Int32).Value = id
        command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = charname
        command.Parameters.Add("@cls", MySqlDbType.VarChar).Value = charclass
        command.Parameters.Add("@lvl", MySqlDbType.Int32).Value = level
        command.Parameters.Add("@bg", MySqlDbType.VarChar).Value = background
        command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = pname
        command.Parameters.Add("@rc", MySqlDbType.VarChar).Value = race
        command.Parameters.Add("@aln", MySqlDbType.VarChar).Value = alignment
        command.Parameters.Add("@xp", MySqlDbType.Int32).Value = xp

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If

        db.closeConnection()
    End Function
End Class
