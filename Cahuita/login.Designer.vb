<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.tbContraseña = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnOlvidoContraseña = New System.Windows.Forms.Button()
        Me.btnCrearCuenta = New System.Windows.Forms.Button()
        Me.btnDesbloquearCuenta = New System.Windows.Forms.Button()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectoDataSet = New Cahuita.ProyectoDataSet()
        Me.UsuariosTableAdapter = New Cahuita.ProyectoDataSetTableAdapters.UsuariosTableAdapter()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Palatino Linotype", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(248, 40)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(262, 65)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "CAHUITA"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(330, 121)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(79, 24)
        Me.lblUsuario.TabIndex = 1
        Me.lblUsuario.Text = "Usuario:"
        '
        'tbUsuario
        '
        Me.tbUsuario.Location = New System.Drawing.Point(259, 158)
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(234, 20)
        Me.tbUsuario.TabIndex = 2
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.Location = New System.Drawing.Point(315, 215)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(111, 24)
        Me.lblContraseña.TabIndex = 3
        Me.lblContraseña.Text = "Contraseña:"
        '
        'tbContraseña
        '
        Me.tbContraseña.Location = New System.Drawing.Point(259, 255)
        Me.tbContraseña.Name = "tbContraseña"
        Me.tbContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbContraseña.Size = New System.Drawing.Size(234, 20)
        Me.tbContraseña.TabIndex = 5
        '
        'btnIngresar
        '
        Me.btnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Location = New System.Drawing.Point(306, 322)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(142, 30)
        Me.btnIngresar.TabIndex = 6
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'btnOlvidoContraseña
        '
        Me.btnOlvidoContraseña.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOlvidoContraseña.Location = New System.Drawing.Point(306, 438)
        Me.btnOlvidoContraseña.Name = "btnOlvidoContraseña"
        Me.btnOlvidoContraseña.Size = New System.Drawing.Size(142, 34)
        Me.btnOlvidoContraseña.TabIndex = 7
        Me.btnOlvidoContraseña.Text = "Olvido contraseña"
        Me.btnOlvidoContraseña.UseVisualStyleBackColor = True
        '
        'btnCrearCuenta
        '
        Me.btnCrearCuenta.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearCuenta.Location = New System.Drawing.Point(306, 404)
        Me.btnCrearCuenta.Name = "btnCrearCuenta"
        Me.btnCrearCuenta.Size = New System.Drawing.Size(142, 28)
        Me.btnCrearCuenta.TabIndex = 8
        Me.btnCrearCuenta.Text = "Crear cuenta"
        Me.btnCrearCuenta.UseVisualStyleBackColor = True
        '
        'btnDesbloquearCuenta
        '
        Me.btnDesbloquearCuenta.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesbloquearCuenta.Location = New System.Drawing.Point(306, 478)
        Me.btnDesbloquearCuenta.Name = "btnDesbloquearCuenta"
        Me.btnDesbloquearCuenta.Size = New System.Drawing.Size(142, 40)
        Me.btnDesbloquearCuenta.TabIndex = 9
        Me.btnDesbloquearCuenta.Text = "Desbloquear cuenta"
        Me.btnDesbloquearCuenta.UseVisualStyleBackColor = True
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.ProyectoDataSet
        '
        'ProyectoDataSet
        '
        Me.ProyectoDataSet.DataSetName = "ProyectoDataSet"
        Me.ProyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 577)
        Me.Controls.Add(Me.btnDesbloquearCuenta)
        Me.Controls.Add(Me.btnCrearCuenta)
        Me.Controls.Add(Me.btnOlvidoContraseña)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.tbContraseña)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.tbUsuario)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "login"
        Me.Text = "Login"
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents tbUsuario As TextBox
    Friend WithEvents lblContraseña As Label
    Friend WithEvents tbContraseña As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnOlvidoContraseña As Button
    Friend WithEvents btnCrearCuenta As Button
    Friend WithEvents btnDesbloquearCuenta As Button
    Friend WithEvents ProyectoDataSet As ProyectoDataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As ProyectoDataSetTableAdapters.UsuariosTableAdapter
End Class
