<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pruebas
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
        Me.lblAgendarPrueba = New System.Windows.Forms.Label()
        Me.lblRegistrarNotas = New System.Windows.Forms.Label()
        Me.btnAgendarPrueba = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEnviarNota = New System.Windows.Forms.Button()
        Me.DpAgendarPrueba = New System.Windows.Forms.DateTimePicker()
        Me.tbRegistrarNotas = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblAgendarPrueba
        '
        Me.lblAgendarPrueba.AutoSize = True
        Me.lblAgendarPrueba.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgendarPrueba.Location = New System.Drawing.Point(3, 9)
        Me.lblAgendarPrueba.Name = "lblAgendarPrueba"
        Me.lblAgendarPrueba.Size = New System.Drawing.Size(128, 20)
        Me.lblAgendarPrueba.TabIndex = 0
        Me.lblAgendarPrueba.Text = "Agendar prueba:"
        '
        'lblRegistrarNotas
        '
        Me.lblRegistrarNotas.AutoSize = True
        Me.lblRegistrarNotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrarNotas.Location = New System.Drawing.Point(3, 186)
        Me.lblRegistrarNotas.Name = "lblRegistrarNotas"
        Me.lblRegistrarNotas.Size = New System.Drawing.Size(122, 20)
        Me.lblRegistrarNotas.TabIndex = 1
        Me.lblRegistrarNotas.Text = "Registrar notas:"
        '
        'btnAgendarPrueba
        '
        Me.btnAgendarPrueba.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAgendarPrueba.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgendarPrueba.Location = New System.Drawing.Point(38, 96)
        Me.btnAgendarPrueba.Name = "btnAgendarPrueba"
        Me.btnAgendarPrueba.Size = New System.Drawing.Size(93, 27)
        Me.btnAgendarPrueba.TabIndex = 2
        Me.btnAgendarPrueba.Text = "Agendar"
        Me.btnAgendarPrueba.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancelar.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(38, 374)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(93, 28)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnEnviarNota
        '
        Me.btnEnviarNota.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEnviarNota.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarNota.Location = New System.Drawing.Point(181, 374)
        Me.btnEnviarNota.Name = "btnEnviarNota"
        Me.btnEnviarNota.Size = New System.Drawing.Size(95, 28)
        Me.btnEnviarNota.TabIndex = 4
        Me.btnEnviarNota.Text = "Registrar"
        Me.btnEnviarNota.UseVisualStyleBackColor = False
        '
        'DpAgendarPrueba
        '
        Me.DpAgendarPrueba.Location = New System.Drawing.Point(38, 56)
        Me.DpAgendarPrueba.Name = "DpAgendarPrueba"
        Me.DpAgendarPrueba.Size = New System.Drawing.Size(200, 20)
        Me.DpAgendarPrueba.TabIndex = 5
        '
        'tbRegistrarNotas
        '
        Me.tbRegistrarNotas.Location = New System.Drawing.Point(38, 217)
        Me.tbRegistrarNotas.Multiline = True
        Me.tbRegistrarNotas.Name = "tbRegistrarNotas"
        Me.tbRegistrarNotas.Size = New System.Drawing.Size(238, 113)
        Me.tbRegistrarNotas.TabIndex = 6
        '
        'Pruebas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 450)
        Me.Controls.Add(Me.tbRegistrarNotas)
        Me.Controls.Add(Me.DpAgendarPrueba)
        Me.Controls.Add(Me.btnEnviarNota)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAgendarPrueba)
        Me.Controls.Add(Me.lblRegistrarNotas)
        Me.Controls.Add(Me.lblAgendarPrueba)
        Me.Name = "Pruebas"
        Me.Text = "Pruebas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAgendarPrueba As Label
    Friend WithEvents lblRegistrarNotas As Label
    Friend WithEvents btnAgendarPrueba As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEnviarNota As Button
    Friend WithEvents DpAgendarPrueba As DateTimePicker
    Friend WithEvents tbRegistrarNotas As TextBox
End Class
