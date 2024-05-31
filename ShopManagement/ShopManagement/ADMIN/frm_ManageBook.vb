Imports System.IO
Imports MySql.Data.MySqlClient
Public Class frm_ManageBook

    Private Sub frm_ManageBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        Auto_bookid()
        Laod_Books()
    End Sub


    Public Sub clear()
        pic_bookimg.Image = Nothing
        txt_Author.Clear()
        txt_BookNme.Clear()
        txt_Price.Clear()
        txt_TotalPrice.Clear()
        cbo_tax.SelectedIndex = -1
    End Sub

    Public Sub Auto_bookid()
        txt_BookId.Clear()
        Try
            conn.Open()

            cmd = New MySqlCommand("SELECT * FROM `tblbookmaster` WHERE bookid order by id desc", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                txt_BookId.Text = dr.Item("bookid").ToString + 1
            Else
                txt_BookId.Text = Date.Now.ToString("yyy") & "001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub pic_bookimg_Click(sender As Object, e As EventArgs) Handles pic_bookimg.Click
        Dim pop As OpenFileDialog = New OpenFileDialog
        If pop.ShowDialog() = DialogResult.OK Then
            pic_bookimg.Image = Image.FromFile(pop.FileName)
        End If

    End Sub

    Public Sub Laod_Books()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `bookid`, `bookname`, `author`, `price`, `tax`, `totalprice` FROM `tblbookmaster`", conn)

            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("bookid"), dr.Item("bookname"), dr.Item("author"), dr.Item("price"), dr.Item("tax"), dr.Item("totalprice"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If txt_BookId.Text = String.Empty OrElse
     txt_BookNme.Text = String.Empty OrElse
     txt_Author.Text = String.Empty OrElse
     txt_Price.Text = String.Empty OrElse
     cbo_tax.Text = String.Empty OrElse
     txt_TotalPrice.Text = String.Empty OrElse
     pic_bookimg.Image Is Nothing Then

            MsgBox("Remplissez tous les champs!", vbExclamation)
        Else
            Try
                ' Ouvrir la connexion à la base de données
                conn.Open()

                ' Créer et configurer la commande SQL
                cmd = New MySqlCommand("INSERT INTO `tblbookmaster` (`bookid`, `bookname`, `author`, `price`, `tax`, `totalprice`, `img` , `status` ) VALUES (@bookid, @bookname, @author, @price, @tax, @totalprice, @img ,@status)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@bookid", txt_BookId.Text)
                cmd.Parameters.AddWithValue("@bookname", txt_BookNme.Text)
                cmd.Parameters.AddWithValue("@author", txt_Author.Text)
                cmd.Parameters.AddWithValue("@price", CDec(txt_Price.Text))
                cmd.Parameters.AddWithValue("@tax", cbo_tax.Text)
                cmd.Parameters.AddWithValue("@totalprice", CDec(txt_TotalPrice.Text))
                cmd.Parameters.AddWithValue("@status", "")

                ' Convertir l'image en tableau de bytes et l'ajouter aux paramètres de la commande SQL
                Dim mstream As New System.IO.MemoryStream
                pic_bookimg.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim picture() As Byte = mstream.ToArray()
                mstream.Close()
                cmd.Parameters.AddWithValue("@img", picture)


                ' Exécuter la commande SQL
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                ' Vérifier si l'insertion a réussi
                If rowsAffected > 0 Then
                    MsgBox("Le livre a été ajouté avec succès!", vbInformation)
                Else
                    MsgBox("L'opération a échoué!", vbExclamation)
                End If
            Catch ex As Exception
                MsgBox("Erreur lors de l'ajout du livre: " & ex.Message, vbExclamation)
            Finally
                ' Fermer la connexion à la base de données
                conn.Close()
            End Try

            ' Effacer les champs de saisie
            clear()

            ' Générer un nouvel identifiant de livre
            Auto_bookid()
            Laod_Books()
        End If

    End Sub

    Private Sub txt_TotalPrice_TextChanged(sender As Object, e As EventArgs) Handles txt_TotalPrice.TextChanged

    End Sub

    Private Sub cbo_tax_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tax.SelectedIndexChanged
        Try
            txt_TotalPrice.Text = CDec(txt_Price.Text * cbo_tax.Text / 100) + txt_Price.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `bookid`, `bookname`, `author`, `price`, `tax`, `totalprice`, `img` FROM `tblbookmaster` WHERE bookid = '" & search.Text & "'", conn)

            dr = cmd.ExecuteReader
            While dr.Read()
                txt_BookId.Text = dr("bookid").ToString()
                txt_BookNme.Text = dr("bookname").ToString()
                txt_Author.Text = dr("author").ToString()
                txt_Price.Text = dr("price").ToString()
                cbo_tax.Text = dr("tax").ToString()
                txt_TotalPrice.Text = dr("totalprice").ToString()

                ' Vérifier si l'image n'est pas NULL avant de la charger
                If Not IsDBNull(dr("img")) Then
                    Dim bytes As Byte() = DirectCast(dr("img"), Byte())
                    Using ms As New MemoryStream(bytes)
                        pic_bookimg.Image = Image.FromStream(ms)
                    End Using
                Else
                    ' Si l'image est NULL, effacer l'image
                    pic_bookimg.Image = Nothing
                End If
            End While

        Catch ex As Exception
            MsgBox("Erreur lors de la récupération des données : " & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If txt_BookId.Text = "" OrElse
        txt_BookNme.Text = "" OrElse
        txt_Author.Text = "" OrElse
        txt_Price.Text = "" OrElse
        cbo_tax.Text = "" OrElse
        txt_TotalPrice.Text = "" OrElse
        pic_bookimg.Image Is Nothing Then

            MsgBox("Remplissez tous les champs!", vbExclamation)
        Else
            Try
                conn.Open()

                cmd = New MySqlCommand("UPDATE `tblbookmaster` SET `bookname` = @bookname, `author` = @author, `price` = @price, `tax` = @tax, `totalprice` = @totalprice, `img` = @img WHERE `bookid` = @bookid", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@bookid", txt_BookId.Text)
                cmd.Parameters.AddWithValue("@bookname", txt_BookNme.Text)
                cmd.Parameters.AddWithValue("@author", txt_Author.Text)
                cmd.Parameters.AddWithValue("@price", CDec(txt_Price.Text))
                cmd.Parameters.AddWithValue("@tax", cbo_tax.Text)
                cmd.Parameters.AddWithValue("@totalprice", CDec(txt_TotalPrice.Text))

                ' Convertir l'image en tableau de bytes et l'ajouter aux paramètres de la commande SQL
                Dim imageBytes() As Byte = Nothing
                Using ms As New MemoryStream()
                    pic_bookimg.Image.Save(ms, pic_bookimg.Image.RawFormat)
                    imageBytes = ms.ToArray()
                End Using
                cmd.Parameters.AddWithValue("@img", imageBytes)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MsgBox("Le livre a été modifié avec succès!", vbInformation)
                Else
                    MsgBox("L'opération a échoué!", vbExclamation)
                End If
            Catch ex As Exception
                MsgBox("Erreur lors de la modification du livre: " & ex.Message, vbExclamation)
            Finally
                conn.Close()
            End Try

            clear()
            Auto_bookid()
            Laod_Books()
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If MsgBox("Voulez-vous supprimer cet livres ?", vbQuestion + vbYesNo) = vbYes Then
            Try
                conn.Open()

                cmd = New MySqlCommand("DELETE FROM `tblbookmaster` WHERE `bookid` = @bookid", conn)
                cmd.Parameters.AddWithValue("@bookid", txt_BookId.Text)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MsgBox("Le livre a été supprimé avec succès!", vbInformation)
                Else
                    MsgBox("Aucun livre correspondant à l'identifiant spécifié n'a été trouvé!", vbExclamation)
                End If
            Catch ex As Exception
                MsgBox("Erreur lors de la suppression du livre: " & ex.Message, vbExclamation)
            Finally
                conn.Close()
            End Try

            clear()
            Auto_bookid()
            Laod_Books()
        Else
            Return

        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged

    End Sub
End Class