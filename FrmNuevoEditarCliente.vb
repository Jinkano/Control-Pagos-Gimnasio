Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class FrmNuevoEditarCliente

    Dim cnxnMySql As New MySqlConnection
    Dim drDataReader As MySqlDataReader
    Dim cmdCommand As MySqlCommand
    Dim sqlConsulta, strEstado, strMtdPgs, strIdGrupo, strAddMembers As String
    Dim nRow, intAddMember As Int16
    Dim precio, dscnto As Decimal
    Dim blnMarker As Boolean
    Public strIdClient As String

    Private Sub FrmNuevoEditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '| * Almacenamos el año actual en la variable currentYear para asignar valores mínimos y _
        '|   _ máximos a los DateTimePicker DtpFdn y DtpFdi.
        '| * Asignamos la fecha mínima y máxima al DtpFdn.
        '|
        '| IF : Si el botón BtnGuardar está activado.
        '|      * Limpiamos el DtpFdn y le damos una nueva fecha con 25 años menos.
        '|      * Limpiamos el TxtEdad.
        '|      * Restamos y sumamos en 1 la variable currentYear que tiene el año actual para _
        '|        _ el valor mínimo y máximo del DtpFdi.
        '| ELSE : Si el botón BtnActualizar está activado
        '|      * Le pasamos al DtpFdn el formato personalizado de la fecha.

        Dim currentYear = Year(Date.Now)

        DtpFdn.MinDate = "01/01/" & currentYear - 90
        DtpFdn.MaxDate = DateTime.Now

        If BtnGuardar.Visible = True Then

            DtpFdn.CustomFormat = " "
            DtpFdn.Value = "01/07/" & currentYear - 25

            TxtEdad.Text = ""

            DtpFdi.MinDate = "01/01/" & currentYear - 1
            DtpFdi.MaxDate = "31/12/" & currentYear + 1
        Else
            DtpFdn.CustomFormat = "' ' dd ' de  ' MMMM ' de  ' yyyy"
        End If

    End Sub
    Private Sub FrmNuevoEditarCliente_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        'MsgBox("FrmNuevoEditarCliente_Deactivate")
        Close()
    End Sub
    '
    '
    '   
    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
    End Sub
    Private Sub TxtNombre_GotFocus(sender As Object, e As EventArgs) Handles TxtNombre.GotFocus

        '| -----------------------------------------------------------------------------------
        '| CAMBIAR EL COLOR DEL FONDO AL RECIBIR EL ENFOQUE
        '| ------------------------------------------------
        TxtNombre.BackColor = Color.Beige

    End Sub
    Private Sub TxtNombre_LostFocus(sender As Object, e As EventArgs) Handles TxtNombre.LostFocus

        '| -----------------------------------------------------------------------------------
        '| VALAIDACIONES AL PERDER EL ENFOQUE
        '| ----------------------------------
        '| * Llamamos a la función Fun_TxtLost_Focus() y le pasamos como parámetro el TextBox
        Fun_TxtLost_Focus(TxtNombre)

    End Sub
    Private Sub TxtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombre.KeyPress

        '| -----------------------------------------------------------------------------------
        '| VALIDAR EL INGRESO DE LETRAS Y ESPACIO
        '| ---------------------------------------
        '| * Almacenamos en la variable strAllowKey los caracteres que queremos PERMITIR.
        '| * Almacenamos en la variable strLockKey los caracteres que queremos EXCLUIR.
        '| * Llamamos a la función Fun_Only_Letters y le pasamos las variables como parámetro.

        Dim strAllowKey As String = " "
        Dim strLockKey As String = "ºª"
        Fun_Only_Letters(strAllowKey, strLockKey, e)

    End Sub
    '
    '
    '
    Private Sub TxtApellido_TextChanged(sender As Object, e As EventArgs) Handles TxtApellido.TextChanged
    End Sub
    Private Sub TxtApellido_GotFocus(sender As Object, e As EventArgs) Handles TxtApellido.GotFocus

        '| -----------------------------------------------------------------------------------
        '| CAMBIAR EL COLOR DEL FONDO AL RECIBIR EL ENFOQUE
        '| ------------------------------------------------
        TxtApellido.BackColor = Color.Beige

    End Sub
    Private Sub TxtApellido_LostFocus(sender As Object, e As EventArgs) Handles TxtApellido.LostFocus

        '| -----------------------------------------------------------------------------------
        '| VALAIDACIONES AL PERDER EL ENFOQUE
        '| ----------------------------------
        '| * Llamamos a la función Fun_TxtLost_Focus() y le pasamos como parámetro el TextBox
        Fun_TxtLost_Focus(TxtApellido)

    End Sub
    Private Sub TxtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtApellido.KeyPress

        '| -----------------------------------------------------------------------------------
        '| VALIDAR EL INGRESO DE LETRAS Y ESPACIO
        '| ---------------------------------------
        '| * Almacenamos en la variable strAllowKey los caracteres que queremos PERMITIR.
        '| * Almacenamos en la variable strLockKey los caracteres que queremos EXCLUIR.
        '| * Llamamos a la función Fun_Only_Letters y le pasamos las variables como parámetro.

        Dim strAllowKey As String = " "
        Dim strLockKey As String = "ºª"
        Fun_Only_Letters(strAllowKey, strLockKey, e)

    End Sub
    '
    '
    '
    Private Sub TxtTelefono_TextChanged(sender As Object, e As EventArgs) Handles TxtTelefono.TextChanged
    End Sub
    Private Sub TxtTelefono_GotFocus(sender As Object, e As EventArgs) Handles TxtTelefono.GotFocus

        '| -----------------------------------------------------------------------------------
        '| CAMBIAR EL COLOR DEL FONDO AL RECIBIR EL ENFOQUE
        '| ------------------------------------------------
        TxtTelefono.BackColor = Color.Beige

    End Sub
    Private Sub TxtTelefono_LostFocus(sender As Object, e As EventArgs) Handles TxtTelefono.LostFocus

        '| -----------------------------------------------------------------------------------
        '| VALAIDACIONES AL PERDER EL ENFOQUE
        '| ----------------------------------
        '| * Llamamos a la función Fun_TxtLost_Focus() y le pasamos como parámetro el TextBox
        Fun_TxtLost_Focus(TxtTelefono)

    End Sub
    Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress

        '| -----------------------------------------------------------------------------------
        '| VALIDAR EL INGRESO DE NÚMEROS, PARÉNTESIS, GUION Y ESPACIO
        '| ----------------------------------------------------------
        '| * Almacenamos en la variable strAllowKey los caracteres que queremos PERMITIR.
        '| * Llamamos a la función Fun_Only_Letters y le pasamos la variable como parámetro.

        Dim strAllowKey As String = "(-) "
        Fun_Only_Numbers(strAllowKey, e)

    End Sub
    '
    '
    '
    Private Sub TxtEmail_TextChanged(sender As Object, e As EventArgs) Handles TxtEmail.TextChanged
    End Sub
    Private Sub TxtEmail_GotFocus(sender As Object, e As EventArgs) Handles TxtEmail.GotFocus

        '| -----------------------------------------------------------------------------------
        '| CAMBIAR EL COLOR DEL FONDO AL RECIBIR EL ENFOQUE
        '| ------------------------------------------------
        TxtEmail.BackColor = Color.Beige

    End Sub
    Private Sub TxtEmail_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtEmail.KeyUp

        '| -----------------------------------------------------------------------------------
        '| VALAIDACIONES AL SOLTAR LA TECLA PRESIONADA
        '| -------------------------------------------
        '| IF : Comrpobamos si Fun_IsValid_Email no cumple con el formato del E-Mail.
        '|      * Mostrar el error si el formato es incorrecto.
        '|      * Cambiamos el color del fondo.
        '| ELSE : 
        '|      * Limpiamos el error.
        '|      * Cambiamos el color del fondo.

        If Not Fun_IsValid_Email(TxtEmail.Text) Then
            'ErrorProvider.Clear()
            ErrorProvider.SetError(TxtEmail, "Ingresa un formato de E-Mail válido (usuario@dominio.com)")
            TxtEmail.BackColor = Color.MistyRose
        Else
            ErrorProvider.Clear()
            TxtEmail.BackColor = Color.Beige
        End If

    End Sub
    Private Sub TxtEmail_LostFocus(sender As Object, e As EventArgs) Handles TxtEmail.LostFocus

        '| -----------------------------------------------------------------------------------
        '| VALAIDACIONES AL PERDER EL ENFOQUE
        '| ----------------------------------
        '| * Llamamos a la función Fun_TxtLost_Focus() y le pasamos como parámetro el TextBox
        '| IF : Comrpobamos si el TxtEmail no está vacio Y si Fun_IsValid_Email no cumple con el formato del E-Mail
        '|      * Mostrar el error si el formato es incorrecto.
        '|      * Cambiamos el color del fondo.

        Fun_TxtLost_Focus(TxtEmail)
        If Not String.IsNullOrWhiteSpace(TxtEmail.Text) And Not Fun_IsValid_Email(TxtEmail.Text) Then
            ErrorProvider.SetError(TxtEmail, "Ingresa un formato de E-Mail válido (usuario@dominio.com)")
            TxtEmail.BackColor = Color.MistyRose
        End If

    End Sub
    '
    '
    '
    Private Sub TxtDireccion_TextChanged(sender As Object, e As EventArgs) Handles TxtDireccion.TextChanged
    End Sub
    Private Sub TxtDireccion_GotFocus(sender As Object, e As EventArgs) Handles TxtDireccion.GotFocus

        '| -----------------------------------------------------------------------------------
        '| CAMBIAR EL COLOR DEL FONDO AL RECIBIR EL ENFOQUE
        '| ------------------------------------------------
        TxtDireccion.BackColor = Color.Beige
    End Sub
    Private Sub TxtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDireccion.KeyPress

        '| -----------------------------------------------------------------------------------
        '| VALIDAR EL INGRESO DE CARACTERES PARA LA DIRECCIÓN
        '| --------------------------------------------------
        '| * Almacenamos en la variable strAllowKey los caracteres que queremos PERMITIR.
        '| * Llamamos a la función Fun_Only_Letters y le pasamos las variables como parámetro.

        Dim strAllowKey As String = "(&'.-/) "
        Fun_Letters_And_Numbers(strAllowKey, e)

    End Sub
    Private Sub TxtDireccion_LostFocus(sender As Object, e As EventArgs) Handles TxtDireccion.LostFocus

        '| -----------------------------------------------------------------------------------
        '| VALAIDACIONES AL PERDER EL ENFOQUE
        '| ----------------------------------
        '| * Llamamos a la función Fun_TxtLost_Focus() y le pasamos como parámetro el TextBox
        Fun_TxtLost_Focus(TxtDireccion)

    End Sub
    '
    '
    '
    Private Sub TxtListaNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtListaNom.TextChanged

        '-*/
        If RbGrupoFamiliar.Checked Then

            sqlConsulta = "SELECT * FROM grp_familiar WHERE nom_grp LIKE '" & TxtListaNom.Text & "%' ORDER BY nom_grp"
            LlenarDgvListaNombre(sqlConsulta)

            If String.IsNullOrWhiteSpace(TxtListaNom.Text) Then LblNumIntgrntes.Text = ""

            If DgvListaNombre.RowCount > 0 Then
                If TxtListaNom.Text = DgvListaNombre.CurrentRow.Cells(1).Value Then
                    LblNumIntgrntes.Text = DgvListaNombre.CurrentRow.Cells(3).Value & " de " & DgvListaNombre.CurrentRow.Cells(2).Value
                End If
            End If
        End If

    End Sub
    Private Sub TxtListaNombre_GotFocus(sender As Object, e As EventArgs) Handles TxtListaNom.GotFocus
        'TxtListaNombre_GotFocus
    End Sub
    Private Sub TxtListaNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtListaNom.KeyPress
        'TxtListaNombre_KeyPress
    End Sub
    Private Sub TxtListaNombre_LostFocus(sender As Object, e As EventArgs) Handles TxtListaNom.LostFocus
        'TxtListaNombre_LostFocus
    End Sub
    '
    '
    '
    Private Sub DtpFdn_ValueChanged(sender As Object, e As EventArgs) Handles DtpFdn.ValueChanged

        'CALCULAR LA EDAD Y ALMACENAR EN LA VARIBLE
        Dim dtpEdad = Int(DateDiff("m", DtpFdn.Value, Now) / 12)

        TxtEdad.Text = dtpEdad & " años" 'MOSTRAR EDAD
        'COMPROBAR LA EDAD
        'If dtpEdad < 1 Then TxtEdad.Text = "0 años"
        'If dtpEdad > 99 Then TxtEdad.Text = "99 años"
    End Sub
    Private Sub DtpFdn_GotFocus(sender As Object, e As EventArgs) Handles DtpFdn.GotFocus

        '| -----------------------------------------------------------------------------------
        '| CAMBIAR EL COLOR DEL FONDO AL RECIBIR EL ENFOQUE
        '| ------------------------------------------------
        TxtEdad.BackColor = Color.Beige

        DtpFdn.CustomFormat = "' ' dd ' de  ' MMMM ' de  ' yyyy" 'LLENAMOS EL DTPFDN CON UNA FECHA PERSONALIZADA
    End Sub
    Private Sub DtpFdn_LostFocus(sender As Object, e As EventArgs) Handles DtpFdn.LostFocus
        'CAMBIAR COLOR 
        TxtEdad.BackColor = Color.Azure
        If TxtEdad.Text = "" Then TxtEdad.BackColor = Color.MistyRose
    End Sub
    '
    '
    '
    Private Sub DtpFdi_ValueChanged(sender As Object, e As EventArgs) Handles DtpFdi.ValueChanged
        'DtpFdi_ValueChanged
    End Sub
    '
    '
    '
    Private Sub RbEstadoActivo_CheckedChanged(sender As Object, e As EventArgs) Handles RbEstadoActivo.CheckedChanged

        '| Comprobamos si RbEstadoActivo está activado para llenar la variable strEstado el texto "ACTIVO", _
        '| _ en caso contrario le pasamos a la variable el texto "INACTIVO".
        '| La variable strEstado se usa para guardar o actualizar los datos del cliente.

        If RbEstadoActivo.Checked Then
            strEstado = "ACTIVO"
        Else
            strEstado = "INACTIVO"
        End If

    End Sub
    '
    '
    '
    Private Sub RbDiario_CheckedChanged(sender As Object, e As EventArgs) Handles RbDiario.CheckedChanged
        '
        If RbDiario.Checked Then

            'ASIGNAR UN VALOR A LA VARIABLE VALOR QUE SE USARÁ PARA GUARDAR EL METODO DE PAGO EN LA TABLA CLIENTES :::'
            strMtdPgs = TxtListaNom.Text
            ''
            ''
            'TxtListaNom.Text = "" 'LIMPIAMOS EL TEXTBOX
            ''LblMetodoPago.BackColor = Color.Azure
            ''
            ''
            GbListaGrupoFamiliar.Text = "Lista clases sueltas" 'CAMBIAMOS EL TITULO DEL GROUPBOX

            'BtnAddGrupo.Enabled = False 'DESACTIVAMOS EL BUTTON ADDGRUPO

            'TxtListaNombre.Enabled = False 'DESACTIVAMOS EL TEXTBOX

            'LblNumIntgrntes.Text = "" 'LIMPIAMOS EL LABEL

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
        '
    End Sub
    Private Sub RbDiario_Click(sender As Object, e As EventArgs) Handles RbDiario.Click
        '
        TxtListaNom.Text = "" 'LIMPIAMOS EL TEXTBOX
        'LblMetodoPago.BackColor = Color.Azure
        '
    End Sub
    '
    '
    '
    Private Sub RbMensual_CheckedChanged(sender As Object, e As EventArgs) Handles RbMensual.CheckedChanged
        '
        If RbMensual.Checked Then
            'ASIGNAR UN VALOR A LA VARIABLE, VALOR QUE SE USARÁ PARA GUARDAR EL METODO DE PAGO EN LA TABLA CLIENTES
            strMtdPgs = "MENSUAL"

            'LLENAMOS EL LABEL CON EL NOMBRE DEL METODO DEL PAGO PARA GUARDAR EN LA TABLA
            TxtListaNom.Text = "" 'LIMPIAMOS EL TEXTBOX
            'LblMetodoPago.Text = "MENSUAL"
            'LblMetodoPago.BackColor = Color.Azure

            'BtnAddGrupo.Enabled = False 'DESACTIVAMOS EL BUTTON ADDGRUPO

            GbListaGrupoFamiliar.Text = "Lista vacia" 'CAMBIAMOS EL NOMBRE DEL GROUPBOX

            'TxtListaNombre.Enabled = False 'DESACTIVAMOS EL TEXTBOX

            'LblNumIntgrntes.Text = ""

            DgvListaNombre.Rows.Clear()
            DgvListaNombre.Enabled = False

        End If
        '
    End Sub
    '
    '
    '
    Private Sub RbGrupoFamiliar_CheckedChanged(sender As Object, e As EventArgs) Handles RbGrupoFamiliar.CheckedChanged
        ''ASIGNAR UN VALOR A LA VARIABLE, VALOR QUE SE USARÁ PARA GUARDAR EL METODO DE PAGO EN LA TABLA CLIENTES
        'If RbGrupoFamiliar.Checked Then strMtdPgs = "GRUPAL"

        'Nombre del grupo
        If RbGrupoFamiliar.Checked Then

            'ASIGNAR UN VALOR A LA VARIABLE, VALOR QUE SE USARÁ PARA GUARDAR EL METODO DE PAGO EN LA TABLA CLIENTES
            strMtdPgs = "GRUPAL"

            TxtListaNom.Text = "" 'LIMPIAMOS EL TEXTBOX
            'LblMetodoPago.BackColor = Color.Azure

            GbListaGrupoFamiliar.Text = "Lista de grupos familiares" 'CAMBIAMOS EL TITULO DEL GROUPBOX

            BtnAddGrupo.Enabled = True 'ACTIVAMOS EL BUTTON ADDGRUPO

            TxtListaNom.Enabled = True 'ACTIVAMOS EL TEXTBOX

            LblNumIntgrntes.Text = "" 'LIMPIAMOS EL LABEL

            DgvListaNombre.Enabled = True

            'HACEMOS LA CONSULTA Y SE LO PASAMOS A LA FUNCIÓN PARA LLENAR EL DATAGRIDVIEW CON LOS GRUPOS FAMILIARES
            sqlConsulta = "SELECT * FROM grp_familiar ORDER BY id_grp DESC"
            LlenarDgvListaNombre(sqlConsulta)

        Else 'RbGrupoFamiliar.Checked=FALSE
            '
            BtnAddGrupo.Enabled = False  'DESACTIVAMOS EL BUTTON ADDGRUPO

            TxtListaNom.Enabled = False  'DESACTIVAMOS EL TEXTBOX

            LblNumIntgrntes.Text = "" 'LIMPIAMOS EL LABEL

            'DgvListaNombre.Enabled = False
        End If
    End Sub
    '
    '
    '
    Private Sub BtnAddGrupo_Click(sender As Object, e As EventArgs) Handles BtnAddGrupo.Click
        '::: 987 :::'
        RbGrupoFamiliar.Checked = False
        FrmGrupoFamiliar.Show()
    End Sub
    '
    '
    '
    Private Sub DgvListaNombre_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListaNombre.CellContentClick
    End Sub
    Private Sub DgvListaNombre_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListaNombre.CellClick
        If RbDiario.Checked Then
            'LLENAMOS EL TEXTBOX CON EL NOMBRE DE LA CLASE SUELTA PARA GUARDAR EN LA TABLA
            strMtdPgs = DgvListaNombre.CurrentRow.Cells(1).Value

            TxtListaNom.Text = strMtdPgs
        End If
    End Sub
    Private Sub DgvListaNombre_DoubleClick(sender As Object, e As EventArgs) Handles DgvListaNombre.DoubleClick

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

                    'AUMENTAMOS EN UNO EL NÚMERO DE INTEGRANTES PARA COMPROBAR SI HAY UNA TARIFA Y ACTUALIZAR LOS DATOS DEL GRUPO
                    intAddMember = DgvListaNombre.CurrentRow.Cells(2).Value + 1

                    '::: COMPROBAMOS SI EXISTE UNA TARIFA CON EL NÚMERO DE INTEGRANTES :::'
                    'USAMOS TRY PARA CONTROLAR POSIBLES ERRORES
                    Try
                        'CONECTAR Y ABRIR LA BBDD
                        cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
                        cnxnMySql.Open()
                        'HACEMOS LA CONSULTA
                        sqlConsulta = "SELECT nperson_trfa FROM trfa_dscto WHERE nperson_trfa = '" & intAddMember & "'"
                        cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                        drDataReader = cmdCommand.ExecuteReader()
                        'COMPROBAMOS SI NO HAY REGISTROS
                        If Not drDataReader.HasRows Then
                            'PREGUNTAMOS SI QUIERE AGREGAR UNA TARIFA
                            If MsgBox("   No hay una tarifa para " & intAddMember & " integrantes." & vbCr &
                                      "   ______________________________________" & vbCr & vbCr &
                                      "                ¿Quieres agergar una tarifa?",
                                        vbYesNo + vbDefaultButton2 + vbQuestion, "Lista de integrantes") = vbYes Then
                                'PONEMOS LA VARIABLE EN 0 Y MOSTRAMOS EL FORM
                                intAddMember = 0
                                FrmTablaDescuento.Show()
                            End If
                        Else 'SI HAY REGISTROS (TARIFA PARA LA CANTIDAD DE INTEGRANTES)
                            'CERRAMOS LA BASE DE DATOS
                            cnxnMySql.Close()
                            'LLENAMOS EL TEXTBOX CON EL NOMBRE DEL GRUPO
                            TxtListaNom.Text = DgvListaNombre.CurrentRow.Cells(1).Value
                            '
                            LblNumIntgrntes.Text = DgvListaNombre.CurrentRow.Cells(3).Value & " de " & DgvListaNombre.CurrentRow.Cells(2).Value
                            '
                            'LLENAMOS LA VARIABLE PARA ACTUALIZAR LOS CAMPOS num_intgrntes_grp Y intgrntes_reg_grp AL MOMENTO DE GUARDAR
                            strAddMembers = "UPDATE_TWO_FIELDS"
                        End If
                    Catch ex As Exception
                        'MOSTRAMOS UN MENSAJE CON EL ERROR CAPTURADO
                        MsgBox(ex.ToString)
                    Finally
                        'CERRAMOS LA BASE DE DATOS
                        cnxnMySql.Close()
                    End Try

                Else 'SI HACEMOS CLICK EN NO

                    TxtListaNom.Text = "" 'LIMPIAMOS EL TEXTBOX PARA NO PODER GUARDAR SIN SELECCIONASR UN GRUPO
                End If

            Else 'SI LA CANTIDAD DE INTEGRANTES ES DIFERENTE QUE LOS INTEGRANTES REGISTRADOS

                '::: LLENAMOS EL TEXTBOX CON EL NOMBRE DEL GRUPO
                '    PASAMOS LA VARIABLE A FALSE PARA ACTUALIZAR EL CAMPO intgrntes_reg_grp
                '    CON EL VALOR DE LA VARIABLE intAddMember DEL REGISTRO SELECCIONADO,
                '    AL MOMENTO DE GUARDAR LOS DATOS DEL CLIENTE :::'
                TxtListaNom.Text = DgvListaNombre.CurrentRow.Cells(1).Value
                '
                LblNumIntgrntes.Text = DgvListaNombre.CurrentRow.Cells(3).Value & " de " & DgvListaNombre.CurrentRow.Cells(2).Value
                '
                intAddMember = DgvListaNombre.CurrentRow.Cells(3).Value + 1
                strAddMembers = "UPDATE_A_FIELD"

            End If
        End If
    End Sub
    '
    '
    '
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        '-----------------------------------------------------------------------------------------------
        '| COMPROBAMOS SI HAY INFORMACION DEL CLIENTE ANTES DE GUARDAR
        '| -----------------------------------------------------------
        '| * Llamamos a la función FunMsgBox() y le pasamos los parámetros, según sea el caso, para _
        '|   _ verificar que toda la información del cliente sea correcta antes de guardar el registro.

        If FunMsgBox(LblNombre.Text, BtnGuardar.Text, TxtNombre) Then Exit Sub
        If FunMsgBox(LblApellido.Text, BtnGuardar.Text, TxtApellido) Then Exit Sub
        If FunMsgBox(LblFnacimiento.Text, BtnGuardar.Text, TxtEdad, DtpFdn) Then Exit Sub
        If FunMsGbox(BtnGuardar.Text, RbDiario, RbMensual, RbGrupoFamiliar) Then Exit Sub
        If FunMsgBox(RbDiario.Text, BtnGuardar.Text, TxtListaNom, RbDiario) Then Exit Sub
        If FunMsgBox(RbGrupoFamiliar.Text, BtnGuardar.Text, TxtListaNom, RbGrupoFamiliar) Then Exit Sub

        '-----------------------------------------------------------------------------------------------
        '| GUARDAR UN NUEVO REGISTRO EN LA TABLA CLIENTES
        '| ----------------------------------------------
        '| * Comprobamos el valor de la variable strmpago para hacer la consulta a la BBDD
        '| IF :
        '|      * Si la variable strMtdPgs es igual a "GRUPAL" hacemos una consulta con el _
        '|        _ campo [id_grp] de la tabla Gruppo Familiar.
        '| ELSE :
        '|      * Si la variable strMtdPgs es "MENSUAL" o "DIARIO" hacemos la consulta sin _
        '|        _ el [id_grp] del grupo familiar.
        '| * Llamamos a la función FunCrudSql() y le pasamos la consulta [sqlConsulta].

        If strMtdPgs = "GRUPAL" Then
            sqlConsulta = "INSERT INTO clientes (nom_cli, ape_cli, fdn_cli, tlf_cli, eml_cli, dir_cli, mpg_cli, fdi_cli, std_cli, id_grp)
                                VALUES ('" & TxtNombre.Text & "', '" & TxtApellido.Text & "',
                                '" & DtpFdn.Value.ToString("yyyy-MM-dd") & "', '" & TxtTelefono.Text & "',
                                '" & TxtEmail.Text & "', '" & TxtDireccion.Text & "',
                                '" & strMtdPgs & "', '" & DtpFdi.Value.ToString("yyyy-MM-dd") & "',
                                '" & strEstado & "', '" & DgvListaNombre.CurrentRow.Cells(0).Value & "')"

        Else
            sqlConsulta = "INSERT INTO clientes (nom_cli, ape_cli, fdn_cli, tlf_cli, eml_cli, dir_cli, mpg_cli, fdi_cli, std_cli)
                                VALUES ('" & TxtNombre.Text & "', '" & TxtApellido.Text & "',
                                '" & DtpFdn.Value.ToString("yyyy-MM-dd") & "', '" & TxtTelefono.Text & "',
                                '" & TxtEmail.Text & "', '" & TxtDireccion.Text & "',
                                '" & strMtdPgs & "', '" & DtpFdi.Value.ToString("yyyy-MM-dd") & "',
                                '" & strEstado & "')"
        End If
        FunCrudSql(sqlConsulta)

        '-----------------------------------------------------------------------------------------------
        '| BUSCAR EL ÚLTIMO REGISTRO GUARDADO PARA OBTENER EL ID DEL CLIENTE
        '| -----------------------------------------------------------------
        '| * Llamamos a la función FunReadIdClient() y le pasamos la consulta para obtener el [id_cli] _
        '|   _ del último registro guardado en la tabla [clientes] y lo almacenamos en la variable _
        '|   _ strIdClient que es Public.

        sqlConsulta = "SELECT id_cli FROM clientes ORDER BY id_cli DESC LIMIT 1"
        FunReadIdClient(sqlConsulta)

        '-----------------------------------------------------------------------------------------------
        '| CONSULTAMOS A LA BBDD LA TARIFA CORRESPONDIENTE AL NUEVO CLIENTE
        '| ----------------------------------------------------------------
        '| * Seleccionamos el CASE para la consulta según el valor de la variable [strMtdPgs].
        '| * Llamamos a la función FunSearchDiscountPrice() y le pasamos por parámetro la consulta _
        '|   _ almacenada en "sqlConsulta", si en está consulta no hay resultado pasamos la variable _
        '|   _ blnMarker a True.
        '|
        '| IF : Si el valor de la variable blnMarker es True
        '|      * Hacemos una nueva consulta para buscar la tarifa única MENSUAL que nos devolverá el _
        '|        _ precio y el descuento registrado en la tabla [trfa_dscto].
        '|      * Llamamos a la función FunSearchDiscountPrice() y le pasamos la consulta .

        Select Case strMtdPgs
            Case "MENSUAL"
                sqlConsulta = "SELECT prcio_trfa, dscto_trfa FROM trfa_dscto WHERE emin_trfa <= '" & TxtEdad.Text & "' AND emax_trfa >= '" & TxtEdad.Text & "'"
            Case "GRUPAL"
                sqlConsulta = "SELECT prcio_trfa, dscto_trfa FROM trfa_dscto WHERE nperson_trfa = '" & DgvListaNombre.CurrentRow.Cells(2).Value & "'"
            Case Else 'DIARIO (5,6,7...)
                sqlConsulta = "SELECT prcio_trfa, dscto_trfa FROM trfa_dscto WHERE tipo_trfa = '" & strMtdPgs & "'"
        End Select
        FunSearchDiscountPrice(sqlConsulta)

        If blnMarker = True Then
            sqlConsulta = "SELECT prcio_trfa, dscto_trfa FROM trfa_dscto WHERE tipo_trfa = 'MENSUAL'"
            FunSearchDiscountPrice(sqlConsulta)
        End If

        '-----------------------------------------------------------------------------------------------
        '| AGREGAMOS UN NUEVO REGISTRO EN LA TABLA PAGOS
        '| ---------------------------------------------
        '| * Hacemos la consulta y lo almacenamos en la variable sqlConsulta.
        '| * Llamamos al la función FunCrudSql() y le pasamos la consulta.

        sqlConsulta = "INSERT INTO pagos (fdi_pgs, mtd_pgs, prc_pgs, dsc_pgs, id_cli, id_user)
                           VALUES ('" & DateTime.Now.ToString("yyyy-MM-dd") & "', '" & strMtdPgs & "',
                                '" & Replace(precio, ",", ".") & "', '" & Replace(dscnto, ",", ".") & "',
                                '" & strIdClient & "', '" & FrmPrincipal.idUser & "')"
        FunCrudSql(sqlConsulta)

        '-----------------------------------------------------------------------------------------------
        '| ACTUALIZAR REGISTROS DE LA TABLA GRUPO_FAMILIAR
        '| -------------------------------------------------
        '| * Comprobamos el valor de la variable strAddMembers para hacer la consulta a la BBDD.
        '|
        '| CASE "UPDATE_A_FIELD" :
        '|      * En este caso solo vamos a actualizar el campo [intgrntes_reg_grp] de la tabla [grp_familiar]
        '|      * Llamamos a la función FunCrudSql() y le pasamos la consulta [sqlConsulta].
        '|
        '| CASE "UPDATE_TWO_FIELDS" :
        '|      * En este caso actualizamos los campos [num_intgrntes_grp y intgrntes_reg_grp] de la tabla [grp_familiar]
        '|      * Llamamos a la función FunCrudSql() y le pasamos la consulta [sqlConsulta].
        '| ** El motivo por el cual estamos llamando dos veces a la función FunCrudSql() es para evitar guardar dos _
        '|    _ registros en la tabla "pagos" al momento de registrar un nuevo cliente. No se porqué se queda la _
        '|    _ consulta después de cerra el DataReader y la BBDD.

        Select Case strAddMembers
            Case "UPDATE_A_FIELD"
                sqlConsulta = "UPDATE grp_familiar SET
                                    intgrntes_reg_grp = '" & intAddMember & "'
                                    WHERE id_grp = '" & DgvListaNombre.CurrentRow.Cells(0).Value & "'"
                FunCrudSql(sqlConsulta)

            Case "UPDATE_TWO_FIELDS"
                sqlConsulta = "UPDATE grp_familiar SET
                                    num_intgrntes_grp = '" & intAddMember & "',
                                    intgrntes_reg_grp = '" & intAddMember & "'
                                    WHERE id_grp = '" & DgvListaNombre.CurrentRow.Cells(0).Value & "'"
                FunCrudSql(sqlConsulta)
        End Select

        '-----------------------------------------------------------------------------------------------
        '| Llamamos a la función FillLabelsMessage() para mostrar los datos en el formulario _
        '| _ FrmNuevoEditarCliente, ****** y mostrar el mensaje de confirmación.
        FillLabelsMessage()

        'If String.IsNullOrEmpty(LblNomCli.Text) Then
        '    FunDisableButtons()

        'Esyo es por si se ha guardado
        FrmClientesPagos.FunActivateButtons()
        'End If
    End Sub
    '
    '
    '
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        '-----------------------------------------------------------------------------------------------
        '| COMPROBAMOS SI HAY INFORMACION DEL CLIENTE ANTES DE ACTUALIZAR
        '| --------------------------------------------------------------
        '| * Llamamos a la función FunMsgBox() y le pasamos los parámetros, según sea el caso, para _
        '|   _ verificar que toda la información del cliente sea correcta antes de actualizar el registro.

        If FunMsgBox(LblNombre.Text, BtnActualizar.Text, TxtNombre) Then Exit Sub
        If FunMsgBox(LblApellido.Text, BtnActualizar.Text, TxtApellido) Then Exit Sub
        If FunMsgBox(LblFnacimiento.Text, BtnActualizar.Text, TxtEdad, DtpFdn) Then Exit Sub
        If FunMsGbox(BtnActualizar.Text, RbDiario, RbMensual, RbGrupoFamiliar) Then Exit Sub
        If FunMsgBox(RbDiario.Text, BtnActualizar.Text, TxtListaNom, RbDiario) Then Exit Sub
        If FunMsgBox(RbGrupoFamiliar.Text, BtnActualizar.Text, TxtListaNom, RbGrupoFamiliar) Then Exit Sub

        '-----------------------------------------------------------------------------------------------
        '| ACTUALIZAR EL REGISTRO EN LA TABLA CLIENTES
        '| -------------------------------------------
        '| * Comprobamos el valor de la variable strmpago para hacer la consulta a la BBDD
        '| IF :
        '|      * Si la variable strMtdPgs es igual a "GRUPAL" hacemos una consulta con el _
        '|        _ campo [id_grp] de la tabla Gruppo Familiar.
        '| ELSE :
        '|      * Si la variable strMtdPgs es "MENSUAL" o "DIARIO" hacemos la consulta sin _
        '|        _ el [id_grp] del grupo familiar.
        '| * Llamamos a la función FunCrudSql() y le pasamos la consulta [sqlConsulta].

        If strMtdPgs = "GRUPAL" Then

            sqlConsulta = "UPDATE clientes SET
                        nom_cli='" & TxtNombre.Text & "',
                        ape_cli='" & TxtApellido.Text & "',
                        fdn_cli='" & DtpFdn.Value.ToString("yyyy-MM-dd") & "',
                        tlf_cli='" & TxtTelefono.Text & "',
                        eml_cli='" & TxtEmail.Text & "',
                        dir_cli='" & TxtDireccion.Text & "',
                        mpg_cli='" & strMtdPgs & "',
                        fdi_cli='" & DtpFdi.Value.ToString("yyyy-MM-dd") & "',
                        std_cli='" & strEstado & "',
                        id_grp='" & DgvListaNombre.CurrentRow.Cells(0).Value & "'
                        WHERE id_cli='" & strIdClient & "'"
        Else

            sqlConsulta = "UPDATE clientes SET
                        nom_cli='" & TxtNombre.Text & "',
                        ape_cli='" & TxtApellido.Text & "',
                        fdn_cli='" & DtpFdn.Value.ToString("yyyy-MM-dd") & "',
                        tlf_cli='" & TxtTelefono.Text & "',
                        eml_cli='" & TxtEmail.Text & "',
                        dir_cli='" & TxtDireccion.Text & "',
                        mpg_cli='" & strMtdPgs & "',
                        fdi_cli='" & DtpFdi.Value.ToString("yyyy-MM-dd") & "',
                        std_cli='" & strEstado & "'
                        WHERE id_cli='" & strIdClient & "'"
        End If
        FunCrudSql(sqlConsulta)

        '------------------------------------------------------------------------------------------------------------
        '| Llamamos a la función FillLabelsMessage() para mostrar los datos en el formulario FrmNuevoEditarCliente, _
        '| _ cambiar el texto del StsBarra y mostrar el mensaje de confirmación.
        FillLabelsMessage()

    End Sub
    '
    '
    '
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        '| Cerramos el formulario.
        If String.IsNullOrEmpty(FrmClientesPagos.LblNomCli.Text) Then FrmClientesPagos.FunDisableButtons()
        Me.Close()

    End Sub
    '
    '::: -------------------------------------------------------- :::'
    '::: ---------->>>>>>>>>> PROCEDIMIENTOS <<<<<<<<<<---------- :::'
    '::: -------------------------------------------------------- :::'

    'Sub TxtLostFocus(ByVal TxtCadena As TextBox)
    Sub Fun_TxtLost_Focus(txtTextBox As TextBox)

        'TxtCadena.Text = Trim(TxtCadena.Text)
        'While TxtCadena.Text.Contains("  ")
        '    TxtCadena.Text = TxtCadena.Text.Replace("  ", " ")
        'End While
        'TxtCadena.BackColor = Color.Azure

        'If TxtCadena.Text = "" Then TxtCadena.BackColor = Color.MistyRose

        ' 1. Limpiar errores previos
        ErrorProvider.Clear()

        If String.IsNullOrWhiteSpace(txtTextBox.Text) Then

            ErrorProvider.SetError(txtTextBox, "El campo no puede estar vacío.")
            txtTextBox.BackColor = Color.MistyRose

        Else

            txtTextBox.Text = Trim(txtTextBox.Text)
            While txtTextBox.Text.Contains("  ")
                txtTextBox.Text = txtTextBox.Text.Replace("  ", " ")
            End While
            txtTextBox.BackColor = Color.Azure

        End If

    End Sub
    '
    '
    '
    Overloads Function FunMsgBox(clientData As String, titleMsgbox As String, textBox As TextBox) As Boolean

        '| IF : Comprobamos si el TextBox está vacío.
        '|      * Convertimos el texto de la variable clientData y titleMsgbox en mayúsculsa y minúsculas _
        '|        _ respectivamente usando UCase() y LCase(), también se puede usar ToUpper() y ToLower().
        '|      * Extraemos el nombre del botón BtnGuardar o BtnActualizar según sea el caso, utilizando Substring() _
        '|        _ y lo convertimos en minúsculas usando LCase, para mostrarlo en el título de mensaje.
        '|      * Mostramos el mensaje con los datos recibidos por parámetro, enviamos el enfoque al textbox _
        '|        _ que corresponda.
        '|      * Return True para salir de la función y no ejecutar el resto del código.
        '| ELSE : Si el TextBox tiene datos
        '|      * Return False para seguir ejecutando el resto del código.

        If String.IsNullOrWhiteSpace(textBox.Text) Then
            clientData = UCase(clientData)
            titleMsgbox = LCase(titleMsgbox.Substring(1, titleMsgbox.Length - 1))
            MsgBox(" Verifica la información del cliente" & vbCr & vbCr &
                   " El campo " & clientData & " no puede estar vacío.", vbCritical, "Error al " & titleMsgbox)
            textBox.Focus()
            Return True
        Else
            Return False
        End If
    End Function
    Overloads Function FunMsgBox(clientData As String, titleMsgbox As String, label As Label, dateTimePicker As DateTimePicker) As Boolean

        '| IF : Comprobamos si el Label está vacío.
        '|      * Convertimos el texto de la variable clientData y titleMsgbox en mayúsculsa y minúsculas _
        '|        _ respectivamente usando UCase() y LCase(), también se puede usar ToUpper() y ToLower().
        '|      * Extraemos el nombre del botón BtnGuardar o BtnActualizar según sea el caso, utilizando Substring() _
        '|        _ y lo convertimos en minúsculas usando LCase, para mostrarlo en el título de mensaje.
        '|      * Mostramos el mensaje con los datos recibidos por parámetro, enviamos el enfoque al dateTimePicker _
        '|        _ que corresponda.
        '|      * Return True para salir de la función y no ejecutar el resto del código.
        '| ELSE : Si el TextBox tiene datos
        '|      * Return False para seguir ejecutando el resto del código.

        If String.IsNullOrEmpty(label.Text) Then
            clientData = UCase(clientData)
            titleMsgbox = LCase(titleMsgbox.Substring(1, titleMsgbox.Length - 1))
            MsgBox(" Verifica la información del cliente" & vbCr & vbCr &
                   " El campo " & clientData & " no puede estar vacío.", vbCritical, "Error al " & titleMsgbox)
            dateTimePicker.Focus()
            Return True
        Else
            Return False
        End If
    End Function
    Overloads Function FunMsGbox(titleMsgbox As String, rb1 As RadioButton, rb2 As RadioButton, rb3 As RadioButton) As Boolean

        '| IF : Comprobamos si los RadioButton no están seleccionados.
        '|      * Extraemos el nombre del botón BtnGuardar o BtnActualizar según sea el caso, utilizando Substring() _
        '|        _ y lo convertimos en minúsculas usando LCase, para mostrarlo en el título de mensaje.
        '|      * Mostramos el mensaje con los datos recibidos por parámetro.
        '|      * Return True para salir de la función y no ejecutar el resto del código.
        '| ELSE : Si uno de los RadioButton está seleccionado.
        '|      * Return False para seguir ejecutando el resto del código.

        If Not rb1.Checked And Not rb2.Checked And Not rb3.Checked Then
            titleMsgbox = LCase(titleMsgbox.Substring(1, titleMsgbox.Length - 1))
            MsgBox("Selecciona un MÉTODO de pago.", vbCritical, "Error al " & titleMsgbox)
            Return True
        Else
            Return False
        End If
    End Function
    Overloads Function FunMsgBox(clientData As String, titleMsgbox As String, textBox As TextBox, radioButton As RadioButton) As Boolean

        '| IF : Comprobamos si está activado el RadioButton y el TextBox está vacío.
        '|      * Convertimos el texto de la variable clientData y titleMsgbox en mayúsculsa y minúsculas _
        '|        _ respectivamente usando UCase() y LCase(), también se puede usar ToUpper() y ToLower()
        '|      * Comprobamos si la variable clientData = "DIARIO" para agragar el texto "pago ".
        '|      * Extraemos el nombre del botón BtnGuardar o BtnActualizar según sea el caso, utilizando Substring() _
        '|        _ y lo convertimos en minúsculas usando LCase, para mostrarlo en el título de mensaje.
        '|      * Mostramos el mensaje con los datos recibidos por parámetro, enviamos el enfoque al textbox _
        '|        _ que corresponda.
        '|      * Return True para salir de la función y no ejecutar el resto del código.
        '| ELSE : Si el TextBox tiene datos
        '|      * Return False para seguir ejecutando el resto del código.

        If radioButton.Checked And textBox.Text = "" Then
            clientData = UCase(clientData)
            If clientData = "DIARIO" Then clientData = "pago " & clientData
            titleMsgbox = LCase(titleMsgbox.Substring(1, titleMsgbox.Length - 1))
            MsgBox(" Verifica la información del cliente" & vbCr & vbCr &
                   " Selecciona un " & clientData & " de la lista.", vbCritical, "Error al " & titleMsgbox)
            textBox.Focus()
            Return True
        Else
            Return False
        End If
    End Function
    '
    '
    '
    Sub FillLabelsMessage()

        '-------------------------------------------------------------------------------------------------------
        '| * Llenamos los campos del formulario FrmClientesPagos con los datos que se han guardado o actualizado.
        '| * Damos formato el codigo del cliente para mostrar en el mensaje de confirmación.
        '| * Cerramos el formulario FrmNuevoEditarCliente.

        With FrmClientesPagos
            .strIdClient = strIdClient
            .LblNomCli.Text = TxtNombre.Text
            .LblApeCli.Text = TxtApellido.Text
            .FnacimientoCorto.Text = DtpFdn.Value
            .LblFdnCli.Text = FechaLarga(DtpFdn.Value)
            .LblEdadCli.Text = TxtEdad.Text
            .LblTlfCli.Text = TxtTelefono.Text
            .LblEmlCli.Text = TxtEmail.Text
            .LblDirCli.Text = TxtDireccion.Text
            If RbDiario.Checked = True Then
                .LblMtdPgoCli.Text = TxtListaNom.Text
            Else
                .LblMtdPgoCli.Text = strMtdPgs
                .LblGrpFamCli.Text = TxtListaNom.Text
            End If
            .FregistroCorto.Text = DtpFdi.Value
            .LblFdiCli.Text = FechaLarga(DtpFdi.Value)
            .LblEstCli.Text = strEstado
        End With

        Dim bodyText As String
        If BtnGuardar.Visible = True Then
            bodyText = "GUARDADOS"
        Else
            bodyText = "ACTUALIZADOS"
        End If

        If strIdClient.Length = 1 Then strIdClient = "CLI - 00" & strIdClient
        If strIdClient.Length = 2 Then strIdClient = "CLI - 0" & strIdClient
        If strIdClient.Length = 3 Then strIdClient = "CLI - " & strIdClient
        MsgBox("DATOS DEL CLIENTE" & vbCr & vbCr &
               "   NOMBRE   :  " & TxtNombre.Text & " " & TxtApellido.Text & vbCr &
               "   CODIGO   :  " & strIdClient & vbCr &
               "   -----------------------------------------------" & vbCr &
               "   Datos " & bodyText & " correctamente.", vbInformation, "Registrado")
        Close()
    End Sub
    '
    '
    '
    Sub FunReadIdClient(sqlConsulta As String)

        '| * Usamos Try-Catch para controlar posibles errores
        '| TRY :
        '|      * Conectamos y abrimos la base de datos.
        '|      * Ejecutamos la consulta recibida por parametro.
        '|      * Leemos el drDataReader y el resultado lo almacenamos en la variable strIdClient.
        '| CATCH :
        '|      * Mostramos un mensaje con el error capturado.
        '| FINALLY :
        '|      * Cerramos el datareader y la base de datos.

        Try
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()
            drDataReader.Read()
            strIdClient = drDataReader.GetInt16(0).ToString

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
    Sub FunSearchDiscountPrice(sqlConsulta)

        '-----------------------------------------------------------------------------------------------
        '| * Usamos Try-Catch para controlar posibles errores
        '| TRY :
        '|      * Conectamos y abrimos la base de datos.
        '|      * Ejecutamos la consulta recibida por parametro.
        '|      IF : Si la consulta devuelve resultados
        '|          * Leemos el drDataReader y el resultado lo almacenamos en las variables -
        '|            - "precio" y "dscnto".
        '|          * Pasamos la variable blnMarker a FALSE para no volver a llamar a esta función.
        '|      ELSE :
        '|          * Pasamos la variable blnMarker a TRUE, para hacer una nueva consulta y volver a _
        '|          * llamar a esta función.
        '| CATCH :
        '|      * Mostramos un mensaje con el error capturado.
        '| FINALLY :
        '|      * Cerramos el datareader y la base de datos.

        Try
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader

            If drDataReader.HasRows Then
                drDataReader.Read()
                precio = drDataReader.GetDecimal(0)
                dscnto = drDataReader.GetDecimal(1)
                blnMarker = False
            Else
                blnMarker = True
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
    Private Sub LlenarDgvListaNombre(sqlConsulta As String)

        'USAMOS TRY PARA CONTROLAR POSIBLES ERRORES
        Try
            'CONECTAR Y ABRIR LA BBDD
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()

            'EJECUTAMOS LA CONSULTA RECIBIDA POR PARAMETRO PARA LLENAR EL DATAGRIDVIEW
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()
            DgvListaNombre.Rows.Clear()

            'COMPROBAMOS SI HAY REGISTROS
            If drDataReader.HasRows Then
                'MIENTRS LEE EL DATAREADER LLENAMOS EL DATAGRIDVIEW
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

    End Sub

End Class