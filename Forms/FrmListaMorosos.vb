Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Org.BouncyCastle.Crypto.Agreement

Public Class FrmListaMorosos
    '
    Dim sqlConsulta As String
    Public Shared cReg As Int16
    '
    Private Sub FrmPagoMensualidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'SELECCIONAR LA PRIMERA OPC. DEL COMBOBOX
        'Limpiamos el label usando la función String

        CmbFiltrar.SelectedIndex = 0

        Label.Text = String.Empty

    End Sub

    Private Sub FrmPagoMensualidad_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        'SELECT clientes.nom_cli, grp_familiar.nom_grp, pagos.fdi_pgs, pagos.prc_pgs,
        'pagos.dsc_pgs, pagos.id_pgs, grp_familiar.num_intgrntes_grp
        'FROM clientes
        'INNER Join grp_familiar ON clientes.id_grp = grp_familiar.id_grp
        'INNER Join pagos ON grp_familiar.id_grp = pagos.id_grp
        'WHERE pagos.fdp_pgs Is NULL
        'ORDER BY pagos.id_pgs

        'CONSULTA A LA BASE DE DATOS
        'sqlConsulta = "SELECT * FROM clientes INNER JOIN pagos ON clientes.id_cli = pagos.id_cli WHERE std_cli = 'ACTIVO' AND frm_pgs = '' ORDER BY id_pgs"
        sqlConsulta = "SELECT clientes.nom_cli, clientes.ape_cli, clientes.fdn_cli,
                        pagos.id_pgs, pagos.fdi_pgs, pagos.prc_pgs, pagos.dsc_pgs, pagos.id_cli
                        from clientes
                        INNER JOIN pagos ON clientes.id_cli = pagos.id_cli
                        WHERE clientes.std_cli = 'ACTIVO' AND pagos.frm_pgs = ''
                        ORDER BY pagos.id_pgs"

        'LLAMAR A LA FUNCIÓN ListaMorosos Y PASAR LA CONSULTA
        ListaMorosos(sqlConsulta, CmbFiltrar.SelectedIndex, DgvIndividual)

        sqlConsulta = "SELECT clientes.nom_cli, grp_familiar.nom_grp, pagos.fdi_pgs, pagos.prc_pgs,
                        pagos.dsc_pgs, pagos.id_pgs, grp_familiar.id_grp, grp_familiar.num_intgrntes_grp
                        FROM clientes
                        INNER Join grp_familiar ON clientes.id_grp = grp_familiar.id_grp
                        INNER Join pagos ON grp_familiar.id_grp = pagos.id_grp
                        WHERE pagos.fdp_pgs Is NULL
                        ORDER BY grp_familiar.id_grp"
        '
        Sub_Dgv_Family_Group(sqlConsulta, DgvFamilyGroup)

        'COMPROBAR REGISTROS PARA MOSTRAR TEXTO EN EL STATUS BAR
        If DgvIndividual.RowCount = 0 Then
            SlblTitulo.Text = "Lista vacia"
            SlblMensaje.Text = " No hay registros pendientes de pago."
        Else
            SlblTitulo.Text = "Nº de Registros"
            SlblMensaje.Text = " " & cReg & " - Registros pendientes de pago."
        End If

        DgvIndividual.CurrentCell = Nothing

    End Sub

    Private Sub CmbFiltrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbFiltrar.SelectedIndexChanged

        TxtBuscar.Focus() 'ENVIAR ENFOQUE AL TEXBOX

        If DgvIndividual.RowCount = 0 Then Exit Sub 'COMPROBAR SI HAY REGISTROS EN LA GRILLA

        'SELECCIONAMOS LA COLUMNA QUE VAMMOS A BUSCAR
        Select Case CmbFiltrar.SelectedIndex
            Case 0 'NOMBRE
                DgvIndividual.CurrentCell = DgvIndividual.Item(0, 1)

            Case 1 'APELLIDO
                DgvIndividual.CurrentCell = DgvIndividual.Item(1, 1)

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

        ''CONSULTAR LA BBDD SEGÚN LA OPC. DEL COMBOBOX
        'Select Case CmbFiltrar.SelectedIndex
        '    Case 0 'NOMBRE
        '        sqlConsulta = "SELECT * FROM clientes INNER JOIN pagos ON clientes.id_cli = pagos.id_cli 
        '                        WHERE nom_cli LIKE '" & TxtBuscar.Text & "%' AND std_cli = 'ACTIVO' AND frm_pgs = '' ORDER BY nom_cli"

        '    Case 1 'APELLIDO
        '        sqlConsulta = "SELECT * FROM clientes INNER JOIN pagos ON clientes.id_cli = pagos.id_cli 
        '                        WHERE ape_cli LIKE '" & TxtBuscar.Text & "%' AND std_cli = 'ACTIVO' AND frm_pgs = '' ORDER BY ape_cli"
        'End Select

        ''LLAMAR A LA FUNCIÓN ListaMorosos Y LE PASAMOS LA CONSULTA
        'ListaMorosos(sqlConsulta, CmbFiltrar.SelectedIndex, DgvMorosos)

        ''COMPROBAMOS EL TEXTBOX PARA MOSTRAR TEXTO EN EL STATUSBAR
        'If TxtBuscar.Text = "" Then
        '    SlblTitulo.Text = "Nº de Registros"
        '    SlblMensaje.Text = " " & cReg & " - Registros pendientes de pago. -987"
        'Else
        '    SlblTitulo.Text = "Buscando Cliente"
        '    SlblMensaje.Text = " " & cReg & " - Registro(s) que coincide(n) con su búsqueda. -564"
        'End If
        'If TxtBuscar.Text = "" And DgvMorosos.RowCount = 0 Then SlblTitulo.Text = "Lista vacia"

        Dim textoBusqueda As String = TxtBuscar.Text.Trim()

        ' Obtener la fuente de datos (el BindingSource)
        Dim bs As BindingSource = TryCast(DgvIndividual.DataSource, BindingSource)

        If bs IsNot Nothing Then

            If String.IsNullOrWhiteSpace(textoBusqueda) Then
                ' Si la caja de texto está vacía, mostrar todas las filas
                bs.Filter = String.Empty
            Else
                ' Aplicar el filtro a la vista de datos
                ' Sintaxis: "NombreColumna LIKE '%Texto%'"
                ' La función CONVERT lo convierte a String para asegurar la comparación.

                'Dim filtro As String = $"CONVERT(Nombre, 'System.String') LIKE '%{textoBusqueda}%'"

                ' O si quieres buscar en varias columnas (usando OR)
                Dim filtro As String = $"nom_cli LIKE '%{textoBusqueda}%' OR ape_cli LIKE '%{textoBusqueda}%'"

                ' Asignar el filtro
                bs.Filter = filtro
            End If

        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        '
        TxtBuscar.Clear()
        TxtBuscar.Focus()
    End Sub

    Private Sub BtnPagar_Click(sender As Object, e As EventArgs) Handles BtnPagar.Click

        '|

        If DgvIndividual.SelectedRows.Count = 0 Then

            ' Muestra el mensaje de advertencia
            MessageBox.Show("Debe seleccionar al menos una fila (un registro) para continuar.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning) ' Usa el icono de advertencia para claridad

            'Exit Sub ' Detiene la ejecución del resto de la subrutina
        Else

            'ENVIAR DATOS AL FORM FrmPagoMensual
            FrmPagoMensual.strIdPgs = DgvIndividual.CurrentRow.Cells(10).Value.ToString ' ID_PAGO
            FrmPagoMensual.LblCliente.Text = DgvIndividual.CurrentRow.Cells(12).Value.ToString 'NOMBRE, APELLIDO y EDAD
            FrmPagoMensual.DtpFdiPgs.Value = DgvIndividual.CurrentRow.Cells(11).Value.ToString 'FECHA DE INICIO DE MES
            FrmPagoMensual.TxtPrcPgs.Text = DgvIndividual.CurrentRow.Cells(4).Value.ToString 'PRECIO
            FrmPagoMensual.TxtDscPgs.Text = DgvIndividual.CurrentRow.Cells(5).Value.ToString 'DESCUENTO
            FrmPagoMensual.MdiParent = FrmPrincipal
            FrmPagoMensual.Show()

        End If


    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        'CERRAR FORM
        Close()
    End Sub

    Private Sub DgvIndividual_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvIndividual.CellContentClick
    End Sub
    Private Sub DgvIndividual_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvIndividual.CellClick

        '|
        '|
        '|

        ' 

        'If String.IsNullOrEmpty(DgvMorosos.CurrentRow.Cells(4).Value) Then

        '    DgvMorosos.CurrentCell = Nothing
        '    ErrorProvider.Clear()
        '    ErrorProvider.SetError(Label, "Selecciona una fila que contenga un PAGO.")

        'Else

        '    ErrorProvider.Clear()

        'End If

    End Sub

    Private Sub DgvIndividual_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvIndividual.CellFormatting

        '
        '

        If e.RowIndex >= 0 Then

            ' 1. Acceder a la celda específica que queremos verificar
            Dim checkCell As DataGridViewCell = DgvIndividual.Rows(e.RowIndex).Cells(4)
            Dim cellValue As String = String.Empty

            ' Comprobación segura de valor
            If checkCell.Value IsNot Nothing AndAlso Not DBNull.Value.Equals(checkCell.Value) Then
                cellValue = checkCell.Value.ToString()
            End If

            ' 2. Lógica de Comprobación
            If String.IsNullOrWhiteSpace(cellValue) Then
                ' Si está vacía, asigna el ToolTip de ADVERTENCIA a TODAS las celdas de esa fila
                ' *Nota: Esto asigna el mensaje a TODAS las celdas de la fila en este evento*
                DgvIndividual.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = "Selecciona una fila que contenga un PAGO."

            Else
                ' Limpia el ToolTip si no cumple ninguna condición
                DgvIndividual.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = String.Empty
            End If

        End If
    End Sub


    'Private Sub LViewMorosos_MouseClick(sender As Object, e As MouseEventArgs)
    '    ' 1. Verificar si realmente se hizo clic en un ítem (y no en un espacio vacío)
    '    Dim itemClickeado As ListViewItem = LViewMorosos.GetItemAt(e.X, e.Y)

    '    If itemClickeado Is Nothing Then
    '        ' No se hizo clic en un elemento. No hacemos nada.
    '        Exit Sub
    '    End If

    '    ' 2. Obtener el valor del SubItem que contiene el dato clave (Columna 5, Índice 4)
    '    ' Los SubItems comienzan a contar después del Item principal (índice 0).
    '    Const INDICE_SUBITEM_CLAVE As Integer = 4 ' Corresponde a la Columna 5 ("MES-AÑO")

    '    Dim valorClave As String = String.Empty

    '    ' Asegurarse de que el SubItem exista antes de intentar leerlo
    '    If itemClickeado.SubItems.Count > INDICE_SUBITEM_CLAVE Then
    '        valorClave = itemClickeado.SubItems(INDICE_SUBITEM_CLAVE).Text
    '    End If

    '    ' 3. Realizar la Validación
    '    If String.IsNullOrEmpty(valorClave) Then

    '        ' La fila es de Resumen/Separador (no tiene MES-AÑO)

    '        ' Deseleccionar la fila (similar a DgvMorosos.CurrentCell = Nothing)
    '        ' Esto evita que la fila de resumen quede resaltada
    '        itemClickeado.Selected = False

    '        MsgBox("Selecciona una fila que contenga un PAGO.")

    '    Else

    '        ' La fila es válida y contiene datos de pago
    '        ' EJECUTAMOS LA OTRA PARTE DEL CÓDIGO

    '    End If
    'End Sub

    Private Sub RbPayIndividual_CheckedChanged(sender As Object, e As EventArgs) Handles RbPayIndividual.CheckedChanged

        If RbPayIndividual.Checked = True Then
            'CONSULTA
            'CreateColumnsDgv(DgvIndividual)

            'PONER ENCIMA
            RbPayIndividual.BringToFront()

            'limpiar
            CmbFiltrar.Items.Clear()
            '' Añadir nuevos valores
            CmbFiltrar.Items.Add("   NOMBRE")
            CmbFiltrar.Items.Add("   APELLIDO")

        Else

            'CONSULTA
            'CreateColumnsDgv(DgvFamilyGroup)

            'PONER ENCIMA
            RbPayGroup.BringToFront()

            'limpiar
            CmbFiltrar.Items.Clear()
            '' Añadir nuevos valores
            CmbFiltrar.Items.Add("   INTEGRANTES")
            CmbFiltrar.Items.Add("   GRUPO")

        End If


    End Sub
End Class