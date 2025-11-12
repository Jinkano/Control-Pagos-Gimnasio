Public Class FrmListaMorosos
    '
    Dim sqlConsulta As String
    Public Shared cReg As Int16
    '
    Private Sub FrmPagoMensualidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SELECCIONAR LA PRIMERA OPC. DEL COMBOBOX
        CmbFiltrar.SelectedIndex = 0
    End Sub

    Private Sub FrmPagoMensualidad_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        'CONSULTA A LA BASE DE DATOS
        sqlConsulta = "SELECT * FROM clientes INNER JOIN pagos ON clientes.id_cli = pagos.id_cli WHERE std_cli = 'ACTIVO' AND frm_pgs = '' ORDER BY nom_cli"

        'LLAMAR A LA FUNCIÓN ListaMorosos Y PASAR LA CONSULTA
        ListaMorosos(sqlConsulta, CmbFiltrar.Text, DgvMorosos)

        'COMPROBAR REGISTROS PARA MOSTRAR TEXTO EN EL STATUS BAR
        If DgvMorosos.RowCount = 0 Then
            SlblTitulo.Text = "Lista vacia"
            SlblMensaje.Text = " No hay registros pendientes de pago."
        Else
            SlblTitulo.Text = "Nº de Registros"
            SlblMensaje.Text = " " & cReg & " - Registros pendientes de pago."
        End If

        DgvMorosos.CurrentCell = Nothing

    End Sub

    Private Sub CmbFiltrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbFiltrar.SelectedIndexChanged

        TxtBuscar.Focus() 'ENVIAR ENFOQUE AL TEXBOX

        If DgvMorosos.RowCount = 0 Then Exit Sub 'COMPROBAR SI HAY REGISTROS EN LA GRILLA

        'SELECCIONAMOS LA COLUMNA QUE VAMMOS A BUSCAR
        Select Case CmbFiltrar.Text
            Case "Nombre"
                DgvMorosos.CurrentCell = DgvMorosos.Item(0, 0)

            Case "Apellido"
                DgvMorosos.CurrentCell = DgvMorosos.Item(1, 0)

        End Select
    End Sub

    Private Sub TxtBuscar_GotFocus(sender As Object, e As EventArgs) Handles TxtBuscar.GotFocus

        If TxtBuscar.TextLength = 0 Then Exit Sub
        TxtBuscar.SelectAll()
        TxtBuscar.Cut()
        TxtBuscar.Paste()
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged

        ''COMRPOBACIONES AL MOMENTO DE BUSCAR UN CLIENTE
        'If TxtBuscarCliente.Text.Contains("'") Then DgvMorosos.Rows.Clear() : SlblMensaje.Text = " 0 - Registro(s) que coincide(n) con su búsqueda." : Exit Sub
        'If TxtBuscarCliente.Text.Contains("º") Then DgvMorosos.Rows.Clear() : SlblMensaje.Text = " 0 - Registro(s) que coincide(n) con su búsqueda." : Exit Sub
        'If TxtBuscarCliente.Text.Contains("ª") Then DgvMorosos.Rows.Clear() : SlblMensaje.Text = " 0 - Registro(s) que coincide(n) con su búsqueda." : Exit Sub
        'If TxtBuscarCliente.Text.Contains("ç") Then DgvMorosos.Rows.Clear() : SlblMensaje.Text = " 0 - Registro(s) que coincide(n) con su búsqueda." : Exit Sub
        'If TxtBuscarCliente.Text.Contains("Ç") Then DgvMorosos.Rows.Clear() : SlblMensaje.Text = " 0 - Registro(s) que coincide(n) con su búsqueda." : Exit Sub
        'If TxtBuscarCliente.Text.Contains("%") Then DgvMorosos.Rows.Clear() : SlblMensaje.Text = " 0 - Registro(s) que coincide(n) con su búsqueda." : Exit Sub
        'If TxtBuscarCliente.Text.Contains("_") Then DgvMorosos.Rows.Clear() : SlblMensaje.Text = " 0 - Registro(s) que coincide(n) con su búsqueda." : Exit Sub

        'CONSULTAR LA BBDD SEGÚN LA OPC. DEL COMBOBOX
        Select Case CmbFiltrar.Text
            Case "Nombre"
                sqlConsulta = "SELECT * FROM clientes INNER JOIN pagos ON clientes.id_cli = pagos.id_cli 
                                WHERE nom_cli LIKE '" & TxtBuscar.Text & "%' AND std_cli = 'ACTIVO' AND frm_pgs = '' ORDER BY nom_cli"

            Case "Apellido"
                sqlConsulta = "SELECT * FROM clientes INNER JOIN pagos ON clientes.id_cli = pagos.id_cli 
                                WHERE ape_cli LIKE '" & TxtBuscar.Text & "%' AND std_cli = 'ACTIVO' AND frm_pgs = '' ORDER BY nom_cli"
        End Select

        'LLAMAR A LA FUNCIÓN ListaMorosos Y LE PASAMOS LA CONSULTA
        ListaMorosos(sqlConsulta, CmbFiltrar.Text, DgvMorosos)

        'COMPROBAMOS EL TEXTBOX PARA MOSTRAR TEXTO EN EL STATUSBAR
        If TxtBuscar.Text = "" Then
            SlblTitulo.Text = "Nº de Registros"
            SlblMensaje.Text = " " & cReg & " - Registros pendientes de pago."
        Else
            SlblTitulo.Text = "Buscando Cliente"
            SlblMensaje.Text = " " & cReg & " - Registro(s) que coincide(n) con su búsqueda."
        End If
        If TxtBuscar.Text = "" And DgvMorosos.RowCount = 0 Then SlblTitulo.Text = "Lista vacia"
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        '
        TxtBuscar.Clear()
        TxtBuscar.Focus()
    End Sub

    Private Sub BtnPagar_Click(sender As Object, e As EventArgs) Handles BtnPagar.Click

        'COMPROBAR SI HAY REGISTROS EN LA GRILLA
        If DgvMorosos.RowCount = 0 Then Exit Sub

        'ENVIAR DATOS AL FORM FrmPagoMensual
        FrmPagoMensual.psIdPgs = DgvMorosos.CurrentRow.Cells(10).Value.ToString ' ID_PAGO
        FrmPagoMensual.LblCliente.Text = DgvMorosos.CurrentRow.Cells(12).Value.ToString 'NOMBRE, APELLIDO y EDAD
        FrmPagoMensual.DtpFdiPgs.Value = DgvMorosos.CurrentRow.Cells(11).Value.ToString 'FECHA DE INICIO DE MES
        FrmPagoMensual.TxtPrcPgs.Text = DgvMorosos.CurrentRow.Cells(4).Value.ToString 'PRECIO
        FrmPagoMensual.TxtDscPgs.Text = DgvMorosos.CurrentRow.Cells(5).Value.ToString 'DESCUENTO
        FrmPagoMensual.MdiParent = FrmPrincipal
        FrmPagoMensual.Show()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        'CERRAR FORM
        Close()
    End Sub

End Class