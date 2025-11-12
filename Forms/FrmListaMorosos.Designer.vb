<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmListaMorosos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgvMorosos = New System.Windows.Forms.DataGridView()
        Me.LblInformacion = New System.Windows.Forms.Label()
        Me.StsBarra = New System.Windows.Forms.StatusStrip()
        Me.SlblTitulo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SlblMensaje = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.PbLogo = New System.Windows.Forms.PictureBox()
        Me.BtnPagar = New System.Windows.Forms.Button()
        Me.PnlBuscar = New System.Windows.Forms.Panel()
        Me.CmbFiltrar = New System.Windows.Forms.ComboBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.LblFiltrar = New System.Windows.Forms.Label()
        Me.nom_cli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ape_cli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fdn_cli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mesanio_pgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prc_pgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsc_pgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_pgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ndias_pgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pagar_pgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_pgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fdi_pgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvMorosos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StsBarra.SuspendLayout()
        CType(Me.PbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBuscar.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvMorosos
        '
        Me.DgvMorosos.AllowUserToAddRows = False
        Me.DgvMorosos.AllowUserToDeleteRows = False
        Me.DgvMorosos.AllowUserToResizeColumns = False
        Me.DgvMorosos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Linux Libertine Display G", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvMorosos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvMorosos.ColumnHeadersHeight = 32
        Me.DgvMorosos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvMorosos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nom_cli, Me.ape_cli, Me.fdn_cli, Me.mesanio_pgs, Me.prc_pgs, Me.dsc_pgs, Me.total_pgs, Me.ndias_pgs, Me.pagar_pgs, Me.Column, Me.id_pgs, Me.fdi_pgs, Me.cliente})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvMorosos.DefaultCellStyle = DataGridViewCellStyle9
        Me.DgvMorosos.Location = New System.Drawing.Point(25, 118)
        Me.DgvMorosos.Margin = New System.Windows.Forms.Padding(16, 16, 0, 16)
        Me.DgvMorosos.MultiSelect = False
        Me.DgvMorosos.Name = "DgvMorosos"
        Me.DgvMorosos.ReadOnly = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvMorosos.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DgvMorosos.RowHeadersWidth = 4
        Me.DgvMorosos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvMorosos.RowTemplate.DividerHeight = 1
        Me.DgvMorosos.RowTemplate.Height = 28
        Me.DgvMorosos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMorosos.Size = New System.Drawing.Size(1022, 592)
        Me.DgvMorosos.TabIndex = 2
        '
        'LblInformacion
        '
        Me.LblInformacion.AutoSize = True
        Me.LblInformacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInformacion.ForeColor = System.Drawing.Color.Brown
        Me.LblInformacion.Location = New System.Drawing.Point(118, 25)
        Me.LblInformacion.Margin = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.LblInformacion.Name = "LblInformacion"
        Me.LblInformacion.Size = New System.Drawing.Size(835, 18)
        Me.LblInformacion.TabIndex = 3
        Me.LblInformacion.Text = "La siguiente lista muestra los pagos pendientes. Selecciona un cliente de la list" &
    "a para poder realizar el pago de la mensualidad."
        '
        'StsBarra
        '
        Me.StsBarra.AutoSize = False
        Me.StsBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlblTitulo, Me.SlblMensaje})
        Me.StsBarra.Location = New System.Drawing.Point(0, 726)
        Me.StsBarra.Name = "StsBarra"
        Me.StsBarra.Size = New System.Drawing.Size(1266, 46)
        Me.StsBarra.SizingGrip = False
        Me.StsBarra.TabIndex = 4
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
        Me.SlblTitulo.Margin = New System.Windows.Forms.Padding(24, 2, 8, 2)
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
        Me.SlblMensaje.Margin = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.SlblMensaje.Name = "SlblMensaje"
        Me.SlblMensaje.Size = New System.Drawing.Size(904, 42)
        Me.SlblMensaje.Text = " n Registros pendientes de pago."
        Me.SlblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.BtnCerrar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.salir22
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCerrar.Location = New System.Drawing.Point(1101, 238)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(0, 56, 0, 0)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Padding = New System.Windows.Forms.Padding(0, 4, 0, 2)
        Me.BtnCerrar.Size = New System.Drawing.Size(140, 64)
        Me.BtnCerrar.TabIndex = 3
        Me.BtnCerrar.Text = "  &Cerrar ventana"
        Me.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'PbLogo
        '
        Me.PbLogo.Image = Global.ControlPagosGimnasio.My.Resources.Resources.caja_regis_60x60
        Me.PbLogo.Location = New System.Drawing.Point(25, 25)
        Me.PbLogo.Margin = New System.Windows.Forms.Padding(16, 16, 0, 0)
        Me.PbLogo.Name = "PbLogo"
        Me.PbLogo.Size = New System.Drawing.Size(77, 77)
        Me.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbLogo.TabIndex = 68
        Me.PbLogo.TabStop = False
        '
        'BtnPagar
        '
        Me.BtnPagar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPagar.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnPagar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.pagar_mes_28x32
        Me.BtnPagar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPagar.Location = New System.Drawing.Point(1101, 118)
        Me.BtnPagar.Margin = New System.Windows.Forms.Padding(16, 0, 16, 0)
        Me.BtnPagar.Name = "BtnPagar"
        Me.BtnPagar.Size = New System.Drawing.Size(140, 64)
        Me.BtnPagar.TabIndex = 1
        Me.BtnPagar.Text = "&Pagar mes"
        Me.BtnPagar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPagar.UseVisualStyleBackColor = True
        '
        'PnlBuscar
        '
        Me.PnlBuscar.AutoSize = True
        Me.PnlBuscar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlBuscar.Controls.Add(Me.CmbFiltrar)
        Me.PnlBuscar.Controls.Add(Me.BtnLimpiar)
        Me.PnlBuscar.Controls.Add(Me.TxtBuscar)
        Me.PnlBuscar.Controls.Add(Me.LblFiltrar)
        Me.PnlBuscar.Location = New System.Drawing.Point(118, 60)
        Me.PnlBuscar.Margin = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.PnlBuscar.Name = "PnlBuscar"
        Me.PnlBuscar.Size = New System.Drawing.Size(967, 42)
        Me.PnlBuscar.TabIndex = 85
        '
        'CmbFiltrar
        '
        Me.CmbFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbFiltrar.ForeColor = System.Drawing.Color.MediumBlue
        Me.CmbFiltrar.FormattingEnabled = True
        Me.CmbFiltrar.IntegralHeight = False
        Me.CmbFiltrar.Items.AddRange(New Object() {"   NOMBRE", "   APELLIDO"})
        Me.CmbFiltrar.Location = New System.Drawing.Point(100, 7)
        Me.CmbFiltrar.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.CmbFiltrar.Name = "CmbFiltrar"
        Me.CmbFiltrar.Size = New System.Drawing.Size(136, 24)
        Me.CmbFiltrar.TabIndex = 82
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.AutoSize = True
        Me.BtnLimpiar.FlatAppearance.BorderSize = 0
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnLimpiar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.cancel_c_28x28
        Me.BtnLimpiar.Location = New System.Drawing.Point(922, 0)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(0, 0, 4, 0)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(37, 37)
        Me.BtnLimpiar.TabIndex = 85
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.BackColor = System.Drawing.Color.Snow
        Me.TxtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBuscar.Font = New System.Drawing.Font("Linux Libertine Display G", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtBuscar.Location = New System.Drawing.Point(241, 6)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TxtBuscar.MaxLength = 30
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(677, 25)
        Me.TxtBuscar.TabIndex = 84
        Me.TxtBuscar.WordWrap = False
        '
        'LblFiltrar
        '
        Me.LblFiltrar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFiltrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblFiltrar.Location = New System.Drawing.Point(8, 6)
        Me.LblFiltrar.Margin = New System.Windows.Forms.Padding(8, 6, 0, 6)
        Me.LblFiltrar.Name = "LblFiltrar"
        Me.LblFiltrar.Size = New System.Drawing.Size(229, 26)
        Me.LblFiltrar.TabIndex = 88
        Me.LblFiltrar.Text = "  Filtrar por"
        Me.LblFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nom_cli
        '
        Me.nom_cli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nom_cli.HeaderText = "NOMBRE"
        Me.nom_cli.Name = "nom_cli"
        Me.nom_cli.ReadOnly = True
        Me.nom_cli.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.nom_cli.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.nom_cli.Width = 160
        '
        'ape_cli
        '
        Me.ape_cli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ape_cli.HeaderText = "APELLIDO"
        Me.ape_cli.Name = "ape_cli"
        Me.ape_cli.ReadOnly = True
        Me.ape_cli.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ape_cli.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ape_cli.Width = 160
        '
        'fdn_cli
        '
        Me.fdn_cli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.fdn_cli.DefaultCellStyle = DataGridViewCellStyle2
        Me.fdn_cli.HeaderText = "EDAD"
        Me.fdn_cli.Name = "fdn_cli"
        Me.fdn_cli.ReadOnly = True
        Me.fdn_cli.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.fdn_cli.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fdn_cli.Width = 90
        '
        'mesanio_pgs
        '
        Me.mesanio_pgs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.mesanio_pgs.DefaultCellStyle = DataGridViewCellStyle3
        Me.mesanio_pgs.HeaderText = "MES Y AÑO"
        Me.mesanio_pgs.Name = "mesanio_pgs"
        Me.mesanio_pgs.ReadOnly = True
        Me.mesanio_pgs.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.mesanio_pgs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.mesanio_pgs.Width = 135
        '
        'prc_pgs
        '
        Me.prc_pgs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.prc_pgs.DefaultCellStyle = DataGridViewCellStyle4
        Me.prc_pgs.HeaderText = "PRECIO"
        Me.prc_pgs.Name = "prc_pgs"
        Me.prc_pgs.ReadOnly = True
        Me.prc_pgs.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.prc_pgs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.prc_pgs.Width = 90
        '
        'dsc_pgs
        '
        Me.dsc_pgs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.dsc_pgs.DefaultCellStyle = DataGridViewCellStyle5
        Me.dsc_pgs.HeaderText = "DSCNTO"
        Me.dsc_pgs.Name = "dsc_pgs"
        Me.dsc_pgs.ReadOnly = True
        Me.dsc_pgs.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dsc_pgs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dsc_pgs.Width = 90
        '
        'total_pgs
        '
        Me.total_pgs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.total_pgs.DefaultCellStyle = DataGridViewCellStyle6
        Me.total_pgs.HeaderText = "TOTAL"
        Me.total_pgs.Name = "total_pgs"
        Me.total_pgs.ReadOnly = True
        Me.total_pgs.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.total_pgs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_pgs.Width = 90
        '
        'ndias_pgs
        '
        Me.ndias_pgs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ndias_pgs.DefaultCellStyle = DataGridViewCellStyle7
        Me.ndias_pgs.HeaderText = "Nº DE DIAS"
        Me.ndias_pgs.Name = "ndias_pgs"
        Me.ndias_pgs.ReadOnly = True
        Me.ndias_pgs.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ndias_pgs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ndias_pgs.Width = 90
        '
        'pagar_pgs
        '
        Me.pagar_pgs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.pagar_pgs.DefaultCellStyle = DataGridViewCellStyle8
        Me.pagar_pgs.HeaderText = "A PAGAR"
        Me.pagar_pgs.Name = "pagar_pgs"
        Me.pagar_pgs.ReadOnly = True
        Me.pagar_pgs.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.pagar_pgs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.pagar_pgs.Width = 90
        '
        'Column
        '
        Me.Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column.HeaderText = ""
        Me.Column.MinimumWidth = 3
        Me.Column.Name = "Column"
        Me.Column.ReadOnly = True
        Me.Column.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column.Width = 3
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
        'FrmListaMorosos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1266, 772)
        Me.Controls.Add(Me.PnlBuscar)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.DgvMorosos)
        Me.Controls.Add(Me.LblInformacion)
        Me.Controls.Add(Me.PbLogo)
        Me.Controls.Add(Me.BtnPagar)
        Me.Controls.Add(Me.StsBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(20, 20)
        Me.MaximizeBox = False
        Me.Name = "FrmListaMorosos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Lista de pagos pendientes"
        CType(Me.DgvMorosos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StsBarra.ResumeLayout(False)
        Me.StsBarra.PerformLayout()
        CType(Me.PbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBuscar.ResumeLayout(False)
        Me.PnlBuscar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCerrar As Button
    Friend WithEvents DgvMorosos As DataGridView
    Friend WithEvents PbLogo As PictureBox
    Friend WithEvents LblInformacion As Label
    Friend WithEvents BtnPagar As Button
    Friend WithEvents StsBarra As StatusStrip
    Friend WithEvents SlblTitulo As ToolStripStatusLabel
    Friend WithEvents SlblMensaje As ToolStripStatusLabel
    Friend WithEvents PnlBuscar As Panel
    Friend WithEvents CmbFiltrar As ComboBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents LblFiltrar As Label
    Friend WithEvents nom_cli As DataGridViewTextBoxColumn
    Friend WithEvents ape_cli As DataGridViewTextBoxColumn
    Friend WithEvents fdn_cli As DataGridViewTextBoxColumn
    Friend WithEvents mesanio_pgs As DataGridViewTextBoxColumn
    Friend WithEvents prc_pgs As DataGridViewTextBoxColumn
    Friend WithEvents dsc_pgs As DataGridViewTextBoxColumn
    Friend WithEvents total_pgs As DataGridViewTextBoxColumn
    Friend WithEvents ndias_pgs As DataGridViewTextBoxColumn
    Friend WithEvents pagar_pgs As DataGridViewTextBoxColumn
    Friend WithEvents Column As DataGridViewTextBoxColumn
    Friend WithEvents id_pgs As DataGridViewTextBoxColumn
    Friend WithEvents fdi_pgs As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
End Class
