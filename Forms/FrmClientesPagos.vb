Public Class FrmClientesPagos

    Dim sqlConsulta, strState, strFilter, strFlags As String

    Public strIdClient As String
    '
    '
    '
    Private Sub FrmClientesPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '----------------------------------------------------------------------------------------
        '| COMPROBAMOS SI HAY REGISTROS EN LA TABLA CLIENTES
        '| -------------------------------------------------
        '| * Llamamos a la función FunCheckRecords() para comprobar si hay registros.
        '| ** El motivo porqué llamamos a la función en Activated y no Load, es para comprobar
        '| 

        sqlConsulta = "SELECT id_cli FROM clientes"
        Sub_Crud_Sql(sqlConsulta, "SubCheckRecords")
        '| * Llamamos a la subrutina Sub_Disable_Buttons() para desactivar los botones.

        Sub_Disable_Buttons()
        '| * Llamamos a la función CleanLabel() para limpiar los label's.
        Sub_Clean_Label()

    End Sub
    Private Sub FrmClientesPagos_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        '----------------------------------------------------------------------------------------
        '| COMPROBAMOS SI HAY REGISTROS EN LA TABLA CLIENTES
        '| -------------------------------------------------

        'MsgBox("FrmClientesPagos_Activated")
    End Sub
    '
    '
    '
    Private Sub CmbFiltrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbFiltrar.SelectedIndexChanged

        '|
        '|
        '|

        Select Case CmbFiltrar.SelectedIndex
            Case 1
                strFilter = "NAME"
                If DgvClientes.RowCount > 0 Then DgvClientes.CurrentCell = DgvClientes.Item(1, 0)

            Case 2
                strFilter = "LASTNAME"
                If DgvClientes.RowCount > 0 Then DgvClientes.CurrentCell = DgvClientes.Item(2, 0)

            Case 3
                strFilter = "PHONE"
                If DgvClientes.RowCount > 0 Then DgvClientes.CurrentCell = DgvClientes.Item(6, 0)

            Case Else
                strFilter = ""
        End Select

        'LIMPIAMOS EL TxtBuscar PARA LA BUSQUEDA Y ENVIAMOS EL ENFOQUE
        TxtBuscar.Clear()
        TxtBuscar.Focus()
    End Sub
    '
    '
    '
    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged

        '| Comprobamos si la variable strFlags es igual a "SKIP_SEARCH" para salir de la función con Exit Sub.
        '| Seleccionamos un caso según el valor de la variable strFilter:
        '|  * Hacemos la consulta y lo almacenamos en la variable sqlConsulta.
        '|  * Si la variable strFilter es nulo o vacio mostramos un mensaje de error y mandamos el enfoque al _
        '|    _ CmbFiltrar para seleccionar un filtro.
        '| Llamamos a la función LlenarListaClientes y le pasamos los parámetros.

        If strFlags = "SKIP_SEARCH" Then Exit Sub

        Select Case strFilter
            Case "NAME"
                sqlConsulta = "SELECT * FROM clientes WHERE nom_cli LIKE '" & TxtBuscar.Text & "%' AND std_cli = '" & strState & "' ORDER BY nom_cli"

            Case "LASTNAME"
                sqlConsulta = "SELECT * FROM clientes WHERE ape_cli LIKE '" & TxtBuscar.Text & "%' AND std_cli = '" & strState & "' ORDER BY ape_cli"

            Case "PHONE"
                sqlConsulta = "SELECT * FROM clientes WHERE tlf_cli LIKE '" & TxtBuscar.Text & "%' AND std_cli = '" & strState & "' ORDER BY tlf_cli"

            Case ""
                sqlConsulta = "SELECT * FROM clientes WHERE std_cli = '" & strState & "' ORDER BY nom_cli"
                MsgBox("Selecciona un FILTRO para busqueda.", vbCritical, "Error en la busqueda")
                CmbFiltrar.Focus()
        End Select

        Sub_Crud_Sql(sqlConsulta, "SubFillClientList", strFilter)
    End Sub
    Private Sub TxtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBuscar.KeyPress
        Select Case strFilter
            Case "NAME"

                '| -----------------------------------------------------------------------------------
                '| VALIDAR EL INGRESO DE LETRAS Y ESPACIO
                '| ---------------------------------------
                '| * Almacenamos en la variable strAllowKey los caracteres que queremos PERMITIR.
                '| * Almacenamos en la variable strLockKey los caracteres que queremos EXCLUIR.
                '| * Llamamos a la subrutina Fun_Only_Letters y le pasamos las variables como parámetro.

                Dim strAllowKey As String = " "
                Dim strLockKey As String = "ºª"
                Sub_Only_Letters(strAllowKey, strLockKey, e)

            Case "LASTNAME"

                '| -----------------------------------------------------------------------------------
                '| VALIDAR EL INGRESO DE LETRAS Y ESPACIO
                '| ---------------------------------------
                '| * Almacenamos en la variable strAllowKey los caracteres que queremos PERMITIR.
                '| * Almacenamos en la variable strLockKey los caracteres que queremos EXCLUIR.
                '| * Llamamos a la subrutina Fun_Only_Letters y le pasamos las variables como parámetro.

                Dim strAllowKey As String = " "
                Dim strLockKey As String = "ºª"
                Sub_Only_Letters(strAllowKey, strLockKey, e)

            Case "PHONE"

                '| -----------------------------------------------------------------------------------
                '| VALIDAR EL INGRESO DE NÚMEROS, PARÉNTESIS, GUION Y ESPACIO
                '| ----------------------------------------------------------
                '| * Almacenamos en la variable strAllowKey los caracteres que queremos PERMITIR.
                '| * Llamamos a la subrutina Sub_Only_Numbers y le pasamos la variable como parámetro.

                Dim strAllowKey As String = "(-) "
                Sub_Only_Numbers(strAllowKey, e)

                'Case ""
                '    sqlConsulta = "SELECT * FROM clientes WHERE std_cli = '" & strState & "' ORDER BY nom_cli"
                '    MsgBox("Selecciona un FILTRO para busqueda.", vbCritical, "Error en la busqueda")
                '    CmbFiltrar.Focus()
        End Select
    End Sub
    '
    '
    '
    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click

        '| * IF : Comprobamos si el CmbFiltrar, TxtBuscar están vacios o el DgvClientes no tiene filas, para _
        '|        _ salir de la función usando Exit Sub y evitar que se ejecuten las demás líneas de código.
        '| * Llenamos la variable strFlags con la cadena "SKIP_SEARCH" que se usará en TxtBuscar para hacer comprobaciones.
        '| * Pasamos la información del cliente seleccionado, del DgvClientes a los Labels, llamando a _
        '|   _ la subrutina Sub_Fill_Data_DgvClientes().
        '| * IF : Comprobamos si el LblGrpFamCli tiene información para buscar un grupo familiar si se cumple la condición _
        '|        _ hacemos la consulta a la BBDD y le pasamos como parámetro a la subrutina principal Sub_Crud_Sql().
        '| * Llamamos a las subrutina Sub_Select_Record_Cancel_Search() y Sub_Activate_Buttons() para activar, desactivar y ocultar controles.
        '| * Limpiamos la variable strFlags para futuras comprobaciones.

        If CmbFiltrar.Text = "" Or TxtBuscar.Text = "" Or DgvClientes.RowCount = 0 Then Exit Sub

        strFlags = "SKIP_SEARCH"
        Sub_Fill_Data_DgvClientes()

        If Not String.IsNullOrEmpty(LblGrpFamCli.Text) Then
            sqlConsulta = "SELECT * FROM grp_familiar WHERE id_grp = '" & LblGrpFamCli.Text & "'"
            Sub_Crud_Sql(sqlConsulta)
        End If

        Sub_Select_Record_Cancel_Search()
        Sub_Activate_Buttons()
        strFlags = ""

    End Sub
    '
    '
    '
    Private Sub BtnFindClient_Click(sender As Object, e As EventArgs) Handles BtnFindClient.Click

        '| * Llamamos a las subrutinas Sub_Select_Record_Cancel_Search() y Sub_Activate_Buttons() para activar, desactivar y ocultar controles.
        Sub_Search_Record()
        Sub_Disable_Buttons()

    End Sub
    '
    '
    '
    Private Sub BtnCancelSearch_Click(sender As Object, e As EventArgs) Handles BtnCancelSearch.Click

        '| * Llenamos la variable strFlags con la cadena "SKIP_SEARCH" que se usará en TxtBuscar para _
        '|   - hacer comprobaciones.
        '| * Llamamos a las subrutina Sub_Select_Record_Cancel_Search() y Sub_Activate_Buttons() para activar, _
        '|   _ desactivar y ocultar controles.
        '| * Limpiamos la variable strFlags para otras comprobaciones.

        strFlags = "SKIP_SEARCH"
        Sub_Select_Record_Cancel_Search()
        Sub_Activate_Buttons()
        strFlags = ""

    End Sub
    '
    '
    '
    Private Sub RbActivo_CheckedChanged(sender As Object, e As EventArgs) Handles RbActivo.CheckedChanged

        '| IF : Comprobamos si el RbActivo está activado para llenar la variable strState con la cadena "ACTIVO".
        '| ELSE : Caso contrario llenamos la variable strState con la cadena "INACTIVO".
        '| ** La variable strState se usa para hacer las consultas a la tabla Clientes.**
        '| * Llenamos el TxtBuscar con "JWIR" y luego borramos el texto, de esa manera activamos el TextChanged _
        '|   _ del TextBox para hacer la consulta, mostramos el resultado en el DgvClientes y enviamos el enfoque.

        If RbActivo.Checked Then
            strState = "ACTIVO"
        Else
            strState = "INACTIVO"
        End If

        TxtBuscar.Text = "JWIR"
        TxtBuscar.Clear()
        TxtBuscar.Focus()

    End Sub
    Private Sub RbInactivo_CheckedChanged(sender As Object, e As EventArgs) Handles RbInactivo.CheckedChanged
    End Sub
    '
    '
    '
    Private Sub DgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvClientes.CellContentClick
    End Sub
    Private Sub DgvClientes_DoubleClick(sender As Object, e As EventArgs) Handles DgvClientes.DoubleClick

        '| * IF : Comprobamos si el DgvClientes no tiene filas, para salir de la función usando Exit Sub y _
        '|        _ evitar que se ejecuten las demás líneas de código.
        '| * Llenamos la variable strFlags con la cadena "SKIP_SEARCH" que se usará en TxtBuscar para hacer comprobaciones.
        '| * Pasamos la información del cliente seleccionado, del DgvClientes a los Labels, llamando a _
        '|   _ la subrutina FunFillOutDgvClientes().
        '| * IF : Comprobamos si el LblGrpFamCli tiene información para buscar un grupo familiar si se cumple la condición _
        '|        _ hacemos la consulta a la BBDD y le pasamos como parámetro a la subrutina principal Sub_Crud_Sql().
        '| * Llamamos a las subrutina Sub_Select_Record_Cancel_Search() y Sub_Activate_Buttons() para activar, desactivar y ocultar controles.
        '| * Limpiamos la variable strFlags para futuras comprobaciones.

        If DgvClientes.RowCount = 0 Then Exit Sub

        strFlags = "SKIP_SEARCH"
        Sub_Fill_Data_DgvClientes()

        If Not String.IsNullOrEmpty(LblGrpFamCli.Text) Then
            sqlConsulta = "SELECT * FROM grp_familiar WHERE id_grp = '" & LblGrpFamCli.Text & "'"
            Sub_Crud_Sql(sqlConsulta)
        End If

        Sub_Select_Record_Cancel_Search()
        Sub_Activate_Buttons()
        strFlags = ""

    End Sub
    '
    '
    '
    Private Sub BtnNewClient_Click(sender As Object, e As EventArgs) Handles BtnNewClient.Click

        '| -------------------------------------------------------------------------------------
        '| REGISTRAR UN NUEVO CLIENTE EN LA BASE DE DATOS
        '| ----------------------------------------------
        '| * Limpiamos todos los labels del contenedor PnlDatosCliente llamando a la subrutina Sub_Clean_Label().
        '| * Desactivamos los botones llamando a la subrutina Sub_Disable_Buttons().
        '| * Ocultamos el boton BtnActualizar para mostrar el boton de guardar.
        '| * Hacemos al formulario FrmNuevoEditarCliente como hijo del formulario principal.
        '| * Mostramos el formulario FrmNuevoEditarCliente

        Sub_Clean_Label()
        Sub_Disable_Buttons()
        FrmNuevoEditarCliente.MdiParent = FrmPrincipal
        FrmNuevoEditarCliente.BtnActualizar.Visible = False
        FrmNuevoEditarCliente.Show()

    End Sub
    '
    '
    '
    Private Sub BtnModifyData_Click(sender As Object, e As EventArgs) Handles BtnModifyData.Click

        '| --------------------------------------------------------------------------------------
        '| MODIFICAR LOS DATOS DEL CLIENTE EN LA BASE DE DATOS
        '| ---------------------------------------------------
        '| IF : Si la variable está vacia:
        '|      * Salimos de la función usando Exit Sub para no ejecutar el resto del código.
        '| ELSE : Si se ha seleccionado un registro:
        '|      With : Enviamos al formulario FrmNuevoEditarCliente los datos del cliente.
        '|      * Hacemos al formulario FrmNuevoEditarCliente como hijo del formulario principal.
        '|      * Ocultamos el botón BtnGuardar para mostrar el botón Actualizar.
        '|      * Mostramos el formulario FrmNuevoEditarCliente con los datos del cliente.


        If LblNomCli.Text = "" Then
            Exit Sub
        Else

            With FrmNuevoEditarCliente
                .strIdClient = strIdClient
                .TxtNombre.Text = LblNomCli.Text
                .TxtApellido.Text = LblApeCli.Text
                .DtpFdn.Value = FnacimientoCorto.Text
                .TxtTelefono.Text = LblTlfCli.Text
                .TxtEmail.Text = LblEmlCli.Text
                .TxtDireccion.Text = LblDirCli.Text
                .DtpFdi.Value = FregistroCorto.Text

                If LblEstCli.Text = "ACTIVO" Then
                    .RbActiveStatus.Checked = True
                Else
                    .RbInactiveState.Checked = True
                End If

                Select Case LblMtdPgoCli.Text
                    Case "MENSUAL"
                        .RbMensual.Checked = True

                    Case "GRUPAL"
                        .RbGrupoFamiliar.Checked = True
                        .TxtListaNom.Text = LblGrpFamCli.Text

                    Case Else '"DIARIO"
                        .TxtListaNom.Text = LblMtdPgoCli.Text
                        .RbDiario.Checked = True
                End Select
            End With

            FrmNuevoEditarCliente.MdiParent = FrmPrincipal
            FrmNuevoEditarCliente.BtnGuardar.Visible = False
            FrmNuevoEditarCliente.Show()

        End If

    End Sub
    '
    '
    '
    Private Sub BtnDeleteClient_Click(sender As Object, e As EventArgs) Handles BtnDeleteClient.Click

        '| ------------------------------------------------------------------------------------------
        '| ELIMINAR UN REGISTRO DE LA TABLA CLIENTE
        '| -----------------------------------------
        '| IF : Comprobamos si la variable strIdClient está vacio, si se cumple la condición:
        '|      * Mostramos un mensaje de error informando que se 
        '|
        '|

        If strIdClient = "" Then MsgBox("  Para ELIMINAR selecciona un cliente :" & vbCr & vbCr &
                                        "    1.- Haz clic en Buscar cliente." & vbCr &
                                        "    2.- Selecciona un registro de la lista." _
                                        , vbCritical, "Error al eliminar") : Exit Sub

        If MsgBox("      NOMBRE  :  " & LblNomCli.Text & " " & LblApeCli.Text & vbCr &
                  "      CODIGO   :  " & strIdClient & vbCr & vbCr &
                  "   Si elimina el registro también eliminará toda la información" & vbCr &
                  "   relacionada al cliente." & vbCr &
                  "   _____________________________________________________________" & vbCr & vbCr &
                  "                             ¿Seguro que quieres ELIMINAR al cliente?" _
                  , vbExclamation + vbYesNo + vbDefaultButton2, "Eliminar registro del cliente") = vbYes Then

            sqlConsulta = "DELETE FROM clientes WHERE id_cli = '" & strIdClient & "'"
            Sub_Crud_Sql(sqlConsulta)

            Sub_Clean_Label()

            '----------------------------------

            sqlConsulta = "SELECT id_cli FROM clientes"

            Sub_Crud_Sql(sqlConsulta, "SubCheckRecords")
            '| * Llamamos a la subrutina Sub_Disable_Buttons() para desactivar los botones.

            Sub_Disable_Buttons()

            '----------------------------------
        End If
    End Sub
    '
    '
    '
    Private Sub DgvListaPagos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListaPagos.CellContentClick
        'DgvListaPagos_CellContentClick
    End Sub
    '
    '
    '
    Private Sub BtnPayMonth_Click(sender As Object, e As EventArgs) Handles BtnPayMonth.Click
        'BtnPagarMes_Click
        If DgvListaPagos.RowCount = 0 Then Exit Sub
    End Sub
    '
    '
    '
    Private Sub BtnNewPayment_Click(sender As Object, e As EventArgs) Handles BtnNewPayment.Click
        'BtnNuevoPago_Click
        If DgvListaPagos.RowCount = 0 Then Exit Sub
    End Sub
    '
    '
    '
    Private Sub BtnCloseWindow_Click(sender As Object, e As EventArgs) Handles BtnCloseWindow.Click
        'CERRAMOS LA VENTANA
        Close()
    End Sub
    '
    '::: -------------------------------------------------------- :::'
    '::: ---------->>>>>>>>>> PROCEDIMIENTOS <<<<<<<<<<---------- :::'
    '::: -------------------------------------------------------- :::'
    '
    Sub Sub_Activate_Buttons()

        '| -----------------------------
        '| * DESACTIVAMOS LOS BOTONES
        '| -----------------------------

        BtnModifyData.Enabled = True
        BtnDeleteClient.Enabled = True
        BtnPayMonth.Enabled = True
        BtnNewPayment.Enabled = True
        DgvListaPagos.Enabled = True

    End Sub

    Sub Sub_Disable_Buttons()

        '| -----------------------------
        '| * DESACTIVAMOS LOS BOTONES
        '| -----------------------------

        BtnModifyData.Enabled = False
        BtnDeleteClient.Enabled = False
        BtnPayMonth.Enabled = False
        BtnNewPayment.Enabled = False
        DgvListaPagos.Enabled = False

    End Sub

    Sub Sub_Select_Record_Cancel_Search()

        '| * Mostramos el botón BtnCancelSearch y ocultamos el botón BtnFindClient.
        '| * Desactivamos el contenedor PnlBuscar.
        '| * Limpiamos el CmbFiltrar cambiando el index a cero.
        '| * Desactivamos el RbActivo, para que al momento de hacer clic en BtnBuscar nos muestre todos los clientes.
        '| * Ocultamos el DgvClientes.
        '| * Desactivvamos el GbEstado para no cambiar de valor los RadioButton.

        BtnFindClient.Visible = True
        BtnCancelSearch.Visible = False
        PnlBuscar.Enabled = False
        CmbFiltrar.SelectedIndex = 0
        RbActivo.Checked = False
        DgvClientes.Visible = False
        LblResult.Visible = False
        GbEstado.Enabled = False

    End Sub

    Sub Sub_Search_Record()

        '| * Ocultamos el botón BtnFindClient y mostramos el botón BtnCancelSearch.
        '| * Activamos los dos contenedores PnlBuscar y GbEstado.
        '| * Cambiamos el texto del PnlBuscar seleccionando el index 1 (NOMBRE).
        '| * Activamos el RbActivo para mostrar y buscar los clientes en actividad.
        '| * Mostramos el DgvClientes y lo ponemos delante de los otros controles usando BringToFront.

        BtnFindClient.Visible = False
        BtnCancelSearch.Visible = True
        PnlBuscar.Enabled = True
        GbEstado.Enabled = True
        CmbFiltrar.SelectedIndex = 1
        RbActivo.Checked = True
        DgvClientes.Visible = True
        LblResult.Visible = True
        DgvClientes.BringToFront()

    End Sub

    Sub Sub_Clean_Label()

        '| * Recorremos todos los controles que están dentro del contenedor PnlDatosCliente.
        '|    * Comprobamos si los controles son de tipo Label.
        '|       * Comprobamos si el Name del control contiene "Cli".
        '|       * Limpiamos el texto del label.
        '| * Limpiamos la variable que contiene el id del cliente para hacer comprobaciones _
        '|   _ cuando se hacen cambios en el TxtBuscar.

        For Each control As Control In PnlDatosCliente.Controls
            If TypeOf (control) Is Label Then
                If control.Name.Contains("Cli") Then
                    control.Text = ""
                End If
            End If
        Next

        strIdClient = ""
    End Sub

    Sub Sub_Fill_Data_DgvClientes()

        '| * Depúes de confirmar la busqueda llenamos los label con información del cliente que lo obtenemos _
        '|   _ del DgvClientes y lo ocultamos para visualizar el resultado.

        With DgvClientes
            strIdClient = .CurrentRow.Cells(0).Value
            LblNomCli.Text = .CurrentRow.Cells(1).Value
            LblApeCli.Text = .CurrentRow.Cells(2).Value
            FnacimientoCorto.Text = .CurrentRow.Cells(3).Value
            LblFdnCli.Text = .CurrentRow.Cells(4).Value
            LblEdadCli.Text = .CurrentRow.Cells(5).Value
            LblTlfCli.Text = .CurrentRow.Cells(6).Value
            LblEmlCli.Text = .CurrentRow.Cells(7).Value
            LblDirCli.Text = .CurrentRow.Cells(8).Value
            LblMtdPgoCli.Text = .CurrentRow.Cells(9).Value
            FregistroCorto.Text = .CurrentRow.Cells(10).Value
            LblFdiCli.Text = .CurrentRow.Cells(11).Value
            LblEstCli.Text = .CurrentRow.Cells(12).Value
            LblGrpFamCli.Text = .CurrentRow.Cells(13).Value
            '.Visible = False
        End With
    End Sub

    Sub ChangeBackColorLabel()

        'COMPROBAMOS EL BACKCOLOR
        If LblNomCli.BackColor = Color.MintCream Then
            'RECORREMOS TODOS LOS LABEL QUE CUMPLAN LA CONDIÓN PARA CAMBIAR EL COLOR
            For Each control As Control In GbDatosCliente.Controls
                If TypeOf (control) Is Label Then
                    If control.Name.Contains("Cli") Then
                        control.BackColor = Color.WhiteSmoke
                    End If
                End If
            Next
        Else
            'RECORREMOS TODOS LOS LABEL QUE CUMPLAN LA CONDIÓN PARA CAMBIAR EL COLOR
            For Each control As Control In GbDatosCliente.Controls
                If TypeOf (control) Is Label Then
                    If control.Name.Contains("Cli") Then
                        control.BackColor = Color.MintCream
                    End If
                End If
            Next
        End If

    End Sub

End Class