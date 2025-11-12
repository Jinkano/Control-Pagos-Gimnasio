Imports MySql.Data.MySqlClient

Public Class A_modify_A

    Dim cnxnMySql As New MySqlConnection
    Dim drDataReader As MySqlDataReader
    Dim cmdCommand As MySqlCommand
    Dim sqlConsulta, idClient, strIdCli As String
    Dim nRow As Int16 ', rptMsgBox
    Public txtFlags As String


    Private Sub BtnPagarMes_Click(sender As Object, e As EventArgs) Handles BtnPagarMes.Click

        'COMPROBAMOS SI EL MES SELECCIONADO YA ESTÁ PAGADO
        If DgvListaPagos.CurrentRow.Cells(7).Value = "--/--/----" Then

            txtFlags = "UPDATE_PAY" 'VARIABLE BANDERA PARA ACTUALIZAR LA GRILLA DgvListaPagos

            'ENVIAMOS LOS DATOS DEL MES AL FORMULARIO PAGOS
            FrmPagoMensual.psIdPgs = DgvListaPagos.CurrentRow.Cells(0).Value.ToString 'ID_PAGO
            'FrmPagoMensual.LblCliente.Text = TxtNomCli.Text & " " & TxtApeCli.Text & " - " & TxtEdaCli.Text 'NOMBRE, APELLIDO y EDAD
            FrmPagoMensual.DtpFdiPgs.Value = DgvListaPagos.CurrentRow.Cells(1).Value.ToString 'FECHA DE INICIO DE MES
            FrmPagoMensual.TxtPrcPgs.Text = DgvListaPagos.CurrentRow.Cells(2).Value.ToString 'PRECIO
            FrmPagoMensual.TxtDscPgs.Text = DgvListaPagos.CurrentRow.Cells(3).Value.ToString 'DESCUENTO
            'FrmPagoMensual.nomUser = FrmPrincipal.nomUser 'USUARIO

            FrmPagoMensual.MdiParent = FrmPrincipal
            FrmPagoMensual.Show()
        Else
            MsgBox("FECHA    : " & DgvListaPagos.CurrentRow.Cells(1).Value.ToString & Chr(13) & Chr(13&) &
                   "ESTADO  : PAGADO" & Chr(13&) & Chr(13&) &
                   "Selecciona otro registro para realizar el pago.", vbInformation, "Pago mensual")
        End If

    End Sub

    Private Sub BtnNuevoPago_Click(sender As Object, e As EventArgs) Handles BtnNuevoPago.Click

        'VARIABLES PARA ALMACENAR EL PRECIO Y EL DSCTO
        Dim precio, descto As Decimal
        Try
            'CONECTAR Y ABRIR LA BBDD
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()

            'SELECCIONAMOS EL DESCUENTO CORRESPONDIENTE A LA EDAD
            'sqlConsulta = "SELECT * FROM tarifas WHERE e_min <= '" & TxtEdaCli.Text & "' AND e_max >= '" & TxtEdaCli.Text & "'"
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader

            'COMPROBAMOS SI HAY REGISTROS
            If drDataReader.HasRows Then
                drDataReader.Read()
                precio = Replace(drDataReader.GetDecimal(1).ToString, ".", ",")
                descto = Replace(drDataReader.GetDecimal(4).ToString, ".", ",")
            Else
                drDataReader.Close()
                sqlConsulta = "SELECT precio FROM tarifas WHERE id_tarifa = 1"
                cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                drDataReader = cmdCommand.ExecuteReader
                drDataReader.Read()
                precio = Replace(drDataReader.GetDecimal(0).ToString, ".", ",")
                descto = 0
            End If

            'CERRAR EL DATAREADER Y LA BBDD
            drDataReader.Close()
            cnxnMySql.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        txtFlags = "UPDATE_PAY" 'VARIABLE BANDERA PARA ACTUALIZAR LA GRILLA DgvListaPagos

        'ENVIAMOS LOS DATOS DEL MES AL FORMULARIO PAGOS
        FrmPagoMensual.Text = "Nuevo pago mensual"
        FrmPagoMensual.MdiParent = FrmPrincipal
        'FrmPagoMensual.psIdCli = DgvListaClientes.CurrentRow.Cells(0).Value.ToString 'ID CLIENTE
        'FrmPagoMensual.LblCliente.Text = TxtNomCli.Text & " " & TxtApeCli.Text & " - " & TxtEdaCli.Text 'NOMBRE, APELLIDO y EDAD
        FrmPagoMensual.DtpFdiPgs.Value = DateTime.Now 'FECHA DE INICIO DE MES
        FrmPagoMensual.TxtPrcPgs.Text = precio & " €"
        FrmPagoMensual.TxtDscPgs.Text = descto & " €"
        'FrmPagoMensual.nomUser = FrmPrincipal.nomUser 'USUARIO
        FrmPagoMensual.Show()
    End Sub

End Class