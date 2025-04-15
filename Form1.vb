Imports MySql.Data.MySqlClient
Imports ZstdSharp.Unsafe

Public Class Form1

    Dim cnxnMySql As New MySqlConnection
    Dim drDataReader As MySqlDataReader
    Dim cmdCommand As MySqlCommand
    Dim sqlConsulta, idUser, passUser As String 'nomUser,

    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles BtnIniciar.Click

        Try
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()

            If TxtContrasena.Text = "" Then
                sqlConsulta = "SELECT * FROM usuarios WHERE usuario = '" & TxtUsuario.Text & "'"
                cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                drDataReader = cmdCommand.ExecuteReader()

                If drDataReader.HasRows Then
                    drDataReader.Read()
                    idUser = drDataReader.GetInt16(0).ToString
                    passUser = drDataReader.GetString(2).ToString

                    If passUser = "" Then
                        LblUsuario2.Text = TxtUsuario.Text
                        GbUsuarioContrasena.Visible = False
                        GbGuardarContrasena.Visible = True
                        TxtContrasena1.Focus()
                    Else
                        MsgBox("El usuario o la contraseña son incorreco.", vbCritical, "Control de acceso")
                        TxtUsuario.Focus()
                    End If
                Else
                    MsgBox("El usuario no está registrado.", vbCritical, "Control de acceso")
                    TxtUsuario.Focus()
                End If
            Else
                sqlConsulta = "SELECT * FROM usuarios WHERE usuario = '" & TxtUsuario.Text & "' AND contrasena = '" & TxtContrasena.Text & "'"
                cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                drDataReader = cmdCommand.ExecuteReader()

                If drDataReader.HasRows Then
                    drDataReader.Read()
                    FrmPrincipal.nomUser = drDataReader.GetString(1).ToString
                    FrmPresentacion.Show()
                    Me.Hide()
                Else
                    MsgBox("El usuario o la contraseña son incorreco.", vbCritical, "Control de acceso")
                    TxtUsuario.Focus()
                End If
            End If
            drDataReader.Close()
            cnxnMySql.Close()

        Catch ex As Exception
            MsgBox(e.ToString)
        End Try
    End Sub

    Private Sub BtnCerrar_Click_1(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        FrmPresentacion.Show()
        Me.Hide()
        'End
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If TxtContrasena1.Text = TxtContrasena2.Text Then
            Try
                cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
                cnxnMySql.Open()
                sqlConsulta = "UPDATE usuarios SET contrasena='" & TxtContrasena1.Text & "' WHERE id='" & idUser & "'"
                cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                drDataReader = cmdCommand.ExecuteReader()
                drDataReader.Close()
                cnxnMySql.Close()

                GbUsuarioContrasena.Visible = True
                GbGuardarContrasena.Visible = False
                TxtContrasena.Focus()
                idUser = ""

            Catch ex As Exception
                MsgBox(e.ToString)
            End Try
        Else
            MsgBox("Las contraseñas no coinciden.", vbCritical, "Guardar contraseña")
            TxtContrasena1.Focus()
        End If
    End Sub
End Class