Imports MySql.Data.MySqlClient

Public Class FrmClientesPagos

    Dim cnxnMySql As New MySqlConnection
    Dim drDataReader As MySqlDataReader
    Dim cmdCommand As MySqlCommand
    Dim sqlConsulta, idClient, strIdCli As String
    Dim nRow As Int16 ', rptMsgBox
    Public txtFlags As String

    Private Sub FrmClientesPagos_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

End Class