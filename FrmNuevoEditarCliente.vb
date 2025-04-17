Imports MySql.Data.MySqlClient
Imports Mysqlx.Cursor

Public Class FrmNuevoEditarCliente

    Dim cnxnMySql As New MySqlConnection
    Dim drDataReader As MySqlDataReader
    Dim cmdCommand As MySqlCommand
    Dim sqlConsulta As String
    Dim fila As Int16
    Public Shared strIdCli As String

    Private Sub NuevoEditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' COMPROBAMOS EL TÍTULO PARA DESACTIVAR UN BOTON
        If Me.Text = "Registrar nuevo cliente" Then
            BtnActualizar.Enabled = False
        Else
            BtnGuardar.Enabled = False
        End If

        'VARIABLE PARA ALMACENAR LA FECHA ACTUAL
        Dim ano = Year(Date.Now)

        'ASIGNAR VALORES NIM Y MAX A LOS DATETIMEPICKER
        DtpFdn.MinDate = "01/01/" & ano - 99
        DtpFdn.MaxDate = DateTime.Now
        DtpFdi.MinDate = "01/01/" & ano - 1
        DtpFdi.MaxDate = "31/12/" & ano + 1
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        'COMPROBAMOS SI HAY INFORMACION DEL CLIENTE EN LOS TEXTBOX
        If TxtNombre.Text = "" Then MsgBox("Ingrese el NOMBRE del cliente.", vbCritical, "Guardar Datos Cliente") : TxtNombre.Focus() : Exit Sub
        If TxtApellido.Text = "" Then MsgBox("Ingrese el APELLIDO del cliente.", vbCritical, "Guardar Datos Cliente") : TxtApellido.Focus() : Exit Sub
        If TxtEdad.Text = "" Or TxtEdad.Text = "0 años" Then MsgBox("Verifica la fecha de NACIMIENTO del cliente.", vbCritical, "Guardar Datos Cliente") : DtpFdn.Focus() : Exit Sub

        Try
            'CONECTAR Y ABRIR LA BBDD
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()

            'AGREGAMOS EL NUEVO CLIENTE A LA TABLA CLIENTES
            sqlConsulta = "INSERT INTO clientes (nom_cli, ape_cli, fdn_cli, tlf_cli, eml_cli, dir_cli, fdi_cli, std_cli) VALUES 
                          ('" & TxtNombre.Text & "', '" & TxtApellido.Text & "', '" & DtpFdn.Value.ToString("yyyy-MM-dd") & "', '" & TxtTelefono.Text & "', 
                          '" & TxtEmail.Text & "', '" & TxtDireccion.Text & "', '" & DtpFdi.Value.Date.ToString("yyyy-MM-dd") & "', 'SI')"
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

            'VARIABLES PARA ALMACENAR EL PRECIO Y EL DSCTO
            Dim precio, descto As Decimal
            'SELECCIONAMOS EL DESCUENTO CORRESPONDIENTE A LA EDAD
            sqlConsulta = "SELECT * FROM tarifas WHERE e_min <= '" & TxtEdad.Text & "' AND e_max >= '" & TxtEdad.Text & "'"
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader
            'COMPROBAMOS SI HAY REGISTROS
            If drDataReader.HasRows Then
                drDataReader.Read()
                precio = drDataReader.GetDecimal(1) 'Replace(drDataReader.GetDecimal(1).ToString, ",", ".")
                descto = drDataReader.GetDecimal(4) 'Replace(drDataReader.GetDecimal(4).ToString, ",", ".")
            Else
                drDataReader.Close()
                sqlConsulta = "SELECT precio FROM tarifas WHERE id_tarifa = 1"
                cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                drDataReader = cmdCommand.ExecuteReader
                drDataReader.Read()
                precio = drDataReader.GetDecimal(0) 'Replace(drDataReader.GetDecimal(0).ToString, ",", ".")
                descto = 0
            End If
            drDataReader.Close()

            'AGREGAMOS UN NUEVO REGISTRO EN LA TABLA PAGOS
            sqlConsulta = "INSERT INTO pagos (fdi_pgs, fdp_pgs, frm_pgs, prc_pgs, dsc_pgs, id_cli, usuario)
                          VALUES ('" & DateTime.Now.ToString("yyyy-MM-dd") & "', '0101-01-01', '',
                          '" & Replace(precio, ",", ".") & "', '" & Replace(descto, ",", ".") & "', '" & strIdCli & "', '')"
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()
            drDataReader.Close()

            'CERRAR BBDD
            cnxnMySql.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        'DAR FORMATO EL CODIGO DEL CLIENTE
        If strIdCli.Length = 1 Then strIdCli = "CLI - 00" & strIdCli
        If strIdCli.Length = 2 Then strIdCli = "CLI - 0" & strIdCli
        If strIdCli.Length = 3 Then strIdCli = "CLI - " & strIdCli

        'MOSTRAMOS UN MESAJE DE CONFIRMACIÓN
        MsgBox("Datos GUARDADOS satisfactoriamente." & Chr(13) & Chr(13) _
                & "NOMBRE   :  " & TxtNombre.Text & " " & TxtApellido.Text & Chr(13) _
                & "CODIGO   :  " & strIdCli, vbInformation, "Guardar Cliente")

        FrmListaClientes.TxtBuscarCliente.Text = TxtNombre.Text

        Close()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        'COMPROBAMOS SI HAYINFORMACION DEL CLIENTE
        If TxtNombre.Text = "" Then MsgBox("Ingrese el NOMBRE del cliente.", vbCritical, "Actualizar Datos Cliente") : TxtNombre.Focus() : Exit Sub
        If TxtApellido.Text = "" Then MsgBox("Ingrese la DIRECCION del cliente.", vbCritical, "Actualizar Datos Cliente") : TxtApellido.Focus() : Exit Sub
        If TxtEdad.Text = "" Or TxtEdad.Text = "0 años" Then MsgBox("Verifica la fecha de NACIMIENTO del cliente.", vbCritical, "Actualizar Datos Cliente") : DtpFdn.Focus() : Exit Sub

        Try
            'CONECTAR Y ABRIR LA BBDD
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()

            'ACTUALIZAMOS LOS DATOS DEL CLIENTE
            sqlConsulta = "UPDATE clientes SET nom_cli='" & TxtNombre.Text & "', ape_cli='" & TxtApellido.Text & "', fdn_cli='" & DtpFdn.Value.ToString("yyyy-MM-dd") & "', 
                          tlf_cli='" & TxtTelefono.Text & "', eml_cli='" & TxtEmail.Text & "', dir_cli='" & TxtDireccion.Text & "', 
                          fdi_cli='" & DtpFdi.Value.ToString("yyyy-MM-dd") & "' WHERE id_cli='" & strIdCli & "'"
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader
            drDataReader.Close()

            'CARRAR BBDD
            cnxnMySql.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        'DAR FORMATO EL CODIGO DEL CLIENTE
        If strIdCli.Length = 1 Then strIdCli = "CLI - 00" & strIdCli
        If strIdCli.Length = 2 Then strIdCli = "CLI - 0" & strIdCli
        If strIdCli.Length = 3 Then strIdCli = "CLI - " & strIdCli

        'ENVIAMOS UN MENSAJE DE CONFIRMACION
        MsgBox("Datos ACTUALIZADOS satisfactoriamente." & Chr(13) & Chr(13) _
            & "NOMBRE   :  " & TxtNombre.Text & " " & TxtApellido.Text & Chr(13) _
            & "CODIGO   :  " & strIdCli, vbInformation, "Actualizar Cliente")

        FrmListaClientes.TxtBuscarCliente.Text = TxtNombre.Text

        Close()

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        'CERRAR VENTANA
        Close()
    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        'validar
    End Sub

    Private Sub TxtNombre_GotFocus(sender As Object, e As EventArgs) Handles TxtNombre.GotFocus
        'CAMBIAR COLOR
        TxtNombre.BackColor = Color.Beige
    End Sub

    Private Sub TxtNombre_LostFocus(sender As Object, e As EventArgs) Handles TxtNombre.LostFocus
        'FUNCION PARA BORRAR ESPACIOS EN BLANCO Y CAMBIO DE COLOR
        TxtLostFocus(TxtNombre)
    End Sub

    Private Sub TxtApellido_TextChanged(sender As Object, e As EventArgs) Handles TxtApellido.TextChanged
        'validar
    End Sub

    Private Sub TxtApellido_GotFocus(sender As Object, e As EventArgs) Handles TxtApellido.GotFocus
        'CAMBIAR COLOR
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
        If dtpEdad < 1 Then TxtEdad.Text = "0 años"
        If dtpEdad > 99 Then TxtEdad.Text = "99 años"
    End Sub

    Private Sub DtpFdn_GotFocus(sender As Object, e As EventArgs) Handles DtpFdn.GotFocus
        'CAMBIAR COLOR
        TxtEdad.BackColor = Color.Beige
    End Sub

    Private Sub DtpFdn_LostFocus(sender As Object, e As EventArgs) Handles DtpFdn.LostFocus
        'CAMBIAR COLOR 
        TxtEdad.BackColor = Color.Azure
        If TxtEdad.Text = "" Then TxtEdad.BackColor = Color.MistyRose
    End Sub

    Private Sub TxtTelefono_TextChanged(sender As Object, e As EventArgs) Handles TxtTelefono.TextChanged
        'validar
    End Sub

    Private Sub TxtTelefono_GotFocus(sender As Object, e As EventArgs) Handles TxtTelefono.GotFocus
        'CAMBIAR COLOR
        TxtTelefono.BackColor = Color.Beige
    End Sub

    Private Sub TxtTelefono_LostFocus(sender As Object, e As EventArgs) Handles TxtTelefono.LostFocus
        'FUNCION PARA BORRAR ESPACIOS EN BLANCO Y CAMBIO DE COLOR
        TxtLostFocus(TxtTelefono)
    End Sub

    Private Sub TxtEmail_TextChanged(sender As Object, e As EventArgs) Handles TxtEmail.TextChanged
        'validar
    End Sub

    Private Sub TxtEmail_GotFocus(sender As Object, e As EventArgs) Handles TxtEmail.GotFocus
        'CAMBIAR COLOR
        TxtEmail.BackColor = Color.Beige
    End Sub

    Private Sub TxtEmail_LostFocus(sender As Object, e As EventArgs) Handles TxtEmail.LostFocus
        'FUNCION PARA BORRAR ESPACIOS EN BLANCO Y CAMBIO DE COLOR
        TxtLostFocus(TxtEmail)
    End Sub

    Private Sub TxtDireccion_TextChanged(sender As Object, e As EventArgs) Handles TxtDireccion.TextChanged
        'validar
    End Sub

    Private Sub TxtDireccion_GotFocus(sender As Object, e As EventArgs) Handles TxtDireccion.GotFocus
        'CAMBIAR COLOR
        TxtDireccion.BackColor = Color.Beige
    End Sub

    Private Sub TxtDireccion_LostFocus(sender As Object, e As EventArgs) Handles TxtDireccion.LostFocus
        'FUNCION PARA BORRAR ESPACIOS EN BLANCO Y CAMBIO DE COLOR
        TxtLostFocus(TxtDireccion)
    End Sub

    ''---------->>>>>>>>>> PROCEDIMIENTOS <<<<<<<<<<----------''
    Sub TxtLostFocus(ByVal TxtCadena As TextBox)
        TxtCadena.Text = Trim(TxtCadena.Text)
        While TxtCadena.Text.Contains("  ")
            TxtCadena.Text = TxtCadena.Text.Replace("  ", " ")
        End While
        TxtCadena.BackColor = Color.Azure
        If TxtCadena.Text = "" Then TxtCadena.BackColor = Color.MistyRose
    End Sub

End Class