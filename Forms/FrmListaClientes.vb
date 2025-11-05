Imports MySql.Data.MySqlClient

Public Class FrmListaClientes

    Dim cnxnMySql As New MySqlConnection
    Dim drDataReader As MySqlDataReader
    Dim cmdCommand As MySqlCommand
    Dim sqlConsulta As String
    Dim intMsgBox As Int16

    Private Sub ListaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'COMPROBAR QUE RADIO BUTTON ESTA ACTIVO YBHACER CONSULTA A LA BBDD
        If RbActivo.Checked Then
            sqlConsulta = "SELECT * FROM clientes WHERE std_cli = 'ACTIVO' ORDER BY nom_cli"
        Else
            sqlConsulta = "SELECT * FROM clientes WHERE std_cli = 'INACTIVO' ORDER BY nom_cli"
        End If

        ListaClientes(sqlConsulta, "", DgvListaClientes) 'LLAMAR FUNCION Y PASAR LA CONSULTA

        'MARCAMOS LA PRIMERA OPCIÓN DEL COMBOBOX Y CAMBIAR TEXTO A LA BARRA DE ESTADO
        CmbBuscar.SelectedIndex = 0
        SlblMensaje.Text = " " & DgvListaClientes.RowCount & " - Cliente(s) registrado(s) en la Base de Datos"
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        FrmNuevoEditarCliente.MdiParent = FrmPrincipal 'HACEMOS AL FORM FrmNuevoEditarCliente COMO HIJO DE FrmPrincipal

        FrmNuevoEditarCliente.Text = "Registrar nuevo cliente" 'CAMBIAR TÍTULO DEL FORM FrmNuevoEditarCliente

        FrmNuevoEditarCliente.Show() 'MOSTRAR FORM FrmNuevoEditarCliente
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        'COMPROBAMOS SI HAY REGISTROS EN EL DgvListaClientes
        If DgvListaClientes.RowCount = 0 Then MsgBox("No se puede EDITAR los datos del cliente." & Chr(13) &
                                                     "Agrega un NUEVO registro, para buscar, editar o eliminar." _
                                                     , vbInformation, "Editar datos del cliente") : BtnNuevo.Focus() : Exit Sub

        FrmNuevoEditarCliente.MdiParent = FrmPrincipal 'HACEMOS AL FORM FrmNuevoEditarCliente COMO HIJO DE FrmPrincipal

        FrmNuevoEditarCliente.Text = "Modificar datos del cliente" 'CAMBIAR TÍTULO DEL FORM FrmNuevoEditarCliente

        'PASAMOS TODOS LOS DATOS DEL CLIENTE AL FORM FrmNuevoEditarCliente
        FrmNuevoEditarCliente.TxtNombre.Text = DgvListaClientes.CurrentRow.Cells(0).Value.ToString 'NOMBRE
        FrmNuevoEditarCliente.TxtApellido.Text = DgvListaClientes.CurrentRow.Cells(1).Value.ToString 'APELLIDO
        FrmNuevoEditarCliente.DtpFdn.Value = DgvListaClientes.CurrentRow.Cells(3).Value.ToString 'FECHA DE NACIMIENTO
        FrmNuevoEditarCliente.TxtTelefono.Text = DgvListaClientes.CurrentRow.Cells(4).Value.ToString 'TELÉFONO
        FrmNuevoEditarCliente.TxtEmail.Text = DgvListaClientes.CurrentRow.Cells(5).Value.ToString 'E-MAIL
        FrmNuevoEditarCliente.TxtDireccion.Text = DgvListaClientes.CurrentRow.Cells(6).Value.ToString 'DIRECCIÓN
        FrmNuevoEditarCliente.DtpFdi.Value = DgvListaClientes.CurrentRow.Cells(7).Value.ToString 'FECHA DE INSCRIPCIÓN
        FrmNuevoEditarCliente.strIdClient = DgvListaClientes.CurrentRow.Cells(8).Value.ToString ' ID DEL CLIENTE

        FrmNuevoEditarCliente.Show() 'MOSTRAR FORM FrmNuevoEditarCliente
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        'COMPROBAR SI HAY REGISTROS EN EL DgvListaClientes
        If DgvListaClientes.RowCount = 0 Then MsgBox("No se puede ELIMINAR los datos del cliente." & Chr(13) & Chr(13) &
                                                     "Agrega un NUEVO registro, para buscar, editar, eliminar o cambiar de estado." _
                                                     , vbInformation, "Eliminar registro del cliente") : BtnNuevo.Focus() : Exit Sub

        'CAMBIAMOS LOS TEXTOS DE LA BARRA DE ESTADO
        SlblTitulo.Text = "Eliminar Cliente"
        SlblMensaje.Text = " ¿Desea eliminar al cliente seleccionado?."

        Try
            'CONECTAR Y ABRIR LA BBDD
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()

            'FORMATO AL CODIGO DEL CLIENTE
            Dim strIdCli = DgvListaClientes.CurrentRow.Cells(8).Value.ToString
            If strIdCli.Length = 1 Then strIdCli = "CLI - 00" & strIdCli
            If strIdCli.Length = 2 Then strIdCli = "CLI - 0" & strIdCli
            If strIdCli.Length = 3 Then strIdCli = "CLI - " & strIdCli

            'MENSAJE DE CONFIRMACIÓN PARA ELIMINAR UN CLIENTE
            If MsgBox("CLIENTE SELECCIONADO :" & Chr(13) & Chr(13) &
                      "     NOMBRE  :  " & DgvListaClientes.CurrentRow.Cells(0).Value.ToString & " " & DgvListaClientes.CurrentRow.Cells(1).Value.ToString & Chr(13) &
                      "     CODIGO  :  " & strIdCli & Chr(13) & Chr(13) &
                      "Si elimina el registro, tambien se borraran todos los" & Chr(13) &
                      "pagos relacionados al cliente." & Chr(13) & Chr(13) &
                      "                                                       ¿Estás seguro?" _
                      , vbQuestion + vbYesNo + vbDefaultButton2, "Eliminar Cliente") = vbYes Then

                'HACEMOS Y EJECUTAMOS LA CONSULTA A LA BBDD
                sqlConsulta = "DELETE FROM clientes WHERE id_cli = '" & DgvListaClientes.CurrentRow.Cells(8).Value.ToString & "'"
                cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                drDataReader = cmdCommand.ExecuteReader
                drDataReader.Close()

                'COMPROBACION PARA CAMBIAR TEXTO DE LA BARRA DE ESTADO
                If TxtBuscarCliente.Text <> "" Then
                    TxtBuscarCliente.Clear()
                Else
                    DgvListaClientes.Rows.Remove(DgvListaClientes.CurrentRow)
                    SlblTitulo.Text = "Nº de Registros"
                    SlblMensaje.Text = " " & DgvListaClientes.RowCount & " - Cliente(s) registrado(s) en la Base de Datos"
                End If
            Else
                'COMPROBACION PARA CAMBIAR TEXTO DE LA BARRA DE ESTADO
                If TxtBuscarCliente.Text = "" Then
                    SlblTitulo.Text = "Nº de Registros"
                    SlblMensaje.Text = " " & DgvListaClientes.RowCount & " - Cliente(s) registrado(s) en la Base de Datos"
                Else
                    SlblTitulo.Text = "Buscar Cliente"
                    SlblMensaje.Text = " " & DgvListaClientes.RowCount & " - Registro(s) que coincide(n) con su búsqueda."
                End If
            End If

            cnxnMySql.Close() 'CERRAMOS LA BBDD

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        TxtBuscarCliente.Focus() 'ENVIAMOS EL ENFOQUE AL TEXTBOX
    End Sub

    Private Sub BtnCambiarEstado_Click(sender As Object, e As EventArgs) Handles BtnCambiarEstado.Click

        'COMPROBAR SI HAY REGISTROS EN EL DgvListaClientes
        If DgvListaClientes.RowCount = 0 Then MsgBox("No se puede CAMBIAR el estado del cliente." & Chr(13) & Chr(13) &
                                                     "Agrega un NUEVO registro, para buscar, editar, eliminar o cambiar de estado." _
                                                     , vbInformation, "Cambiar estado") : BtnNuevo.Focus() : Exit Sub

        'CAMBIAMOS LOS TEXTOS DE LA BARRA DE ESTADO
        SlblTitulo.Text = "Cambiar estado"
        SlblMensaje.Text = " ¿Desea cambiar el estado del cliente seleccionado?."

        Try
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()

            'FORMATO AL CODIGO DEL CLIENTE
            Dim strIdCli = DgvListaClientes.CurrentRow.Cells(8).Value.ToString
            If strIdCli.Length = 1 Then strIdCli = "CLI - 00" & strIdCli
            If strIdCli.Length = 2 Then strIdCli = "CLI - 0" & strIdCli
            If strIdCli.Length = 3 Then strIdCli = "CLI - " & strIdCli

            'MENSAJE DE CONFIRMACIÓN PARA CAMBIAR DE ESTADO UN CLIENTE
            If MsgBox("CLIENTE SELECCIONADO :" & Chr(13) & Chr(13) &
                      "     NOMBRE  :  " & DgvListaClientes.CurrentRow.Cells(0).Value.ToString & " " & DgvListaClientes.CurrentRow.Cells(1).Value.ToString & Chr(13) &
                      "     CODIGO  :  " & strIdCli & Chr(13) & Chr(13) &
                      "Vas a cambiar el estado del cliente." & Chr(13) &
                      "Si pasa a INACTIVIDAD no se podra realizar nuevos pagos." & Chr(13) & Chr(13) &
                      "                                                       ¿Estás seguro?" _
                      , vbQuestion + vbYesNo + vbDefaultButton2, "Cambiar estado") = vbYes Then

                'HACEMOS Y EJECUTAMOS LA CONSULTA A LA BBDD
                If RbActivo.Checked = True Then
                    sqlConsulta = "UPDATE clientes SET std_cli = 'NO' WHERE id_cli = '" & DgvListaClientes.CurrentRow.Cells(8).Value.ToString & "'"
                Else
                    sqlConsulta = "UPDATE clientes SET std_cli = 'SI' WHERE id_cli = '" & DgvListaClientes.CurrentRow.Cells(8).Value.ToString & "'"
                End If
                cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                drDataReader = cmdCommand.ExecuteReader

                'COMPROBACION PARA CAMBIAR TEXTO DE LA BARRA DE ESTADO
                If TxtBuscarCliente.Text <> "" Then
                    TxtBuscarCliente.Clear()
                Else
                    DgvListaClientes.Rows.Remove(DgvListaClientes.CurrentRow)
                    SlblTitulo.Text = "Nº de Registros"
                    SlblMensaje.Text = " " & DgvListaClientes.RowCount & " - Cliente(s) registrado(s) en la Base de Datos"
                End If
            Else
                'COMPROBACION PARA CAMBIAR TEXTO DE LA BARRA DE ESTADO
                If TxtBuscarCliente.Text = "" Then
                    SlblTitulo.Text = "Nº de Registros"
                    SlblMensaje.Text = " " & DgvListaClientes.RowCount & " - Cliente(s) registrado(s) en la Base de Datos"
                Else
                    SlblTitulo.Text = "Buscar Cliente"
                    SlblMensaje.Text = " " & DgvListaClientes.RowCount & " - Registro(s) que coincide(n) con su búsqueda."
                End If
            End If

            cnxnMySql.Close() 'CERRAMOS LA BBDD

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        TxtBuscarCliente.Focus() 'ENVIAMOS EL ENFOQUE AL TEXTBOX
    End Sub

    Private Sub BtnHistorialPagos_Click(sender As Object, e As EventArgs) Handles BtnHistorialPagos.Click

        'COMPROBAR SI HAY REGISTROS EN LA GRILLA DgvListaClientes
        If DgvListaClientes.RowCount = 0 Then Exit Sub

        'ENVIAMOS LOS DATOS AL FORM FrmHistorialPagos PARA REALIZAR EL PAGO
        FrmHistorialPagos.MdiParent = FrmPrincipal
        FrmHistorialPagos.psIdCli = DgvListaClientes.CurrentRow.Cells(8).Value.ToString
        FrmHistorialPagos.TxtCliente.Text = DgvListaClientes.CurrentRow.Cells(0).Value.ToString & " " & DgvListaClientes.CurrentRow.Cells(1).Value.ToString
        FrmHistorialPagos.TxtInscripcion.Text = DgvListaClientes.CurrentRow.Cells(7).Value.ToString
        'COMPROBAR SI EL CLIENTE ESTA EN ACTIVIDAD O INACTIVIDAD
        If DgvListaClientes.CurrentRow.Cells(9).Value.ToString = "SI" Then
            FrmHistorialPagos.TxtEstado.Text = "EN ACTIVIDAD"
        Else
            FrmHistorialPagos.TxtEstado.ForeColor = Color.Red
            FrmHistorialPagos.TxtEstado.Text = "INACTIVO"
        End If
        FrmHistorialPagos.TxtEdad.Text = DgvListaClientes.CurrentRow.Cells(2).Value.ToString

        FrmHistorialPagos.Show() 'MOSTRAMOS EL FORM
    End Sub

    Private Sub BtnNuevoPago_Click(sender As Object, e As EventArgs) Handles BtnNuevoPago.Click
        'COMPROBAR SI HAY REGISTROS EN LA GRILLA
        If DgvListaClientes.RowCount = 0 Then Exit Sub

        'VARIABLES PARA ALMACENAR EL PRECIO Y EL DSCTO
        Dim precio, descto As Decimal

        Try
            'CONECTAR Y ABRIR BBDD
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()

            'SELECCIONAMOS EL DESCUENTO CORRESPONDIENTE A LA EDAD
            Dim iEdad = DgvListaClientes.CurrentRow.Cells(2).Value.ToString.Substring(0, 2)
            sqlConsulta = "SELECT * FROM tarifas WHERE e_min <= '" & iEdad & "' AND e_max >= '" & iEdad & "'"
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

        'ALMACENAR EN LAS VARIBLES LOS DATOS DE LOS CLIENTES
        Dim nombre = DgvListaClientes.CurrentRow.Cells(0).Value.ToString
        Dim apellido = DgvListaClientes.CurrentRow.Cells(1).Value.ToString
        Dim edad = DgvListaClientes.CurrentRow.Cells(2).Value.ToString

        'ENVIAMOS LOS DATOS AL FORM FrmPagoMensual PARA EL NUEVO PAGO
        FrmPagoMensual.Text = "Nuevo pago mensual"
        FrmPagoMensual.MdiParent = FrmPrincipal
        FrmPagoMensual.psIdCli = DgvListaClientes.CurrentRow.Cells(8).Value.ToString
        FrmPagoMensual.LblCliente.Text = nombre & " " & apellido & " - " & edad 'NOMBRE, APELLIDO y EDAD
        FrmPagoMensual.DtpFdi.Value = DateTime.Now 'FECHA DE INICIO DE MES
        FrmPagoMensual.TxtPrecio.Text = precio & " €"
        FrmPagoMensual.TxtDscto.Text = descto & " €"

        FrmPagoMensual.Show() 'MOSTRAR EL FORM
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub

    Private Sub CmbBuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBuscar.SelectedIndexChanged
        '
        TxtBuscarCliente.Focus()
        '
        If DgvListaClientes.RowCount = 0 Then Exit Sub
        Select Case CmbBuscar.Text
            Case "Nombre"
                '
                DgvListaClientes.CurrentCell = DgvListaClientes.Item(0, 0)
                '
            Case "Apellido"
                '
                DgvListaClientes.CurrentCell = DgvListaClientes.Item(1, 0)
                '
            Case "Teléfono"
                '
                DgvListaClientes.CurrentCell = DgvListaClientes.Item(4, 0)
                '
        End Select
    End Sub

    Private Sub TxtBuscarCliente_GotFocus(sender As Object, e As EventArgs) Handles TxtBuscarCliente.GotFocus
        '
        If TxtBuscarCliente.TextLength = 0 Then Exit Sub
        TxtBuscarCliente.SelectAll()
        TxtBuscarCliente.Cut()
        TxtBuscarCliente.Paste()
    End Sub

    Private Sub TxtBuscarCliente_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarCliente.TextChanged

        'COMPROBAR EL TIPO DE CARACTERES PARA EVITAR ERRORES AL BUSCAR
        If TxtBuscarCliente.Text.Contains("'") Or TxtBuscarCliente.Text.Contains("º") Or TxtBuscarCliente.Text.Contains("ª") Or TxtBuscarCliente.Text.Contains("ç") Or TxtBuscarCliente.Text.Contains("Ç") Or
           TxtBuscarCliente.Text.Contains("%") Or TxtBuscarCliente.Text.Contains("_") Then DgvListaClientes.Rows.Clear() : SlblMensaje.Text = " 0 - Registro(s) que coincide(n) con su búsqueda." : Exit Sub

        'HACER LA CONSULTA SEGÚN EL CRITERIO DE BUSQUEDA
        Select Case CmbBuscar.Text
            Case "Nombre"
                If RbActivo.Checked Then
                    sqlConsulta = "SELECT * FROM clientes WHERE nom_cli LIKE '" & TxtBuscarCliente.Text & "%' AND std_cli = 'SI' ORDER BY nom_cli"
                Else
                    sqlConsulta = "SELECT * FROM clientes WHERE nom_cli LIKE '" & TxtBuscarCliente.Text & "%' AND std_cli = 'NO' ORDER BY nom_cli"
                End If

            Case "Apellido"
                If RbActivo.Checked Then
                    sqlConsulta = "SELECT * FROM clientes WHERE ape_cli LIKE '" & TxtBuscarCliente.Text & "%' AND std_cli = 'SI' ORDER BY ape_cli"
                Else
                    sqlConsulta = "SELECT * FROM clientes WHERE ape_cli LIKE '" & TxtBuscarCliente.Text & "%' AND std_cli = 'NO' ORDER BY ape_cli"
                End If

            Case "Teléfono"
                If RbActivo.Checked Then
                    sqlConsulta = "SELECT * FROM clientes WHERE tlf_cli LIKE '" & TxtBuscarCliente.Text & "%' AND std_cli = 'SI' ORDER BY tlf_cli"
                Else
                    sqlConsulta = "SELECT * FROM clientes WHERE tlf_cli LIKE '" & TxtBuscarCliente.Text & "%' AND std_cli = 'NO' ORDER BY tlf_cli"
                End If
        End Select

        'LLAMAMOS A LA FUNCIÓN ListaClientes Y LE PASAMOS LA CONSULTA
        ListaClientes(sqlConsulta, CmbBuscar.Text, DgvListaClientes)

        'HACER COMPROBACIONES PARA MOSTRAR TEXTO EN EL STATUSBAR
        If TxtBuscarCliente.Text = "" Then
            SlblTitulo.Text = "Nº de Registros"
            SlblMensaje.Text = " " & DgvListaClientes.RowCount & " - Cliente(s) registrado(s) en la Base de Datos"
        Else
            SlblTitulo.Text = "Buscar Cliente"
            SlblMensaje.Text = " " & DgvListaClientes.RowCount & " - Registro(s) que coincide(n) con su búsqueda."
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        'LIMPIAR TEXTBOX Y ENVIAR ENFOQUE
        TxtBuscarCliente.Clear()
        TxtBuscarCliente.Focus()
    End Sub

    Private Sub RbActivo_Click(sender As Object, e As EventArgs) Handles RbActivo.Click
        'ENVIAR TEXTO PARA SIMULAR BUSQUEDA, LIMPIAR TEXTO Y ENVIAR ENFOQUE
        TxtBuscarCliente.Text = "a" : TxtBuscarCliente.Clear() : TxtBuscarCliente.Focus()

        'ACIVAR BUTTON BtnNuevoPago
        BtnNuevoPago.Enabled = True
    End Sub

    Private Sub RbNoActivo_Click(sender As Object, e As EventArgs) Handles RbNoActivo.Click
        'ENVIAR TEXTO PARA SIMULAR BUSQUEDA, LIMPIAR TEXTO Y ENVIAR ENFOQUE
        TxtBuscarCliente.Text = "a" : TxtBuscarCliente.Clear() : TxtBuscarCliente.Focus()

        'DESACIVAR BUTTON BtnNuevoPago
        BtnNuevoPago.Enabled = False
    End Sub

End Class