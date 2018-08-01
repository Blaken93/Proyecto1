<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SolicitarPrueba
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
        Me.DpSolicitarPrueba = New System.Windows.Forms.DateTimePicker()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblSolicitarPrueba = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DpSolicitarPrueba
        '
        Me.DpSolicitarPrueba.Location = New System.Drawing.Point(46, 75)
        Me.DpSolicitarPrueba.Name = "DpSolicitarPrueba"
        Me.DpSolicitarPrueba.Size = New System.Drawing.Size(200, 20)
        Me.DpSolicitarPrueba.TabIndex = 8
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGuardar.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(169, 147)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(93, 27)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'lblSolicitarPrueba
        '
        Me.lblSolicitarPrueba.AutoSize = True
        Me.lblSolicitarPrueba.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSolicitarPrueba.Location = New System.Drawing.Point(12, 9)
        Me.lblSolicitarPrueba.Name = "lblSolicitarPrueba"
        Me.lblSolicitarPrueba.Size = New System.Drawing.Size(140, 18)
        Me.lblSolicitarPrueba.TabIndex = 6
        Me.lblSolicitarPrueba.Text = "Solicitar prueba:"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancelar.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(35, 147)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 27)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'SolicitarPrueba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 262)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.DpSolicitarPrueba)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblSolicitarPrueba)
        Me.Name = "SolicitarPrueba"
        Me.Text = "Solicitar prueba"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DpSolicitarPrueba As DateTimePicker
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblSolicitarPrueba As Label
    Friend WithEvents btnCancelar As Button
End Class
