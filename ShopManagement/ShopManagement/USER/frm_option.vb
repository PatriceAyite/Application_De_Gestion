Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class frm_option

    Private Sub frm_option_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Private Sub LoadUserData(ByVal userId As Integer)
        Try
            ' Créer une connexion MySQL et ouvrir la connexion
            Using conn As New MySqlConnection("votre_chaine_de_connexion_mysql")
                conn.Open()

                ' Définir la requête SQL pour sélectionner les données pertinentes de la table tbluser
                Dim query As String = "SELECT name, username, role FROM tbluser WHERE id = @userId"

                ' Créer une commande MySQL
                Using command As New MySqlCommand(query, conn)
                    ' Ajouter un paramètre pour l'ID de l'utilisateur
                    command.Parameters.AddWithValue("@userId", userId)

                    ' Créer un lecteur de données pour récupérer les résultats de la requête
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ' Vérifier s'il y a des lignes de données
                        If reader.Read() Then
                            ' Récupérer les valeurs de colonnes (name, username, role)
                            Dim name As String = reader("name").ToString()
                            Dim username As String = reader("username").ToString()
                            Dim role As String = reader("role").ToString()

                            ' Afficher les valeurs dans les contrôles appropriés de votre formulaire
                            nom_user.Text = $"Name: {name}"
                            speudo_user.Text = $"Username: {username}"
                            role_user.Text = $"Role: {role}"
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Gérer les exceptions (par exemple, afficher un message d'erreur)
            MessageBox.Show("Une erreur s'est produite lors du chargement des données : " & ex.Message)
        End Try
    End Sub



End Class
