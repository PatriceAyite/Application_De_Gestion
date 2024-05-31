Imports Guna.UI2.WinForms

Public Class bienvenu
    Dim a As Double = 0
    Dim b As Double = 0S

    Private Sub Guna2CircleProgressBar1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2CircleProgressBar1.ValueChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        a = a + 0.1
        If a > 1 Then
            a = 0
            b = b + 10
        End If
        If b > 100 Then
            Me.Close()

        End If
        Guna2CircleProgressBar1.Value = b
        If b >= 0 And b <= 20 Then
            Label1.Text = "Chargement des interfaces..."
        ElseIf b >= 21 And b <= 40 Then
            Label1.Text = "Chargement des services..."
        ElseIf b >= 41 And b <= 80 Then
            Label1.Text = "Vérification du système..."
        ElseIf b >= 81 And b <= 99 Then
            Label1.Text = "Veuillez patienter..."
        ElseIf b = 100 Then
            ' Une fois le chargement terminé, ouvrez le formulaire de connexion
            Dim loginForm As New login()
            loginForm.Show()
        End If

    End Sub

    Private Sub bienvenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
