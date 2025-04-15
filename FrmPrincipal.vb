Imports MySql.Data.MySqlClient

Public Class FrmPrincipal

    'DECLARACIÓN DE VARIABLES
    Dim cnxnMySql As New MySqlConnection
    Dim drDataReader As MySqlDataReader
    Dim cmdCommand As MySqlCommand
    Dim sqlConsulta As String
    Public nomUser As String

    Private Sub FrmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        'COMPRUEBA SI EL FORMULARIO DE ESTÁ CERRANDO
        If MsgBox("¿Está seguro que desea CERRAR la aplicación?", vbQuestion + vbYesNo, "Segundos Fuera") = vbNo Then
            e.Cancel = True
        Else
            End
        End If
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'CONECTA Y ABRE LA BASE DE DATOS
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()

            'HACER CONSULTA PARA COMPROBAR SI HAY PRECIO Y DESCUENTO
            sqlConsulta = "SELECT * FROM tarifas"
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader

            If drDataReader.HasRows Then
                'CERRAR EL DATAREADER
                drDataReader.Close()

                'OBTENEMOS EL DÍA DEL MES ACTUAL
                Dim strDia As String = DateTime.Now.Day

                'COMPROBAMOS SI ES EL PRIMER DÍA DEL MES
                If strDia = 1 Then
                    'HACEMOS LA CONSULTA PARA OBTENER LOS ID Y LA FECHA DE NACIEMIENTO DE LOS CLIENTES ACTIVOS
                    sqlConsulta = "SELECT id_cli, fdn_cli FROM clientes WHERE std_cli = 'SI'"
                    cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                    drDataReader = cmdCommand.ExecuteReader()

                    'CREAMOS UN DATATABLE PARA ALMACENAR LOS ID Y LA FDN OBTENIDOS EN LA CONSULTA
                    Dim dtPago As New DataTable("Pago")
                    dtPago.Columns.Add("IdCli", GetType(Int16))
                    dtPago.Columns.Add("Descto", GetType(Decimal))
                    If drDataReader.HasRows Then
                        While drDataReader.Read()
                            Dim edad = Int(DateDiff("m", drDataReader.GetDateTime(1).ToString, Now) / 12)
                            dtPago.Rows.Add(drDataReader.GetInt16(0).ToString, edad)
                        End While
                    End If
                    drDataReader.Close()

                    'CREAMOS UN DATATABLE PARA ALMACENAR LOS ID Y LA FDN OBTENIDOS EN LA CONSULTA
                    Dim dtInsertPago As New DataTable("InsertPago")
                    dtInsertPago.Columns.Add("IdCli", GetType(Int16))
                    dtInsertPago.Columns.Add("Descto", GetType(Decimal))
                    For Each iFe As DataRow In dtPago.Rows
                        'COMPROBAR SI HAY ALGUN REGISTRO CON EL PRIMER DÍA DEL MES
                        sqlConsulta = "SELECT fdi_pgs, id_cli FROM pagos WHERE fdi_pgs = '" & DateTime.Now.ToString("yyyy-MM-dd") & "' AND id_cli = '" & iFe("IdCli") & "'"
                        cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                        drDataReader = cmdCommand.ExecuteReader
                        If Not drDataReader.HasRows Then
                            dtInsertPago.Rows.Add(iFe("IdCli"), iFe("Descto"))
                        End If
                        drDataReader.Close()
                    Next

                    'SELECCIONAMOS EL DESCUENTO Y EL PRECIO Y AGREGAMOS EL CAMPO PRECIO
                    dtInsertPago.Columns.Add("Precio", GetType(Decimal))
                    For Each iFe As DataRow In dtInsertPago.Rows
                        sqlConsulta = "SELECT precio, dscto FROM tarifas WHERE e_min <= '" & iFe("Descto") & "' AND e_max >= '" & iFe("Descto") & "'"
                        cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                        drDataReader = cmdCommand.ExecuteReader
                        drDataReader.Read()
                        iFe("Precio") = drDataReader.GetDecimal(0).ToString
                        iFe("Descto") = drDataReader.GetDecimal(1).ToString
                        drDataReader.Close()
                    Next

                    'AGREGAMOS LOS NUEVOS REGISTROS EN LA TABLA PAGOS
                    For Each iFe As DataRow In dtInsertPago.Rows
                        Dim precio = Replace(iFe("Precio"), ",", ".")
                        Dim descto = Replace(iFe("Descto"), ",", ".")
                        sqlConsulta = "INSERT INTO pagos (fdi_pgs, fdp_pgs, frm_pgs, prc_pgs, dsc_pgs, id_cli, usuario)
                                      VALUES ('" & DateTime.Now.ToString("yyyy-MM-dd") & "', '0101-01-01', '',
                                      '" & precio & "', '" & descto & "', '" & iFe("IdCli") & "','')"
                        cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                        drDataReader = cmdCommand.ExecuteReader()
                        drDataReader.Close()
                    Next

                    'BORRAMOS LOS DATATABLE dtPago Y dtInsertPago
                    dtPago = Nothing
                    dtInsertPago = Nothing
                End If

                'EJECUTA EL FORMULARIO LISTA MOROSOS
                FrmListaMorosos.MdiParent = Me
                FrmListaMorosos.Show()
            Else
                'CERRAR EL DATAREADER
                drDataReader.Close()

                'DESHABILITAR BOTONES
                BtnListaClientes.Enabled = False
                BtnClientesPagos.Enabled = False
                BtnPagoPendiente.Enabled = False

                'EJECUTA EL FORMULARIO LISTA MOROSOS
                FrmTablaDescuento.MdiParent = Me
                FrmTablaDescuento.Show()
            End If

            'CERRAR BBDD
            cnxnMySql.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Me.Text = Me.Text & nomUser 'AGREGAR NOMBRE DE USUARIO A LA BARRA DE TITULO
    End Sub

    Private Sub BtnListaClientes_Click(sender As Object, e As EventArgs) Handles BtnListaClientes.Click
        FrmListaClientes.MdiParent = Me
        FrmListaClientes.Show()
    End Sub

    Private Sub BtnClientesPagos_Click(sender As Object, e As EventArgs) Handles BtnClientesPagos.Click
        FrmClientesPagos.MdiParent = Me
        FrmClientesPagos.Show()
    End Sub

    Private Sub BtnPagoPendiente_Click(sender As Object, e As EventArgs) Handles BtnPagoPendiente.Click
        'EJECUTA FORMULARIO LISTA MOROSOS
        FrmListaMorosos.MdiParent = Me
        FrmListaMorosos.Show()
    End Sub

    Private Sub BtnPrecioDsctos_Click(sender As Object, e As EventArgs) Handles BtnPrecioDsctos.Click
        'EJECTA FORMULARIO TABLA DE DESCUENTOS
        FrmTablaDescuento.MdiParent = Me
        FrmTablaDescuento.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        'CIERRA EL FORMULARIO
        Close()
    End Sub
End Class