<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaClientes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnPago = New System.Windows.Forms.Button()
        Me.BtnHistorial = New System.Windows.Forms.Button()
        Me.GbEncabezado = New System.Windows.Forms.GroupBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.CmbBuscar = New System.Windows.Forms.ComboBox()
        Me.PbLogo = New System.Windows.Forms.PictureBox()
        Me.LblInformacion = New System.Windows.Forms.Label()
        Me.TxtBuscarCliente = New System.Windows.Forms.TextBox()
        Me.LblBuscar = New System.Windows.Forms.Label()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.RbNoActivo = New System.Windows.Forms.RadioButton()
        Me.RbActivo = New System.Windows.Forms.RadioButton()
        Me.DgvListaClientes = New System.Windows.Forms.DataGridView()
        Me.colNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEdad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFdNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFdInscripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.std = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StsBarra = New System.Windows.Forms.StatusStrip()
        Me.SlblTitulo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SlblMensaje = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GbEncabezado.SuspendLayout()
        CType(Me.PbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvListaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StsBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnPago
        '
        Me.BtnPago.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise
        Me.BtnPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew
        Me.BtnPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPago.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnPago.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPago.Location = New System.Drawing.Point(776, 658)
        Me.BtnPago.Name = "BtnPago"
        Me.BtnPago.Size = New System.Drawing.Size(190, 32)
        Me.BtnPago.TabIndex = 87
        Me.BtnPago.Text = "&Pago mensual"
        Me.BtnPago.UseVisualStyleBackColor = True
        '
        'BtnHistorial
        '
        Me.BtnHistorial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnHistorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise
        Me.BtnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew
        Me.BtnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHistorial.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnHistorial.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnHistorial.Location = New System.Drawing.Point(568, 658)
        Me.BtnHistorial.Name = "BtnHistorial"
        Me.BtnHistorial.Size = New System.Drawing.Size(190, 32)
        Me.BtnHistorial.TabIndex = 82
        Me.BtnHistorial.Text = "&Historial de pagos"
        Me.BtnHistorial.UseVisualStyleBackColor = True
        '
        'GbEncabezado
        '
        Me.GbEncabezado.Controls.Add(Me.BtnLimpiar)
        Me.GbEncabezado.Controls.Add(Me.CmbBuscar)
        Me.GbEncabezado.Controls.Add(Me.PbLogo)
        Me.GbEncabezado.Controls.Add(Me.LblInformacion)
        Me.GbEncabezado.Controls.Add(Me.TxtBuscarCliente)
        Me.GbEncabezado.Controls.Add(Me.LblBuscar)
        Me.GbEncabezado.Location = New System.Drawing.Point(32, 2)
        Me.GbEncabezado.Name = "GbEncabezado"
        Me.GbEncabezado.Size = New System.Drawing.Size(968, 104)
        Me.GbEncabezado.TabIndex = 86
        Me.GbEncabezado.TabStop = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Location = New System.Drawing.Point(920, 68)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(34, 30)
        Me.BtnLimpiar.TabIndex = 8
        Me.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'CmbBuscar
        '
        Me.CmbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBuscar.ForeColor = System.Drawing.Color.MediumBlue
        Me.CmbBuscar.FormattingEnabled = True
        Me.CmbBuscar.Items.AddRange(New Object() {"Nombre", "Apellido", "Teléfono"})
        Me.CmbBuscar.Location = New System.Drawing.Point(112, 72)
        Me.CmbBuscar.Name = "CmbBuscar"
        Me.CmbBuscar.Size = New System.Drawing.Size(130, 24)
        Me.CmbBuscar.TabIndex = 0
        '
        'PbLogo
        '
        Me.PbLogo.Location = New System.Drawing.Point(24, 16)
        Me.PbLogo.Margin = New System.Windows.Forms.Padding(6)
        Me.PbLogo.Name = "PbLogo"
        Me.PbLogo.Size = New System.Drawing.Size(60, 46)
        Me.PbLogo.TabIndex = 68
        Me.PbLogo.TabStop = False
        '
        'LblInformacion
        '
        Me.LblInformacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInformacion.ForeColor = System.Drawing.Color.Green
        Me.LblInformacion.Location = New System.Drawing.Point(88, 24)
        Me.LblInformacion.Margin = New System.Windows.Forms.Padding(6)
        Me.LblInformacion.Name = "LblInformacion"
        Me.LblInformacion.Size = New System.Drawing.Size(864, 40)
        Me.LblInformacion.TabIndex = 67
        Me.LblInformacion.Text = "La siguiente lista muestra los clientes registrados en la base de datos. Seleccio" &
    "na un cliente de la lista para editar sus datos, eliminar de la lista o cambiar " &
    "su estado." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtBuscarCliente
        '
        Me.TxtBuscarCliente.BackColor = System.Drawing.SystemColors.Window
        Me.TxtBuscarCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscarCliente.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtBuscarCliente.Location = New System.Drawing.Point(256, 73)
        Me.TxtBuscarCliente.MaxLength = 30
        Me.TxtBuscarCliente.Name = "TxtBuscarCliente"
        Me.TxtBuscarCliente.Size = New System.Drawing.Size(656, 22)
        Me.TxtBuscarCliente.TabIndex = 1
        Me.TxtBuscarCliente.WordWrap = False
        '
        'LblBuscar
        '
        Me.LblBuscar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscar.Location = New System.Drawing.Point(16, 72)
        Me.LblBuscar.Name = "LblBuscar"
        Me.LblBuscar.Size = New System.Drawing.Size(86, 24)
        Me.LblBuscar.TabIndex = 66
        Me.LblBuscar.Text = "Buscar por"
        Me.LblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEditar
        '
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEditar.Location = New System.Drawing.Point(1128, 34)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(100, 74)
        Me.BtnEditar.TabIndex = 78
        Me.BtnEditar.Text = "&Editar"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.Brown
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BtnCerrar.Location = New System.Drawing.Point(1224, 658)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(170, 32)
        Me.BtnCerrar.TabIndex = 83
        Me.BtnCerrar.Text = "  &Cerrar ventana"
        Me.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEliminar.Location = New System.Drawing.Point(1248, 34)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(148, 74)
        Me.BtnEliminar.TabIndex = 79
        Me.BtnEliminar.Text = "Eli&minar / Cambiar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNuevo.Location = New System.Drawing.Point(1016, 34)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(100, 74)
        Me.BtnNuevo.TabIndex = 77
        Me.BtnNuevo.Tag = ""
        Me.BtnNuevo.Text = "&Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'RbNoActivo
        '
        Me.RbNoActivo.Appearance = System.Windows.Forms.Appearance.Button
        Me.RbNoActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNoActivo.Location = New System.Drawing.Point(232, 658)
        Me.RbNoActivo.Name = "RbNoActivo"
        Me.RbNoActivo.Size = New System.Drawing.Size(190, 32)
        Me.RbNoActivo.TabIndex = 81
        Me.RbNoActivo.Text = "Clientes inactivos"
        Me.RbNoActivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RbNoActivo.UseVisualStyleBackColor = True
        '
        'RbActivo
        '
        Me.RbActivo.Appearance = System.Windows.Forms.Appearance.Button
        Me.RbActivo.Checked = True
        Me.RbActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbActivo.Location = New System.Drawing.Point(24, 658)
        Me.RbActivo.Name = "RbActivo"
        Me.RbActivo.Size = New System.Drawing.Size(190, 32)
        Me.RbActivo.TabIndex = 80
        Me.RbActivo.TabStop = True
        Me.RbActivo.Text = "Clientes en actividad"
        Me.RbActivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RbActivo.UseVisualStyleBackColor = True
        '
        'DgvListaClientes
        '
        Me.DgvListaClientes.AllowUserToAddRows = False
        Me.DgvListaClientes.AllowUserToDeleteRows = False
        Me.DgvListaClientes.AllowUserToResizeColumns = False
        Me.DgvListaClientes.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgvListaClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvListaClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvListaClientes.ColumnHeadersHeight = 35
        Me.DgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvListaClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNom, Me.colApe, Me.colEdad, Me.colFdNacimiento, Me.colTelefono, Me.colEmail, Me.colDireccion, Me.colFdInscripcion, Me.id, Me.std})
        Me.DgvListaClientes.Location = New System.Drawing.Point(24, 122)
        Me.DgvListaClientes.MultiSelect = False
        Me.DgvListaClientes.Name = "DgvListaClientes"
        Me.DgvListaClientes.ReadOnly = True
        Me.DgvListaClientes.RowHeadersWidth = 35
        Me.DgvListaClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvListaClientes.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvListaClientes.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DgvListaClientes.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvListaClientes.RowTemplate.Height = 27
        Me.DgvListaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvListaClientes.Size = New System.Drawing.Size(1376, 518)
        Me.DgvListaClientes.TabIndex = 84
        '
        'colNom
        '
        Me.colNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colNom.HeaderText = "NOMBRE"
        Me.colNom.Name = "colNom"
        Me.colNom.ReadOnly = True
        Me.colNom.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colNom.Width = 180
        '
        'colApe
        '
        Me.colApe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colApe.HeaderText = "APELLIDO"
        Me.colApe.Name = "colApe"
        Me.colApe.ReadOnly = True
        Me.colApe.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colApe.Width = 180
        '
        'colEdad
        '
        Me.colEdad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colEdad.HeaderText = "EDAD"
        Me.colEdad.Name = "colEdad"
        Me.colEdad.ReadOnly = True
        Me.colEdad.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colFdNacimiento
        '
        Me.colFdNacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colFdNacimiento.HeaderText = "FECHA NACIMIENTO"
        Me.colFdNacimiento.Name = "colFdNacimiento"
        Me.colFdNacimiento.ReadOnly = True
        Me.colFdNacimiento.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colFdNacimiento.Width = 160
        '
        'colTelefono
        '
        Me.colTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colTelefono.HeaderText = "TELÉFONO"
        Me.colTelefono.Name = "colTelefono"
        Me.colTelefono.ReadOnly = True
        Me.colTelefono.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colTelefono.Width = 140
        '
        'colEmail
        '
        Me.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colEmail.HeaderText = "E-MAIL"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.ReadOnly = True
        Me.colEmail.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colEmail.Width = 200
        '
        'colDireccion
        '
        Me.colDireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colDireccion.HeaderText = "DIRECCIÓN"
        Me.colDireccion.Name = "colDireccion"
        Me.colDireccion.ReadOnly = True
        Me.colDireccion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDireccion.Width = 200
        '
        'colFdInscripcion
        '
        Me.colFdInscripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colFdInscripcion.HeaderText = "FECHA INSCRIPCIÓN"
        Me.colFdInscripcion.Name = "colFdInscripcion"
        Me.colFdInscripcion.ReadOnly = True
        Me.colFdInscripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colFdInscripcion.Width = 160
        '
        'id
        '
        Me.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        Me.id.Width = 44
        '
        'std
        '
        Me.std.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.std.HeaderText = "std"
        Me.std.Name = "std"
        Me.std.ReadOnly = True
        Me.std.Visible = False
        Me.std.Width = 51
        '
        'StsBarra
        '
        Me.StsBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlblTitulo, Me.SlblMensaje})
        Me.StsBarra.Location = New System.Drawing.Point(0, 712)
        Me.StsBarra.Name = "StsBarra"
        Me.StsBarra.Size = New System.Drawing.Size(1424, 46)
        Me.StsBarra.SizingGrip = False
        Me.StsBarra.TabIndex = 85
        Me.StsBarra.Text = "stsBarra"
        '
        'SlblTitulo
        '
        Me.SlblTitulo.AutoSize = False
        Me.SlblTitulo.BackColor = System.Drawing.SystemColors.Control
        Me.SlblTitulo.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.SlblTitulo.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.SlblTitulo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SlblTitulo.Margin = New System.Windows.Forms.Padding(22, 2, 5, 2)
        Me.SlblTitulo.Name = "SlblTitulo"
        Me.SlblTitulo.Size = New System.Drawing.Size(140, 42)
        Me.SlblTitulo.Text = "Nº de Registros"
        '
        'SlblMensaje
        '
        Me.SlblMensaje.AutoSize = False
        Me.SlblMensaje.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.SlblMensaje.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.SlblMensaje.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SlblMensaje.Margin = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.SlblMensaje.Name = "SlblMensaje"
        Me.SlblMensaje.Size = New System.Drawing.Size(1226, 42)
        Me.SlblMensaje.Text = " No hay cliente(s) registrado(s) en la Base de Datos"
        Me.SlblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmListaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1424, 758)
        Me.Controls.Add(Me.BtnPago)
        Me.Controls.Add(Me.BtnHistorial)
        Me.Controls.Add(Me.GbEncabezado)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.RbNoActivo)
        Me.Controls.Add(Me.RbActivo)
        Me.Controls.Add(Me.DgvListaClientes)
        Me.Controls.Add(Me.StsBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmListaClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista clientes"
        Me.GbEncabezado.ResumeLayout(False)
        Me.GbEncabezado.PerformLayout()
        CType(Me.PbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvListaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StsBarra.ResumeLayout(False)
        Me.StsBarra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnPago As Button
    Friend WithEvents BtnHistorial As Button
    Friend WithEvents GbEncabezado As GroupBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents CmbBuscar As ComboBox
    Friend WithEvents PbLogo As PictureBox
    Friend WithEvents LblInformacion As Label
    Friend WithEvents TxtBuscarCliente As TextBox
    Friend WithEvents LblBuscar As Label
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents RbNoActivo As RadioButton
    Friend WithEvents RbActivo As RadioButton
    Friend WithEvents DgvListaClientes As DataGridView
    Friend WithEvents colNom As DataGridViewTextBoxColumn
    Friend WithEvents colApe As DataGridViewTextBoxColumn
    Friend WithEvents colEdad As DataGridViewTextBoxColumn
    Friend WithEvents colFdNacimiento As DataGridViewTextBoxColumn
    Friend WithEvents colTelefono As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewTextBoxColumn
    Friend WithEvents colDireccion As DataGridViewTextBoxColumn
    Friend WithEvents colFdInscripcion As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents std As DataGridViewTextBoxColumn
    Friend WithEvents StsBarra As StatusStrip
    Friend WithEvents SlblTitulo As ToolStripStatusLabel
    Friend WithEvents SlblMensaje As ToolStripStatusLabel
End Class
