<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContratarEmpleados
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
        Me.lblLista = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnContratarEmpleado = New System.Windows.Forms.Button()
        Me.clbEmpleados = New System.Windows.Forms.CheckedListBox()
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
        Me.btnCancelar.Location = New System.Drawing.Point(73, 336)
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
        Me.btnContratarEmpleado.Location = New System.Drawing.Point(174, 336)
        Me.btnContratarEmpleado.Name = "btnContratarEmpleado"
        Me.btnContratarEmpleado.Size = New System.Drawing.Size(140, 27)
        Me.btnContratarEmpleado.TabIndex = 3
        Me.btnContratarEmpleado.Text = "Contratar empleado"
        Me.btnContratarEmpleado.UseVisualStyleBackColor = False
        '
        'clbEmpleados
        '
        Me.clbEmpleados.FormattingEnabled = True
        Me.clbEmpleados.Location = New System.Drawing.Point(81, 47)
        Me.clbEmpleados.Name = "clbEmpleados"
        Me.clbEmpleados.Size = New System.Drawing.Size(487, 259)
        Me.clbEmpleados.TabIndex = 5
        '
        'ContratarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.clbEmpleados)
        Me.Controls.Add(Me.btnContratarEmpleado)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblLista)
        Me.Name = "ContratarEmpleados"
        Me.Text = "Contratar empleados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLista As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnContratarEmpleado As Button
    Friend WithEvents clbEmpleados As CheckedListBox
End Class
