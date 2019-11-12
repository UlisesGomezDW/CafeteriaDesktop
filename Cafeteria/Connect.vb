Module Connect
    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Cafeteria.mdb; Persist Security Info=False")
    Public cmd As New OleDb.OleDbCommand
    Public reader As OleDb.OleDbDataReader
    Public sql As String = ""
    Public Sub conection()
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub ConsultaCafes()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Cafes"
        Try
            reader = cmd.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    MsgBox(reader(1).ToString)
                End While
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
