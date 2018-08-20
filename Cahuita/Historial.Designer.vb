<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Historial
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblHistorial = New System.Windows.Forms.Label()
        Me.dtgComentarios = New System.Windows.Forms.DataGridView()
        CType(Me.dtgComentarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancelar.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(350, 394)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 27)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'lblHistorial
        '
        Me.lblHistorial.AutoSize = True
        Me.lblHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHistorial.Location = New System.Drawing.Point(27, 12)
        Me.lblHistorial.Name = "lblHistorial"
        Me.lblHistorial.Size = New System.Drawing.Size(81, 24)
        Me.lblHistorial.TabIndex = 5
        Me.lblHistorial.Text = "Historial:"
        '
        'dtgComentarios
        '
        Me.dtgComentarios.AllowUserToAddRows = False
        Me.dtgComentarios.AllowUserToDeleteRows = False
        Me.dtgComentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgComentarios.Location = New System.Drawing.Point(31, 53)
        Me.dtgComentarios.MultiSelect = False
        Me.dtgComentarios.Name = "dtgComentarios"
        Me.dtgComentarios.ReadOnly = True
        Me.dtgComentarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgComentarios.Size = New System.Drawing.Size(696, 308)
        Me.dtgComentarios.TabIndex = 21
        '
        'Historial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dtgComentarios)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblHistorial)
        Me.Name = "Historial"
        Me.Text = "Mi historial"
        CType(Me.dtgComentarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblHistorial As Label
    Friend WithEvents dtgComentarios As DataGridView
End Class
