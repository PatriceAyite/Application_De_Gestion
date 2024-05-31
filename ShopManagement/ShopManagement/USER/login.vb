Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Close()
    End Sub

    Sub clear()
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim connectionString As String = "server=localhost;user=root;password=;port=3306;database=book_db"
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "SELECT role FROM tbluser WHERE username = @username AND password = @password"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)

                Dim role As Object = cmd.ExecuteScalar()

                If role IsNot Nothing AndAlso Not Convert.IsDBNull(role) Then
                    Dim userRole As String = Convert.ToString(role)

                    If userRole.ToUpper() = "ADMIN" Then
                        ' Redirection vers la page d'administration
                        Me.Hide()
                        frm_AdminMain.ShowDialog()
                    ElseIf userRole.ToUpper() = "UTILISATEUR" Then
                        ' Redirection vers la page utilisateur
                        Me.Hide()
                        frm_UserMain.ShowDialog()

                    Else
                        MessageBox.Show("Rôle d'utilisateur non reconnu.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite : " & ex.Message, "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        clear()
    End Sub
End Class