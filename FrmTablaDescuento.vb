Imports MySql.Data.MySqlClient

Public Class FrmTablaDescuento

    Dim cnxnMySql As New MySqlConnection
    Dim drDataReader As MySqlDataReader
    Dim cmdCommand As MySqlCommand
    Dim sqlConsulta As String
    Dim nRow, idTarifa As Int16
    Dim precio, dscnto As Decimal

    Private Sub FrmTablaDescuentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LlenarDgvTarifas() 'LLENAR GRILLA CON LAS TARIFAS

        BtnGuarActuCancElim() 'LLAMA FUNCIÓN ACTIVAR/DESACTIVAR BOTONES
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        BtnNuevoModificar() 'LLAMA FUNCIÓN ACTIVAR/DESACTIVAR BOTONES

        'ACTIVAR Y DESACTIVAR BOTONES
        BtnGuardar.Visible = True
        BtnActualizar.Visible = False

        LimpiarCuadros() 'LLAMA FUNCION LIMPIAR TEXTOS
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        If idTarifa = 0 Then MsgBox("marca") : Exit Sub 'COMPROBAR SI HAY REGISTRO SELECCIONADO

        BtnNuevoModificar() 'LLAMA FUNCIÓN ACTIVAR/DESACTIVAR BOTONES

        'ACTIVAR Y DESACTIVAR BOTONES
        BtnGuardar.Visible = False
        BtnActualizar.Visible = True
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        If idTarifa = 0 Then MsgBox("marca") : Exit Sub 'COMPROBAR SI HAY REGISTRO SELECCIONADO

        'HACER CONSULTA A LA BBDD Y PASAR A LA FUNCION
        sqlConsulta = "DELETE FROM tarifas WHERE id_tarifa  = '" & idTarifa & "'"
        Consultas(sqlConsulta)

        LlenarDgvTarifas() 'LLENAR GRILLA CON LAS TARIFAS

        BtnGuarActuCancElim() 'LLAMAR FUNCION ACTIVAR/DESACTIVAR BOTONES

        LimpiarCuadros() 'LLAMA FUNCION LIMPIAR TEXTOS

        MsgBox("delete - OK") 'MENSAJE DE INFORMACIÓN
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        'COMPROBAR SI HAY INFORMACION EN LOS CUADROS
        If TxtPrecio.Text = "" Then MsgBox("Ingrese el PRECIO.", vbCritical, "Precios y Descuentos") : TxtPrecio.Focus() : Exit Sub
        Dim gcPrecio = TxtPrecio.Text.Substring(0, Len(TxtPrecio.Text) - 2)
        If TxtPrecio.Text = "0 €" Or (gcPrecio < 1 Or gcPrecio > 100) Then MsgBox("Corrige el PRECIO.", vbCritical, "Precios y Descuentos") : TxtPrecio.Focus() : Exit Sub
        If TxtDscnto.Text = "" Then MsgBox("Ingresa el DESCUENTO.", vbCritical, "Precios y Descuentos") : TxtDscnto.Focus() : Exit Sub
        Dim gcDscnto = TxtDscnto.Text.Substring(0, Len(TxtDscnto.Text) - 2)
        If gcDscnto > gcPrecio / 2 Then MsgBox("Corrige el DESCUENTO.", vbCritical, "Precios y Descuentos") : TxtDscnto.Focus() : Exit Sub
        If NudEdadMin.Value < 6 Then MsgBox("Corrige la edad MÍNIMA.", vbCritical, "Precios y Descuentos") : NudEdadMin.Focus() : Exit Sub
        If NudEdadMax.Value < 7 Then MsgBox("Corrige la edad MÁXIMA.", vbCritical, "Precios y Descuentos") : NudEdadMax.Focus() : Exit Sub

        'HACER CONSULTA A LA BBDD Y PASAR A LA FUNCION
        sqlConsulta = "INSERT INTO tarifas (precio, e_min, e_max, dscto) VALUES
                        ('" & precio & "', '" & NudEdadMin.Value & "', '" & NudEdadMax.Value & "', '" & dscnto & "')"
        Consultas(sqlConsulta)

        LlenarDgvTarifas() 'LLENAR GRILLA CON LAS TARIFAS

        BtnGuarActuCancElim() 'LLAMAR FUNCION ACTIVAR/DESACTIVAR BOTONES

        MsgBox("SAVE - OK") 'MENSAJE DE INFORMACIÓN
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        'COMPROBAR SI HAY INFORMACION EN LOS CUADROS
        If TxtPrecio.Text = "" Or TxtPrecio.Text = "0 €" Then MsgBox("Ingrese el PRECIO.", vbCritical, "Precios y Descuentos") : TxtPrecio.Focus() : Exit Sub
        If TxtDscnto.Text = "" Then MsgBox("Ingresa el DESCUENTO.", vbCritical, "Precios y Descuentos") : TxtDscnto.Focus() : Exit Sub
        If NudEdadMin.Value < 6 Then MsgBox("Corrige la EDAD mínima.", vbCritical, "Precios y Descuentos") : NudEdadMin.Focus() : Exit Sub
        If NudEdadMax.Value < 7 Then MsgBox("Corrige la EDAD máxima.", vbCritical, "Precios y Descuentos") : NudEdadMax.Focus() : Exit Sub

        'HACER CONSULTA A LA BBDD Y PASAR A LA FUNCION
        sqlConsulta = "UPDATE tarifas SET precio='" & precio & "', e_min='" & NudEdadMin.Value & "',
                        e_max='" & NudEdadMax.Value & "', dscto='" & dscnto & "' WHERE id_tarifa='" & idTarifa & "'"
        Consultas(sqlConsulta)

        LlenarDgvTarifas() 'LLENAR GRILLA CON LAS TARIFAS

        BtnGuarActuCancElim() ' LLAMAR FUNCION ACTIVAR/DESACTIVAR BOTONES
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        BtnGuarActuCancElim() ' LLAMAR FUNCION ACTIVAR/DESACTIVAR BOTONES

        LimpiarCuadros() 'LLAMA FUNCION LIMPIAR TEXTOS
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub

    Private Sub TxtPrecio_GotFocus(sender As Object, e As EventArgs) Handles TxtPrecio.GotFocus
        TxtPrecio.SelectAll()
    End Sub

    Private Sub TxtPrecio_LostFocus(sender As Object, e As EventArgs) Handles TxtPrecio.LostFocus

        If TxtPrecio.Text = "" Then TxtPrecio.Text = "0"
    End Sub

    Private Sub TxtPrecio_TextChanged(sender As Object, e As EventArgs) Handles TxtPrecio.TextChanged

        'Dim precio As Decimal 'VARIABLE PARA ALMACENAR EL PRECIO

        TxtPrecio.Text = Replace(TxtPrecio.Text, ".", ",") 'REEMPLAZAR EL PUNTO POR LA COMA

        'COMPROBAR EL LARGO DEL TEXTBOX
        If Len(TxtPrecio.Text) = 1 Then TxtPrecio.Text = TxtPrecio.Text & " €" : TxtPrecio.SelectionStart = 1
        If Len(TxtPrecio.Text) = 2 Then TxtPrecio.Clear()
        If Len(TxtPrecio.Text) >= 3 Then
            Dim largo = TxtPrecio.Text.Substring(0, Len(TxtPrecio.Text) - 2)
            TxtPrecio.Text = largo & " €"
            TxtPrecio.SelectionStart = Len(largo)
            If Len(largo) >= 1 Then precio = largo
        End If

        'COMPROBAR SI EL TEXTBOX CONTIENE LA COMA
        If TxtPrecio.Text.Contains(",") Then
            Dim intDec() As String = TxtPrecio.Text.Split(",")
            If (intDec(0).Length = 0) OrElse (intDec(1).Length = 2 Or intDec(1).Length > 4) Or (precio < 20 Or precio > 90) Then
                TxtPrecio.ForeColor = Color.Red
                TxtPrecio.Font = New System.Drawing.Font(TxtPrecio.Font, FontStyle.Bold)
            Else
                TxtPrecio.ForeColor = Color.Green
                TxtPrecio.Font = New System.Drawing.Font(TxtPrecio.Font, TxtPrecio.Font.Style And Not FontStyle.Bold)
            End If
            '
        ElseIf (precio < 20 Or precio > 90) Then
            TxtPrecio.ForeColor = Color.Red
            TxtPrecio.Font = New System.Drawing.Font(TxtPrecio.Font, FontStyle.Bold)
        Else
            TxtPrecio.ForeColor = Color.Green
            TxtPrecio.Font = New System.Drawing.Font(TxtPrecio.Font, TxtPrecio.Font.Style And Not FontStyle.Bold)
        End If
    End Sub

    Private Sub NudEdadMin_GotFocus(sender As Object, e As EventArgs) Handles NudEdadMin.GotFocus
        'NudEdadMin.Select(0, NudEdadMin.Value)
    End Sub

    Private Sub NudEdadMax_GotFocus(sender As Object, e As EventArgs) Handles NudEdadMax.GotFocus
        'NudEdadMax.Select()
    End Sub

    Private Sub TxtDscnto_GotFocus(sender As Object, e As EventArgs) Handles TxtDscnto.GotFocus
        TxtDscnto.SelectAll()
    End Sub

    Private Sub TxtDscnto_LostFocus(sender As Object, e As EventArgs) Handles TxtDscnto.LostFocus

        If TxtDscnto.Text = "" Then TxtDscnto.Text = "0"
    End Sub

    Private Sub TxtDscnto_TextChanged(sender As Object, e As EventArgs) Handles TxtDscnto.TextChanged

        TxtDscnto.Text = Replace(TxtDscnto.Text, ".", ",") 'REEMPLAZAR EL PUNTO POR LA COMA

        'COMPROBAR EL LARGO DEL TEXTBOX
        If Len(TxtDscnto.Text) = 1 Then TxtDscnto.Text = TxtDscnto.Text & " €" : TxtDscnto.SelectionStart = 1
        If Len(TxtDscnto.Text) = 2 Then TxtDscnto.Clear()
        If Len(TxtDscnto.Text) >= 3 Then
            Dim largo = TxtDscnto.Text.Substring(0, Len(TxtDscnto.Text) - 2)
            TxtDscnto.Text = largo & " €"
            TxtDscnto.SelectionStart = Len(largo)
            If Len(largo) >= 1 Then dscnto = largo
        End If

        'COMPROBAR SI EL TEXTBOX CONTIENE LA COMA
        If TxtDscnto.Text.Contains(",") Then
            Dim intDec() As String = TxtDscnto.Text.Split(",")
            If (intDec(0).Length = 0) OrElse (intDec(1).Length = 2 Or intDec(1).Length > 4) Or (dscnto < 0 Or dscnto > 50) Then
                TxtDscnto.ForeColor = Color.Red
                TxtDscnto.Font = New System.Drawing.Font(TxtDscnto.Font, FontStyle.Bold)
            Else
                TxtDscnto.ForeColor = Color.Green
                TxtDscnto.Font = New System.Drawing.Font(TxtDscnto.Font, TxtDscnto.Font.Style And Not FontStyle.Bold)
            End If

        ElseIf (dscnto < 0 Or dscnto > 50) Then
            TxtDscnto.ForeColor = Color.Red
            TxtDscnto.Font = New System.Drawing.Font(TxtDscnto.Font, FontStyle.Bold)
        Else
            TxtDscnto.ForeColor = Color.Green
            TxtDscnto.Font = New System.Drawing.Font(TxtDscnto.Font, TxtDscnto.Font.Style And Not FontStyle.Bold)
        End If
    End Sub

    Private Sub DgvTarifas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTarifas.CellClick

        idTarifa = DgvTarifas.CurrentRow.Cells(0).Value  'LLENAR VARIABLE CON ID TARIFA
        TxtPrecio.Text = DgvTarifas.CurrentRow.Cells(1).Value & " €" 'PRECIO
        NudEdadMin.Value = DgvTarifas.CurrentRow.Cells(2).Value 'EDAD MINIMA
        NudEdadMax.Value = DgvTarifas.CurrentRow.Cells(3).Value 'EDAD MAXIMA
        TxtDscnto.Text = DgvTarifas.CurrentRow.Cells(4).Value & " €" 'DESCUENTO

    End Sub


    '----->>>>> PROCEDIMIENTOS <<<<<-----'
    Sub BtnNuevoModificar()

        BtnNuevo.Visible = False
        BtnModificar.Visible = False
        BtnCancelar.Visible = True
        BtnEliminar.Visible = False

        GbPrecio.Enabled = True
        GbIntervaloEdad.Enabled = True
        GbDscto.Enabled = True

        DgvTarifas.Enabled = False

        TxtPrecio.Focus()
    End Sub

    Sub BtnGuarActuCancElim()

        BtnNuevo.Visible = True
        BtnGuardar.Visible = False
        BtnActualizar.Visible = False
        BtnModificar.Visible = True
        BtnCancelar.Visible = False
        BtnEliminar.Visible = True

        If DgvTarifas.RowCount = 0 Then
            BtnModificar.Visible = False
            BtnEliminar.Visible = False

            DgvTarifas.Enabled = False
        Else
            BtnModificar.Visible = True
            BtnEliminar.Visible = True

            DgvTarifas.Enabled = True
        End If

        GbPrecio.Enabled = False
        GbIntervaloEdad.Enabled = False
        GbDscto.Enabled = False

        idTarifa = 0 'LIMPIAR VARIABLE

        BtnNuevo.Focus()
    End Sub

    Sub LimpiarCuadros()
        TxtPrecio.Text = ""
        NudEdadMin.Value = 0
        NudEdadMax.Value = 0
        TxtDscnto.Text = ""
    End Sub
    Sub LlenarDgvTarifas()
        Try
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()
            sqlConsulta = "SELECT * FROM tarifas ORDER BY e_min"
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()
            DgvTarifas.Rows.Clear()
            If drDataReader.HasRows Then
                While drDataReader.Read()
                    nRow = DgvTarifas.Rows.Add()
                    DgvTarifas.Rows(nRow).Cells(0).Value = drDataReader.GetInt16(0).ToString 'ID TARIFA
                    DgvTarifas.Rows(nRow).Cells(1).Value = drDataReader.GetDecimal(1).ToString 'PRECIO
                    DgvTarifas.Rows(nRow).Cells(2).Value = drDataReader.GetInt16(2).ToString 'EDAD MINIMA
                    DgvTarifas.Rows(nRow).Cells(3).Value = drDataReader.GetInt16(3).ToString 'EDAD MAXIMA
                    DgvTarifas.Rows(nRow).Cells(4).Value = drDataReader.GetDecimal(4).ToString 'DESCUENTO
                End While
            End If

            drDataReader.Close()
            cnxnMySql.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub Consultas(ByVal sqlConsulta As String)
        Try
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()
            drDataReader.Close()
            cnxnMySql.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class