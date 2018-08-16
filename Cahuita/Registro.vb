Imports System.Data.SqlClient

Public Class Registro
    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        Try
            If validarCamposBlancos() Then
                MessageBox.Show("Debe de llenar todos los campos")
            ElseIf Not validarContrasenas() Then
                MessageBox.Show("Las contraseñas deben de coincidir")
            ElseIf Not validarContratado() Then
                MessageBox.Show("Su correo no ha sido registrado como empleado")
            ElseIf validarUsuarioCreado() Then
                MessageBox.Show("Su correo ya fue registrado, proceda al login")
            Else
                CrearUsuario()
                MessageBox.Show("Empleado registrado correctamente")
                Me.Close()

            End If

        Catch ex As Exception
            MessageBox.Show("Hubo un problema al registrar el usuario por favor intente de nuevo")
        End Try
    End Sub

    Private Function validarUsuarioCreado() As Boolean
        conexion.ConnectionString = servidor_datos
        conexion.Open()
        Dim instruccionSQL As String
        instruccionSQL = "select * from empleados where correo='" + tbCorreo.Text + "'"
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

    Private Function validarContrasenas()
        Return tbContraseña.Text = tbVerificarContraseña.Text
    End Function

    Private Function validarCamposBlancos()
        Return tbApellidos.Text = String.Empty OrElse
            tbContraseña.Text = String.Empty OrElse
            tbCorreo.Text = String.Empty OrElse
            tbNombre.Text = String.Empty OrElse
            tbID.Text = String.Empty
    End Function

    Private Function validarContratado()
        conexion.ConnectionString = servidor_datos
        conexion.Open()
        Dim instruccionSQL As String
        instruccionSQL = "select * from candidatos where correo='" + tbCorreo.Text + "' and estado='3'" ' 3 ssignifica que esta contratado

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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class