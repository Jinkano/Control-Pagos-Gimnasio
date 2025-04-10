Imports MySql.Data.MySqlClient

Public Class FrmListaClientes

    Dim cnxnMySql As New MySqlConnection
    Dim drDataReader As MySqlDataReader
    Dim cmdCommand As MySqlCommand
    Dim sqlConsulta As String
    Dim intMsgBox As Int16

    Private Sub ListaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        If RbActivo.Checked Then
            sqlConsulta = "SELECT * FROM clientes WHERE std_cli = 'SI' ORDER BY nom_cli"
        Else
            sqlConsulta = "SELECT * FROM clientes WHERE std_cli = 'NO' ORDER BY nom_cli"
        End If
        '
        ListaClientes(sqlConsulta, "", DgvListaClientes)
        '
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
        FrmNuevoEditarCliente.strIdCli = DgvListaClientes.CurrentRow.Cells(8).Value.ToString ' ID DEL CLIENTE

        FrmNuevoEditarCliente.Show() 'MOSTRAR FORM FrmNuevoEditarCliente
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        '    '
        '    If DgvListaClientes.RowCount = 0 Then MsgBox("No se puede ELIMINAR los datos del cliente." & Chr(13) & "Agrega un NUEVO registro, para buscar, editar o eliminar." _
        '                                                 , vbInformation, "Eliminar registro del cliente") : BtnNuevo.Focus() : Exit Sub
        '    '
        '    'CAMBIAMOS LOS TEXTOS DE LA BARRA DE ESTADO
        '    SlblTitulo.Text = "Eliminar Cliente"
        '    SlblMensaje.Text = " ¿Desea eliminar al cliente seleccionado?."
        '    '
        '    Try
        '        '
        '        cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
        '        cnxnMySql.Open()
        '        '
        '        Dim strIdCli = DgvListaClientes.CurrentRow.Cells(8).Value.ToString
        '        If strIdCli.Length = 1 Then strIdCli = "CLI-00" & strIdCli
        '        If strIdCli.Length = 2 Then strIdCli = "CLI-0" & strIdCli
        '        If strIdCli.Length = 3 Then strIdCli = "CLI-" & strIdCli
        '        'MENSAJE DE CONFIRMACIÓN PARA ELIMINAR O PASAR A INACTIVIDAD UN CLIENTE
        '        intMsgBox = MsgBox("¿Desea eliminar al cliente?" & Chr(13) & Chr(13) _
        '                    & "NOMBRE  :  " & DgvListaClientes.CurrentRow.Cells(0).Value.ToString & " " & DgvListaClientes.CurrentRow.Cells(1).Value.ToString & Chr(13) _
        '                    & "CODIGO  :  " & strIdCli & "", vbQuestion + vbYesNoCancel, "Eliminar Cliente")
        '        '
        '        If intMsgBox = vbYes Then
        '            '
        '            sqlConsulta = "DELETE FROM clientes WHERE id_cli = '" & DgvListaClientes.CurrentRow.Cells(8).Value.ToString & "'"
        '            '
        '        ElseIf intMsgBox = vbNo Then
        '            '
        '            If RbActivo.Checked = True Then
        '                '
        '                sqlConsulta = "UPDATE clientes SET std_cli = 'NO' WHERE id_cli = '" & DgvListaClientes.CurrentRow.Cells(8).Value.ToString & "'"
        '            Else
        '                '
        '                sqlConsulta = "UPDATE clientes SET std_cli = 'SI' WHERE id_cli = '" & DgvListaClientes.CurrentRow.Cells(8).Value.ToString & "'"
        '            End If
        '        End If
        '        '
        '        cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
        '        drDataReader = cmdCommand.ExecuteReader
        '        '
        '        drDataReader.Close()
        '        cnxnMySql.Close()
        '        '
        '    Catch ex As Exception
        '        '
        '        MsgBox(ex.ToString)
        '        '
        '    End Try
        '    '
        '    If intMsgBox = vbYes Or intMsgBox = vbNo Then
        '        '
        '        If TxtBuscarCliente.Text <> "" Then
        '            '
        '            TxtBuscarCliente.Clear()
        '        Else
        '            DgvListaClientes.Rows.Remove(DgvListaClientes.CurrentRow)
        '            SlblTitulo.Text = "Nº de Registros"
        '            SlblMensaje.Text = " " & DgvListaClientes.RowCount & " - Cliente(s) registrado(s) en la Base de Datos"
        '            '
        '        End If
        '        '
        '    Else
        '        If TxtBuscarCliente.Text = "" Then
        '            SlblTitulo.Text = "Nº de Registros"
        '            SlblMensaje.Text = " " & DgvListaClientes.RowCount & " - Cliente(s) registrado(s) en la Base de Datos"
        '            '
        '        Else
        '            SlblTitulo.Text = "Buscar Cliente"
        '            SlblMensaje.Text = " " & DgvListaClientes.RowCount & " - Registro(s) que coincide(n) con su búsqueda."
        '            '
        '        End If
        '    End If
        '    '
        '    TxtBuscarCliente.Focus()
    End Sub

    Private Sub BtnCambiarEstado_Click(sender As Object, e As EventArgs) Handles BtnCambiarEstado.Click
        '    '
        '    If DgvListaClientes.RowCount = 0 Then MsgBox("No se puede ELIMINAR los datos del cliente." & Chr(13) & "Agrega un NUEVO registro, para buscar, editar o eliminar." _
        '                                                 , vbInformation, "Eliminar registro del cliente") : BtnNuevo.Focus() : Exit Sub
        '    '
        '    'CAMBIAMOS LOS TEXTOS DE LA BARRA DE ESTADO
        '    SlblTitulo.Text = "Eliminar Cliente"
        '    SlblMensaje.Text = " ¿Desea eliminar al cliente seleccionado?."
        '    '
        '    Try
        '        '
        '        cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
        '        cnxnMySql.Open()
        '        '
        '        Dim strIdCli = DgvListaClientes.CurrentRow.Cells(8).Value.ToString
        '        If strIdCli.Length = 1 Then strIdCli = "CLI-00" & strIdCli
        '        If strIdCli.Length = 2 Then strIdCli = "CLI-0" & strIdCli
        '        If strIdCli.Length = 3 Then strIdCli = "CLI-" & strIdCli
        '        'MENSAJE DE CONFIRMACIÓN PARA ELIMINAR O PASAR A INACTIVIDAD UN CLIENTE
        '        intMsgBox = MsgBox("¿Desea eliminar al cliente?" & Chr(13) & Chr(13) _
        '                    & "NOMBRE  :  " & DgvListaClientes.CurrentRow.Cells(0).Value.ToString & " " & DgvListaClientes.CurrentRow.Cells(1).Value.ToString & Chr(13) _
        '                    & "CODIGO  :  " & strIdCli & "", vbQuestion + vbYesNoCancel, "Eliminar Cliente")
        '        '
        '        If intMsgBox = vbYes Then
        '            '
        '            sqlConsulta = "DELETE FROM clientes WHERE id_cli = '" & DgvListaClientes.CurrentRow.Cells(8).Value.ToString & "'"
        '            '
        '        ElseIf intMsgBox = vbNo Then
        '            '
        '            If RbActivo.Checked = True Then
        '                '
        '                sqlConsulta = "UPDATE clientes SET std_cli = 'NO' WHERE id_cli = '" & DgvListaClientes.CurrentRow.Cells(8).Value.ToString & "'"
        '            Else
        '                '
        '                sqlConsulta = "UPDATE clientes SET std_cli = 'SI' WHERE id_cli = '" & DgvListaClientes.CurrentRow.Cells(8).Value.ToString & "'"
        '            End If
        '        End If
        '        '
        '        cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
        '        drDataReader = cmdCommand.ExecuteReader
        '        '
        '        drDataReader.Close()
        '        cnxnMySql.Close()
        '        '
        '    Catch ex As Exception
        '        '
        '        MsgBox(ex.ToString)
        '        '
        '    End Try
        '    '
        '    If intMsgBox = vbYes Or intMsgBox = vbNo Then
        '        '
        '        If TxtBuscarCliente.Text <> "" Then
        '            '
        '            TxtBuscarCliente.Clear()
        '        Else
        '            DgvListaClientes.Rows.Remove(DgvListaClientes.CurrentRow)
        '            SlblTitulo.Text = "Nº de Registros"
        '            SlblMensaje.Text = " " & DgvListaClientes.RowCount & " - Cliente(s) registrado(s) en la Base de Datos"
        '            '
        '        End If
        '        '
        '    Else
        '        If TxtBuscarCliente.Text = "" Then
        '            SlblTitulo.Text = "Nº de Registros"
        '            SlblMensaje.Text = " " & DgvListaClientes.RowCount & " - Cliente(s) registrado(s) en la Base de Datos"
        '            '
        '        Else
        '            SlblTitulo.Text = "Buscar Cliente"
        '            SlblMensaje.Text = " " & DgvListaClientes.RowCount & " - Registro(s) que coincide(n) con su búsqueda."
        '            '
        '        End If
        '    End If
        '    '
        '    TxtBuscarCliente.Focus()
    End Sub

    Private Sub BtnHistorialPagos_Click(sender As Object, e As EventArgs) Handles BtnHistorialPagos.Click

        If DgvListaClientes.RowCount = 0 Then Exit Sub
        FrmHistorialPagos.MdiParent = FrmPrincipal
        FrmHistorialPagos.psIdCli = DgvListaClientes.CurrentRow.Cells(8).Value.ToString
        FrmHistorialPagos.TxtCliente.Text = DgvListaClientes.CurrentRow.Cells(0).Value.ToString & " " & DgvListaClientes.CurrentRow.Cells(1).Value.ToString
        FrmHistorialPagos.TxtInscripcion.Text = DgvListaClientes.CurrentRow.Cells(7).Value.ToString
        '
        If DgvListaClientes.CurrentRow.Cells(9).Value.ToString = "SI" Then
            FrmHistorialPagos.TxtEstado.Text = "EN ACTIVIDAD"
        Else
            FrmHistorialPagos.TxtEstado.ForeColor = Color.Red
            FrmHistorialPagos.TxtEstado.Text = "INACTIVO"
        End If
        '
        FrmHistorialPagos.TxtEdad.Text = DgvListaClientes.CurrentRow.Cells(2).Value.ToString
        FrmHistorialPagos.Show()
    End Sub

    Private Sub BtnNuevoPago_Click(sender As Object, e As EventArgs) Handles BtnNuevoPago.Click
        If DgvListaClientes.RowCount = 0 Then Exit Sub
        '
        Dim precio, descto As Decimal
        '
        Try
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()
            '
            Dim iEdad = DgvListaClientes.CurrentRow.Cells(2).Value.ToString.Substring(0, 2)
            sqlConsulta = "SELECT * FROM tarifas WHERE e_min <= '" & iEdad & "' AND e_max >= '" & iEdad & "'"
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader
            drDataReader.Read()
            precio = Replace(drDataReader.GetDecimal(0).ToString, ",", ".")
            descto = Replace(drDataReader.GetDecimal(3).ToString, ",", ".")
            drDataReader.Close()
            '
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader
            '
            drDataReader.Close()
            cnxnMySql.Close()
            '
        Catch ex As Exception
            '
            MsgBox(ex.ToString)
            '
        End Try
        '
        Dim nombre = DgvListaClientes.CurrentRow.Cells(0).Value.ToString
        Dim apellido = DgvListaClientes.CurrentRow.Cells(1).Value.ToString
        Dim edad = DgvListaClientes.CurrentRow.Cells(2).Value.ToString
        FrmPagoMensual.Text = "Nuevo pago mensual"
        FrmPagoMensual.MdiParent = FrmPrincipal
        FrmPagoMensual.psIdCli = DgvListaClientes.CurrentRow.Cells(8).Value.ToString
        FrmPagoMensual.LblCliente.Text = nombre & " " & apellido & " - " & edad
        FrmPagoMensual.DtpFdi.Value = DateTime.Now
        FrmPagoMensual.TxtPrecio.Text = precio
        FrmPagoMensual.TxtDscto.Text = descto
        FrmPagoMensual.Show()
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
        '
        If TxtBuscarCliente.Text.Contains("'") Then DgvListaClientes.Rows.Clear() : SlblMensaje.Text = " 0 - Registro(s) que coincide(n) con su búsqueda." : Exit Sub
        If TxtBuscarCliente.Text.Contains("º") Then DgvListaClientes.Rows.Clear() : SlblMensaje.Text = " 0 - Registro(s) que coincide(n) con su búsqueda." : Exit Sub
        If TxtBuscarCliente.Text.Contains("ª") Then DgvListaClientes.Rows.Clear() : SlblMensaje.Text = " 0 - Registro(s) que coincide(n) con su búsqueda." : Exit Sub
        If TxtBuscarCliente.Text.Contains("ç") Then DgvListaClientes.Rows.Clear() : SlblMensaje.Text = " 0 - Registro(s) que coincide(n) con su búsqueda." : Exit Sub
        If TxtBuscarCliente.Text.Contains("Ç") Then DgvListaClientes.Rows.Clear() : SlblMensaje.Text = " 0 - Registro(s) que coincide(n) con su búsqueda." : Exit Sub
        If TxtBuscarCliente.Text.Contains("%") Then DgvListaClientes.Rows.Clear() : SlblMensaje.Text = " 0 - Registro(s) que coincide(n) con su búsqueda." : Exit Sub
        If TxtBuscarCliente.Text.Contains("_") Then DgvListaClientes.Rows.Clear() : SlblMensaje.Text = " 0 - Registro(s) que coincide(n) con su búsqueda." : Exit Sub
        '
        Select Case CmbBuscar.Text
                '
            Case "Nombre"
                '
                If RbActivo.Checked Then
                    sqlConsulta = "SELECT * FROM clientes WHERE nom_cli LIKE '" & TxtBuscarCliente.Text & "%' AND std_cli = 'SI' ORDER BY nom_cli"
                Else
                    sqlConsulta = "SELECT * FROM clientes WHERE nom_cli LIKE '" & TxtBuscarCliente.Text & "%' AND std_cli = 'NO' ORDER BY nom_cli"
                End If
                    '
            Case "Apellido"
                '
                If RbActivo.Checked Then
                    sqlConsulta = "SELECT * FROM clientes WHERE ape_cli LIKE '" & TxtBuscarCliente.Text & "%' AND std_cli = 'SI' ORDER BY ape_cli"
                Else
                    sqlConsulta = "SELECT * FROM clientes WHERE ape_cli LIKE '" & TxtBuscarCliente.Text & "%' AND std_cli = 'NO' ORDER BY ape_cli"
                End If
                '
            Case "Teléfono"
                '
                If RbActivo.Checked Then
                    sqlConsulta = "SELECT * FROM clientes WHERE tlf_cli LIKE '" & TxtBuscarCliente.Text & "%' AND std_cli = 'SI' ORDER BY tlf_cli"
                Else
                    sqlConsulta = "SELECT * FROM clientes WHERE tlf_cli LIKE '" & TxtBuscarCliente.Text & "%' AND std_cli = 'NO' ORDER BY tlf_cli"
                End If
        End Select
        '
        ListaClientes(sqlConsulta, CmbBuscar.Text, DgvListaClientes)
        '
        If TxtBuscarCliente.Text = "" Then
            SlblTitulo.Text = "Nº de Registros"
            SlblMensaje.Text = " " & DgvListaClientes.RowCount & " - Cliente(s) registrado(s) en la Base de Datos"
            '
        Else
            SlblTitulo.Text = "Buscar Cliente"
            SlblMensaje.Text = " " & DgvListaClientes.RowCount & " - Registro(s) que coincide(n) con su búsqueda."
            '
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        '
        TxtBuscarCliente.Clear()
        TxtBuscarCliente.Focus()
    End Sub

    Private Sub RbActivo_Click(sender As Object, e As EventArgs) Handles RbActivo.Click
        '
        TxtBuscarCliente.Text = "a" : TxtBuscarCliente.Clear() : TxtBuscarCliente.Focus()
    End Sub

    Private Sub RbNoActivo_Click(sender As Object, e As EventArgs) Handles RbNoActivo.Click
        '
        TxtBuscarCliente.Text = "a" : TxtBuscarCliente.Clear() : TxtBuscarCliente.Focus()
    End Sub

End Class