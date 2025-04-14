<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
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
        Me.PnlBotonera = New System.Windows.Forms.Panel()
        Me.BtnClientesPagos = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.BtnTablaDsctos = New System.Windows.Forms.Button()
        Me.BtnListaMorosos = New System.Windows.Forms.Button()
        Me.BtnListaClientes = New System.Windows.Forms.Button()
        Me.PnlBotonera.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBotonera
        '
        Me.PnlBotonera.AutoSize = True
        Me.PnlBotonera.Controls.Add(Me.BtnClientesPagos)
        Me.PnlBotonera.Controls.Add(Me.BtnSalir)
        Me.PnlBotonera.Controls.Add(Me.Panel)
        Me.PnlBotonera.Controls.Add(Me.BtnTablaDsctos)
        Me.PnlBotonera.Controls.Add(Me.BtnListaMorosos)
        Me.PnlBotonera.Controls.Add(Me.BtnListaClientes)
        Me.PnlBotonera.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlBotonera.Location = New System.Drawing.Point(0, 0)
        Me.PnlBotonera.Name = "PnlBotonera"
        Me.PnlBotonera.Size = New System.Drawing.Size(188, 561)
        Me.PnlBotonera.TabIndex = 0
        '
        'BtnClientesPagos
        '
        Me.BtnClientesPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientesPagos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnClientesPagos.Location = New System.Drawing.Point(0, 101)
        Me.BtnClientesPagos.Name = "BtnClientesPagos"
        Me.BtnClientesPagos.Size = New System.Drawing.Size(184, 74)
        Me.BtnClientesPagos.TabIndex = 4
        Me.BtnClientesPagos.Text = "C&LIENTES completo"
        Me.BtnClientesPagos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnClientesPagos.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Image = Global.ControlPagosGimnasio.My.Resources.Resources.salir22
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSalir.Location = New System.Drawing.Point(0, 461)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(188, 74)
        Me.BtnSalir.TabIndex = 3
        Me.BtnSalir.Text = "CERRAR &APP"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Panel
        '
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel.Location = New System.Drawing.Point(0, 535)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(188, 26)
        Me.Panel.TabIndex = 1
        '
        'BtnTablaDsctos
        '
        Me.BtnTablaDsctos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTablaDsctos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnTablaDsctos.Location = New System.Drawing.Point(0, 365)
        Me.BtnTablaDsctos.Name = "BtnTablaDsctos"
        Me.BtnTablaDsctos.Size = New System.Drawing.Size(184, 74)
        Me.BtnTablaDsctos.TabIndex = 2
        Me.BtnTablaDsctos.Text = "TABLA &DESCUENTOS"
        Me.BtnTablaDsctos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnTablaDsctos.UseVisualStyleBackColor = True
        '
        'BtnListaMorosos
        '
        Me.BtnListaMorosos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnListaMorosos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnListaMorosos.Location = New System.Drawing.Point(0, 192)
        Me.BtnListaMorosos.Name = "BtnListaMorosos"
        Me.BtnListaMorosos.Size = New System.Drawing.Size(184, 74)
        Me.BtnListaMorosos.TabIndex = 1
        Me.BtnListaMorosos.Text = "LISTA DE &MOROSOS"
        Me.BtnListaMorosos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnListaMorosos.UseVisualStyleBackColor = True
        '
        'BtnListaClientes
        '
        Me.BtnListaClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnListaClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnListaClientes.Location = New System.Drawing.Point(1, 12)
        Me.BtnListaClientes.Name = "BtnListaClientes"
        Me.BtnListaClientes.Size = New System.Drawing.Size(184, 74)
        Me.BtnListaClientes.TabIndex = 0
        Me.BtnListaClientes.Text = "&CLIENTES individual"
        Me.BtnListaClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnListaClientes.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.PnlBotonera)
        Me.IsMdiContainer = True
        Me.MinimumSize = New System.Drawing.Size(1200, 500)
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gimnasio Segundos Fuera   -   USUARIO : :  "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlBotonera.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlBotonera As Panel
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Panel As Panel
    Friend WithEvents BtnTablaDsctos As Button
    Friend WithEvents BtnListaMorosos As Button
    Friend WithEvents BtnListaClientes As Button
    Friend WithEvents BtnClientesPagos As Button
End Class
