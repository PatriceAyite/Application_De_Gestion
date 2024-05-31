Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frm_users

    Private Sub frm_users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub
    Sub clear()
        txtName.Clear()
        txtPass.Clear()
        txtUser.Clear()
        cboUser.Text = String.Empty
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        conn.Open()
        Try
            cmd = New MySqlCommand("insert into tbl_users (username, password, name, role) values('" & txtUser.Text & "','" & txtPass.Text & "','" & txtName.Text & "','" & cboUser.Text & "')", conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Le nouveau compte a été créé avec succès.", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clear()
        Me.Close()
    End Sub

    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Me.Close()
    End Sub
End Class