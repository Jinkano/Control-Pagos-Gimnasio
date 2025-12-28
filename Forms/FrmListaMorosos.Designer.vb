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
        Me.components = New System.ComponentModel.Container()
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgvIndividual = New System.Windows.Forms.DataGridView()
        Me.nom_cli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ape_cli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fdn_cli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_pgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mesanio_pgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prc_pgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsc_pgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fdi_pgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_pgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ndias_pgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pagar_pgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label = New System.Windows.Forms.Label()
        Me.RbPayIndividual = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RbPayGroup = New System.Windows.Forms.RadioButton()
        Me.DgvFamilyGroup = New System.Windows.Forms.DataGridView()
        Me.nom_cli_gf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_grp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fdi_pgs_gf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prc_pgs_gf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsc_pgs_gf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_pgs_gf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ndias_pgs_gf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pagar_pgs_gf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_pgs_gf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_grp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_intgrntes_grp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grupo_familiar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvIndividual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StsBarra.SuspendLayout()
        CType(Me.PbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBuscar.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvFamilyGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvIndividual
        '
        Me.DgvIndividual.AllowUserToAddRows = False
        Me.DgvIndividual.AllowUserToDeleteRows = False
        Me.DgvIndividual.AllowUserToResizeColumns = False
        Me.DgvIndividual.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Linux Libertine Display G", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvIndividual.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvIndividual.ColumnHeadersHeight = 32
        Me.DgvIndividual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvIndividual.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nom_cli, Me.ape_cli, Me.fdn_cli, Me.id_pgs, Me.mesanio_pgs, Me.prc_pgs, Me.dsc_pgs, Me.fdi_pgs, Me.total_pgs, Me.ndias_pgs, Me.pagar_pgs, Me.Column, Me.cliente})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvIndividual.DefaultCellStyle = DataGridViewCellStyle9
        Me.DgvIndividual.Location = New System.Drawing.Point(25, 152)
        Me.DgvIndividual.Margin = New System.Windows.Forms.Padding(16, 0, 0, 16)
        Me.DgvIndividual.MultiSelect = False
        Me.DgvIndividual.Name = "DgvIndividual"
        Me.DgvIndividual.ReadOnly = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvIndividual.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DgvIndividual.RowHeadersWidth = 4
        Me.DgvIndividual.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvIndividual.RowTemplate.Height = 24
        Me.DgvIndividual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvIndividual.Size = New System.Drawing.Size(1052, 256)
        Me.DgvIndividual.TabIndex = 2
        '
        'nom_cli
        '
        Me.nom_cli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nom_cli.HeaderText = "NOMBRE"
        Me.nom_cli.Name = "nom_cli"
        Me.nom_cli.ReadOnly = True
        Me.nom_cli.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.nom_cli.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.nom_cli.Width = 184
        '
        'ape_cli
        '
        Me.ape_cli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ape_cli.HeaderText = "APELLIDO"
        Me.ape_cli.Name = "ape_cli"
        Me.ape_cli.ReadOnly = True
        Me.ape_cli.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ape_cli.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ape_cli.Width = 184
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
        Me.fdn_cli.Width = 88
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
        Me.mesanio_pgs.Width = 128
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
        Me.prc_pgs.Width = 88
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
        Me.dsc_pgs.Width = 88
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
        Me.total_pgs.Width = 88
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
        Me.ndias_pgs.Width = 88
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
        Me.pagar_pgs.Width = 88
        '
        'Column
        '
        Me.Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column.HeaderText = ""
        Me.Column.MinimumWidth = 4
        Me.Column.Name = "Column"
        Me.Column.ReadOnly = True
        Me.Column.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column.Width = 4
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
        'LblInformacion
        '
        Me.LblInformacion.AutoSize = True
        Me.LblInformacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInformacion.ForeColor = System.Drawing.Color.Brown
        Me.LblInformacion.Location = New System.Drawing.Point(115, 25)
        Me.LblInformacion.Margin = New System.Windows.Forms.Padding(0)
        Me.LblInformacion.Name = "LblInformacion"
        Me.LblInformacion.Size = New System.Drawing.Size(671, 18)
        Me.LblInformacion.TabIndex = 3
        Me.LblInformacion.Text = "La siguiente lista muestra los pagos pendientes. Selecciona un cliente de la list" &
    "a para realizar el pago."
        '
        'StsBarra
        '
        Me.StsBarra.AutoSize = False
        Me.StsBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlblTitulo, Me.SlblMensaje})
        Me.StsBarra.Location = New System.Drawing.Point(0, 713)
        Me.StsBarra.Name = "StsBarra"
        Me.StsBarra.Size = New System.Drawing.Size(1493, 46)
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
        Me.BtnCerrar.Location = New System.Drawing.Point(1103, 624)
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
        Me.BtnPagar.Location = New System.Drawing.Point(1103, 60)
        Me.BtnPagar.Margin = New System.Windows.Forms.Padding(24, 0, 24, 0)
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
        Me.PnlBuscar.Size = New System.Drawing.Size(959, 42)
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
        Me.BtnLimpiar.Location = New System.Drawing.Point(914, 0)
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
        Me.TxtBuscar.Size = New System.Drawing.Size(669, 25)
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
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(1080, 199)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(55, 13)
        Me.Label.TabIndex = 87
        Me.Label.Text = "1052; 536"
        '
        'RbPayIndividual
        '
        Me.RbPayIndividual.Appearance = System.Windows.Forms.Appearance.Button
        Me.RbPayIndividual.Checked = True
        Me.RbPayIndividual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbPayIndividual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RbPayIndividual.Location = New System.Drawing.Point(0, 0)
        Me.RbPayIndividual.Margin = New System.Windows.Forms.Padding(0)
        Me.RbPayIndividual.Name = "RbPayIndividual"
        Me.RbPayIndividual.Size = New System.Drawing.Size(544, 32)
        Me.RbPayIndividual.TabIndex = 88
        Me.RbPayIndividual.TabStop = True
        Me.RbPayIndividual.Text = "Pagos individuales"
        Me.RbPayIndividual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RbPayIndividual.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.RbPayIndividual)
        Me.Panel1.Controls.Add(Me.RbPayGroup)
        Me.Panel1.Location = New System.Drawing.Point(25, 118)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(16, 16, 0, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1054, 36)
        Me.Panel1.TabIndex = 90
        '
        'RbPayGroup
        '
        Me.RbPayGroup.Appearance = System.Windows.Forms.Appearance.Button
        Me.RbPayGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbPayGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RbPayGroup.Location = New System.Drawing.Point(506, 0)
        Me.RbPayGroup.Margin = New System.Windows.Forms.Padding(0)
        Me.RbPayGroup.Name = "RbPayGroup"
        Me.RbPayGroup.Padding = New System.Windows.Forms.Padding(30, 0, 30, 0)
        Me.RbPayGroup.Size = New System.Drawing.Size(544, 32)
        Me.RbPayGroup.TabIndex = 91
        Me.RbPayGroup.Text = "Pagos grupales"
        Me.RbPayGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RbPayGroup.UseVisualStyleBackColor = True
        '
        'DgvFamilyGroup
        '
        Me.DgvFamilyGroup.AllowUserToAddRows = False
        Me.DgvFamilyGroup.AllowUserToDeleteRows = False
        Me.DgvFamilyGroup.AllowUserToResizeColumns = False
        Me.DgvFamilyGroup.AllowUserToResizeRows = False
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Linux Libertine Display G", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvFamilyGroup.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DgvFamilyGroup.ColumnHeadersHeight = 32
        Me.DgvFamilyGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvFamilyGroup.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nom_cli_gf, Me.nom_grp, Me.fdi_pgs_gf, Me.prc_pgs_gf, Me.dsc_pgs_gf, Me.total_pgs_gf, Me.ndias_pgs_gf, Me.pagar_pgs_gf, Me.empty, Me.id_pgs_gf, Me.id_grp, Me.num_intgrntes_grp, Me.grupo_familiar})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvFamilyGroup.DefaultCellStyle = DataGridViewCellStyle18
        Me.DgvFamilyGroup.Location = New System.Drawing.Point(25, 409)
        Me.DgvFamilyGroup.Margin = New System.Windows.Forms.Padding(16, 0, 0, 16)
        Me.DgvFamilyGroup.MultiSelect = False
        Me.DgvFamilyGroup.Name = "DgvFamilyGroup"
        Me.DgvFamilyGroup.ReadOnly = True
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvFamilyGroup.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.DgvFamilyGroup.RowHeadersWidth = 4
        Me.DgvFamilyGroup.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvFamilyGroup.RowTemplate.Height = 24
        Me.DgvFamilyGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvFamilyGroup.Size = New System.Drawing.Size(1460, 279)
        Me.DgvFamilyGroup.TabIndex = 91
        '
        'nom_cli_gf
        '
        Me.nom_cli_gf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nom_cli_gf.HeaderText = "INTEGRANTES"
        Me.nom_cli_gf.Name = "nom_cli_gf"
        Me.nom_cli_gf.ReadOnly = True
        Me.nom_cli_gf.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.nom_cli_gf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.nom_cli_gf.Width = 184
        '
        'nom_grp
        '
        Me.nom_grp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nom_grp.HeaderText = "NOMBRE DEL GRUPO"
        Me.nom_grp.Name = "nom_grp"
        Me.nom_grp.ReadOnly = True
        Me.nom_grp.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.nom_grp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.nom_grp.Width = 272
        '
        'fdi_pgs_gf
        '
        Me.fdi_pgs_gf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.fdi_pgs_gf.DefaultCellStyle = DataGridViewCellStyle12
        Me.fdi_pgs_gf.HeaderText = "MES Y AÑO"
        Me.fdi_pgs_gf.Name = "fdi_pgs_gf"
        Me.fdi_pgs_gf.ReadOnly = True
        Me.fdi_pgs_gf.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.fdi_pgs_gf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fdi_pgs_gf.Width = 128
        '
        'prc_pgs_gf
        '
        Me.prc_pgs_gf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.prc_pgs_gf.DefaultCellStyle = DataGridViewCellStyle13
        Me.prc_pgs_gf.HeaderText = "PRECIO"
        Me.prc_pgs_gf.Name = "prc_pgs_gf"
        Me.prc_pgs_gf.ReadOnly = True
        Me.prc_pgs_gf.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.prc_pgs_gf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.prc_pgs_gf.Width = 88
        '
        'dsc_pgs_gf
        '
        Me.dsc_pgs_gf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.dsc_pgs_gf.DefaultCellStyle = DataGridViewCellStyle14
        Me.dsc_pgs_gf.HeaderText = "DSCNTO"
        Me.dsc_pgs_gf.Name = "dsc_pgs_gf"
        Me.dsc_pgs_gf.ReadOnly = True
        Me.dsc_pgs_gf.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dsc_pgs_gf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dsc_pgs_gf.Width = 88
        '
        'total_pgs_gf
        '
        Me.total_pgs_gf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.total_pgs_gf.DefaultCellStyle = DataGridViewCellStyle15
        Me.total_pgs_gf.HeaderText = "TOTAL"
        Me.total_pgs_gf.Name = "total_pgs_gf"
        Me.total_pgs_gf.ReadOnly = True
        Me.total_pgs_gf.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.total_pgs_gf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_pgs_gf.Width = 88
        '
        'ndias_pgs_gf
        '
        Me.ndias_pgs_gf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ndias_pgs_gf.DefaultCellStyle = DataGridViewCellStyle16
        Me.ndias_pgs_gf.HeaderText = "Nº DE DIAS"
        Me.ndias_pgs_gf.Name = "ndias_pgs_gf"
        Me.ndias_pgs_gf.ReadOnly = True
        Me.ndias_pgs_gf.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ndias_pgs_gf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ndias_pgs_gf.Width = 88
        '
        'pagar_pgs_gf
        '
        Me.pagar_pgs_gf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.pagar_pgs_gf.DefaultCellStyle = DataGridViewCellStyle17
        Me.pagar_pgs_gf.HeaderText = "A PAGAR"
        Me.pagar_pgs_gf.Name = "pagar_pgs_gf"
        Me.pagar_pgs_gf.ReadOnly = True
        Me.pagar_pgs_gf.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.pagar_pgs_gf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.pagar_pgs_gf.Width = 88
        '
        'empty
        '
        Me.empty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.empty.HeaderText = ""
        Me.empty.MinimumWidth = 4
        Me.empty.Name = "empty"
        Me.empty.ReadOnly = True
        Me.empty.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.empty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.empty.Width = 4
        '
        'id_pgs_gf
        '
        Me.id_pgs_gf.HeaderText = "id_pgs"
        Me.id_pgs_gf.Name = "id_pgs_gf"
        Me.id_pgs_gf.ReadOnly = True
        Me.id_pgs_gf.Width = 50
        '
        'id_grp
        '
        Me.id_grp.HeaderText = "id_grp"
        Me.id_grp.Name = "id_grp"
        Me.id_grp.ReadOnly = True
        Me.id_grp.Width = 50
        '
        'num_intgrntes_grp
        '
        Me.num_intgrntes_grp.HeaderText = "num_intgrntes_grp"
        Me.num_intgrntes_grp.Name = "num_intgrntes_grp"
        Me.num_intgrntes_grp.ReadOnly = True
        Me.num_intgrntes_grp.Width = 50
        '
        'grupo_familiar
        '
        Me.grupo_familiar.HeaderText = "grupo_familiar"
        Me.grupo_familiar.Name = "grupo_familiar"
        Me.grupo_familiar.ReadOnly = True
        Me.grupo_familiar.Width = 250
        '
        'FrmListaMorosos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1493, 759)
        Me.Controls.Add(Me.DgvFamilyGroup)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.PnlBuscar)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.DgvIndividual)
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
        CType(Me.DgvIndividual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StsBarra.ResumeLayout(False)
        Me.StsBarra.PerformLayout()
        CType(Me.PbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBuscar.ResumeLayout(False)
        Me.PnlBuscar.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DgvFamilyGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCerrar As Button
    Friend WithEvents DgvIndividual As DataGridView
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
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents Label As Label
    Friend WithEvents nom_cli As DataGridViewTextBoxColumn
    Friend WithEvents ape_cli As DataGridViewTextBoxColumn
    Friend WithEvents fdn_cli As DataGridViewTextBoxColumn
    Friend WithEvents id_pgs As DataGridViewTextBoxColumn
    Friend WithEvents mesanio_pgs As DataGridViewTextBoxColumn
    Friend WithEvents prc_pgs As DataGridViewTextBoxColumn
    Friend WithEvents dsc_pgs As DataGridViewTextBoxColumn
    Friend WithEvents fdi_pgs As DataGridViewTextBoxColumn
    Friend WithEvents total_pgs As DataGridViewTextBoxColumn
    Friend WithEvents ndias_pgs As DataGridViewTextBoxColumn
    Friend WithEvents pagar_pgs As DataGridViewTextBoxColumn
    Friend WithEvents Column As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents RbPayIndividual As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RbPayGroup As RadioButton
    Friend WithEvents DgvFamilyGroup As DataGridView
    Friend WithEvents nom_cli_gf As DataGridViewTextBoxColumn
    Friend WithEvents nom_grp As DataGridViewTextBoxColumn
    Friend WithEvents fdi_pgs_gf As DataGridViewTextBoxColumn
    Friend WithEvents prc_pgs_gf As DataGridViewTextBoxColumn
    Friend WithEvents dsc_pgs_gf As DataGridViewTextBoxColumn
    Friend WithEvents total_pgs_gf As DataGridViewTextBoxColumn
    Friend WithEvents ndias_pgs_gf As DataGridViewTextBoxColumn
    Friend WithEvents pagar_pgs_gf As DataGridViewTextBoxColumn
    Friend WithEvents empty As DataGridViewTextBoxColumn
    Friend WithEvents id_pgs_gf As DataGridViewTextBoxColumn
    Friend WithEvents id_grp As DataGridViewTextBoxColumn
    Friend WithEvents num_intgrntes_grp As DataGridViewTextBoxColumn
    Friend WithEvents grupo_familiar As DataGridViewTextBoxColumn
End Class
