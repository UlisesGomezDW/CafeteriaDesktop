Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Escribe tu nombre, para continuar.", vbOKOnly + vbExclamation)
        Else
            Module1.Nombre = TextBox1.Text
            Me.Hide()
            MenuCafes.Show()
        End If
    End Sub
End Class