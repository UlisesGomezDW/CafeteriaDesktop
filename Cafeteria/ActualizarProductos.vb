Public Class ActualizarProductos

    Private Sub ActualizarProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Cafés")
        ComboBox1.Items.Add("Postres")
        ComboBox1.Items.Add("Malteadas")
        ComboBox1.Items.Add("Desayunos")
        ComboBox1.Items.Add("Otras Bebidas")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim id As Integer
        id = Me.Code.Text
        conn.Open()
        Select Case ComboBox1.SelectedIndex
            Case 0
                If Code.Text = "" Then
                    MsgBox("Escribe un código del producto, para continuar.", vbOKOnly + vbExclamation)
                Else
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conn
                    cmd.CommandText = "SELECT *  FROM Cafes WHERE Id =" & id & ""
                    Try
                        reader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()
                                Me.Nombre.Text = reader(1).ToString
                                Me.Desc.Text = reader(2).ToString
                                Me.Precio.Text = reader(3).ToString
                            End While
                        End If
                        reader.Close()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            Case 1
                If Code.Text = "" Then
                    MsgBox("Escribe un código del producto, para continuar.", vbOKOnly + vbExclamation)
                Else
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conn
                    cmd.CommandText = "SELECT *  FROM Postres WHERE Id =" & id & ""
                    Try
                        reader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()
                                Me.Nombre.Text = reader(1).ToString
                                Me.Desc.Text = reader(2).ToString
                                Me.Precio.Text = reader(3).ToString
                            End While
                        End If
                        reader.Close()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            Case 2
                If Code.Text = "" Then
                    MsgBox("Escribe un código del producto, para continuar.", vbOKOnly + vbExclamation)
                Else
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conn
                    cmd.CommandText = "SELECT *  FROM Malteadas WHERE Id =" & id & ""
                    Try
                        reader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()
                                Me.Nombre.Text = reader(1).ToString
                                Me.Desc.Text = reader(2).ToString
                                Me.Precio.Text = reader(3).ToString
                            End While
                        End If
                        reader.Close()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            Case 3
                If Code.Text = "" Then
                    MsgBox("Escribe un código del producto, para continuar.", vbOKOnly + vbExclamation)
                Else
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conn
                    cmd.CommandText = "SELECT *  FROM Desayunos WHERE Id =" & id & ""
                    Try
                        reader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()
                                Me.Nombre.Text = reader(1).ToString
                                Me.Desc.Text = reader(2).ToString
                                Me.Precio.Text = reader(3).ToString
                            End While
                        End If
                        reader.Close()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            Case 4
                If Code.Text = "" Then
                    MsgBox("Escribe un código del producto, para continuar.", vbOKOnly + vbExclamation)
                Else
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conn
                    cmd.CommandText = "SELECT *  FROM Otros WHERE Id =" & id & ""
                    Try
                        reader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()
                                Me.Nombre.Text = reader(1).ToString
                                Me.Desc.Text = reader(2).ToString
                                Me.Precio.Text = reader(3).ToString
                            End While
                        End If
                        reader.Close()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
        End Select
        conn.Close()
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
                cmd.CommandType = CommandType.Text
                cmd.Connection = conn
                sql = "UPDATE Cafes SET Nombre='" & nameProducto & "', Descripcion='" & descProducto & "', Precio=" & precioProducto & " "
                sql += "WHERE Id=" & id & ""
                cmd.CommandText = sql
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Datos Actualizados!", vbOKOnly + vbInformation)
                    Me.Hide()
                    AdminMenu.Show()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case 1
                cmd.CommandType = CommandType.Text
                cmd.Connection = conn
                sql = "UPDATE Postres SET Nombre='" & nameProducto & "', Descripcion='" & descProducto & "', Precio=" & precioProducto & " "
                sql += "WHERE Id=" & id & ""
                cmd.CommandText = sql
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Datos Actualizados!", vbOKOnly + vbInformation)
                    Me.Hide()
                    AdminMenu.Show()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case 2
                cmd.CommandType = CommandType.Text
                cmd.Connection = conn
                sql = "UPDATE Malteadas SET Nombre='" & nameProducto & "', Descripcion='" & descProducto & "', Precio=" & precioProducto & " "
                sql += "WHERE Id=" & id & ""
                cmd.CommandText = sql
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Datos Actualizados!", vbOKOnly + vbInformation)
                    Me.Hide()
                    AdminMenu.Show()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case 3
                cmd.CommandType = CommandType.Text
                cmd.Connection = conn
                sql = "UPDATE Desayunos SET Nombre='" & nameProducto & "', Descripcion='" & descProducto & "', Precio=" & precioProducto & " "
                sql += "WHERE Id=" & id & ""
                cmd.CommandText = sql
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Datos Actualizados!", vbOKOnly + vbInformation)
                    Me.Hide()
                    AdminMenu.Show()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Case 4
                cmd.CommandType = CommandType.Text
                cmd.Connection = conn
                sql = "UPDATE Otros SET Nombre='" & nameProducto & "', Descripcion='" & descProducto & "', Precio=" & precioProducto & " "
                sql += "WHERE Id=" & id & ""
                cmd.CommandText = sql
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Datos Actualizados!", vbOKOnly + vbInformation)
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