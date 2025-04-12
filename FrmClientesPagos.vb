Imports MySql.Data.MySqlClient

Public Class FrmClientesPagos

    Dim cnxnMySql As New MySqlConnection
    Dim drDataReader As MySqlDataReader
    Dim cmdCommand As MySqlCommand
    Dim sqlConsulta, idClient, strIdCli As String
    Dim nRow As Int16 ', rptMsgBox
    Public txtFlags As String

    Private Sub FrmClientesPagos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If txtFlags = "UPDATE_PAY" Then
            'CONSULTANOS A LA BBDD EL HISTORIAL DE PAGOS DEL CLIENTE SELECCIONADO
            sqlConsulta = "SELECT * FROM pagos WHERE id_cli = '" & idClient & "' ORDER BY id_pgs DESC"
            DgvLlenarPagos(sqlConsulta, DgvListaPagos)
            txtFlags = ""
        End If
    End Sub

    Private Sub FrmClientesPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'LLAMAMOS A LA FUNCIÓN DgvLlenar Y LE PASAMOS LA CONSULTA
        sqlConsulta = "SELECT * FROM clientes WHERE std_cli = 'SI' ORDER BY nom_cli"
        DgvLlenarClientes(sqlConsulta)

        BtnGuardaActualCancelCambia() 'ACTIVAR y DESACTIVAR LOS BOTONES

        TxtEdaCli.Clear() 'LIMPIAR TXTEDAD
    End Sub

    Private Sub TxtNomCli_GotFocus(sender As Object, e As EventArgs) Handles TxtNomCli.GotFocus

        TxtNomCli.BackColor = Color.Azure 'CAMBIAR COLOR DE FONDO DEL TEXTBOX

        If SlblTitulo.Text = "Buscar Cliente" Then

            TxtApeCli.Clear() 'LIMPIAR TEXTBOX PARA LA NUEVA BUSQUEDA

            DgvListaClientes.CurrentCell = DgvListaClientes.Item(1, 0) 'MARCAMOS LA CELDA
        End If
    End Sub

    Private Sub TxtNomCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNomCli.KeyPress
        'SOLO LETRAS
    End Sub

    Private Sub TxtNomCli_LostFocus(sender As Object, e As EventArgs) Handles TxtNomCli.LostFocus

        TxtLostFocus(TxtNomCli) 'LLAMAMOS A LA FUNCION TxtLostFocus Y LE PASAMOS LA CADENA DEL TxtNomCli
    End Sub

    Private Sub TxtNomCli_TextChanged(sender As Object, e As EventArgs) Handles TxtNomCli.TextChanged

        'COMPROBAR BUSCAR UN CLIENTE POR NOMBRE
        If SlblTitulo.Text = "Buscar Cliente" Then

            If RbSiCli.Checked Then 'HACEMOS LA CONSULTA A LA BBDD
                sqlConsulta = "SELECT * FROM clientes WHERE nom_cli LIKE '" & TxtNomCli.Text & "%' AND std_cli = 'SI' ORDER BY nom_cli"
            Else
                sqlConsulta = "SELECT * FROM clientes WHERE nom_cli LIKE '" & TxtNomCli.Text & "%' AND std_cli = 'NO' ORDER BY nom_cli"
            End If

            DgvLlenarClientes(sqlConsulta) 'LLAMAMOS A LA FUNCIÓN DgvLlenar Y LE PASAMOS LA CONSULTA

            If DgvListaClientes.RowCount <> 0 Then DgvListaClientes.CurrentCell = DgvListaClientes.Item(1, 0) 'MARCAMOS LA CELDA

            'CAMBIAMOS LOS TEXTOS DEL PANEL O BARRA DE ESTADO
            SlblTitulo.Text = "Buscar Cliente"
            SlblDescrip.Text = " " & DgvListaClientes.RowCount & " - Registro(s) que coincide(n) con su búsqueda."
        End If
    End Sub

    Private Sub TxtApeCli_GotFocus(sender As Object, e As EventArgs) Handles TxtApeCli.GotFocus

        TxtApeCli.BackColor = Color.Azure 'CAMBIAR COLOR DE FONDO DEL TEXTBOX

        If SlblTitulo.Text = "Buscar Cliente" Then

            TxtNomCli.Clear() 'LIMPIAR TEXTBOX PARA LA NUEVA BUSQUEDA

            DgvListaClientes.CurrentCell = DgvListaClientes.Item(2, 0) 'MARCAMOS LA CELDA
        End If
    End Sub

    Private Sub TxtApeCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtApeCli.KeyPress
        'SOLOLETRAS
    End Sub

    Private Sub TxtApeCli_LostFocus(sender As Object, e As EventArgs) Handles TxtApeCli.LostFocus

        TxtLostFocus(TxtApeCli) 'LLAMAMOS A LA FUNCION TxtLostFocus Y LE PASAMOS LA CADENA DEL TxtApeCli
    End Sub

    Private Sub TxtApeCli_TextChanged(sender As Object, e As EventArgs) Handles TxtApeCli.TextChanged

        'COMPROBAR BUSCAR UN CLIENTE POR APELLIDO
        If SlblTitulo.Text = "Buscar Cliente" Then

            If RbSiCli.Checked Then 'HACEMOS LA CONSULTA A LA BBDD
                sqlConsulta = "SELECT * FROM clientes WHERE ape_cli LIKE '" & TxtApeCli.Text & "%' AND std_cli = 'SI' ORDER BY ape_cli"
            Else
                sqlConsulta = "SELECT * FROM clientes WHERE ape_cli LIKE '" & TxtApeCli.Text & "%' AND std_cli = 'NO' ORDER BY ape_cli"
            End If

            DgvLlenarClientes(sqlConsulta) 'LLAMAMOS A LA FUNCIÓN DgvLlenar Y LE PASAMOS LA CONSULTA

            If DgvListaClientes.RowCount <> 0 Then DgvListaClientes.CurrentCell = DgvListaClientes.Item(2, 0) 'MARCAMOS LA CELDA

            'CAMBIAMOS LOS TEXTOS DEL PANEL O BARRA DE ESTADO
            SlblTitulo.Text = "Buscar Cliente"
            SlblDescrip.Text = " " & DgvListaClientes.RowCount & " - Registro(s) que coincide(n) con su búsqueda."
        End If
    End Sub

    Private Sub DtpFdnCli_GotFocus(sender As Object, e As EventArgs) Handles DtpFdnCli.GotFocus
        TxtEdaCli.BackColor = Color.Azure
    End Sub

    Private Sub DtpFdnCli_LostFocus(sender As Object, e As EventArgs) Handles DtpFdnCli.LostFocus
        TxtEdaCli.BackColor = Color.Beige
        If TxtEdaCli.Text = "" Then TxtEdaCli.BackColor = Color.MistyRose
    End Sub

    Private Sub DtpFdnCli_ValueChanged(sender As Object, e As EventArgs) Handles DtpFdnCli.ValueChanged
        '
        TxtEdaCli.Text = Int(DateDiff("m", DtpFdnCli.Value, Now) / 12) & " años"
    End Sub

    Private Sub TxtTlfCli_GotFocus(sender As Object, e As EventArgs) Handles TxtTlfCli.GotFocus
        TxtTlfCli.BackColor = Color.Azure
    End Sub

    Private Sub TxtTlfCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTlfCli.KeyPress
        'SOLO NÚMEROS
    End Sub

    Private Sub TxtTlfCli_LostFocus(sender As Object, e As EventArgs) Handles TxtTlfCli.LostFocus
        TxtLostFocus(TxtTlfCli)
    End Sub

    Private Sub TxtTlfCli_TextChanged(sender As Object, e As EventArgs) Handles TxtTlfCli.TextChanged
        'CODIGO PARA BUSCAR
    End Sub

    Private Sub TxtEmlCli_GotFocus(sender As Object, e As EventArgs) Handles TxtEmlCli.GotFocus
        TxtEmlCli.BackColor = Color.Azure
    End Sub

    Private Sub TxtEmlCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEmlCli.KeyPress
        'NO SABEMOS QUE HACER
    End Sub

    Private Sub TxtEmlCli_LostFocus(sender As Object, e As EventArgs) Handles TxtEmlCli.LostFocus
        TxtLostFocus(TxtEmlCli)
    End Sub
    Private Sub TxtEmlCli_TextChanged(sender As Object, e As EventArgs) Handles TxtEmlCli.TextChanged
        'COMPROBAR SI ES UN CORREO CORRECTO
    End Sub

    Private Sub TxtDirCli_GotFocus(sender As Object, e As EventArgs) Handles TxtDirCli.GotFocus
        TxtDirCli.BackColor = Color.Azure
    End Sub

    Private Sub TxtDirCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDirCli.KeyPress
        'COMPROBAR
    End Sub

    Private Sub TxtDirCli_LostFocus(sender As Object, e As EventArgs) Handles TxtDirCli.LostFocus
        TxtLostFocus(TxtDirCli)
    End Sub

    Private Sub TxtDirCli_TextChanged(sender As Object, e As EventArgs) Handles TxtDirCli.TextChanged
        'PENSAREMOS PARA QUE NOS PUEDE SERVIR
    End Sub

    Private Sub DgvListCli_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListaClientes.CellClick

        'COMPROBAR SI LA LISTA ESTA VACIA
        If DgvListaClientes.RowCount = 0 Then Exit Sub

        SlblTitulo.Text = "" 'CAMBIAMOS EL TEXTOS DEL PANEL O BARRA DE ESTADO

        TxtLlenar() 'LLAMAMOS LA FUNCIÓN PARA LLENAR LOS TEXTBOX

        sqlConsulta = "SELECT * FROM clientes WHERE id_cli = '" & idClient & "'" 'HACEMOS LA CONSULTA A LA BBDD

        DgvLlenarClientes(sqlConsulta) 'LLAMAMOS A LA FUNCIÓN DgvLlenar Y LE PASAMOS LA CONSULTA

        TxtDesactivar() 'DESACTIVAR CUADROS DE TEXTO

        'CONSULTANOS A LA BBDD EL HISTORIAL DE PAGOS DEL CLIENTE SELECCIONADO
        sqlConsulta = "SELECT * FROM pagos WHERE id_cli = '" & idClient & "' ORDER BY id_pgs DESC"
        DgvLlenarPagos(sqlConsulta, DgvListaPagos)

        BtnGuardaActualCancelCambia() 'ACTIVAR y DESACTIVAR BOTONES

        'CAMBIAMOS LOS TEXTOS DEL PANEL O BARRA DE ESTADO
        SlblTitulo.Text = "Cliente Encontrado"
        SlblDescrip.Text = " Puedes modificar sus datos, hacer pagos o cambiar su estado."
    End Sub

    Private Sub RbSiCli_Click(sender As Object, e As EventArgs) Handles RbSiCli.Click

        sqlConsulta = "SELECT * FROM clientes WHERE std_cli = 'SI' ORDER BY nom_cli" 'HACEMOS LA CONSULTA A LA BBDD

        DgvLlenarClientes(sqlConsulta) 'LLAMAMOS A LA FUNCIÓN DgvLlenar Y LE PASAMOS LA CONSULTA

        TxtLimpiar() 'LIMPIAR CUADROS DE TEXTO

        TxtDesactivar() 'DESACTIVAR CUADROS DE TEXTO

        BtnGuardaActualCancelCambia() 'ACTIVAR y DESACTIVAR BOTONES
    End Sub

    Private Sub RbNoCli_Click(sender As Object, e As EventArgs) Handles RbNoCli.Click

        sqlConsulta = "SELECT * FROM clientes WHERE std_cli = 'NO' ORDER BY nom_cli" 'HACEMOS LA CONSULTA A LA BBDD

        DgvLlenarClientes(sqlConsulta) 'LLAMAMOS A LA FUNCIÓN DgvLlenar Y LE PASAMOS LA CONSULTA

        TxtLimpiar() 'LIMPIAR CUADROS DE TEXTO

        TxtDesactivar() 'DESACTIVAR CUADROS DE TEXTO

        BtnGuardaActualCancelCambia() 'ACTIVAR y DESACTIVAR BOTONES
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        RbSiCli.PerformClick() 'ACTIVAR RADIOBUTTON SI

        'CAMBIAMOS EL TEXTO DE LA BARRA DE ESTADO
        SlblTitulo.Text = "Nuevo Cliente"
        SlblDescrip.Text = " Ingresa los datos del nuevo cliente."

        DgvListaPagos.Rows.Clear() '

        BtnNuevoEditar() 'ACTIVAR y DESACTIVAR BOTONES

        TxtLimpiar() 'LIMPIAR CUADROS DE TEXTO

        TxtActivar() 'ACTIVAR CUADROS DE TEXTO

        TxtNomCli.Focus() 'ENVIAR ENFOQUE

        'CAMBIAR TEXTO DEL ESTADO
        TxtStdCli.Text = "En Actividad"
        TxtStdCli.ForeColor = Color.MediumBlue
        TxtStdCli.Font = New Font(TxtStdCli.Font, FontStyle.Regular)
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        'COMPROBAMOS SI HAY UN CLIENTE SELECCIONADO
        If idClient = "" Then MsgBox("Selecciona un cliente de la lista", vbInformation, "Modificar Datos") : DgvListaClientes.Focus() : Exit Sub

        'CAMBIAMOS EL TEXTO DE LA BARRA DE ESTADO
        SlblTitulo.Text = "Editar Cliente"
        SlblDescrip.Text = " Modifica los datos del cliente registrado."

        txtFlags = "UPDATE" 'VARIABLE BANDERA PARA LA BARRA DE ESTADO

        BtnNuevoEditar() 'ACTIVAR y DESACTIVAR BOTONES

        TxtActivar() 'ACTIVAR LOS TEXBOX

        TxtNomCli.Focus() 'ENVIAR ENFOQUE
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        'COMPROBAMOS SI HAY UN CLIENTE SELECCIONADO
        If idClient = "" Then MsgBox("Selecciona un cliente de la lista", vbInformation, "Eliminar Cliente") : DgvListaClientes.Focus() : Exit Sub

        'CAMBIAMOS EL TEXTO DE LA BARRA DE ESTADO
        SlblTitulo.Text = "Eliminar Cliente"
        SlblDescrip.Text = " ¿Desea eliminar al cliente seleccionado?."

        Try
            'CONECTAR Y ABRIR LA BBDD
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()

            'CONCATENAMOS EL CÓDIGO DEL CLIENTE
            If idClient.Length = 1 Then strIdCli = "CLI - 00" & idClient
            If idClient.Length = 2 Then strIdCli = "CLI - 0" & idClient
            If idClient.Length = 3 Then strIdCli = "CLI - " & idClient

            'MENSAJE DE CONFIRMACIÓN PARA ELIMINAR UN CLIENTE
            If MsgBox("CLIENTE SELECCIONADO :" & Chr(13) & Chr(13) &
                      "     NOMBRE  :  " & TxtNomCli.Text & " " & TxtApeCli.Text & Chr(13) &
                      "     CODIGO  :  " & strIdCli & Chr(13) & Chr(13) &
                      "Si elimina el registro, tambien se borraran todos los" & Chr(13) &
                      "pagos relacionados al cliente." & Chr(13) & Chr(13) &
                      "                                                       ¿Estás seguro?" _
                      , vbQuestion + vbYesNo + vbDefaultButton2, "Eliminar Cliente") = vbYes Then

                'HACEMOS Y EJECUTAMOS LA CONSULTA A LA BBDD
                sqlConsulta = "DELETE FROM clientes WHERE id_cli = '" & idClient & "'"
                cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                drDataReader = cmdCommand.ExecuteReader
                drDataReader.Close()
                cnxnMySql.Close() 'CERRAMOS LA BBDD

                'HACEMOS LA CONSULTA A LA BBDD
                If RbSiCli.Checked = True Then
                    sqlConsulta = "SELECT * FROM clientes WHERE std_cli = 'SI' ORDER BY nom_cli"
                Else
                    sqlConsulta = "SELECT * FROM clientes WHERE std_cli = 'NO' ORDER BY nom_cli"
                End If
                DgvLlenarClientes(sqlConsulta) 'LLAMAMOS A LA FUNCIÓN DgvLlenar Y LE PASAMOS LA CONSULTA

                TxtLimpiar() 'LIMPIAR CUADROS TEXTO

                BtnGuardaActualCancelCambia() 'ACTIVAR y DESACTIVAR BOTONES

                BtnNuevo.Focus() 'ENVIAMOS EL ENFOQUE
            Else
                'CAMBIAMOS LOS TEXTOS DEL PANEL O BARRA DE ESTADO
                SlblTitulo.Text = "Cliente Encontrado"
                SlblDescrip.Text = " Puedes modificar sus datos, hacer pagos o cambiar su estado."
                cnxnMySql.Close() 'CERRAMOS LA BBDD
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnCambiar_Click(sender As Object, e As EventArgs) Handles BtnCambiar.Click

        'COMPROBAMOS SI HAY UN CLIENTE SELECCIONADO
        If idClient = "" Then MsgBox("Selecciona un cliente de la lista", vbExclamation, "Cambiar estado") : DgvListaClientes.Focus() : Exit Sub

        'CAMBIAMOS EL TEXTO DE LA BARRA DE ESTADO
        SlblTitulo.Text = "Cambiar estado"
        SlblDescrip.Text = " ¿Desea cambiar el estado cliente seleccionado?."

        Try
            'CONECTAR Y ABRIR LA BBDD
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()

            'CONCATENAMOS EL CÓDIGO DEL CLIENTE
            If idClient.Length = 1 Then strIdCli = "CLI - 00" & idClient
            If idClient.Length = 2 Then strIdCli = "CLI - 0" & idClient
            If idClient.Length = 3 Then strIdCli = "CLI - " & idClient

            'MENSAJE DE CONFIRMACIÓN PARA CAMBIAR DE ESTADO UN CLIENTE
            If MsgBox("CLIENTE SELECCIONADO :" & Chr(13) & Chr(13) &
                      "     NOMBRE  :  " & DgvListaClientes.CurrentRow.Cells(0).Value.ToString & " " & DgvListaClientes.CurrentRow.Cells(1).Value.ToString & Chr(13) &
                      "     CODIGO  :  " & strIdCli & Chr(13) & Chr(13) &
                      "Vas a cambiar el estado del cliente." & Chr(13) &
                      "Si pasa a INACTIVIDAD no se podra realizar nuevos pagos." & Chr(13) & Chr(13) &
                      "                                                       ¿Estás seguro?" _
                      , vbQuestion + vbYesNo + vbDefaultButton2, "Cambiar estado") = vbYes Then

                'HACEMOS Y EJECUTAMOS LA CONSULTA A LA BBDD
                If RbSiCli.Checked = True Then
                    sqlConsulta = "UPDATE clientes SET std_cli = 'NO' WHERE id_cli = '" & idClient & "'"
                Else
                    sqlConsulta = "UPDATE clientes SET std_cli = 'SI' WHERE id_cli = '" & idClient & "'"
                End If
                cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                drDataReader = cmdCommand.ExecuteReader
                drDataReader.Close()
                cnxnMySql.Close() 'CERRAMOS LA BBDD

                'HACEMOS LA CONSULTA A LA BBDD
                If RbSiCli.Checked = True Then
                    sqlConsulta = "SELECT * FROM clientes WHERE std_cli = 'SI' ORDER BY nom_cli"
                Else
                    sqlConsulta = "SELECT * FROM clientes WHERE std_cli = 'NO' ORDER BY nom_cli"
                End If
                DgvLlenarClientes(sqlConsulta) 'LLAMAMOS A LA FUNCIÓN DgvLlenar Y LE PASAMOS LA CONSULTA

                TxtLimpiar() 'LIMPIAR CUADROS TEXTO

                BtnGuardaActualCancelCambia() 'ACTIVAR y DESACTIVAR BOTONES

                BtnNuevo.Focus() 'ENVIAMOS EL ENFOQUE
            Else
                'CAMBIAMOS LOS TEXTOS DEL PANEL O BARRA DE ESTADO
                SlblTitulo.Text = "Cliente Encontrado"
                SlblDescrip.Text = " Puedes modificar sus datos, hacer pagos o cambiar su estado."
                cnxnMySql.Close() 'CERRAMOS LA BBDD
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        SlblTitulo.Text = "Buscar Cliente" 'CAMBIAR TEXTO DE LA BARRA DE ESTADO

        'ACTIVAR Y CAMBIAR COLOR DE TEXTBOX
        TxtNomCli.Enabled = True
        TxtNomCli.BackColor = Color.Beige
        TxtApeCli.Enabled = True
        TxtApeCli.BackColor = Color.Beige

        TxtLimpiar() 'LIMPIAR CUADROS DE TEXTO

        TxtNomCli.Focus() 'ENVIA EL ENFOQUE

        BtnGuardaActualCancelCambia() 'ACTIVAR Y DESACTIVAR LOS BOTONES

        'CAMBIAMOS LOS TEXTOS DEL PANEL O BARRA DE ESTADO
        SlblTitulo.Text = "Buscar Cliente"
        SlblDescrip.Text = " " & DgvListaClientes.RowCount & " - Registro(s) que coincide(n) con su búsqueda."
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        'COMPROBAMOS SI HAY INFORMACION DEL CLIENTE
        If TxtNomCli.Text = "" Then MsgBox("Ingrese el NOMBRE del cliente.", vbCritical, "Guardar Datos Cliente") : TxtNomCli.Focus() : Exit Sub
        If TxtApeCli.Text = "" Then MsgBox("Ingrese el APELLIDO del cliente.", vbCritical, "Guardar Datos Cliente") : TxtApeCli.Focus() : Exit Sub
        If TxtEdaCli.Text = "" Then MsgBox("Ingrese la FECHA de NACIMIENTO del cliente.", vbCritical, "Guardar Datos Cliente") : DtpFdnCli.Focus() : Exit Sub

        'CAMBIAMOS LOS TEXTOS DE LA BARRA DE ESTADO
        SlblTitulo.Text = "Guardar Cliente"
        SlblDescrip.Text = " Los datos del nuevo cliente se han REGISTRADO en la Base de Datos."

        Try
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()

            'AGREGAMOS EL NUEVO CLIENTE A LA TABLA CLIENTES
            sqlConsulta = "INSERT INTO clientes (nom_cli, ape_cli, fdn_cli, tlf_cli, eml_cli, dir_cli, fdi_cli, std_cli) VALUES 
              ('" & TxtNomCli.Text & "', '" & TxtApeCli.Text & "', '" & DtpFdnCli.Value.ToString("yyyy-MM-dd") & "', '" & TxtTlfCli.Text & "', 
              '" & TxtEmlCli.Text & "', '" & TxtDirCli.Text & "', '" & DtpFdiCli.Value.Date.ToString("yyyy-MM-dd") & "', 'SI')"
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()
            drDataReader.Close()

            'OBTENEMOS EL ID DEL ÚLTIMO REGISTRO Y LO ALMACENAMOS EN LA VARIABLE strIdCli
            sqlConsulta = "SELECT id_cli FROM clientes ORDER BY id_cli DESC LIMIT 1"
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader
            drDataReader.Read()
            idClient = drDataReader.GetInt16(0).ToString
            drDataReader.Close()

            'SELECCIONAMOS EL DESCUENTO CORRESPONDIENTE POR LA EDAD
            sqlConsulta = "SELECT * FROM tarifas WHERE e_min <= '" & TxtEdaCli.Text & "' AND e_max >= '" & TxtEdaCli.Text & "'"
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader
            drDataReader.Read()
            Dim precio = Replace(drDataReader.GetDecimal(1).ToString, ",", ".")
            Dim descto = Replace(drDataReader.GetDecimal(4).ToString, ",", ".")
            drDataReader.Close()
            '
            'AGREGAMOS UN NUEVO REGISTRO EN LA TABLA PAGOS
            sqlConsulta = "INSERT INTO pagos (fdi_pgs, fdp_pgs, frm_pgs, prc_pgs, dsc_pgs, id_cli) VALUES 
                          ('" & DateTime.Now.ToString("yyyy-MM-dd") & "', '0101-01-01', '', '" & precio & "', '" & descto & "', '" & idClient & "')"
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()
            drDataReader.Close()
            cnxnMySql.Close()

            'LLAMAMOS A LA FUNCIÓN DgvLlenar Y LE PASAMOS LA CONSULTA
            sqlConsulta = "SELECT * FROM clientes WHERE id_cli = '" & idClient & "'"
            DgvLlenarClientes(sqlConsulta)

            'ENVIAMOS MENSAJE DE CONFIRMACIÓN
            If idClient.Length = 1 Then strIdCli = "CLI - 00" & idClient
            If idClient.Length = 2 Then strIdCli = "CLI - 0" & idClient
            If idClient.Length = 3 Then strIdCli = "CLI - " & idClient
            MsgBox("Datos GUARDADOS satisfactoriamente." & Chr(13) & Chr(13) _
                   & "NOMBRE   :  " & TxtNomCli.Text & " " & TxtApeCli.Text & Chr(13) _
                   & "CODIGO   :  " & strIdCli, vbInformation, "Guardar Cliente")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        BtnGuardaActualCancelCambia() 'ACTIVAR Y DESACTIVAR BOTONES

        TxtDesactivar() 'DESACTIVAR CUADROS DE TEXTO

        BtnNuevo.Focus() 'ENVIAMOS EL ENFOQUE AL BOTON NUEVO

        'CONSULTANOS A LA BBDD EL HISTORIAL DE PAGOS DEL CLIENTE SELECCIONADO
        sqlConsulta = "SELECT * FROM pagos WHERE id_cli = '" & idClient & "' ORDER BY id_pgs DESC"
        DgvLlenarPagos(sqlConsulta, DgvListaPagos)
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        'COMPROBAMOS SI HAYINFORMACION DEL CLIENTE
        If TxtNomCli.Text = "" Then MsgBox("Ingrese el NOMBRE del cliente.", vbCritical, "Actualizar Datos Cliente") : TxtNomCli.Focus() : Exit Sub
        If TxtApeCli.Text = "" Then MsgBox("Ingrese la DIRECCION del cliente.", vbCritical, "Actualizar Datos Cliente") : TxtApeCli.Focus() : Exit Sub
        If TxtEdaCli.Text = "" Then MsgBox("Ingrese la fecha de NACIMIENTO del cliente.", vbCritical, "Actualizar Datos Cliente") : TxtEdaCli.Focus() : Exit Sub

        'CAMBIAMOS LOS TEXTOS DE LA BARRA DE ESTADO
        SlblTitulo.Text = "Actualizar Cliente"
        SlblDescrip.Text = " Los datos del cliente se están ACTUALIZANDO en la Base de Datos."

        Try
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()

            'ACTUALIZAMOS LOS DATOS DEL CLIENTE
            sqlConsulta = "UPDATE clientes SET nom_cli='" & TxtNomCli.Text & "', ape_cli='" & TxtApeCli.Text & "', fdn_cli='" & DtpFdnCli.Value.ToString("yyyy-MM-dd") & "', 
                          tlf_cli='" & TxtTlfCli.Text & "', eml_cli='" & TxtEmlCli.Text & "', dir_cli='" & TxtDirCli.Text & "', 
                          fdi_cli='" & DtpFdiCli.Value.ToString("yyyy-MM-dd") & "' WHERE id_cli='" & idClient & "'" ', std_cli='" & strEstado & "' 
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader
            drDataReader.Close()
            cnxnMySql.Close()

            'ACTUALIZAMOS LOS DATOS EN EL DATAGRIDVIEW
            DgvListaClientes.CurrentRow.Cells(1).Value = TxtNomCli.Text
            DgvListaClientes.CurrentRow.Cells(2).Value = TxtApeCli.Text
            DgvListaClientes.CurrentRow.Cells(3).Value = DtpFdnCli.Value
            DgvListaClientes.CurrentRow.Cells(4).Value = TxtTlfCli.Text
            DgvListaClientes.CurrentRow.Cells(5).Value = TxtEmlCli.Text
            DgvListaClientes.CurrentRow.Cells(6).Value = TxtDirCli.Text
            DgvListaClientes.CurrentRow.Cells(7).Value = DtpFdiCli.Value

            'ENVIAMOS MENSAJE DE CONFIRMACION
            If idClient.Length = 1 Then strIdCli = "CLI-00" & idClient
            If idClient.Length = 2 Then strIdCli = "CLI-0" & idClient
            If idClient.Length = 3 Then strIdCli = "CLI-" & idClient
            MsgBox("Datos ACTUALIZADOS satisfactoriamente." & Chr(13) & Chr(13) _
               & "NOMBRE   :  " & TxtNomCli.Text & " " & TxtApeCli.Text & Chr(13) _
               & "CODIGO   :  " & strIdCli, vbInformation, "Actualizar Cliente")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        BtnGuardaActualCancelCambia() 'ACTIVAMOS y DESACTIVAMOS LOS BOTONES

        BtnNuevo.Focus() 'ENVIAMOS EL ENFOQUE AL BOTON NUEVO

        TxtDesactivar() 'DESACTIVAR CUADROS DE TEXTO
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        'LIMPIAR O LLENAR LOS CUADROS DE TEXTBOX
        If SlblTitulo.Text = "Nuevo Cliente" Then
            TxtLimpiar() 'LIMPIAR TEXTBOX
            BtnNuevo.Focus() 'ENVIAMOS ENFOQUE AL BtnNuevo
        Else
            TxtLlenar() 'LLENAR TEXTBOX
            BtnModificar.Focus() 'ENVIAMOS ENFOQUE AL BtnEditar
        End If

        TxtDesactivar() 'DESACTIVAR LOS CUADROS DE TEXTBOX

        BtnGuardaActualCancelCambia() 'ACTIVAMOS y DESACTIVAMOS LOS BOTONES
    End Sub

    Private Sub BtnPagarMes_Click(sender As Object, e As EventArgs) Handles BtnPagarMes.Click

        'COMPROBAMOS SI EL MES SELECCIONADO YA ESTÁ PAGADO
        If DgvListaPagos.CurrentRow.Cells(7).Value = "--/--/----" Then
            txtFlags = "UPDATE_PAY"
            'ENVIAMOS LOS DATOS DEL MES AL FORMULARIO PAGOS
            'FrmPagoMensual.MdiParent = FrmPrincipal
            FrmPagoMensual.psIdPgs = DgvListaPagos.CurrentRow.Cells(0).Value.ToString 'ID_PAGO
            FrmPagoMensual.LblCliente.Text = TxtNomCli.Text & " " & TxtApeCli.Text & " - " & TxtEdaCli.Text 'NOMBRE, APELLIDO y EDAD
            FrmPagoMensual.DtpFdi.Value = DgvListaPagos.CurrentRow.Cells(1).Value.ToString 'FECHA DE INICIO DE MES
            FrmPagoMensual.TxtPrecio.Text = DgvListaPagos.CurrentRow.Cells(2).Value.ToString 'PRECIO
            FrmPagoMensual.TxtDscto.Text = DgvListaPagos.CurrentRow.Cells(3).Value.ToString 'DESCUENTO
            FrmPagoMensual.ShowDialog()
        Else
            MsgBox("YA ESTA, SELECT OTRO")
        End If

    End Sub

    Private Sub BtnNuevoPago_Click(sender As Object, e As EventArgs) Handles BtnNuevoPago.Click

        Dim precio, descto As Decimal
        Try
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()
            sqlConsulta = "SELECT * FROM tarifas WHERE e_min <= '" & TxtEdaCli.Text & "' AND e_max >= '" & TxtEdaCli.Text & "'"
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

        txtFlags = "UPDATE_PAY"
        FrmPagoMensual.Text = "Nuevo pago mensual"
        'FrmPagoMensual.MdiParent = FrmPrincipal
        FrmPagoMensual.psIdCli = DgvListaClientes.CurrentRow.Cells(0).Value.ToString 'ID CLIENTE
        FrmPagoMensual.LblCliente.Text = TxtNomCli.Text & " " & TxtApeCli.Text & " - " & TxtEdaCli.Text 'NOMBRE, APELLIDO y EDAD
        FrmPagoMensual.DtpFdi.Value = DateTime.Now 'FECHA DE INICIO DE MES
        FrmPagoMensual.TxtPrecio.Text = precio & " €"
        FrmPagoMensual.TxtDscto.Text = descto & " €"
        FrmPagoMensual.ShowDialog()
    End Sub

    Private Sub BtnCerrar_Click_1(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub

    ''---------->>>>>>>>>> PROCEDIMIENTOS <<<<<<<<<<----------''
    Sub TxtLostFocus(ByVal TxtCadena As TextBox)
        TxtCadena.Text = Trim(TxtCadena.Text)
        While TxtCadena.Text.Contains("  ")
            TxtCadena.Text = TxtCadena.Text.Replace("  ", " ")
        End While
        TxtCadena.BackColor = Color.Beige
        If TxtCadena.Text = "" Then TxtCadena.BackColor = Color.MistyRose
        If SlblTitulo.Text = "Buscar Cliente" Then TxtCadena.BackColor = Color.Beige
    End Sub

    Sub TxtLimpiar()
        idClient = ""
        txtFlags = ""
        TxtNomCli.Clear()
        TxtApeCli.Clear()
        DtpFdnCli.Value = New DateTime(2000, 1, 1)
        TxtEdaCli.Clear()
        TxtTlfCli.Clear()
        TxtEmlCli.Clear()
        TxtDirCli.Clear()
        DtpFdiCli.Value = DateTime.Now
        TxtStdCli.Clear()
        DgvListaPagos.Rows.Clear()
    End Sub

    Sub TxtLlenar()
        idClient = DgvListaClientes.CurrentRow.Cells(0).Value
        TxtNomCli.Text = DgvListaClientes.CurrentRow.Cells(1).Value
        TxtApeCli.Text = DgvListaClientes.CurrentRow.Cells(2).Value
        DtpFdnCli.Value = DgvListaClientes.CurrentRow.Cells(3).Value
        TxtTlfCli.Text = DgvListaClientes.CurrentRow.Cells(4).Value
        TxtEmlCli.Text = DgvListaClientes.CurrentRow.Cells(5).Value
        TxtDirCli.Text = DgvListaClientes.CurrentRow.Cells(6).Value
        DtpFdiCli.Value = DgvListaClientes.CurrentRow.Cells(7).Value

        If DgvListaClientes.CurrentRow.Cells(8).Value = "SI" Then
            TxtStdCli.Text = "En Actividad"
            TxtStdCli.ForeColor = Color.MediumBlue
            TxtStdCli.Font = New Font(TxtStdCli.Font, FontStyle.Regular)
        Else
            TxtStdCli.Text = "Inactivo"
            TxtStdCli.ForeColor = Color.Red
            TxtStdCli.Font = New Font(TxtStdCli.Font, FontStyle.Bold)
        End If
    End Sub

    Sub TxtActivar()
        TxtNomCli.Enabled = True
        TxtApeCli.Enabled = True
        DtpFdnCli.Enabled = True
        TxtEdaCli.Enabled = True
        TxtTlfCli.Enabled = True
        TxtEmlCli.Enabled = True
        TxtDirCli.Enabled = True
        DtpFdiCli.Enabled = True
        TxtStdCli.Enabled = True
        TxtNomCli.BackColor = Color.Beige
        TxtApeCli.BackColor = Color.Beige
        TxtEdaCli.BackColor = Color.Beige
        TxtTlfCli.BackColor = Color.Beige
        TxtEmlCli.BackColor = Color.Beige
        TxtDirCli.BackColor = Color.Beige
        TxtStdCli.BackColor = Color.Beige
    End Sub

    Sub TxtDesactivar()
        TxtNomCli.Enabled = False
        TxtApeCli.Enabled = False
        DtpFdnCli.Enabled = False
        TxtEdaCli.Enabled = False
        TxtTlfCli.Enabled = False
        TxtEmlCli.Enabled = False
        TxtDirCli.Enabled = False
        DtpFdiCli.Enabled = False
        TxtStdCli.Enabled = False
        TxtNomCli.BackColor = Color.FromArgb(198, 205, 215)
        TxtApeCli.BackColor = Color.FromArgb(198, 205, 215)
        TxtEdaCli.BackColor = Color.FromArgb(198, 205, 215)
        TxtTlfCli.BackColor = Color.FromArgb(198, 205, 215)
        TxtEmlCli.BackColor = Color.FromArgb(198, 205, 215)
        TxtDirCli.BackColor = Color.FromArgb(198, 205, 215)
        TxtStdCli.BackColor = Color.FromArgb(198, 205, 215)
    End Sub

    Sub BtnNuevoEditar()
        BtnNuevo.Visible = False
        BtnModificar.Visible = False
        BtnEliminar.Visible = False
        BtnCambiar.Visible = False
        BtnCancelar.Visible = True
        BtnBuscar.Visible = False
        RbSiCli.Enabled = False
        RbNoCli.Enabled = False
        BtnPagarMes.Visible = False
        BtnNuevoPago.Visible = False
        DgvListaClientes.Enabled = False
        DgvListaPagos.Enabled = False

        If SlblTitulo.Text = "Nuevo Cliente" Then
            BtnGuardar.Visible = True
            BtnActualizar.Visible = False
        Else
            BtnGuardar.Visible = False
            BtnActualizar.Visible = True
        End If
    End Sub

    Sub BtnGuardaActualCancelCambia()

        BtnNuevo.Visible = True
        BtnModificar.Visible = True
        BtnEliminar.Visible = True
        BtnCambiar.Visible = True
        BtnGuardar.Visible = False
        BtnActualizar.Visible = False
        BtnCancelar.Visible = False
        BtnBuscar.Visible = True
        RbSiCli.Enabled = True
        RbNoCli.Enabled = True
        BtnPagarMes.Visible = True
        BtnNuevoPago.Visible = True
        DgvListaClientes.Enabled = True
        DgvListaPagos.Enabled = True

        If DgvListaClientes.RowCount = 0 Then
            BtnModificar.Visible = False
            BtnEliminar.Visible = False
            BtnCambiar.Visible = False
            BtnBuscar.Visible = False
            SlblTitulo.Text = "Lista vacia"
            SlblDescrip.Text = " No hay clientes registrados en la Base de Datos."
        Else
            If txtFlags = "UPDATE" Then
                SlblTitulo.Text = "Cliente Encontrado"
                SlblDescrip.Text = " Puedes modificar sus datos, hacer pagos o cambiar su estado."
            Else
                SlblTitulo.Text = "Nº de Registros"
                SlblDescrip.Text = " " & DgvListaClientes.RowCount & " - Cliente(s) registrado(s) en la Base de Datos."
            End If
        End If

        If DgvListaPagos.RowCount = 0 Then
            BtnPagarMes.Visible = False
            BtnNuevoPago.Visible = False
        End If
    End Sub

    Sub DgvLlenarClientes(ByVal strConsulta As String)
        Try
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader
            DgvListaClientes.Rows.Clear()

            If drDataReader.HasRows Then
                While drDataReader.Read()
                    nRow = DgvListaClientes.Rows.Add()
                    DgvListaClientes.Rows(nRow).Cells(0).Value = drDataReader.GetInt16(0).ToString 'ID_CLIENTE
                    DgvListaClientes.Rows(nRow).Cells(1).Value = drDataReader.GetString(1).ToString 'NOMBRE
                    DgvListaClientes.Rows(nRow).Cells(2).Value = drDataReader.GetString(2).ToString 'APELLIDO
                    DgvListaClientes.Rows(nRow).Cells(3).Value = drDataReader.GetDateTime(3).ToShortDateString 'FECHA DE NACIMIENTO
                    DgvListaClientes.Rows(nRow).Cells(4).Value = drDataReader.GetString(4).ToString 'TELEFONO
                    DgvListaClientes.Rows(nRow).Cells(5).Value = drDataReader.GetString(5).ToString 'E-MAIL
                    DgvListaClientes.Rows(nRow).Cells(6).Value = drDataReader.GetString(6).ToString 'DIRECCION
                    DgvListaClientes.Rows(nRow).Cells(7).Value = drDataReader.GetDateTime(7).ToShortDateString 'FECHA DE INSCRIPCION
                    DgvListaClientes.Rows(nRow).Cells(8).Value = drDataReader.GetString(8).ToString 'ESTADO
                End While
            End If

            drDataReader.Close()
            cnxnMySql.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class