<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class A_modify_A
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
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.BtnPagarMes = New System.Windows.Forms.Button()
        Me.BtnNuevoPago = New System.Windows.Forms.Button()
        CType(Me.DgvListaPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvListaPagos
        '
        Me.DgvListaPagos.AllowUserToAddRows = False
        Me.DgvListaPagos.AllowUserToDeleteRows = False
        Me.DgvListaPagos.AllowUserToResizeColumns = False
        Me.DgvListaPagos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvListaPagos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvListaPagos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvListaPagos.ColumnHeadersHeight = 35
        Me.DgvListaPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvListaPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idPagos, Me.colFdiPgs, Me.colPrcPgs, Me.colDescuento, Me.colTotal, Me.colNdias, Me.colApagar, Me.colFdpPgs, Me.colFrmPgs, Me.colUsuario})
        Me.DgvListaPagos.Location = New System.Drawing.Point(12, 12)
        Me.DgvListaPagos.MultiSelect = False
        Me.DgvListaPagos.Name = "DgvListaPagos"
        Me.DgvListaPagos.ReadOnly = True
        Me.DgvListaPagos.RowHeadersWidth = 35
        Me.DgvListaPagos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvListaPagos.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DgvListaPagos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvListaPagos.RowTemplate.Height = 27
        Me.DgvListaPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvListaPagos.Size = New System.Drawing.Size(1085, 276)
        Me.DgvListaPagos.TabIndex = 78
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colFdiPgs.DefaultCellStyle = DataGridViewCellStyle3
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colPrcPgs.DefaultCellStyle = DataGridViewCellStyle4
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
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colDescuento.DefaultCellStyle = DataGridViewCellStyle5
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
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colTotal.DefaultCellStyle = DataGridViewCellStyle6
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colNdias.DefaultCellStyle = DataGridViewCellStyle7
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
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colApagar.DefaultCellStyle = DataGridViewCellStyle8
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
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colFdpPgs.DefaultCellStyle = DataGridViewCellStyle9
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
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colFrmPgs.DefaultCellStyle = DataGridViewCellStyle10
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
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colUsuario.DefaultCellStyle = DataGridViewCellStyle11
        Me.colUsuario.HeaderText = "USUARIO"
        Me.colUsuario.Name = "colUsuario"
        Me.colUsuario.ReadOnly = True
        Me.colUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colUsuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'BtnPagarMes
        '
        Me.BtnPagarMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPagarMes.Image = Global.ControlPagosGimnasio.My.Resources.Resources.pagar_mes_28x32
        Me.BtnPagarMes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPagarMes.Location = New System.Drawing.Point(927, 294)
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
        Me.BtnNuevoPago.Location = New System.Drawing.Point(751, 294)
        Me.BtnNuevoPago.Name = "BtnNuevoPago"
        Me.BtnNuevoPago.Padding = New System.Windows.Forms.Padding(0, 5, 0, 4)
        Me.BtnNuevoPago.Size = New System.Drawing.Size(170, 70)
        Me.BtnNuevoPago.TabIndex = 9
        Me.BtnNuevoPago.Text = "N&uevo pago"
        Me.BtnNuevoPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNuevoPago.UseVisualStyleBackColor = True
        '
        'A_modify_A
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1117, 392)
        Me.Controls.Add(Me.BtnNuevoPago)
        Me.Controls.Add(Me.BtnPagarMes)
        Me.Controls.Add(Me.DgvListaPagos)
        Me.Name = "A_modify_A"
        Me.Text = "A_modify_A"
        CType(Me.DgvListaPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvListaPagos As DataGridView
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
    Friend WithEvents BtnPagarMes As Button
    Friend WithEvents BtnNuevoPago As Button
End Class
