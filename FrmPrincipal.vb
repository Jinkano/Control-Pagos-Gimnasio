Imports MySql.Data.MySqlClient

Public Class FrmPrincipal

    'DECLARACIÓN DE VARIABLES
    Dim cnxnMySql As New MySqlConnection
    Dim drDataReader As MySqlDataReader
    Dim cmdCommand As MySqlCommand
    Dim sqlConsulta As String

    Private Sub FrmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        'COMPRUEBA SI EL FORMULARIO DE ESTÁ CERRANDO
        If MsgBox("¿Está seguro que desea CERRAR la aplicación?", vbQuestion + vbYesNo, "Segundos Fuera") = vbNo Then
            e.Cancel = True
        Else
            End
        End If
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strDia As String = DateTime.Now.Day 'OBTENEMOS EL DÍA DEL MES ACTUAL

        'COMPROBAMOS SI ES EL PRIMER DÍA DEL MES
        If strDia = 25 Then
            Try
                cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
                cnxnMySql.Open()

                'HACEMOS LA CONSULTA PARA OBTENER LOS ID Y LA FECHA DE NACIEMIENTO DE LOS CLIENTES ACTIVOS
                'CREAMOS UN DATATABLE PARA ALMACENAR LOS ID Y LA FDN OBTENIDOS EN LA CONSULTA
                sqlConsulta = "SELECT id_cli, fdn_cli FROM clientes WHERE std_cli = 'SI'"
                cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                drDataReader = cmdCommand.ExecuteReader()
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
                'preguntamos SI HAY ALGUN REGISTRO CON EL PRIMER DÍA DEL MES)
                Dim dtInsertPago As New DataTable("InsertPago")
                dtInsertPago.Columns.Add("IdCli", GetType(Int16))
                dtInsertPago.Columns.Add("Descto", GetType(Decimal))
                For Each iFe As DataRow In dtPago.Rows
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
                    sqlConsulta = "INSERT INTO pagos (fdi_pgs, fdp_pgs, frm_pgs, prc_pgs, dsc_pgs, id_cli) VALUES
                                 ('" & DateTime.Now.ToString("yyyy-MM-dd") & "', '0101-01-01', '', '" & precio & "', '" & descto & "', '" & iFe("IdCli") & "')"
                    cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                    drDataReader = cmdCommand.ExecuteReader()
                    drDataReader.Close()
                Next

                'BORRAMOS LOS DATATABLE dtPago Y dtInsertPago
                dtPago = Nothing
                dtInsertPago = Nothing
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

        'EJECUTA EL FORMULARIO LISTA MOROSOS
        FrmListaMorosos.MdiParent = Me
        FrmListaMorosos.Show()
    End Sub

    Private Sub BtnListaClientes_Click(sender As Object, e As EventArgs) Handles BtnListaClientes.Click

        'EJECUTA EL FORMULARIO *-*-*
        'FrmListaClientes.MdiParent = Me
        'FrmListaClientes.Show()
        FrmClientesPagos.MdiParent = Me
        FrmClientesPagos.Show()
    End Sub

    Private Sub BtnListaMorosos_Click(sender As Object, e As EventArgs) Handles BtnListaMorosos.Click

        'EJECUTA FORMULARIO LISTA MOROSOS
        FrmListaMorosos.MdiParent = Me
        FrmListaMorosos.Show()
    End Sub

    Private Sub BtnTablaDsctos_Click(sender As Object, e As EventArgs) Handles BtnTablaDsctos.Click

        'EJECTA FORMULARIO TABLA DE DESCUENTOS
        FrmTablaDescuento.MdiParent = Me
        FrmTablaDescuento.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        'CIERRA EL FORMULARIO
        Close()
    End Sub

End Class