<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNuevoEditarCliente
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
        Me.components = New System.ComponentModel.Container()
        Me.GbContacto = New System.Windows.Forms.GroupBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.DtpFdn = New System.Windows.Forms.DateTimePicker()
        Me.LblEdad = New System.Windows.Forms.Label()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtEdad = New System.Windows.Forms.Label()
        Me.LblFnacimiento = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.GbOtros = New System.Windows.Forms.GroupBox()
        Me.DgvListaNom = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblListMetod = New System.Windows.Forms.Label()
        Me.TxtMetodoPago = New System.Windows.Forms.Label()
        Me.BtnAddGrupo = New System.Windows.Forms.Button()
        Me.RbGrupo = New System.Windows.Forms.RadioButton()
        Me.LblMetodoPago = New System.Windows.Forms.Label()
        Me.RbMensual = New System.Windows.Forms.RadioButton()
        Me.DtpFdi = New System.Windows.Forms.DateTimePicker()
        Me.LblFinscripcion = New System.Windows.Forms.Label()
        Me.ToolTipText = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.RbDiario = New System.Windows.Forms.RadioButton()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.GbContacto.SuspendLayout()
        Me.GbDatos.SuspendLayout()
        Me.GbOtros.SuspendLayout()
        CType(Me.DgvListaNom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbContacto
        '
        Me.GbContacto.Controls.Add(Me.TxtDireccion)
        Me.GbContacto.Controls.Add(Me.TxtEmail)
        Me.GbContacto.Controls.Add(Me.TxtTelefono)
        Me.GbContacto.Controls.Add(Me.LblDireccion)
        Me.GbContacto.Controls.Add(Me.LblEmail)
        Me.GbContacto.Controls.Add(Me.LblTelefono)
        Me.GbContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbContacto.Location = New System.Drawing.Point(21, 260)
        Me.GbContacto.Margin = New System.Windows.Forms.Padding(12, 18, 0, 0)
        Me.GbContacto.Name = "GbContacto"
        Me.GbContacto.Size = New System.Drawing.Size(396, 271)
        Me.GbContacto.TabIndex = 1
        Me.GbContacto.TabStop = False
        Me.GbContacto.Text = "Datos de contacto :"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.BackColor = System.Drawing.Color.Azure
        Me.TxtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDireccion.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.TxtDireccion.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtDireccion.Location = New System.Drawing.Point(23, 169)
        Me.TxtDireccion.Margin = New System.Windows.Forms.Padding(0, 5, 0, 20)
        Me.TxtDireccion.MaxLength = 100
        Me.TxtDireccion.Multiline = True
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDireccion.Size = New System.Drawing.Size(350, 79)
        Me.TxtDireccion.TabIndex = 2
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.Azure
        Me.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtEmail.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.TxtEmail.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtEmail.Location = New System.Drawing.Point(23, 110)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.TxtEmail.MaxLength = 50
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(350, 26)
        Me.TxtEmail.TabIndex = 1
        Me.TxtEmail.WordWrap = False
        '
        'TxtTelefono
        '
        Me.TxtTelefono.BackColor = System.Drawing.Color.Azure
        Me.TxtTelefono.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.TxtTelefono.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtTelefono.Location = New System.Drawing.Point(23, 51)
        Me.TxtTelefono.Margin = New System.Windows.Forms.Padding(20, 5, 0, 0)
        Me.TxtTelefono.MaxLength = 15
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(350, 26)
        Me.TxtTelefono.TabIndex = 0
        Me.TxtTelefono.WordWrap = False
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDireccion.Location = New System.Drawing.Point(23, 148)
        Me.LblDireccion.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(64, 16)
        Me.LblDireccion.TabIndex = 5
        Me.LblDireccion.Text = "Dirección"
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.Location = New System.Drawing.Point(23, 89)
        Me.LblEmail.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(45, 16)
        Me.LblEmail.TabIndex = 4
        Me.LblEmail.Text = "E-Mail"
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelefono.Location = New System.Drawing.Point(23, 30)
        Me.LblTelefono.Margin = New System.Windows.Forms.Padding(20, 12, 0, 0)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(61, 16)
        Me.LblTelefono.TabIndex = 3
        Me.LblTelefono.Text = "Teléfono"
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.DtpFdn)
        Me.GbDatos.Controls.Add(Me.LblEdad)
        Me.GbDatos.Controls.Add(Me.TxtApellido)
        Me.GbDatos.Controls.Add(Me.TxtNombre)
        Me.GbDatos.Controls.Add(Me.TxtEdad)
        Me.GbDatos.Controls.Add(Me.LblFnacimiento)
        Me.GbDatos.Controls.Add(Me.LblApellido)
        Me.GbDatos.Controls.Add(Me.LblNombre)
        Me.GbDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbDatos.Location = New System.Drawing.Point(21, 21)
        Me.GbDatos.Margin = New System.Windows.Forms.Padding(12, 12, 0, 0)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(396, 221)
        Me.GbDatos.TabIndex = 0
        Me.GbDatos.TabStop = False
        Me.GbDatos.Text = "Datos del cliente :"
        '
        'DtpFdn
        '
        Me.DtpFdn.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFdn.CustomFormat = "' ' dd ' de  ' MMMM ' de  ' yyyy"
        Me.DtpFdn.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.DtpFdn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFdn.Location = New System.Drawing.Point(23, 172)
        Me.DtpFdn.Margin = New System.Windows.Forms.Padding(20, 6, 0, 20)
        Me.DtpFdn.Name = "DtpFdn"
        Me.DtpFdn.Size = New System.Drawing.Size(270, 26)
        Me.DtpFdn.TabIndex = 2
        '
        'LblEdad
        '
        Me.LblEdad.AutoSize = True
        Me.LblEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEdad.Location = New System.Drawing.Point(303, 148)
        Me.LblEdad.Margin = New System.Windows.Forms.Padding(0)
        Me.LblEdad.Name = "LblEdad"
        Me.LblEdad.Size = New System.Drawing.Size(40, 16)
        Me.LblEdad.TabIndex = 7
        Me.LblEdad.Text = "Edad"
        '
        'TxtApellido
        '
        Me.TxtApellido.BackColor = System.Drawing.Color.Azure
        Me.TxtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtApellido.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.TxtApellido.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtApellido.Location = New System.Drawing.Point(23, 112)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(20, 6, 0, 0)
        Me.TxtApellido.MaxLength = 30
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(350, 26)
        Me.TxtApellido.TabIndex = 1
        Me.TxtApellido.WordWrap = False
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.Azure
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtNombre.Location = New System.Drawing.Point(23, 52)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(20, 6, 20, 0)
        Me.TxtNombre.MaxLength = 30
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(350, 26)
        Me.TxtNombre.TabIndex = 0
        Me.TxtNombre.WordWrap = False
        '
        'TxtEdad
        '
        Me.TxtEdad.BackColor = System.Drawing.Color.Azure
        Me.TxtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEdad.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.TxtEdad.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtEdad.Location = New System.Drawing.Point(303, 172)
        Me.TxtEdad.Margin = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(70, 26)
        Me.TxtEdad.TabIndex = 3
        Me.TxtEdad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblFnacimiento
        '
        Me.LblFnacimiento.AutoSize = True
        Me.LblFnacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFnacimiento.Location = New System.Drawing.Point(23, 150)
        Me.LblFnacimiento.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.LblFnacimiento.Name = "LblFnacimiento"
        Me.LblFnacimiento.Size = New System.Drawing.Size(135, 16)
        Me.LblFnacimiento.TabIndex = 6
        Me.LblFnacimiento.Text = "Fecha de Nacimiento"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApellido.Location = New System.Drawing.Point(23, 90)
        Me.LblApellido.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(57, 16)
        Me.LblApellido.TabIndex = 5
        Me.LblApellido.Text = "Apellido"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(23, 30)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(20, 12, 0, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(56, 16)
        Me.LblNombre.TabIndex = 4
        Me.LblNombre.Text = "Nombre"
        '
        'GbOtros
        '
        Me.GbOtros.Controls.Add(Me.DgvListaNom)
        Me.GbOtros.Controls.Add(Me.LblListMetod)
        Me.GbOtros.Controls.Add(Me.TxtMetodoPago)
        Me.GbOtros.Controls.Add(Me.BtnAddGrupo)
        Me.GbOtros.Controls.Add(Me.RbGrupo)
        Me.GbOtros.Controls.Add(Me.LblMetodoPago)
        Me.GbOtros.Controls.Add(Me.RbMensual)
        Me.GbOtros.Controls.Add(Me.DtpFdi)
        Me.GbOtros.Controls.Add(Me.LblFinscripcion)
        Me.GbOtros.Controls.Add(Me.RbDiario)
        Me.GbOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbOtros.Location = New System.Drawing.Point(437, 21)
        Me.GbOtros.Margin = New System.Windows.Forms.Padding(20, 12, 12, 0)
        Me.GbOtros.Name = "GbOtros"
        Me.GbOtros.Size = New System.Drawing.Size(376, 409)
        Me.GbOtros.TabIndex = 2
        Me.GbOtros.TabStop = False
        Me.GbOtros.Text = "Otros datos :"
        '
        'DgvListaNom
        '
        Me.DgvListaNom.AllowUserToAddRows = False
        Me.DgvListaNom.AllowUserToDeleteRows = False
        Me.DgvListaNom.AllowUserToResizeColumns = False
        Me.DgvListaNom.AllowUserToResizeRows = False
        Me.DgvListaNom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvListaNom.ColumnHeadersHeight = 4
        Me.DgvListaNom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvListaNom.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DgvListaNom.Enabled = False
        Me.DgvListaNom.Location = New System.Drawing.Point(23, 288)
        Me.DgvListaNom.Margin = New System.Windows.Forms.Padding(0, 6, 0, 20)
        Me.DgvListaNom.MultiSelect = False
        Me.DgvListaNom.Name = "DgvListaNom"
        Me.DgvListaNom.ReadOnly = True
        Me.DgvListaNom.RowHeadersWidth = 4
        Me.DgvListaNom.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvListaNom.RowTemplate.DividerHeight = 2
        Me.DgvListaNom.RowTemplate.Height = 25
        Me.DgvListaNom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvListaNom.Size = New System.Drawing.Size(330, 98)
        Me.DgvListaNom.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column2.Width = 305
        '
        'LblListMetod
        '
        Me.LblListMetod.AutoSize = True
        Me.LblListMetod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblListMetod.Location = New System.Drawing.Point(20, 266)
        Me.LblListMetod.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.LblListMetod.Name = "LblListMetod"
        Me.LblListMetod.Size = New System.Drawing.Size(71, 16)
        Me.LblListMetod.TabIndex = 6
        Me.LblListMetod.Text = "Lista vacia"
        '
        'TxtMetodoPago
        '
        Me.TxtMetodoPago.BackColor = System.Drawing.Color.Azure
        Me.TxtMetodoPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMetodoPago.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.TxtMetodoPago.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtMetodoPago.Location = New System.Drawing.Point(23, 112)
        Me.TxtMetodoPago.Margin = New System.Windows.Forms.Padding(20, 6, 0, 0)
        Me.TxtMetodoPago.Name = "TxtMetodoPago"
        Me.TxtMetodoPago.Size = New System.Drawing.Size(330, 26)
        Me.TxtMetodoPago.TabIndex = 5
        Me.TxtMetodoPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnAddGrupo
        '
        Me.BtnAddGrupo.Enabled = False
        Me.BtnAddGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddGrupo.Image = Global.ControlPagosGimnasio.My.Resources.Resources.addgrupo
        Me.BtnAddGrupo.Location = New System.Drawing.Point(263, 214)
        Me.BtnAddGrupo.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnAddGrupo.Name = "BtnAddGrupo"
        Me.BtnAddGrupo.Size = New System.Drawing.Size(90, 40)
        Me.BtnAddGrupo.TabIndex = 4
        Me.BtnAddGrupo.UseVisualStyleBackColor = True
        '
        'RbGrupo
        '
        Me.RbGrupo.Appearance = System.Windows.Forms.Appearance.Button
        Me.RbGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbGrupo.Image = Global.ControlPagosGimnasio.My.Resources.Resources.grupfamily
        Me.RbGrupo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RbGrupo.Location = New System.Drawing.Point(23, 214)
        Me.RbGrupo.Margin = New System.Windows.Forms.Padding(0, 18, 0, 0)
        Me.RbGrupo.Name = "RbGrupo"
        Me.RbGrupo.Padding = New System.Windows.Forms.Padding(25, 0, 25, 0)
        Me.RbGrupo.Size = New System.Drawing.Size(230, 40)
        Me.RbGrupo.TabIndex = 3
        Me.RbGrupo.TabStop = True
        Me.RbGrupo.Text = "Grupo familiar"
        Me.RbGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RbGrupo.UseVisualStyleBackColor = True
        '
        'LblMetodoPago
        '
        Me.LblMetodoPago.AutoSize = True
        Me.LblMetodoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMetodoPago.Location = New System.Drawing.Point(23, 90)
        Me.LblMetodoPago.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.LblMetodoPago.Name = "LblMetodoPago"
        Me.LblMetodoPago.Size = New System.Drawing.Size(107, 16)
        Me.LblMetodoPago.TabIndex = 2
        Me.LblMetodoPago.Text = "Método de pago"
        '
        'RbMensual
        '
        Me.RbMensual.Appearance = System.Windows.Forms.Appearance.Button
        Me.RbMensual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbMensual.Image = Global.ControlPagosGimnasio.My.Resources.Resources.mensual
        Me.RbMensual.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RbMensual.Location = New System.Drawing.Point(193, 156)
        Me.RbMensual.Margin = New System.Windows.Forms.Padding(0)
        Me.RbMensual.Name = "RbMensual"
        Me.RbMensual.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.RbMensual.Size = New System.Drawing.Size(160, 40)
        Me.RbMensual.TabIndex = 2
        Me.RbMensual.TabStop = True
        Me.RbMensual.Text = "Mensual"
        Me.RbMensual.UseVisualStyleBackColor = True
        '
        'DtpFdi
        '
        Me.DtpFdi.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFdi.CustomFormat = "' ' dddd ', ' dd ' de ' MMMM ' de ' yyyy"
        Me.DtpFdi.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.DtpFdi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFdi.Location = New System.Drawing.Point(23, 51)
        Me.DtpFdi.Margin = New System.Windows.Forms.Padding(20, 5, 20, 0)
        Me.DtpFdi.Name = "DtpFdi"
        Me.DtpFdi.Size = New System.Drawing.Size(330, 26)
        Me.DtpFdi.TabIndex = 0
        '
        'LblFinscripcion
        '
        Me.LblFinscripcion.AutoSize = True
        Me.LblFinscripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFinscripcion.Location = New System.Drawing.Point(23, 30)
        Me.LblFinscripcion.Margin = New System.Windows.Forms.Padding(20, 12, 0, 0)
        Me.LblFinscripcion.Name = "LblFinscripcion"
        Me.LblFinscripcion.Size = New System.Drawing.Size(131, 16)
        Me.LblFinscripcion.TabIndex = 1
        Me.LblFinscripcion.Text = "Fecha de Inscripción"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Brown
        Me.BtnCancelar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.cancel_28x28
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(673, 461)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Padding = New System.Windows.Forms.Padding(0, 6, 0, 3)
        Me.BtnCancelar.Size = New System.Drawing.Size(140, 70)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'RbDiario
        '
        Me.RbDiario.Appearance = System.Windows.Forms.Appearance.Button
        Me.RbDiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbDiario.Image = Global.ControlPagosGimnasio.My.Resources.Resources.diario
        Me.RbDiario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RbDiario.Location = New System.Drawing.Point(23, 156)
        Me.RbDiario.Margin = New System.Windows.Forms.Padding(0, 18, 0, 0)
        Me.RbDiario.Name = "RbDiario"
        Me.RbDiario.Padding = New System.Windows.Forms.Padding(30, 0, 30, 0)
        Me.RbDiario.Size = New System.Drawing.Size(160, 40)
        Me.RbDiario.TabIndex = 1
        Me.RbDiario.TabStop = True
        Me.RbDiario.Text = "Diario"
        Me.RbDiario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RbDiario.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnGuardar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.guardar_28x32
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGuardar.Location = New System.Drawing.Point(513, 461)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Padding = New System.Windows.Forms.Padding(0, 4, 0, 3)
        Me.BtnGuardar.Size = New System.Drawing.Size(140, 70)
        Me.BtnGuardar.TabIndex = 3
        Me.BtnGuardar.Text = "&Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnActualizar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.actualizar_28x27
        Me.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnActualizar.Location = New System.Drawing.Point(513, 461)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(0, 0, 20, 20)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Padding = New System.Windows.Forms.Padding(0, 6, 0, 3)
        Me.BtnActualizar.Size = New System.Drawing.Size(140, 70)
        Me.BtnActualizar.TabIndex = 4
        Me.BtnActualizar.Text = "&Actualizar"
        Me.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'FrmNuevoEditarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 560)
        Me.Controls.Add(Me.GbContacto)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.GbDatos)
        Me.Controls.Add(Me.GbOtros)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmNuevoEditarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTRO Y ACTUALIZACIÓN DE USUARIOS"
        Me.GbContacto.ResumeLayout(False)
        Me.GbContacto.PerformLayout()
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        Me.GbOtros.ResumeLayout(False)
        Me.GbOtros.PerformLayout()
        CType(Me.DgvListaNom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbContacto As GroupBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents LblDireccion As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblTelefono As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents DtpFdn As DateTimePicker
    Friend WithEvents LblEdad As Label
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtEdad As Label
    Friend WithEvents LblFnacimiento As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents GbOtros As GroupBox
    Friend WithEvents DgvListaNom As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents LblListMetod As Label
    Friend WithEvents TxtMetodoPago As Label
    Friend WithEvents BtnAddGrupo As Button
    Friend WithEvents RbGrupo As RadioButton
    Friend WithEvents LblMetodoPago As Label
    Friend WithEvents RbMensual As RadioButton
    Friend WithEvents DtpFdi As DateTimePicker
    Friend WithEvents LblFinscripcion As Label
    Friend WithEvents RbDiario As RadioButton
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents ToolTipText As ToolTip
End Class
