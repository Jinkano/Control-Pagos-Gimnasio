Imports System.ComponentModel
Imports System.Drawing.Drawing2D ' Necesario para GraphicsPath y SmoothingMode
Imports System.Windows.Forms.VisualStyles ' Opcional: Para dibujar el circulo si no lo dibujamos a mano



'' Esto no oculta el encabezado, pero elimina la interacción del usuario
''LViewMorosos.HeaderStyle = ColumnHeaderStyle.None
'' En el código de tu formulario
'Dim miRadioButton As New CustomRadioButton()
'miRadioButton.Appearance = Appearance.Button
'miRadioButton.Location = New Point(25, 133)
'miRadioButton.Size = New Size(300, 40)
'miRadioButton.Text = "Opción 1"
'miRadioButton.BorderRadius = 20
'miRadioButton.BorderColor = Color.Blue
'miRadioButton.BorderSize = 2
'Me.Controls.Add(miRadioButton)


Public Class CustomRadioButton
    Inherits RadioButton

    ' (Mantener propiedades BorderSize, BorderRadius, BorderColor, Constructor y GetFigurePath intactos)
    ' ... (Propiedades y GetFigurePath) ...

    Private _borderSize As Integer = 0
    Private _borderRadius As Integer = 20
    Private _borderColor As Color = Color.PaleVioletRed

    <Category("Custom RadioButton")>
    Public Property BorderSize As Integer
        Get
            Return _borderSize
        End Get
        Set(value As Integer)
            _borderSize = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Custom RadioButton")>
    Public Property BorderRadius As Integer
        Get
            Return _borderRadius
        End Get
        Set(value As Integer)
            _borderRadius = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Custom RadioButton")>
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(value As Color)
            _borderColor = value
            Me.Invalidate()
        End Set
    End Property

    Public Sub New()
        ' Importante: El estilo AllPaintingInWmPaint deshabilita el dibujo nativo.
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint Or ControlStyles.SupportsTransparentBackColor, True)

        ' Habilitar Double Buffering para un dibujo suave
        Me.SetStyle(ControlStyles.DoubleBuffer, True)

        Me.BackColor = Color.Transparent
        Me.ForeColor = Color.Black
    End Sub

    Private Function GetFigurePath(rect As Rectangle, radius As Single) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim curveSize As Single = radius * 2.0F
        path.StartFigure()
        path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90)
        path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90)
        path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90)
        path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    ' ----------------------------------------------------------------------------------
    ' MÉTODO ONPAINT CORREGIDO
    ' ----------------------------------------------------------------------------------
    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        ' NO LLAMAR A MyBase.OnPaint(e) AQUÍ.
        ' Esto evita que el RadioButton nativo se dibuje encima de tu diseño.
        ' 1. BORRAR EL FONDO DEL CONTROL para eliminar artefactos
        e.Graphics.Clear(Me.Parent.BackColor)

        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        Dim rect As Rectangle = Me.ClientRectangle
        Dim path As GraphicsPath = GetFigurePath(rect, _borderRadius)

        ' 1. DIBUJAR EL FONDO REDONDEADO (Cuerpo del RadioButton)
        Using brush As New SolidBrush(Me.BackColor)
            g.FillPath(brush, path)
        End Using

        ' 2. DIBUJAR EL BORDE REDONDEADO
        If _borderSize > 0 Then
            Using pen As New Pen(_borderColor, _borderSize)
                g.DrawPath(pen, path)
            End Using
        End If

        ' 3. DIBUJAR EL CÍRCULO NATIVO DE SELECCIÓN Y EL TEXTO

        ' Definir el área rectangular donde se dibujará el círculo (a la izquierda)
        ' Usamos la altura como referencia para el tamaño.
        Dim sizeCircle As Integer = Me.Height - 4 ' Tamaño del círculo
        Dim radioRect As New Rectangle(
            2, _ ' Posición X (un pequeño margen)
            (Me.Height \ 2) - (sizeCircle \ 2), _ ' Posición Y (centrado verticalmente)
            sizeCircle,
            sizeCircle)

        ' DIBUJAR EL CÍRCULO EXTERNO (Simular el círculo radio nativo)
        Using penCircle As New Pen(Me.ForeColor, 2) ' Usar ForeColor para el color del borde
            g.DrawEllipse(penCircle, radioRect)
        End Using

        ' 4. DIBUJAR EL PUNTO DE SELECCIÓN (Solo si está Checked)
        If Me.Checked Then
            ' Reducir el rectángulo para el punto interno
            Dim pointRect As New Rectangle(radioRect.X + 4, radioRect.Y + 4, radioRect.Width - 8, radioRect.Height - 8)
            Using brushPoint As New SolidBrush(Me.ForeColor)
                g.FillEllipse(brushPoint, pointRect)
            End Using
        End If

        ' 5. DIBUJAR EL TEXTO (Desplazado a la derecha del círculo)
        Dim textRect As New Rectangle(
            radioRect.Right + 5, ' Comienza 5px después del círculo
            0,
            Me.Width - radioRect.Right - 5,
            Me.Height)

        ' Dibujar el texto centrado verticalmente
        TextRenderer.DrawText(g, Me.Text, Me.Font, textRect, Me.ForeColor, TextFormatFlags.VerticalCenter)

    End Sub

    ' Suscribir el evento HandleCreated para manejar cambios de fondo del contenedor
    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        MyBase.OnHandleCreated(e)
        ' Invalidate() fuerza el redibujo cuando el contenedor cambia de color.
        If Me.Parent IsNot Nothing Then
            AddHandler Me.Parent.BackColorChanged, AddressOf Parent_BackColorChanged
        End If
    End Sub

    Private Sub Parent_BackColorChanged(sender As Object, e As EventArgs)
        Me.Invalidate()
    End Sub

    ' Manejar el evento CheckedChanged para forzar el redibujo al seleccionar/deseleccionar
    Protected Overrides Sub OnCheckedChanged(e As EventArgs)
        Me.Invalidate()
        MyBase.OnCheckedChanged(e)
    End Sub

End Class