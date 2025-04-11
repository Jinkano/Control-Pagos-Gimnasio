Imports MySql.Data.MySqlClient

Public Class FrmHistorialPagos

    Dim cnxnMySql As New MySqlConnection
    Dim drDataReader As MySqlDataReader
    Dim cmdCommand As MySqlCommand
    Dim sqlConsulta As String
    Public Shared psIdCli As String

    Private Sub FrmHistorialPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'CONSULTANOS A LA BBDD EL HISTORIAL DE PAGOS DEL CLIENTE SELECCIONADO
        sqlConsulta = "SELECT * FROM pagos WHERE id_cli = '" & psIdCli & "' ORDER BY id_pgs DESC"
        DgvLlenarPagos(sqlConsulta, DgvListaPagos)
    End Sub

    Private Sub TxtEstado_TextChanged(sender As Object, e As EventArgs) Handles TxtEstado.TextChanged
        'COMPROBAR ESTADO DEL CLIENTE
        If TxtEstado.Text = "INACTIVO" Then BtnPagarMes.Enabled = False : BtnNuevoPago.Enabled = False
    End Sub

    Private Sub BtnPagarMes_Click(sender As Object, e As EventArgs) Handles BtnPagarMes.Click

        'COMPROBAMOS SI EL MES SELECCIONADO YA ESTÁ PAGADO
        If DgvListaPagos.CurrentRow.Cells(7).Value = "--/--/----" Then
            'txtFlags = "UPDATE_PAY"
            'ENVIAMOS LOS DATOS DEL MES AL FORMULARIO PAGOS
            FrmPagoMensual.psIdPgs = DgvListaPagos.CurrentRow.Cells(0).Value.ToString 'ID_PAGO
            FrmPagoMensual.LblCliente.Text = TxtCliente.Text 'NOMBRE, APELLIDO y EDAD
            FrmPagoMensual.DtpFdi.Value = DgvListaPagos.CurrentRow.Cells(1).Value.ToString 'FECHA DE INICIO DE MES
            FrmPagoMensual.TxtPrecio.Text = DgvListaPagos.CurrentRow.Cells(2).Value.ToString 'PRECIO
            FrmPagoMensual.TxtDscto.Text = DgvListaPagos.CurrentRow.Cells(3).Value.ToString 'DESCUENTO
            FrmPagoMensual.ShowDialog()
        Else
            MsgBox("FECHA    : " & DgvListaPagos.CurrentRow.Cells(1).Value.ToString & Chr(13) & Chr(13&) &
                   "ESTADO  : PAGADO" & Chr(13&) & Chr(13&) &
                   "Selecciona otro registro para realizar el pago.", vbInformation, "Pago mensual")
        End If
    End Sub

    Private Sub BtnNuevoPago_Click(sender As Object, e As EventArgs) Handles BtnNuevoPago.Click
        'DECLARAR VARIABLES PARA ALMACENAR EL PRECIO Y EL DSCTO
        Dim precio, descto As Decimal
        Try
            'CONECTAR Y ABRIR BBDD
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()

            sqlConsulta = "SELECT * FROM tarifas WHERE e_min <= '" & TxtEdad.Text & "' AND e_max >= '" & TxtEdad.Text & "'"
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader
            drDataReader.Read()

            precio = Replace(drDataReader.GetDecimal(1).ToString, ".", ",")
            descto = Replace(drDataReader.GetDecimal(4).ToString, ".", ",")

            drDataReader.Close()
            cnxnMySql.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        'txtFlags = "UPDATE_PAY"
        'ENVIAMOS LOS DATOS DEL MES AL FORMULARIO PAGOS
        FrmPagoMensual.Text = "Nuevo pago mensual"
        FrmPagoMensual.psIdCli = psIdCli 'ID CLIENTE
        FrmPagoMensual.LblCliente.Text = TxtCliente.Text 'NOMBRE, APELLIDO y EDAD
        FrmPagoMensual.DtpFdi.Value = DateTime.Now 'FECHA DE INICIO DE MES
        FrmPagoMensual.TxtPrecio.Text = precio & " €"
        FrmPagoMensual.TxtDscto.Text = descto & " €"

        FrmPagoMensual.ShowDialog() 'MOSTRAR EL FORM
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        'CERRAR FORM FrmHistorialPagos
        Close()
    End Sub

End Class