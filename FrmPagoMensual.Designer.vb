<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPagoMensual
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
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.DtpFdi = New System.Windows.Forms.DateTimePicker()
        Me.LblFechaDi = New System.Windows.Forms.Label()
        Me.TxtApagar = New System.Windows.Forms.Label()
        Me.TxtDias = New System.Windows.Forms.Label()
        Me.TxtPrcDia = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnPagar = New System.Windows.Forms.Button()
        Me.DtpFdp = New System.Windows.Forms.DateTimePicker()
        Me.CmbFdp = New System.Windows.Forms.ComboBox()
        Me.TxtDscto = New System.Windows.Forms.TextBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.LblFechaDp = New System.Windows.Forms.Label()
        Me.LblFormaDp = New System.Windows.Forms.Label()
        Me.LblApagar = New System.Windows.Forms.Label()
        Me.LblDias = New System.Windows.Forms.Label()
        Me.LblPrcDia = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.LblDscto = New System.Windows.Forms.Label()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.LblCliente = New System.Windows.Forms.Label()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.DtpFdi)
        Me.GroupBox.Controls.Add(Me.LblFechaDi)
        Me.GroupBox.Controls.Add(Me.TxtApagar)
        Me.GroupBox.Controls.Add(Me.TxtDias)
        Me.GroupBox.Controls.Add(Me.TxtPrcDia)
        Me.GroupBox.Controls.Add(Me.TxtTotal)
        Me.GroupBox.Controls.Add(Me.BtnCancelar)
        Me.GroupBox.Controls.Add(Me.BtnPagar)
        Me.GroupBox.Controls.Add(Me.DtpFdp)
        Me.GroupBox.Controls.Add(Me.CmbFdp)
        Me.GroupBox.Controls.Add(Me.TxtDscto)
        Me.GroupBox.Controls.Add(Me.TxtPrecio)
        Me.GroupBox.Controls.Add(Me.LblFechaDp)
        Me.GroupBox.Controls.Add(Me.LblFormaDp)
        Me.GroupBox.Controls.Add(Me.LblApagar)
        Me.GroupBox.Controls.Add(Me.LblDias)
        Me.GroupBox.Controls.Add(Me.LblPrcDia)
        Me.GroupBox.Controls.Add(Me.LblTotal)
        Me.GroupBox.Controls.Add(Me.LblDscto)
        Me.GroupBox.Controls.Add(Me.LblPrecio)
        Me.GroupBox.Location = New System.Drawing.Point(36, 72)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(510, 380)
        Me.GroupBox.TabIndex = 0
        Me.GroupBox.TabStop = False
        '
        'DtpFdi
        '
        Me.DtpFdi.CustomFormat = "dd 'de' MMMM 'de' yyyy"
        Me.DtpFdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFdi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFdi.Location = New System.Drawing.Point(154, 32)
        Me.DtpFdi.Name = "DtpFdi"
        Me.DtpFdi.Size = New System.Drawing.Size(200, 22)
        Me.DtpFdi.TabIndex = 0
        '
        'LblFechaDi
        '
        Me.LblFechaDi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaDi.Location = New System.Drawing.Point(12, 32)
        Me.LblFechaDi.Name = "LblFechaDi"
        Me.LblFechaDi.Size = New System.Drawing.Size(120, 22)
        Me.LblFechaDi.TabIndex = 7
        Me.LblFechaDi.Text = "Fecha de inicio"
        Me.LblFechaDi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtApagar
        '
        Me.TxtApagar.BackColor = System.Drawing.SystemColors.Window
        Me.TxtApagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtApagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApagar.Location = New System.Drawing.Point(154, 248)
        Me.TxtApagar.Name = "TxtApagar"
        Me.TxtApagar.Size = New System.Drawing.Size(200, 22)
        Me.TxtApagar.TabIndex = 17
        Me.TxtApagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtDias
        '
        Me.TxtDias.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDias.ForeColor = System.Drawing.Color.Green
        Me.TxtDias.Location = New System.Drawing.Point(154, 212)
        Me.TxtDias.Name = "TxtDias"
        Me.TxtDias.Size = New System.Drawing.Size(200, 22)
        Me.TxtDias.TabIndex = 15
        Me.TxtDias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtPrcDia
        '
        Me.TxtPrcDia.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPrcDia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrcDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrcDia.Location = New System.Drawing.Point(154, 176)
        Me.TxtPrcDia.Name = "TxtPrcDia"
        Me.TxtPrcDia.Size = New System.Drawing.Size(200, 22)
        Me.TxtPrcDia.TabIndex = 13
        Me.TxtPrcDia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(154, 140)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(200, 22)
        Me.TxtTotal.TabIndex = 11
        Me.TxtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.BtnCancelar.Location = New System.Drawing.Point(384, 140)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Padding = New System.Windows.Forms.Padding(0, 9, 0, 5)
        Me.BtnCancelar.Size = New System.Drawing.Size(100, 75)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "C&ancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCancelar.UseVisualStyleBackColor = False
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
        Me.BtnPagar.Location = New System.Drawing.Point(384, 32)
        Me.BtnPagar.Name = "BtnPagar"
        Me.BtnPagar.Padding = New System.Windows.Forms.Padding(0, 10, 0, 5)
        Me.BtnPagar.Size = New System.Drawing.Size(100, 75)
        Me.BtnPagar.TabIndex = 6
        Me.BtnPagar.Text = "&Pagar"
        Me.BtnPagar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPagar.UseVisualStyleBackColor = True
        '
        'DtpFdp
        '
        Me.DtpFdp.CustomFormat = "dd 'de' MMMM 'de' yyyy"
        Me.DtpFdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFdp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFdp.Location = New System.Drawing.Point(154, 322)
        Me.DtpFdp.Name = "DtpFdp"
        Me.DtpFdp.Size = New System.Drawing.Size(200, 22)
        Me.DtpFdp.TabIndex = 4
        '
        'CmbFdp
        '
        Me.CmbFdp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbFdp.FormattingEnabled = True
        Me.CmbFdp.ItemHeight = 16
        Me.CmbFdp.Items.AddRange(New Object() {"EFECTIVO", "BIZUM", "TARJETA", "TRANSFERENCIA"})
        Me.CmbFdp.Location = New System.Drawing.Point(154, 286)
        Me.CmbFdp.Name = "CmbFdp"
        Me.CmbFdp.Size = New System.Drawing.Size(200, 24)
        Me.CmbFdp.TabIndex = 3
        '
        'TxtDscto
        '
        Me.TxtDscto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDscto.Location = New System.Drawing.Point(154, 104)
        Me.TxtDscto.MaxLength = 10
        Me.TxtDscto.Name = "TxtDscto"
        Me.TxtDscto.Size = New System.Drawing.Size(200, 22)
        Me.TxtDscto.TabIndex = 2
        Me.TxtDscto.Text = "0"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecio.Location = New System.Drawing.Point(154, 68)
        Me.TxtPrecio.MaxLength = 10
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(200, 22)
        Me.TxtPrecio.TabIndex = 1
        Me.TxtPrecio.Text = "0"
        '
        'LblFechaDp
        '
        Me.LblFechaDp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaDp.Location = New System.Drawing.Point(12, 322)
        Me.LblFechaDp.Name = "LblFechaDp"
        Me.LblFechaDp.Size = New System.Drawing.Size(120, 22)
        Me.LblFechaDp.TabIndex = 19
        Me.LblFechaDp.Text = "Fecha de pago"
        Me.LblFechaDp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblFormaDp
        '
        Me.LblFormaDp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFormaDp.Location = New System.Drawing.Point(12, 286)
        Me.LblFormaDp.Name = "LblFormaDp"
        Me.LblFormaDp.Size = New System.Drawing.Size(120, 22)
        Me.LblFormaDp.TabIndex = 18
        Me.LblFormaDp.Text = "Forma de pago"
        Me.LblFormaDp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblApagar
        '
        Me.LblApagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApagar.Location = New System.Drawing.Point(12, 248)
        Me.LblApagar.Name = "LblApagar"
        Me.LblApagar.Size = New System.Drawing.Size(120, 22)
        Me.LblApagar.TabIndex = 16
        Me.LblApagar.Text = "A Pagar"
        Me.LblApagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDias
        '
        Me.LblDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDias.Location = New System.Drawing.Point(12, 212)
        Me.LblDias.Name = "LblDias"
        Me.LblDias.Size = New System.Drawing.Size(120, 22)
        Me.LblDias.TabIndex = 14
        Me.LblDias.Text = "Días"
        Me.LblDias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPrcDia
        '
        Me.LblPrcDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrcDia.Location = New System.Drawing.Point(12, 176)
        Me.LblPrcDia.Name = "LblPrcDia"
        Me.LblPrcDia.Size = New System.Drawing.Size(120, 22)
        Me.LblPrcDia.TabIndex = 12
        Me.LblPrcDia.Text = "Precio día"
        Me.LblPrcDia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTotal
        '
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(12, 140)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(120, 22)
        Me.LblTotal.TabIndex = 10
        Me.LblTotal.Text = "Total"
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDscto
        '
        Me.LblDscto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDscto.Location = New System.Drawing.Point(12, 104)
        Me.LblDscto.Name = "LblDscto"
        Me.LblDscto.Size = New System.Drawing.Size(120, 22)
        Me.LblDscto.TabIndex = 9
        Me.LblDscto.Text = "Descuento"
        Me.LblDscto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPrecio
        '
        Me.LblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecio.Location = New System.Drawing.Point(12, 68)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(120, 22)
        Me.LblPrecio.TabIndex = 8
        Me.LblPrecio.Text = "Precio"
        Me.LblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCliente
        '
        Me.LblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCliente.Location = New System.Drawing.Point(33, 9)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(493, 60)
        Me.LblCliente.TabIndex = 1
        Me.LblCliente.Text = "NOMBRE COMPLETO DEL CLIENTE Y SU EDAD"
        Me.LblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmPagoMensual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 485)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.LblCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmPagoMensual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago de mensualidad"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents DtpFdi As DateTimePicker
    Friend WithEvents LblFechaDi As Label
    Friend WithEvents TxtApagar As Label
    Friend WithEvents TxtDias As Label
    Friend WithEvents TxtPrcDia As Label
    Friend WithEvents TxtTotal As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnPagar As Button
    Friend WithEvents DtpFdp As DateTimePicker
    Friend WithEvents CmbFdp As ComboBox
    Friend WithEvents TxtDscto As TextBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents LblFechaDp As Label
    Friend WithEvents LblFormaDp As Label
    Friend WithEvents LblApagar As Label
    Friend WithEvents LblDias As Label
    Friend WithEvents LblPrcDia As Label
    Friend WithEvents LblTotal As Label
    Friend WithEvents LblDscto As Label
    Friend WithEvents LblPrecio As Label
    Friend WithEvents LblCliente As Label
End Class
