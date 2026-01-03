Imports System.Configuration
Imports System.Data
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Crmf

Module ModuleTest
    '
    Dim cnxnMySql As New MySqlConnection
    Dim cmdCommand As MySqlCommand
    Dim drDataReader As MySqlDataReader
    '
    Dim dtDataTable As New DataTable
    '
    Dim nRow, cMes, cReg, idCli As Int16
    Dim sTotal As Decimal
    Dim arrayMeses() As String = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}
    '

    Public Sub ListaClientes(ByVal SqlConsulta As String, CmbBuscar As String, ByVal DgvListaClientes As DataGridView)

        Try
            cnxnMySql.ConnectionString = ConfigurationManager.ConnectionStrings("MyConnectionMySQL").ConnectionString
            'cnxnMySql.ConnectionString = "server=localhost; user=root; password=MySQL€051179.jwir; database=control_pagos"
            cnxnMySql.Open()
            cmdCommand = New MySqlCommand(SqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()

            DgvListaClientes.Rows.Clear()

            If drDataReader.HasRows Then

                While drDataReader.Read()
                    nRow = DgvListaClientes.Rows.Add()
                    DgvListaClientes.Rows(nRow).Cells(0).Value = drDataReader.GetString(1).ToString 'NOMBRE
                    DgvListaClientes.Rows(nRow).Cells(1).Value = drDataReader.GetString(2).ToString 'APELLIDO
                    DgvListaClientes.Rows(nRow).Cells(2).Value = Int(DateDiff("m", drDataReader.GetDateTime(3).ToString("yyyy-MM-dd"), Now) / 12) & " años" 'EDAD
                    DgvListaClientes.Rows(nRow).Cells(3).Value = Fun_Long_Date(drDataReader.GetDateTime(3).ToShortDateString) 'FECHA DE NACIMIENTO
                    DgvListaClientes.Rows(nRow).Cells(4).Value = drDataReader.GetString(4).ToString 'TELEFONO
                    DgvListaClientes.Rows(nRow).Cells(5).Value = drDataReader.GetString(5).ToString 'E-MAIL
                    DgvListaClientes.Rows(nRow).Cells(6).Value = drDataReader.GetString(6).ToString 'DIRECCION
                    DgvListaClientes.Rows(nRow).Cells(7).Value = Fun_Long_Date(drDataReader.GetDateTime(7).ToShortDateString) 'FECHA DE INSCRIPCION
                    DgvListaClientes.Rows(nRow).Cells(8).Value = drDataReader.GetInt16(0).ToString 'ID
                    DgvListaClientes.Rows(nRow).Cells(9).Value = drDataReader.GetString(8).ToString 'ESTADO
                End While

                Select Case CmbBuscar

                    Case "Nombre"
                        DgvListaClientes.CurrentCell = DgvListaClientes.Item(0, 0)

                    Case "Apellido"
                        DgvListaClientes.CurrentCell = DgvListaClientes.Item(1, 0)

                    Case "Teléfono"
                        DgvListaClientes.CurrentCell = DgvListaClientes.Item(4, 0)
                End Select
            End If

            drDataReader.Close()
            cnxnMySql.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



    Public Sub ListaMorosos(ByVal SqlConsulta As String, CmbFiltrar As Int16, ByVal DgvMorosos As DataGridView)
        '
        Try
            '
            cnxnMySql.ConnectionString = ConfigurationManager.ConnectionStrings("MyConnectionMySQL").ConnectionString
            'cnxnMySql.ConnectionString = "server=localhost; user=root; password=MySQL€051179.jwir; database=control_pagos"
            cnxnMySql.Open()
            '
            cmdCommand = New MySqlCommand(SqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader
            '
            DgvMorosos.Rows.Clear()
            '
            If drDataReader.HasRows Then
                '
                While drDataReader.Read()
                    '
                    Dim fechaIni As DateTime = drDataReader.GetDateTime(4).ToString
                    Dim dia = fechaIni.Day
                    Dim mes = fechaIni.Month
                    Dim ano = fechaIni.Year

                    Dim nDias = DateTime.DaysInMonth(fechaIni.Year, fechaIni.Month)
                    Dim precio = drDataReader.GetDecimal(5).ToString
                    Dim dscnto = drDataReader.GetDecimal(6).ToString
                    Dim total = precio - dscnto
                    Dim prcDia = total / nDias
                    nDias = nDias - dia + 1
                    Dim aPagar = prcDia * nDias
                    '
                    If idCli = drDataReader.GetInt16(7).ToString Then
                        '
                        DgvMorosos.Rows.Add()
                        'DgvMorosos.Rows(nRow).Cells(3).Value = drDataReader.GetString(15).ToString 'METODO DE PAGO
                        DgvMorosos.Rows(nRow).Cells(3).Value = drDataReader.GetInt16(3).ToString 'ID PAGO
                        DgvMorosos.Rows(nRow).Cells(4).Value = arrayMeses(mes - 1) & " " & ano 'MES-AÑO
                        DgvMorosos.Rows(nRow).Cells(5).Value = FormatCurrency(drDataReader.GetDecimal(5).ToString) 'PRECIO
                        DgvMorosos.Rows(nRow).Cells(6).Value = FormatCurrency(drDataReader.GetDecimal(6).ToString) 'DESCUENTO
                        DgvMorosos.Rows(nRow).Cells(7).Value = drDataReader.GetDateTime(4).ToString 'FECHA INICIO DE MES
                        DgvMorosos.Rows(nRow).Cells(8).Value = FormatCurrency(total) 'TOTAL
                        DgvMorosos.Rows(nRow).Cells(9).Value = nDias 'NUMERO DE DIAS
                        DgvMorosos.Rows(nRow).Cells(10).Value = FormatCurrency(aPagar) 'A PAGAR
                        DgvMorosos.Rows(nRow).Cells(11).Value = drDataReader.GetString(0).ToString & " " & drDataReader.GetString(1).ToString & " - " & Int(DateDiff("m", drDataReader.GetDateTime(2).ToString, Now) / 12) & " años" 'NOMBRE, APELLIDO y EDAD
                        cMes += 1
                        cReg += 1
                        sTotal += aPagar
                        idCli = drDataReader.GetInt16(7).ToString
                        '
                    Else
                        If DgvMorosos.RowCount <> 0 Then
                            '
                            DgvMorosos.Rows.Add()
                            DgvMorosos.Rows(nRow).Height = 30
                            DgvMorosos.Rows(nRow).DefaultCellStyle.BackColor = Color.LightSalmon
                            DgvMorosos.Rows(nRow).DefaultCellStyle.ForeColor = Color.Red
                            DgvMorosos.Rows(nRow).DefaultCellStyle.Font = New Drawing.Font("Arial", 10, FontStyle.Bold)
                            DgvMorosos.Rows(nRow).Cells(8).Value = "DEBE : "
                            DgvMorosos.Rows(nRow).Cells(9).Value = cMes & " MESES"
                            DgvMorosos.Rows(nRow).Cells(10).Value = FormatCurrency(sTotal, 2) 'SUMATORIA
                            '
                            nRow += 1
                            '
                        End If
                        ''
                        nRow = DgvMorosos.Rows.Add()
                        'DgvMorosos.Rows(nRow).Height = 12
                        'DgvMorosos.Rows(nRow).DefaultCellStyle.BackColor = Color.LightGray
                        nRow += 1
                        ''
                        DgvMorosos.Rows.Add()
                        DgvMorosos.Rows(nRow).Cells(0).Value = drDataReader.GetString(0).ToString 'NOMBRE
                        DgvMorosos.Rows(nRow).Cells(1).Value = drDataReader.GetString(1).ToString 'APELLIDO
                        DgvMorosos.Rows(nRow).Cells(2).Value = Int(DateDiff("m", drDataReader.GetDateTime(2).ToString, Now) / 12) & " años" 'EDAD
                        DgvMorosos.Rows(nRow).Cells(3).Value = drDataReader.GetInt16(3).ToString 'ID PAGO
                        DgvMorosos.Rows(nRow).Cells(4).Value = arrayMeses(mes - 1) & " " & ano 'MES-AÑO
                        DgvMorosos.Rows(nRow).Cells(5).Value = FormatCurrency(drDataReader.GetDecimal(5).ToString) 'PRECIO
                        DgvMorosos.Rows(nRow).Cells(6).Value = FormatCurrency(drDataReader.GetDecimal(6).ToString) 'DESCUENTO
                        DgvMorosos.Rows(nRow).Cells(7).Value = drDataReader.GetDateTime(4).ToString 'FECHA INICIO DE MES
                        DgvMorosos.Rows(nRow).Cells(8).Value = FormatCurrency(total) 'TOTAL
                        DgvMorosos.Rows(nRow).Cells(9).Value = nDias 'NUMERO DE DIAS
                        DgvMorosos.Rows(nRow).Cells(10).Value = FormatCurrency(aPagar) 'A PAGAR
                        DgvMorosos.Rows(nRow).Cells(11).Value = drDataReader.GetString(0).ToString & " " & drDataReader.GetString(1).ToString & " - " & Int(DateDiff("m", drDataReader.GetDateTime(2).ToString, Now) / 12) & " años" 'NOMBRE, APELLIDO y EDAD
                        cMes = 1
                        cReg += 1
                        sTotal = aPagar
                        idCli = drDataReader.GetInt16(7).ToString
                        '
                    End If
                    '
                    nRow += 1
                    '
                End While
                '
                idCli = 0
                '
                DgvMorosos.Rows.Add()
                DgvMorosos.Rows(nRow).Height = 30
                DgvMorosos.Rows(nRow).DefaultCellStyle.BackColor = Color.LightSalmon
                DgvMorosos.Rows(nRow).DefaultCellStyle.ForeColor = Color.Red
                DgvMorosos.Rows(nRow).DefaultCellStyle.Font = New Drawing.Font("Arial", 10, FontStyle.Bold)
                DgvMorosos.Rows(nRow).Cells(8).Value = "DEBE : "
                DgvMorosos.Rows(nRow).Cells(9).Value = cMes & " MESES"
                DgvMorosos.Rows(nRow).Cells(10).Value = FormatCurrency(sTotal, 2) 'SUMATORIA
                '
                Select Case CmbFiltrar
                    '
                    Case 0 '"   NOMBRE"
                        '
                        DgvMorosos.CurrentCell = DgvMorosos.Item(0, 1)
                        DgvMorosos.Columns(0).HeaderCell.Style.BackColor = Color.AliceBlue
                        DgvMorosos.Columns(0).HeaderCell.Style.ForeColor = SystemColors.MenuHighlight
                        '
                    Case 1 '"   APELLIDO"
                        '
                        DgvMorosos.CurrentCell = DgvMorosos.Item(1, 1)
                        DgvMorosos.Columns(0).HeaderCell.Style.BackColor = Color.AliceBlue
                        DgvMorosos.Columns(0).HeaderCell.Style.ForeColor = SystemColors.MenuHighlight
                        '
                End Select
                '
            End If
            '
            FrmListaMorosos.cReg = cReg
            cReg = 0
            drDataReader.Close()
            cnxnMySql.Close()
            ' 
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        '
    End Sub

    'Sub AgregarFilaComentario(ByVal comentario As String, DgvMorosos As DataGridView)

    '    ' Crea una nueva fila
    '    Dim nuevaFila As New DataGridViewRow()

    '    ' Crea una celda base (basada en el RowTemplate)
    '    nuevaFila.CreateCells(DgvMorosos)

    '    ' --- Personalización Visual (Opcional pero Recomendado) ---

    '    ' 1. Color de fondo para diferenciarla
    '    nuevaFila.DefaultCellStyle.BackColor = Color.LightGray
    '    nuevaFila.DefaultCellStyle.Font = New Font(DgvMorosos.Font, FontStyle.Bold)

    '    ' 2. Altura (para que destaque)
    '    nuevaFila.Height = 30

    '    ' 3. Contenido del comentario (se coloca en la primera celda)
    '    nuevaFila.Cells(0).Value = comentario

    '    ' Opcional: Combinar celdas adyacentes si es necesario (más complejo, pero el comentario se pone en la primera celda)

    '    ' 4. Hacer que la fila no sea seleccionable (opcional)
    '    nuevaFila.ReadOnly = True

    '    ' --- Añadir la Fila ---

    '    ' Añade la fila a la colección de filas del DataGridView
    '    DgvMorosos.Rows.Add(nuevaFila)

    'End Sub


    'Public Sub ListaMorososListView(ByVal SqlConsulta As String, ByVal LViewMorosos As ListView)

    '    ' Definimos colores para el intercalado
    '    Dim ColorFilaPar As Color = Color.White
    '    Dim ColorFilaImpar As Color = Color.LightYellow
    '    Dim ColorFilaResumen As Color = Color.LightSalmon

    '    ' Reiniciamos contadores para la agrupación
    '    cMes = 0
    '    cReg = 0
    '    sTotal = 0D ' Usamos Decimal para manejar sumas monetarias
    '    idCli = 0

    '    Try
    '        ' 1. Configuración de la Conexión
    '        cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
    '        cnxnMySql.Open()

    '        cmdCommand = New MySqlCommand(SqlConsulta, cnxnMySql)
    '        drDataReader = cmdCommand.ExecuteReader

    '        ' Limpiar y configurar el ListView
    '        LViewMorosos.Items.Clear()
    '        LViewMorosos.View = View.Details

    '        If drDataReader.HasRows Then

    '            Dim nuevoItem As ListViewItem
    '            Dim indiceFila As Integer = 0 ' Contador de items en el ListView

    '            While drDataReader.Read()

    '                ' Manejo seguro de la fecha de inicio (Columna 12)
    '                Dim fechaIni As DateTime
    '                If Not drDataReader.IsDBNull(12) Then
    '                    fechaIni = drDataReader.GetDateTime(12)
    '                Else
    '                    ' Si la fecha es nula o cero, la saltamos o usamos una fecha segura.
    '                    Continue While
    '                End If

    '                ' Cálculos (Mejorado el manejo de tipos Decimal)
    '                Dim precio As Decimal = If(drDataReader.IsDBNull(16), 0D, drDataReader.GetDecimal(16))
    '                Dim dscnto As Decimal = If(drDataReader.IsDBNull(17), 0D, drDataReader.GetDecimal(17))

    '                Dim total As Decimal = precio - dscnto
    '                Dim nDiasMes As Integer = DateTime.DaysInMonth(fechaIni.Year, fechaIni.Month)
    '                Dim prcDia As Decimal = total / nDiasMes

    '                Dim nDias As Integer = nDiasMes - fechaIni.Day + 1
    '                Dim aPagar As Decimal = prcDia * nDias

    '                Dim idClienteActual As String = drDataReader.GetInt16(0).ToString

    '                ' --- LÓGICA DE AGRUPACIÓN Y RESUMEN ---

    '                If idCli <> 0 AndAlso idCli <> idClienteActual Then

    '                    ' Si cambia el cliente (idCli), agregamos el resumen del cliente anterior
    '                    AgregarFilaResumenListView(LViewMorosos, cMes, sTotal, ColorFilaResumen)
    '                    indiceFila += 1 ' Contar la fila de resumen

    '                    ' Agregar una fila vacía de separación (opcional)
    '                    Dim separadorItem As New ListViewItem(String.Empty)
    '                    'separadorItem.BackColor = Color.LightBlue
    '                    'separadorItem.Height = 12 ' Simular la fila separadora de 12px
    '                    ' Truco: Usar un texto invisible o un carácter de espacio
    '                    separadorItem.Text = " "
    '                    LViewMorosos.Items.Add(separadorItem)
    '                    indiceFila += 1
    '                    '
    '                    '
    '                    ' 1. Crear el nuevo ListViewItem
    '                    Dim itemResumen As New ListViewItem()

    '                    ' 2. AÑADIRLO al control antes de llamar a la función de unión
    '                    ' Esto es CRUCIAL para que itemResumen.ListView sea válido.
    '                    LViewMorosos.Items.Add(itemResumen)

    '                    ' 3. Llamar a la función
    '                    UnirCeldasDeFilaListView(itemResumen, "Resumen del Cliente Moroso. Este es un comentario o resumen que abarca toda la fila", Color.LightBlue)
    '                    '
    '                    '
    '                    'UnirCeldasDeFilaListView(unoSolo, "Este es un comentario o resumen que abarca toda la fila.", Color.LightBlue)
    '                    '
    '                    '
    '                    ' Reiniciar contadores para el nuevo cliente
    '                    cMes = 0
    '                    sTotal = 0D
    '                End If

    '                ' -------------------------------------------------------------

    '                ' 1. Crear el nuevo Item
    '                nuevoItem = New ListViewItem(drDataReader.GetString(1)) ' Nombre (Columna 0)

    '                ' 2. Agregar SubItems
    '                ' SubItem 1: Apellido
    '                nuevoItem.SubItems.Add(drDataReader.GetString(2))
    '                ' SubItem 2: Edad
    '                nuevoItem.SubItems.Add(Int(DateDiff("m", drDataReader.GetDateTime(3), Now) / 12) & " años")
    '                ' SubItem 3: METODO DE PAGO (Columna 15)
    '                nuevoItem.SubItems.Add(drDataReader.GetString(15))
    '                ' SubItem 4: MES-AÑO
    '                nuevoItem.SubItems.Add(arrayMeses(fechaIni.Month - 1) & " " & fechaIni.Year)
    '                ' SubItem 5 a 8: PRECIO, DESCUENTO, TOTAL, DÍAS, A PAGAR (FORMATO DE MONEDA)
    '                nuevoItem.SubItems.Add(FormatCurrency(precio))
    '                nuevoItem.SubItems.Add(FormatCurrency(dscnto))
    '                nuevoItem.SubItems.Add(FormatCurrency(total))
    '                nuevoItem.SubItems.Add(nDias.ToString())
    '                nuevoItem.SubItems.Add(FormatCurrency(aPagar))

    '                ' SubItem 9 y 10: ID PAGO (11) y FECHA INICIO (12) (Campos ocultos/internos)
    '                nuevoItem.SubItems.Add(drDataReader.GetInt16(11).ToString)
    '                nuevoItem.SubItems.Add(drDataReader.GetDateTime(12).ToString)

    '                ' 3. Aplicar intercalado
    '                'If indiceFila Mod 2 = 0 Then
    '                '    nuevoItem.BackColor = ColorFilaPar
    '                'Else
    '                '    nuevoItem.BackColor = ColorFilaImpar
    '                'End If

    '                ' 4. Agregar a la lista
    '                LViewMorosos.Items.Add(nuevoItem)

    '                ' 5. Actualizar contadores para la próxima iteración
    '                cMes += 1
    '                cReg += 1
    '                sTotal += aPagar
    '                idCli = idClienteActual ' Guardar el ID del cliente actual
    '                indiceFila += 1

    '            End While

    '            ' 6. Agregar el resumen del ÚLTIMO cliente después de salir del While
    '            If LViewMorosos.Items.Count > 0 Then
    '                AgregarFilaResumenListView(LViewMorosos, cMes, sTotal, ColorFilaResumen)
    '            End If

    '        End If

    '        ' (El Select Case para el foco no tiene un equivalente directo y útil en ListView sin selección)

    '        FrmListaMorosos.cReg = cReg

    '    Catch ex As MySqlException
    '        MsgBox("Error de MySQL: " & ex.Message)

    '    Catch ex As Exception
    '        MsgBox("Error general en el proceso: " & ex.Message)

    '    Finally
    '        If drDataReader IsNot Nothing Then drDataReader.Close()
    '        If cnxnMySql IsNot Nothing AndAlso cnxnMySql.State = ConnectionState.Open Then cnxnMySql.Close()
    '    End Try

    'End Sub

    '' --- SUBRUTINA AUXILIAR PARA EL RESUMEN ---
    'Private Sub AgregarFilaResumenListView(ByVal LView As ListView, ByVal meses As Integer, ByVal totalPagar As Decimal, ByVal colorFondo As Color)

    '    Dim itemResumen As New ListViewItem(String.Empty)
    '    itemResumen.UseItemStyleForSubItems = False ' Permitir estilos de subitems

    '    ' Aplicar estilos a todas las celdas para simular combinación
    '    For i As Integer = 0 To LView.Columns.Count - 1
    '        itemResumen.SubItems.Add(String.Empty) ' Asegurar que haya suficientes subitems
    '        itemResumen.SubItems(i).BackColor = colorFondo
    '        itemResumen.SubItems(i).Font = New Font(LView.Font, FontStyle.Bold)
    '        itemResumen.SubItems(i).ForeColor = Color.Red
    '    Next

    '    ' Colocar los valores del resumen en las columnas clave (ajustar índices si es necesario)
    '    itemResumen.SubItems(7).Text = "DEBE :"
    '    itemResumen.SubItems(8).Text = meses & " MESES"
    '    itemResumen.SubItems(9).Text = FormatCurrency(totalPagar, 2) ' SUMATORIA
    '    'itemResumen.SubItems(9).ForeColor = Color.Red

    '    ' La altura no se puede cambiar directamente en un ListViewItem, pero si el font es más grande, se ajusta un poco.

    '    LView.Items.Add(itemResumen)


    'End Sub

    'Public Sub UnirCeldasDeFilaListView(ByVal filaResumen As ListViewItem, ByVal textoUnido As String, ByVal colorFondo As Color)

    '    ' Esto es VITAL: Permite que los SubItems tengan estilos individuales.
    '    filaResumen.UseItemStyleForSubItems = False

    '    ' Obtener la referencia al ListView para saber cuántas columnas tiene
    '    Dim LView As ListView = filaResumen.ListView
    '    If LView Is Nothing Then Exit Sub ' Asegurar que el item ya está en la lista

    '    ' El Item principal (Columna 1, Índice 0) contendrá el texto
    '    filaResumen.Text = textoUnido

    '    ' Configurar el estilo del Item principal (Columna 1)
    '    filaResumen.BackColor = colorFondo
    '    filaResumen.ForeColor = Color.Black
    '    filaResumen.Font = New Font(filaResumen.Font, FontStyle.Bold)

    '    ' -----------------------------------------------------------------

    '    ' 1. Asegurar que haya suficientes SubItems
    '    Dim numColumnas As Integer = LView.Columns.Count

    '    ' Insertar SubItems vacíos si no existen (hasta la última columna)
    '    ' El índice i=1 es el primer SubItem (Columna 2).
    '    For i As Integer = filaResumen.SubItems.Count To numColumnas - 1
    '        ' Agregar un SubItem vacío para cada columna faltante
    '        filaResumen.SubItems.Add(String.Empty)
    '    Next

    '    ' 2. Aplicar el estilo a todos los SubItems (a partir del índice 1)
    '    For i As Integer = 1 To numColumnas - 1

    '        ' 1. Limpiar el texto (celdas vacías)
    '        filaResumen.SubItems(i).Text = String.Empty

    '        ' 2. Aplicar el mismo color de fondo
    '        filaResumen.SubItems(i).BackColor = colorFondo

    '        ' 3. Copiar el estilo de fuente
    '        filaResumen.SubItems(i).Font = filaResumen.Font

    '    Next

    'End Sub


    Sub DgvLlenarPagos(ByVal sqlConsulta As String, ByVal DgvListaPagos As DataGridView)
        Try
            cnxnMySql.ConnectionString = ConfigurationManager.ConnectionStrings("MyConnectionMySQL").ConnectionString
            'cnxnMySql.ConnectionString = "server=localhost; user=root; password=MySQL€051179.jwir; database=control_pagos"
            cnxnMySql.Open()
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader
            DgvListaPagos.Rows.Clear()

            If drDataReader.HasRows Then
                While drDataReader.Read()
                    Dim nRow = DgvListaPagos.Rows.Add()
                    Dim fecha As DateTime = drDataReader.GetDateTime(1).ToShortDateString
                    Dim dia = fecha.Day
                    Dim mes = fecha.Month
                    Dim ano = fecha.Year
                    Dim precio = drDataReader.GetDecimal(4).ToString
                    Dim dscto = drDataReader.GetDecimal(5).ToString
                    Dim total = precio - dscto
                    Dim nDias = DateTime.DaysInMonth(fecha.Year, fecha.Month)
                    Dim prcDia = total / nDias
                    nDias = nDias - dia + 1

                    DgvListaPagos.Rows(nRow).Cells(0).Value = drDataReader.GetInt16(0).ToString 'ID PAGO
                    DgvListaPagos.Rows(nRow).Cells(1).Value = dia & " de " & arrayMeses(mes - 1) & " de " & ano 'FECHA DE INICIO
                    DgvListaPagos.Rows(nRow).Cells(2).Value = FormatCurrency(precio) 'PRECIO
                    DgvListaPagos.Rows(nRow).Cells(3).Value = FormatCurrency(dscto) 'DESCUENTO
                    DgvListaPagos.Rows(nRow).Cells(4).Value = FormatCurrency(total) 'TOTAL
                    DgvListaPagos.Rows(nRow).Cells(5).Value = nDias 'NUMERO DE DIAS
                    DgvListaPagos.Rows(nRow).Cells(6).Value = FormatCurrency(prcDia * nDias) 'A PAGAR
                    If drDataReader.GetDateTime(2).ToShortDateString = "01/01/0101" Then
                        DgvListaPagos.Rows(nRow).Cells(7).Value = "--/--/----" 'FECHA DE PAGO
                        DgvListaPagos.Rows(nRow).Cells(8).Value = "DEBE" 'FORMA DE PAGO
                        'DgvListaPagos.Rows(nRow).DefaultCellStyle.BackColor = Color.LightSalmon
                        DgvListaPagos.Rows(nRow).DefaultCellStyle.ForeColor = Color.Red
                        DgvListaPagos.Rows(nRow).DefaultCellStyle.Font = New Drawing.Font("Arial", 10, FontStyle.Bold)
                        '
                    Else
                        DgvListaPagos.Rows(nRow).Cells(7).Value = Fun_Long_Date(drDataReader.GetDateTime(2).ToShortDateString) 'FECHA DE PAGO
                        DgvListaPagos.Rows(nRow).Cells(8).Value = drDataReader.GetString(3).ToString 'FORMA DE PAGO
                        DgvListaPagos.Rows(nRow).Cells(9).Value = drDataReader.GetString(7).ToString 'USUARIO
                    End If
                End While
            End If

            drDataReader.Close()
            cnxnMySql.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


End Module
