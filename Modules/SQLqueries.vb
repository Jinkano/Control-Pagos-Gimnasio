Imports System.Configuration
Imports MySql.Data.MySqlClient

Module SQLqueries

    ReadOnly cnxnMySql As New MySqlConnection
    Dim cmdCommand As MySqlCommand
    Dim drDataReader As MySqlDataReader

    Dim nRow, cMes, cReg, idCli As Int16
    Dim sTotal As Decimal

    Public Sub Sub_Crud_Sql(sqlConsulta As String, Optional strSubroutine As String = "", Optional strFiltrar As String = "")

        '| * Usamos Try-Catch para controlar posibles errores
        '| TRY :
        '|      * Conectamos y abrimos la base de datos.
        '|      * Ejecutamos la consulta recibida por parametro.
        '|      SELECT CASE :
        '|          * Seleccionamos el CASE para llamar a la subrutina correspondiente al valor de la variable _
        '|            _ strSubroutine, que se recibe por parámetro cuando se hace la llamada a la subrutina _
        '|            _ principal Sub_Crud_Sql.
        '| CATCH :
        '|      * Mostramos un mensaje con el error capturado.
        '| FINALLY :
        '|      * Cerramos el datareader y la base de datos.

        Try
            cnxnMySql.ConnectionString = ConfigurationManager.ConnectionStrings("MyConnectionMySQL").ConnectionString
            cnxnMySql.Open()
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()

            Select Case strSubroutine

                Case "SubCheckRecords"
                    SubCheckRecords()

                Case "SubReadIdClient"
                    SubReadIdClient()

                Case "SubFillGroupName"
                    SubFillGroupName()

                Case "SubSearchDiscountPrice"
                    SubSearchDiscountPrice()

                Case "CheckPaymentRegistered"
                    CheckPaymentRegistered()

                Case "SubFillFamilyGroupData"
                    SubFillFamilyGroupData()

                Case "SubSearchGroupPrice"
                    SubSearchGroupPrice()

                Case "SubSearchDailyPrice"
                    SubSearchDailyPrice()

                Case "SubFillClientList"
                    SubFillClientList(strFiltrar)

                Case "SubFillPayments"
                    SubFillPayments(strFiltrar)

            End Select

        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            drDataReader.Close()
            cnxnMySql.Close()
        End Try

    End Sub

    Public Sub SubCheckRecords()

        '| ---------------------------------------------------------------------------------------
        '| COMPROBAR SI HAY CLIENTES REGISTRADOS EN LA BBDD
        '| ------------------------------------------------
        '| * IF : Comprobamos si la consulta tiene registros y activamos el boton BtnFindClient.
        '|
        '| * ELSE : Si la consulta no ha encontrado registros desactivamos el boton BtnFindClient.

        If drDataReader.HasRows Then
            FrmClientesPagos.BtnFindClient.Enabled = True
        Else
            FrmClientesPagos.BtnFindClient.Enabled = False
        End If

    End Sub


    Public Sub SubReadIdClient()

        '| ----------------------------------------------------------------------------------------------
        '| LEER EL ID DEL CLIENTE
        '| ----------------------
        '| * Leemos el drDataReader.
        '| * El resultado lo almacenamos en la variable strIdClient del formulario FrmNuevoEditarCliente.

        drDataReader.Read()
        FrmNuevoEditarCliente.strIdClient = drDataReader.GetInt16(0).ToString
    End Sub


    Public Sub SubFillGroupName()

        '| --------------------------------------------------------------------------------------------
        '| LLENAR NOMBRE DEL GRUPO FAMILIAR
        '| --------------------------------
        '| * Leemos el drDataReader.
        '| * Llenamos el label LblGrpFamCli del Form FrmClientesPagos con el nombre del grupo familiar.

        drDataReader.Read()
        FrmClientesPagos.LblGrpFamCli.Text = drDataReader.GetString(0)
    End Sub


    Public Sub SubFillFamilyGroupData()

        '| ---------------------------------------------------------------------------------------------------
        '| LLENAR LOS DATOS DEL GRUPO FAMILIAR
        '| -----------------------------------
        '| WITH : Hace referencia al datagridview 'DgvListaNombre' del formulario 'FrmNuevoEditarCliente'
        '|      * Limpiamos el DataGridView DgvListaNombre
        '|
        '|      IF : Comprobammos si hay registros:
        '|
        '|          WHILE : Mientras leemos el DataReader
        '|              * Agregamos una nueva fila y lo almacenamos en la variable nRow para llenar los campos
        '|                del DataGridView DgvListaNombre con los datos del Grupo Familiar.

        With FrmNuevoEditarCliente.DgvListaNombre
            .Rows.Clear()
            If drDataReader.HasRows Then
                While drDataReader.Read()
                    nRow = .Rows.Add()
                    .Rows(nRow).Cells(0).Value = drDataReader.GetInt16(0) 'ID
                    .Rows(nRow).Cells(1).Value = drDataReader.GetString(1) 'NOMBRE TIPO TARIFA
                    .Rows(nRow).Cells(2).Value = drDataReader.GetInt16(2) 'NUMERO DE INTEGRANTES
                    .Rows(nRow).Cells(3).Value = drDataReader.GetInt16(3) 'INTEGRANTES REGISTRADOS
                End While
            End If
        End With
    End Sub

    Public Sub SubSearchDiscountPrice()

        '| ---------------------------------------------------------------------------------------------------
        '| BUSCAR PRECIO Y DESCUENTO
        '| -------------------------
        '| WITH : Hace referencia al formulario 'FrmNuevoEditarCliente'
        '|
        '|      IF : Si la consulta devuelve resultados
        '|          * Leemos el drDataReader y el resultado lo almacenamos en las variables 'precio y dscnto'.
        '|          * Pasamos la variable 'blnMarker' a TRUE para no volver a llamar a esta función.
        '|
        '|      ELSE :
        '|          * Pasamos la variable 'blnMarker' a FALSE, para hacer una nueva consulta y volver a llamar
        '|            a esta función.

        With FrmNuevoEditarCliente
            If drDataReader.HasRows Then
                drDataReader.Read()
                .precio = drDataReader.GetDecimal(0)
                .dscnto = drDataReader.GetDecimal(1)
                .blnMarker = True
            Else
                .blnMarker = False
            End If
        End With
    End Sub

    Public Sub CheckPaymentRegistered()

        '| ------------------------------------------------------------
        '| COMPROBAMOS SI HAY UN PAGO GRUPAL REGISTRADO
        '| --------------------------------------------
        '| WITH : Hace referencia al formulario 'FrmNuevoEditarCliente'
        '|
        '|      IF : Si la consulta devuelve resultados
        '|          * Pasamos la variable blnMarker a TRUE 
        '|
        '|      ELSE :
        '|          * Pasamos la variable blnMarker a FALSE

        With FrmNuevoEditarCliente
            If drDataReader.HasRows Then
                .blnMarker = True
            Else
                .blnMarker = False
            End If
        End With
    End Sub

    Public Sub SubSearchDailyPrice()

        '| -----------------------------------------------------------------------------------------------------
        '| BUSCAR LA TARIFA DE LAS CLASES SUELTAS (PRECIO DIARIO)
        '| ------------------------------------------------------
        '| WITH : Hace referencia al datagridview 'DgvListaNombre' del formulario 'FrmNuevoEditarCliente'
        '|      * Limpiamos el DataGridView DgvListaNombre
        '|
        '|      IF : Comprobammos si hay registros:
        '|
        '|          WHILE : Mientras leemos el DataReader
        '|              * Agregamos una nueva fila y lo almacenamos en la variable 'nRow' para llenar los campos
        '|                del DataGridView DgvListaNombre con los datos del Precio Diario.

        With FrmNuevoEditarCliente.DgvListaNombre
            .Rows.Clear()
            If drDataReader.HasRows Then
                While drDataReader.Read()
                    nRow = .Rows.Add()
                    .Rows(nRow).Cells(0).Value = drDataReader.GetInt16(0) 'ID
                    .Rows(nRow).Cells(1).Value = drDataReader.GetString(1) 'NOMBRE TIPO TARIFA
                End While
            End If
        End With
    End Sub

    Public Sub SubSearchGroupPrice()

        '| -----------------------------------------------------------------------------------------------------
        '| BUSCAR TARIFA DE UN GRUPO FAMILIAR
        '| ----------------------------------
        '| WITH : Hace referencia al formulario 'FrmNuevoEditarCliente'
        '|
        '|      IF : Comprobamos si la consulta NO devuelve registros:
        '|
        '|          IF : Preguntammos si queremos agregar una tarifa, si la respuesta es SI
        '|              * Ponemos la variable 'intAddMember' a cero.
        '|              * Mostramos el Form FrmTablaDescuento para agregar una nueva tarifa.
        '|
        '|      ELSE : Si encuentra la tarifa correspondiente al grupo:
        '|          * Llemanos el TxtListaNom y el LblNumIntgrntes con los datos del grupo.
        '|          * Llenamos la variable 'strAddMembers' con el valor "UPDATE_TWO_FIELDS" para actualizar los
        '|            campos num_intgrntes_grp Y intgrntes_reg_grp al momento de guardar.

        With FrmNuevoEditarCliente
            If Not drDataReader.HasRows Then
                If MsgBox("   No hay una tarifa para " & .intAddMember & " integrantes." & vbCr &
                          "   ______________________________________" & vbCr & vbCr &
                          "                ¿Quieres agergar una tarifa?",
                            vbYesNo + vbDefaultButton2 + vbQuestion, "Lista de integrantes") = vbYes Then
                    .intAddMember = 0
                    FrmTablaDescuento.Show()
                End If
            Else
                .TxtListaNom.Text = .DgvListaNombre.CurrentRow.Cells(1).Value
                .LblNumIntgrntes.Text = .DgvListaNombre.CurrentRow.Cells(3).Value & " de " & .DgvListaNombre.CurrentRow.Cells(2).Value
                .strAddMembers = "UPDATE_TWO_FIELDS"
            End If
        End With
    End Sub

    Public Sub SubFillClientList(strFiltrar As String)

        '| -----------------------------------------------------------------------------------------------------
        '| LLENAR LA LISTA CON TODOS LOS CLIENTES
        '| --------------------------------------
        '| WITH :
        '|      * Limpiamos el DataGridView DgvListaNombre
        '|
        '|      IF : Comprobamos si hay registros:
        '|
        '|          WHILE : Mientras leemos el DataReader
        '|              * Agregamos una nueva fila y lo almacenamos en la variable nRow para llenar los campos
        '|                del DataGridView DgvClientes con los datos del cliente.
        '|
        '|          SELECT CASE : Evaluamos la variable strFiltrar recibida por parámetro para marcar el campo
        '|                        que se está buscando.
        '|
        '|          * FrmClientesPagos.TxtBuscar.BackColor = Color.Snow
        '|
        '|      ELSE :
        '|          * FrmClientesPagos.TxtBuscar.BackColor = Color.MistyRose
        '|
        '|      * FrmClientesPagos.LblResult.Text = .RowCount & " - Registro(s) que coincide(n) con su búsqueda."

        With FrmClientesPagos.DgvClientes

            .Rows.Clear()

            If drDataReader.HasRows Then

                While drDataReader.Read()
                    nRow = .Rows.Add()
                    'ID DEL CLIENTE
                    .Rows(nRow).Cells(0).Value = drDataReader.GetInt16(0).ToString
                    'NOMBRE DEL CLIENTE
                    .Rows(nRow).Cells(1).Value = drDataReader.GetString(1)
                    'APELLIDO DEL CLIENTE
                    .Rows(nRow).Cells(2).Value = drDataReader.GetString(2)
                    'FECHA DE NACIMIENTO Y EDAD DEL CLIENTE
                    Dim dtDateOfBirth As Date = drDataReader.GetDateTime(3).ToShortDateString
                    .Rows(nRow).Cells(3).Value = dtDateOfBirth
                    .Rows(nRow).Cells(4).Value = Fun_Long_Date(dtDateOfBirth)
                    .Rows(nRow).Cells(5).Value = Fun_Calculate_Age(dtDateOfBirth) & " años"
                    'TELEFONO DEL CLIENTE
                    .Rows(nRow).Cells(6).Value = drDataReader.GetString(4)
                    'E-MAIL DEL CLIENTE
                    .Rows(nRow).Cells(7).Value = drDataReader.GetString(5)
                    'DIRECCIÓN DEL CLIENTE
                    .Rows(nRow).Cells(8).Value = drDataReader.GetString(6)
                    'MÉTODO DE PAGO DEL CLIENTE
                    .Rows(nRow).Cells(9).Value = drDataReader.GetString(7)
                    'FECHA DE INSCRIPCIÓN
                    .Rows(nRow).Cells(10).Value = drDataReader.GetDateTime(8).ToShortDateString.ToString
                    .Rows(nRow).Cells(11).Value = Fun_Long_Date(drDataReader.GetDateTime(8).ToShortDateString)
                    'ESTADO DEL CLIENTE
                    .Rows(nRow).Cells(12).Value = drDataReader.GetString(9)
                    'ID DEL GRUPO FAMILIAR
                    If Not (drDataReader("id_grp") Is DBNull.Value) Then
                        .Rows(nRow).Cells(13).Value = drDataReader.GetInt16(10).ToString
                    End If
                End While

                Select Case strFiltrar
                    Case "NAME"
                        .CurrentCell = .Item(1, 0)
                    Case "LASTNAME"
                        .CurrentCell = .Item(2, 0)
                    Case "PHONE"
                        .CurrentCell = .Item(6, 0)
                End Select

                FrmClientesPagos.TxtBuscar.BackColor = Color.Snow
            Else
                FrmClientesPagos.TxtBuscar.BackColor = Color.MistyRose
            End If

            FrmClientesPagos.LblResult.Text = .RowCount & " - Registro(s) que coincide(n) con su búsqueda."
        End With
    End Sub

    Public Sub SubFillPayments(strDaily As String)

        '| -----------------------------------------------------------------------------------------------------
        '| FUNCIÓN PARA LISTAR LOS PAGOS DE LO CLIENTES O DE LOS GRUPOS
        '| ------------------------------------------------------------
        '| * Variables para el cálculo de días y precio por día.
        '|
        '| WITH : REFERENCIA AL DGVPAYMENTLIST DEL FORMULARIO FRMCLIENTESPAGOS
        '|      * Limpia todas las filas antes de cargar nuevos datos.
        '|
        '|      IF : VERIFICA SI EL DATAREADER CONTIENE REGISTROS
        '|
        '|          WHILE : RECORRE CADA REGISTRO DEVUELTO POR EL DATAREADER
        '|              * Agrega una nueva fila al DataGridView
        '|              * Almacenamos en la variable 'startDate' la fecha de inicio del pago y el día del mes
        '|                en la variable 'startDay'.
        '|              * Obtenemos el precio y descuento de la BBDD, calculamos el total restando los valores.
        '|
        '|              IF : VERIFICAMOS SI EL PAGO ES DIARIO
        '|                  * Asignamos 1 a la variable 'nDias'
        '|                  * Igualamos la variable 'prcDia' con el valor del 'total'
        '|
        '|              ELSE : SI EL PAGO ES MENSUAL O GRUPAL
        '|                  * Llenamos la variable 'nDias' con los días del mes
        '|                  * Obtenemos el precio diario dividiendo el 'precio con nDias' y lo almacenamos en
        '|                    la variable 'prcDia'.
        '|                  * Reasignar el valor de la variable 'nDias' restando 'nDias' menos la fecha de
        '|                    inicio 'startDate' mas uno.
        '|
        '|              * Obtenemos el valor de la variable 'aPagar' multiplicando 'prcDia' por 'nDias'.
        '|
        '|              * Llenamos las columnas con el id pago y la fecha de inicio.
        '|              * En la variable 'payDate' guardamos la fecha de pago.
        '|
        '|              IF : Verificamos si la 'payDate' es el valor por defecto '01/01/0001'
        '|                  * Si la función nos devuelve VERDADERO cambiamos el texto de las columnas FECHA DE
        '|                    PAGO, FORMA DE PAGO y USUARIO, también cambiamos el color del fondo, el color del
        '|                    texto y la fuente.
        '|
        '|              ELSE : Si la mensualidad ya está pagado
        '|                  * Llamamos a la subrutina 'Fun_Long_Date' para convertir la fecha corta en fecha
        '|                    larga para mostrarlo en la columna FECHA DE PAGO.
        '|                  * Llenamos las columnas FORMA DE PAGO y USUARIO con los valores de la BBDD.
        '|
        '|              * Llenamos el resto de las columnas con valores monetarios formateados PRECIO, DESCUENTO,
        '|                TOTAL, NUMERO DE DIAS y A PAGAR con los datos obtenidos de la BBDD y los calculos realizados.

        Dim nDias As Integer
        Dim prcDia, aPagar As Decimal

        With FrmClientesPagos.DgvPaymentList
            .Rows.Clear()

            If drDataReader.HasRows Then

                While drDataReader.Read()
                    Dim nRow = .Rows.Add()

                    Dim startDate As DateTime = drDataReader.GetDateTime(1).ToShortDateString
                    Dim startDay As Integer = startDate.Day

                    Dim precio As Decimal = drDataReader.GetDecimal(5).ToString
                    Dim dscto As Decimal = drDataReader.GetDecimal(6).ToString
                    Dim total As Decimal = precio - dscto

                    If strDaily = "strDaily" Then
                        nDias = 1
                        prcDia = total

                    Else
                        nDias = DateTime.DaysInMonth(startDate.Year, startDate.Month)
                        prcDia = total / nDias
                        nDias = (nDias - startDay) + 1

                    End If

                    aPagar = prcDia * nDias

                    .Rows(nRow).Cells(0).Value = drDataReader.GetInt16(0).ToString 'ID PAGO
                    .Rows(nRow).Cells(1).Value = Fun_Long_Date(drDataReader.GetDateTime(1).ToShortDateString) 'FECHA DE INICIO

                    Dim payDate As DateTime = drDataReader.GetDateTime(2) 'FECHA DE PAGO

                    If IsDateNotAssigned(payDate) Then
                        .Rows(nRow).Cells(2).Value = "SIN FECHA" 'FECHA DE PAGO
                        .Rows(nRow).Cells(3).Value = "IMPAGO" 'FORMA DE PAGO
                        .Rows(nRow).Cells(10).Value = "N/A" 'USUARIO
                        .Rows(nRow).DefaultCellStyle.ForeColor = Color.Red
                        .Rows(nRow).DefaultCellStyle.BackColor = Color.MistyRose
                        .Rows(nRow).DefaultCellStyle.Font = New Drawing.Font("Arial", 9, FontStyle.Bold)
                    Else
                        .Rows(nRow).Cells(2).Value = Fun_Long_Date(drDataReader.GetDateTime(2).ToShortDateString) 'FECHA DE PAGO
                        .Rows(nRow).Cells(3).Value = drDataReader.GetString(3).ToString 'FORMA DE PAGO
                        .Rows(nRow).Cells(10).Value = drDataReader.GetInt16(8).ToString 'USUARIO
                    End If

                    .Rows(nRow).Cells(5).Value = FormatCurrency(precio) 'PRECIO
                    .Rows(nRow).Cells(6).Value = FormatCurrency(dscto) 'DESCUENTO
                    .Rows(nRow).Cells(7).Value = FormatCurrency(total) 'TOTAL
                    .Rows(nRow).Cells(8).Value = nDias 'NUMERO DE DIAS
                    .Rows(nRow).Cells(9).Value = FormatCurrency(aPagar) 'A PAGAR

                End While
            End If

        End With
    End Sub

End Module