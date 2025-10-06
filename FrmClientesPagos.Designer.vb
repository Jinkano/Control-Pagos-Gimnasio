<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmClientesPagos
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
        Dim DataGridViewCellStyle53 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle54 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle64 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle65 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle55 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle56 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle57 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle58 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle59 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle60 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle61 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle62 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle63 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClientesPagos))
        Me.DgvListaPagos = New System.Windows.Forms.DataGridView()
        Me.idPagos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFdiPgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrcPgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNdias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApagar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFdpPgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFrmPgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlBotonera = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnPagarMes = New System.Windows.Forms.Button()
        Me.BtnNuevoPago = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.StsBarra = New System.Windows.Forms.StatusStrip()
        Me.SlblTitulo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SlblDescrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RbInactivo = New System.Windows.Forms.RadioButton()
        Me.RbActivo = New System.Windows.Forms.RadioButton()
        Me.GbDatosCliente = New System.Windows.Forms.GroupBox()
        Me.LblEdad = New System.Windows.Forms.Label()
        Me.LblEdadCli = New System.Windows.Forms.Label()
        Me.LblGrupoFamiliar = New System.Windows.Forms.Label()
        Me.LblMtdPgo = New System.Windows.Forms.Label()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.LblFechaInscripcion = New System.Windows.Forms.Label()
        Me.LblMetodoPago = New System.Windows.Forms.Label()
        Me.LblFdiCli = New System.Windows.Forms.Label()
        Me.LblGrpFam = New System.Windows.Forms.Label()
        Me.LblEstCli = New System.Windows.Forms.Label()
        Me.LblApeCli = New System.Windows.Forms.Label()
        Me.LblFdnCli = New System.Windows.Forms.Label()
        Me.LblNomCli = New System.Windows.Forms.Label()
        Me.LblFechaNacimiento = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.GbListaPagos = New System.Windows.Forms.GroupBox()
        Me.GbBusqueda = New System.Windows.Forms.GroupBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.CmbFiltrar = New System.Windows.Forms.ComboBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.LblFiltrar = New System.Windows.Forms.Label()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.LblTlfCli = New System.Windows.Forms.Label()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.LblEmlCli = New System.Windows.Forms.Label()
        Me.LblDirCli = New System.Windows.Forms.Label()
        Me.LblLetrero = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DgvListaPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBotonera.SuspendLayout()
        Me.StsBarra.SuspendLayout()
        Me.GbDatosCliente.SuspendLayout()
        Me.GbBusqueda.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvListaPagos
        '
        Me.DgvListaPagos.AllowUserToAddRows = False
        Me.DgvListaPagos.AllowUserToDeleteRows = False
        Me.DgvListaPagos.AllowUserToResizeColumns = False
        Me.DgvListaPagos.AllowUserToResizeRows = False
        DataGridViewCellStyle53.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle53.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvListaPagos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle53
        DataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle54.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle54.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle54.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle54.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle54.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvListaPagos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle54
        Me.DgvListaPagos.ColumnHeadersHeight = 35
        Me.DgvListaPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvListaPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idPagos, Me.colFdiPgs, Me.colPrcPgs, Me.colDescuento, Me.colTotal, Me.colNdias, Me.colApagar, Me.colFdpPgs, Me.colFrmPgs, Me.colUsuario})
        DataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle64.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle64.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle64.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle64.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle64.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle64.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvListaPagos.DefaultCellStyle = DataGridViewCellStyle64
        Me.DgvListaPagos.Location = New System.Drawing.Point(36, 483)
        Me.DgvListaPagos.Margin = New System.Windows.Forms.Padding(8)
        Me.DgvListaPagos.MultiSelect = False
        Me.DgvListaPagos.Name = "DgvListaPagos"
        Me.DgvListaPagos.ReadOnly = True
        Me.DgvListaPagos.RowHeadersWidth = 35
        Me.DgvListaPagos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle65.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle65.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvListaPagos.RowsDefaultCellStyle = DataGridViewCellStyle65
        Me.DgvListaPagos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvListaPagos.RowTemplate.Height = 27
        Me.DgvListaPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvListaPagos.Size = New System.Drawing.Size(1085, 276)
        Me.DgvListaPagos.TabIndex = 3
        '
        'idPagos
        '
        Me.idPagos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.idPagos.HeaderText = "idPagos"
        Me.idPagos.Name = "idPagos"
        Me.idPagos.ReadOnly = True
        Me.idPagos.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.idPagos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.idPagos.Visible = False
        Me.idPagos.Width = 65
        '
        'colFdiPgs
        '
        Me.colFdiPgs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colFdiPgs.DefaultCellStyle = DataGridViewCellStyle55
        Me.colFdiPgs.HeaderText = "FECHA DE INICIO"
        Me.colFdiPgs.Name = "colFdiPgs"
        Me.colFdiPgs.ReadOnly = True
        Me.colFdiPgs.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colFdiPgs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colFdiPgs.Width = 170
        '
        'colPrcPgs
        '
        Me.colPrcPgs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colPrcPgs.DefaultCellStyle = DataGridViewCellStyle56
        Me.colPrcPgs.HeaderText = "PRECIO"
        Me.colPrcPgs.Name = "colPrcPgs"
        Me.colPrcPgs.ReadOnly = True
        Me.colPrcPgs.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colPrcPgs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colPrcPgs.Width = 90
        '
        'colDescuento
        '
        Me.colDescuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colDescuento.DefaultCellStyle = DataGridViewCellStyle57
        Me.colDescuento.HeaderText = "DESCT"
        Me.colDescuento.Name = "colDescuento"
        Me.colDescuento.ReadOnly = True
        Me.colDescuento.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDescuento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDescuento.Width = 90
        '
        'colTotal
        '
        Me.colTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colTotal.DefaultCellStyle = DataGridViewCellStyle58
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
        DataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colNdias.DefaultCellStyle = DataGridViewCellStyle59
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
        DataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colApagar.DefaultCellStyle = DataGridViewCellStyle60
        Me.colApagar.HeaderText = "A PAGAR"
        Me.colApagar.Name = "colApagar"
        Me.colApagar.ReadOnly = True
        Me.colApagar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colApagar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colApagar.Width = 90
        '
        'colFdpPgs
        '
        Me.colFdpPgs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colFdpPgs.DefaultCellStyle = DataGridViewCellStyle61
        Me.colFdpPgs.HeaderText = "FECHA DE PAGO"
        Me.colFdpPgs.Name = "colFdpPgs"
        Me.colFdpPgs.ReadOnly = True
        Me.colFdpPgs.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colFdpPgs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colFdpPgs.Width = 170
        '
        'colFrmPgs
        '
        Me.colFrmPgs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colFrmPgs.DefaultCellStyle = DataGridViewCellStyle62
        Me.colFrmPgs.HeaderText = "FORMA DE PAGO"
        Me.colFrmPgs.Name = "colFrmPgs"
        Me.colFrmPgs.ReadOnly = True
        Me.colFrmPgs.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colFrmPgs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colFrmPgs.Width = 140
        '
        'colUsuario
        '
        Me.colUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colUsuario.DefaultCellStyle = DataGridViewCellStyle63
        Me.colUsuario.HeaderText = "USUARIO"
        Me.colUsuario.Name = "colUsuario"
        Me.colUsuario.ReadOnly = True
        Me.colUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colUsuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'PnlBotonera
        '
        Me.PnlBotonera.AutoSize = True
        Me.PnlBotonera.BackColor = System.Drawing.Color.Silver
        Me.PnlBotonera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlBotonera.Controls.Add(Me.BtnCerrar)
        Me.PnlBotonera.Controls.Add(Me.BtnEliminar)
        Me.PnlBotonera.Controls.Add(Me.BtnNuevo)
        Me.PnlBotonera.Controls.Add(Me.BtnPagarMes)
        Me.PnlBotonera.Controls.Add(Me.BtnNuevoPago)
        Me.PnlBotonera.Controls.Add(Me.BtnModificar)
        Me.PnlBotonera.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlBotonera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlBotonera.Location = New System.Drawing.Point(1156, 0)
        Me.PnlBotonera.Margin = New System.Windows.Forms.Padding(0)
        Me.PnlBotonera.Name = "PnlBotonera"
        Me.PnlBotonera.Size = New System.Drawing.Size(182, 786)
        Me.PnlBotonera.TabIndex = 0
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
        Me.BtnCerrar.Location = New System.Drawing.Point(4, 713)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.BtnCerrar.Size = New System.Drawing.Size(170, 44)
        Me.BtnCerrar.TabIndex = 5
        Me.BtnCerrar.Text = "Cerrar &ventana"
        Me.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.eliminar_28x32
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEliminar.Location = New System.Drawing.Point(4, 240)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Padding = New System.Windows.Forms.Padding(0, 6, 0, 4)
        Me.BtnEliminar.Size = New System.Drawing.Size(170, 70)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "&Eliminar cliente"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Image = Global.ControlPagosGimnasio.My.Resources.Resources.nuevo_24x32
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNuevo.Location = New System.Drawing.Point(4, 76)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 0)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Padding = New System.Windows.Forms.Padding(0, 5, 0, 4)
        Me.BtnNuevo.Size = New System.Drawing.Size(170, 70)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "&Nuevo cliente"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnPagarMes
        '
        Me.BtnPagarMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPagarMes.Image = Global.ControlPagosGimnasio.My.Resources.Resources.pagar_mes_28x32
        Me.BtnPagarMes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPagarMes.Location = New System.Drawing.Point(4, 481)
        Me.BtnPagarMes.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnPagarMes.Name = "BtnPagarMes"
        Me.BtnPagarMes.Padding = New System.Windows.Forms.Padding(0, 6, 0, 4)
        Me.BtnPagarMes.Size = New System.Drawing.Size(170, 70)
        Me.BtnPagarMes.TabIndex = 3
        Me.BtnPagarMes.Text = "&Pagar mes"
        Me.BtnPagarMes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPagarMes.UseVisualStyleBackColor = True
        '
        'BtnNuevoPago
        '
        Me.BtnNuevoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevoPago.Image = Global.ControlPagosGimnasio.My.Resources.Resources.nuevo_pago_28x32
        Me.BtnNuevoPago.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNuevoPago.Location = New System.Drawing.Point(5, 563)
        Me.BtnNuevoPago.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.BtnNuevoPago.Name = "BtnNuevoPago"
        Me.BtnNuevoPago.Padding = New System.Windows.Forms.Padding(0, 5, 0, 4)
        Me.BtnNuevoPago.Size = New System.Drawing.Size(170, 70)
        Me.BtnNuevoPago.TabIndex = 4
        Me.BtnNuevoPago.Text = "N&uevo pago"
        Me.BtnNuevoPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNuevoPago.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.editar_28x32
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnModificar.Location = New System.Drawing.Point(4, 158)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Padding = New System.Windows.Forms.Padding(0, 6, 0, 4)
        Me.BtnModificar.Size = New System.Drawing.Size(170, 70)
        Me.BtnModificar.TabIndex = 1
        Me.BtnModificar.Text = "&Modificar datos"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.buscar_28x32
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBuscar.Location = New System.Drawing.Point(1002, 78)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.BtnBuscar.Size = New System.Drawing.Size(130, 63)
        Me.BtnBuscar.TabIndex = 0
        Me.BtnBuscar.Text = "&Buscar cliente"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'StsBarra
        '
        Me.StsBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StsBarra.GripMargin = New System.Windows.Forms.Padding(0)
        Me.StsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlblTitulo, Me.SlblDescrip})
        Me.StsBarra.Location = New System.Drawing.Point(0, 786)
        Me.StsBarra.Name = "StsBarra"
        Me.StsBarra.Size = New System.Drawing.Size(1338, 46)
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
        Me.SlblTitulo.Margin = New System.Windows.Forms.Padding(24, 4, 6, 4)
        Me.SlblTitulo.Name = "SlblTitulo"
        Me.SlblTitulo.Size = New System.Drawing.Size(160, 38)
        Me.SlblTitulo.Text = "SlblTitulo"
        '
        'SlblDescrip
        '
        Me.SlblDescrip.AutoSize = False
        Me.SlblDescrip.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.SlblDescrip.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.SlblDescrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SlblDescrip.Margin = New System.Windows.Forms.Padding(8, 4, 0, 4)
        Me.SlblDescrip.Name = "SlblDescrip"
        Me.SlblDescrip.Size = New System.Drawing.Size(956, 38)
        Me.SlblDescrip.Text = "SlblDescrip"
        Me.SlblDescrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RbInactivo
        '
        Me.RbInactivo.Appearance = System.Windows.Forms.Appearance.Button
        Me.RbInactivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbInactivo.Image = Global.ControlPagosGimnasio.My.Resources.Resources.inactivo_60x60
        Me.RbInactivo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RbInactivo.Location = New System.Drawing.Point(1002, 307)
        Me.RbInactivo.Margin = New System.Windows.Forms.Padding(0)
        Me.RbInactivo.Name = "RbInactivo"
        Me.RbInactivo.Padding = New System.Windows.Forms.Padding(0, 14, 0, 12)
        Me.RbInactivo.Size = New System.Drawing.Size(130, 134)
        Me.RbInactivo.TabIndex = 2
        Me.RbInactivo.Text = "Clientes inactivos"
        Me.RbInactivo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RbInactivo.UseVisualStyleBackColor = True
        '
        'RbActivo
        '
        Me.RbActivo.Appearance = System.Windows.Forms.Appearance.Button
        Me.RbActivo.Checked = True
        Me.RbActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbActivo.Image = Global.ControlPagosGimnasio.My.Resources.Resources.en_actividad_60x60
        Me.RbActivo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RbActivo.Location = New System.Drawing.Point(1002, 157)
        Me.RbActivo.Margin = New System.Windows.Forms.Padding(0, 0, 24, 16)
        Me.RbActivo.Name = "RbActivo"
        Me.RbActivo.Padding = New System.Windows.Forms.Padding(0, 14, 0, 12)
        Me.RbActivo.Size = New System.Drawing.Size(130, 134)
        Me.RbActivo.TabIndex = 1
        Me.RbActivo.TabStop = True
        Me.RbActivo.Text = "Clientes en actividad"
        Me.RbActivo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RbActivo.UseVisualStyleBackColor = True
        '
        'GbDatosCliente
        '
        Me.GbDatosCliente.Controls.Add(Me.LblEdad)
        Me.GbDatosCliente.Controls.Add(Me.LblEdadCli)
        Me.GbDatosCliente.Controls.Add(Me.LblGrupoFamiliar)
        Me.GbDatosCliente.Controls.Add(Me.LblMtdPgo)
        Me.GbDatosCliente.Controls.Add(Me.LblEstado)
        Me.GbDatosCliente.Controls.Add(Me.LblFechaInscripcion)
        Me.GbDatosCliente.Controls.Add(Me.LblMetodoPago)
        Me.GbDatosCliente.Controls.Add(Me.LblFdiCli)
        Me.GbDatosCliente.Controls.Add(Me.LblGrpFam)
        Me.GbDatosCliente.Controls.Add(Me.LblEstCli)
        Me.GbDatosCliente.Controls.Add(Me.LblApeCli)
        Me.GbDatosCliente.Controls.Add(Me.LblFdnCli)
        Me.GbDatosCliente.Controls.Add(Me.LblNomCli)
        Me.GbDatosCliente.Controls.Add(Me.LblFechaNacimiento)
        Me.GbDatosCliente.Controls.Add(Me.LblApellido)
        Me.GbDatosCliente.Controls.Add(Me.LblNombre)
        Me.GbDatosCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbDatosCliente.Location = New System.Drawing.Point(25, 151)
        Me.GbDatosCliente.Margin = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.GbDatosCliente.Name = "GbDatosCliente"
        Me.GbDatosCliente.Size = New System.Drawing.Size(961, 290)
        Me.GbDatosCliente.TabIndex = 1
        Me.GbDatosCliente.TabStop = False
        Me.GbDatosCliente.Text = "Datos del cliente :"
        '
        'LblEdad
        '
        Me.LblEdad.AutoSize = True
        Me.LblEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEdad.Location = New System.Drawing.Point(564, 73)
        Me.LblEdad.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.LblEdad.Name = "LblEdad"
        Me.LblEdad.Size = New System.Drawing.Size(40, 15)
        Me.LblEdad.TabIndex = 66
        Me.LblEdad.Text = "Edad"
        Me.LblEdad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblEdadCli
        '
        Me.LblEdadCli.BackColor = System.Drawing.Color.AliceBlue
        Me.LblEdadCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblEdadCli.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.LblEdadCli.ForeColor = System.Drawing.Color.MediumBlue
        Me.LblEdadCli.Location = New System.Drawing.Point(612, 68)
        Me.LblEdadCli.Margin = New System.Windows.Forms.Padding(0)
        Me.LblEdadCli.Name = "LblEdadCli"
        Me.LblEdadCli.Size = New System.Drawing.Size(150, 26)
        Me.LblEdadCli.TabIndex = 67
        Me.LblEdadCli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblGrupoFamiliar
        '
        Me.LblGrupoFamiliar.AutoSize = True
        Me.LblGrupoFamiliar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGrupoFamiliar.Location = New System.Drawing.Point(47, 250)
        Me.LblGrupoFamiliar.Margin = New System.Windows.Forms.Padding(0)
        Me.LblGrupoFamiliar.Name = "LblGrupoFamiliar"
        Me.LblGrupoFamiliar.Size = New System.Drawing.Size(99, 15)
        Me.LblGrupoFamiliar.TabIndex = 65
        Me.LblGrupoFamiliar.Text = "Grupo familiar"
        Me.LblGrupoFamiliar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblMtdPgo
        '
        Me.LblMtdPgo.BackColor = System.Drawing.Color.AliceBlue
        Me.LblMtdPgo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblMtdPgo.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.LblMtdPgo.ForeColor = System.Drawing.Color.MediumBlue
        Me.LblMtdPgo.Location = New System.Drawing.Point(154, 211)
        Me.LblMtdPgo.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.LblMtdPgo.Name = "LblMtdPgo"
        Me.LblMtdPgo.Size = New System.Drawing.Size(310, 26)
        Me.LblMtdPgo.TabIndex = 60
        Me.LblMtdPgo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstado.Location = New System.Drawing.Point(553, 250)
        Me.LblEstado.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(51, 15)
        Me.LblEstado.TabIndex = 64
        Me.LblEstado.Text = "Estado"
        Me.LblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblFechaInscripcion
        '
        Me.LblFechaInscripcion.AutoSize = True
        Me.LblFechaInscripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaInscripcion.Location = New System.Drawing.Point(491, 216)
        Me.LblFechaInscripcion.Margin = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.LblFechaInscripcion.Name = "LblFechaInscripcion"
        Me.LblFechaInscripcion.Size = New System.Drawing.Size(113, 15)
        Me.LblFechaInscripcion.TabIndex = 58
        Me.LblFechaInscripcion.Text = "F. de Inscripción"
        Me.LblFechaInscripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblMetodoPago
        '
        Me.LblMetodoPago.AutoSize = True
        Me.LblMetodoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMetodoPago.Location = New System.Drawing.Point(35, 216)
        Me.LblMetodoPago.Margin = New System.Windows.Forms.Padding(0)
        Me.LblMetodoPago.Name = "LblMetodoPago"
        Me.LblMetodoPago.Size = New System.Drawing.Size(111, 15)
        Me.LblMetodoPago.TabIndex = 63
        Me.LblMetodoPago.Text = "Método de pago"
        Me.LblMetodoPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblFdiCli
        '
        Me.LblFdiCli.BackColor = System.Drawing.Color.AliceBlue
        Me.LblFdiCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblFdiCli.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.LblFdiCli.ForeColor = System.Drawing.Color.MediumBlue
        Me.LblFdiCli.Location = New System.Drawing.Point(612, 211)
        Me.LblFdiCli.Margin = New System.Windows.Forms.Padding(0)
        Me.LblFdiCli.Name = "LblFdiCli"
        Me.LblFdiCli.Size = New System.Drawing.Size(310, 26)
        Me.LblFdiCli.TabIndex = 59
        Me.LblFdiCli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblGrpFam
        '
        Me.LblGrpFam.BackColor = System.Drawing.Color.AliceBlue
        Me.LblGrpFam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblGrpFam.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.LblGrpFam.ForeColor = System.Drawing.Color.MediumBlue
        Me.LblGrpFam.Location = New System.Drawing.Point(154, 245)
        Me.LblGrpFam.Margin = New System.Windows.Forms.Padding(0, 8, 0, 16)
        Me.LblGrpFam.Name = "LblGrpFam"
        Me.LblGrpFam.Size = New System.Drawing.Size(310, 26)
        Me.LblGrpFam.TabIndex = 62
        Me.LblGrpFam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblEstCli
        '
        Me.LblEstCli.BackColor = System.Drawing.Color.AliceBlue
        Me.LblEstCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblEstCli.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.LblEstCli.ForeColor = System.Drawing.Color.MediumBlue
        Me.LblEstCli.Location = New System.Drawing.Point(612, 245)
        Me.LblEstCli.Margin = New System.Windows.Forms.Padding(0)
        Me.LblEstCli.Name = "LblEstCli"
        Me.LblEstCli.Size = New System.Drawing.Size(150, 26)
        Me.LblEstCli.TabIndex = 61
        Me.LblEstCli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblApeCli
        '
        Me.LblApeCli.BackColor = System.Drawing.Color.AliceBlue
        Me.LblApeCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblApeCli.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.LblApeCli.ForeColor = System.Drawing.Color.MediumBlue
        Me.LblApeCli.Location = New System.Drawing.Point(154, 68)
        Me.LblApeCli.Margin = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.LblApeCli.Name = "LblApeCli"
        Me.LblApeCli.Size = New System.Drawing.Size(310, 26)
        Me.LblApeCli.TabIndex = 47
        Me.LblApeCli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblFdnCli
        '
        Me.LblFdnCli.BackColor = System.Drawing.Color.AliceBlue
        Me.LblFdnCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblFdnCli.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.LblFdnCli.ForeColor = System.Drawing.Color.MediumBlue
        Me.LblFdnCli.Location = New System.Drawing.Point(612, 34)
        Me.LblFdnCli.Margin = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.LblFdnCli.Name = "LblFdnCli"
        Me.LblFdnCli.Size = New System.Drawing.Size(310, 26)
        Me.LblFdnCli.TabIndex = 46
        Me.LblFdnCli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblNomCli
        '
        Me.LblNomCli.BackColor = System.Drawing.Color.AliceBlue
        Me.LblNomCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNomCli.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.LblNomCli.ForeColor = System.Drawing.Color.MediumBlue
        Me.LblNomCli.Location = New System.Drawing.Point(154, 34)
        Me.LblNomCli.Margin = New System.Windows.Forms.Padding(8, 16, 0, 0)
        Me.LblNomCli.Name = "LblNomCli"
        Me.LblNomCli.Size = New System.Drawing.Size(310, 26)
        Me.LblNomCli.TabIndex = 45
        Me.LblNomCli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblFechaNacimiento
        '
        Me.LblFechaNacimiento.AutoSize = True
        Me.LblFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaNacimiento.Location = New System.Drawing.Point(488, 39)
        Me.LblFechaNacimiento.Margin = New System.Windows.Forms.Padding(24, 0, 0, 0)
        Me.LblFechaNacimiento.Name = "LblFechaNacimiento"
        Me.LblFechaNacimiento.Size = New System.Drawing.Size(116, 15)
        Me.LblFechaNacimiento.TabIndex = 40
        Me.LblFechaNacimiento.Text = "F. de Nacimiento"
        Me.LblFechaNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApellido.Location = New System.Drawing.Point(87, 73)
        Me.LblApellido.Margin = New System.Windows.Forms.Padding(24, 0, 0, 0)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(59, 15)
        Me.LblApellido.TabIndex = 39
        Me.LblApellido.Text = "Apellido"
        Me.LblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblNombre
        '
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(35, 39)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(32, 0, 0, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(111, 15)
        Me.LblNombre.TabIndex = 38
        Me.LblNombre.Text = "Nombre"
        Me.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GbListaPagos
        '
        Me.GbListaPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbListaPagos.Location = New System.Drawing.Point(25, 457)
        Me.GbListaPagos.Margin = New System.Windows.Forms.Padding(0, 16, 0, 16)
        Me.GbListaPagos.Name = "GbListaPagos"
        Me.GbListaPagos.Size = New System.Drawing.Size(1107, 313)
        Me.GbListaPagos.TabIndex = 3
        Me.GbListaPagos.TabStop = False
        Me.GbListaPagos.Text = "Historial de pagos :"
        '
        'GbBusqueda
        '
        Me.GbBusqueda.Controls.Add(Me.BtnLimpiar)
        Me.GbBusqueda.Controls.Add(Me.CmbFiltrar)
        Me.GbBusqueda.Controls.Add(Me.TxtBuscar)
        Me.GbBusqueda.Controls.Add(Me.LblFiltrar)
        Me.GbBusqueda.Enabled = False
        Me.GbBusqueda.Location = New System.Drawing.Point(25, 73)
        Me.GbBusqueda.Margin = New System.Windows.Forms.Padding(16, 8, 0, 0)
        Me.GbBusqueda.Name = "GbBusqueda"
        Me.GbBusqueda.Size = New System.Drawing.Size(961, 68)
        Me.GbBusqueda.TabIndex = 0
        Me.GbBusqueda.TabStop = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.clear22
        Me.BtnLimpiar.Location = New System.Drawing.Point(908, 21)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(0, 0, 16, 0)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(34, 30)
        Me.BtnLimpiar.TabIndex = 2
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'CmbFiltrar
        '
        Me.CmbFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFiltrar.Font = New System.Drawing.Font("Linux Libertine Display G", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbFiltrar.ForeColor = System.Drawing.Color.MediumBlue
        Me.CmbFiltrar.FormattingEnabled = True
        Me.CmbFiltrar.Items.AddRange(New Object() {"Nombre", "Apellido", "Teléfono"})
        Me.CmbFiltrar.Location = New System.Drawing.Point(115, 24)
        Me.CmbFiltrar.Margin = New System.Windows.Forms.Padding(0)
        Me.CmbFiltrar.Name = "CmbFiltrar"
        Me.CmbFiltrar.Size = New System.Drawing.Size(136, 25)
        Me.CmbFiltrar.TabIndex = 0
        '
        'TxtBuscar
        '
        Me.TxtBuscar.BackColor = System.Drawing.SystemColors.Window
        Me.TxtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBuscar.Font = New System.Drawing.Font("Linux Libertine Display G", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtBuscar.Location = New System.Drawing.Point(259, 24)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.TxtBuscar.MaxLength = 30
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(633, 25)
        Me.TxtBuscar.TabIndex = 1
        Me.TxtBuscar.WordWrap = False
        '
        'LblFiltrar
        '
        Me.LblFiltrar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFiltrar.Location = New System.Drawing.Point(19, 24)
        Me.LblFiltrar.Margin = New System.Windows.Forms.Padding(16, 8, 0, 16)
        Me.LblFiltrar.Name = "LblFiltrar"
        Me.LblFiltrar.Size = New System.Drawing.Size(96, 25)
        Me.LblFiltrar.TabIndex = 4
        Me.LblFiltrar.Text = "Filtrar por"
        Me.LblFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.LblTlfCli)
        Me.GroupBox.Controls.Add(Me.LblTelefono)
        Me.GroupBox.Controls.Add(Me.LblEmail)
        Me.GroupBox.Controls.Add(Me.LblDireccion)
        Me.GroupBox.Controls.Add(Me.LblEmlCli)
        Me.GroupBox.Controls.Add(Me.LblDirCli)
        Me.GroupBox.Location = New System.Drawing.Point(25, 253)
        Me.GroupBox.Margin = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox.Size = New System.Drawing.Size(961, 97)
        Me.GroupBox.TabIndex = 2
        Me.GroupBox.TabStop = False
        '
        'LblTlfCli
        '
        Me.LblTlfCli.BackColor = System.Drawing.Color.AliceBlue
        Me.LblTlfCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTlfCli.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.LblTlfCli.ForeColor = System.Drawing.Color.MediumBlue
        Me.LblTlfCli.Location = New System.Drawing.Point(154, 21)
        Me.LblTlfCli.Margin = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.LblTlfCli.Name = "LblTlfCli"
        Me.LblTlfCli.Size = New System.Drawing.Size(310, 26)
        Me.LblTlfCli.TabIndex = 60
        Me.LblTlfCli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelefono.Location = New System.Drawing.Point(87, 26)
        Me.LblTelefono.Margin = New System.Windows.Forms.Padding(0)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(63, 15)
        Me.LblTelefono.TabIndex = 57
        Me.LblTelefono.Text = "Teléfono"
        Me.LblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.Location = New System.Drawing.Point(97, 60)
        Me.LblEmail.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(49, 15)
        Me.LblEmail.TabIndex = 58
        Me.LblEmail.Text = "E-Mail"
        Me.LblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDireccion.Location = New System.Drawing.Point(536, 26)
        Me.LblDireccion.Margin = New System.Windows.Forms.Padding(0)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(68, 15)
        Me.LblDireccion.TabIndex = 59
        Me.LblDireccion.Text = "Dirección"
        Me.LblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblEmlCli
        '
        Me.LblEmlCli.BackColor = System.Drawing.Color.AliceBlue
        Me.LblEmlCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblEmlCli.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.LblEmlCli.ForeColor = System.Drawing.Color.MediumBlue
        Me.LblEmlCli.Location = New System.Drawing.Point(154, 55)
        Me.LblEmlCli.Margin = New System.Windows.Forms.Padding(0, 8, 0, 16)
        Me.LblEmlCli.Name = "LblEmlCli"
        Me.LblEmlCli.Size = New System.Drawing.Size(310, 26)
        Me.LblEmlCli.TabIndex = 61
        Me.LblEmlCli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDirCli
        '
        Me.LblDirCli.BackColor = System.Drawing.Color.AliceBlue
        Me.LblDirCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblDirCli.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.LblDirCli.ForeColor = System.Drawing.Color.MediumBlue
        Me.LblDirCli.Location = New System.Drawing.Point(612, 21)
        Me.LblDirCli.Margin = New System.Windows.Forms.Padding(0)
        Me.LblDirCli.Name = "LblDirCli"
        Me.LblDirCli.Size = New System.Drawing.Size(310, 60)
        Me.LblDirCli.TabIndex = 62
        '
        'LblLetrero
        '
        Me.LblLetrero.Font = New System.Drawing.Font("Linux Libertine Display G", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLetrero.ForeColor = System.Drawing.Color.Green
        Me.LblLetrero.Location = New System.Drawing.Point(89, 17)
        Me.LblLetrero.Margin = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.LblLetrero.Name = "LblLetrero"
        Me.LblLetrero.Size = New System.Drawing.Size(844, 48)
        Me.LblLetrero.TabIndex = 86
        Me.LblLetrero.Text = "Para ver los datos de un cliente, actualizar o eliminar haz clic en buscar y sele" &
    "cciona un registro de la lista. Podrás cobrar mensualidades y ver el historial d" &
    "e pagos del cliente seleccionado."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(25, 17)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.TabIndex = 85
        Me.PictureBox1.TabStop = False
        '
        'FrmClientesPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1338, 832)
        Me.Controls.Add(Me.LblLetrero)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.GbBusqueda)
        Me.Controls.Add(Me.RbInactivo)
        Me.Controls.Add(Me.DgvListaPagos)
        Me.Controls.Add(Me.RbActivo)
        Me.Controls.Add(Me.PnlBotonera)
        Me.Controls.Add(Me.StsBarra)
        Me.Controls.Add(Me.GbDatosCliente)
        Me.Controls.Add(Me.GbListaPagos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmClientesPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLIENTES REGISTRADOS - HISTORIAL DE PAGOS"
        CType(Me.DgvListaPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBotonera.ResumeLayout(False)
        Me.StsBarra.ResumeLayout(False)
        Me.StsBarra.PerformLayout()
        Me.GbDatosCliente.ResumeLayout(False)
        Me.GbDatosCliente.PerformLayout()
        Me.GbBusqueda.ResumeLayout(False)
        Me.GbBusqueda.PerformLayout()
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCerrar As Button
    Friend WithEvents DgvListaPagos As DataGridView
    Friend WithEvents PnlBotonera As Panel
    Friend WithEvents BtnNuevoPago As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnPagarMes As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents StsBarra As StatusStrip
    Friend WithEvents SlblTitulo As ToolStripStatusLabel
    Friend WithEvents SlblDescrip As ToolStripStatusLabel
    Friend WithEvents RbInactivo As RadioButton
    Friend WithEvents RbActivo As RadioButton
    Friend WithEvents GbDatosCliente As GroupBox
    Friend WithEvents LblFechaNacimiento As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents GbListaPagos As GroupBox
    Friend WithEvents idPagos As DataGridViewTextBoxColumn
    Friend WithEvents colFdiPgs As DataGridViewTextBoxColumn
    Friend WithEvents colPrcPgs As DataGridViewTextBoxColumn
    Friend WithEvents colDescuento As DataGridViewTextBoxColumn
    Friend WithEvents colTotal As DataGridViewTextBoxColumn
    Friend WithEvents colNdias As DataGridViewTextBoxColumn
    Friend WithEvents colApagar As DataGridViewTextBoxColumn
    Friend WithEvents colFdpPgs As DataGridViewTextBoxColumn
    Friend WithEvents colFrmPgs As DataGridViewTextBoxColumn
    Friend WithEvents colUsuario As DataGridViewTextBoxColumn
    Friend WithEvents LblNomCli As Label
    Friend WithEvents LblApeCli As Label
    Friend WithEvents LblFdnCli As Label
    Friend WithEvents LblGrupoFamiliar As Label
    Friend WithEvents LblMtdPgo As Label
    Friend WithEvents LblEstado As Label
    Friend WithEvents LblFechaInscripcion As Label
    Friend WithEvents LblMetodoPago As Label
    Friend WithEvents LblFdiCli As Label
    Friend WithEvents LblGrpFam As Label
    Friend WithEvents LblEstCli As Label
    Friend WithEvents LblEdad As Label
    Friend WithEvents LblEdadCli As Label
    Friend WithEvents GbBusqueda As GroupBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents CmbFiltrar As ComboBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents LblFiltrar As Label
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents LblTlfCli As Label
    Friend WithEvents LblTelefono As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblDireccion As Label
    Friend WithEvents LblEmlCli As Label
    Friend WithEvents LblDirCli As Label
    Friend WithEvents LblLetrero As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
