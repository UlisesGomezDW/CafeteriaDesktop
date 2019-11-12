Public Class Otros

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        MenuCafes.Show()
    End Sub

    Private Sub Otros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn.Open()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Otros"
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Try
            reader = cmd.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    Me.ComboBox1.Items.Add(reader(1).ToString)
                End While
            End If
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        conn.Close()
    End Sub
End Class