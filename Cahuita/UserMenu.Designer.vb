<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CandidatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarCandidatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecursosHumanosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContratarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinutosDeSeguimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiPerfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiHistorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolicitarPruebaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CandidatosToolStripMenuItem, Me.RecursosHumanosToolStripMenuItem, Me.PerfilToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CandidatosToolStripMenuItem
        '
        Me.CandidatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarCandidatoToolStripMenuItem})
        Me.CandidatosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CandidatosToolStripMenuItem.Name = "CandidatosToolStripMenuItem"
        Me.CandidatosToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.CandidatosToolStripMenuItem.Text = "Candidatos"
        '
        'ModificarCandidatoToolStripMenuItem
        '
        Me.ModificarCandidatoToolStripMenuItem.Name = "ModificarCandidatoToolStripMenuItem"
        Me.ModificarCandidatoToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ModificarCandidatoToolStripMenuItem.Text = "Modificar candidato "
        '
        'RecursosHumanosToolStripMenuItem
        '
        Me.RecursosHumanosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContratarEmpleadoToolStripMenuItem, Me.MinutosDeSeguimientoToolStripMenuItem})
        Me.RecursosHumanosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecursosHumanosToolStripMenuItem.Name = "RecursosHumanosToolStripMenuItem"
        Me.RecursosHumanosToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.RecursosHumanosToolStripMenuItem.Text = "Recursos Humanos"
        '
        'ContratarEmpleadoToolStripMenuItem
        '
        Me.ContratarEmpleadoToolStripMenuItem.Name = "ContratarEmpleadoToolStripMenuItem"
        Me.ContratarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ContratarEmpleadoToolStripMenuItem.Text = "Contratar empleado"
        '
        'MinutosDeSeguimientoToolStripMenuItem
        '
        Me.MinutosDeSeguimientoToolStripMenuItem.Name = "MinutosDeSeguimientoToolStripMenuItem"
        Me.MinutosDeSeguimientoToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.MinutosDeSeguimientoToolStripMenuItem.Text = "Minutas de seguimiento"
        '
        'PerfilToolStripMenuItem
        '
        Me.PerfilToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MiPerfilToolStripMenuItem, Me.MiHistorialToolStripMenuItem, Me.SolicitarPruebaToolStripMenuItem})
        Me.PerfilToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerfilToolStripMenuItem.Name = "PerfilToolStripMenuItem"
        Me.PerfilToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.PerfilToolStripMenuItem.Text = "Perfil"
        '
        'MiPerfilToolStripMenuItem
        '
        Me.MiPerfilToolStripMenuItem.Name = "MiPerfilToolStripMenuItem"
        Me.MiPerfilToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.MiPerfilToolStripMenuItem.Text = "Mi perfil"
        '
        'MiHistorialToolStripMenuItem
        '
        Me.MiHistorialToolStripMenuItem.Name = "MiHistorialToolStripMenuItem"
        Me.MiHistorialToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.MiHistorialToolStripMenuItem.Text = "Mi historial"
        '
        'SolicitarPruebaToolStripMenuItem
        '
        Me.SolicitarPruebaToolStripMenuItem.Name = "SolicitarPruebaToolStripMenuItem"
        Me.SolicitarPruebaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.SolicitarPruebaToolStripMenuItem.Text = "Solicitar prueba"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'UserMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "UserMenu"
        Me.Text = "Menú"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CandidatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarCandidatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecursosHumanosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PerfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContratarEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinutosDeSeguimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MiPerfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MiHistorialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SolicitarPruebaToolStripMenuItem As ToolStripMenuItem
End Class
