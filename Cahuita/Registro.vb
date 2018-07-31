Public Class Registro
    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        conexion.ConnectionString = servidor_datos
        Dim instruccionSQL As String
        instruccionSQL = "INSERT INTO USUARIOS (NOMBRE,APELLIDO,DIRECCION,CORREO,PROVINCIA,CONTRASENA,FECHA_NACIMIENTO) VALUES ('1?','2?','3?','4?','5?','6?','7?')"
        instruccionSQL = instruccionSQL.Replace("1?", tbNombre.Text)
        instruccionSQL = instruccionSQL.Replace("2?", tbApellidos.Text)
        instruccionSQL = instruccionSQL.Replace("3?", "NONE")
        instruccionSQL = instruccionSQL.Replace("4?", tbCorreo.Text)
        instruccionSQL = instruccionSQL.Replace("5?", "none")
        instruccionSQL = instruccionSQL.Replace("6?", tbContraseña.Text)
        instruccionSQL = instruccionSQL.Replace("7?", DpFechaDeNacimineto.Value.ToUniversalTime)


        Dim comando As New SqlClient.SqlCommand(instruccionSQL, conexion)

        '3.3 Abre la conexion a la base de datos
        conexion.Open()

        '3.4 Ejecuta el comando para sentencias SQL
        comando.ExecuteNonQuery()

    End Sub
End Class