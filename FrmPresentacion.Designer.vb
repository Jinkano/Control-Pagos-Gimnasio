<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPresentacion
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
        Me.components = New System.ComponentModel.Container()
        Me.LblTitulo2 = New System.Windows.Forms.Label()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.LblCopyright = New System.Windows.Forms.Label()
        Me.LblVersion = New System.Windows.Forms.Label()
        Me.LblTitulo1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitulo2
        '
        Me.LblTitulo2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblTitulo2.AutoSize = True
        Me.LblTitulo2.BackColor = System.Drawing.Color.Transparent
        Me.LblTitulo2.Font = New System.Drawing.Font("Ink Free", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo2.Location = New System.Drawing.Point(374, 140)
        Me.LblTitulo2.Name = "LblTitulo2"
        Me.LblTitulo2.Size = New System.Drawing.Size(312, 36)
        Me.LblTitulo2.TabIndex = 11
        Me.LblTitulo2.Text = "Juan Hinostroza Team"
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.Location = New System.Drawing.Point(414, 329)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(211, 16)
        Me.LblDescripcion.TabIndex = 10
        Me.LblDescripcion.Text = "Descripción acerca del programa."
        '
        'LblCopyright
        '
        Me.LblCopyright.AutoSize = True
        Me.LblCopyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCopyright.Location = New System.Drawing.Point(414, 290)
        Me.LblCopyright.Name = "LblCopyright"
        Me.LblCopyright.Size = New System.Drawing.Size(64, 16)
        Me.LblCopyright.TabIndex = 9
        Me.LblCopyright.Text = "Copyright"
        '
        'LblVersion
        '
        Me.LblVersion.AutoSize = True
        Me.LblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVersion.Location = New System.Drawing.Point(414, 252)
        Me.LblVersion.Name = "LblVersion"
        Me.LblVersion.Size = New System.Drawing.Size(100, 16)
        Me.LblVersion.TabIndex = 8
        Me.LblVersion.Text = "Versión  1.01.01"
        '
        'LblTitulo1
        '
        Me.LblTitulo1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblTitulo1.AutoSize = True
        Me.LblTitulo1.BackColor = System.Drawing.Color.Transparent
        Me.LblTitulo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo1.Location = New System.Drawing.Point(374, 82)
        Me.LblTitulo1.Name = "LblTitulo1"
        Me.LblTitulo1.Size = New System.Drawing.Size(219, 33)
        Me.LblTitulo1.TabIndex = 7
        Me.LblTitulo1.Text = "Segundos fuera"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(76, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(238, 263)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Timer
        '
        Me.Timer.Interval = 2000
        '
        'FrmPresentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblTitulo2)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.LblCopyright)
        Me.Controls.Add(Me.LblVersion)
        Me.Controls.Add(Me.LblTitulo1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPresentacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPresentacion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitulo2 As Label
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents LblCopyright As Label
    Friend WithEvents LblVersion As Label
    Friend WithEvents LblTitulo1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer As Timer
End Class
