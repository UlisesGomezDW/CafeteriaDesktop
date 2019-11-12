Public Class VerProducto

    Private Sub VerProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Cafés")
        ComboBox1.Items.Add("Postres")
        ComboBox1.Items.Add("Malteadas")
        ComboBox1.Items.Add("Desayunos")
        ComboBox1.Items.Add("Otras Bebidas")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        conn.Open()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Select Case ComboBox1.SelectedIndex
            Case 0
                Dim strSql As String = "SELECT * FROM Cafes"
                Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
                ds.Tables.Add("Tabla")
                adp.Fill(ds.Tables("Tabla"))
                Me.DataGridView1.DataSource = ds.Tables("Tabla")
            Case 1
                Dim strSql As String = "SELECT * FROM Postres"
                Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
                ds.Tables.Add("Tabla")
                adp.Fill(ds.Tables("Tabla"))
                Me.DataGridView1.DataSource = ds.Tables("Tabla")
            Case 2
                Dim strSql As String = "SELECT * FROM Malteadas"
                Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
                ds.Tables.Add("Tabla")
                adp.Fill(ds.Tables("Tabla"))
                Me.DataGridView1.DataSource = ds.Tables("Tabla")
            Case 3
                Dim strSql As String = "SELECT * FROM Desayunos"
                Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
                ds.Tables.Add("Tabla")
                adp.Fill(ds.Tables("Tabla"))
                Me.DataGridView1.DataSource = ds.Tables("Tabla")
            Case 4
                Dim strSql As String = "SELECT * FROM Otros"
                Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
                ds.Tables.Add("Tabla")
                adp.Fill(ds.Tables("Tabla"))
                Me.DataGridView1.DataSource = ds.Tables("Tabla")
        End Select
        conn.Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        AdminMenu.Show()
    End Sub
End Class