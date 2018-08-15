<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContratarEmpleados
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
        Me.lblLista = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnContratarEmpleado = New System.Windows.Forms.Button()
        Me.dgvCandidatos = New System.Windows.Forms.DataGridView()
        CType(Me.dgvCandidatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLista
        '
        Me.lblLista.AutoSize = True
        Me.lblLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLista.Location = New System.Drawing.Point(13, 13)
        Me.lblLista.Name = "lblLista"
        Me.lblLista.Size = New System.Drawing.Size(52, 24)
        Me.lblLista.TabIndex = 0
        Me.lblLista.Text = "Lista:"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancelar.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(81, 389)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 27)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnContratarEmpleado
        '
        Me.btnContratarEmpleado.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnContratarEmpleado.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContratarEmpleado.Location = New System.Drawing.Point(227, 389)
        Me.btnContratarEmpleado.Name = "btnContratarEmpleado"
        Me.btnContratarEmpleado.Size = New System.Drawing.Size(140, 27)
        Me.btnContratarEmpleado.TabIndex = 3
        Me.btnContratarEmpleado.Text = "Contratar empleado"
        Me.btnContratarEmpleado.UseVisualStyleBackColor = False
        '
        'dgvCandidatos
        '
        Me.dgvCandidatos.AllowUserToAddRows = False
        Me.dgvCandidatos.AllowUserToDeleteRows = False
        Me.dgvCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCandidatos.Location = New System.Drawing.Point(56, 40)
        Me.dgvCandidatos.MultiSelect = False
        Me.dgvCandidatos.Name = "dgvCandidatos"
        Me.dgvCandidatos.ReadOnly = True
        Me.dgvCandidatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCandidatos.Size = New System.Drawing.Size(641, 316)
        Me.dgvCandidatos.TabIndex = 20
        '
        'ContratarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvCandidatos)
        Me.Controls.Add(Me.btnContratarEmpleado)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblLista)
        Me.Name = "ContratarEmpleados"
        Me.Text = "Contratar empleados"
        CType(Me.dgvCandidatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLista As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnContratarEmpleado As Button
    Friend WithEvents dgvCandidatos As DataGridView
End Class
