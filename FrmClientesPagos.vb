Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class FrmClientesPagos

    Dim cnxnMySql As New MySqlConnection
    Dim drDataReader As MySqlDataReader
    Dim cmdCommand As MySqlCommand
    Dim nRow As Int16
    Dim sqlConsulta, strState, strFilter, strFlags As String
    Public strIdClient As String
    '
    '
    '
    Private Sub FrmClientesPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '| Llamamos a la función CleanLabel()
        '| Limpiamos el texto de SlblTitulo y SlblDescrip

        CleanLabel()
        SlblTitulo.Text = ""
        SlblDescrip.Text = ""

    End Sub
    Private Sub FrmClientesPagos_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        '| Usamos try-catch para controlar posibles errores.
        '| Conectamos y abrimos la base de datos.
        '| Hacemos una consulta para comprobar si hay registros en la tabla clientes y lo ejecutamos.
        '| IF : Comprobamos si la consulta tiene registros:
        '|      *FALTA DECIDIR BOTONES*'ACTIVAMOS LOS CONTROLES Y OCULTAMOS BOTONES
        '| ELSE : Si la consulta no ha encontrado registros:
        '|      *---*'DESACTIVAMOS LOS CONTROLES Y OCULTAMOS BOTONES
        '|      * Cambiamos los textos del StsBarra (SlblTitulo y SlblDescrip) informando que la tabla está vacía.
        '| Si se produce algún error lo capturamos en el Catch y mostramos un mensaje.
        '| Cerramos el drDataReader y la base de datos.

        Try
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()
            sqlConsulta = "SELECT id_cli FROM clientes"
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()

            If drDataReader.HasRows Then
                BtnBuscar.Enabled = True
                BtnModificar.Visible = True
                BtnEliminar.Visible = True
                DgvListaPagos.Enabled = True
                BtnPagarMes.Visible = True
                BtnNuevoPago.Visible = True
            Else
                BtnBuscar.Enabled = False
                BtnModificar.Visible = False
                BtnEliminar.Visible = False
                DgvListaPagos.Enabled = False
                BtnPagarMes.Visible = False
                BtnNuevoPago.Visible = False

                SlblTitulo.Text = "No hay clientes"
                SlblDescrip.Text = "  Haz clic en NUEVO para registrar un cliente."
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            drDataReader.Close()
            cnxnMySql.Close()
        End Try
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
                If DgvClientes.RowCount > 0 Then DgvClientes.CurrentCell = DgvClientes.Item(5, 0)

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

        LlenarListaClientes(sqlConsulta, strFilter, DgvClientes)
    End Sub
    '
    '
    '
    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click

        '| Comprobamos si el CmbFiltrar, TxtBuscar están vacios o el DgvClientes no tiene filas, para _
        '| _ salir de la función usando Exit Sub y evitar que se ejecuten las demás líneas de código.
        '| Llenamos la variable strFlags con la cadena "SKIP_SEARCH" que se usará en TxtBuscar para hacer comprobaciones.
        '| Pasamos la información del cliente seleccionado, del DgvClientes a los Labels, llamando a _
        '| _ la función FillDataDgvClientes().
        '| Llamamos a la función SearchFamilyGroup y le pasamos como parámetro el texto del LblGrpFamCli.
        '| Desactivamos los dos contenedores PnlBuscar y GbEstado.
        '| Cambiamos el texto del CmbFiltrar seleccionando el index uno (NOMBRE).
        '| Desactivamos el RbActivo, para que al momento de hacer clic en BtnBuscar nos muestre todos los clientes.
        '| Ponemos BtnBuscar encima del otro button usando BringToFront().
        '
        '| AQUI FALTA HACER COMENTARIO
        '
        '| Limpiamos la variable strFlags para futuras comprobaciones.
        '| Cambiamos los textos de SlblTitulo y de SlblDescrip después de seleccionar un cliente de la lista.

        If CmbFiltrar.Text = "" Or TxtBuscar.Text = "" Or DgvClientes.RowCount = 0 Then Exit Sub

        strFlags = "SKIP_SEARCH"

        FillDataDgvClientes()

        If Not String.IsNullOrEmpty(LblGrpFamCli.Text) Then SearchFamilyGroup(LblGrpFamCli.Text)

        PnlBuscar.Enabled = False
        GbEstado.Enabled = False
        CmbFiltrar.SelectedIndex = 0
        RbActivo.Checked = False
        BtnBuscar.BringToFront()
        '-----------------------'
        BtnNuevo.Enabled = True
        BtnModificar.Enabled = True
        BtnEliminar.Enabled = True
        BtnPagarMes.Enabled = True
        BtnNuevoPago.Enabled = True
        '-----------------------'
        strFlags = ""
        SlblTitulo.Text = "Cliente seleccionado"
        SlblDescrip.Text = " Puedes modificar sus datos, hacer pagos o eliminar al cliente."
    End Sub
    '
    '
    '
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        '| Activamos los dos contenedores PnlBuscar y GbEstado.
        '| Cambiamos el texto del PnlBuscar seleccionando el index 1 (NOMBRE).
        '| Activamos el RbActivo para mostrar y buscar los clientes en actividad.
        '| Mostramos el DgvClientes y lo ponemos delante de los otros controles usando BringToFront.
        '| Ponemos BtnCancelSearch encima del otro button usando BringToFront.
        '
        'FALTA DECIDIR EL COMPORTAMIENTO DE LOS BOTONES
        '
        PnlBuscar.Enabled = True
        GbEstado.Enabled = True
        CmbFiltrar.SelectedIndex = 1
        RbActivo.Checked = True
        DgvClientes.Visible = True
        DgvClientes.BringToFront()
        BtnCancelSearch.BringToFront()
        '
        BtnNuevo.Enabled = False
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
        BtnPagarMes.Enabled = False
        BtnNuevoPago.Enabled = False

    End Sub
    '
    '
    '
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelSearch.Click

        '| Llenamos la variable strFlags con la cadena "SKIP_SEARCH" que se usará en TxtBuscar para hacer comprobaciones.
        '| Desactivamos el contenedor PnlBuscar.
        '| Limpiamos el CmbFiltrar cambiando el index a cero.
        '| Desactivamos el RbActivo, para que al momento de hacer clic en BtnBuscar nos muestre todos los clientes.
        '| Ocultamos el DgvClientes.
        '| Ponemos el BtnBuscar encima del otro control usando BringToFront.
        '| Desactivvamos el GbEstado para no cambiar de valor los RadioButton.
        '
        '|FALTA DECIDIR SOBRE EL COMPORTAMIENTO DE LOS BOTONES
        '
        '| Limpiamos la variable strFlags para otras comprobaciones

        strFlags = "SKIP_SEARCH"
        PnlBuscar.Enabled = False
        CmbFiltrar.SelectedIndex = 0
        RbActivo.Checked = False
        DgvClientes.Visible = False
        BtnBuscar.BringToFront()
        GbEstado.Enabled = False
        '
        BtnNuevo.Enabled = True
        BtnModificar.Enabled = True
        BtnEliminar.Enabled = True
        'BtnPagarMes.Enabled = True
        'BtnNuevoPago.Enabled = True
        'ChangeBackColor()
        '
        strFlags = ""

    End Sub
    '
    '
    '
    Private Sub RbActivo_CheckedChanged(sender As Object, e As EventArgs) Handles RbActivo.CheckedChanged

        '| Comprobamos si el RbActivo está activado para llenar la variable strState con la cadena "ACTIVO".
        '| Caso contrario llenamos la variable strState con la cadena "INACTIVO".
        '| * La variable strState se usa para hacer las consultas a la tabla Clientes.
        '| Llenamos el TxtBuscar con "JWIR" y luego borramos el texto, de esa manera activamos el TextChanged _
        '| _ del TextBox para hacer la consulta, mostramos el resultado en el DgvClientes y enviamos el enfoque.

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

        '| * Comprobamos si el DgvClientes no tiene filas, para salir de la función usando Exit Sub y evitar _
        '|   _ que se ejecuten las demás líneas de código.
        '| * Llenamos la variable strFlags con la cadena "SKIP_SEARCH" que se usará en TxtBuscar para hacer comprobaciones.
        '| * Pasamos la información del cliente seleccionado, del DgvClientes a los Labels, llamando a _
        '|   _ la función FillOutDgvClientes().
        '| * Llamamos a la función SearchFamilyGroup y le pasamos como parámetro el texto del LblGrpFamCli.
        '| * Desactivamos los dos contenedores PnlBuscar y GbEstado.
        '| * Cambiamos el texto del CmbFiltrar seleccionando el index uno (NOMBRE).
        '| * Desactivamos el RbActivo, para que al momento de hacer clic en BtnBuscar nos muestre todos los clientes.
        '| * Ponemos BtnBuscar encima del otro button usando BringToFront().
        '
        '| AQUI FALTA HACER COMENTARIO
        '
        '| * Limpiamos la variable strFlags para futuras comprobaciones.
        '| * Cambiamos los textos de SlblTitulo y de SlblDescrip después de seleccionar un cliente de la lista.

        If DgvClientes.RowCount = 0 Then Exit Sub

        strFlags = "SKIP_SEARCH"

        FillDataDgvClientes()

        If Not String.IsNullOrEmpty(LblGrpFamCli.Text) Then SearchFamilyGroup(LblGrpFamCli.Text)

        PnlBuscar.Enabled = False
        GbEstado.Enabled = False
        CmbFiltrar.SelectedIndex = 0
        RbActivo.Checked = False
        BtnBuscar.BringToFront()
        '--------------------------'
        BtnNuevo.Enabled = True
        BtnModificar.Enabled = True
        BtnEliminar.Enabled = True
        BtnPagarMes.Enabled = True
        BtnNuevoPago.Enabled = True
        '--------------------------'
        strFlags = ""
        SlblTitulo.Text = "Cliente seleccionado"
        SlblDescrip.Text = " Puedes modificar sus datos, hacer pagos o eliminar al cliente."
    End Sub
    '
    '
    '
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        '| Limpiamos todos los labels del contenedor PnlDatosCliente llamando a la función CleanLabel()
        '| Cambiamos los textos de StsBarra para indicar al usuario que se va agregar un nuevo registro.
        '| Hacemos al formulario FrmNuevoEditarCliente como hijo del formulario principal.
        '| Ocultamos el boton BtnActualizar para mostrar el boton de guardar.
        '| Mostramos el formulario FrmNuevoEditarCliente

        CleanLabel()
        SlblTitulo.Text = "Nuevo registro"
        SlblDescrip.Text = " Esperando los datos del nuevo cliente."
        FrmNuevoEditarCliente.MdiParent = FrmPrincipal
        FrmNuevoEditarCliente.BtnActualizar.Visible = False
        FrmNuevoEditarCliente.Show()

    End Sub
    '
    '
    '
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        '| IF : Si la variable está vacio mostramos un mensaje de error y salimos de la función _
        '|      _ usando Exit Sub.
        '| ELSE : Si se ha seleccionado un registro
        '|      * -----
        '|      * Cambiamos los textos de SlblTitulo y SlblDescrip informando que se van a hcer cambios
        '|      * Hacemos al formulario FrmNuevoEditarCliente como hijo del formulario principal.
        '|      * Ocultamos el botón BtnGuardar para mostrar el botón Actualizar.
        '|      * Mostramos el formulario FrmNuevoEditarCliente con los datos del cliente.

        If LblNomCli.Text = "" Then
            Exit Sub
        Else
            'llenar datos
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
                    .RbEstadoActivo.Checked = True
                Else
                    .RbEstadoInactivo.Checked = True
                End If

                Select Case LblMtdPgoCli.Text
                    Case "MENSUAL"
                        .RbMensual.Checked = True

                    Case "GRUPAL"
                        .RbGrupoFamiliar.Checked = True
                        .TxtListaNom.Text = LblGrpFamCli.Text

                    Case Else '"DIARIO"
                        .RbDiario.Checked = True
                        .TxtListaNom.Text = LblMtdPgoCli.Text
                End Select
            End With
            'llenar datos
            SlblTitulo.Text = "Actualizar datos"
            SlblDescrip.Text = " Se va a modificar los datos, esperando los cambios."
            FrmNuevoEditarCliente.MdiParent = FrmPrincipal
            FrmNuevoEditarCliente.BtnGuardar.Visible = False
            FrmNuevoEditarCliente.Show()
        End If

    End Sub
    '
    '
    '
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        '"  Cliente seleccionado :" & vbCr & vbCr &
        '
        'COMPROBAMOS SI HAY UN REGISTRO SELECCIONADO
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
            FunCrudSql(sqlConsulta)

            CleanLabel()

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
    Private Sub BtnPagarMes_Click(sender As Object, e As EventArgs) Handles BtnPagarMes.Click
        'BtnPagarMes_Click
        If DgvListaPagos.RowCount = 0 Then Exit Sub
    End Sub
    '
    '
    '
    Private Sub BtnNuevoPago_Click(sender As Object, e As EventArgs) Handles BtnNuevoPago.Click
        'BtnNuevoPago_Click
        If DgvListaPagos.RowCount = 0 Then Exit Sub
    End Sub
    '
    '
    '
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        'CERRAMOS LA VENTANA
        Close()
    End Sub
    '
    '::: -------------------------------------------------------- :::'
    '::: ---------->>>>>>>>>> PROCEDIMIENTOS <<<<<<<<<<---------- :::'
    '::: -------------------------------------------------------- :::'
    '
    Sub CleanLabel()
        ' Recorremos todos los controles que están dentro del contenedor PnlDatosCliente.
        '   Comprobamos si los controles son de tipo Label.
        '       Comprobamos si el Name del control contiene "Cli".
        '       Limpiamos el texto del label.
        For Each control As Control In PnlDatosCliente.Controls
            If TypeOf (control) Is Label Then
                If control.Name.Contains("Cli") Then
                    control.Text = ""
                End If
            End If
        Next
        ' Limpiamos la variable que contiene el id del cliente para hacer
        ' comprobaciones cuando se hacen cambios en el TxtBuscar.
        strIdClient = ""
    End Sub

    Sub FillDataDgvClientes()

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
            .Visible = False
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

    Sub LlenarListaClientes(ByVal SqlConsulta As String, strFiltrar As String, ByVal DgvClientes As DataGridView)

        'USAMOS TRY-CATCH PARA CONTROLAR POSIBLES ERRORES
        Try
            'CONECTAMOS Y ABRIMOS LA BASE DE DATOS
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()

            'EJECUTAMOS LA CONSULTA RECIBIDA POR PARÁMETRO
            cmdCommand = New MySqlCommand(SqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()

            'LIMPIAMOS EL DATAGRIDVIEW
            DgvClientes.Rows.Clear()

            'COMPROBAMOS SI HAY REGISTROS
            If drDataReader.HasRows Then

                'MIENTRAS RECORRE EL DATAREADER LLENAMOS EL DATAGRIDVIEW
                While drDataReader.Read()
                    'AGREGAMOS UNA NUEVA FILA
                    nRow = DgvClientes.Rows.Add()
                    'LLENAMOS LOS DATOS
                    'ID DEL CLIENTE
                    DgvClientes.Rows(nRow).Cells(0).Value = drDataReader.GetInt16(0).ToString
                    'NOMBRE DEL CLIENTE
                    DgvClientes.Rows(nRow).Cells(1).Value = drDataReader.GetString(1)
                    'APELLIDO DEL CLIENTE
                    DgvClientes.Rows(nRow).Cells(2).Value = drDataReader.GetString(2)
                    'FECHA DE NACIMIENTO Y EDAD DEL CLIENTE
                    DgvClientes.Rows(nRow).Cells(3).Value = drDataReader.GetDateTime(3).ToShortDateString.ToString
                    DgvClientes.Rows(nRow).Cells(4).Value = FechaLarga(drDataReader.GetDateTime(3).ToShortDateString)
                    DgvClientes.Rows(nRow).Cells(5).Value = Int(DateDiff("m", drDataReader.GetDateTime(3).ToString("yyyy-MM-dd"), Now) / 12) & " años"
                    'TELEFONO DEL CLIENTE
                    DgvClientes.Rows(nRow).Cells(6).Value = drDataReader.GetString(4)
                    'E-MAIL DEL CLIENTE
                    DgvClientes.Rows(nRow).Cells(7).Value = drDataReader.GetString(5)
                    'DIRECCIÓN DEL CLIENTE
                    DgvClientes.Rows(nRow).Cells(8).Value = drDataReader.GetString(6)
                    'MÉTODO DE PAGO DEL CLIENTE
                    DgvClientes.Rows(nRow).Cells(9).Value = drDataReader.GetString(7)
                    'FECHA DE INSCRIPCIÓN
                    DgvClientes.Rows(nRow).Cells(10).Value = drDataReader.GetDateTime(8).ToShortDateString.ToString
                    DgvClientes.Rows(nRow).Cells(11).Value = FechaLarga(drDataReader.GetDateTime(8).ToShortDateString)
                    'ESTADO DEL CLIENTE
                    DgvClientes.Rows(nRow).Cells(12).Value = drDataReader.GetString(9)
                    'ID DEL GRUPO FAMILIAR
                    If Not (drDataReader("id_grp") Is DBNull.Value) Then
                        DgvClientes.Rows(nRow).Cells(13).Value = drDataReader.GetInt16(10).ToString
                    End If
                End While

                'SELECCIONAMOS EL TIPO DE TEXTO PARA MARCAR LA CABECERA DEL CAMPO DONDE SE ESTÁ HACIENDO LA BUSQUEDA
                Select Case strFiltrar

                    Case "NAME"
                        DgvClientes.CurrentCell = DgvClientes.Item(1, 0)

                    Case "LASTNAME"
                        DgvClientes.CurrentCell = DgvClientes.Item(2, 0)

                    Case "PHONE"
                        DgvClientes.CurrentCell = DgvClientes.Item(5, 0)

                End Select

                TxtBuscar.BackColor = Color.Snow
            Else
                TxtBuscar.BackColor = Color.MistyRose
            End If

            'TEXTO PARA EL STATUSSTRIP CON LA CANTIDAD DE CLIENTES REGISTRADOS
            SlblTitulo.Text = "Buscar Cliente"
            SlblDescrip.Text = " " & DgvClientes.RowCount & " - Registro(s) que coincide(n) con su búsqueda."

        Catch ex As MySql.Data.MySqlClient.MySqlException
            'ERROR GENERADO POR INGRESAR ESTE CARACTER ' Y OTROS POSIBLES CARACTERES QUE INFLUYAN EN LA CONSULTA A LA BBDD
            'mas comentario
            TxtBuscar.BackColor = Color.MistyRose
            MsgBox("El caractér ingresado es incorrecto [ ' ]", vbCritical, "Error")
            TxtBuscar.SelectionStart = TxtBuscar.Text.Length - 1
            TxtBuscar.SelectionLength = TxtBuscar.Text.Length
            Exit Try

        Catch ex As Exception
            'MENSAJE CON EL ERROR CAPTURADO
            MsgBox(ex.ToString)

        Finally
            'CERRAMOS EL DATAREADER Y LA BBDD
            drDataReader.Close()
            cnxnMySql.Close()
        End Try
    End Sub

    Sub SearchFamilyGroup(ByVal idGrupoFamiliar As String)

        '| Usamos Try-Catch para controlar posibles errores.
        '| Try :
        '|      * Conectamos la base de datos y lo abrimos.
        '|      * Hacemos la consulta a la tabla Grupo Familiar y lo ejecutamos.
        '|      * Llenamos el label LblGrpFamCli con el nombre del grupo familiar.
        '| Catch :
        '|      * Si hay un error lo capturamo y mostramos un mensaje.
        '| Finally :
        '|      * Cerramos el drDataReader y la base de datos.

        Try
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()
            sqlConsulta = "SELECT * FROM grp_familiar WHERE id_grp = '" & idGrupoFamiliar & "'"
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()
            drDataReader.Read()
            LblGrpFamCli.Text = drDataReader.GetString(1)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            drDataReader.Close()
            cnxnMySql.Close()
        End Try
    End Sub

End Class