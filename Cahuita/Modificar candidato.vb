Public Class ModificarCandidato

    Private Sub btnRegistrarComentarios_Click(sender As Object, e As EventArgs) Handles btnRegistrarComentarios.Click
        'IR A LA BASE DE DATOS Y GUARDAR ESTA INFORMACION 
        If (tbID.Text = String.Empty) Then
            MessageBox.Show("Debe de seleccionar un candidato para generar un comentario")
        ElseIf tbComentarios.Text = String.Empty Then
            MessageBox.Show("El comentario no puede estar en blanco")
        Else
            MessageBox.Show("Se guardo el comentario " + tbComentarios.Text)
            crearComentario()
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAgendarEntrevista_Click(sender As Object, e As EventArgs) Handles btnAgendarEntrevista.Click
        'IR A LA BASE DE DATOS Y GUARDAR ESTA INFORMACION Y ENVIAR UN CORREO
        MessageBox.Show("Se agendo la entrevista el dia " + DpAgendarEntrevista.Value.ToShortDateString)




        'SEND EMAIL
    End Sub

    Private Sub btnAprobarCandidato_Click(sender As Object, e As EventArgs) Handles btnAprobarCandidato.Click
        'Ir a la base de datos y cambiar el estado del candidato a aprobado.
        Dim i As Integer
        i = dgvCandidatos.CurrentRow.Index
        If (tbID.Text = String.Empty) Then
            MessageBox.Show("Debe de seleccionar un candidato para aprobarlo")
        ElseIf dgvCandidatos.Item(4, i).Value = "Aprobado" Then
            MessageBox.Show("El candidato ya ha sido aprobado")
        Else
            actualizarEstado()
            MessageBox.Show("Se ha aprobado el candidato: " + tbNombre.Text)
            cargarDatos()
        End If

    End Sub

    Private Sub ModificarCandidato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Private Sub dgvCandidatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCandidatos.CellContentClick
        Dim i As Integer
        i = dgvCandidatos.CurrentRow.Index
        tbID.Text = dgvCandidatos.Item(0, i).Value
        tbNombre.Text = dgvCandidatos.Item(1, i).Value
        tbApellidos.Text = dgvCandidatos.Item(2, i).Value
        tbCorreo.Text = dgvCandidatos.Item(3, i).Value
        tbEstado.Text = dgvCandidatos.Item(4, i).Value
    End Sub

    Private Function cargarDatos()
        'Define conectividad a base de datos
        conexion.ConnectionString = servidor_datos
        conexion.Open()
        Dim adaptador As SqlClient.SqlDataAdapter
        Dim set_de_datos As New DataSet()
        Dim instruccionSQL As String
        instruccionSQL = "Select c.id as Id, c.nombre as Nombre, c.apellidos as Apellidos, c.correo as Correo, e.descripcion as Estado  from candidatos c join estadoscandidatos e on (e.id = c.estado and e.id!=3 )"
        'Ejecuta instruccion de consulta - muestra todos los candidatos
        dgvCandidatos.DataSource = ""
        adaptador = New SqlClient.SqlDataAdapter(instruccionSQL, conexion)
        adaptador.Fill(set_de_datos, "Candidatos")
        dgvCandidatos.DataSource = set_de_datos.Tables("Candidatos")
        conexion.Close()
    End Function

    Private Function crearComentario()
        conexion.ConnectionString = servidor_datos
        Dim instruccionSQL As String
        instruccionSQL = "INSERT INTO COMENTARIOS (COMENTARIO, USUARIO) VALUES ('1?','2?')"
        instruccionSQL = instruccionSQL.Replace("1?", tbComentarios.Text)
        instruccionSQL = instruccionSQL.Replace("2?", tbID.Text)
        Dim comando As New SqlClient.SqlCommand(instruccionSQL, conexion)
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Function

    Private Function actualizarEstado()
        conexion.ConnectionString = servidor_datos
        Dim instruccionSQL As String
        instruccionSQL = "Update CANDIDATOS SET ESTADO='1?' WHERE ID=2?"
        instruccionSQL = instruccionSQL.Replace("1?", 2) ' 2 ES IGUAL A APROBADO EN LA BASE DE DATOS
        instruccionSQL = instruccionSQL.Replace("2?", tbID.Text)
        Dim comando As New SqlClient.SqlCommand(instruccionSQL, conexion)
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Function
End Class