<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaMorosos
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
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.DgvMorosos = New System.Windows.Forms.DataGridView()
        Me.colNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEdad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMesAno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDesct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNdias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApagar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_pgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fdi_pgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbEncabezado = New System.Windows.Forms.GroupBox()
        Me.CmbBuscar = New System.Windows.Forms.ComboBox()
        Me.LblBuscar = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.PbLogo = New System.Windows.Forms.PictureBox()
        Me.LblInformacion = New System.Windows.Forms.Label()
        Me.TxtBuscarCliente = New System.Windows.Forms.TextBox()
        Me.BtnPagar = New System.Windows.Forms.Button()
        Me.StsBarra = New System.Windows.Forms.StatusStrip()
        Me.SlblTitulo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SlblMensaje = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SlblButton = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.DgvMorosos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEncabezado.SuspendLayout()
        CType(Me.PbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StsBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BtnCerrar.Location = New System.Drawing.Point(1033, 720)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(100, 30)
        Me.BtnCerrar.TabIndex = 80
        Me.BtnCerrar.Text = "  &Cerrar"
        Me.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'DgvMorosos
        '
        Me.DgvMorosos.AllowUserToAddRows = False
        Me.DgvMorosos.AllowUserToDeleteRows = False
        Me.DgvMorosos.AllowUserToResizeColumns = False
        Me.DgvMorosos.AllowUserToResizeRows = False
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvMorosos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle12
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvMorosos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.DgvMorosos.ColumnHeadersHeight = 35
        Me.DgvMorosos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvMorosos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNom, Me.colApe, Me.colEdad, Me.colMesAno, Me.colPrecio, Me.colDesct, Me.colTotal, Me.colNdias, Me.colApagar, Me.Column, Me.id_pgs, Me.fdi_pgs, Me.cliente})
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvMorosos.DefaultCellStyle = DataGridViewCellStyle21
        Me.DgvMorosos.Location = New System.Drawing.Point(24, 114)
        Me.DgvMorosos.MultiSelect = False
        Me.DgvMorosos.Name = "DgvMorosos"
        Me.DgvMorosos.ReadOnly = True
        Me.DgvMorosos.RowHeadersWidth = 35
        Me.DgvMorosos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvMorosos.RowsDefaultCellStyle = DataGridViewCellStyle22
        Me.DgvMorosos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvMorosos.RowTemplate.Height = 27
        Me.DgvMorosos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvMorosos.Size = New System.Drawing.Size(1115, 578)
        Me.DgvMorosos.TabIndex = 78
        '
        'colNom
        '
        Me.colNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colNom.HeaderText = "NOMBRE"
        Me.colNom.Name = "colNom"
        Me.colNom.ReadOnly = True
        Me.colNom.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colNom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colNom.Width = 180
        '
        'colApe
        '
        Me.colApe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colApe.HeaderText = "APELLIDO"
        Me.colApe.Name = "colApe"
        Me.colApe.ReadOnly = True
        Me.colApe.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colApe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colApe.Width = 180
        '
        'colEdad
        '
        Me.colEdad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colEdad.DefaultCellStyle = DataGridViewCellStyle14
        Me.colEdad.HeaderText = "EDAD"
        Me.colEdad.Name = "colEdad"
        Me.colEdad.ReadOnly = True
        Me.colEdad.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colEdad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colEdad.Width = 90
        '
        'colMesAno
        '
        Me.colMesAno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colMesAno.DefaultCellStyle = DataGridViewCellStyle15
        Me.colMesAno.HeaderText = "MES Y AÑO"
        Me.colMesAno.Name = "colMesAno"
        Me.colMesAno.ReadOnly = True
        Me.colMesAno.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colMesAno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colMesAno.Width = 140
        '
        'colPrecio
        '
        Me.colPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colPrecio.DefaultCellStyle = DataGridViewCellStyle16
        Me.colPrecio.HeaderText = "PRECIO"
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.ReadOnly = True
        Me.colPrecio.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colPrecio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colPrecio.Width = 90
        '
        'colDesct
        '
        Me.colDesct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colDesct.DefaultCellStyle = DataGridViewCellStyle17
        Me.colDesct.HeaderText = "DESCT."
        Me.colDesct.Name = "colDesct"
        Me.colDesct.ReadOnly = True
        Me.colDesct.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDesct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDesct.Width = 90
        '
        'colTotal
        '
        Me.colTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colTotal.DefaultCellStyle = DataGridViewCellStyle18
        Me.colTotal.HeaderText = "TOTAL"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.ReadOnly = True
        Me.colTotal.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colTotal.Width = 90
        '
        'colNdias
        '
        Me.colNdias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colNdias.DefaultCellStyle = DataGridViewCellStyle19
        Me.colNdias.HeaderText = "Nº DE DIAS"
        Me.colNdias.Name = "colNdias"
        Me.colNdias.ReadOnly = True
        Me.colNdias.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colNdias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colNdias.Width = 90
        '
        'colApagar
        '
        Me.colApagar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colApagar.DefaultCellStyle = DataGridViewCellStyle20
        Me.colApagar.HeaderText = "A PAGAR"
        Me.colApagar.Name = "colApagar"
        Me.colApagar.ReadOnly = True
        Me.colApagar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colApagar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colApagar.Width = 90
        '
        'Column
        '
        Me.Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column.HeaderText = ""
        Me.Column.Name = "Column"
        Me.Column.ReadOnly = True
        Me.Column.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column.Width = 20
        '
        'id_pgs
        '
        Me.id_pgs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.id_pgs.HeaderText = "id_pgs"
        Me.id_pgs.Name = "id_pgs"
        Me.id_pgs.ReadOnly = True
        Me.id_pgs.Visible = False
        Me.id_pgs.Width = 10
        '
        'fdi_pgs
        '
        Me.fdi_pgs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.fdi_pgs.HeaderText = "fdi_pgs"
        Me.fdi_pgs.Name = "fdi_pgs"
        Me.fdi_pgs.ReadOnly = True
        Me.fdi_pgs.Visible = False
        Me.fdi_pgs.Width = 10
        '
        'cliente
        '
        Me.cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.cliente.HeaderText = "cliente"
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        Me.cliente.Visible = False
        Me.cliente.Width = 10
        '
        'gbEncabezado
        '
        Me.gbEncabezado.Controls.Add(Me.CmbBuscar)
        Me.gbEncabezado.Controls.Add(Me.LblBuscar)
        Me.gbEncabezado.Controls.Add(Me.BtnLimpiar)
        Me.gbEncabezado.Controls.Add(Me.PbLogo)
        Me.gbEncabezado.Controls.Add(Me.LblInformacion)
        Me.gbEncabezado.Controls.Add(Me.TxtBuscarCliente)
        Me.gbEncabezado.Location = New System.Drawing.Point(24, 2)
        Me.gbEncabezado.Name = "gbEncabezado"
        Me.gbEncabezado.Size = New System.Drawing.Size(960, 104)
        Me.gbEncabezado.TabIndex = 82
        Me.gbEncabezado.TabStop = False
        '
        'CmbBuscar
        '
        Me.CmbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBuscar.ForeColor = System.Drawing.Color.MediumBlue
        Me.CmbBuscar.FormattingEnabled = True
        Me.CmbBuscar.Items.AddRange(New Object() {"Nombre", "Apellido"})
        Me.CmbBuscar.Location = New System.Drawing.Point(192, 64)
        Me.CmbBuscar.Name = "CmbBuscar"
        Me.CmbBuscar.Size = New System.Drawing.Size(130, 24)
        Me.CmbBuscar.TabIndex = 1
        '
        'LblBuscar
        '
        Me.LblBuscar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscar.Location = New System.Drawing.Point(96, 64)
        Me.LblBuscar.Name = "LblBuscar"
        Me.LblBuscar.Size = New System.Drawing.Size(86, 24)
        Me.LblBuscar.TabIndex = 70
        Me.LblBuscar.Text = "Buscar por"
        Me.LblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Location = New System.Drawing.Point(912, 56)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(34, 30)
        Me.BtnLimpiar.TabIndex = 4
        Me.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'PbLogo
        '
        Me.PbLogo.Location = New System.Drawing.Point(16, 24)
        Me.PbLogo.Margin = New System.Windows.Forms.Padding(6)
        Me.PbLogo.Name = "PbLogo"
        Me.PbLogo.Size = New System.Drawing.Size(64, 68)
        Me.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbLogo.TabIndex = 68
        Me.PbLogo.TabStop = False
        '
        'LblInformacion
        '
        Me.LblInformacion.AutoSize = True
        Me.LblInformacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInformacion.ForeColor = System.Drawing.Color.Firebrick
        Me.LblInformacion.Location = New System.Drawing.Point(96, 24)
        Me.LblInformacion.Margin = New System.Windows.Forms.Padding(6)
        Me.LblInformacion.Name = "LblInformacion"
        Me.LblInformacion.Size = New System.Drawing.Size(835, 18)
        Me.LblInformacion.TabIndex = 67
        Me.LblInformacion.Text = "La siguiente lista muestra los pagos pendientes. Selecciona un cliente de la list" &
    "a para poder realizar el pago de la mensualidad."
        '
        'TxtBuscarCliente
        '
        Me.TxtBuscarCliente.BackColor = System.Drawing.SystemColors.Window
        Me.TxtBuscarCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscarCliente.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtBuscarCliente.Location = New System.Drawing.Point(328, 64)
        Me.TxtBuscarCliente.MaxLength = 30
        Me.TxtBuscarCliente.Name = "TxtBuscarCliente"
        Me.TxtBuscarCliente.Size = New System.Drawing.Size(576, 22)
        Me.TxtBuscarCliente.TabIndex = 0
        Me.TxtBuscarCliente.WordWrap = False
        '
        'BtnPagar
        '
        Me.BtnPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPagar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPagar.Location = New System.Drawing.Point(1032, 18)
        Me.BtnPagar.Name = "BtnPagar"
        Me.BtnPagar.Size = New System.Drawing.Size(100, 74)
        Me.BtnPagar.TabIndex = 79
        Me.BtnPagar.Text = "&Pagar"
        Me.BtnPagar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPagar.UseVisualStyleBackColor = True
        '
        'StsBarra
        '
        Me.StsBarra.AutoSize = False
        Me.StsBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlblTitulo, Me.SlblMensaje, Me.SlblButton})
        Me.StsBarra.Location = New System.Drawing.Point(0, 718)
        Me.StsBarra.Name = "StsBarra"
        Me.StsBarra.Size = New System.Drawing.Size(1159, 46)
        Me.StsBarra.SizingGrip = False
        Me.StsBarra.TabIndex = 81
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
        Me.SlblTitulo.Margin = New System.Windows.Forms.Padding(22, 2, 0, 2)
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
        Me.SlblMensaje.Margin = New System.Windows.Forms.Padding(6, 2, 6, 2)
        Me.SlblMensaje.Name = "SlblMensaje"
        Me.SlblMensaje.Size = New System.Drawing.Size(846, 42)
        Me.SlblMensaje.Text = " n Registros pendientes de pago."
        Me.SlblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SlblButton
        '
        Me.SlblButton.AutoSize = False
        Me.SlblButton.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.SlblButton.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.SlblButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.SlblButton.Margin = New System.Windows.Forms.Padding(6, 2, 22, 2)
        Me.SlblButton.Name = "SlblButton"
        Me.SlblButton.Size = New System.Drawing.Size(114, 42)
        Me.SlblButton.Text = "Button"
        '
        'FrmListaMorosos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 764)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.DgvMorosos)
        Me.Controls.Add(Me.gbEncabezado)
        Me.Controls.Add(Me.BtnPagar)
        Me.Controls.Add(Me.StsBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(20, 20)
        Me.MaximizeBox = False
        Me.Name = "FrmListaMorosos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Lista de pagos pendientes"
        CType(Me.DgvMorosos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEncabezado.ResumeLayout(False)
        Me.gbEncabezado.PerformLayout()
        CType(Me.PbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StsBarra.ResumeLayout(False)
        Me.StsBarra.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCerrar As Button
    Friend WithEvents DgvMorosos As DataGridView
    Friend WithEvents colNom As DataGridViewTextBoxColumn
    Friend WithEvents colApe As DataGridViewTextBoxColumn
    Friend WithEvents colEdad As DataGridViewTextBoxColumn
    Friend WithEvents colMesAno As DataGridViewTextBoxColumn
    Friend WithEvents colPrecio As DataGridViewTextBoxColumn
    Friend WithEvents colDesct As DataGridViewTextBoxColumn
    Friend WithEvents colTotal As DataGridViewTextBoxColumn
    Friend WithEvents colNdias As DataGridViewTextBoxColumn
    Friend WithEvents colApagar As DataGridViewTextBoxColumn
    Friend WithEvents Column As DataGridViewTextBoxColumn
    Friend WithEvents id_pgs As DataGridViewTextBoxColumn
    Friend WithEvents fdi_pgs As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents gbEncabezado As GroupBox
    Friend WithEvents CmbBuscar As ComboBox
    Friend WithEvents LblBuscar As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents PbLogo As PictureBox
    Friend WithEvents LblInformacion As Label
    Friend WithEvents TxtBuscarCliente As TextBox
    Friend WithEvents BtnPagar As Button
    Friend WithEvents StsBarra As StatusStrip
    Friend WithEvents SlblTitulo As ToolStripStatusLabel
    Friend WithEvents SlblMensaje As ToolStripStatusLabel
    Friend WithEvents SlblButton As ToolStripStatusLabel
End Class
