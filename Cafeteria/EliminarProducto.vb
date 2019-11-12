Public Class EliminarProducto

    Private Sub EliminarProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Cafés")
        ComboBox1.Items.Add("Postres")
        ComboBox1.Items.Add("Malteadas")
        ComboBox1.Items.Add("Desayunos")
        ComboBox1.Items.Add("Otras Bebidas")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim id As Integer
        id = Code.Text
        conn.Open()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Select Case ComboBox1.SelectedIndex
            Case 0
                If Code.Text = "" Then
                    MsgBox("Escribe un código del producto, para continuar.", vbOKOnly + vbExclamation)
                Else
                    Dim strSql As String = "SELECT * FROM Cafes WHERE Id=" & id & ""
                    Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
                    ds.Tables.Add("Tabla")
                    adp.Fill(ds.Tables("Tabla"))
                    Me.DataGridView1.DataSource = ds.Tables("Tabla")
                End If
            Case 1
                If Code.Text = "" Then
                    MsgBox("Escribe un código del producto, para continuar.", vbOKOnly + vbExclamation)
                Else
                    Dim strSql As String = "SELECT * FROM Cafes WHERE Id=" & id & ""
                    Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
                    ds.Tables.Add("Tabla")
                    adp.Fill(ds.Tables("Tabla"))
                    Me.DataGridView1.DataSource = ds.Tables("Tabla")
                End If
            Case 2
                If Code.Text = "" Then
                    MsgBox("Escribe un código del producto, para continuar.", vbOKOnly + vbExclamation)
                Else
                    Dim strSql As String = "SELECT * FROM Cafes WHERE Id=" & id & ""
                    Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
                    ds.Tables.Add("Tabla")
                    adp.Fill(ds.Tables("Tabla"))
                    Me.DataGridView1.DataSource = ds.Tables("Tabla")
                End If
            Case 3
                If Code.Text = "" Then
                    MsgBox("Escribe un código del producto, para continuar.", vbOKOnly + vbExclamation)
                Else
                    Dim strSql As String = "SELECT * FROM Cafes WHERE Id=" & id & ""
                    Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
                    ds.Tables.Add("Tabla")
                    adp.Fill(ds.Tables("Tabla"))
                    Me.DataGridView1.DataSource = ds.Tables("Tabla")
                End If
            Case 4
                If Code.Text = "" Then
                    MsgBox("Escribe un código del producto, para continuar.", vbOKOnly + vbExclamation)
                Else
                    Dim strSql As String = "SELECT * FROM Cafes WHERE Id=" & id & ""
                    Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
                    ds.Tables.Add("Tabla")
                    adp.Fill(ds.Tables("Tabla"))
                    Me.DataGridView1.DataSource = ds.Tables("Tabla")
                End If
        End Select
        conn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim id As Integer
        id = Me.Code.Text
        conn.Open()
        Select Case ComboBox1.SelectedIndex
            Case 0
                cmd.CommandType = CommandType.Text
                cmd.Connection = conn
                sql = "DELETE FROM Cafes "
                sql += "WHERE Id=" & id & ""
                cmd.CommandText = sql
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Producto Borrado!", vbOKOnly + vbInformation)
                    Me.Hide()
                    AdminMenu.Show()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case 1
                cmd.CommandType = CommandType.Text
                cmd.Connection = conn
                sql = "DELETE FROM Postres "
                sql += "WHERE Id=" & id & ""
                cmd.CommandText = sql
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Producto Borrado!", vbOKOnly + vbInformation)
                    Me.Hide()
                    AdminMenu.Show()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case 2
                cmd.CommandType = CommandType.Text
                cmd.Connection = conn
                sql = "DELETE FROM Malteadas "
                sql += "WHERE Id=" & id & ""
                cmd.CommandText = sql
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Producto Borrado!", vbOKOnly + vbInformation)
                    Me.Hide()
                    AdminMenu.Show()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case 3
                cmd.CommandType = CommandType.Text
                cmd.Connection = conn
                sql = "DELETE FROM Desayunos "
                sql += "WHERE Id=" & id & ""
                cmd.CommandText = sql
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Producto Borrado!", vbOKOnly + vbInformation)
                    Me.Hide()
                    AdminMenu.Show()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case 4
                cmd.CommandType = CommandType.Text
                cmd.Connection = conn
                sql = "DELETE FROM Otros "
                sql += "WHERE Id=" & id & ""
                cmd.CommandText = sql
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Producto Borrado!", vbOKOnly + vbInformation)
                    Me.Hide()
                    AdminMenu.Show()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
        End Select
        conn.Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        AdminMenu.Show()
    End Sub
End Class