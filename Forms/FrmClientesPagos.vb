Public Class FrmClientesPagos

    Dim sqlConsulta, strState, strFilter As String

    Public strIdClient, strIdGrpFamily, strFlags As String
    '
    '
    '
    Private Sub FrmClientesPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '-----------------------------------------------------------------------------------
        '| COMPROBAMOS SI HAY REGISTROS EN LA TABLA CLIENTES
        '| -------------------------------------------------
        '| * Llamamos a la subrutina Sub_Disable_Buttons() para desactivar los botones.
        '|
        '| * Hacemos la consulta y lo guardamos en la variable 'sqlConsulta' para comprobar
        '|   si hay registros en la tabla clientes, llamamos a la subrutina Sub_Crud_Sql()
        '|   y le pasamos como parametro la variable 'sqlConsulta' y el String 'SubCheckRecords'
        '|   que se usa en el Select Case del módulo SQLqueries.
        '|
        '| * Llamamos a la subrutina Sub_Clean_Controls() para limpiar los controles.

        Sub_Disable_Buttons()

        sqlConsulta = "SELECT id_cli FROM clientes"
        Sub_Crud_Sql(sqlConsulta, "SubCheckRecords")

        Sub_Clean_Controls()

    End Sub
    Private Sub FrmClientesPagos_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        '----------------------------------------------------------------------------------------
        '| COMPROBAMOS SI HAY CAMBIOS PARA ACTUALIZAR EL DATAGRIDVIEW
        '| ----------------------------------------------------------
        '| IF : Comprobamos el valor de la variable 'strFlags' para actualizar el DataGridView, si
        '|      es igual a 'UPDATE_PAYMENT_LIST' llamamos a la subrutina Sub_View_Payment_List()
        '|      para actualizar la lista de pagos.
        '|
        '| * Limpiamos la variable 'strFlags' para las próximas comprobaciones.

        If strFlags = "UPDATE_PAYMENT_LIST" Then Sub_View_Payment_List()

        'strFlags = ""
        'DgvPaymentList.CurrentCell = Nothing
        'BtnPayMonth.Enabled = False

    End Sub
    '
    '
    '
    Private Sub CmbFiltrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbFiltrar.SelectedIndexChanged

        '-----------------------------------------------------------------------------------------------------------------
        '| LLENAMOS LA VARIABLE PARA CONSULTAR LA TABLA CLIENTES
        '| -----------------------------------------------------
        '| SELECT CASE :
        '|      * Llenamos la variable 'strFilter' que servirá de filtro para hacer la consulta a la BBDD al momento de
        '|        ingresar datos en el TextBox 'TxtBuscar'.
        '|
        '| * Limpiamos TextBox 'TxtBuscar' y le enviamos el enfoque.

        Select Case CmbFiltrar.SelectedIndex
            Case 1
                strFilter = "NAME"

            Case 2
                strFilter = "LASTNAME"

            Case 3
                strFilter = "PHONE"

            Case Else
                strFilter = ""
        End Select

        TxtBuscar.Clear()
        TxtBuscar.Focus()

    End Sub
    '
    '
    '
    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged

        '--------------------------------------------------------------------------------------------
        '| LLENAMOS LA VARIABLE PARA CONSULTAR LA TABLA CLIENTES
        '| -----------------------------------------------------
        '| * Comprobamos si la variable strFlags es igual a "SKIP_SEARCH" para salir de la función con
        '|   Exit Sub, ese valor se recibe de 'BtnSeleccionar', 'DgvClientes' y 'BtnCancelSearch' y
        '|   sirve para no volver a hacer la consulta al momento de limpiar el TextBox ya que se
        '|   dispara el TextChanged.
        '|
        '| SELECT CASE : Seleccionamos un caso según el valor de la variable 'strFilter':
        '|      * Hacemos la consulta y lo almacenamos en la variable 'sqlConsulta'.
        '|      * Si la variable strFilter es nulo o vacio mostramos un mensaje de error y mandamos el
        '|        enfoque al 'CmbFiltrar' para seleccionar un filtro de busqueda.
        '|
        '| * Llamamos a la subrutina Sub_Crud_Sql() y le pasamos tres parámetros. El segundo parámetro
        '|   'SubFillClientList' se usa en el SelectCase del módulo 'SQLqueries', el tercer parámetro es
        '|   para pasarselo a la subrutina 'SubFillClientList' que se encarga de marca la columna que
        '|   estamos filtrando en la busqueda.

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

        '| --------------------------------------------------------------------------------------------
        '| VALIDAR EL INGRESO DE CARACTERES
        '| --------------------------------
        '| * Almacenamos en la variable 'strAllowKey' los caracteres que queremos PERMITIR.
        '| * Almacenamos en la variable 'strLockKey' los caracteres que queremos EXCLUIR.
        '| * Llamamos a la subrutina Fun_Only_Letters() y Sub_Only_Numbers () según sea el caso y le 
        '|   pasamos las variables como parámetros.

        Select Case strFilter
            Case "NAME"
                Dim strAllowKey As String = " "
                Dim strLockKey As String = "ºª"
                Sub_Only_Letters(strAllowKey, strLockKey, e)

            Case "LASTNAME"
                Dim strAllowKey As String = " "
                Dim strLockKey As String = "ºª"
                Sub_Only_Letters(strAllowKey, strLockKey, e)

            Case "PHONE"
                Dim strAllowKey As String = "(-) "
                Sub_Only_Numbers(strAllowKey, e)

        End Select

    End Sub
    '
    '
    '
    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click

        '| -----------------------------------------------------------------------------------------
        '| SELECCIONAR UN REGISTRO PRESIONANDO ENTER O HACIENDO CLIC EN EL BOTÓN
        '| ---------------------------------------------------------------------
        '| IF : Comprobamos si el CmbFiltrar o TxtBuscar están vacios, para salir de la función usando
        '|      Exit Sub y evitar que se ejecuten el resto del código.
        '|
        '| * Llamamos a la subrutina Sub_Upload_Data_And_Payments() que se encarga de llenar los datos
        '|   del cliente, comprobar si el cliente pertenece a un grupo familiar, ocultar, mostrar los
        '|   controles y llamar a la subrutina Sub_View_Payment_List() que carga el historial de pagos
        '|   del cliente seleccionado.

        If CmbFiltrar.Text = "" Or TxtBuscar.Text = "" Then Exit Sub

        Sub_Upload_Data_And_Payments()

    End Sub
    '
    '
    '
    Private Sub BtnFindClient_Click(sender As Object, e As EventArgs) Handles BtnFindClient.Click

        '| ---------------------------------------------------------------------------------------
        '| PREPARAMOS LOS CONTROLES PARA LA BUSQUEDA
        '| -----------------------------------------
        '| * Llamamos a las subrutinas Sub_Search_Record(), Sub_Disable_Buttons() y Sub_Clean_Controls()
        '|   para activar/desactivar, mostrar/ocultar y limpiar los controles.

        Sub_Search_Record()
        Sub_Disable_Buttons()
        Sub_Clean_Controls()

    End Sub
    '
    '
    '
    Private Sub BtnCancelSearch_Click(sender As Object, e As EventArgs) Handles BtnCancelSearch.Click

        '| ------------------------------------------------------------------------------------------
        '| CANCELAR LA BUSQUEDA
        '| --------------------
        '| * Llenamos la variable strFlags con la cadena "SKIP_SEARCH" que se usará en TxtBuscar para
        '|   hacer comprobaciones y evitar hacer consultas innecesarias.
        '|
        '| * Llamamos a las subrutina Sub_SelectRecord_CancelSearch() para activar, desactivar y
        '|   ocultar controles.
        '|
        '| * Limpiamos la variable strFlags para otras comprobaciones.

        strFlags = "SKIP_SEARCH"

        Sub_SelectRecord_CancelSearch()

        strFlags = ""

    End Sub
    '
    '
    '
    Private Sub RbActivo_CheckedChanged(sender As Object, e As EventArgs) Handles RbActivo.CheckedChanged

        '| ----------------------------------------------------------------------------------------------
        '| COMPROBAR QUE RADIOBUTTON ESTÁ ACTIVADO
        '| ---------------------------------------
        '| * Comprobamos si el RbActivo está activado para llenar la variable 'strState' con la cadena
        '|   "ACTIVO" en caso contrario llenamos la variable con la cadena "INACTIVO".
        '| ** La variable strState se usa para hacer las consultas a la tabla Clientes.**
        '|
        '| * Llenamos el TxtBuscar con "JWIR" y luego borramos el texto, de esa manera activamos el
        '|   TextChanged del TextBox para hacer la consulta, asi mostramos el resultado en el DgvClientes.
        '| * Limpiamos el textbox 'TxtBuscar' y enviamos le enfoque.

        If RbActivo.Checked Then
            strState = "ACTIVO"
        Else
            strState = "INACTIVO"
        End If

        TxtBuscar.Text = "JWIR"
        TxtBuscar.Clear()
        TxtBuscar.Focus()

    End Sub
    '
    '
    '
    Private Sub DgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvClientes.CellContentClick
    End Sub
    Private Sub DgvClientes_DoubleClick(sender As Object, e As EventArgs) Handles DgvClientes.DoubleClick

        '| ----------------------------------------------------------------------------------------------
        '| SELECCIONAR UN REGISTRO HACIENDO DOBLE CLIC EN EL DATAGRIDVIEW
        '| --------------------------------------------------------------
        '| * Llamamos a la subrutina Sub_Upload_Data_And_Payments() que se encarga de llenar los datos
        '|   del cliente, comprobar si el cliente pertenece a un grupo familiar, ocultar y mostrar los
        '|   controles y llamar a la subrutina Sub_View_Payment_List() que carga el historial de pagos
        '|   del cliente seleccionado.

        Sub_Upload_Data_And_Payments()

    End Sub
    Private Sub DgvClientes_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvClientes.CellFormatting

        '| ------------------------------------------------------------------------------------------------------------------------------
        '| MOSTRAR TOOLTIPTEXT EN EL DATAGRIDVIEW
        '| --------------------------------------
        '| IF : Comprobamos si el cursor del mouse está en una de las Columnas y no es la fila deL encabezado.
        '|      * Asignamos el ToolTipText directamente a la celda.

        Dim strToolTipText = "DOBLE CLIC PARA SELECCIONAR UN CLIENTE"

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 1 Then
            DgvClientes.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = strToolTipText
        End If

    End Sub
    '
    '
    '
    Private Sub BtnNewClient_Click(sender As Object, e As EventArgs) Handles BtnNewClient.Click

        '| -------------------------------------------------------------------------------------
        '| REGISTRAR UN NUEVO CLIENTE EN LA BASE DE DATOS
        '| ----------------------------------------------
        '| * Limpiamos los controles y todos los labels del contenedor PnlDatosCliente llamando
        '|   a la subrutina Sub_Clean_Controls().
        '|
        '| * Desactivamos los botones llamando a la subrutina Sub_Disable_Buttons().
        '|
        '| * Ocultamos el boton BtnActualizar para mostrar el boton de BtnGuardar.
        '| * Hacemos al formulario FrmNuevoEditarCliente como hijo del formulario principal.
        '| * Mostramos el formulario FrmNuevoEditarCliente

        Sub_Clean_Controls()

        Sub_Disable_Buttons()

        FrmNuevoEditarCliente.BtnActualizar.Visible = False
        FrmNuevoEditarCliente.MdiParent = FrmPrincipal
        FrmNuevoEditarCliente.Show()

    End Sub
    '
    '
    '
    Private Sub BtnModifyData_Click(sender As Object, e As EventArgs) Handles BtnModifyData.Click

        '| --------------------------------------------------------------------------------------
        '| MODIFICAR LOS DATOS DEL CLIENTE EN LA BASE DE DATOS
        '| ---------------------------------------------------
        '| * Si hay un registro seleccionado enviamos al formulario FrmNuevoEditarCliente los
        '|   datos del cliente para modificar su información.
        '|
        '| IF : Comprobamos el texto del 'LblEstCli' para activar el RadioButton que corresponda
        '|      al estado del cliente.
        '|
        '| SELECT CASE :
        '| * Elejimos unos de los casos según el texto de 'LblMtdPgoCli' para activar el RadioButton
        '|   que corresponda al método de pago del cliente.
        '|
        '| * Hacemos al formulario FrmNuevoEditarCliente como hijo del formulario principal.
        '| * Ocultamos el botón BtnGuardar para mostrar el botón Actualizar.
        '| * Mostramos el formulario FrmNuevoEditarCliente con los datos del cliente.

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

    End Sub
    '
    '
    '
    Private Sub BtnDeleteClient_Click(sender As Object, e As EventArgs) Handles BtnDeleteClient.Click

        '| ------------------------------------------------------------------------------------------
        '| ELIMINAR UN REGISTRO DE LA TABLA CLIENTE
        '| -----------------------------------------
        '| * Antes de eliminar mostramos un mensaje de advertencia y con una sentencia IF comprobamos
        '|   la respuesta del usuario.
        '|
        '| * Si la respuesta es 'SI' hacemos una consulta y lo almacenamos en la variable 'sqlConsulta'
        '| * Llamamos a la subrutina Sub_Crud_Sql() y le pasamos como parametro la 'sqlConsulta.
        '|
        '| * La subrutina Sub_Clean_Controls() se encarga de limpiar los Label's, el datagridview y la
        '|   variable 'strIdClient'.
        '|
        '| * Despues de eliminar comprobamos si hay registros en la tabla clientes haciendo una consulta
        '|   y llamando a la subrutina Sub_Crud_Sql(sqlConsulta, "SubCheckRecords"), el primer parametro
        '|   es la consulta y el segundo parámetro es para llamar a la subrutina que se encarga de activar
        '|   o desactivar el botón para hacer la busqueda de clientes.
        '|
        '| * Llamamos a la subrutina Sub_Disable_Buttons() para desactivar los botones.

        If MsgBox("      NOMBRE  :  " & LblNomCli.Text & " " & LblApeCli.Text & vbCr &
                  "      CODIGO   :  " & strIdClient & vbCr & vbCr &
                  "   Si elimina el registro también eliminará toda la información" & vbCr &
                  "   relacionada al cliente." & vbCr &
                  "   _____________________________________________________________" & vbCr & vbCr &
                  "                             ¿Seguro que quieres ELIMINAR al cliente?" _
                  , vbExclamation + vbYesNo + vbDefaultButton2, "Eliminar registro del cliente") = vbYes Then

            sqlConsulta = "DELETE FROM clientes WHERE id_cli = '" & strIdClient & "'"
            Sub_Crud_Sql(sqlConsulta)

            Sub_Clean_Controls()

            sqlConsulta = "SELECT id_cli FROM clientes"
            Sub_Crud_Sql(sqlConsulta, "SubCheckRecords")

            Sub_Disable_Buttons()

        End If

    End Sub
    '
    '
    '
    Private Sub DgvListaPagos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPaymentList.CellContentClick
    End Sub
    Private Sub DgvPaymentList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPaymentList.CellClick

        '| ----------------------------------------------------------------------------------------------------------------
        '| ACTIVAR O DESACTIVAR EL BOTON PARA PAGAR
        '| ----------------------------------------
        '| * Comprobamos si el registro seleccionado está pagado o no para activar o desactivar el botón 'BtnPayMonth'

        If DgvPaymentList.CurrentRow.Cells(2).Value = "SIN FECHA" Then
            BtnPayMonth.Enabled = True
        Else
            BtnPayMonth.Enabled = False
        End If

    End Sub
    '
    '
    '
    Private Sub BtnPayMonth_Click(sender As Object, e As EventArgs) Handles BtnPayMonth.Click

        '| ----------------------------------------------------------------------------------
        '| PAGAR UNA MENSUALIDAD
        '| ---------------------
        '| * Llenamos la variable 'strFlags' para actualizar el datagridview 'DgvPaymentList'
        '|   al momento de activar el formulario.

        strFlags = "UPDATE_PAYMENT_LIST"

        '| * ENVIAMOS LOS DATOS DEL MES AL FORMULARIO PAGOS

        With FrmPagoMensual
            .strIdPgs = DgvPaymentList.CurrentRow.Cells(0).Value 'ID_PAGO -ToString
            .LblCliente.Text = LblNomCli.Text & " " & LblApeCli.Text & " - " & LblEdadCli.Text 'NOMBRE, APELLIDO y EDAD
            .DtpFdiPgs.Value = DgvPaymentList.CurrentRow.Cells(1).Value 'FECHA DE INICIO DE MES -.ToString
            .TxtPrcPgs.Text = DgvPaymentList.CurrentRow.Cells(5).Value 'PRECIO
            .TxtDscPgs.Text = DgvPaymentList.CurrentRow.Cells(6).Value 'DESCUENTO
            '
            Select Case LblMtdPgoCli.Text
                Case "MENSUAL"
                    .CmbMtdPgs.SelectedIndex = 2
                Case "GRUPAL"
                    .CmbMtdPgs.SelectedIndex = 3
                Case Else 'DIARIO (5,6,7...)
                    .CmbMtdPgs.SelectedIndex = 1
            End Select
            '
            .MdiParent = FrmPrincipal
            .Show()
        End With

        '
        BtnPayMonth.Enabled = False
        DgvPaymentList.CurrentCell = Nothing

    End Sub
    '
    '
    '
    Private Sub BtnNewPayment_Click(sender As Object, e As EventArgs) Handles BtnNewPayment.Click

        '| ------------------------------------------------------------------------------------------
        '| 
        '| -----------------------------------------
        '|
        'BtnNuevoPago_Click
        'If DgvListaPagos.RowCount = 0 Then Exit Sub
        FrmPagoMensual.MdiParent = FrmPrincipal
        FrmPagoMensual.Show()
    End Sub
    '
    '
    '
    Private Sub BtnCloseWindow_Click(sender As Object, e As EventArgs) Handles BtnCloseWindow.Click

        '| ----------------------------------------------------------------------------------------
        '| CERRAMOS EL FORMULARIO
        '| ----------------------
        Close()

    End Sub

    '| ---------------------------------------------------- '
    '| ---------->>>>>>>>>> SUBRUTINAS <<<<<<<<<<---------- '
    '| ---------------------------------------------------- '

    Sub Sub_Activate_Buttons()

        '| -----------------------------
        '| * ACTIVAMOS LOS BOTONES
        '| -----------------------------

        BtnFindClient.Enabled = True
        BtnModifyData.Enabled = True
        BtnDeleteClient.Enabled = True
        'BtnPayMonth.Enabled = True
        BtnNewPayment.Enabled = True
        DgvPaymentList.Enabled = True

    End Sub

    Sub Sub_Disable_Buttons()

        '| -----------------------------
        '| * DESACTIVAMOS LOS CONTROLES
        '| -----------------------------

        'BtnFindClient.Enabled = False
        BtnModifyData.Enabled = False
        BtnDeleteClient.Enabled = False
        BtnPayMonth.Enabled = False
        BtnNewPayment.Enabled = False
        DgvPaymentList.Enabled = False

    End Sub

    Sub Sub_SelectRecord_CancelSearch()

        '| * Activamos el botón BtnNewClient.
        '| * Mostramos el botón BtnCancelSearch y ocultamos el botón BtnFindClient.
        '| * Desactivamos el contenedor PnlBuscar.
        '| * Limpiamos el CmbFiltrar cambiando el index a cero.
        '| * Desactivamos el RbActivo, para que al momento de hacer clic en BtnBuscar nos muestre todos los clientes.
        '| * Ocultamos el DgvClientes.
        '| * Desactivvamos el GbEstado para no cambiar de valor los RadioButton.

        BtnNewClient.Enabled = True
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

        '| * Desactivamos el botón BtnNewClient.
        '| * Ocultamos el botón BtnFindClient y mostramos el botón BtnCancelSearch.
        '| * Activamos los dos contenedores PnlBuscar y GbEstado.
        '| * Cambiamos el texto del PnlBuscar seleccionando el index 1 (NOMBRE).
        '| * Activamos el RbActivo para mostrar y buscar los clientes en actividad.
        '| * Mostramos el DgvClientes y lo ponemos delante de los otros controles usando BringToFront.

        BtnNewClient.Enabled = False
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

    Sub Sub_Clean_Controls()

        '| * Recorremos todos los controles que están dentro del contenedor PnlDatosCliente.
        '|    * Comprobamos si los controles son de tipo Label.
        '|       * Comprobamos si el Name del control contiene "Cli".
        '|       * Limpiamos el texto del label.
        ''
        '| * Limpiamos la variable que contiene el id del cliente para hacer comprobaciones _
        '|   _ cuando se hacen cambios en el TxtBuscar.

        For Each control As Control In PnlDatosCliente.Controls
            If TypeOf (control) Is Label Then
                If control.Name.Contains("Cli") Then
                    control.Text = ""
                End If
            End If
        Next
        DgvPaymentList.Rows.Clear()
        strIdClient = ""
    End Sub

    Sub Sub_Fill_Data_DgvClientes()

        '| * Depúes de confirmar la busqueda llenamos los label con información del cliente que
        '|   obtenemos del DgvClientes y lo ocultamos para visualizar el resultado.

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
            strIdGrpFamily = .CurrentRow.Cells(13).Value
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

    Sub Sub_Upload_Data_And_Payments()

        '| * Llenamos la variable 'strFlags' con la cadena "SKIP_SEARCH" que se usará en 'TxtBuscar' para
        '|   hacer comprobaciones y evitar hacer consultas inecesarias.
        '| * Pasamos la información del cliente seleccionado, del DgvClientes a los Labels, llamando a
        '|   la subrutina Sub_Fill_Data_DgvClientes().
        '|
        '| IF : Comprobamos si el 'LblGrpFamCli' tiene información para buscar un grupo familiar, si se cumple
        '|      la condición hacemos la consulta a la BBDD y lo almacenamos en la variable 'sqlConsulta'.
        '|      * Llamamos a la subrutina principal Sub_Crud_Sql() que va a recibir dos parametros, el primero
        '|        es la consulta y el segundo es la cadena 'SubFillGroupName' que servirá para el Select Case de
        '|        la subrutina principal que a su vez llama a la subrutina SubFillGroupName que se encarga de
        '|        recoger el nombre del grupo familiar.
        '|
        '| * Llamamos a las subrutina 'Sub_SelectRecord_CancelSearch()' y 'Sub_Activate_Buttons()' para
        '|   activar, desactivar y ocultar controles.
        '|
        '| * Llamamos a la subrutina Sub_View_Payment_List() para consultar los pagos del cliente.
        '|
        '| * Limpiamos la variable strFlags para futuras comprobaciones.

        strFlags = "SKIP_SEARCH"
        Sub_Fill_Data_DgvClientes()

        If Not String.IsNullOrWhiteSpace(strIdGrpFamily) Then 'LblGrpFamCli.Text
            sqlConsulta = "SELECT nom_grp FROM grp_familiar WHERE id_grp = '" & strIdGrpFamily & "'"
            Sub_Crud_Sql(sqlConsulta, "SubFillGroupName")
        End If

        Sub_SelectRecord_CancelSearch()
        Sub_Activate_Buttons()

        Sub_View_Payment_List()

        strFlags = ""

    End Sub

    Sub Sub_View_Payment_List()

        '| * Hacemos la consulta para seleccionar los pagos del cliente seleccionado y lo almacenamos en
        '|   la variable 'sqlConsulta'º
        '|
        '| IF : Comprobammos si el método de pago contiene 'DIARIO', si se cumple la condición llamamos a
        '|      la subrutina principal y le pasamos como tercer parámetro 'strDaily' en caso contario pasamos
        '|      un valor vacio, el segundo parámetro es para llamar a la subrutina que se encarga de llenar
        '|      el DataGridView 'DgvListaPagos'.
        '| * CurrentCell = Nothing eliminar el foco del cursor de la primera celda. 

        If String.IsNullOrWhiteSpace(strIdGrpFamily) Then
            sqlConsulta = "SELECT * FROM pagos WHERE id_cli = '" & strIdClient & "' ORDER BY fdi_pgs DESC"
        Else
            sqlConsulta = "SELECT * FROM pagos WHERE id_grp = '" & strIdGrpFamily & "' ORDER BY fdi_pgs DESC"
        End If

        If LblMtdPgoCli.Text.Contains("DIARIO") Then
            Sub_Crud_Sql(sqlConsulta, "SubFillPayments", "strDaily")
        Else
            Sub_Crud_Sql(sqlConsulta, "SubFillPayments", "")
        End If

        strFlags = ""

        DgvPaymentList.CurrentCell = Nothing

    End Sub

End Class