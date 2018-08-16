<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Me.btnRegistrarse = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.tbVerificarContraseña = New System.Windows.Forms.TextBox()
        Me.tbContraseña = New System.Windows.Forms.TextBox()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.tbCorreo = New System.Windows.Forms.TextBox()
        Me.tbApellidos = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.lblVerificarContraseña = New System.Windows.Forms.Label()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblFechaDeNacimiento = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.DpFechaDeNacimineto = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btnRegistrarse
        '
        Me.btnRegistrarse.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRegistrarse.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarse.Location = New System.Drawing.Point(391, 507)
        Me.btnRegistrarse.Name = "btnRegistrarse"
        Me.btnRegistrarse.Size = New System.Drawing.Size(85, 34)
        Me.btnRegistrarse.TabIndex = 31
        Me.btnRegistrarse.Text = "Registrarse"
        Me.btnRegistrarse.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancelar.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(227, 507)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 34)
        Me.btnCancelar.TabIndex = 30
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'tbVerificarContraseña
        '
        Me.tbVerificarContraseña.Location = New System.Drawing.Point(235, 420)
        Me.tbVerificarContraseña.Multiline = True
        Me.tbVerificarContraseña.Name = "tbVerificarContraseña"
        Me.tbVerificarContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbVerificarContraseña.Size = New System.Drawing.Size(241, 25)
        Me.tbVerificarContraseña.TabIndex = 29
        '
        'tbContraseña
        '
        Me.tbContraseña.Location = New System.Drawing.Point(236, 357)
        Me.tbContraseña.Multiline = True
        Me.tbContraseña.Name = "tbContraseña"
        Me.tbContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbContraseña.Size = New System.Drawing.Size(240, 25)
        Me.tbContraseña.TabIndex = 28
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(236, 295)
        Me.tbID.Multiline = True
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(240, 25)
        Me.tbID.TabIndex = 27
        '
        'tbCorreo
        '
        Me.tbCorreo.Location = New System.Drawing.Point(236, 165)
        Me.tbCorreo.Multiline = True
        Me.tbCorreo.Name = "tbCorreo"
        Me.tbCorreo.Size = New System.Drawing.Size(240, 25)
        Me.tbCorreo.TabIndex = 25
        '
        'tbApellidos
        '
        Me.tbApellidos.Location = New System.Drawing.Point(236, 102)
        Me.tbApellidos.Multiline = True
        Me.tbApellidos.Name = "tbApellidos"
        Me.tbApellidos.Size = New System.Drawing.Size(240, 25)
        Me.tbApellidos.TabIndex = 24
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(236, 40)
        Me.tbNombre.Multiline = True
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(240, 25)
        Me.tbNombre.TabIndex = 23
        '
        'lblVerificarContraseña
        '
        Me.lblVerificarContraseña.AutoSize = True
        Me.lblVerificarContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerificarContraseña.Location = New System.Drawing.Point(232, 395)
        Me.lblVerificarContraseña.Name = "lblVerificarContraseña"
        Me.lblVerificarContraseña.Size = New System.Drawing.Size(155, 20)
        Me.lblVerificarContraseña.TabIndex = 22
        Me.lblVerificarContraseña.Text = "Verificar contraseña:"
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.Location = New System.Drawing.Point(232, 332)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(96, 20)
        Me.lblContraseña.TabIndex = 21
        Me.lblContraseña.Text = "Contraseña:"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(232, 270)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(79, 20)
        Me.lblID.TabIndex = 20
        Me.lblID.Text = "Direccion:"
        '
        'lblFechaDeNacimiento
        '
        Me.lblFechaDeNacimiento.AutoSize = True
        Me.lblFechaDeNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaDeNacimiento.Location = New System.Drawing.Point(233, 211)
        Me.lblFechaDeNacimiento.Name = "lblFechaDeNacimiento"
        Me.lblFechaDeNacimiento.Size = New System.Drawing.Size(161, 20)
        Me.lblFechaDeNacimiento.TabIndex = 19
        Me.lblFechaDeNacimiento.Text = "Fecha de nacimiento:"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(233, 144)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(61, 20)
        Me.lblCorreo.TabIndex = 18
        Me.lblCorreo.Text = "Correo:"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.Location = New System.Drawing.Point(233, 81)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(77, 20)
        Me.lblApellidos.TabIndex = 17
        Me.lblApellidos.Text = "Apellidos:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(233, 19)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(69, 20)
        Me.lblNombre.TabIndex = 32
        Me.lblNombre.Text = "Nombre:"
        '
        'DpFechaDeNacimineto
        '
        Me.DpFechaDeNacimineto.Location = New System.Drawing.Point(236, 232)
        Me.DpFechaDeNacimineto.Name = "DpFechaDeNacimineto"
        Me.DpFechaDeNacimineto.Size = New System.Drawing.Size(240, 20)
        Me.DpFechaDeNacimineto.TabIndex = 33
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 606)
        Me.Controls.Add(Me.DpFechaDeNacimineto)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnRegistrarse)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.tbVerificarContraseña)
        Me.Controls.Add(Me.tbContraseña)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.tbCorreo)
        Me.Controls.Add(Me.tbApellidos)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.lblVerificarContraseña)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblFechaDeNacimiento)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblApellidos)
        Me.Name = "Registro"
        Me.Text = "Registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegistrarse As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents tbVerificarContraseña As TextBox
    Friend WithEvents tbContraseña As TextBox
    Friend WithEvents tbID As TextBox
    Friend WithEvents tbCorreo As TextBox
    Friend WithEvents tbApellidos As TextBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents lblVerificarContraseña As Label
    Friend WithEvents lblContraseña As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblFechaDeNacimiento As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents DpFechaDeNacimineto As DateTimePicker
End Class
