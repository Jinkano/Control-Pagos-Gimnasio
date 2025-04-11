<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTablaDescuento
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PnlBotonera = New System.Windows.Forms.Panel()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.GbDscto = New System.Windows.Forms.GroupBox()
        Me.TxtDscnto = New System.Windows.Forms.TextBox()
        Me.GbIntervaloEdad = New System.Windows.Forms.GroupBox()
        Me.NudEdadMax = New System.Windows.Forms.NumericUpDown()
        Me.NudEdadMin = New System.Windows.Forms.NumericUpDown()
        Me.LblMax = New System.Windows.Forms.Label()
        Me.LblMin = New System.Windows.Forms.Label()
        Me.GbPrecio = New System.Windows.Forms.GroupBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.DgvTarifas = New System.Windows.Forms.DataGridView()
        Me.id_tarifa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlBotonera.SuspendLayout()
        Me.GbDscto.SuspendLayout()
        Me.GbIntervaloEdad.SuspendLayout()
        CType(Me.NudEdadMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudEdadMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbPrecio.SuspendLayout()
        CType(Me.DgvTarifas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlBotonera
        '
        Me.PnlBotonera.BackColor = System.Drawing.Color.LightGray
        Me.PnlBotonera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlBotonera.Controls.Add(Me.BtnEliminar)
        Me.PnlBotonera.Controls.Add(Me.BtnCerrar)
        Me.PnlBotonera.Controls.Add(Me.BtnNuevo)
        Me.PnlBotonera.Controls.Add(Me.BtnGuardar)
        Me.PnlBotonera.Controls.Add(Me.BtnActualizar)
        Me.PnlBotonera.Controls.Add(Me.BtnModificar)
        Me.PnlBotonera.Controls.Add(Me.BtnCancelar)
        Me.PnlBotonera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlBotonera.Location = New System.Drawing.Point(0, 0)
        Me.PnlBotonera.Name = "PnlBotonera"
        Me.PnlBotonera.Size = New System.Drawing.Size(701, 76)
        Me.PnlBotonera.TabIndex = 0
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.eliminar_28x32
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(310, 10)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.BtnEliminar.Size = New System.Drawing.Size(140, 48)
        Me.BtnEliminar.TabIndex = 3
        Me.BtnEliminar.Text = "&Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.salir22
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCerrar.Location = New System.Drawing.Point(559, 10)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Padding = New System.Windows.Forms.Padding(6, 0, 4, 0)
        Me.BtnCerrar.Size = New System.Drawing.Size(115, 48)
        Me.BtnCerrar.TabIndex = 7
        Me.BtnCerrar.Text = "&Cerrar"
        Me.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Image = Global.ControlPagosGimnasio.My.Resources.Resources.nuevo_24x32
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(18, 10)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnNuevo.Size = New System.Drawing.Size(140, 48)
        Me.BtnNuevo.TabIndex = 1
        Me.BtnNuevo.Text = "&Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.guardar_28x32
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(18, 10)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Padding = New System.Windows.Forms.Padding(10, 0, 14, 0)
        Me.BtnGuardar.Size = New System.Drawing.Size(140, 48)
        Me.BtnGuardar.TabIndex = 4
        Me.BtnGuardar.Text = "&Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.editar_28x32
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(164, 10)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Padding = New System.Windows.Forms.Padding(10, 0, 11, 0)
        Me.BtnModificar.Size = New System.Drawing.Size(140, 48)
        Me.BtnModificar.TabIndex = 2
        Me.BtnModificar.Text = "&Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.cancel_28x32
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(164, 10)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.BtnCancelar.Size = New System.Drawing.Size(140, 48)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.actualizar_28x32
        Me.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizar.Location = New System.Drawing.Point(18, 10)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.BtnActualizar.Size = New System.Drawing.Size(140, 48)
        Me.BtnActualizar.TabIndex = 5
        Me.BtnActualizar.Text = "&Actualizar"
        Me.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'GbDscto
        '
        Me.GbDscto.Controls.Add(Me.TxtDscnto)
        Me.GbDscto.Enabled = False
        Me.GbDscto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbDscto.Location = New System.Drawing.Point(546, 99)
        Me.GbDscto.Name = "GbDscto"
        Me.GbDscto.Size = New System.Drawing.Size(130, 72)
        Me.GbDscto.TabIndex = 3
        Me.GbDscto.TabStop = False
        Me.GbDscto.Text = "Descuento"
        '
        'TxtDscnto
        '
        Me.TxtDscnto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDscnto.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDscnto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDscnto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDscnto.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtDscnto.Location = New System.Drawing.Point(15, 32)
        Me.TxtDscnto.MaxLength = 10
        Me.TxtDscnto.Name = "TxtDscnto"
        Me.TxtDscnto.Size = New System.Drawing.Size(100, 26)
        Me.TxtDscnto.TabIndex = 0
        Me.TxtDscnto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtDscnto.WordWrap = False
        '
        'GbIntervaloEdad
        '
        Me.GbIntervaloEdad.Controls.Add(Me.NudEdadMax)
        Me.GbIntervaloEdad.Controls.Add(Me.NudEdadMin)
        Me.GbIntervaloEdad.Controls.Add(Me.LblMax)
        Me.GbIntervaloEdad.Controls.Add(Me.LblMin)
        Me.GbIntervaloEdad.Enabled = False
        Me.GbIntervaloEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbIntervaloEdad.Location = New System.Drawing.Point(174, 99)
        Me.GbIntervaloEdad.Name = "GbIntervaloEdad"
        Me.GbIntervaloEdad.Size = New System.Drawing.Size(344, 72)
        Me.GbIntervaloEdad.TabIndex = 2
        Me.GbIntervaloEdad.TabStop = False
        Me.GbIntervaloEdad.Text = "Intervalo de edad"
        '
        'NudEdadMax
        '
        Me.NudEdadMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudEdadMax.ForeColor = System.Drawing.Color.MediumBlue
        Me.NudEdadMax.Location = New System.Drawing.Point(245, 31)
        Me.NudEdadMax.Margin = New System.Windows.Forms.Padding(10)
        Me.NudEdadMax.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.NudEdadMax.Name = "NudEdadMax"
        Me.NudEdadMax.Size = New System.Drawing.Size(86, 26)
        Me.NudEdadMax.TabIndex = 1
        Me.NudEdadMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NudEdadMin
        '
        Me.NudEdadMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudEdadMin.ForeColor = System.Drawing.Color.MediumBlue
        Me.NudEdadMin.Location = New System.Drawing.Point(71, 31)
        Me.NudEdadMin.Margin = New System.Windows.Forms.Padding(10)
        Me.NudEdadMin.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.NudEdadMin.Name = "NudEdadMin"
        Me.NudEdadMin.Size = New System.Drawing.Size(86, 26)
        Me.NudEdadMin.TabIndex = 0
        Me.NudEdadMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblMax
        '
        Me.LblMax.AutoSize = True
        Me.LblMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMax.Location = New System.Drawing.Point(184, 36)
        Me.LblMax.Name = "LblMax"
        Me.LblMax.Size = New System.Drawing.Size(54, 16)
        Me.LblMax.TabIndex = 39
        Me.LblMax.Text = "Maximo"
        '
        'LblMin
        '
        Me.LblMin.AutoSize = True
        Me.LblMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMin.Location = New System.Drawing.Point(14, 36)
        Me.LblMin.Name = "LblMin"
        Me.LblMin.Size = New System.Drawing.Size(50, 16)
        Me.LblMin.TabIndex = 38
        Me.LblMin.Text = "Minimo"
        '
        'GbPrecio
        '
        Me.GbPrecio.Controls.Add(Me.TxtPrecio)
        Me.GbPrecio.Enabled = False
        Me.GbPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbPrecio.Location = New System.Drawing.Point(20, 99)
        Me.GbPrecio.Name = "GbPrecio"
        Me.GbPrecio.Size = New System.Drawing.Size(130, 72)
        Me.GbPrecio.TabIndex = 1
        Me.GbPrecio.TabStop = False
        Me.GbPrecio.Text = "Precio"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPrecio.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecio.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtPrecio.Location = New System.Drawing.Point(15, 31)
        Me.TxtPrecio.MaxLength = 10
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(100, 26)
        Me.TxtPrecio.TabIndex = 0
        Me.TxtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtPrecio.WordWrap = False
        '
        'DgvTarifas
        '
        Me.DgvTarifas.AllowUserToAddRows = False
        Me.DgvTarifas.AllowUserToDeleteRows = False
        Me.DgvTarifas.AllowUserToResizeColumns = False
        Me.DgvTarifas.AllowUserToResizeRows = False
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvTarifas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvTarifas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DgvTarifas.ColumnHeadersHeight = 35
        Me.DgvTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvTarifas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_tarifa, Me.colPrecio, Me.colEmin, Me.colEmax, Me.colDescuento})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvTarifas.DefaultCellStyle = DataGridViewCellStyle13
        Me.DgvTarifas.Location = New System.Drawing.Point(20, 190)
        Me.DgvTarifas.MultiSelect = False
        Me.DgvTarifas.Name = "DgvTarifas"
        Me.DgvTarifas.ReadOnly = True
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvTarifas.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DgvTarifas.RowHeadersWidth = 35
        Me.DgvTarifas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvTarifas.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.DgvTarifas.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DgvTarifas.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvTarifas.RowTemplate.DividerHeight = 2
        Me.DgvTarifas.RowTemplate.Height = 30
        Me.DgvTarifas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvTarifas.Size = New System.Drawing.Size(656, 200)
        Me.DgvTarifas.TabIndex = 8
        '
        'id_tarifa
        '
        Me.id_tarifa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.id_tarifa.HeaderText = "id"
        Me.id_tarifa.Name = "id_tarifa"
        Me.id_tarifa.ReadOnly = True
        Me.id_tarifa.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.id_tarifa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.id_tarifa.Visible = False
        Me.id_tarifa.Width = 20
        '
        'colPrecio
        '
        Me.colPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colPrecio.HeaderText = "PRECIO"
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.ReadOnly = True
        Me.colPrecio.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colPrecio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colPrecio.Width = 150
        '
        'colEmin
        '
        Me.colEmin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colEmin.HeaderText = "EDAD MIN"
        Me.colEmin.Name = "colEmin"
        Me.colEmin.ReadOnly = True
        Me.colEmin.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colEmin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colEmin.Width = 150
        '
        'colEmax
        '
        Me.colEmax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colEmax.HeaderText = "EDAD MAX"
        Me.colEmax.Name = "colEmax"
        Me.colEmax.ReadOnly = True
        Me.colEmax.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colEmax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colEmax.Width = 150
        '
        'colDescuento
        '
        Me.colDescuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colDescuento.HeaderText = "DESCUENTO"
        Me.colDescuento.Name = "colDescuento"
        Me.colDescuento.ReadOnly = True
        Me.colDescuento.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDescuento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDescuento.Width = 150
        '
        'FrmTablaDescuento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 431)
        Me.Controls.Add(Me.PnlBotonera)
        Me.Controls.Add(Me.GbDscto)
        Me.Controls.Add(Me.GbIntervaloEdad)
        Me.Controls.Add(Me.GbPrecio)
        Me.Controls.Add(Me.DgvTarifas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmTablaDescuento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tabla de precios y descuentos"
        Me.PnlBotonera.ResumeLayout(False)
        Me.GbDscto.ResumeLayout(False)
        Me.GbDscto.PerformLayout()
        Me.GbIntervaloEdad.ResumeLayout(False)
        Me.GbIntervaloEdad.PerformLayout()
        CType(Me.NudEdadMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudEdadMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbPrecio.ResumeLayout(False)
        Me.GbPrecio.PerformLayout()
        CType(Me.DgvTarifas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlBotonera As Panel
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents GbDscto As GroupBox
    Friend WithEvents TxtDscnto As TextBox
    Friend WithEvents GbIntervaloEdad As GroupBox
    Friend WithEvents NudEdadMax As NumericUpDown
    Friend WithEvents NudEdadMin As NumericUpDown
    Friend WithEvents LblMax As Label
    Friend WithEvents LblMin As Label
    Friend WithEvents GbPrecio As GroupBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents DgvTarifas As DataGridView
    Friend WithEvents id_tarifa As DataGridViewTextBoxColumn
    Friend WithEvents colPrecio As DataGridViewTextBoxColumn
    Friend WithEvents colEmin As DataGridViewTextBoxColumn
    Friend WithEvents colEmax As DataGridViewTextBoxColumn
    Friend WithEvents colDescuento As DataGridViewTextBoxColumn
End Class
