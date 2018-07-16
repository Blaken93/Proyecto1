Module Base_de_datos
    Public servidor_datos As String = "Data Source=DESKTOP-0APDQ9T\SQLEXPRESS;Initial Catalog=CAHUITA;Integrated Security=SSPI;"
    Public conexion As New SqlClient.SqlConnection(servidor_datos)
    'Esta variable permite pasar datos de un formulario a otro
    Public VCONSULTA As String = ""
End Module
