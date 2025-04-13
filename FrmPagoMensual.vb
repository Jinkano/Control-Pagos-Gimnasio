Imports MySql.Data.MySqlClient

Public Class FrmPagoMensual

    Dim cnxnMySql As New MySqlConnection
    Dim drDataReader As MySqlDataReader
    Dim cmdCommand As MySqlCommand
    Dim sqlConsulta As String
    Dim precio, dscto, total, prcDia As Decimal
    Public Shared psIdCli, psIdPgs As String

    Private Sub FrmPagoMensual_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CmbFdp.SelectedIndex = 0 'SELECCIONA LA PRIMA OPCIÓN DEL COMBOBOX
    End Sub

    Private Sub BtnPagar_Click(sender As Object, e As EventArgs) Handles BtnPagar.Click

        Try
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()

            If Me.Text = "Nuevo pago mensual" Then
                sqlConsulta = "INSERT INTO pagos (fdi_pgs, fdp_pgs, frm_pgs, prc_pgs, dsc_pgs, id_cli) VALUES 
                              ('" & DtpFdi.Value.ToString("yyyy-MM-dd") & "', '" & DtpFdp.Value.ToString("yyyy-MM-dd") & "',
                              '" & CmbFdp.Text & "', '" & Replace(precio, ",", ".") & "', '" & Replace(dscto, ",", ".") & "', '" & psIdCli & "')"
            Else
                sqlConsulta = "UPDATE pagos SET fdi_pgs='" & DtpFdi.Value.ToString("yyyy-MM-dd") & "', fdp_pgs='" & DtpFdp.Value.ToString("yyyy-MM-dd") & "', 
                              frm_pgs='" & CmbFdp.Text & "', prc_pgs='" & Replace(precio, ",", ".") & "', dsc_pgs='" & Replace(dscto, ",", ".") & "' 
                              WHERE id_pgs='" & psIdPgs & "'"
            End If
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader

            'MENSAJE DE CONFIRMACIÓN
            MsgBox("PAGO realizado con exito", vbInformation, "Pagos")

            drDataReader.Close() 'CERRAMOS EL DATAREADER

            cnxnMySql.Close() ' CERRAMOS LA CONEXIÓN A LA BBDD
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        'TENEMOS QUE MANDAR LA INFO A LA GRILA
        Close()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        'LIMPIAR LAS VARIBLES BANDERAS
        FrmClientesPagos.txtFlags = ""
        FrmHistorialPagos.txtFlags = ""

        Close() 'CERRAR FORM
    End Sub

    Private Sub DtpFdi_ValueChanged(sender As Object, e As EventArgs) Handles DtpFdi.ValueChanged

        CalcPrecio() 'LLAMAR FUNCIÓN PARA CALCULAR EL PRECIO
    End Sub

    Private Sub TxtPrecio_GotFocus(sender As Object, e As EventArgs) Handles TxtPrecio.GotFocus

        TxtPrecio.SelectAll() 'SELECCIONA TODO EL TEXTO
    End Sub

    Private Sub TxtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrecio.KeyPress
        '
        If Char.IsDigit(e.KeyChar) Then e.Handled = False : Exit Sub
        If Char.IsControl(e.KeyChar) Then e.Handled = False : Exit Sub
        If e.KeyChar = "." AndAlso Not TxtPrecio.Text.Contains(",") Then e.Handled = False : Exit Sub
        e.Handled = True
    End Sub

    Private Sub TxtPrecio_TextChanged(sender As Object, e As EventArgs) Handles TxtPrecio.TextChanged
        '
        If TxtPrecio.Text = "" Then FuenteError() : Exit Sub
        '
        TxtPrecio.Text = Replace(TxtPrecio.Text, ".", ",")
        If Len(TxtPrecio.Text) = 1 Then TxtPrecio.Text = TxtPrecio.Text & " €" : TxtPrecio.SelectionStart = 1
        If Len(TxtPrecio.Text) = 2 Then TxtPrecio.Clear() : FuenteError()
        If Len(TxtPrecio.Text) >= 3 Then
            Dim largo = TxtPrecio.Text.Substring(0, Len(TxtPrecio.Text) - 2)
            TxtPrecio.Text = largo & " €"
            TxtPrecio.SelectionStart = Len(largo)
            If Len(largo) >= 1 Then precio = largo
        End If
        '
        If TxtDscto.Text = "" Then TxtDscto.Text = "0 €" : TxtDscto.ForeColor = Color.DarkOrange
        '
        If TxtPrecio.Text.Contains(",") Then
            Dim intDec() As String = TxtPrecio.Text.Split(",")
            If (intDec(0).Length = 0) OrElse (intDec(1).Length = 2 Or intDec(1).Length > 4) Or (precio < 30 Or precio > 90) Then
                TxtPrecio.ForeColor = Color.Red
                TxtPrecio.Font = New System.Drawing.Font(TxtPrecio.Font, FontStyle.Bold)
                FuenteError()
            Else
                TxtPrecio.ForeColor = Color.Green
                TxtPrecio.Font = New System.Drawing.Font(TxtPrecio.Font, TxtPrecio.Font.Style And Not FontStyle.Bold)
                FuenteOk()
                CalcPrecio()
            End If
            '
        ElseIf (precio < 30 Or precio > 90) Then
            TxtPrecio.ForeColor = Color.Red
            TxtPrecio.Font = New System.Drawing.Font(TxtPrecio.Font, FontStyle.Bold)
            FuenteError()
        Else
            TxtPrecio.ForeColor = Color.Green
            TxtPrecio.Font = New System.Drawing.Font(TxtPrecio.Font, TxtPrecio.Font.Style And Not FontStyle.Bold)
            FuenteOk()
            CalcPrecio()
        End If
    End Sub

    Private Sub TxtDscto_GotFocus(sender As Object, e As EventArgs) Handles TxtDscto.GotFocus

        TxtDscto.SelectAll() 'SELECCIONA TODO EL TEXTO
    End Sub

    Private Sub TxtDscto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDscto.KeyPress
        '
        If Char.IsDigit(e.KeyChar) Then e.Handled = False : Exit Sub
        If Char.IsControl(e.KeyChar) Then e.Handled = False : Exit Sub
        If e.KeyChar = "." AndAlso Not TxtDscto.Text.Contains(",") Then e.Handled = False : Exit Sub
        e.Handled = True
    End Sub

    Private Sub TxtDscto_TextChanged(sender As Object, e As EventArgs) Handles TxtDscto.TextChanged
        '
        TxtDscto.Text = Replace(TxtDscto.Text, ".", ",")
        If Len(TxtDscto.Text) = 1 Then TxtDscto.Text = TxtDscto.Text & " €" : TxtDscto.SelectionStart = 1
        If Len(TxtDscto.Text) = 2 Then TxtDscto.Clear() : FuenteError()
        If Len(TxtDscto.Text) >= 3 Then
            Dim largo = TxtDscto.Text.Substring(0, Len(TxtDscto.Text) - 2)
            TxtDscto.Text = largo & " €"
            TxtDscto.SelectionStart = Len(largo)
            If Len(largo) >= 1 Then dscto = largo
        End If
        '
        If TxtPrecio.Text = "" Then TxtPrecio.Text = "0 €"
        If TxtDscto.Text = "" Then FuenteError() : Exit Sub
        '
        If TxtDscto.Text.Contains(",") Then
            Dim intDec() As String = TxtDscto.Text.Split(",")
            If (intDec(0).Length = 0) OrElse (intDec(1).Length = 2 Or intDec(1).Length > 4) Or (dscto > 25) Then
                TxtDscto.ForeColor = Color.Red
                TxtDscto.Font = New System.Drawing.Font(TxtDscto.Font, FontStyle.Bold)
                FuenteError()
            Else
                TxtDscto.ForeColor = Color.Green
                TxtDscto.Font = New System.Drawing.Font(TxtDscto.Font, TxtDscto.Font.Style And Not FontStyle.Bold)
                If dscto = 0 Then TxtDscto.ForeColor = Color.DarkOrange
                If TxtPrecio.Text = "0 €" Then FuenteError() : Exit Sub
                FuenteOk()
                CalcPrecio()
            End If
            '
        Else
            If (dscto > 20) Then
                TxtDscto.ForeColor = Color.Red
                TxtDscto.Font = New System.Drawing.Font(TxtDscto.Font, FontStyle.Bold)
                FuenteError()
            Else
                TxtDscto.ForeColor = Color.Green
                TxtDscto.Font = New System.Drawing.Font(TxtDscto.Font, TxtDscto.Font.Style And Not FontStyle.Bold)
                If dscto = 0 Then TxtDscto.ForeColor = Color.DarkOrange
                If TxtPrecio.Text = "0 €" Then FuenteError() : Exit Sub
                FuenteOk()
                CalcPrecio()
            End If
        End If
    End Sub

    Sub FuenteError()
        '
        TxtTotal.Text = "ERROR"
        TxtTotal.ForeColor = Color.Red
        TxtTotal.Font = New System.Drawing.Font(TxtTotal.Font, FontStyle.Bold)
        TxtPrcDia.Text = "ERROR"
        TxtPrcDia.ForeColor = Color.Red
        TxtPrcDia.Font = New System.Drawing.Font(TxtPrcDia.Font, FontStyle.Bold)
        TxtApagar.Text = "ERROR"
        TxtApagar.ForeColor = Color.Red
        TxtApagar.Font = New System.Drawing.Font(TxtApagar.Font, FontStyle.Bold)
    End Sub

    Sub FuenteOk()
        '
        TxtTotal.ForeColor = Color.Green
        TxtTotal.Font = New System.Drawing.Font(TxtPrecio.Font, TxtTotal.Font.Style And Not FontStyle.Bold)
        TxtPrcDia.ForeColor = Color.Green
        TxtPrcDia.Font = New System.Drawing.Font(TxtPrcDia.Font, TxtPrecio.Font.Style And Not FontStyle.Bold)
        TxtApagar.ForeColor = Color.Green
        TxtApagar.Font = New System.Drawing.Font(TxtApagar.Font, TxtPrecio.Font.Style And Not FontStyle.Bold)
    End Sub

    Sub CalcPrecio()
        '
        precio = TxtPrecio.Text.Substring(0, Len(TxtPrecio.Text) - 2)
        dscto = TxtDscto.Text.Substring(0, Len(TxtDscto.Text) - 2)
        total = precio - dscto
        TxtTotal.Text = FormatCurrency(total)
        Dim fecha As DateTime = DtpFdi.Value
        Dim dia = fecha.Day
        Dim mes = fecha.Month
        Dim ano = fecha.Year
        Dim nDias = DateTime.DaysInMonth(fecha.Year, fecha.Month)
        prcDia = total / nDias
        nDias = nDias - dia + 1
        TxtDias.Text = nDias
        TxtPrcDia.Text = FormatCurrency(prcDia)
        TxtApagar.Text = FormatCurrency(prcDia * nDias)
    End Sub
    '
End Class