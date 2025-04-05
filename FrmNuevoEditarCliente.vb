Imports MySql.Data.MySqlClient

Public Class FrmNuevoEditarCliente
    '
    Dim cnxnMySql As New MySqlConnection
    Dim drDataReader As MySqlDataReader
    Dim cmdCommand As MySqlCommand
    Dim sqlConsulta As String
    Dim fila As Int16
    Public Shared strIdCli As String
    '
    Private Sub NuevoEditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' COMPROBAMOS EL TÍTULO PARA DESACTIVAR UN BOTON
        If Me.Text = "Registrar nuevo cliente" Then
            'BtnGuardar.Enabled = True
            BtnActualizar.Enabled = False
            'TxtNombre.Clear()
            'TxtApellido.Clear()
            ''DtpFdn .Value =
            'TxtEdad.ResetText()
            'TxtTelefono.Clear()
            'TxtEmail.Clear()
            'TxtDireccion.Clear()
            ''DtpFdi .Value =
        Else
            BtnGuardar.Enabled = False
            'BtnActualizar.Enabled = True
        End If
        '
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        '
        'COMPROBAMOS SI HAY INFORMACION DEL CLIENTE EN LOS TEXTBOX
        If TxtNombre.Text = "" Then MsgBox("Ingrese el NOMBRE del cliente.", vbCritical, "Guardar Datos Cliente") : TxtNombre.Focus() : Exit Sub
        If TxtApellido.Text = "" Then MsgBox("Ingrese el APELLIDO del cliente.", vbCritical, "Guardar Datos Cliente") : TxtApellido.Focus() : Exit Sub
        'If dtpfdn.value= "" Then MsgBox "Ingrese la fecha de NACIMIENTO del cliente.", vbCritical, "Guardar Datos Cliente": dtpfdn.Focus : Exit Sub
        'QUITAR ESPACIOS EN BLANCO TxtClientes(intIndex).Text = Trim(TxtClientes(intIndex).Text)
        '
        Try
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

            'SELECCIONAMOS EL DESCUENTO CORRESPONDIENTE POR LA EDAD
            sqlConsulta = "SELECT * FROM tarifas WHERE e_min <= '" & TxtEdad.Text & "' AND e_max >= '" & TxtEdad.Text & "'"
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader
            drDataReader.Read()
            Dim precio = Replace(drDataReader.GetDecimal(1).ToString, ",", ".")
            Dim descto = Replace(drDataReader.GetDecimal(4).ToString, ",", ".")
            drDataReader.Close()

            'AGREGAMOS UN NUEVO REGISTRO EN LA TABLA PAGOS
            sqlConsulta = "INSERT INTO pagos (fdi_pgs, fdp_pgs, frm_pgs, prc_pgs, dsc_pgs, id_cli) VALUES 
                          ('" & DateTime.Now.ToString("yyyy-MM-dd") & "', '0101-01-01', '', '" & precio & "', '" & descto & "', '" & strIdCli & "')"
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()
            drDataReader.Close()

            cnxnMySql.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        If strIdCli.Length = 1 Then strIdCli = "CLI-00" & strIdCli
        If strIdCli.Length = 2 Then strIdCli = "CLI-0" & strIdCli
        If strIdCli.Length = 3 Then strIdCli = "CLI-" & strIdCli
        'MOSTRAMOS UN MESAJE DE CONFIRMACIÓN
        MsgBox("Datos GUARDADOS satisfactoriamente." & Chr(13) & Chr(13) _
                & "NOMBRE   :  " & TxtNombre.Text & " " & TxtApellido.Text & Chr(13) _
                & "CODIGO   :  " & strIdCli, vbInformation, "Guardar Cliente")

        FrmListaClientes.TxtBuscarCliente.Text = TxtNombre.Text
        'FrmListaClientes.DgvListaClientes.Sort(FrmListaClientes.DgvListaClientes.Columns(8), System.ComponentModel.ListSortDirection.Descending)
        'dgvConsultaEstudiante.Sort(dgvConsultaEstudiante.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        Close()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        '
        'COMPROBAMOS SI HAYINFORMACION DEL CLIENTE
        If TxtNombre.Text = "" Then MsgBox("Ingrese el NOMBRE del cliente.", vbCritical, "Actualizar Datos Cliente") : TxtNombre.Focus() : Exit Sub
        If TxtApellido.Text = "" Then MsgBox("Ingrese la DIRECCION del cliente.", vbCritical, "Actualizar Datos Cliente") : TxtApellido.Focus() : Exit Sub
        'If dtpfdn.value= "" Then MsgBox "Ingrese la fecha de NACIMIENTO del cliente.", vbCritical, "Guardar Datos Cliente": dtpfdn.Focus : Exit Sub
        'QUITAR ESPACIOS EN BLANCO TxtClientes(intIndex).Text = Trim(TxtClientes(intIndex).Text)
        '
        Try
            '
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()
            '
            'ACTUALIZAMOS LOS DATOS DEL CLIENTE
            sqlConsulta = "UPDATE clientes SET nom_cli='" & TxtNombre.Text & "', ape_cli='" & TxtApellido.Text & "', fdn_cli='" & DtpFdn.Value.ToString("yyyy-MM-dd") & "', 
                          tlf_cli='" & TxtTelefono.Text & "', eml_cli='" & TxtEmail.Text & "', dir_cli='" & TxtDireccion.Text & "', 
                          fdi_cli='" & DtpFdi.Value.ToString("yyyy-MM-dd") & "' WHERE id_cli='" & strIdCli & "'" ', std_cli='" & strEstado & "' 
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
        If strIdCli.Length = 1 Then strIdCli = "CLI-00" & strIdCli
        If strIdCli.Length = 2 Then strIdCli = "CLI-0" & strIdCli
        If strIdCli.Length = 3 Then strIdCli = "CLI-" & strIdCli
        'ENVIAMOS UN MENSAJE DE CONFIRMACION
        MsgBox("Datos ACTUALIZADOS satisfactoriamente." & Chr(13) & Chr(13) _
            & "NOMBRE   :  " & TxtNombre.Text & " " & TxtApellido.Text & Chr(13) _
            & "CODIGO   :  " & strIdCli, vbInformation, "Actualizar Cliente")
        '
        FrmListaClientes.TxtBuscarCliente.Text = TxtNombre.Text
        'FrmListaClientes.DgvListaClientes.Sort(FrmListaClientes.DgvListaClientes.Columns(8), System.ComponentModel.ListSortDirection.Descending)
        Close()
        '
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        '
        Close()
        '
    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        'validar
    End Sub

    Private Sub TxtNombre_GotFocus(sender As Object, e As EventArgs) Handles TxtNombre.GotFocus
        '
        TxtNombre.BackColor = Color.Beige
        '
    End Sub

    Private Sub TxtNombre_LostFocus(sender As Object, e As EventArgs) Handles TxtNombre.LostFocus
        '
        TxtNombre.BackColor = Color.Azure
        If TxtNombre.Text = "" Then TxtNombre.BackColor = Color.MistyRose
        '
    End Sub

    Private Sub TxtApellido_TextChanged(sender As Object, e As EventArgs) Handles TxtApellido.TextChanged
        'validar
    End Sub

    Private Sub TxtApellido_GotFocus(sender As Object, e As EventArgs) Handles TxtApellido.GotFocus
        '
        TxtApellido.BackColor = Color.Beige
        '
    End Sub

    Private Sub TxtApellido_LostFocus(sender As Object, e As EventArgs) Handles TxtApellido.LostFocus
        '
        TxtApellido.BackColor = Color.Azure
        If TxtApellido.Text = "" Then TxtApellido.BackColor = Color.MistyRose
        '
    End Sub

    Private Sub DtpFdn_ValueChanged(sender As Object, e As EventArgs) Handles DtpFdn.ValueChanged
        '
        TxtEdad.Text = Int(DateDiff("m", DtpFdn.Value, Now) / 12) & " años"
        '
    End Sub

    Private Sub DtpFdn_GotFocus(sender As Object, e As EventArgs) Handles DtpFdn.GotFocus
        '
        TxtEdad.BackColor = Color.Beige
        '
    End Sub

    Private Sub DtpFdn_LostFocus(sender As Object, e As EventArgs) Handles DtpFdn.LostFocus
        '
        TxtEdad.BackColor = Color.Azure
        '
    End Sub

    Private Sub TxtTelefono_TextChanged(sender As Object, e As EventArgs) Handles TxtTelefono.TextChanged
        'validar
    End Sub

    Private Sub TxtTelefono_GotFocus(sender As Object, e As EventArgs) Handles TxtTelefono.GotFocus
        '
        TxtTelefono.BackColor = Color.Beige
        '
    End Sub

    Private Sub TxtTelefono_LostFocus(sender As Object, e As EventArgs) Handles TxtTelefono.LostFocus
        '
        TxtTelefono.BackColor = Color.Azure
        '
    End Sub

    Private Sub TxtEmail_TextChanged(sender As Object, e As EventArgs) Handles TxtEmail.TextChanged
        'validar
    End Sub

    Private Sub TxtEmail_GotFocus(sender As Object, e As EventArgs) Handles TxtEmail.GotFocus
        '
        TxtEmail.BackColor = Color.Beige
        '
    End Sub

    Private Sub TxtEmail_LostFocus(sender As Object, e As EventArgs) Handles TxtEmail.LostFocus
        '
        TxtEmail.BackColor = Color.Azure
        '
    End Sub

    Private Sub TxtDireccion_TextChanged(sender As Object, e As EventArgs) Handles TxtDireccion.TextChanged
        'validar
    End Sub

    Private Sub TxtDireccion_GotFocus(sender As Object, e As EventArgs) Handles TxtDireccion.GotFocus
        '
        TxtDireccion.BackColor = Color.Beige
        '
    End Sub

    Private Sub TxtDireccion_LostFocus(sender As Object, e As EventArgs) Handles TxtDireccion.LostFocus
        '
        TxtDireccion.BackColor = Color.Azure
        '
    End Sub
    '
End Class