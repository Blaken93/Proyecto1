Imports System.Data.SqlClient

Public Class login
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If validarUsuario(tbUsuario.Text, tbContraseña.Text) Then
            MessageBox.Show("Acceso permitido")
        Else
            MessageBox.Show("Acceso denegado")
        End If

    End Sub

    Private Function validarUsuario(email As String,
                               contrasena As String
                               ) As Boolean
        conexion.ConnectionString = servidor_datos
        conexion.Open()
        Dim instruccionSQL As String
        instruccionSQL = "select * from USUARIOS where correo='" + email + "' and contrasena='" + contrasena + "'"

        Dim myCommand As New SqlCommand(instruccionSQL, conexion)
        Dim myReader As SqlDataReader = myCommand.ExecuteReader()
        Try
            While myReader.Read()
                Return True
            End While
        Finally
            myReader.Close()
            conexion.Close()
        End Try
        Return False
    End Function

    Private Sub btnDesbloquearCuenta_Click(sender As Object, e As EventArgs) Handles btnDesbloquearCuenta.Click
        DesbloquearCuenta.Show()

    End Sub

    Private Sub btnOlvidoContraseña_Click(sender As Object, e As EventArgs) Handles btnOlvidoContraseña.Click
        OlvidoContrasena.Show()
    End Sub

    Private Sub btnCrearCuenta_Click(sender As Object, e As EventArgs) Handles btnCrearCuenta.Click
        Registro.Show()
    End Sub

End Class
