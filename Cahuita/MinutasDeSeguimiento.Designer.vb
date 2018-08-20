<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MinutasDeSeguimiento
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
        Me.lblMinutasDeSeguimiento = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.dtgComentarios = New System.Windows.Forms.DataGridView()
        Me.dtgCandidatos = New System.Windows.Forms.DataGridView()
        CType(Me.dtgComentarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgCandidatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMinutasDeSeguimiento
        '
        Me.lblMinutasDeSeguimiento.AutoSize = True
        Me.lblMinutasDeSeguimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutasDeSeguimiento.Location = New System.Drawing.Point(13, 13)
        Me.lblMinutasDeSeguimiento.Name = "lblMinutasDeSeguimiento"
        Me.lblMinutasDeSeguimiento.Size = New System.Drawing.Size(215, 24)
        Me.lblMinutasDeSeguimiento.TabIndex = 0
        Me.lblMinutasDeSeguimiento.Text = "Minutas de seguimiento:"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancelar.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(291, 497)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 27)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGuardar.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(389, 497)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(93, 27)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'dtgComentarios
        '
        Me.dtgComentarios.AllowUserToAddRows = False
        Me.dtgComentarios.AllowUserToDeleteRows = False
        Me.dtgComentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgComentarios.Location = New System.Drawing.Point(619, 49)
        Me.dtgComentarios.MultiSelect = False
        Me.dtgComentarios.Name = "dtgComentarios"
        Me.dtgComentarios.ReadOnly = True
        Me.dtgComentarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgComentarios.Size = New System.Drawing.Size(338, 413)
        Me.dtgComentarios.TabIndex = 20
        '
        'dtgCandidatos
        '
        Me.dtgCandidatos.AllowUserToAddRows = False
        Me.dtgCandidatos.AllowUserToDeleteRows = False
        Me.dtgCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCandidatos.Location = New System.Drawing.Point(39, 49)
        Me.dtgCandidatos.MultiSelect = False
        Me.dtgCandidatos.Name = "dtgCandidatos"
        Me.dtgCandidatos.ReadOnly = True
        Me.dtgCandidatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgCandidatos.Size = New System.Drawing.Size(500, 413)
        Me.dtgCandidatos.TabIndex = 21
        '
        'MinutasDeSeguimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 634)
        Me.Controls.Add(Me.dtgCandidatos)
        Me.Controls.Add(Me.dtgComentarios)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblMinutasDeSeguimiento)
        Me.Name = "MinutasDeSeguimiento"
        Me.Text = "Minutas de seguimiento"
        CType(Me.dtgComentarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgCandidatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMinutasDeSeguimiento As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents dtgComentarios As DataGridView
    Friend WithEvents dtgCandidatos As DataGridView
End Class
