Public Class ContratarEmpleados
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnContratarEmpleado_Click(sender As Object, e As EventArgs) Handles btnContratarEmpleado.Click
        ' Se guarda el nuevo usuario como empleado
        'Ir a la base de datos y cambiar el estado del candidato a aprobado.
        Dim i As Integer
        i = dgvCandidatos.CurrentRow.Index
        If (dgvCandidatos.Item(0, i).Value = Nothing) Then
            MessageBox.Show("Debe de seleccionar un candidato para aprobarlo")
        ElseIf dgvCandidatos.Item(4, i).Value = "Contratado" Then
            MessageBox.Show("El candidato ya fue contratado")
        ElseIf Not (dgvCandidatos.Item(4, i).Value = "Aprobado") Then
            MessageBox.Show("El candidato debe de ser aprobado primero")
        Else
            actualizarEstado(dgvCandidatos.Item(0, i).Value)
            MessageBox.Show("Se ha contratado el candidato: " + dgvCandidatos.Item(1, i).Value)
            cargarDatos()
        End If

    End Sub

    Private Sub ContratarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Private Function cargarDatos()
        'Define conectividad a base de datos
        conexion.ConnectionString = servidor_datos
        conexion.Open()
        Dim adaptador As SqlClient.SqlDataAdapter
        Dim set_de_datos As New DataSet()
        Dim instruccionSQL As String
        instruccionSQL = "Select c.id as Id, c.nombre as Nombre, c.apellidos as Apellidos, c.correo as Correo, e.descripcion as Estado  from candidatos c join estadoscandidatos e on (e.id = c.estado)"
        'Ejecuta instruccion de consulta - muestra todos los candidatos
        dgvCandidatos.DataSource = ""
        adaptador = New SqlClient.SqlDataAdapter(instruccionSQL, conexion)
        adaptador.Fill(set_de_datos, "Candidatos")
        dgvCandidatos.DataSource = set_de_datos.Tables("Candidatos")
        conexion.Close()
    End Function


    Private Function actualizarEstado(id As String)
        conexion.ConnectionString = servidor_datos
        Dim instruccionSQL As String
        instruccionSQL = "Update CANDIDATOS SET ESTADO='1?' WHERE ID=2?"
        instruccionSQL = instruccionSQL.Replace("1?", 3) ' 2 ES IGUAL A Contratado EN LA BASE DE DATOS
        instruccionSQL = instruccionSQL.Replace("2?", id)
        Dim comando As New SqlClient.SqlCommand(instruccionSQL, conexion)
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Function
End Class