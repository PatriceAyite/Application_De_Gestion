Imports MySql.Data.MySqlClient
Public Class frm_ManageUser
    Private Sub frm_ManageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Public Sub clear()
        txt_name.Clear()
        txt_password.Clear()
        txt_UserName.Clear()
        cbo_role.SelectedIndex = 1
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Try
            conn.Open()
            cmd = New MySqlCommand("INSERT INTO `tbluser`( `name`, `username`, `password`, `role`) VALUES (@name,@username,@password,@role)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@name", txt_name.Text)
            cmd.Parameters.AddWithValue("@username", txt_UserName.Text)
            cmd.Parameters.AddWithValue("@password", txt_password.Text)
            cmd.Parameters.AddWithValue("@role", cbo_role.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Nouveau utilisateur ajouter ", "BOOK SHOP", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Erreur ", "BOOK SHOP", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        clear()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        clear()
        Me.Close()
    End Sub
End Class














