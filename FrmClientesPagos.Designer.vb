<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientesPagos
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
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClientesPagos))
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgvListaPagos = New System.Windows.Forms.DataGridView()
        Me.PnlBotonera = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnPagarMes = New System.Windows.Forms.Button()
        Me.BtnNuevoPago = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnCambiar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.StsBarra = New System.Windows.Forms.StatusStrip()
        Me.SlblTitulo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SlblDescrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GbListaClientes = New System.Windows.Forms.GroupBox()
        Me.RbNoCli = New System.Windows.Forms.RadioButton()
        Me.RbSiCli = New System.Windows.Forms.RadioButton()
        Me.DgvListaClientes = New System.Windows.Forms.DataGridView()
        Me.idCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ape = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fdn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eml = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fdi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.std = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GbDatosClientes = New System.Windows.Forms.GroupBox()
        Me.TxtStdCli = New System.Windows.Forms.Label()
        Me.TxtEdaCli = New System.Windows.Forms.Label()
        Me.DtpFdnCli = New System.Windows.Forms.DateTimePicker()
        Me.TxtDirCli = New System.Windows.Forms.TextBox()
        Me.TxtEmlCli = New System.Windows.Forms.TextBox()
        Me.TxtTlfCli = New System.Windows.Forms.TextBox()
        Me.TxtApeCli = New System.Windows.Forms.TextBox()
        Me.TxtNomCli = New System.Windows.Forms.TextBox()
        Me.DtpFdiCli = New System.Windows.Forms.DateTimePicker()
        Me.LblFdiCli = New System.Windows.Forms.Label()
        Me.LblDirCli = New System.Windows.Forms.Label()
        Me.LblEmlCli = New System.Windows.Forms.Label()
        Me.LblTlfCli = New System.Windows.Forms.Label()
        Me.LblFdnCli = New System.Windows.Forms.Label()
        Me.LblApeCli = New System.Windows.Forms.Label()
        Me.LblNomCli = New System.Windows.Forms.Label()
        Me.LblLetrero = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        CType(Me.DgvListaPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBotonera.SuspendLayout()
        Me.StsBarra.SuspendLayout()
        Me.GbListaClientes.SuspendLayout()
        CType(Me.DgvListaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbDatosClientes.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvListaPagos
        '
        Me.DgvListaPagos.AllowUserToAddRows = False
        Me.DgvListaPagos.AllowUserToDeleteRows = False
        Me.DgvListaPagos.AllowUserToResizeColumns = False
        Me.DgvListaPagos.AllowUserToResizeRows = False
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvListaPagos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvListaPagos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.DgvListaPagos.ColumnHeadersHeight = 35
        Me.DgvListaPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvListaPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idPagos, Me.colFdiPgs, Me.colPrcPgs, Me.colDescuento, Me.colTotal, Me.colNdias, Me.colApagar, Me.colFdpPgs, Me.colFrmPgs, Me.colUsuario})
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvListaPagos.DefaultCellStyle = DataGridViewCellStyle28
        Me.DgvListaPagos.Location = New System.Drawing.Point(54, 457)
        Me.DgvListaPagos.MultiSelect = False
        Me.DgvListaPagos.Name = "DgvListaPagos"
        Me.DgvListaPagos.ReadOnly = True
        Me.DgvListaPagos.RowHeadersWidth = 35
        Me.DgvListaPagos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvListaPagos.RowsDefaultCellStyle = DataGridViewCellStyle29
        Me.DgvListaPagos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvListaPagos.RowTemplate.Height = 27
        Me.DgvListaPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvListaPagos.Size = New System.Drawing.Size(1085, 276)
        Me.DgvListaPagos.TabIndex = 3
        '
        'PnlBotonera
        '
        Me.PnlBotonera.AutoSize = True
        Me.PnlBotonera.BackColor = System.Drawing.Color.Silver
        Me.PnlBotonera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlBotonera.Controls.Add(Me.BtnCerrar)
        Me.PnlBotonera.Controls.Add(Me.BtnBuscar)
        Me.PnlBotonera.Controls.Add(Me.BtnEliminar)
        Me.PnlBotonera.Controls.Add(Me.BtnNuevo)
        Me.PnlBotonera.Controls.Add(Me.BtnPagarMes)
        Me.PnlBotonera.Controls.Add(Me.BtnNuevoPago)
        Me.PnlBotonera.Controls.Add(Me.BtnModificar)
        Me.PnlBotonera.Controls.Add(Me.BtnCambiar)
        Me.PnlBotonera.Controls.Add(Me.BtnActualizar)
        Me.PnlBotonera.Controls.Add(Me.BtnGuardar)
        Me.PnlBotonera.Controls.Add(Me.BtnCancelar)
        Me.PnlBotonera.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlBotonera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlBotonera.Location = New System.Drawing.Point(1184, 0)
        Me.PnlBotonera.Name = "PnlBotonera"
        Me.PnlBotonera.Size = New System.Drawing.Size(180, 821)
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
        Me.BtnCerrar.Location = New System.Drawing.Point(3, 762)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.BtnCerrar.Size = New System.Drawing.Size(170, 44)
        Me.BtnCerrar.TabIndex = 10
        Me.BtnCerrar.Text = "Cerrar &ventana"
        Me.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.buscar_28x32
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBuscar.Location = New System.Drawing.Point(3, 339)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Padding = New System.Windows.Forms.Padding(0, 6, 0, 4)
        Me.BtnBuscar.Size = New System.Drawing.Size(170, 70)
        Me.BtnBuscar.TabIndex = 7
        Me.BtnBuscar.Text = "&Buscar cliente"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.eliminar_28x32
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEliminar.Location = New System.Drawing.Point(3, 263)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Padding = New System.Windows.Forms.Padding(0, 6, 0, 4)
        Me.BtnEliminar.Size = New System.Drawing.Size(170, 70)
        Me.BtnEliminar.TabIndex = 6
        Me.BtnEliminar.Text = "&Eliminar cliente"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Image = Global.ControlPagosGimnasio.My.Resources.Resources.nuevo_24x32
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNuevo.Location = New System.Drawing.Point(3, 36)
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
        Me.BtnPagarMes.Location = New System.Drawing.Point(3, 490)
        Me.BtnPagarMes.Name = "BtnPagarMes"
        Me.BtnPagarMes.Padding = New System.Windows.Forms.Padding(0, 6, 0, 4)
        Me.BtnPagarMes.Size = New System.Drawing.Size(170, 70)
        Me.BtnPagarMes.TabIndex = 8
        Me.BtnPagarMes.Text = "&Pagar mes"
        Me.BtnPagarMes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPagarMes.UseVisualStyleBackColor = True
        '
        'BtnNuevoPago
        '
        Me.BtnNuevoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevoPago.Image = Global.ControlPagosGimnasio.My.Resources.Resources.nuevo_pago_28x32
        Me.BtnNuevoPago.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNuevoPago.Location = New System.Drawing.Point(3, 566)
        Me.BtnNuevoPago.Name = "BtnNuevoPago"
        Me.BtnNuevoPago.Padding = New System.Windows.Forms.Padding(0, 5, 0, 4)
        Me.BtnNuevoPago.Size = New System.Drawing.Size(170, 70)
        Me.BtnNuevoPago.TabIndex = 9
        Me.BtnNuevoPago.Text = "N&uevo pago"
        Me.BtnNuevoPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNuevoPago.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.editar_28x32
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnModificar.Location = New System.Drawing.Point(3, 112)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Padding = New System.Windows.Forms.Padding(0, 6, 0, 4)
        Me.BtnModificar.Size = New System.Drawing.Size(170, 70)
        Me.BtnModificar.TabIndex = 3
        Me.BtnModificar.Text = "&Modificar datos"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnCambiar
        '
        Me.BtnCambiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCambiar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.cambiarstd_28x32
        Me.BtnCambiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCambiar.Location = New System.Drawing.Point(3, 187)
        Me.BtnCambiar.Name = "BtnCambiar"
        Me.BtnCambiar.Padding = New System.Windows.Forms.Padding(0, 6, 0, 4)
        Me.BtnCambiar.Size = New System.Drawing.Size(170, 70)
        Me.BtnCambiar.TabIndex = 5
        Me.BtnCambiar.Text = "&Cambiar estado"
        Me.BtnCambiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCambiar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.actualizar2_34x28
        Me.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnActualizar.Location = New System.Drawing.Point(3, 120)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Padding = New System.Windows.Forms.Padding(0, 7, 0, 4)
        Me.BtnActualizar.Size = New System.Drawing.Size(170, 70)
        Me.BtnActualizar.TabIndex = 2
        Me.BtnActualizar.Text = "&Actualizar datos"
        Me.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnActualizar.UseVisualStyleBackColor = True
        Me.BtnActualizar.Visible = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.guardar_28x32
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGuardar.Location = New System.Drawing.Point(3, 120)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Padding = New System.Windows.Forms.Padding(0, 5, 0, 4)
        Me.BtnGuardar.Size = New System.Drawing.Size(170, 70)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.Text = "&Guardar datos"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGuardar.UseVisualStyleBackColor = True
        Me.BtnGuardar.Visible = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.clear22
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(3, 196)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Padding = New System.Windows.Forms.Padding(0, 12, 0, 4)
        Me.BtnCancelar.Size = New System.Drawing.Size(170, 70)
        Me.BtnCancelar.TabIndex = 4
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCancelar.UseVisualStyleBackColor = True
        Me.BtnCancelar.Visible = False
        '
        'StsBarra
        '
        Me.StsBarra.Dock = System.Windows.Forms.DockStyle.None
        Me.StsBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlblTitulo, Me.SlblDescrip})
        Me.StsBarra.Location = New System.Drawing.Point(0, 764)
        Me.StsBarra.Name = "StsBarra"
        Me.StsBarra.Size = New System.Drawing.Size(1213, 46)
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
        Me.SlblTitulo.Margin = New System.Windows.Forms.Padding(30, 2, 6, 2)
        Me.SlblTitulo.Name = "SlblTitulo"
        Me.SlblTitulo.Size = New System.Drawing.Size(150, 42)
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
        Me.SlblDescrip.Margin = New System.Windows.Forms.Padding(6, 2, 30, 2)
        Me.SlblDescrip.Name = "SlblDescrip"
        Me.SlblDescrip.Size = New System.Drawing.Size(974, 42)
        Me.SlblDescrip.Text = "SlblDescrip"
        Me.SlblDescrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GbListaClientes
        '
        Me.GbListaClientes.Controls.Add(Me.RbNoCli)
        Me.GbListaClientes.Controls.Add(Me.RbSiCli)
        Me.GbListaClientes.Controls.Add(Me.DgvListaClientes)
        Me.GbListaClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbListaClientes.Location = New System.Drawing.Point(596, 71)
        Me.GbListaClientes.Name = "GbListaClientes"
        Me.GbListaClientes.Size = New System.Drawing.Size(572, 340)
        Me.GbListaClientes.TabIndex = 2
        Me.GbListaClientes.TabStop = False
        Me.GbListaClientes.Text = "Lista de clientes"
        '
        'RbNoCli
        '
        Me.RbNoCli.Appearance = System.Windows.Forms.Appearance.Button
        Me.RbNoCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNoCli.Location = New System.Drawing.Point(440, 182)
        Me.RbNoCli.Name = "RbNoCli"
        Me.RbNoCli.Size = New System.Drawing.Size(120, 132)
        Me.RbNoCli.TabIndex = 2
        Me.RbNoCli.Text = "Clientes inactivos"
        Me.RbNoCli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RbNoCli.UseVisualStyleBackColor = True
        '
        'RbSiCli
        '
        Me.RbSiCli.Appearance = System.Windows.Forms.Appearance.Button
        Me.RbSiCli.Checked = True
        Me.RbSiCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbSiCli.Location = New System.Drawing.Point(440, 32)
        Me.RbSiCli.Name = "RbSiCli"
        Me.RbSiCli.Size = New System.Drawing.Size(120, 132)
        Me.RbSiCli.TabIndex = 1
        Me.RbSiCli.TabStop = True
        Me.RbSiCli.Text = "Clientes en actividad"
        Me.RbSiCli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RbSiCli.UseVisualStyleBackColor = True
        '
        'DgvListaClientes
        '
        Me.DgvListaClientes.AllowUserToAddRows = False
        Me.DgvListaClientes.AllowUserToDeleteRows = False
        Me.DgvListaClientes.AllowUserToResizeColumns = False
        Me.DgvListaClientes.AllowUserToResizeRows = False
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvListaClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle30
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvListaClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle31
        Me.DgvListaClientes.ColumnHeadersHeight = 35
        Me.DgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvListaClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCli, Me.nom, Me.ape, Me.fdn, Me.tlf, Me.eml, Me.dir, Me.fdi, Me.std})
        Me.DgvListaClientes.Location = New System.Drawing.Point(18, 32)
        Me.DgvListaClientes.MultiSelect = False
        Me.DgvListaClientes.Name = "DgvListaClientes"
        Me.DgvListaClientes.ReadOnly = True
        Me.DgvListaClientes.RowHeadersWidth = 35
        Me.DgvListaClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle32.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvListaClientes.RowsDefaultCellStyle = DataGridViewCellStyle32
        Me.DgvListaClientes.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DgvListaClientes.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvListaClientes.RowTemplate.Height = 27
        Me.DgvListaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvListaClientes.Size = New System.Drawing.Size(416, 282)
        Me.DgvListaClientes.TabIndex = 0
        '
        'idCli
        '
        Me.idCli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.idCli.HeaderText = "idCli"
        Me.idCli.Name = "idCli"
        Me.idCli.ReadOnly = True
        Me.idCli.Visible = False
        Me.idCli.Width = 63
        '
        'nom
        '
        Me.nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nom.HeaderText = "Nombre"
        Me.nom.Name = "nom"
        Me.nom.ReadOnly = True
        Me.nom.Width = 180
        '
        'ape
        '
        Me.ape.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ape.HeaderText = "Apellido"
        Me.ape.Name = "ape"
        Me.ape.ReadOnly = True
        Me.ape.Width = 180
        '
        'fdn
        '
        Me.fdn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.fdn.HeaderText = "fdn"
        Me.fdn.Name = "fdn"
        Me.fdn.ReadOnly = True
        Me.fdn.Visible = False
        Me.fdn.Width = 53
        '
        'tlf
        '
        Me.tlf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.tlf.HeaderText = "tlf"
        Me.tlf.Name = "tlf"
        Me.tlf.ReadOnly = True
        Me.tlf.Visible = False
        Me.tlf.Width = 44
        '
        'eml
        '
        Me.eml.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.eml.HeaderText = "eml"
        Me.eml.Name = "eml"
        Me.eml.ReadOnly = True
        Me.eml.Visible = False
        Me.eml.Width = 57
        '
        'dir
        '
        Me.dir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.dir.HeaderText = "dir"
        Me.dir.Name = "dir"
        Me.dir.ReadOnly = True
        Me.dir.Visible = False
        Me.dir.Width = 50
        '
        'fdi
        '
        Me.fdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.fdi.HeaderText = "fdi"
        Me.fdi.Name = "fdi"
        Me.fdi.ReadOnly = True
        Me.fdi.Visible = False
        Me.fdi.Width = 49
        '
        'std
        '
        Me.std.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.std.HeaderText = "std"
        Me.std.Name = "std"
        Me.std.ReadOnly = True
        Me.std.Visible = False
        Me.std.Width = 53
        '
        'GbDatosClientes
        '
        Me.GbDatosClientes.Controls.Add(Me.TxtStdCli)
        Me.GbDatosClientes.Controls.Add(Me.TxtEdaCli)
        Me.GbDatosClientes.Controls.Add(Me.DtpFdnCli)
        Me.GbDatosClientes.Controls.Add(Me.TxtDirCli)
        Me.GbDatosClientes.Controls.Add(Me.TxtEmlCli)
        Me.GbDatosClientes.Controls.Add(Me.TxtTlfCli)
        Me.GbDatosClientes.Controls.Add(Me.TxtApeCli)
        Me.GbDatosClientes.Controls.Add(Me.TxtNomCli)
        Me.GbDatosClientes.Controls.Add(Me.DtpFdiCli)
        Me.GbDatosClientes.Controls.Add(Me.LblFdiCli)
        Me.GbDatosClientes.Controls.Add(Me.LblDirCli)
        Me.GbDatosClientes.Controls.Add(Me.LblEmlCli)
        Me.GbDatosClientes.Controls.Add(Me.LblTlfCli)
        Me.GbDatosClientes.Controls.Add(Me.LblFdnCli)
        Me.GbDatosClientes.Controls.Add(Me.LblApeCli)
        Me.GbDatosClientes.Controls.Add(Me.LblNomCli)
        Me.GbDatosClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbDatosClientes.Location = New System.Drawing.Point(30, 71)
        Me.GbDatosClientes.Name = "GbDatosClientes"
        Me.GbDatosClientes.Size = New System.Drawing.Size(550, 340)
        Me.GbDatosClientes.TabIndex = 1
        Me.GbDatosClientes.TabStop = False
        Me.GbDatosClientes.Text = "Datos del cliente :"
        '
        'TxtStdCli
        '
        Me.TxtStdCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.TxtStdCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStdCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStdCli.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtStdCli.Location = New System.Drawing.Point(417, 292)
        Me.TxtStdCli.Name = "TxtStdCli"
        Me.TxtStdCli.Size = New System.Drawing.Size(108, 22)
        Me.TxtStdCli.TabIndex = 61
        Me.TxtStdCli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtEdaCli
        '
        Me.TxtEdaCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.TxtEdaCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEdaCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEdaCli.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtEdaCli.Location = New System.Drawing.Point(416, 101)
        Me.TxtEdaCli.Name = "TxtEdaCli"
        Me.TxtEdaCli.Size = New System.Drawing.Size(108, 22)
        Me.TxtEdaCli.TabIndex = 60
        Me.TxtEdaCli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DtpFdnCli
        '
        Me.DtpFdnCli.Enabled = False
        Me.DtpFdnCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFdnCli.Location = New System.Drawing.Point(144, 101)
        Me.DtpFdnCli.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.DtpFdnCli.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.DtpFdnCli.Name = "DtpFdnCli"
        Me.DtpFdnCli.Size = New System.Drawing.Size(260, 22)
        Me.DtpFdnCli.TabIndex = 2
        Me.DtpFdnCli.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'TxtDirCli
        '
        Me.TxtDirCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.TxtDirCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDirCli.Enabled = False
        Me.TxtDirCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDirCli.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtDirCli.Location = New System.Drawing.Point(145, 207)
        Me.TxtDirCli.MaxLength = 100
        Me.TxtDirCli.Multiline = True
        Me.TxtDirCli.Name = "TxtDirCli"
        Me.TxtDirCli.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDirCli.Size = New System.Drawing.Size(380, 72)
        Me.TxtDirCli.TabIndex = 5
        '
        'TxtEmlCli
        '
        Me.TxtEmlCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.TxtEmlCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtEmlCli.Enabled = False
        Me.TxtEmlCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmlCli.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtEmlCli.Location = New System.Drawing.Point(145, 170)
        Me.TxtEmlCli.MaxLength = 50
        Me.TxtEmlCli.Name = "TxtEmlCli"
        Me.TxtEmlCli.Size = New System.Drawing.Size(380, 22)
        Me.TxtEmlCli.TabIndex = 4
        Me.TxtEmlCli.WordWrap = False
        '
        'TxtTlfCli
        '
        Me.TxtTlfCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.TxtTlfCli.Enabled = False
        Me.TxtTlfCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTlfCli.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtTlfCli.Location = New System.Drawing.Point(144, 134)
        Me.TxtTlfCli.MaxLength = 15
        Me.TxtTlfCli.Name = "TxtTlfCli"
        Me.TxtTlfCli.Size = New System.Drawing.Size(380, 22)
        Me.TxtTlfCli.TabIndex = 3
        Me.TxtTlfCli.WordWrap = False
        '
        'TxtApeCli
        '
        Me.TxtApeCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.TxtApeCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtApeCli.Enabled = False
        Me.TxtApeCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApeCli.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtApeCli.Location = New System.Drawing.Point(144, 68)
        Me.TxtApeCli.MaxLength = 30
        Me.TxtApeCli.Name = "TxtApeCli"
        Me.TxtApeCli.Size = New System.Drawing.Size(380, 22)
        Me.TxtApeCli.TabIndex = 1
        Me.TxtApeCli.WordWrap = False
        '
        'TxtNomCli
        '
        Me.TxtNomCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.TxtNomCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNomCli.Enabled = False
        Me.TxtNomCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomCli.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtNomCli.Location = New System.Drawing.Point(145, 32)
        Me.TxtNomCli.MaxLength = 30
        Me.TxtNomCli.Name = "TxtNomCli"
        Me.TxtNomCli.Size = New System.Drawing.Size(380, 22)
        Me.TxtNomCli.TabIndex = 0
        Me.TxtNomCli.WordWrap = False
        '
        'DtpFdiCli
        '
        Me.DtpFdiCli.Enabled = False
        Me.DtpFdiCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFdiCli.Location = New System.Drawing.Point(145, 292)
        Me.DtpFdiCli.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.DtpFdiCli.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.DtpFdiCli.Name = "DtpFdiCli"
        Me.DtpFdiCli.Size = New System.Drawing.Size(260, 22)
        Me.DtpFdiCli.TabIndex = 6
        '
        'LblFdiCli
        '
        Me.LblFdiCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFdiCli.Location = New System.Drawing.Point(15, 296)
        Me.LblFdiCli.Name = "LblFdiCli"
        Me.LblFdiCli.Size = New System.Drawing.Size(110, 16)
        Me.LblFdiCli.TabIndex = 44
        Me.LblFdiCli.Text = "F. de Inscripción"
        Me.LblFdiCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDirCli
        '
        Me.LblDirCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDirCli.Location = New System.Drawing.Point(16, 210)
        Me.LblDirCli.Name = "LblDirCli"
        Me.LblDirCli.Size = New System.Drawing.Size(110, 16)
        Me.LblDirCli.TabIndex = 43
        Me.LblDirCli.Text = "Dirección"
        Me.LblDirCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblEmlCli
        '
        Me.LblEmlCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmlCli.Location = New System.Drawing.Point(16, 173)
        Me.LblEmlCli.Name = "LblEmlCli"
        Me.LblEmlCli.Size = New System.Drawing.Size(110, 16)
        Me.LblEmlCli.TabIndex = 42
        Me.LblEmlCli.Text = "E-Mail"
        Me.LblEmlCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTlfCli
        '
        Me.LblTlfCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTlfCli.Location = New System.Drawing.Point(16, 137)
        Me.LblTlfCli.Name = "LblTlfCli"
        Me.LblTlfCli.Size = New System.Drawing.Size(110, 16)
        Me.LblTlfCli.TabIndex = 41
        Me.LblTlfCli.Text = "Teléfono"
        Me.LblTlfCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblFdnCli
        '
        Me.LblFdnCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFdnCli.Location = New System.Drawing.Point(16, 105)
        Me.LblFdnCli.Name = "LblFdnCli"
        Me.LblFdnCli.Size = New System.Drawing.Size(110, 16)
        Me.LblFdnCli.TabIndex = 40
        Me.LblFdnCli.Text = "F. de Nacimiento"
        Me.LblFdnCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblApeCli
        '
        Me.LblApeCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApeCli.Location = New System.Drawing.Point(16, 71)
        Me.LblApeCli.Name = "LblApeCli"
        Me.LblApeCli.Size = New System.Drawing.Size(110, 16)
        Me.LblApeCli.TabIndex = 39
        Me.LblApeCli.Text = "Apellido"
        Me.LblApeCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblNomCli
        '
        Me.LblNomCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNomCli.Location = New System.Drawing.Point(16, 35)
        Me.LblNomCli.Name = "LblNomCli"
        Me.LblNomCli.Size = New System.Drawing.Size(110, 16)
        Me.LblNomCli.TabIndex = 38
        Me.LblNomCli.Text = "Nombre"
        Me.LblNomCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblLetrero
        '
        Me.LblLetrero.AutoSize = True
        Me.LblLetrero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLetrero.ForeColor = System.Drawing.Color.Green
        Me.LblLetrero.Location = New System.Drawing.Point(135, 16)
        Me.LblLetrero.Margin = New System.Windows.Forms.Padding(6)
        Me.LblLetrero.Name = "LblLetrero"
        Me.LblLetrero.Size = New System.Drawing.Size(705, 40)
        Me.LblLetrero.TabIndex = 74
        Me.LblLetrero.Text = "La siguiente lista muestra los clientes registrados en este gimnasio." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Selecciona" &
    " un cliente de la lista para ver mas información a cerca del cliente y su histor" &
    "ial de pagos."
        '
        'GroupBox1
        '
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(30, 427)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1138, 324)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Historial de pagos :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(49, 16)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 46)
        Me.PictureBox1.TabIndex = 73
        Me.PictureBox1.TabStop = False
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
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colFdiPgs.DefaultCellStyle = DataGridViewCellStyle19
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
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colPrcPgs.DefaultCellStyle = DataGridViewCellStyle20
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
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colDescuento.DefaultCellStyle = DataGridViewCellStyle21
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
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colTotal.DefaultCellStyle = DataGridViewCellStyle22
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
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colNdias.DefaultCellStyle = DataGridViewCellStyle23
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
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colApagar.DefaultCellStyle = DataGridViewCellStyle24
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
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colFdpPgs.DefaultCellStyle = DataGridViewCellStyle25
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
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colFrmPgs.DefaultCellStyle = DataGridViewCellStyle26
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
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colUsuario.DefaultCellStyle = DataGridViewCellStyle27
        Me.colUsuario.HeaderText = "USUARIO"
        Me.colUsuario.Name = "colUsuario"
        Me.colUsuario.ReadOnly = True
        Me.colUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colUsuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'FrmClientesPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 821)
        Me.Controls.Add(Me.DgvListaPagos)
        Me.Controls.Add(Me.PnlBotonera)
        Me.Controls.Add(Me.StsBarra)
        Me.Controls.Add(Me.GbListaClientes)
        Me.Controls.Add(Me.GbDatosClientes)
        Me.Controls.Add(Me.LblLetrero)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmClientesPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de clientes - Historial de pagos"
        CType(Me.DgvListaPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBotonera.ResumeLayout(False)
        Me.StsBarra.ResumeLayout(False)
        Me.StsBarra.PerformLayout()
        Me.GbListaClientes.ResumeLayout(False)
        CType(Me.DgvListaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbDatosClientes.ResumeLayout(False)
        Me.GbDatosClientes.PerformLayout()
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
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnPagarMes As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents StsBarra As StatusStrip
    Friend WithEvents SlblTitulo As ToolStripStatusLabel
    Friend WithEvents SlblDescrip As ToolStripStatusLabel
    Friend WithEvents GbListaClientes As GroupBox
    Friend WithEvents RbNoCli As RadioButton
    Friend WithEvents RbSiCli As RadioButton
    Friend WithEvents DgvListaClientes As DataGridView
    Friend WithEvents idCli As DataGridViewTextBoxColumn
    Friend WithEvents nom As DataGridViewTextBoxColumn
    Friend WithEvents ape As DataGridViewTextBoxColumn
    Friend WithEvents fdn As DataGridViewTextBoxColumn
    Friend WithEvents tlf As DataGridViewTextBoxColumn
    Friend WithEvents eml As DataGridViewTextBoxColumn
    Friend WithEvents dir As DataGridViewTextBoxColumn
    Friend WithEvents fdi As DataGridViewTextBoxColumn
    Friend WithEvents std As DataGridViewTextBoxColumn
    Friend WithEvents GbDatosClientes As GroupBox
    Friend WithEvents DtpFdnCli As DateTimePicker
    Friend WithEvents TxtDirCli As TextBox
    Friend WithEvents TxtEmlCli As TextBox
    Friend WithEvents TxtTlfCli As TextBox
    Friend WithEvents TxtApeCli As TextBox
    Friend WithEvents TxtNomCli As TextBox
    Friend WithEvents DtpFdiCli As DateTimePicker
    Friend WithEvents LblFdiCli As Label
    Friend WithEvents LblDirCli As Label
    Friend WithEvents LblEmlCli As Label
    Friend WithEvents LblTlfCli As Label
    Friend WithEvents LblFdnCli As Label
    Friend WithEvents LblApeCli As Label
    Friend WithEvents LblNomCli As Label
    Friend WithEvents LblLetrero As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnCambiar As Button
    Friend WithEvents TxtStdCli As Label
    Friend WithEvents TxtEdaCli As Label
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
End Class
