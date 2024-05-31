Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frm_login

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        txtPass.PasswordChar = Chr(149)
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            conn.Open()
            Dim found As Boolean = False
            cmd = New MySqlCommand("select * from tbl_users where username like '" & txtUser.Text & "' and password like '" & txtPass.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                found = True
                Name = dr.Item("name").ToString
                user = dr.Item("username").ToString
                pass = dr.Item("password").ToString
                role = dr.Item("role").ToString

            Else
                found = False
                Name = ""
                user = ""
                pass = ""
                role = ""

            End If
            dr.Close()
            conn.Close()

            If found = True Then
                If StrComp(txtPass.Text, pass, CompareMethod.Binary) Or StrComp(txtUser.Text, user, CompareMethod.Binary) Then
                    MsgBox("Wrong: Invalid username or password!", vbCritical)
                Else
                    txtPass.Clear()
                    txtUser.Clear()
                    Me.Hide()
                    If UCase(role) = "ADMIN" Then
                        Me.Hide()
                        Form1.Show()
                        Form1.lbl_loginuser.Text = Name
                        Form1.lbl_logintime.Text = "Login Time : " & Date.Now.ToString("hh:mm:ss tt")
                    ElseIf UCase(role) = "CASHIER" Then
                        Me.Hide()
                        frm_cashier.Show()
                        frm_cashier.lbl_loginUsers.Text = "Login User : " & Name
                        frm_cashier.lbl_loginTime.Text = "Login Time : " & Date.Now.ToString("hh:mm:ss tt")
                    End If
                End If
            Else
                MsgBox("Wrong : Invalid username or password!", vbCritical)
            End If

        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        If MsgBox("Are you sure you want to exit?", vbYesNo + vbQuestion) = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub
End Class