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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.LblInformacion = New System.Windows.Forms.Label()
        Me.TxtBuscarCliente = New System.Windows.Forms.TextBox()
        Me.StsBarra = New System.Windows.Forms.StatusStrip()
        Me.SlblTitulo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SlblMensaje = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SlblButton = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.PbLogo = New System.Windows.Forms.PictureBox()
        Me.BtnPagar = New System.Windows.Forms.Button()
        CType(Me.DgvMorosos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEncabezado.SuspendLayout()
        Me.StsBarra.SuspendLayout()
        CType(Me.PbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvMorosos
        '
        Me.DgvMorosos.AllowUserToAddRows = False
        Me.DgvMorosos.AllowUserToDeleteRows = False
        Me.DgvMorosos.AllowUserToResizeColumns = False
        Me.DgvMorosos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvMorosos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvMorosos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvMorosos.ColumnHeadersHeight = 35
        Me.DgvMorosos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvMorosos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNom, Me.colApe, Me.colEdad, Me.colMesAno, Me.colPrecio, Me.colDesct, Me.colTotal, Me.colNdias, Me.colApagar, Me.Column, Me.id_pgs, Me.fdi_pgs, Me.cliente})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvMorosos.DefaultCellStyle = DataGridViewCellStyle10
        Me.DgvMorosos.Location = New System.Drawing.Point(24, 116)
        Me.DgvMorosos.MultiSelect = False
        Me.DgvMorosos.Name = "DgvMorosos"
        Me.DgvMorosos.ReadOnly = True
        Me.DgvMorosos.RowHeadersWidth = 35
        Me.DgvMorosos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvMorosos.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.DgvMorosos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvMorosos.RowTemplate.Height = 27
        Me.DgvMorosos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvMorosos.Size = New System.Drawing.Size(1115, 518)
        Me.DgvMorosos.TabIndex = 2
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colEdad.DefaultCellStyle = DataGridViewCellStyle3
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colMesAno.DefaultCellStyle = DataGridViewCellStyle4
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
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colPrecio.DefaultCellStyle = DataGridViewCellStyle5
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
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colDesct.DefaultCellStyle = DataGridViewCellStyle6
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colTotal.DefaultCellStyle = DataGridViewCellStyle7
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
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colNdias.DefaultCellStyle = DataGridViewCellStyle8
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
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colApagar.DefaultCellStyle = DataGridViewCellStyle9
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
        Me.gbEncabezado.Controls.Add(Me.TxtBuscarCliente)
        Me.gbEncabezado.Location = New System.Drawing.Point(110, 51)
        Me.gbEncabezado.Name = "gbEncabezado"
        Me.gbEncabezado.Size = New System.Drawing.Size(865, 50)
        Me.gbEncabezado.TabIndex = 0
        Me.gbEncabezado.TabStop = False
        '
        'CmbBuscar
        '
        Me.CmbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBuscar.ForeColor = System.Drawing.Color.MediumBlue
        Me.CmbBuscar.FormattingEnabled = True
        Me.CmbBuscar.Items.AddRange(New Object() {"Nombre", "Apellido"})
        Me.CmbBuscar.Location = New System.Drawing.Point(104, 17)
        Me.CmbBuscar.Name = "CmbBuscar"
        Me.CmbBuscar.Size = New System.Drawing.Size(130, 24)
        Me.CmbBuscar.TabIndex = 1
        '
        'LblBuscar
        '
        Me.LblBuscar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscar.Location = New System.Drawing.Point(12, 16)
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
        Me.LblInformacion.ForeColor = System.Drawing.Color.Brown
        Me.LblInformacion.Location = New System.Drawing.Point(113, 24)
        Me.LblInformacion.Margin = New System.Windows.Forms.Padding(6)
        Me.LblInformacion.Name = "LblInformacion"
        Me.LblInformacion.Size = New System.Drawing.Size(835, 18)
        Me.LblInformacion.TabIndex = 3
        Me.LblInformacion.Text = "La siguiente lista muestra los pagos pendientes. Selecciona un cliente de la list" &
    "a para poder realizar el pago de la mensualidad."
        '
        'TxtBuscarCliente
        '
        Me.TxtBuscarCliente.BackColor = System.Drawing.SystemColors.Window
        Me.TxtBuscarCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscarCliente.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtBuscarCliente.Location = New System.Drawing.Point(240, 18)
        Me.TxtBuscarCliente.MaxLength = 30
        Me.TxtBuscarCliente.Name = "TxtBuscarCliente"
        Me.TxtBuscarCliente.Size = New System.Drawing.Size(576, 22)
        Me.TxtBuscarCliente.TabIndex = 0
        Me.TxtBuscarCliente.WordWrap = False
        '
        'StsBarra
        '
        Me.StsBarra.AutoSize = False
        Me.StsBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlblTitulo, Me.SlblMensaje, Me.SlblButton})
        Me.StsBarra.Location = New System.Drawing.Point(0, 657)
        Me.StsBarra.Name = "StsBarra"
        Me.StsBarra.Size = New System.Drawing.Size(1164, 46)
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
        Me.SlblMensaje.Size = New System.Drawing.Size(770, 42)
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
        Me.SlblButton.Size = New System.Drawing.Size(190, 42)
        Me.SlblButton.Text = "Button"
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
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCerrar.Location = New System.Drawing.Point(960, 663)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Padding = New System.Windows.Forms.Padding(4, 0, 8, 0)
        Me.BtnCerrar.Size = New System.Drawing.Size(170, 34)
        Me.BtnCerrar.TabIndex = 3
        Me.BtnCerrar.Text = "  &Cerrar ventana"
        Me.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.clear22
        Me.BtnLimpiar.Location = New System.Drawing.Point(822, 13)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(34, 30)
        Me.BtnLimpiar.TabIndex = 2
        Me.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'PbLogo
        '
        Me.PbLogo.Image = Global.ControlPagosGimnasio.My.Resources.Resources.caja_regis_60x60
        Me.PbLogo.Location = New System.Drawing.Point(24, 24)
        Me.PbLogo.Margin = New System.Windows.Forms.Padding(6)
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
        Me.BtnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPagar.Location = New System.Drawing.Point(984, 53)
        Me.BtnPagar.Name = "BtnPagar"
        Me.BtnPagar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.BtnPagar.Size = New System.Drawing.Size(155, 48)
        Me.BtnPagar.TabIndex = 1
        Me.BtnPagar.Text = "&Pagar mes"
        Me.BtnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPagar.UseVisualStyleBackColor = True
        '
        'FrmListaMorosos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 703)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.DgvMorosos)
        Me.Controls.Add(Me.gbEncabezado)
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
        Me.gbEncabezado.ResumeLayout(False)
        Me.gbEncabezado.PerformLayout()
        Me.StsBarra.ResumeLayout(False)
        Me.StsBarra.PerformLayout()
        CType(Me.PbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
