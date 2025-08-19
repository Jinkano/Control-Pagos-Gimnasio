<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_modify_A
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
        Dim DataGridViewCellStyle101 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle102 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle103 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle104 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle105 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle106 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle107 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle108 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle109 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle110 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvDescuentos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvTarifas = New System.Windows.Forms.DataGridView()
        Me.id_tarifa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTipoPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnCancelPrecio = New System.Windows.Forms.Button()
        Me.BtnGuardarPrecio = New System.Windows.Forms.Button()
        Me.PnlBotonera = New System.Windows.Forms.Panel()
        Me.BtnFijarPrecio = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.GbFormulario = New System.Windows.Forms.GroupBox()
        Me.LblDscto = New System.Windows.Forms.Label()
        Me.TxtDscnto = New System.Windows.Forms.TextBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.CmbTipoPago = New System.Windows.Forms.ComboBox()
        Me.NudEdadMax = New System.Windows.Forms.NumericUpDown()
        Me.LblTipoPago = New System.Windows.Forms.Label()
        Me.NudEdadMin = New System.Windows.Forms.NumericUpDown()
        Me.LblMax = New System.Windows.Forms.Label()
        Me.LblMin = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtEdad = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvDescuentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvTarifas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBotonera.SuspendLayout()
        Me.GbFormulario.SuspendLayout()
        CType(Me.NudEdadMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudEdadMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvDescuentos)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 289)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox2.Size = New System.Drawing.Size(401, 188)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LISTA DE DESCUENTOS"
        '
        'DgvDescuentos
        '
        Me.DgvDescuentos.AllowUserToAddRows = False
        Me.DgvDescuentos.AllowUserToDeleteRows = False
        Me.DgvDescuentos.AllowUserToResizeColumns = False
        Me.DgvDescuentos.AllowUserToResizeRows = False
        DataGridViewCellStyle101.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle101.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle101.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvDescuentos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle101
        DataGridViewCellStyle102.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle102.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle102.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle102.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle102.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle102.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle102.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDescuentos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle102
        Me.DgvDescuentos.ColumnHeadersHeight = 35
        Me.DgvDescuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvDescuentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.Column2})
        DataGridViewCellStyle103.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle103.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle103.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle103.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle103.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle103.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle103.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvDescuentos.DefaultCellStyle = DataGridViewCellStyle103
        Me.DgvDescuentos.Location = New System.Drawing.Point(15, 26)
        Me.DgvDescuentos.MultiSelect = False
        Me.DgvDescuentos.Name = "DgvDescuentos"
        Me.DgvDescuentos.ReadOnly = True
        DataGridViewCellStyle104.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle104.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle104.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle104.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle104.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle104.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle104.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDescuentos.RowHeadersDefaultCellStyle = DataGridViewCellStyle104
        Me.DgvDescuentos.RowHeadersWidth = 35
        Me.DgvDescuentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle105.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle105.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvDescuentos.RowsDefaultCellStyle = DataGridViewCellStyle105
        Me.DgvDescuentos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DgvDescuentos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvDescuentos.RowTemplate.DividerHeight = 2
        Me.DgvDescuentos.RowTemplate.Height = 30
        Me.DgvDescuentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvDescuentos.Size = New System.Drawing.Size(632, 55)
        Me.DgvDescuentos.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvTarifas)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBox1.Size = New System.Drawing.Size(416, 188)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LISTA DE TARIFAS"
        '
        'DgvTarifas
        '
        Me.DgvTarifas.AllowUserToAddRows = False
        Me.DgvTarifas.AllowUserToDeleteRows = False
        Me.DgvTarifas.AllowUserToResizeColumns = False
        Me.DgvTarifas.AllowUserToResizeRows = False
        DataGridViewCellStyle106.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle106.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle106.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvTarifas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle106
        DataGridViewCellStyle107.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle107.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle107.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle107.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle107.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle107.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle107.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvTarifas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle107
        Me.DgvTarifas.ColumnHeadersHeight = 35
        Me.DgvTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvTarifas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_tarifa, Me.colTipoPago, Me.colPrecio})
        DataGridViewCellStyle108.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle108.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle108.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle108.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle108.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle108.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle108.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvTarifas.DefaultCellStyle = DataGridViewCellStyle108
        Me.DgvTarifas.Location = New System.Drawing.Point(15, 29)
        Me.DgvTarifas.MultiSelect = False
        Me.DgvTarifas.Name = "DgvTarifas"
        Me.DgvTarifas.ReadOnly = True
        DataGridViewCellStyle109.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle109.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle109.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle109.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle109.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle109.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle109.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvTarifas.RowHeadersDefaultCellStyle = DataGridViewCellStyle109
        Me.DgvTarifas.RowHeadersWidth = 35
        Me.DgvTarifas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle110.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle110.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvTarifas.RowsDefaultCellStyle = DataGridViewCellStyle110
        Me.DgvTarifas.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DgvTarifas.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvTarifas.RowTemplate.DividerHeight = 2
        Me.DgvTarifas.RowTemplate.Height = 30
        Me.DgvTarifas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvTarifas.Size = New System.Drawing.Size(386, 144)
        Me.DgvTarifas.TabIndex = 43
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
        'colTipoPago
        '
        Me.colTipoPago.HeaderText = "TIPO PAGO"
        Me.colTipoPago.Name = "colTipoPago"
        Me.colTipoPago.ReadOnly = True
        Me.colTipoPago.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colTipoPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colTipoPago.Width = 165
        '
        'colPrecio
        '
        Me.colPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colPrecio.HeaderText = "PRECIO"
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.ReadOnly = True
        Me.colPrecio.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colPrecio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colPrecio.Width = 165
        '
        'BtnCancelPrecio
        '
        Me.BtnCancelPrecio.Enabled = False
        Me.BtnCancelPrecio.FlatAppearance.BorderSize = 0
        Me.BtnCancelPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelPrecio.Image = Global.ControlPagosGimnasio.My.Resources.Resources.clear22
        Me.BtnCancelPrecio.Location = New System.Drawing.Point(1174, 588)
        Me.BtnCancelPrecio.Name = "BtnCancelPrecio"
        Me.BtnCancelPrecio.Size = New System.Drawing.Size(30, 26)
        Me.BtnCancelPrecio.TabIndex = 13
        Me.BtnCancelPrecio.UseVisualStyleBackColor = True
        '
        'BtnGuardarPrecio
        '
        Me.BtnGuardarPrecio.Enabled = False
        Me.BtnGuardarPrecio.FlatAppearance.BorderSize = 0
        Me.BtnGuardarPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarPrecio.Image = Global.ControlPagosGimnasio.My.Resources.Resources.guardar_22x22
        Me.BtnGuardarPrecio.Location = New System.Drawing.Point(1142, 588)
        Me.BtnGuardarPrecio.Name = "BtnGuardarPrecio"
        Me.BtnGuardarPrecio.Size = New System.Drawing.Size(26, 26)
        Me.BtnGuardarPrecio.TabIndex = 11
        Me.BtnGuardarPrecio.UseVisualStyleBackColor = True
        '
        'PnlBotonera
        '
        Me.PnlBotonera.AutoSize = True
        Me.PnlBotonera.BackColor = System.Drawing.Color.LightGray
        Me.PnlBotonera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlBotonera.Controls.Add(Me.BtnFijarPrecio)
        Me.PnlBotonera.Controls.Add(Me.BtnNuevo)
        Me.PnlBotonera.Controls.Add(Me.BtnEliminar)
        Me.PnlBotonera.Controls.Add(Me.BtnCancelar)
        Me.PnlBotonera.Controls.Add(Me.BtnGuardar)
        Me.PnlBotonera.Controls.Add(Me.BtnModificar)
        Me.PnlBotonera.Controls.Add(Me.BtnActualizar)
        Me.PnlBotonera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlBotonera.Location = New System.Drawing.Point(0, 0)
        Me.PnlBotonera.Name = "PnlBotonera"
        Me.PnlBotonera.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.PnlBotonera.Size = New System.Drawing.Size(1366, 78)
        Me.PnlBotonera.TabIndex = 8
        '
        'BtnFijarPrecio
        '
        Me.BtnFijarPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFijarPrecio.Image = Global.ControlPagosGimnasio.My.Resources.Resources.fijar_precio_34x30
        Me.BtnFijarPrecio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFijarPrecio.Location = New System.Drawing.Point(23, 13)
        Me.BtnFijarPrecio.Name = "BtnFijarPrecio"
        Me.BtnFijarPrecio.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.BtnFijarPrecio.Size = New System.Drawing.Size(155, 48)
        Me.BtnFijarPrecio.TabIndex = 0
        Me.BtnFijarPrecio.Text = "&Fijar precio"
        Me.BtnFijarPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFijarPrecio.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Image = Global.ControlPagosGimnasio.My.Resources.Resources.nuevo_24x32
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(311, 13)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Padding = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.BtnNuevo.Size = New System.Drawing.Size(170, 48)
        Me.BtnNuevo.TabIndex = 1
        Me.BtnNuevo.Text = "&Nuevo dscnto"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.eliminar_28x32
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(643, 13)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Padding = New System.Windows.Forms.Padding(14, 0, 14, 0)
        Me.BtnEliminar.Size = New System.Drawing.Size(140, 48)
        Me.BtnEliminar.TabIndex = 3
        Me.BtnEliminar.Text = "&Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.cancel_28x28
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(643, 13)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Padding = New System.Windows.Forms.Padding(14, 0, 14, 0)
        Me.BtnCancelar.Size = New System.Drawing.Size(140, 48)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.UseVisualStyleBackColor = True
        Me.BtnCancelar.Visible = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.guardar_28x32
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(487, 13)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Padding = New System.Windows.Forms.Padding(18, 0, 18, 0)
        Me.BtnGuardar.Size = New System.Drawing.Size(150, 48)
        Me.BtnGuardar.TabIndex = 4
        Me.BtnGuardar.Text = "&Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = True
        Me.BtnGuardar.Visible = False
        '
        'BtnModificar
        '
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.editar_28x32
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(487, 13)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Padding = New System.Windows.Forms.Padding(16, 0, 16, 0)
        Me.BtnModificar.Size = New System.Drawing.Size(150, 48)
        Me.BtnModificar.TabIndex = 2
        Me.BtnModificar.Text = "&Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.actualizar_28x27
        Me.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizar.Location = New System.Drawing.Point(487, 13)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Padding = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.BtnActualizar.Size = New System.Drawing.Size(150, 48)
        Me.BtnActualizar.TabIndex = 5
        Me.BtnActualizar.Text = "&Actualizar"
        Me.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnActualizar.UseVisualStyleBackColor = True
        Me.BtnActualizar.Visible = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCerrar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.salir22
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCerrar.Location = New System.Drawing.Point(1142, 526)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.BtnCerrar.Size = New System.Drawing.Size(170, 40)
        Me.BtnCerrar.TabIndex = 14
        Me.BtnCerrar.Text = "&Cerrar ventana"
        Me.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'GbFormulario
        '
        Me.GbFormulario.AutoSize = True
        Me.GbFormulario.Controls.Add(Me.TextBox1)
        Me.GbFormulario.Enabled = False
        Me.GbFormulario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbFormulario.Location = New System.Drawing.Point(1143, 460)
        Me.GbFormulario.Name = "GbFormulario"
        Me.GbFormulario.Padding = New System.Windows.Forms.Padding(20, 12, 20, 0)
        Me.GbFormulario.Size = New System.Drawing.Size(211, 60)
        Me.GbFormulario.TabIndex = 9
        Me.GbFormulario.TabStop = False
        '
        'LblDscto
        '
        Me.LblDscto.AutoSize = True
        Me.LblDscto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDscto.Location = New System.Drawing.Point(735, 329)
        Me.LblDscto.Name = "LblDscto"
        Me.LblDscto.Size = New System.Drawing.Size(81, 16)
        Me.LblDscto.TabIndex = 4
        Me.LblDscto.Text = "Descuento"
        Me.LblDscto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDscnto
        '
        Me.TxtDscnto.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDscnto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDscnto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDscnto.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtDscnto.Location = New System.Drawing.Point(822, 323)
        Me.TxtDscnto.MaxLength = 10
        Me.TxtDscnto.Name = "TxtDscnto"
        Me.TxtDscnto.Size = New System.Drawing.Size(121, 26)
        Me.TxtDscnto.TabIndex = 4
        Me.TxtDscnto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtDscnto.WordWrap = False
        '
        'TxtPrecio
        '
        Me.TxtPrecio.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecio.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtPrecio.Location = New System.Drawing.Point(600, 323)
        Me.TxtPrecio.MaxLength = 10
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(121, 26)
        Me.TxtPrecio.TabIndex = 1
        Me.TxtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtPrecio.WordWrap = False
        '
        'LblPrecio
        '
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecio.Location = New System.Drawing.Point(542, 329)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(52, 16)
        Me.LblPrecio.TabIndex = 1
        Me.LblPrecio.Text = "Precio"
        Me.LblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbTipoPago
        '
        Me.CmbTipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTipoPago.ForeColor = System.Drawing.Color.MediumBlue
        Me.CmbTipoPago.FormattingEnabled = True
        Me.CmbTipoPago.Items.AddRange(New Object() {"BONO", "DIARIO", "GRUPAL", "MENSUAL"})
        Me.CmbTipoPago.Location = New System.Drawing.Point(652, 121)
        Me.CmbTipoPago.Name = "CmbTipoPago"
        Me.CmbTipoPago.Size = New System.Drawing.Size(167, 24)
        Me.CmbTipoPago.TabIndex = 0
        '
        'NudEdadMax
        '
        Me.NudEdadMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudEdadMax.ForeColor = System.Drawing.Color.MediumBlue
        Me.NudEdadMax.Location = New System.Drawing.Point(919, 259)
        Me.NudEdadMax.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.NudEdadMax.Name = "NudEdadMax"
        Me.NudEdadMax.Size = New System.Drawing.Size(121, 26)
        Me.NudEdadMax.TabIndex = 3
        Me.NudEdadMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblTipoPago
        '
        Me.LblTipoPago.AutoSize = True
        Me.LblTipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipoPago.Location = New System.Drawing.Point(545, 124)
        Me.LblTipoPago.Name = "LblTipoPago"
        Me.LblTipoPago.Size = New System.Drawing.Size(101, 16)
        Me.LblTipoPago.TabIndex = 0
        Me.LblTipoPago.Text = "Tipo de pago"
        Me.LblTipoPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NudEdadMin
        '
        Me.NudEdadMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudEdadMin.ForeColor = System.Drawing.Color.MediumBlue
        Me.NudEdadMin.Location = New System.Drawing.Point(661, 259)
        Me.NudEdadMin.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.NudEdadMin.Name = "NudEdadMin"
        Me.NudEdadMin.Size = New System.Drawing.Size(121, 26)
        Me.NudEdadMin.TabIndex = 2
        Me.NudEdadMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblMax
        '
        Me.LblMax.AutoSize = True
        Me.LblMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMax.Location = New System.Drawing.Point(796, 264)
        Me.LblMax.Name = "LblMax"
        Me.LblMax.Size = New System.Drawing.Size(101, 16)
        Me.LblMax.TabIndex = 3
        Me.LblMax.Text = "Edad Maxima"
        '
        'LblMin
        '
        Me.LblMin.AutoSize = True
        Me.LblMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMin.Location = New System.Drawing.Point(558, 264)
        Me.LblMin.Name = "LblMin"
        Me.LblMin.Size = New System.Drawing.Size(97, 16)
        Me.LblMin.TabIndex = 2
        Me.LblMin.Text = "Edad Minima"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 20
        '
        'Column1
        '
        Me.Column1.HeaderText = "PRECIO"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.HeaderText = "EDAD MIN"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 110
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn5.HeaderText = "EDAD MAX"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn5.Width = 110
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn6.HeaderText = "DESCUENTO"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn6.Width = 110
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column2.Width = 110
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.MediumBlue
        Me.TextBox1.Location = New System.Drawing.Point(0, 13)
        Me.TextBox1.MaxLength = 10
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(188, 26)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox1.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(545, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Num de integrantes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.MediumBlue
        Me.NumericUpDown1.Location = New System.Drawing.Point(548, 209)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(138, 26)
        Me.NumericUpDown1.TabIndex = 17
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(717, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nombre del tipo de pago"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtEdad
        '
        Me.TxtEdad.BackColor = System.Drawing.SystemColors.Window
        Me.TxtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEdad.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtEdad.Location = New System.Drawing.Point(720, 209)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(177, 26)
        Me.TxtEdad.TabIndex = 19
        Me.TxtEdad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(960, 329)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "A pagar"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.MediumBlue
        Me.TextBox2.Location = New System.Drawing.Point(1028, 323)
        Me.TextBox2.MaxLength = 10
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(121, 26)
        Me.TextBox2.TabIndex = 21
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox2.WordWrap = False
        '
        'A_modify_A
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 640)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.NudEdadMax)
        Me.Controls.Add(Me.LblDscto)
        Me.Controls.Add(Me.LblMax)
        Me.Controls.Add(Me.NudEdadMin)
        Me.Controls.Add(Me.TxtDscnto)
        Me.Controls.Add(Me.TxtEdad)
        Me.Controls.Add(Me.LblMin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Me.LblPrecio)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnCancelPrecio)
        Me.Controls.Add(Me.BtnGuardarPrecio)
        Me.Controls.Add(Me.CmbTipoPago)
        Me.Controls.Add(Me.PnlBotonera)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.LblTipoPago)
        Me.Controls.Add(Me.GbFormulario)
        Me.Name = "A_modify_A"
        Me.Text = "A_modify_A"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvDescuentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvTarifas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBotonera.ResumeLayout(False)
        Me.GbFormulario.ResumeLayout(False)
        Me.GbFormulario.PerformLayout()
        CType(Me.NudEdadMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudEdadMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DgvDescuentos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgvTarifas As DataGridView
    Friend WithEvents id_tarifa As DataGridViewTextBoxColumn
    Friend WithEvents colTipoPago As DataGridViewTextBoxColumn
    Friend WithEvents colPrecio As DataGridViewTextBoxColumn
    Friend WithEvents BtnCancelPrecio As Button
    Friend WithEvents BtnGuardarPrecio As Button
    Friend WithEvents PnlBotonera As Panel
    Friend WithEvents BtnFijarPrecio As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents GbFormulario As GroupBox
    Friend WithEvents LblDscto As Label
    Friend WithEvents TxtDscnto As TextBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents LblPrecio As Label
    Friend WithEvents CmbTipoPago As ComboBox
    Friend WithEvents NudEdadMax As NumericUpDown
    Friend WithEvents LblTipoPago As Label
    Friend WithEvents NudEdadMin As NumericUpDown
    Friend WithEvents LblMax As Label
    Friend WithEvents LblMin As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtEdad As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
End Class
