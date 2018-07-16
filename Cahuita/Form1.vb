Public Class Form1
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim admin As String
        Dim pass As String
        admin = "Admin"
        pass = "12345"
        If tbUsuario.Text = admin And tbContraseña.Text = pass Then
            MessageBox.Show("Acceso permitido")
        Else
            MessageBox.Show("Acceso denegado")
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblUsuario.Click

    End Sub

    Private Sub lblTitulo_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbUsuario.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblContraseña.Click

    End Sub

    Private Sub btnDesbloquearCuenta_Click(sender As Object, e As EventArgs) Handles btnDesbloquearCuenta.Click
        Form4.Show()

    End Sub

    Private Sub btnOlvidoContraseña_Click(sender As Object, e As EventArgs) Handles btnOlvidoContraseña.Click
        Form3.Show()
    End Sub

    Private Sub btnCrearCuenta_Click(sender As Object, e As EventArgs) Handles btnCrearCuenta.Click
        Form2.Show()
    End Sub

    Private Sub tbContraseña_TextChanged(sender As Object, e As EventArgs) Handles tbContraseña.TextChanged

    End Sub
End Class
