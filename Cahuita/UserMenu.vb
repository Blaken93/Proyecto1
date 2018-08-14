Public Class UserMenu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show(login.usuario)
    End Sub

    Private Sub ModificarCandidatoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarCandidatoToolStripMenuItem.Click
        ModificarCandidato.Show()
    End Sub

    Private Sub AgendarPruebaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        SolicitarPrueba.Show()
    End Sub

    Private Sub ContratarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContratarEmpleadoToolStripMenuItem.Click
        ContratarEmpleados.Show()
    End Sub

    Private Sub MinutosDeSeguimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinutosDeSeguimientoToolStripMenuItem.Click
        MinutasDeSeguimiento.Show()
    End Sub

    Private Sub MiPerfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiPerfilToolStripMenuItem.Click
        Perfil.Show()
    End Sub

    Private Sub MiHistorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiHistorialToolStripMenuItem.Click
        Historial.Show()
    End Sub

    Private Sub SolicitarPruebaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolicitarPruebaToolStripMenuItem.Click
        SolicitarPrueba.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class