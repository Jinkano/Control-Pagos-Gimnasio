<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevoEditarCliente
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
        Me.GbOtros = New System.Windows.Forms.GroupBox()
        Me.DtpFdi = New System.Windows.Forms.DateTimePicker()
        Me.LblFdi = New System.Windows.Forms.Label()
        Me.GbContacto = New System.Windows.Forms.GroupBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.LblDir = New System.Windows.Forms.Label()
        Me.LblEml = New System.Windows.Forms.Label()
        Me.LblTlf = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.LblEdad = New System.Windows.Forms.Label()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.DtpFdn = New System.Windows.Forms.DateTimePicker()
        Me.TxtEdad = New System.Windows.Forms.Label()
        Me.LblFdn = New System.Windows.Forms.Label()
        Me.LblApe = New System.Windows.Forms.Label()
        Me.LblNom = New System.Windows.Forms.Label()
        Me.GbOtros.SuspendLayout()
        Me.GbContacto.SuspendLayout()
        Me.GbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbOtros
        '
        Me.GbOtros.Controls.Add(Me.DtpFdi)
        Me.GbOtros.Controls.Add(Me.LblFdi)
        Me.GbOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbOtros.Location = New System.Drawing.Point(20, 496)
        Me.GbOtros.Name = "GbOtros"
        Me.GbOtros.Size = New System.Drawing.Size(480, 72)
        Me.GbOtros.TabIndex = 18
        Me.GbOtros.TabStop = False
        Me.GbOtros.Text = "Otros datos :"
        '
        'DtpFdi
        '
        Me.DtpFdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFdi.Location = New System.Drawing.Point(160, 32)
        Me.DtpFdi.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.DtpFdi.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.DtpFdi.Name = "DtpFdi"
        Me.DtpFdi.Size = New System.Drawing.Size(296, 22)
        Me.DtpFdi.TabIndex = 6
        '
        'LblFdi
        '
        Me.LblFdi.AutoSize = True
        Me.LblFdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFdi.Location = New System.Drawing.Point(24, 32)
        Me.LblFdi.Name = "LblFdi"
        Me.LblFdi.Size = New System.Drawing.Size(131, 16)
        Me.LblFdi.TabIndex = 48
        Me.LblFdi.Text = "Fecha de Inscripción"
        '
        'GbContacto
        '
        Me.GbContacto.Controls.Add(Me.TxtDireccion)
        Me.GbContacto.Controls.Add(Me.TxtEmail)
        Me.GbContacto.Controls.Add(Me.TxtTelefono)
        Me.GbContacto.Controls.Add(Me.LblDir)
        Me.GbContacto.Controls.Add(Me.LblEml)
        Me.GbContacto.Controls.Add(Me.LblTlf)
        Me.GbContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbContacto.Location = New System.Drawing.Point(20, 240)
        Me.GbContacto.Name = "GbContacto"
        Me.GbContacto.Size = New System.Drawing.Size(480, 240)
        Me.GbContacto.TabIndex = 17
        Me.GbContacto.TabStop = False
        Me.GbContacto.Text = "Contacto :"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.BackColor = System.Drawing.Color.Azure
        Me.TxtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtDireccion.Location = New System.Drawing.Point(24, 160)
        Me.TxtDireccion.MaxLength = 100
        Me.TxtDireccion.Multiline = True
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDireccion.Size = New System.Drawing.Size(432, 60)
        Me.TxtDireccion.TabIndex = 5
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.Azure
        Me.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtEmail.Location = New System.Drawing.Point(24, 104)
        Me.TxtEmail.MaxLength = 50
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(432, 22)
        Me.TxtEmail.TabIndex = 4
        Me.TxtEmail.WordWrap = False
        '
        'TxtTelefono
        '
        Me.TxtTelefono.BackColor = System.Drawing.Color.Azure
        Me.TxtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefono.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtTelefono.Location = New System.Drawing.Point(24, 48)
        Me.TxtTelefono.MaxLength = 15
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(432, 22)
        Me.TxtTelefono.TabIndex = 3
        Me.TxtTelefono.WordWrap = False
        '
        'LblDir
        '
        Me.LblDir.AutoSize = True
        Me.LblDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDir.Location = New System.Drawing.Point(24, 144)
        Me.LblDir.Name = "LblDir"
        Me.LblDir.Size = New System.Drawing.Size(64, 16)
        Me.LblDir.TabIndex = 49
        Me.LblDir.Text = "Dirección"
        '
        'LblEml
        '
        Me.LblEml.AutoSize = True
        Me.LblEml.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEml.Location = New System.Drawing.Point(24, 88)
        Me.LblEml.Name = "LblEml"
        Me.LblEml.Size = New System.Drawing.Size(45, 16)
        Me.LblEml.TabIndex = 48
        Me.LblEml.Text = "E-Mail"
        '
        'LblTlf
        '
        Me.LblTlf.AutoSize = True
        Me.LblTlf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTlf.Location = New System.Drawing.Point(24, 32)
        Me.LblTlf.Name = "LblTlf"
        Me.LblTlf.Size = New System.Drawing.Size(61, 16)
        Me.LblTlf.TabIndex = 47
        Me.LblTlf.Text = "Teléfono"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(524, 512)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(100, 50)
        Me.BtnCancelar.TabIndex = 21
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Location = New System.Drawing.Point(516, 96)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(100, 50)
        Me.BtnActualizar.TabIndex = 20
        Me.BtnActualizar.Text = "&Actualizar"
        Me.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(516, 32)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 50)
        Me.BtnGuardar.TabIndex = 19
        Me.BtnGuardar.Text = "&Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.LblEdad)
        Me.GbDatos.Controls.Add(Me.TxtApellido)
        Me.GbDatos.Controls.Add(Me.TxtNombre)
        Me.GbDatos.Controls.Add(Me.DtpFdn)
        Me.GbDatos.Controls.Add(Me.TxtEdad)
        Me.GbDatos.Controls.Add(Me.LblFdn)
        Me.GbDatos.Controls.Add(Me.LblApe)
        Me.GbDatos.Controls.Add(Me.LblNom)
        Me.GbDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbDatos.Location = New System.Drawing.Point(20, 24)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(480, 200)
        Me.GbDatos.TabIndex = 16
        Me.GbDatos.TabStop = False
        Me.GbDatos.Text = "Datos del cliente :"
        '
        'LblEdad
        '
        Me.LblEdad.AutoSize = True
        Me.LblEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEdad.Location = New System.Drawing.Point(344, 144)
        Me.LblEdad.Name = "LblEdad"
        Me.LblEdad.Size = New System.Drawing.Size(40, 16)
        Me.LblEdad.TabIndex = 47
        Me.LblEdad.Text = "Edad"
        '
        'TxtApellido
        '
        Me.TxtApellido.BackColor = System.Drawing.Color.Azure
        Me.TxtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellido.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtApellido.Location = New System.Drawing.Point(24, 104)
        Me.TxtApellido.MaxLength = 30
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(432, 22)
        Me.TxtApellido.TabIndex = 1
        Me.TxtApellido.WordWrap = False
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.Azure
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtNombre.Location = New System.Drawing.Point(24, 48)
        Me.TxtNombre.MaxLength = 30
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(432, 22)
        Me.TxtNombre.TabIndex = 0
        Me.TxtNombre.WordWrap = False
        '
        'DtpFdn
        '
        Me.DtpFdn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFdn.Location = New System.Drawing.Point(24, 160)
        Me.DtpFdn.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.DtpFdn.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.DtpFdn.Name = "DtpFdn"
        Me.DtpFdn.Size = New System.Drawing.Size(304, 22)
        Me.DtpFdn.TabIndex = 2
        Me.DtpFdn.Value = New Date(2000, 6, 15, 0, 0, 0, 0)
        '
        'TxtEdad
        '
        Me.TxtEdad.BackColor = System.Drawing.Color.Azure
        Me.TxtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEdad.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtEdad.Location = New System.Drawing.Point(344, 160)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(112, 22)
        Me.TxtEdad.TabIndex = 46
        Me.TxtEdad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblFdn
        '
        Me.LblFdn.AutoSize = True
        Me.LblFdn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFdn.Location = New System.Drawing.Point(24, 144)
        Me.LblFdn.Name = "LblFdn"
        Me.LblFdn.Size = New System.Drawing.Size(135, 16)
        Me.LblFdn.TabIndex = 40
        Me.LblFdn.Text = "Fecha de Nacimiento"
        '
        'LblApe
        '
        Me.LblApe.AutoSize = True
        Me.LblApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApe.Location = New System.Drawing.Point(24, 88)
        Me.LblApe.Name = "LblApe"
        Me.LblApe.Size = New System.Drawing.Size(57, 16)
        Me.LblApe.TabIndex = 39
        Me.LblApe.Text = "Apellido"
        '
        'LblNom
        '
        Me.LblNom.AutoSize = True
        Me.LblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNom.Location = New System.Drawing.Point(24, 32)
        Me.LblNom.Name = "LblNom"
        Me.LblNom.Size = New System.Drawing.Size(56, 16)
        Me.LblNom.TabIndex = 38
        Me.LblNom.Text = "Nombre"
        '
        'FrmNuevoEditarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 593)
        Me.Controls.Add(Me.GbOtros)
        Me.Controls.Add(Me.GbContacto)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.GbDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmNuevoEditarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NuevoEditarCliente"
        Me.GbOtros.ResumeLayout(False)
        Me.GbOtros.PerformLayout()
        Me.GbContacto.ResumeLayout(False)
        Me.GbContacto.PerformLayout()
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbOtros As GroupBox
    Friend WithEvents DtpFdi As DateTimePicker
    Friend WithEvents LblFdi As Label
    Friend WithEvents GbContacto As GroupBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents LblDir As Label
    Friend WithEvents LblEml As Label
    Friend WithEvents LblTlf As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents LblEdad As Label
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents DtpFdn As DateTimePicker
    Friend WithEvents TxtEdad As Label
    Friend WithEvents LblFdn As Label
    Friend WithEvents LblApe As Label
    Friend WithEvents LblNom As Label
End Class
