<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHistorialPagos
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
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.TxtCliente = New System.Windows.Forms.Label()
        Me.TxtEdad = New System.Windows.Forms.Label()
        Me.LblInscripcion = New System.Windows.Forms.Label()
        Me.TxtEstado = New System.Windows.Forms.Label()
        Me.TxtInscripcion = New System.Windows.Forms.Label()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.LblEdad = New System.Windows.Forms.Label()
        Me.BtnPagarMes = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.DgvHistorialPagos = New System.Windows.Forms.DataGridView()
        Me.colFdiPgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrcPgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNdias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApagar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFdpPgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFrmPgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnNuevoPago = New System.Windows.Forms.Button()
        Me.GroupBox.SuspendLayout()
        CType(Me.DgvHistorialPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.TxtCliente)
        Me.GroupBox.Controls.Add(Me.TxtEdad)
        Me.GroupBox.Controls.Add(Me.LblInscripcion)
        Me.GroupBox.Controls.Add(Me.TxtEstado)
        Me.GroupBox.Controls.Add(Me.TxtInscripcion)
        Me.GroupBox.Controls.Add(Me.LblEstado)
        Me.GroupBox.Controls.Add(Me.LblEdad)
        Me.GroupBox.Location = New System.Drawing.Point(22, 12)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(986, 104)
        Me.GroupBox.TabIndex = 0
        Me.GroupBox.TabStop = False
        '
        'TxtCliente
        '
        Me.TxtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCliente.Location = New System.Drawing.Point(0, 24)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(986, 23)
        Me.TxtCliente.TabIndex = 7
        Me.TxtCliente.Text = "NOMBRE COMPLETO DEL CLIENTE"
        Me.TxtCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtEdad
        '
        Me.TxtEdad.BackColor = System.Drawing.SystemColors.Window
        Me.TxtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEdad.ForeColor = System.Drawing.Color.Blue
        Me.TxtEdad.Location = New System.Drawing.Point(744, 64)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(96, 22)
        Me.TxtEdad.TabIndex = 3
        Me.TxtEdad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblInscripcion
        '
        Me.LblInscripcion.AutoSize = True
        Me.LblInscripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInscripcion.Location = New System.Drawing.Point(128, 64)
        Me.LblInscripcion.Name = "LblInscripcion"
        Me.LblInscripcion.Size = New System.Drawing.Size(151, 16)
        Me.LblInscripcion.TabIndex = 4
        Me.LblInscripcion.Text = "Fecha de inscripción"
        Me.LblInscripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtEstado
        '
        Me.TxtEstado.BackColor = System.Drawing.SystemColors.Window
        Me.TxtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEstado.ForeColor = System.Drawing.Color.Blue
        Me.TxtEstado.Location = New System.Drawing.Point(552, 64)
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.Size = New System.Drawing.Size(112, 22)
        Me.TxtEstado.TabIndex = 2
        Me.TxtEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtInscripcion
        '
        Me.TxtInscripcion.BackColor = System.Drawing.SystemColors.Window
        Me.TxtInscripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtInscripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInscripcion.ForeColor = System.Drawing.Color.Blue
        Me.TxtInscripcion.Location = New System.Drawing.Point(288, 64)
        Me.TxtInscripcion.Name = "TxtInscripcion"
        Me.TxtInscripcion.Size = New System.Drawing.Size(176, 22)
        Me.TxtInscripcion.TabIndex = 1
        Me.TxtInscripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstado.Location = New System.Drawing.Point(488, 64)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(56, 16)
        Me.LblEstado.TabIndex = 5
        Me.LblEstado.Text = "Estado"
        '
        'LblEdad
        '
        Me.LblEdad.AutoSize = True
        Me.LblEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEdad.Location = New System.Drawing.Point(688, 64)
        Me.LblEdad.Name = "LblEdad"
        Me.LblEdad.Size = New System.Drawing.Size(44, 16)
        Me.LblEdad.TabIndex = 6
        Me.LblEdad.Text = "Edad"
        '
        'BtnPagarMes
        '
        Me.BtnPagarMes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPagarMes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise
        Me.BtnPagarMes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew
        Me.BtnPagarMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPagarMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPagarMes.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnPagarMes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPagarMes.Location = New System.Drawing.Point(22, 509)
        Me.BtnPagarMes.Name = "BtnPagarMes"
        Me.BtnPagarMes.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.BtnPagarMes.Size = New System.Drawing.Size(160, 48)
        Me.BtnPagarMes.TabIndex = 0
        Me.BtnPagarMes.Text = "&Pagar mes"
        Me.BtnPagarMes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPagarMes.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.AutoSize = True
        Me.BtnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.Brown
        Me.BtnCerrar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.salir22
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCerrar.Location = New System.Drawing.Point(828, 509)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.BtnCerrar.Size = New System.Drawing.Size(180, 48)
        Me.BtnCerrar.TabIndex = 2
        Me.BtnCerrar.Text = "  &Cerrar ventama"
        Me.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'DgvHistorialPagos
        '
        Me.DgvHistorialPagos.AllowUserToAddRows = False
        Me.DgvHistorialPagos.AllowUserToDeleteRows = False
        Me.DgvHistorialPagos.AllowUserToResizeColumns = False
        Me.DgvHistorialPagos.AllowUserToResizeRows = False
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvHistorialPagos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle25
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvHistorialPagos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle26
        Me.DgvHistorialPagos.ColumnHeadersHeight = 35
        Me.DgvHistorialPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvHistorialPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFdiPgs, Me.colPrcPgs, Me.colDescuento, Me.colTotal, Me.colNdias, Me.colApagar, Me.colFdpPgs, Me.colFrmPgs})
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvHistorialPagos.DefaultCellStyle = DataGridViewCellStyle35
        Me.DgvHistorialPagos.Location = New System.Drawing.Point(22, 132)
        Me.DgvHistorialPagos.MultiSelect = False
        Me.DgvHistorialPagos.Name = "DgvHistorialPagos"
        Me.DgvHistorialPagos.ReadOnly = True
        Me.DgvHistorialPagos.RowHeadersWidth = 35
        Me.DgvHistorialPagos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle36.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvHistorialPagos.RowsDefaultCellStyle = DataGridViewCellStyle36
        Me.DgvHistorialPagos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvHistorialPagos.RowTemplate.Height = 27
        Me.DgvHistorialPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvHistorialPagos.Size = New System.Drawing.Size(986, 360)
        Me.DgvHistorialPagos.TabIndex = 3
        '
        'colFdiPgs
        '
        Me.colFdiPgs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colFdiPgs.DefaultCellStyle = DataGridViewCellStyle27
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
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colPrcPgs.DefaultCellStyle = DataGridViewCellStyle28
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
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colDescuento.DefaultCellStyle = DataGridViewCellStyle29
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
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colTotal.DefaultCellStyle = DataGridViewCellStyle30
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
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colNdias.DefaultCellStyle = DataGridViewCellStyle31
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
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colApagar.DefaultCellStyle = DataGridViewCellStyle32
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
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colFdpPgs.DefaultCellStyle = DataGridViewCellStyle33
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
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colFrmPgs.DefaultCellStyle = DataGridViewCellStyle34
        Me.colFrmPgs.HeaderText = "FORMA DE PAGO"
        Me.colFrmPgs.Name = "colFrmPgs"
        Me.colFrmPgs.ReadOnly = True
        Me.colFrmPgs.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colFrmPgs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colFrmPgs.Width = 140
        '
        'BtnNuevoPago
        '
        Me.BtnNuevoPago.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNuevoPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise
        Me.BtnNuevoPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew
        Me.BtnNuevoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevoPago.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnNuevoPago.Image = Global.ControlPagosGimnasio.My.Resources.Resources.nuevo_pago_28x32
        Me.BtnNuevoPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevoPago.Location = New System.Drawing.Point(198, 509)
        Me.BtnNuevoPago.Name = "BtnNuevoPago"
        Me.BtnNuevoPago.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.BtnNuevoPago.Size = New System.Drawing.Size(160, 48)
        Me.BtnNuevoPago.TabIndex = 1
        Me.BtnNuevoPago.Text = "N&uevo pago"
        Me.BtnNuevoPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevoPago.UseVisualStyleBackColor = True
        '
        'FrmHistorialPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 578)
        Me.Controls.Add(Me.BtnNuevoPago)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.BtnPagarMes)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.DgvHistorialPagos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmHistorialPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ficha del cliente"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        CType(Me.DgvHistorialPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents TxtCliente As Label
    Friend WithEvents TxtEdad As Label
    Friend WithEvents LblInscripcion As Label
    Friend WithEvents TxtEstado As Label
    Friend WithEvents TxtInscripcion As Label
    Friend WithEvents LblEstado As Label
    Friend WithEvents LblEdad As Label
    Friend WithEvents BtnPagarMes As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents DgvHistorialPagos As DataGridView
    Friend WithEvents colFdiPgs As DataGridViewTextBoxColumn
    Friend WithEvents colPrcPgs As DataGridViewTextBoxColumn
    Friend WithEvents colDescuento As DataGridViewTextBoxColumn
    Friend WithEvents colTotal As DataGridViewTextBoxColumn
    Friend WithEvents colNdias As DataGridViewTextBoxColumn
    Friend WithEvents colApagar As DataGridViewTextBoxColumn
    Friend WithEvents colFdpPgs As DataGridViewTextBoxColumn
    Friend WithEvents colFrmPgs As DataGridViewTextBoxColumn
    Friend WithEvents BtnNuevoPago As Button
End Class
