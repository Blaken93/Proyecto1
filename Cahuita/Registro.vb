Public Class Registro
    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        Try
            CrearUsuario()
            MessageBox.Show("Empleado registrado correctamente")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Hubo un problema al registrar el usuario por favor intente de nuevo")
        End Try
    End Sub

    Private Function CrearUsuario()
        conexion.ConnectionString = servidor_datos
        Dim instruccionSQL As String
        instruccionSQL = "INSERT INTO EMPLEADOS (NOMBRE,APELLIDO,DIRECCION,CORREO,PROVINCIA,CONTRASENA,FECHA_NACIMIENTO,TIPO) VALUES ('1?','2?','3?','4?','5?','6?','7?','8?')"
        instruccionSQL = instruccionSQL.Replace("1?", tbNombre.Text)
        instruccionSQL = instruccionSQL.Replace("2?", tbApellidos.Text)
        instruccionSQL = instruccionSQL.Replace("3?", tbID.Text)
        instruccionSQL = instruccionSQL.Replace("4?", tbCorreo.Text)
        instruccionSQL = instruccionSQL.Replace("5?", "none")
        instruccionSQL = instruccionSQL.Replace("6?", tbContraseña.Text)
        instruccionSQL = instruccionSQL.Replace("7?", DpFechaDeNacimineto.Value.ToUniversalTime)
        instruccionSQL = instruccionSQL.Replace("8?", 2) '1-Administrador 2-Empleado

        Dim comando As New SqlClient.SqlCommand(instruccionSQL, conexion)
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class