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
        Me.PnlBotonera = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnPagarMes = New System.Windows.Forms.Button()
        Me.BtnNuevoPago = New System.Windows.Forms.Button()
        Me.BtnCambiar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.StsBarra = New System.Windows.Forms.StatusStrip()
        Me.SlblTitulo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SlblDescrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PnlBotonera.SuspendLayout()
        Me.StsBarra.SuspendLayout()
        Me.SuspendLayout()
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
        Me.PnlBotonera.Controls.Add(Me.BtnCambiar)
        Me.PnlBotonera.Controls.Add(Me.BtnGuardar)
        Me.PnlBotonera.Controls.Add(Me.BtnCancelar)
        Me.PnlBotonera.Controls.Add(Me.BtnModificar)
        Me.PnlBotonera.Controls.Add(Me.BtnActualizar)
        Me.PnlBotonera.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlBotonera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlBotonera.Location = New System.Drawing.Point(1287, 0)
        Me.PnlBotonera.Name = "PnlBotonera"
        Me.PnlBotonera.Size = New System.Drawing.Size(180, 821)
        Me.PnlBotonera.TabIndex = 75
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
        'StsBarra
        '
        Me.StsBarra.Dock = System.Windows.Forms.DockStyle.None
        Me.StsBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlblTitulo, Me.SlblDescrip})
        Me.StsBarra.Location = New System.Drawing.Point(-8, 764)
        Me.StsBarra.Name = "StsBarra"
        Me.StsBarra.Size = New System.Drawing.Size(1213, 46)
        Me.StsBarra.TabIndex = 80
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
        'A_modify_A
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1467, 821)
        Me.Controls.Add(Me.PnlBotonera)
        Me.Controls.Add(Me.StsBarra)
        Me.Name = "A_modify_A"
        Me.Text = "A_modify_A"
        Me.PnlBotonera.ResumeLayout(False)
        Me.StsBarra.ResumeLayout(False)
        Me.StsBarra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlBotonera As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnPagarMes As Button
    Friend WithEvents BtnNuevoPago As Button
    Friend WithEvents BtnCambiar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents StsBarra As StatusStrip
    Friend WithEvents SlblTitulo As ToolStripStatusLabel
    Friend WithEvents SlblDescrip As ToolStripStatusLabel
End Class
