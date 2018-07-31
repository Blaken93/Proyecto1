Module baseDatos
    '1- Definir nombre del servidor y la base de datos para conexion
    'servidor_datos = �Data Source=SP-LAB4-PROFE;Initial Catalog=PRUEBAS;Integrated Security=SSPI;�
    Public servidor_datos As String = "Data Source=den1.mssql3.gear.host;Initial Catalog=proyectolatina;User Id=proyectolatina;Password=Lb865N2?~IIq"

    '2- Definir una conexion para la base de datos
    Public conexion As New SqlClient.SqlConnection(servidor_datos)
    '3- Esta variable permite pasar datos de un formulario a otro
    Public VCONSULTA As String = ""
End Module
