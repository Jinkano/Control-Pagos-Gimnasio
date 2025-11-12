Imports MySql.Data.MySqlClient

Public Class FrmPagoMensual

    Dim cnxnMySql As New MySqlConnection
    Dim drDataReader As MySqlDataReader
    Dim cmdCommand As MySqlCommand
    Dim sqlConsulta, nomUser As String
    Dim precio, dscto, total, prcDia As Decimal
    Public Shared psIdCli, psIdPgs As String
    Dim arrayMes() As String = {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"}
    '
    '
    '
    Private Sub FrmPagoMensual_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'COMPROBAMOS EL TÍTULO DE LA VENTANA PARA DESACTIVAR EL DtpFdi
        If Me.Text = "Pago de mensualidad" Then DtpFdiPgs.Enabled = False

        'SELECCIONA LA PRIMA OPCIÓN DEL COMBOBOX
        CmbFrmPgs.SelectedIndex = 0

        'VARIBLE PARA SABER EL USUARIO
        nomUser = FrmPrincipal.nomUser
    End Sub
    Private Sub FrmPagoMensual_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate

        '| ---------------------------------------------------------------------------------------
        '| CERRAMOS LA VENTANA AL DESACTIVAR EL FORMULARIO 
        '| ------------------------------------------------
        '| * Si se desactiva el Form o se hace clic fuera del Form cerramos el FrmPagoMensual para
        '|   evitar hacer otras acciones con el form ejecutado (no visible).
        Close()

    End Sub
    '
    '
    '
    Private Sub BtnPagar_Click(sender As Object, e As EventArgs) Handles BtnPagar.Click
        Try
            'CONECTAMOS Y ABRIMOS LA BBDD 
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()

            'DECLARAMOS VARIABLES PARA ALMACENAR EL MES Y EL AÑO DEL DtpFdi
            Dim fechaPago As DateTime = DtpFdiPgs.Value
            Dim dia = fechaPago.Day
            Dim mes = fechaPago.Month
            Dim ano = fechaPago.Year

            'COMPROBAMOS EL TÍTULO DE LA VENTANA
            If Me.Text = "Nuevo pago mensual" Then

                'HACEMOS LA CONSULTA PARA VER SI HAY ALGÚN REGISTRO CON LA MISMA FECHA
                sqlConsulta = "SELECT * FROM pagos WHERE MONTH(fdi_pgs) = '" & mes & "' AND YEAR(fdi_pgs) = ' " & ano & " ' AND id_cli = '" & psIdCli & "'"
                cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                drDataReader = cmdCommand.ExecuteReader

                'SI ENCUENTRA UN REGISTRO
                If drDataReader.HasRows = True Then
                    'MENSAJE PARA AVISAR QUE HAY UN REGISTRO CON LA MISMA FECHA
                    MsgBox("Estás intentando cobrar un mes que ya está registrado" & Chr(13) & Chr(13) &
                           "     FECHA : " & dia & " de " & arrayMes(mes - 1) & " de " & ano & Chr(13) & Chr(13) &
                           "Cambia la FECHA para realizar el pago.", vbCritical, "Verificar pagos")
                    'ENVIAMOS EL ENFOQUE AL DtpFdi
                    DtpFdiPgs.Focus()
                    'CERRAMOS EL DATAREADER y LA CONEXIÓN A LA BBDD
                    drDataReader.Close()
                    cnxnMySql.Close()
                    Exit Sub
                Else
                    'CERRAMOS EL DATAREADER 
                    drDataReader.Close()
                    'HACEMOS LA CONSULTA PARA INSERTA UN NUEVO REGISTRO A LA TABLA PAGOS
                    sqlConsulta = "INSERT INTO pagos (fdi_pgs, fdp_pgs, frm_pgs, prc_pgs, dsc_pgs, id_cli, usuario)
                              VALUES ('" & DtpFdiPgs.Value.ToString("yyyy-MM-dd") & "', '" & DtpFdpPgs.Value.ToString("yyyy-MM-dd") & "',
                              '" & CmbFrmPgs.Text & "', '" & Replace(precio, ",", ".") & "', '" & Replace(dscto, ",", ".") & "',
                              '" & psIdCli & "', '" & nomUser & "')"
                    cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                    drDataReader = cmdCommand.ExecuteReader
                    'MENSAJE PARA AVISAR QUE SE HA PAGADO
                    MsgBox("Se ha realizado un NUEVO pago del mes" & Chr(13) & Chr(13) &
                           "     FECHA : " & dia & " de " & arrayMes(mes - 1) & " de " & ano, vbInformation, "Nuevo pago")
                End If
            Else
                'HACEMOS LA CONSULTA PARA ACTUALIZAR EL REGISTRO DEL MES
                sqlConsulta = "UPDATE pagos SET fdi_pgs='" & DtpFdiPgs.Value.ToString("yyyy-MM-dd") & "', fdp_pgs='" & DtpFdpPgs.Value.ToString("yyyy-MM-dd") & "', 
                              frm_pgs='" & CmbFrmPgs.Text & "', prc_pgs='" & Replace(precio, ",", ".") & "', dsc_pgs='" & Replace(dscto, ",", ".") & "',
                              usuario ='" & nomUser & "' WHERE id_pgs='" & psIdPgs & "'"
                cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                drDataReader = cmdCommand.ExecuteReader
                'MENSAJE PARA AVISAR QUE SE HA PAGADO
                MsgBox("Se ha realizado el PAGO del mes" & Chr(13) & Chr(13) &
                           "     FECHA : " & dia & " de " & arrayMes(mes - 1) & " de " & ano, vbInformation, "Cobrar mes")
            End If

            'CERRAMOS EL DATAREADER y LA CONEXIÓN A LA BBDD
            drDataReader.Close()
            cnxnMySql.Close()

            'CERRAMOS LA VENTANA
            Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        'LIMPIAR LAS VARIBLES BANDERAS
        'FrmClientesPagos.txtFlags = ""
        'FrmHistorialPagos.txtFlags = ""

        Close() 'CERRAR FORM
    End Sub

    Private Sub DtpFdi_ValueChanged(sender As Object, e As EventArgs) Handles DtpFdiPgs.ValueChanged

        CalcPrecio() 'LLAMAR FUNCIÓN PARA CALCULAR EL PRECIO
    End Sub

    Private Sub TxtPrecio_GotFocus(sender As Object, e As EventArgs) Handles TxtPrcPgs.GotFocus

        TxtPrcPgs.SelectAll() 'SELECCIONA TODO EL TEXTO
    End Sub

    Private Sub TxtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrcPgs.KeyPress
        '
        If Char.IsDigit(e.KeyChar) Then e.Handled = False : Exit Sub
        If Char.IsControl(e.KeyChar) Then e.Handled = False : Exit Sub
        If e.KeyChar = "." AndAlso Not TxtPrcPgs.Text.Contains(",") Then e.Handled = False : Exit Sub
        e.Handled = True
    End Sub

    Private Sub TxtPrecio_TextChanged(sender As Object, e As EventArgs) Handles TxtPrcPgs.TextChanged
        '
        If TxtPrcPgs.Text = "" Then FuenteError() : Exit Sub
        '
        TxtPrcPgs.Text = Replace(TxtPrcPgs.Text, ".", ",")
        If Len(TxtPrcPgs.Text) = 1 Then TxtPrcPgs.Text = TxtPrcPgs.Text & " €" : TxtPrcPgs.SelectionStart = 1
        If Len(TxtPrcPgs.Text) = 2 Then TxtPrcPgs.Clear() : FuenteError()
        If Len(TxtPrcPgs.Text) >= 3 Then
            Dim largo = TxtPrcPgs.Text.Substring(0, Len(TxtPrcPgs.Text) - 2)
            TxtPrcPgs.Text = largo & " €"
            TxtPrcPgs.SelectionStart = Len(largo)
            If Len(largo) >= 1 Then precio = largo
        End If
        '
        If TxtDscPgs.Text = "" Then TxtDscPgs.Text = "0 €" : TxtDscPgs.ForeColor = Color.DarkOrange
        '
        If TxtPrcPgs.Text.Contains(",") Then
            Dim intDec() As String = TxtPrcPgs.Text.Split(",")
            If (intDec(0).Length = 0) OrElse (intDec(1).Length = 2 Or intDec(1).Length > 4) Or (precio < 30 Or precio > 90) Then
                TxtPrcPgs.ForeColor = Color.Red
                'LblPrcPgs.Font = New System.Drawing.Font(LblPrcPgs.Font, FontStyle.Bold)
                FuenteError()
            Else
                TxtPrcPgs.ForeColor = Color.Green
                'LblPrcPgs.Font = New System.Drawing.Font(LblPrcPgs.Font, LblPrcPgs.Font.Style And Not FontStyle.Bold)
                FuenteOk()
                CalcPrecio()
            End If
            '
        ElseIf (precio < 30 Or precio > 90) Then
            TxtPrcPgs.ForeColor = Color.Red
            'LblPrcPgs.Font = New System.Drawing.Font(LblPrcPgs.Font, FontStyle.Bold)
            FuenteError()
        Else
            TxtPrcPgs.ForeColor = Color.Green
            'LblPrcPgs.Font = New System.Drawing.Font(LblPrcPgs.Font, LblPrcPgs.Font.Style And Not FontStyle.Bold)
            FuenteOk()
            CalcPrecio()
        End If
    End Sub

    Private Sub TxtDscto_GotFocus(sender As Object, e As EventArgs) Handles TxtDscPgs.GotFocus

        TxtDscPgs.SelectAll() 'SELECCIONA TODO EL TEXTO
    End Sub

    Private Sub Panel_Paint(sender As Object, e As PaintEventArgs) Handles Panel.Paint

    End Sub

    Private Sub CmbMtdPgs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMtdPgs.SelectedIndexChanged

        '|
        '|

        Dim strDetail As String

        Select Case CmbMtdPgs.SelectedIndex
            Case 0 'BONO
                strDetail = "Cuota mensual +" & vbCrLf & "guantes +" & vbCrLf & "vendas"

            Case 1 'DIARIO
                strDetail = "Pago diario, " & TxtPrcPgs.Text & " por cada clase suelta."

            Case 2 'MENSAL
                strDetail = "Con descuento de " & TxtDscPgs.Text & " por edad."

            Case Else 'GRUPO FAMILIAR
                strDetail = "Jinkis" & vbCrLf & "Sarita" & vbCrLf & "Marjorie"

        End Select

        TxtDtlleMtdo.Text = strDetail

    End Sub

    Private Sub TxtDscto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDscPgs.KeyPress
        '
        If Char.IsDigit(e.KeyChar) Then e.Handled = False : Exit Sub
        If Char.IsControl(e.KeyChar) Then e.Handled = False : Exit Sub
        If e.KeyChar = "." AndAlso Not TxtDscPgs.Text.Contains(",") Then e.Handled = False : Exit Sub
        e.Handled = True
    End Sub

    Private Sub TxtDscto_TextChanged(sender As Object, e As EventArgs) Handles TxtDscPgs.TextChanged
        '
        TxtDscPgs.Text = Replace(TxtDscPgs.Text, ".", ",")
        If Len(TxtDscPgs.Text) = 1 Then TxtDscPgs.Text = TxtDscPgs.Text & " €" : TxtDscPgs.SelectionStart = 1
        If Len(TxtDscPgs.Text) = 2 Then TxtDscPgs.Clear() : FuenteError()
        If Len(TxtDscPgs.Text) >= 3 Then
            Dim largo = TxtDscPgs.Text.Substring(0, Len(TxtDscPgs.Text) - 2)
            TxtDscPgs.Text = largo & " €"
            TxtDscPgs.SelectionStart = Len(largo)
            If Len(largo) >= 1 Then dscto = largo
        End If
        '
        If TxtPrcPgs.Text = "" Then TxtPrcPgs.Text = "0 €"
        If TxtDscPgs.Text = "" Then FuenteError() : Exit Sub
        '
        If TxtDscPgs.Text.Contains(",") Then
            Dim intDec() As String = TxtDscPgs.Text.Split(",")
            If (intDec(0).Length = 0) OrElse (intDec(1).Length = 2 Or intDec(1).Length > 4) Or (dscto > 25) Then
                TxtDscPgs.ForeColor = Color.Red
                'LblDscPgs.Font = New System.Drawing.Font(LblDscPgs.Font, FontStyle.Bold)
                FuenteError()
            Else
                TxtDscPgs.ForeColor = Color.Green
                'LblDscPgs.Font = New System.Drawing.Font(LblDscPgs.Font, LblDscPgs.Font.Style And Not FontStyle.Bold)
                If dscto = 0 Then TxtDscPgs.ForeColor = Color.DarkOrange
                If TxtPrcPgs.Text = "0 €" Then FuenteError() : Exit Sub
                FuenteOk()
                CalcPrecio()
            End If
            '
        Else
            If (dscto > 20) Then
                TxtDscPgs.ForeColor = Color.Red
                'LblDscPgs.Font = New System.Drawing.Font(LblDscPgs.Font, FontStyle.Bold)
                FuenteError()
            Else
                TxtDscPgs.ForeColor = Color.Green
                'LblDscPgs.Font = New System.Drawing.Font(LblDscPgs.Font, LblDscPgs.Font.Style And Not FontStyle.Bold)
                If dscto = 0 Then TxtDscPgs.ForeColor = Color.DarkOrange
                If TxtPrcPgs.Text = "0 €" Then FuenteError() : Exit Sub
                FuenteOk()
                CalcPrecio()
            End If
        End If
    End Sub

    Sub FuenteError()
        '
        LblTtlPgs.Text = "ERROR"
        LblTtlPgs.ForeColor = Color.Red
        LblPrcDisPgs.Text = "ERROR"
        LblPrcDisPgs.ForeColor = Color.Red
        LblPagarPgs.Text = "ERROR"
        LblPagarPgs.ForeColor = Color.Red
        'LblTtlPgs.Font = New System.Drawing.Font(LblTtlPgs.Font, FontStyle.Bold)
        'LblPrcDisPgs.Font = New System.Drawing.Font(LblPrcDisPgs.Font, FontStyle.Bold)
        'LblPagarPgs.Font = New System.Drawing.Font(LblPagarPgs.Font, FontStyle.Bold)
    End Sub

    Sub FuenteOk()
        '
        LblTtlPgs.ForeColor = Color.Green
        LblPrcDisPgs.ForeColor = Color.Green
        LblPagarPgs.ForeColor = Color.Black
        'LblTtlPgs.Font = New System.Drawing.Font(LblPrcPgs.Font, LblTtlPgs.Font.Style And Not FontStyle.Bold)
        'LblPrcDisPgs.Font = New System.Drawing.Font(LblPrcDisPgs.Font, LblPrcPgs.Font.Style And Not FontStyle.Bold)
        'LblPagarPgs.Font = New System.Drawing.Font(LblPagarPgs.Font, LblPrcPgs.Font.Style And Not FontStyle.Bold)
    End Sub

    Sub CalcPrecio()
        '
        precio = TxtPrcPgs.Text.Substring(0, Len(TxtPrcPgs.Text) - 2)
        dscto = TxtDscPgs.Text.Substring(0, Len(TxtDscPgs.Text) - 2)
        total = precio - dscto
        LblTtlPgs.Text = FormatCurrency(total)
        Dim fecha As DateTime = DtpFdiPgs.Value
        Dim dia = fecha.Day
        Dim mes = fecha.Month
        Dim ano = fecha.Year
        Dim nDias = DateTime.DaysInMonth(fecha.Year, fecha.Month)
        prcDia = total / nDias
        nDias = nDias - dia + 1
        LblDiasPgs.Text = nDias
        LblPrcDisPgs.Text = FormatCurrency(prcDia)
        LblPagarPgs.Text = FormatCurrency(prcDia * nDias)
    End Sub

End Class