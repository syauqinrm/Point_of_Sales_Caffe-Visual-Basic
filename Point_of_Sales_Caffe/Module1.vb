Imports MySql.Data.MySqlClient
Module Module1
    Public conn As MySqlConnection
    Public dr As MySqlDataReader
    Public da As New MySqlDataAdapter
    Public cmd As MySqlCommand
    Public ds As DataSet

    Public Sub koneksi()
        Dim sqlconn As String
        sqlconn = "server=localhost; uid=root; password=; database=db_poscaffe"
        conn = New MySqlConnection(sqlconn)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
