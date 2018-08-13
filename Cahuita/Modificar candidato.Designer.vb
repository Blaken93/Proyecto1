<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarCandidato
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
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblComentarios = New System.Windows.Forms.Label()
        Me.lblAgendarEntrevista = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbApellidos = New System.Windows.Forms.TextBox()
        Me.tbCorreo = New System.Windows.Forms.TextBox()
        Me.tbEstado = New System.Windows.Forms.TextBox()
        Me.tbComentarios = New System.Windows.Forms.TextBox()
        Me.DpAgendarEntrevista = New System.Windows.Forms.DateTimePicker()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAgendarEntrevista = New System.Windows.Forms.Button()
        Me.btnAprobarCandidato = New System.Windows.Forms.Button()
        Me.btnRegistrarComentarios = New System.Windows.Forms.Button()
        Me.clbCandidatos = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(94, 7)
        Me.tbID.Multiline = True
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(182, 20)
        Me.tbID.TabIndex = 0
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(21, 12)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(30, 20)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "ID:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(2, 42)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(69, 20)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre:"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.Location = New System.Drawing.Point(2, 73)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(77, 20)
        Me.lblApellidos.TabIndex = 3
        Me.lblApellidos.Text = "Apellidos:"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(2, 103)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(61, 20)
        Me.lblCorreo.TabIndex = 4
        Me.lblCorreo.Text = "Correo:"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(2, 138)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(64, 20)
        Me.lblEstado.TabIndex = 5
        Me.lblEstado.Text = "Estado:"
        '
        'lblComentarios
        '
        Me.lblComentarios.AutoSize = True
        Me.lblComentarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComentarios.Location = New System.Drawing.Point(2, 171)
        Me.lblComentarios.Name = "lblComentarios"
        Me.lblComentarios.Size = New System.Drawing.Size(103, 20)
        Me.lblComentarios.TabIndex = 6
        Me.lblComentarios.Text = "Comentarios:"
        '
        'lblAgendarEntrevista
        '
        Me.lblAgendarEntrevista.AutoSize = True
        Me.lblAgendarEntrevista.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgendarEntrevista.Location = New System.Drawing.Point(2, 310)
        Me.lblAgendarEntrevista.Name = "lblAgendarEntrevista"
        Me.lblAgendarEntrevista.Size = New System.Drawing.Size(147, 20)
        Me.lblAgendarEntrevista.TabIndex = 7
        Me.lblAgendarEntrevista.Text = "Agendar entrevista:"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(94, 40)
        Me.tbNombre.Multiline = True
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(182, 20)
        Me.tbNombre.TabIndex = 8
        '
        'tbApellidos
        '
        Me.tbApellidos.Location = New System.Drawing.Point(94, 71)
        Me.tbApellidos.Multiline = True
        Me.tbApellidos.Name = "tbApellidos"
        Me.tbApellidos.Size = New System.Drawing.Size(182, 20)
        Me.tbApellidos.TabIndex = 9
        '
        'tbCorreo
        '
        Me.tbCorreo.Location = New System.Drawing.Point(94, 101)
        Me.tbCorreo.Multiline = True
        Me.tbCorreo.Name = "tbCorreo"
        Me.tbCorreo.Size = New System.Drawing.Size(182, 20)
        Me.tbCorreo.TabIndex = 10
        '
        'tbEstado
        '
        Me.tbEstado.Location = New System.Drawing.Point(94, 136)
        Me.tbEstado.Multiline = True
        Me.tbEstado.Name = "tbEstado"
        Me.tbEstado.Size = New System.Drawing.Size(182, 20)
        Me.tbEstado.TabIndex = 11
        '
        'tbComentarios
        '
        Me.tbComentarios.Location = New System.Drawing.Point(94, 192)
        Me.tbComentarios.Multiline = True
        Me.tbComentarios.Name = "tbComentarios"
        Me.tbComentarios.Size = New System.Drawing.Size(182, 100)
        Me.tbComentarios.TabIndex = 12
        '
        'DpAgendarEntrevista
        '
        Me.DpAgendarEntrevista.Location = New System.Drawing.Point(94, 343)
        Me.DpAgendarEntrevista.Name = "DpAgendarEntrevista"
        Me.DpAgendarEntrevista.Size = New System.Drawing.Size(182, 20)
        Me.DpAgendarEntrevista.TabIndex = 13
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancelar.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(12, 417)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 31)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAgendarEntrevista
        '
        Me.btnAgendarEntrevista.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAgendarEntrevista.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgendarEntrevista.Location = New System.Drawing.Point(93, 417)
        Me.btnAgendarEntrevista.Name = "btnAgendarEntrevista"
        Me.btnAgendarEntrevista.Size = New System.Drawing.Size(131, 31)
        Me.btnAgendarEntrevista.TabIndex = 16
        Me.btnAgendarEntrevista.Text = "Agendar entrevista "
        Me.btnAgendarEntrevista.UseVisualStyleBackColor = False
        '
        'btnAprobarCandidato
        '
        Me.btnAprobarCandidato.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAprobarCandidato.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAprobarCandidato.Location = New System.Drawing.Point(230, 417)
        Me.btnAprobarCandidato.Name = "btnAprobarCandidato"
        Me.btnAprobarCandidato.Size = New System.Drawing.Size(132, 31)
        Me.btnAprobarCandidato.TabIndex = 17
        Me.btnAprobarCandidato.Text = "Aprobar candidato"
        Me.btnAprobarCandidato.UseVisualStyleBackColor = False
        '
        'btnRegistrarComentarios
        '
        Me.btnRegistrarComentarios.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRegistrarComentarios.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarComentarios.Location = New System.Drawing.Point(368, 417)
        Me.btnRegistrarComentarios.Name = "btnRegistrarComentarios"
        Me.btnRegistrarComentarios.Size = New System.Drawing.Size(150, 31)
        Me.btnRegistrarComentarios.TabIndex = 18
        Me.btnRegistrarComentarios.Text = "Registrar comentarios"
        Me.btnRegistrarComentarios.UseVisualStyleBackColor = False
        '
        'clbCandidatos
        '
        Me.clbCandidatos.FormattingEnabled = True
        Me.clbCandidatos.Location = New System.Drawing.Point(312, 7)
        Me.clbCandidatos.Name = "clbCandidatos"
        Me.clbCandidatos.Size = New System.Drawing.Size(487, 259)
        Me.clbCandidatos.TabIndex = 19
        '
        'ModificarCandidato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 512)
        Me.Controls.Add(Me.clbCandidatos)
        Me.Controls.Add(Me.btnRegistrarComentarios)
        Me.Controls.Add(Me.btnAprobarCandidato)
        Me.Controls.Add(Me.btnAgendarEntrevista)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.DpAgendarEntrevista)
        Me.Controls.Add(Me.tbComentarios)
        Me.Controls.Add(Me.tbEstado)
        Me.Controls.Add(Me.tbCorreo)
        Me.Controls.Add(Me.tbApellidos)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.lblAgendarEntrevista)
        Me.Controls.Add(Me.lblComentarios)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblApellidos)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.tbID)
        Me.Name = "ModificarCandidato"
        Me.Text = "Modificar candidato"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbID As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblComentarios As Label
    Friend WithEvents lblAgendarEntrevista As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbApellidos As TextBox
    Friend WithEvents tbCorreo As TextBox
    Friend WithEvents tbEstado As TextBox
    Friend WithEvents tbComentarios As TextBox
    Friend WithEvents DpAgendarEntrevista As DateTimePicker
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAgendarEntrevista As Button
    Friend WithEvents btnAprobarCandidato As Button
    Friend WithEvents btnRegistrarComentarios As Button
    Friend WithEvents clbCandidatos As CheckedListBox
End Class
