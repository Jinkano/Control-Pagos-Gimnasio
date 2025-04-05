Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FrmPresentacion.ShowDialog() 'MOSTRAMOS EL FORMULARIO PRESENTACIÓN

    End Sub

    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click

        Me.Hide() 'OCULTAR FORMULARIO LOGIN

        FrmPrincipal.Show() 'MOSTRAR FORM PRIMCIPAL

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        End 'FINALIZAR LA APLICACIÓN

    End Sub
End Class
