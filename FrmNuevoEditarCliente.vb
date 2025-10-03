Imports MySql.Data.MySqlClient

Public Class FrmNuevoEditarCliente

    Dim cnxnMySql As New MySqlConnection
    Dim drDataReader As MySqlDataReader
    Dim cmdCommand As MySqlCommand
    Dim sqlConsulta, strEstado, strMpago, strIdGrupo As String
    Dim nRow, intAddMember As Int16
    Dim blnAddMembers As Boolean
    Public Shared strIdCli As String

    Private Sub FrmNuevoEditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '' COMPROBAMOS EL TÍTULO PARA DESACTIVAR UN BOTON
        'If Me.Text = "Registrar nuevo cliente" Then
        '    BtnActualizar.Enabled = False
        'Else
        '    BtnGuardar.Enabled = False
        'End If

        'LIMPIAMOS EL DTPFDN CON UN ESPACIO EN BLANCO
        DtpFdn.CustomFormat = " "

        'VARIABLE PARA ALMACENAR LA FECHA ACTUAL
        Dim ano = Year(Date.Now)

        'ASIGNAR VALORES NIM Y MAX A LOS DATETIMEPICKER
        DtpFdn.MinDate = "01/01/" & ano - 90
        DtpFdn.MaxDate = DateTime.Now
        DtpFdn.Value = "01/07/" & ano - 25
        TxtEdad.Text = ""
        DtpFdi.MinDate = "01/01/" & ano - 1
        DtpFdi.MaxDate = "31/12/" & ano + 1
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        'COMPROBAMOS SI HAY INFORMACION DEL CLIENTE
        If TxtNombre.Text = "" Then
            MsgBox("Ingrese el NOMBRE del cliente.", vbCritical, "Comprobar datos")
            TxtNombre.Focus() : Exit Sub
        End If

        If TxtApellido.Text = "" Then
            MsgBox("Ingrese el APELLIDO del cliente.", vbCritical, "Comprobar datos")
            TxtApellido.Focus() : Exit Sub
        End If

        If TxtEdad.Text = "" Then
            MsgBox("Corrige la fecha de NACIMIENTO del cliente.", vbCritical, "Comprobar datos")
            DtpFdn.Focus() : Exit Sub
        End If

        If Not RbDiario.Checked And Not RbMensual.Checked And Not RbGrupoFamiliar.Checked Then
            MsgBox("Selecciona un MÉTODO de pago.", vbCritical, "Comprobar datos")
            Exit Sub
        End If

        If RbDiario.Checked And TxtListaNombre.Text = "" Then
            MsgBox("Selecciona un PAGO de la lista.", vbCritical, "Comprobar datos")
            DgvListaNombre.Focus() : Exit Sub
        End If

        If RbGrupoFamiliar.Checked And TxtListaNombre.Text = "" Then
            MsgBox("Selecciona un GRUPO de la lista.", vbCritical, "Comprobar datos")
            DgvListaNombre.Focus() : Exit Sub
        End If

        'COMPROBAR QUE RADIOBUTTON ESTA ACTIVADO PARA GUARDAR EL METODO DE PAGO
        If RbDiario.Checked Then strMpago = TxtListaNombre.Text
        If RbMensual.Checked Then strMpago = "MENSUAL"
        If RbGrupoFamiliar.Checked Then strMpago = "GRUPAL"

        'COMPROBAR QUE RADIOBUTTON ESTA ACTIVADO PARA GUARDAR EL ESTADO DEL CLIENTE
        If RbEstadoActivo.Checked Then strEstado = "ACTIVO"
        If RbEstadoInactivo.Checked Then strEstado = "INACTIVO"

        'USAMOS TRY PARA CONTROLAR POSIBLES ERRORES
        Try
            'CONECTAR Y ABRIR LA BBDD
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()

            ':::::COMPROBAMOS EL VALOR DE LA VARIABLE:::::'
            If strMpago = "GRUPAL" Then

                'HACEMOS LA CONSULTA A LA BBDD CON EL ID DEL GRUPO FAMILIAR
                sqlConsulta = "INSERT INTO clientes (nom_cli, ape_cli,
                                fdn_cli, tlf_cli, eml_cli, dir_cli,
                                mpg_cli, fdi_cli, std_cli, id_grp) VALUES
                                ('" & TxtNombre.Text & "', '" & TxtApellido.Text & "',
                                '" & DtpFdn.Value.ToString("yyyy-MM-dd") & "', '" & TxtTelefono.Text & "',
                                '" & TxtEmail.Text & "', '" & TxtDireccion.Text & "',
                                '" & strMpago & "', '" & DtpFdi.Value.Date.ToString("yyyy-MM-dd") & "',
                                '" & strEstado & "', '" & DgvListaNombre.CurrentRow.Cells(0).Value & "')"

            Else 'SI ES MENSUAL O DIARIO

                'HACEMOS LA CONSULTA A LA BBDD SIN EL ID DEL GRUPO FAMILIAR
                sqlConsulta = "INSERT INTO clientes (nom_cli, ape_cli,
                                fdn_cli, tlf_cli, eml_cli, dir_cli,
                                mpg_cli, fdi_cli, std_cli) VALUES
                                ('" & TxtNombre.Text & "', '" & TxtApellido.Text & "',
                                '" & DtpFdn.Value.ToString("yyyy-MM-dd") & "', '" & TxtTelefono.Text & "',
                                '" & TxtEmail.Text & "', '" & TxtDireccion.Text & "',
                                '" & strMpago & "', '" & DtpFdi.Value.Date.ToString("yyyy-MM-dd") & "',
                                '" & strEstado & "')"
            End If

            'AGREGAMOS EL NUEVO CLIENTE A LA TABLA CLIENTES
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()
            drDataReader.Close()

            'OBTENEMOS EL ID DEL ÚLTIMO REGISTRO Y LO ALMACENAMOS EN LA VARIABLE strIdCli
            sqlConsulta = "SELECT id_cli FROM clientes ORDER BY id_cli DESC LIMIT 1"
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader
            drDataReader.Read()
            strIdCli = drDataReader.GetInt16(0).ToString
            drDataReader.Close()

            'CONSULTAMOS A LA BBDD LA TARIFA CORRESPONDIENTE AL CLIENTE
            Select Case strMpago
                Case "DIARIO"
                    sqlConsulta = "SELECT * FROM trfa_dscto WHERE tipo_trfa = '" & strMpago & "'"
                Case "MENSUAL"
                    sqlConsulta = "SELECT * FROM trfa_dscto WHERE emin_trfa <= '" & TxtEdad.Text & "' AND emax_trfa >= '" & TxtEdad.Text & "'"
                Case "GRUPAL"
                    sqlConsulta = "SELECT * FROM trfa_dscto WHERE nperson_trfa = '" & DgvListaNombre.CurrentRow.Cells(2).Value & "'"
            End Select
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader

            'VARIABLES PARA ALMACENAR EL PRECIO Y EL DSCTO
            Dim precio, dscnto As Decimal

            'COMPROBAMOS SI HAY REGISTROS
            If drDataReader.HasRows Then
                drDataReader.Read()
                precio = drDataReader.GetDecimal(2) 'Replace(drDataReader.GetDecimal(1).ToString, ",", ".")
                dscnto = drDataReader.GetDecimal(6) 'Replace(drDataReader.GetDecimal(4).ToString, ",", ".")
            Else
                drDataReader.Close()
                sqlConsulta = "SELECT prcio_trfa FROM trfa_dscto WHERE tipo_trfa = 'MENSUAL'" 'id_tarifa = 1
                cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                drDataReader = cmdCommand.ExecuteReader
                drDataReader.Read()
                precio = drDataReader.GetDecimal(0) 'Replace(drDataReader.GetDecimal(0).ToString, ",", ".")
                dscnto = 0
            End If
            drDataReader.Close()

            ':::'
            MsgBox(precio & " :: " & dscnto)
            'AGREGAMOS UN NUEVO REGISTRO EN LA TABLA PAGOS
            'sqlConsulta = "INSERT INTO pagos (fdi_pgs, fdp_pgs, frm_pgs, prc_pgs, dsc_pgs, id_cli, usuario)
            '              VALUES ('" & DateTime.Now.ToString("yyyy-MM-dd") & "', '0101-01-01', '',
            '              '" & Replace(precio, ",", ".") & "', '" & Replace(descto, ",", ".") & "', '" & strIdCli & "', '')"
            'cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            'drDataReader = cmdCommand.ExecuteReader()
            'drDataReader.Close()

            'COMPROBAMOS EL VALOR DE LA VARIABLE PARA HCER LA CONSULTA A LA BBDD
            If blnAddMembers Then
                'CONSULTA PARA ACTUALIZAR DOS CAMPOS DEL REGISTRO
                sqlConsulta = "UPDATE grp_familiar SET
                                num_intgrntes_grp = '" & intAddMember & "',
                                intgrntes_reg_grp = '" & intAddMember & "'
                                WHERE id_grp = '" & DgvListaNombre.CurrentRow.Cells(0).Value & "'"
            Else
                'CONSULTA PARA ACTUALIZAR UN CAMPO DEL REGISTRO
                sqlConsulta = "UPDATE grp_familiar SET
                                intgrntes_reg_grp = '" & intAddMember & "'
                                WHERE id_grp = '" & DgvListaNombre.CurrentRow.Cells(0).Value & "'"
            End If

            'ACTUALIZAMOS LOS DATOS DEL GRUPO FAMILIAR
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()
            'drDataReader.Close()

        Catch ex As Exception
            'MOSTRAMOS UN MENSAJE CON EL ERROR CAPTURADO
            MsgBox(ex.ToString)
        Finally
            'CERRAMOS EL DATAREADER Y LA BBDD
            drDataReader.Close()
            cnxnMySql.Close()
        End Try

        'DAR FORMATO EL CODIGO DEL CLIENTE
        If strIdCli.Length = 1 Then strIdCli = "CLI - 00" & strIdCli
        If strIdCli.Length = 2 Then strIdCli = "CLI - 0" & strIdCli
        If strIdCli.Length = 3 Then strIdCli = "CLI - " & strIdCli

        'MOSTRAMOS UN MESAJE DE CONFIRMACIÓN
        MsgBox("Datos GUARDADOS satisfactoriamente." & Chr(13) & Chr(13) _
                & "NOMBRE   :  " & TxtNombre.Text & " " & TxtApellido.Text & Chr(13) _
                & "CODIGO   :  " & strIdCli, vbInformation, "Guardar Cliente")


        'FrmListaClientes.TxtBuscarCliente.Text = TxtNombre.Text
        ''''
        ''
        'LLENAR EL OTRO FORMULARIO CON LOS DATOS QUE SE HAN GUARDADO

        '
        ''
        ''''
        'CERRAMOS EL FORM
        Close()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        '987654321
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        'CERRAMOS EL FORM
        Close()
    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        'VALIDAR SOLO LETRAS
    End Sub

    Private Sub TxtNombre_GotFocus(sender As Object, e As EventArgs) Handles TxtNombre.GotFocus
        'CAMBIA EL COLOR AL RECIBIR EL ENFOQUE
        TxtNombre.BackColor = Color.Beige
    End Sub

    Private Sub TxtNombre_LostFocus(sender As Object, e As EventArgs) Handles TxtNombre.LostFocus
        'FUNCION PARA BORRAR ESPACIOS EN BLANCO Y CAMBIO DE COLOR
        TxtLostFocus(TxtNombre)
    End Sub

    Private Sub TxtApellido_TextChanged(sender As Object, e As EventArgs) Handles TxtApellido.TextChanged
        'VALIDAR SOLO LETRAS
    End Sub

    Private Sub TxtApellido_GotFocus(sender As Object, e As EventArgs) Handles TxtApellido.GotFocus
        'CAMBIA EL COLOR AL RECIBIR EL ENFOQUE
        TxtApellido.BackColor = Color.Beige
    End Sub

    Private Sub TxtApellido_LostFocus(sender As Object, e As EventArgs) Handles TxtApellido.LostFocus
        'FUNCION PARA BORRAR ESPACIOS EN BLANCO Y CAMBIO DE COLOR
        TxtLostFocus(TxtApellido)
    End Sub

    Private Sub DtpFdn_ValueChanged(sender As Object, e As EventArgs) Handles DtpFdn.ValueChanged

        'CALCULAR LA EDAD Y ALMACENAR EN LA VARIBLE
        Dim dtpEdad = Int(DateDiff("m", DtpFdn.Value, Now) / 12)

        TxtEdad.Text = dtpEdad & " años" 'MOSTRAR EDAD

        'COMPROBAR LA EDAD
        'If dtpEdad < 1 Then TxtEdad.Text = "0 años"
        'If dtpEdad > 99 Then TxtEdad.Text = "99 años"

    End Sub

    Private Sub DtpFdn_GotFocus(sender As Object, e As EventArgs) Handles DtpFdn.GotFocus

        TxtEdad.BackColor = Color.Beige 'CAMBIAR COLOR

        DtpFdn.CustomFormat = "' ' dd ' de  ' MMMM ' de  ' yyyy" 'LLENAMOS EL DTPFDN CON UNA FECHA PERSONALIZADA
    End Sub

    Private Sub DtpFdn_LostFocus(sender As Object, e As EventArgs) Handles DtpFdn.LostFocus
        'CAMBIAR COLOR 
        TxtEdad.BackColor = Color.Azure
        If TxtEdad.Text = "" Then TxtEdad.BackColor = Color.MistyRose
    End Sub

    Private Sub TxtTelefono_TextChanged(sender As Object, e As EventArgs) Handles TxtTelefono.TextChanged
        'VALIDAR SOLO LETRAS
    End Sub

    Private Sub TxtTelefono_GotFocus(sender As Object, e As EventArgs) Handles TxtTelefono.GotFocus
        'CAMBIA EL COLOR AL RECIBIR EL ENFOQUE
        TxtTelefono.BackColor = Color.Beige
    End Sub

    Private Sub TxtTelefono_LostFocus(sender As Object, e As EventArgs) Handles TxtTelefono.LostFocus
        'FUNCION PARA BORRAR ESPACIOS EN BLANCO Y CAMBIO DE COLOR
        TxtLostFocus(TxtTelefono)
    End Sub

    Private Sub TxtEmail_TextChanged(sender As Object, e As EventArgs) Handles TxtEmail.TextChanged
        'VALIDAR SOLO LETRAS
    End Sub

    Private Sub TxtEmail_GotFocus(sender As Object, e As EventArgs) Handles TxtEmail.GotFocus
        'CAMBIA EL COLOR AL RECIBIR EL ENFOQUE
        TxtEmail.BackColor = Color.Beige
    End Sub

    Private Sub TxtEmail_LostFocus(sender As Object, e As EventArgs) Handles TxtEmail.LostFocus
        'FUNCION PARA BORRAR ESPACIOS EN BLANCO Y CAMBIO DE COLOR
        TxtLostFocus(TxtEmail)
    End Sub

    Private Sub TxtDireccion_TextChanged(sender As Object, e As EventArgs) Handles TxtDireccion.TextChanged
        'VALIDAR SOLO LETRAS
    End Sub

    Private Sub TxtDireccion_GotFocus(sender As Object, e As EventArgs) Handles TxtDireccion.GotFocus
        'CAMBIA EL COLOR AL RECIBIR EL ENFOQUE
        TxtDireccion.BackColor = Color.Beige
    End Sub

    Private Sub TxtDireccion_LostFocus(sender As Object, e As EventArgs) Handles TxtDireccion.LostFocus
        'FUNCION PARA BORRAR ESPACIOS EN BLANCO Y CAMBIO DE COLOR
        TxtLostFocus(TxtDireccion)
    End Sub

    Private Sub RbGrupoFamiliar_CheckedChanged(sender As Object, e As EventArgs) Handles RbGrupoFamiliar.CheckedChanged
        'Nombre del grupo
        If RbGrupoFamiliar.Checked Then

            TxtListaNombre.Text = "" 'LIMPIAMOS EL TEXTBOX
            'LblMetodoPago.BackColor = Color.Azure

            GbListaGrupoFamiliar.Text = "Lista de grupos familiares" 'CAMBIAMOS EL TITULO DEL GROUPBOX

            BtnAddGrupo.Enabled = True 'ACTIVAMOS EL BUTTON ADDGRUPO

            TxtListaNombre.Enabled = True 'ACTIVAMOS EL TEXTBOX

            LblNumIntgrntes.Text = "" 'LIMPIAMOS EL LABEL

            DgvListaNombre.Enabled = True

            'USAMOS TRY PARA CONTROLAR POSIBLES ERRORES
            Try
                'CONECTAR Y ABRIR LA BBDD
                cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
                cnxnMySql.Open()

                'HACEMOS LA CONSULTA PARA LLENAR EL DATAGRIDVIEW
                sqlConsulta = "SELECT * FROM grp_familiar ORDER BY nom_grp" 'WHERE tipo_trfa LIKE '%GRUPO%'"
                cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                drDataReader = cmdCommand.ExecuteReader()
                DgvListaNombre.Rows.Clear()

                'COMPROBAMOS SI HAY REGISTROS
                If drDataReader.HasRows Then

                    While drDataReader.Read()
                        nRow = DgvListaNombre.Rows.Add()
                        DgvListaNombre.Rows(nRow).Cells(0).Value = drDataReader.GetInt16(0) 'ID
                        DgvListaNombre.Rows(nRow).Cells(1).Value = drDataReader.GetString(1) 'NOMBRE TIPO TARIFA
                        DgvListaNombre.Rows(nRow).Cells(2).Value = drDataReader.GetInt16(2) 'NUMERO DE INTEGRANTES
                        DgvListaNombre.Rows(nRow).Cells(3).Value = drDataReader.GetInt16(3) 'INTEGRANTES REGISTRADOS
                    End While
                End If

            Catch ex As Exception
                'MOSTRAMOS UN MENSAJE CON EL ERROR CAPTURADO
                MsgBox(ex.ToString)
            Finally
                'CERRAMOS EL DATAREADER Y LA BASE DE DATOS
                drDataReader.Close()
                cnxnMySql.Close()
            End Try
        End If

    End Sub

    Private Sub RbDiario_CheckedChanged(sender As Object, e As EventArgs) Handles RbDiario.CheckedChanged
        'Nombre del grupo
        If RbDiario.Checked Then

            TxtListaNombre.Text = "" 'LIMPIAMOS EL TEXTBOX
            'LblMetodoPago.BackColor = Color.Azure

            GbListaGrupoFamiliar.Text = "Lista clases sueltas" 'CAMBIAMOS EL TITULO DEL GROUPBOX

            BtnAddGrupo.Enabled = False 'DESACTIVAMOS EL BUTTON ADDGRUPO

            TxtListaNombre.Enabled = False 'DESACTIVAMOS EL TEXTBOX

            LblNumIntgrntes.Text = "" 'LIMPIAMOS EL LABEL

            DgvListaNombre.Enabled = True

            'USAMOS TRY PARA CONTROLAR POSIBLES ERRORES
            Try
                'CONECTAR Y ABRIR LA BBDD
                cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
                cnxnMySql.Open()
                sqlConsulta = "SELECT id_trfa, tipo_trfa FROM trfa_dscto WHERE tipo_trfa LIKE '%DIARIO%'"
                cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                drDataReader = cmdCommand.ExecuteReader()
                DgvListaNombre.Rows.Clear()
                'COMPROBAMOS SI HAY REGISTROS
                If drDataReader.HasRows Then
                    While drDataReader.Read()
                        nRow = DgvListaNombre.Rows.Add()
                        DgvListaNombre.Rows(nRow).Cells(0).Value = drDataReader.GetInt16(0) '.ToString 'ID
                        DgvListaNombre.Rows(nRow).Cells(1).Value = drDataReader.GetString(1) 'NOMBRE TIPO TARIFA
                    End While
                End If
                'CERRAMOS EL DATA READER
                drDataReader.Close()
            Catch ex As Exception
                '
                MsgBox(ex.Message)
            Finally
                'CERRAMOS LA BASE DE DATOS
                cnxnMySql.Close()
            End Try
            'Else
            'GbListaPrecio.Text = "Lista"
        End If
    End Sub

    Private Sub RbMensual_CheckedChanged(sender As Object, e As EventArgs) Handles RbMensual.CheckedChanged
        'Nombre del grupo
        If RbMensual.Checked Then

            'LLENAMOS EL LABEL CON EL NOMBRE DEL METODO DEL PAGO PARA GUARDAR EN LA TABLA
            TxtListaNombre.Text = "" 'LIMPIAMOS EL TEXTBOX
            'LblMetodoPago.Text = "MENSUAL"
            'LblMetodoPago.BackColor = Color.Azure

            BtnAddGrupo.Enabled = False 'DESACTIVAMOS EL BUTTON ADDGRUPO

            GbListaGrupoFamiliar.Text = "Lista vacia" 'CAMBIAMOS EL NOMBRE DEL GROUPBOX

            TxtListaNombre.Enabled = False 'DESACTIVAMOS EL TEXTBOX

            LblNumIntgrntes.Text = ""

            DgvListaNombre.Rows.Clear()
            DgvListaNombre.Enabled = False

        End If
    End Sub

    Private Sub BtnAddGrupo_Click(sender As Object, e As EventArgs) Handles BtnAddGrupo.Click
        FrmGrupoFamiliar.Show()
    End Sub

    Private Sub DgvListaNombre_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListaNombre.CellContentClick
    End Sub
    Private Sub DgvListaNombre_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListaNombre.CellClick

        'COMPROBAR SI EL RADIOBUTTON ESTÁ ACTIVADO
        If RbGrupoFamiliar.Checked Then

            'SI LA CANTIDAD DE INTEGRANTES ES = A LOS INTEGRANTES REGISTRADOS
            If DgvListaNombre.CurrentRow.Cells(2).Value = DgvListaNombre.CurrentRow.Cells(3).Value Then

                'ADVERTENCIA QUE EL GRUPO ESTA LLENO, PREGUNTA SI QUIEREN AGREGAR UN NUEVO INTEGRANTES
                If MsgBox("    Nombre del grupo  : " & DgvListaNombre.CurrentRow.Cells(1).Value & vbCr &
                          "    Nº de Integrante     : " & DgvListaNombre.CurrentRow.Cells(2).Value & vbCr & vbCr &
                          "    El grupo seleccionado ya tiene los integrantes completos." & vbCr &
                          "    ___________________________________________________________" & vbCr & vbCr &
                          "                        ¿Seguro que quieres añadir otro integrante?",
                          vbExclamation + vbYesNo + vbDefaultButton2, "Comprobar datos") = vbYes Then

                    '::: LLENAMOS EL TEXTBOX CON EL NOMBRE DEL GRUPO PARA GUARDAR EN LA TABLA
                    '    PASAMOS LA VARIABLE A TRUE PARA ACTUALIZAR LOS CAMPOS num_intgrntes_grp Y intgrntes_reg_grp
                    '    CON EL VALOR DE LA VARIABLE intAddMember DEL REGISTRO SELECCIONADO,
                    '    AL MOMENTO DE GUARDAR LOS DATOS DEL CLIENTE :::'
                    TxtListaNombre.Text = DgvListaNombre.CurrentRow.Cells(1).Value
                    intAddMember = DgvListaNombre.CurrentRow.Cells(2).Value + 1
                    blnAddMembers = True

                Else 'SI HACEMOS CLICK EN NO

                    TxtListaNombre.Text = "" 'LIMPIAMOS EL TEXTBOX PARA NO PODER GUARDAR SIN SELECCIONASR UN GRUPO
                End If

            Else 'SI LA CANTIDAD DE INTEGRANTES ES DIFERENTE QUE LOS INTEGRANTES REGISTRADOS

                '::: LLENAMOS EL TEXTBOX CON EL NOMBRE DEL GRUPO
                '    PASAMOS LA VARIABLE A FALSE PARA ACTUALIZAR EL CAMPO intgrntes_reg_grp
                '    CON EL VALOR DE LA VARIABLE intAddMember DEL REGISTRO SELECCIONADO,
                '    AL MOMENTO DE GUARDAR LOS DATOS DEL CLIENTE :::'
                TxtListaNombre.Text = DgvListaNombre.CurrentRow.Cells(1).Value
                intAddMember = DgvListaNombre.CurrentRow.Cells(3).Value + 1
                blnAddMembers = False

            End If

        Else 'SI EL RADIOBUTTON DIARIO ESTÁ ACTIVADO

            'LLENAMOS EL TEXTBOX CON EL NOMBRE DE LA CLASE SUELTA PARA GUARDAR EN LA TABLA
            TxtListaNombre.Text = DgvListaNombre.CurrentRow.Cells(1).Value

        End If
    End Sub

    '::: ---------->>>>>>>>>> PROCEDIMIENTOS <<<<<<<<<<---------- :::'
    Sub TxtLostFocus(ByVal TxtCadena As TextBox)
        TxtCadena.Text = Trim(TxtCadena.Text)
        While TxtCadena.Text.Contains("  ")
            TxtCadena.Text = TxtCadena.Text.Replace("  ", " ")
        End While
        TxtCadena.BackColor = Color.Azure
        If TxtCadena.Text = "" Then TxtCadena.BackColor = Color.MistyRose
    End Sub

End Class