Imports System.Configuration
Imports MySql.Data.MySqlClient

Module FillOutRecords

    ReadOnly cnxnMySql As New MySqlConnection
    Dim cmdCommand As MySqlCommand
    Dim drDataReader As MySqlDataReader

    Dim nRow, cMes, cReg, id_pgs, id_grp, nMembers As Int16
    Dim sTotal As Decimal


    Sub Sub_Dgv_Family_Group(ByVal sqlQueries As String, ByVal dataGridView As DataGridView)

        '| * Usamos Try-Catch para controlar posibles errores
        '| TRY :
        '|      * Conectamos y abrimos la base de datos.
        '|      * Ejecutamos la consulta recibida por parametro.
        '|
        '|
        '|
        '|
        '| CATCH :
        '|      * Mostramos un mensaje con el error capturado.
        '| FINALLY :
        '|      * Cerramos el datareader y la base de datos.

        Try
            cnxnMySql.ConnectionString = ConfigurationManager.ConnectionStrings("MyConnectionMySQL").ConnectionString
            cnxnMySql.Open()
            cmdCommand = New MySqlCommand(sqlQueries, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()

            With dataGridView

                .Rows.Clear()

                If drDataReader.HasRows Then

                    While drDataReader.Read()

                        If id_grp = drDataReader.GetInt16(6) Then

                            If id_pgs = drDataReader.GetInt16(5) Then

                                .Rows.Add()
                                .Rows(nRow).Cells(0).Value = drDataReader.GetString(0) 'INTEGRANTES
                                .Rows(nRow).Cells(10).Value = drDataReader.GetInt16(6) 'ID DEL GRUPO
                                .Rows(nRow).Cells(11).Value = drDataReader.GetInt16(7) 'NUM DE INTEGRANTES
                                .Rows(nRow).Cells(12).Value = drDataReader.GetString(1) & " - " & drDataReader.GetInt16(6)   'NOMBRE GRUPO MAS INTEGRANTES

                                nRow += 1
                                nMembers += 1

                            Else

                                .Rows.Add()
                                .Rows(nRow).Cells(2).Value = drDataReader.GetDateTime(2) 'MES Y AÑO
                                .Rows(nRow).Cells(3).Value = drDataReader.GetDecimal(3) 'PRECIO
                                .Rows(nRow).Cells(4).Value = drDataReader.GetDecimal(4) 'DESCUENTO
                                .Rows(nRow).Cells(5).Value = FormatCurrency(drDataReader.GetDecimal(3) - drDataReader.GetDecimal(4)) 'TOTAL
                                .Rows(nRow).Cells(6).Value = 0 'NUM DE DIAS
                                .Rows(nRow).Cells(7).Value = FormatCurrency(46) 'A PAGAR
                                nRow += 1

                            End If

                        Else


                            .Rows.Add()
                            .Rows(nRow).Cells(0).Value = drDataReader.GetString(0) 'INTEGRANTES
                            .Rows(nRow).Cells(1).Value = drDataReader.GetString(1) 'NOMBRE DEL GRUPO
                            .Rows(nRow).Cells(2).Value = drDataReader.GetDateTime(2) 'MES Y AÑO
                            .Rows(nRow).Cells(3).Value = drDataReader.GetDecimal(3) 'PRECIO
                            .Rows(nRow).Cells(4).Value = drDataReader.GetDecimal(4) 'DESCUENTO
                            .Rows(nRow).Cells(5).Value = FormatCurrency(drDataReader.GetDecimal(3) - drDataReader.GetDecimal(4)) 'TOTAL
                            .Rows(nRow).Cells(6).Value = 0 'NUM DE DIAS
                            .Rows(nRow).Cells(7).Value = FormatCurrency(46) 'A PAGAR

                            .Rows(nRow).Cells(9).Value = drDataReader.GetInt16(5) 'ID DEL PAGO
                            .Rows(nRow).Cells(10).Value = drDataReader.GetInt16(6) 'ID DEL GRUPO
                            .Rows(nRow).Cells(11).Value = drDataReader.GetInt16(7) 'NUM DE INTEGRANTES
                            .Rows(nRow).Cells(12).Value = drDataReader.GetString(1) & " - " & drDataReader.GetInt16(6)   'NOMBRE GRUPO MAS INTEGRANTES

                            id_pgs = drDataReader.GetInt16(5) 'ID DEL PAGO
                            id_grp = drDataReader.GetInt16(6) 'ID DEL GRUPO

                            nRow += 1
                            nMembers += 1

                        End If
                        '
                        '
                        '
                        '
                        'comparamos el id del pago si es igual
                        'If nMembers = drDataReader.GetInt16(7) Then

                        '    nRow += 1

                        '    .Rows.Add()
                        '    .Rows(nRow).Height = 30
                        '    .Rows(nRow).DefaultCellStyle.BackColor = Color.LightSalmon
                        '    .Rows(nRow).DefaultCellStyle.ForeColor = Color.Red
                        '    .Rows(nRow).DefaultCellStyle.Font = New Drawing.Font("arial", 10, FontStyle.Bold)
                        '    .Rows(nRow).Cells(5).Value = "DEBE : "
                        '    .Rows(nRow).Cells(6).Value = cMes & " MESES"
                        '    .Rows(nRow).Cells(7).Value = FormatCurrency(1979) 'sumatoria 'stotal

                        '    nRow += 1

                        '    nMembers = 0

                        'End If


                    End While

                End If

            End With

        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            drDataReader.Close()
            cnxnMySql.Close()
        End Try

    End Sub


    'Sub CreateColumnsDgv(ByVal dataGridView As DataGridView)
    '' ---------------------------------------------------------
    '' * Limpiar el Datagridview, para clear las nuevas columnas
    '' ---------------------------------------------------------
    'dataGridView.Columns.Clear()
    '' ---------------------------------------------
    '' * DEFINIMOS EL ESTILO DEL ENCABEZADO (Header)
    '' ---------------------------------------------
    'Dim headerStyle As New DataGridViewCellStyle()
    'headerStyle.Font = New Font("Linux Libertine Display G", 9.75, FontStyle.Bold)
    'headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    'headerStyle.BackColor = SystemColors.Control
    'headerStyle.ForeColor = SystemColors.ControlText
    'dataGridView.ColumnHeadersDefaultCellStyle = headerStyle
    '' -----------------------------------
    '' * Agregar las Columnas Individuales
    '' -----------------------------------
    'dataGridView.Columns.Add("mesanio_pgs", "MES Y AÑO")
    'dataGridView.Columns("id_pgs").Visible = False
    'dataGridView.Columns("mesanio_pgs").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
    'dataGridView.Columns("mesanio_pgs").Resizable = DataGridViewTriState.False
    'dataGridView.Columns("mesanio_pgs").SortMode = DataGridViewColumnSortMode.NotSortable
    'dataGridView.Columns("mesanio_pgs").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
    'dataGridView.Columns("mesanio_pgs").Width = 128
    'End Sub
End Module
