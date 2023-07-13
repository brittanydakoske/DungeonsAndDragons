Imports MySql.Data.MySqlClient

Public Class MY_DB
    Private conn As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vbnet_dungeons_and_dragons_db")

    ReadOnly Property getConnection() As MySqlConnection
        Get
            Return conn
        End Get
    End Property

    Sub openConnection()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Sub closeConnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
End Class
