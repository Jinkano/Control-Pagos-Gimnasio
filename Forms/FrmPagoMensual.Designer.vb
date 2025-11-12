<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPagoMensual
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
        Me.LblCliente = New System.Windows.Forms.Label()
        Me.BtnPagar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.TxtPrcPgs = New System.Windows.Forms.TextBox()
        Me.LblPagarPgs = New System.Windows.Forms.Label()
        Me.LblDiasPgs = New System.Windows.Forms.Label()
        Me.TxtDscPgs = New System.Windows.Forms.TextBox()
        Me.LblPrcDisPgs = New System.Windows.Forms.Label()
        Me.LblDscto = New System.Windows.Forms.Label()
        Me.LblApagar = New System.Windows.Forms.Label()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.LblTtlPgs = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.DtpFdiPgs = New System.Windows.Forms.DateTimePicker()
        Me.LblPrcDia = New System.Windows.Forms.Label()
        Me.LblDias = New System.Windows.Forms.Label()
        Me.LblFechaDi = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbMtdPgs = New System.Windows.Forms.ComboBox()
        Me.CmbFrmPgs = New System.Windows.Forms.ComboBox()
        Me.DtpFdpPgs = New System.Windows.Forms.DateTimePicker()
        Me.LblMetodoDp = New System.Windows.Forms.Label()
        Me.LblFormaDp = New System.Windows.Forms.Label()
        Me.LblFechaDp = New System.Windows.Forms.Label()
        Me.TxtDtlleMtdo = New System.Windows.Forms.TextBox()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.GroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblCliente
        '
        Me.LblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCliente.Location = New System.Drawing.Point(25, 25)
        Me.LblCliente.Margin = New System.Windows.Forms.Padding(0, 16, 0, 0)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(704, 18)
        Me.LblCliente.TabIndex = 1
        Me.LblCliente.Text = "NOMBRE COMPLETO DEL CLIENTE Y SU EDAD"
        Me.LblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnPagar
        '
        Me.BtnPagar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue
        Me.BtnPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPagar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPagar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.pagar_mes_28x32
        Me.BtnPagar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPagar.Location = New System.Drawing.Point(544, 29)
        Me.BtnPagar.Margin = New System.Windows.Forms.Padding(16, 0, 16, 0)
        Me.BtnPagar.Name = "BtnPagar"
        Me.BtnPagar.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.BtnPagar.Size = New System.Drawing.Size(136, 64)
        Me.BtnPagar.TabIndex = 5
        Me.BtnPagar.Text = "&Pagar mes"
        Me.BtnPagar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPagar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Brown
        Me.BtnCancelar.Image = Global.ControlPagosGimnasio.My.Resources.Resources.cancel_pago_34x28
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(544, 207)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Padding = New System.Windows.Forms.Padding(0, 4, 0, 1)
        Me.BtnCancelar.Size = New System.Drawing.Size(136, 64)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "C&ancelar pago"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.LblFechaDi)
        Me.GroupBox.Controls.Add(Me.LblDias)
        Me.GroupBox.Controls.Add(Me.LblPrcDia)
        Me.GroupBox.Controls.Add(Me.DtpFdiPgs)
        Me.GroupBox.Controls.Add(Me.LblTotal)
        Me.GroupBox.Controls.Add(Me.LblTtlPgs)
        Me.GroupBox.Controls.Add(Me.LblPrecio)
        Me.GroupBox.Controls.Add(Me.LblApagar)
        Me.GroupBox.Controls.Add(Me.LblDscto)
        Me.GroupBox.Controls.Add(Me.LblPrcDisPgs)
        Me.GroupBox.Controls.Add(Me.TxtDscPgs)
        Me.GroupBox.Controls.Add(Me.LblDiasPgs)
        Me.GroupBox.Controls.Add(Me.LblPagarPgs)
        Me.GroupBox.Controls.Add(Me.TxtPrcPgs)
        Me.GroupBox.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox.Margin = New System.Windows.Forms.Padding(16, 8, 0, 16)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox.Size = New System.Drawing.Size(248, 285)
        Me.GroupBox.TabIndex = 0
        Me.GroupBox.TabStop = False
        '
        'TxtPrcPgs
        '
        Me.TxtPrcPgs.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrcPgs.Location = New System.Drawing.Point(16, 111)
        Me.TxtPrcPgs.Margin = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.TxtPrcPgs.MaxLength = 10
        Me.TxtPrcPgs.Name = "TxtPrcPgs"
        Me.TxtPrcPgs.Size = New System.Drawing.Size(100, 26)
        Me.TxtPrcPgs.TabIndex = 1
        Me.TxtPrcPgs.Text = "0"
        Me.TxtPrcPgs.WordWrap = False
        '
        'LblPagarPgs
        '
        Me.LblPagarPgs.BackColor = System.Drawing.SystemColors.Window
        Me.LblPagarPgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblPagarPgs.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPagarPgs.Location = New System.Drawing.Point(132, 243)
        Me.LblPagarPgs.Margin = New System.Windows.Forms.Padding(0)
        Me.LblPagarPgs.Name = "LblPagarPgs"
        Me.LblPagarPgs.Size = New System.Drawing.Size(100, 26)
        Me.LblPagarPgs.TabIndex = 17
        Me.LblPagarPgs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblDiasPgs
        '
        Me.LblDiasPgs.BackColor = System.Drawing.SystemColors.Window
        Me.LblDiasPgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblDiasPgs.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDiasPgs.ForeColor = System.Drawing.Color.Green
        Me.LblDiasPgs.Location = New System.Drawing.Point(16, 243)
        Me.LblDiasPgs.Margin = New System.Windows.Forms.Padding(0, 8, 0, 16)
        Me.LblDiasPgs.Name = "LblDiasPgs"
        Me.LblDiasPgs.Size = New System.Drawing.Size(100, 26)
        Me.LblDiasPgs.TabIndex = 15
        Me.LblDiasPgs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtDscPgs
        '
        Me.TxtDscPgs.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDscPgs.Location = New System.Drawing.Point(132, 111)
        Me.TxtDscPgs.Margin = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.TxtDscPgs.MaxLength = 10
        Me.TxtDscPgs.Name = "TxtDscPgs"
        Me.TxtDscPgs.Size = New System.Drawing.Size(100, 26)
        Me.TxtDscPgs.TabIndex = 2
        Me.TxtDscPgs.Text = "0"
        Me.TxtDscPgs.WordWrap = False
        '
        'LblPrcDisPgs
        '
        Me.LblPrcDisPgs.BackColor = System.Drawing.SystemColors.Window
        Me.LblPrcDisPgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblPrcDisPgs.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrcDisPgs.Location = New System.Drawing.Point(132, 177)
        Me.LblPrcDisPgs.Margin = New System.Windows.Forms.Padding(0)
        Me.LblPrcDisPgs.Name = "LblPrcDisPgs"
        Me.LblPrcDisPgs.Size = New System.Drawing.Size(100, 26)
        Me.LblPrcDisPgs.TabIndex = 13
        Me.LblPrcDisPgs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblDscto
        '
        Me.LblDscto.AutoSize = True
        Me.LblDscto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDscto.Location = New System.Drawing.Point(134, 87)
        Me.LblDscto.Margin = New System.Windows.Forms.Padding(0)
        Me.LblDscto.Name = "LblDscto"
        Me.LblDscto.Size = New System.Drawing.Size(72, 16)
        Me.LblDscto.TabIndex = 9
        Me.LblDscto.Text = "Descuento"
        Me.LblDscto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblApagar
        '
        Me.LblApagar.AutoSize = True
        Me.LblApagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApagar.Location = New System.Drawing.Point(134, 219)
        Me.LblApagar.Margin = New System.Windows.Forms.Padding(0)
        Me.LblApagar.Name = "LblApagar"
        Me.LblApagar.Size = New System.Drawing.Size(88, 16)
        Me.LblApagar.TabIndex = 16
        Me.LblApagar.Text = "Total a pagar"
        Me.LblApagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPrecio
        '
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecio.Location = New System.Drawing.Point(18, 87)
        Me.LblPrecio.Margin = New System.Windows.Forms.Padding(0, 16, 0, 0)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(46, 16)
        Me.LblPrecio.TabIndex = 8
        Me.LblPrecio.Text = "Precio"
        Me.LblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTtlPgs
        '
        Me.LblTtlPgs.BackColor = System.Drawing.SystemColors.Window
        Me.LblTtlPgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTtlPgs.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTtlPgs.Location = New System.Drawing.Point(16, 177)
        Me.LblTtlPgs.Margin = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.LblTtlPgs.Name = "LblTtlPgs"
        Me.LblTtlPgs.Size = New System.Drawing.Size(100, 26)
        Me.LblTtlPgs.TabIndex = 11
        Me.LblTtlPgs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(18, 153)
        Me.LblTotal.Margin = New System.Windows.Forms.Padding(0, 16, 0, 0)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(38, 16)
        Me.LblTotal.TabIndex = 10
        Me.LblTotal.Text = "Total"
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DtpFdiPgs
        '
        Me.DtpFdiPgs.CustomFormat = "dd 'de' MMMM 'de' yyyy"
        Me.DtpFdiPgs.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.DtpFdiPgs.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFdiPgs.Location = New System.Drawing.Point(16, 45)
        Me.DtpFdiPgs.Margin = New System.Windows.Forms.Padding(16, 8, 16, 0)
        Me.DtpFdiPgs.Name = "DtpFdiPgs"
        Me.DtpFdiPgs.Size = New System.Drawing.Size(216, 26)
        Me.DtpFdiPgs.TabIndex = 0
        '
        'LblPrcDia
        '
        Me.LblPrcDia.AutoSize = True
        Me.LblPrcDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrcDia.Location = New System.Drawing.Point(134, 153)
        Me.LblPrcDia.Margin = New System.Windows.Forms.Padding(0)
        Me.LblPrcDia.Name = "LblPrcDia"
        Me.LblPrcDia.Size = New System.Drawing.Size(91, 16)
        Me.LblPrcDia.TabIndex = 12
        Me.LblPrcDia.Text = "Precio por día"
        Me.LblPrcDia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDias
        '
        Me.LblDias.AutoSize = True
        Me.LblDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDias.Location = New System.Drawing.Point(18, 219)
        Me.LblDias.Margin = New System.Windows.Forms.Padding(0, 16, 0, 0)
        Me.LblDias.Name = "LblDias"
        Me.LblDias.Size = New System.Drawing.Size(82, 16)
        Me.LblDias.TabIndex = 14
        Me.LblDias.Text = "Cant de días"
        Me.LblDias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblFechaDi
        '
        Me.LblFechaDi.AutoSize = True
        Me.LblFechaDi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaDi.Location = New System.Drawing.Point(18, 21)
        Me.LblFechaDi.Margin = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.LblFechaDi.Name = "LblFechaDi"
        Me.LblFechaDi.Size = New System.Drawing.Size(130, 16)
        Me.LblFechaDi.TabIndex = 7
        Me.LblFechaDi.Text = "Fecha inicio  de mes"
        Me.LblFechaDi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtDtlleMtdo)
        Me.GroupBox1.Controls.Add(Me.LblFechaDp)
        Me.GroupBox1.Controls.Add(Me.LblFormaDp)
        Me.GroupBox1.Controls.Add(Me.LblMetodoDp)
        Me.GroupBox1.Controls.Add(Me.DtpFdpPgs)
        Me.GroupBox1.Controls.Add(Me.CmbFrmPgs)
        Me.GroupBox1.Controls.Add(Me.CmbMtdPgs)
        Me.GroupBox1.Location = New System.Drawing.Point(272, 8)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Size = New System.Drawing.Size(248, 285)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'CmbMtdPgs
        '
        Me.CmbMtdPgs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMtdPgs.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.CmbMtdPgs.ForeColor = System.Drawing.Color.MediumBlue
        Me.CmbMtdPgs.FormattingEnabled = True
        Me.CmbMtdPgs.IntegralHeight = False
        Me.CmbMtdPgs.Items.AddRange(New Object() {"BONO", "DIARIO", "MENSUAL", "GRUPO FAMILIAR"})
        Me.CmbMtdPgs.Location = New System.Drawing.Point(16, 177)
        Me.CmbMtdPgs.Margin = New System.Windows.Forms.Padding(0)
        Me.CmbMtdPgs.Name = "CmbMtdPgs"
        Me.CmbMtdPgs.Size = New System.Drawing.Size(216, 26)
        Me.CmbMtdPgs.TabIndex = 8
        '
        'CmbFrmPgs
        '
        Me.CmbFrmPgs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFrmPgs.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.CmbFrmPgs.ForeColor = System.Drawing.Color.MediumBlue
        Me.CmbFrmPgs.FormattingEnabled = True
        Me.CmbFrmPgs.ItemHeight = 18
        Me.CmbFrmPgs.Items.AddRange(New Object() {"EFECTIVO", "BIZUM", "TARJETA", "TRANSFERENCIA"})
        Me.CmbFrmPgs.Location = New System.Drawing.Point(16, 111)
        Me.CmbFrmPgs.Margin = New System.Windows.Forms.Padding(0)
        Me.CmbFrmPgs.Name = "CmbFrmPgs"
        Me.CmbFrmPgs.Size = New System.Drawing.Size(216, 26)
        Me.CmbFrmPgs.TabIndex = 3
        '
        'DtpFdpPgs
        '
        Me.DtpFdpPgs.CustomFormat = "dd 'de' MMMM 'de' yyyy"
        Me.DtpFdpPgs.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.DtpFdpPgs.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFdpPgs.Location = New System.Drawing.Point(16, 45)
        Me.DtpFdpPgs.Margin = New System.Windows.Forms.Padding(0)
        Me.DtpFdpPgs.Name = "DtpFdpPgs"
        Me.DtpFdpPgs.Size = New System.Drawing.Size(216, 26)
        Me.DtpFdpPgs.TabIndex = 4
        '
        'LblMetodoDp
        '
        Me.LblMetodoDp.AutoSize = True
        Me.LblMetodoDp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMetodoDp.Location = New System.Drawing.Point(18, 153)
        Me.LblMetodoDp.Margin = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.LblMetodoDp.Name = "LblMetodoDp"
        Me.LblMetodoDp.Size = New System.Drawing.Size(107, 16)
        Me.LblMetodoDp.TabIndex = 20
        Me.LblMetodoDp.Text = "Método de pago"
        Me.LblMetodoDp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblFormaDp
        '
        Me.LblFormaDp.AutoSize = True
        Me.LblFormaDp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFormaDp.Location = New System.Drawing.Point(18, 87)
        Me.LblFormaDp.Margin = New System.Windows.Forms.Padding(0)
        Me.LblFormaDp.Name = "LblFormaDp"
        Me.LblFormaDp.Size = New System.Drawing.Size(100, 16)
        Me.LblFormaDp.TabIndex = 18
        Me.LblFormaDp.Text = "Forma de pago"
        Me.LblFormaDp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblFechaDp
        '
        Me.LblFechaDp.AutoSize = True
        Me.LblFechaDp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaDp.Location = New System.Drawing.Point(18, 21)
        Me.LblFechaDp.Margin = New System.Windows.Forms.Padding(16, 8, 0, 0)
        Me.LblFechaDp.Name = "LblFechaDp"
        Me.LblFechaDp.Size = New System.Drawing.Size(99, 16)
        Me.LblFechaDp.TabIndex = 19
        Me.LblFechaDp.Text = "Fecha de pago"
        Me.LblFechaDp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDtlleMtdo
        '
        Me.TxtDtlleMtdo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDtlleMtdo.Location = New System.Drawing.Point(16, 205)
        Me.TxtDtlleMtdo.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtDtlleMtdo.Multiline = True
        Me.TxtDtlleMtdo.Name = "TxtDtlleMtdo"
        Me.TxtDtlleMtdo.ReadOnly = True
        Me.TxtDtlleMtdo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDtlleMtdo.Size = New System.Drawing.Size(216, 64)
        Me.TxtDtlleMtdo.TabIndex = 9
        '
        'Panel
        '
        Me.Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel.Controls.Add(Me.GroupBox1)
        Me.Panel.Controls.Add(Me.GroupBox)
        Me.Panel.Controls.Add(Me.BtnCancelar)
        Me.Panel.Controls.Add(Me.BtnPagar)
        Me.Panel.Location = New System.Drawing.Point(25, 59)
        Me.Panel.Margin = New System.Windows.Forms.Padding(16, 16, 16, 24)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(700, 313)
        Me.Panel.TabIndex = 7
        '
        'FrmPagoMensual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 405)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.LblCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmPagoMensual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAGO CUOTA MENSUAL"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblCliente As Label
    Friend WithEvents BtnPagar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents LblFechaDi As Label
    Friend WithEvents LblDias As Label
    Friend WithEvents LblPrcDia As Label
    Friend WithEvents DtpFdiPgs As DateTimePicker
    Friend WithEvents LblTotal As Label
    Friend WithEvents LblTtlPgs As Label
    Friend WithEvents LblPrecio As Label
    Friend WithEvents LblApagar As Label
    Friend WithEvents LblDscto As Label
    Friend WithEvents LblPrcDisPgs As Label
    Friend WithEvents TxtDscPgs As TextBox
    Friend WithEvents LblDiasPgs As Label
    Friend WithEvents LblPagarPgs As Label
    Friend WithEvents TxtPrcPgs As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtDtlleMtdo As TextBox
    Friend WithEvents LblFechaDp As Label
    Friend WithEvents LblFormaDp As Label
    Friend WithEvents LblMetodoDp As Label
    Friend WithEvents DtpFdpPgs As DateTimePicker
    Friend WithEvents CmbFrmPgs As ComboBox
    Friend WithEvents CmbMtdPgs As ComboBox
    Friend WithEvents Panel As Panel
End Class
