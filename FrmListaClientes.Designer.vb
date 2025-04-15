<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmListaClientes
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GbEncabezado = New System.Windows.Forms.GroupBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.CmbBuscar = New System.Windows.Forms.ComboBox()
        Me.TxtBuscarCliente = New System.Windows.Forms.TextBox()
        Me.LblBuscar = New System.Windows.Forms.Label()
        Me.LblInformacion = New System.Windows.Forms.Label()
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
        Me.PnlBotonera = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnNuevoPago = New System.Windows.Forms.Button()
        Me.BtnHistorialPagos = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnCambiarEstado = New System.Windows.Forms.Button()
        Me.PbLogo = New System.Windows.Forms.PictureBox()
        Me.GbEncabezado.SuspendLayout()
        CType(Me.DgvListaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StsBarra.SuspendLayout()
        Me.PnlBotonera.SuspendLayout()
        CType(Me.PbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbEncabezado
        '
        Me.GbEncabezado.Controls.Add(Me.BtnLimpiar)
        Me.GbEncabezado.Controls.Add(Me.CmbBuscar)
        Me.GbEncabezado.Controls.Add(Me.TxtBuscarCliente)
        Me.GbEncabezado.Controls.Add(Me.LblBuscar)
        Me.GbEncabezado.Location = New System.Drawing.Point(106, 118)
        Me.GbEncabezado.Name = "GbEncabezado"
        Me.GbEncabezado.Size = New System.Drawing.Size(900, 51)
        Me.GbEncabezado.TabIndex = 1
        Me.GbEncabezado.TabStop = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.clear22
        Me.BtnLimpiar.Location = New System.Drawing.Point(860, 12)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(34, 30)
        Me.BtnLimpiar.TabIndex = 2
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
        Me.CmbBuscar.Location = New System.Drawing.Point(98, 16)
        Me.CmbBuscar.Name = "CmbBuscar"
        Me.CmbBuscar.Size = New System.Drawing.Size(130, 24)
        Me.CmbBuscar.TabIndex = 0
        '
        'TxtBuscarCliente
        '
        Me.TxtBuscarCliente.BackColor = System.Drawing.SystemColors.Window
        Me.TxtBuscarCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscarCliente.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtBuscarCliente.Location = New System.Drawing.Point(234, 16)
        Me.TxtBuscarCliente.MaxLength = 30
        Me.TxtBuscarCliente.Name = "TxtBuscarCliente"
        Me.TxtBuscarCliente.Size = New System.Drawing.Size(620, 22)
        Me.TxtBuscarCliente.TabIndex = 1
        Me.TxtBuscarCliente.WordWrap = False
        '
        'LblBuscar
        '
        Me.LblBuscar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscar.Location = New System.Drawing.Point(6, 16)
        Me.LblBuscar.Name = "LblBuscar"
        Me.LblBuscar.Size = New System.Drawing.Size(86, 24)
        Me.LblBuscar.TabIndex = 4
        Me.LblBuscar.Text = "Buscar por"
        Me.LblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblInformacion
        '
        Me.LblInformacion.AutoSize = True
        Me.LblInformacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInformacion.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LblInformacion.Location = New System.Drawing.Point(109, 94)
        Me.LblInformacion.Margin = New System.Windows.Forms.Padding(6)
        Me.LblInformacion.Name = "LblInformacion"
        Me.LblInformacion.Size = New System.Drawing.Size(891, 18)
        Me.LblInformacion.TabIndex = 3
        Me.LblInformacion.Text = "La lista muestra los clientes registrados en la base de datos. Selecciona un clie" &
    "nte para editar sus datos, eliminar o cambiar su estado." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'RbNoActivo
        '
        Me.RbNoActivo.Appearance = System.Windows.Forms.Appearance.Button
        Me.RbNoActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNoActivo.Location = New System.Drawing.Point(1208, 125)
        Me.RbNoActivo.Name = "RbNoActivo"
        Me.RbNoActivo.Size = New System.Drawing.Size(190, 40)
        Me.RbNoActivo.TabIndex = 3
        Me.RbNoActivo.Text = "Clientes inactivos"
        Me.RbNoActivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RbNoActivo.UseVisualStyleBackColor = True
        '
        'RbActivo
        '
        Me.RbActivo.Appearance = System.Windows.Forms.Appearance.Button
        Me.RbActivo.Checked = True
        Me.RbActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbActivo.Location = New System.Drawing.Point(1012, 126)
        Me.RbActivo.Name = "RbActivo"
        Me.RbActivo.Size = New System.Drawing.Size(190, 40)
        Me.RbActivo.TabIndex = 2
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
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DgvListaClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvListaClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvListaClientes.ColumnHeadersHeight = 35
        Me.DgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvListaClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNom, Me.colApe, Me.colEdad, Me.colFdNacimiento, Me.colTelefono, Me.colEmail, Me.colDireccion, Me.colFdInscripcion, Me.id, Me.std})
        Me.DgvListaClientes.Location = New System.Drawing.Point(22, 178)
        Me.DgvListaClientes.MultiSelect = False
        Me.DgvListaClientes.Name = "DgvListaClientes"
        Me.DgvListaClientes.ReadOnly = True
        Me.DgvListaClientes.RowHeadersWidth = 35
        Me.DgvListaClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvListaClientes.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvListaClientes.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DgvListaClientes.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvListaClientes.RowTemplate.Height = 27
        Me.DgvListaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvListaClientes.Size = New System.Drawing.Size(1376, 518)
        Me.DgvListaClientes.TabIndex = 4
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
        Me.StsBarra.Location = New System.Drawing.Point(0, 715)
        Me.StsBarra.Name = "StsBarra"
        Me.StsBarra.Size = New System.Drawing.Size(1424, 46)
        Me.StsBarra.SizingGrip = False
        Me.StsBarra.TabIndex = 5
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
        'PnlBotonera
        '
        Me.PnlBotonera.BackColor = System.Drawing.Color.LightGray
        Me.PnlBotonera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlBotonera.Controls.Add(Me.BtnCerrar)
        Me.PnlBotonera.Controls.Add(Me.BtnNuevoPago)
        Me.PnlBotonera.Controls.Add(Me.BtnHistorialPagos)
        Me.PnlBotonera.Controls.Add(Me.BtnModificar)
        Me.PnlBotonera.Controls.Add(Me.BtnNuevo)
        Me.PnlBotonera.Controls.Add(Me.BtnEliminar)
        Me.PnlBotonera.Controls.Add(Me.BtnCambiarEstado)
        Me.PnlBotonera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlBotonera.Location = New System.Drawing.Point(0, 0)
        Me.PnlBotonera.Name = "PnlBotonera"
        Me.PnlBotonera.Size = New System.Drawing.Size(1424, 75)
        Me.PnlBotonera.TabIndex = 0
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.LightGray
        Me.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.Brown
        Me.BtnCerrar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.salir22
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCerrar.Location = New System.Drawing.Point(1216, 12)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.BtnCerrar.Size = New System.Drawing.Size(180, 44)
        Me.BtnCerrar.TabIndex = 7
        Me.BtnCerrar.Text = "  Cerrar &ventana"
        Me.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'BtnNuevoPago
        '
        Me.BtnNuevoPago.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BtnNuevoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevoPago.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnNuevoPago.Image = Global.ControlPagosGimnasio.My.Resources.Resources.nuevo_pago_28x32
        Me.BtnNuevoPago.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevoPago.Location = New System.Drawing.Point(1010, 12)
        Me.BtnNuevoPago.Name = "BtnNuevoPago"
        Me.BtnNuevoPago.Padding = New System.Windows.Forms.Padding(23, 0, 15, 0)
        Me.BtnNuevoPago.Size = New System.Drawing.Size(180, 44)
        Me.BtnNuevoPago.TabIndex = 6
        Me.BtnNuevoPago.Text = "N&uevo pago"
        Me.BtnNuevoPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevoPago.UseVisualStyleBackColor = True
        '
        'BtnHistorialPagos
        '
        Me.BtnHistorialPagos.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BtnHistorialPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHistorialPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHistorialPagos.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnHistorialPagos.Image = Global.ControlPagosGimnasio.My.Resources.Resources.historial_28x32
        Me.BtnHistorialPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnHistorialPagos.Location = New System.Drawing.Point(798, 12)
        Me.BtnHistorialPagos.Name = "BtnHistorialPagos"
        Me.BtnHistorialPagos.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.BtnHistorialPagos.Size = New System.Drawing.Size(200, 44)
        Me.BtnHistorialPagos.TabIndex = 5
        Me.BtnHistorialPagos.Text = "&Historial de pagos"
        Me.BtnHistorialPagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHistorialPagos.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.editar_28x32
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(166, 10)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Padding = New System.Windows.Forms.Padding(10, 0, 12, 0)
        Me.BtnModificar.Size = New System.Drawing.Size(140, 48)
        Me.BtnModificar.TabIndex = 2
        Me.BtnModificar.Text = "&Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Image = Global.ControlPagosGimnasio.My.Resources.Resources.nuevo_24x32
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(20, 10)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Padding = New System.Windows.Forms.Padding(15, 0, 20, 0)
        Me.BtnNuevo.Size = New System.Drawing.Size(140, 48)
        Me.BtnNuevo.TabIndex = 1
        Me.BtnNuevo.Text = "&Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.eliminar_28x32
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(312, 10)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Padding = New System.Windows.Forms.Padding(10, 0, 13, 0)
        Me.BtnEliminar.Size = New System.Drawing.Size(140, 48)
        Me.BtnEliminar.TabIndex = 3
        Me.BtnEliminar.Text = "&Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnCambiarEstado
        '
        Me.BtnCambiarEstado.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.BtnCambiarEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCambiarEstado.Image = Global.ControlPagosGimnasio.My.Resources.Resources.cambiarstd_28x32
        Me.BtnCambiarEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCambiarEstado.Location = New System.Drawing.Point(458, 10)
        Me.BtnCambiarEstado.Name = "BtnCambiarEstado"
        Me.BtnCambiarEstado.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.BtnCambiarEstado.Size = New System.Drawing.Size(180, 48)
        Me.BtnCambiarEstado.TabIndex = 4
        Me.BtnCambiarEstado.Text = "&Cambiar estado"
        Me.BtnCambiarEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCambiarEstado.UseVisualStyleBackColor = True
        '
        'PbLogo
        '
        Me.PbLogo.Image = Global.ControlPagosGimnasio.My.Resources.Resources.boxeador
        Me.PbLogo.Location = New System.Drawing.Point(22, 94)
        Me.PbLogo.Margin = New System.Windows.Forms.Padding(6)
        Me.PbLogo.Name = "PbLogo"
        Me.PbLogo.Size = New System.Drawing.Size(75, 75)
        Me.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbLogo.TabIndex = 68
        Me.PbLogo.TabStop = False
        '
        'FrmListaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1424, 761)
        Me.Controls.Add(Me.PnlBotonera)
        Me.Controls.Add(Me.GbEncabezado)
        Me.Controls.Add(Me.RbNoActivo)
        Me.Controls.Add(Me.PbLogo)
        Me.Controls.Add(Me.RbActivo)
        Me.Controls.Add(Me.LblInformacion)
        Me.Controls.Add(Me.DgvListaClientes)
        Me.Controls.Add(Me.StsBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmListaClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista clientes"
        Me.GbEncabezado.ResumeLayout(False)
        Me.GbEncabezado.PerformLayout()
        CType(Me.DgvListaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StsBarra.ResumeLayout(False)
        Me.StsBarra.PerformLayout()
        Me.PnlBotonera.ResumeLayout(False)
        CType(Me.PbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GbEncabezado As GroupBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents CmbBuscar As ComboBox
    Friend WithEvents PbLogo As PictureBox
    Friend WithEvents LblInformacion As Label
    Friend WithEvents TxtBuscarCliente As TextBox
    Friend WithEvents LblBuscar As Label
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
    Friend WithEvents PnlBotonera As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnNuevoPago As Button
    Friend WithEvents BtnHistorialPagos As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnCambiarEstado As Button
End Class
