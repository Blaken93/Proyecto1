Public Class MinutasDeSeguimiento
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub cargarDatos()
        'Define conectividad a base de datos
        conexion.ConnectionString = servidor_datos
        conexion.Open()
        Dim adaptador As SqlClient.SqlDataAdapter
        Dim set_de_datos As New DataSet()
        Dim instruccionSQL As String
        instruccionSQL = "Select c.id as Id, c.nombre as Nombre, c.apellidos as Apellidos, c.correo as Correo, e.descripcion as Estado  from candidatos c join estadoscandidatos e on (e.id = c.estado and e.id!=3 )"
        'Ejecuta instruccion de consulta - muestra todos los candidatos
        dtgCandidatos.DataSource = ""
        adaptador = New SqlClient.SqlDataAdapter(instruccionSQL, conexion)
        adaptador.Fill(set_de_datos, "Candidatos")
        dtgCandidatos.DataSource = set_de_datos.Tables("Candidatos")
        conexion.Close()
    End Sub

    Private Sub cargarDatosComentarios(id As String)
        'Define conectividad a base de datos
        conexion.ConnectionString = servidor_datos
        conexion.Open()
        Dim adaptador As SqlClient.SqlDataAdapter
        Dim set_de_datos As New DataSet()
        Dim instruccionSQL As String
        instruccionSQL = "Select Comentario from COMENTARIOS WHERE usuario='" + id + "'"
        'Ejecuta instruccion de consulta - muestra todos los candidatos
        dtgComentarios.DataSource = ""
        adaptador = New SqlClient.SqlDataAdapter(instruccionSQL, conexion)
        adaptador.Fill(set_de_datos, "Candidatos")
        dtgComentarios.DataSource = set_de_datos.Tables("Candidatos")
        conexion.Close()
    End Sub

    Private Sub MinutasDeSeguimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Private Sub dtgCandidatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgCandidatos.CellContentClick
        Dim i As Integer
        i = dtgCandidatos.CurrentRow.Index
        Dim id As String = dtgCandidatos.Item(0, i).Value
        cargarDatosComentarios(id)
    End Sub
End Class