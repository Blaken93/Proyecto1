<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historial
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
        Me.lbHistorial = New System.Windows.Forms.ListBox()
        Me.btnContratarEmpleado = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblHistorial = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbHistorial
        '
        Me.lbHistorial.FormattingEnabled = True
        Me.lbHistorial.Location = New System.Drawing.Point(96, 37)
        Me.lbHistorial.Name = "lbHistorial"
        Me.lbHistorial.Size = New System.Drawing.Size(573, 277)
        Me.lbHistorial.TabIndex = 8
        '
        'btnContratarEmpleado
        '
        Me.btnContratarEmpleado.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnContratarEmpleado.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContratarEmpleado.Location = New System.Drawing.Point(193, 335)
        Me.btnContratarEmpleado.Name = "btnContratarEmpleado"
        Me.btnContratarEmpleado.Size = New System.Drawing.Size(140, 27)
        Me.btnContratarEmpleado.TabIndex = 7
        Me.btnContratarEmpleado.Text = "Contratar empleado"
        Me.btnContratarEmpleado.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancelar.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(96, 335)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 27)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'lblHistorial
        '
        Me.lblHistorial.AutoSize = True
        Me.lblHistorial.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHistorial.Location = New System.Drawing.Point(27, 12)
        Me.lblHistorial.Name = "lblHistorial"
        Me.lblHistorial.Size = New System.Drawing.Size(92, 22)
        Me.lblHistorial.TabIndex = 5
        Me.lblHistorial.Text = "Historial:"
        '
        'Historial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbHistorial)
        Me.Controls.Add(Me.btnContratarEmpleado)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblHistorial)
        Me.Name = "Historial"
        Me.Text = "Mi historial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbHistorial As ListBox
    Friend WithEvents btnContratarEmpleado As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblHistorial As Label
End Class
