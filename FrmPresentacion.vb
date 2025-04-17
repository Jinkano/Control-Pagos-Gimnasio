Public Class FrmPresentacion
    Private Sub FrmPresentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'ASIRNAR TEXTO A LA ETIQUE VERSIÓN
        'Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)
        'LblVersion.Text = System.String.Format(LblVersion.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'ASIRNAR TEXTO A LA ETIQUE CON LA INFORMACIÓN DEL COPYRIGHT 
        'LblCopyright.Text = My.Application.Info.Copyright

        'INICIAR EL TIMER
        Timer.Start()

    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        Timer.Stop() 'DETENER TIMER

        Me.Close() 'CERRA EL FORMULARIO

        FrmPrincipal.Show() 'MOSTRAMOS EL FORMULARIO LOGIN

    End Sub
End Class