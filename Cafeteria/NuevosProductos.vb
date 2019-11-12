Public Class NuevosProductos
    Private Sub NuevosProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Cafés")
        ComboBox1.Items.Add("Postres")
        ComboBox1.Items.Add("Malteadas")
        ComboBox1.Items.Add("Desayunos")
        ComboBox1.Items.Add("Otras Bebidas")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim nameProducto As String = ""
        Dim precioProducto As Integer
        Dim descProducto As String = ""
        Dim id As Integer

        precioProducto = Me.Precio.Text
        nameProducto = Me.Nombre.Text
        descProducto = Me.Desc.Text
        id = Me.Code.Text
        conn.Open()
        Select Case ComboBox1.SelectedIndex
            Case 0
                If Code.Text = "" Then
                    MsgBox("Escribe un código del producto, para continuar.", vbOKOnly + vbExclamation)
                ElseIf Nombre.Text = "" Then
                    MsgBox("Escribe el nombre del producto, para continuar.", vbOKOnly + vbExclamation)
                ElseIf Precio.Text = "" Then
                    MsgBox("Escribe el precio del producto, para continuar.", vbOKOnly + vbExclamation)
                ElseIf Desc.Text = "" Then
                    MsgBox("Escribe la descripción del producto, para continuar.", vbOKOnly + vbExclamation)
                Else
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conn
                    sql = "INSERT INTO Cafes(Id, Nombre, Descripcion, Precio) "
                    sql += "VALUES (" & id & ", '" & nameProducto & "','" & descProducto & "'," & precioProducto & ")"
                    cmd.CommandText = sql
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Datos Registrados!", vbOKOnly + vbInformation)
                        Me.Hide()
                        AdminMenu.Show()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            Case 1
                If Code.Text = "" Then
                    MsgBox("Escribe un código del producto, para continuar.", vbOKOnly + vbExclamation)
                ElseIf Nombre.Text = "" Then
                    MsgBox("Escribe el nombre del producto, para continuar.", vbOKOnly + vbExclamation)
                ElseIf Precio.Text = "" Then
                    MsgBox("Escribe el precio del producto, para continuar.", vbOKOnly + vbExclamation)
                ElseIf Desc.Text = "" Then
                    MsgBox("Escribe la descripción del producto, para continuar.", vbOKOnly + vbExclamation)
                Else
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conn
                    sql = "INSERT INTO Postres(Id, Nombre, Descripcion, Precio) "
                    sql += "VALUES (" & id & ", '" & nameProducto & "','" & descProducto & "'," & precioProducto & ")"
                    cmd.CommandText = sql
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Datos Registrados!", vbOKOnly + vbInformation)
                        Me.Hide()
                        AdminMenu.Show()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            Case 2
                If Code.Text = "" Then
                    MsgBox("Escribe un código del producto, para continuar.", vbOKOnly + vbExclamation)
                ElseIf Nombre.Text = "" Then
                    MsgBox("Escribe el nombre del producto, para continuar.", vbOKOnly + vbExclamation)
                ElseIf Precio.Text = "" Then
                    MsgBox("Escribe el precio del producto, para continuar.", vbOKOnly + vbExclamation)
                ElseIf Desc.Text = "" Then
                    MsgBox("Escribe la descripción del producto, para continuar.", vbOKOnly + vbExclamation)
                Else
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conn
                    sql = "INSERT INTO Malteadas(Id, Nombre, Descripcion, Precio) "
                    sql += "VALUES (" & id & ", '" & nameProducto & "','" & descProducto & "'," & precioProducto & ")"
                    cmd.CommandText = sql
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Datos Registrados!", vbOKOnly + vbInformation)
                        Me.Hide()
                        AdminMenu.Show()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            Case 3
                If Code.Text = "" Then
                    MsgBox("Escribe un código del producto, para continuar.", vbOKOnly + vbExclamation)
                ElseIf Nombre.Text = "" Then
                    MsgBox("Escribe el nombre del producto, para continuar.", vbOKOnly + vbExclamation)
                ElseIf Precio.Text = "" Then
                    MsgBox("Escribe el precio del producto, para continuar.", vbOKOnly + vbExclamation)
                ElseIf Desc.Text = "" Then
                    MsgBox("Escribe la descripción del producto, para continuar.", vbOKOnly + vbExclamation)
                Else
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conn
                    sql = "INSERT INTO Desayunos(Id, Nombre, Descripcion, Precio) "
                    sql += "VALUES (" & id & ", '" & nameProducto & "','" & descProducto & "'," & precioProducto & ")"
                    cmd.CommandText = sql
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Datos Registrados!", vbOKOnly + vbInformation)
                        Me.Hide()
                        AdminMenu.Show()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            Case 4
                If Code.Text = "" Then
                    MsgBox("Escribe un código del producto, para continuar.", vbOKOnly + vbExclamation)
                ElseIf Nombre.Text = "" Then
                    MsgBox("Escribe el nombre del producto, para continuar.", vbOKOnly + vbExclamation)
                ElseIf Precio.Text = "" Then
                    MsgBox("Escribe el precio del producto, para continuar.", vbOKOnly + vbExclamation)
                ElseIf Desc.Text = "" Then
                    MsgBox("Escribe la descripción del producto, para continuar.", vbOKOnly + vbExclamation)
                Else
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conn
                    sql = "INSERT INTO Otros(Id, Nombre, Descripcion, Precio) "
                    sql += "VALUES (" & id & ", '" & nameProducto & "','" & descProducto & "'," & precioProducto & ")"
                    cmd.CommandText = sql
                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Datos Registrados!", vbOKOnly + vbInformation)
                        Me.Hide()
                        AdminMenu.Show()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
        End Select
        conn.Close()
    End Sub


    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        AdminMenu.Show()
    End Sub
End Class