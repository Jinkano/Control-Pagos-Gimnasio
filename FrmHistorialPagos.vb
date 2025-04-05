Imports MySql.Data.MySqlClient

Public Class FrmHistorialPagos
    '
    Dim cnxnMySql As New MySqlConnection
    Dim drDataReader As MySqlDataReader
    Dim cmdCommand As MySqlCommand
    Dim sqlConsulta As String
    Public Shared psIdCli As String
    Dim arrayMeses() As String = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}
    '
    Private Sub FrmHistorialPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        Try
            '
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()
            sqlConsulta = "SELECT * FROM pagos WHERE id_cli = '" & psIdCli & "' ORDER BY id_pgs"
            '
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader
            '
            'DgvHistorialPagos.Rows.Clear()
            If drDataReader.HasRows Then
                '
                While drDataReader.Read()
                    '
                    Dim nRow = DgvHistorialPagos.Rows.Add()
                    '
                    Dim fecha As DateTime = drDataReader.GetDateTime(1).ToShortDateString
                    Dim dia = fecha.Day
                    Dim mes = fecha.Month
                    Dim ano = fecha.Year
                    DgvHistorialPagos.Rows(nRow).Cells(0).Value = dia & " de " & arrayMeses(mes - 1) & " de " & ano 'FECHA DE INICIO
                    '
                    Dim precio = drDataReader.GetDecimal(4).ToString
                    DgvHistorialPagos.Rows(nRow).Cells(1).Value = FormatCurrency(precio)
                    Dim dscto = drDataReader.GetDecimal(5).ToString
                    DgvHistorialPagos.Rows(nRow).Cells(2).Value = FormatCurrency(dscto)
                    Dim total = precio - dscto
                    DgvHistorialPagos.Rows(nRow).Cells(3).Value = FormatCurrency(total)
                    Dim nDias = DateTime.DaysInMonth(fecha.Year, fecha.Month)
                    Dim prcDia = total / nDias
                    nDias = nDias - dia + 1
                    DgvHistorialPagos.Rows(nRow).Cells(4).Value = nDias
                    DgvHistorialPagos.Rows(nRow).Cells(5).Value = FormatCurrency(prcDia * nDias) 'A PAGAR
                    '
                    If drDataReader.GetDateTime(2).ToShortDateString = "01/01/0101" Then
                        DgvHistorialPagos.Rows(nRow).Cells(6).Value = ""
                    Else
                        DgvHistorialPagos.Rows(nRow).Cells(6).Value = FechaLarga(drDataReader.GetDateTime(2).ToShortDateString)
                    End If
                    '
                    DgvHistorialPagos.Rows(nRow).Cells(7).Value = drDataReader.GetString(3).ToString 'FORMA DE PAGO
                End While
            End If
            '
            drDataReader.Close()
            cnxnMySql.Close()
            '
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        '
        Close()
    End Sub
    '
End Class