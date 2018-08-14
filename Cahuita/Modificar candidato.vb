Public Class ModificarCandidato

    Private Sub btnRegistrarComentarios_Click(sender As Object, e As EventArgs) Handles btnRegistrarComentarios.Click
        'IR A LA BASE DE DATOS Y GUARDAR ESTA INFORMACION 
        MessageBox.Show("Se guardo el comentario " + tbComentarios.Text)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAgendarEntrevista_Click(sender As Object, e As EventArgs) Handles btnAgendarEntrevista.Click
        'IR A LA BASE DE DATOS Y GUARDAR ESTA INFORMACION Y ENVIAR UN CORREO
        MessageBox.Show("Se agendo la entrevista el dia " + DpAgendarEntrevista.Value.ToShortDateString)
    End Sub

    Private Sub btnAprobarCandidato_Click(sender As Object, e As EventArgs) Handles btnAprobarCandidato.Click
        'Ir a la base de datos y cambiar el estado del candidato a aprobado.
        MessageBox.Show("Se ha aprobado el candidato: " + tbNombre.Text)
    End Sub

    Private Sub ModificarCandidato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Define conectividad a base de datos
        conexion.ConnectionString = servidor_datos
        conexion.Open()
        Dim adaptador As SqlClient.SqlDataAdapter
        Dim set_de_datos As New DataSet()
        Dim instruccionSQL As String
        instruccionSQL = "select c.id as Id, c.nombre as Nombre, c.correo as Correo, e.descripcion as Estado  from candidatos c join estadoscandidatos e on (e.id = c.estado)"
        'Ejecuta instruccion de consulta - muestra todos los clientes
        dgvCandidatos.DataSource = ""
        adaptador = New SqlClient.SqlDataAdapter(instruccionSQL, conexion)
        adaptador.Fill(set_de_datos, "Candidatos")
        dgvCandidatos.DataSource = set_de_datos.Tables("Candidatos")
        conexion.Close()
    End Sub

    Private Sub dgvCandidatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCandidatos.CellContentClick
        Dim i As Integer
        i = dgvCandidatos.CurrentRow.Index
        tbID.Text = dgvCandidatos.Item(0, i).Value
        tbNombre.Text = dgvCandidatos.Item(1, i).Value
    End Sub
End Class