Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Module SqlRepository

    Private ReadOnly ConnectionString As String = ConfigurationManager.ConnectionStrings("MyConnectionMySQL").ConnectionString

    '----------------------------------------------------
    ' DEVUELVE TRUE SI LA CONSULTA TIENE REGISTROS
    '----------------------------------------------------
    Public Function Exists(sqlStr As String) As Boolean

        Using conStr As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(sqlStr, conStr)
                conStr.Open()
                Using exeReader = cmd.ExecuteReader()
                    Return exeReader.HasRows
                End Using
            End Using
        End Using

    End Function

    '----------------------------------------------------
    ' DEVUELVE UN VALOR ESCALAR (ID, TOTAL, ETC)
    '----------------------------------------------------
    Public Function ExecuteScalar(Of T)(sqlStr As String, Optional parametrosExiste As List(Of MySqlParameter) = Nothing) As T

        Using conStr As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(sqlStr, conStr)

                ' Si se pasan parámetros, agregarlos al comando
                If parametrosExiste IsNot Nothing Then
                    cmd.Parameters.AddRange(parametrosExiste.ToArray())
                End If

                conStr.Open()

                Dim result As Object = cmd.ExecuteScalar()

                ' Si la consulta no devuelve nada
                If result Is Nothing OrElse result Is DBNull.Value Then
                    Return Nothing
                End If

                Return CType(result, T)
            End Using
        End Using

    End Function

    '----------------------------------------------------
    ' DEVUELVE UN DataTable (PARA GRIDS)
    '----------------------------------------------------
    Public Function GetDataTable(sqlStr As String) As DataTable

        Using conStr As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(sqlStr, conStr)
                Using dtAdap As New MySqlDataAdapter(cmd)

                    Dim dtTable As New DataTable()
                    dtAdap.Fill(dtTable)
                    Return dtTable

                End Using
            End Using
        End Using

    End Function

    '-------------------------------------------------------------------------
    ' Ejecuta una instrucción SQL que NO devuelve filas, NO se usa para SELECT
    '-------------------------------------------------------------------------
    Public Sub ExecuteNonQuery(sql As String, Optional params As List(Of MySqlParameter) = Nothing)
        Using conStr As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(sql, conStr)
                If params IsNot Nothing Then
                    cmd.Parameters.AddRange(params.ToArray())
                End If
                conStr.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Module