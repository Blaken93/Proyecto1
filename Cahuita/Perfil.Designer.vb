<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Perfil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Perfil))
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblFechaDeNacimiento = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblNombreDatos = New System.Windows.Forms.Label()
        Me.lblApellidosDatos = New System.Windows.Forms.Label()
        Me.lblFechaDeNacimientoDatos = New System.Windows.Forms.Label()
        Me.lblCorreoDatos = New System.Windows.Forms.Label()
        Me.lblIDDatos = New System.Windows.Forms.Label()
        Me.lblTelefonoDatos = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRegresarAlMenuPrincipal = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(13, 13)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(76, 18)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.Location = New System.Drawing.Point(13, 47)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(86, 18)
        Me.lblApellidos.TabIndex = 1
        Me.lblApellidos.Text = "Apellidos:"
        '
        'lblFechaDeNacimiento
        '
        Me.lblFechaDeNacimiento.AutoSize = True
        Me.lblFechaDeNacimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaDeNacimiento.Location = New System.Drawing.Point(13, 84)
        Me.lblFechaDeNacimiento.Name = "lblFechaDeNacimiento"
        Me.lblFechaDeNacimiento.Size = New System.Drawing.Size(179, 18)
        Me.lblFechaDeNacimiento.TabIndex = 2
        Me.lblFechaDeNacimiento.Text = "Fecha de nacimiento:"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(13, 118)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(69, 18)
        Me.lblCorreo.TabIndex = 3
        Me.lblCorreo.Text = "Correo:"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(13, 152)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(30, 18)
        Me.lblID.TabIndex = 4
        Me.lblID.Text = "ID:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(7, 191)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(82, 18)
        Me.lblTelefono.TabIndex = 5
        Me.lblTelefono.Text = "Teléfono:"
        '
        'lblNombreDatos
        '
        Me.lblNombreDatos.AutoSize = True
        Me.lblNombreDatos.Location = New System.Drawing.Point(122, 17)
        Me.lblNombreDatos.Name = "lblNombreDatos"
        Me.lblNombreDatos.Size = New System.Drawing.Size(39, 13)
        Me.lblNombreDatos.TabIndex = 6
        Me.lblNombreDatos.Text = "Label7"
        '
        'lblApellidosDatos
        '
        Me.lblApellidosDatos.AutoSize = True
        Me.lblApellidosDatos.Location = New System.Drawing.Point(122, 47)
        Me.lblApellidosDatos.Name = "lblApellidosDatos"
        Me.lblApellidosDatos.Size = New System.Drawing.Size(39, 13)
        Me.lblApellidosDatos.TabIndex = 7
        Me.lblApellidosDatos.Text = "Label8"
        '
        'lblFechaDeNacimientoDatos
        '
        Me.lblFechaDeNacimientoDatos.AutoSize = True
        Me.lblFechaDeNacimientoDatos.Location = New System.Drawing.Point(208, 88)
        Me.lblFechaDeNacimientoDatos.Name = "lblFechaDeNacimientoDatos"
        Me.lblFechaDeNacimientoDatos.Size = New System.Drawing.Size(39, 13)
        Me.lblFechaDeNacimientoDatos.TabIndex = 8
        Me.lblFechaDeNacimientoDatos.Text = "Label9"
        '
        'lblCorreoDatos
        '
        Me.lblCorreoDatos.AutoSize = True
        Me.lblCorreoDatos.Location = New System.Drawing.Point(88, 118)
        Me.lblCorreoDatos.Name = "lblCorreoDatos"
        Me.lblCorreoDatos.Size = New System.Drawing.Size(45, 13)
        Me.lblCorreoDatos.TabIndex = 9
        Me.lblCorreoDatos.Text = "Label10"
        '
        'lblIDDatos
        '
        Me.lblIDDatos.AutoSize = True
        Me.lblIDDatos.Location = New System.Drawing.Point(88, 152)
        Me.lblIDDatos.Name = "lblIDDatos"
        Me.lblIDDatos.Size = New System.Drawing.Size(45, 13)
        Me.lblIDDatos.TabIndex = 10
        Me.lblIDDatos.Text = "Label11"
        '
        'lblTelefonoDatos
        '
        Me.lblTelefonoDatos.AutoSize = True
        Me.lblTelefonoDatos.Location = New System.Drawing.Point(95, 196)
        Me.lblTelefonoDatos.Name = "lblTelefonoDatos"
        Me.lblTelefonoDatos.Size = New System.Drawing.Size(45, 13)
        Me.lblTelefonoDatos.TabIndex = 11
        Me.lblTelefonoDatos.Text = "Label12"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(405, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 145)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'btnRegresarAlMenuPrincipal
        '
        Me.btnRegresarAlMenuPrincipal.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresarAlMenuPrincipal.Location = New System.Drawing.Point(186, 264)
        Me.btnRegresarAlMenuPrincipal.Name = "btnRegresarAlMenuPrincipal"
        Me.btnRegresarAlMenuPrincipal.Size = New System.Drawing.Size(181, 28)
        Me.btnRegresarAlMenuPrincipal.TabIndex = 13
        Me.btnRegresarAlMenuPrincipal.Text = "Regresar al menú principal"
        Me.btnRegresarAlMenuPrincipal.UseVisualStyleBackColor = True
        '
        'Perfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 344)
        Me.Controls.Add(Me.btnRegresarAlMenuPrincipal)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTelefonoDatos)
        Me.Controls.Add(Me.lblIDDatos)
        Me.Controls.Add(Me.lblCorreoDatos)
        Me.Controls.Add(Me.lblFechaDeNacimientoDatos)
        Me.Controls.Add(Me.lblApellidosDatos)
        Me.Controls.Add(Me.lblNombreDatos)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblFechaDeNacimiento)
        Me.Controls.Add(Me.lblApellidos)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "Perfil"
        Me.Text = "Mi perfil"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents lblFechaDeNacimiento As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblNombreDatos As Label
    Friend WithEvents lblApellidosDatos As Label
    Friend WithEvents lblFechaDeNacimientoDatos As Label
    Friend WithEvents lblCorreoDatos As Label
    Friend WithEvents lblIDDatos As Label
    Friend WithEvents lblTelefonoDatos As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnRegresarAlMenuPrincipal As Button
End Class
