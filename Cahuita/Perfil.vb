Public Class Perfil

    Private Sub btnRegresarAlMenuPrincipal_Click(sender As Object, e As EventArgs) Handles btnRegresarAlMenuPrincipal.Click
        Me.Close()
    End Sub

    Private Sub Perfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Private Sub cargarDatos()
        conexion.ConnectionString = servidor_datos
        conexion.Open()
        Dim instruccionSQL As String
        instruccionSQL = "Select *  from Empleados where correo ='1?'"
        instruccionSQL = instruccionSQL.Replace("1?", login.usuario)

        Dim datos As New SqlClient.SqlCommand(instruccionSQL, conexion)
        Dim datosUser As SqlClient.SqlDataReader
        datosUser = datos.ExecuteReader()
        datosUser.Read()
        lblCorreoDatos.Text = datosUser("correo")
        lblApellidosDatos.Text = datosUser("apellido")
        lblFechaDeNacimientoDatos.Text = datosUser("fecha_Nacimiento")
        lblNombreDatos.Text = datosUser("nombre")
        lblIDDatos.Text = datosUser("id")
        lblDireccionDatos.Text = datosUser("direccion")
        conexion.Close()
    End Sub


End Class