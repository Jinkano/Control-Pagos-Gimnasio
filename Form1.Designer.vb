<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnEntrar = New System.Windows.Forms.Button()
        Me.TxtContrasena = New System.Windows.Forms.TextBox()
        Me.LblContrasena = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(429, 217)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(150, 30)
        Me.BtnSalir.TabIndex = 13
        Me.BtnSalir.Text = "Cerrar &App"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnEntrar
        '
        Me.BtnEntrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEntrar.Location = New System.Drawing.Point(264, 217)
        Me.BtnEntrar.Name = "BtnEntrar"
        Me.BtnEntrar.Size = New System.Drawing.Size(150, 30)
        Me.BtnEntrar.TabIndex = 12
        Me.BtnEntrar.Text = "&Iniciar sesión"
        Me.BtnEntrar.UseVisualStyleBackColor = True
        '
        'TxtContrasena
        '
        Me.TxtContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContrasena.Location = New System.Drawing.Point(264, 156)
        Me.TxtContrasena.Name = "TxtContrasena"
        Me.TxtContrasena.Size = New System.Drawing.Size(315, 26)
        Me.TxtContrasena.TabIndex = 11
        Me.TxtContrasena.Text = "txtContraseña"
        '
        'LblContrasena
        '
        Me.LblContrasena.AutoSize = True
        Me.LblContrasena.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContrasena.Location = New System.Drawing.Point(260, 131)
        Me.LblContrasena.Name = "LblContrasena"
        Me.LblContrasena.Size = New System.Drawing.Size(105, 22)
        Me.LblContrasena.TabIndex = 10
        Me.LblContrasena.Text = "&Contraseña"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Location = New System.Drawing.Point(264, 84)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(315, 26)
        Me.TxtUsuario.TabIndex = 9
        Me.TxtUsuario.Text = "txtUsuario"
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.Location = New System.Drawing.Point(260, 59)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(166, 22)
        Me.LblUsuario.TabIndex = 8
        Me.LblUsuario.Text = "&Nombre de usuario"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(43, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(211, 206)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 311)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEntrar)
        Me.Controls.Add(Me.TxtContrasena)
        Me.Controls.Add(Me.LblContrasena)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuario y Contraseña"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnEntrar As Button
    Friend WithEvents TxtContrasena As TextBox
    Friend WithEvents LblContrasena As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents LblUsuario As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
