Public Class Login
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim conexion As New SqlClient.SqlConnection(servidor_datos)

        Dim Sql As Boolean = "Select * from USUARIOS where usuario = '" + tbUsuario.Text + "' And contrasena = '" + tbContraseña.Text + "'"

        Dim comando As New SqlClient.SqlCommand(SQL, conexion)
        conexion.Open()
        comando.ExecuteNonQuery()

        If Sql = True Then
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
