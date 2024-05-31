Imports System.Drawing.Printing
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frm_UserMain

    Private WithEvents pic As New PictureBox
    Private WithEvents lblbookid As New Label
    Private WithEvents lblbookname As New Label
    Private WithEvents lblprice As New Label

    Private Sub frm_UserMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        Me.WindowState = FormWindowState.Maximized
        DataGridView1.RowTemplate.Height = 28
        lbl_TransationDate.Text = Date.Now.ToString("yyy-MM-dd")
        Auto_generateTransNo()
        Load_Books()
    End Sub



    Sub Auto_generateTransNo()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tblbookinventory` WHERE `transno`  ORDER BY id DESC", conn)

            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                Dim lastTransNo As Integer = Convert.ToInt32(dr("transno")) ' Convertir le numéro de transaction en entier
                lbl_TransationNo.Text = (lastTransNo + 1).ToString() ' Incrémenter et afficher le nouveau numéro de transaction
            Else
                lbl_TransationNo.Text = Date.Now.ToString("yyyMM") & "001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Sub Total()
        Dim sum As Double = 0
        For k As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum = sum + DataGridView1.Rows(k).Cells(6).Value
        Next
        lbl_GrandTota.Text = Format(CDec(sum), "#,##0.00")
    End Sub

    Sub Load_controls()
        If Not dr Is Nothing AndAlso dr.HasRows Then
            While dr.Read()
                If Not IsDBNull(dr("bookid")) AndAlso Not IsDBNull(dr("bookname")) AndAlso Not IsDBNull(dr("totalprice")) AndAlso Not IsDBNull(dr("img")) Then
                    Dim pic As New PictureBox()
                    pic.Width = 120
                    pic.Height = 200
                    pic.BackgroundImageLayout = ImageLayout.Stretch
                    pic.Tag = dr.Item("bookid").ToString

                    Dim lblbookid As New Label()
                    lblbookid.ForeColor = Color.Red
                    lblbookid.BackColor = Color.WhiteSmoke
                    lblbookid.TextAlign = ContentAlignment.MiddleLeft
                    lblbookid.Dock = DockStyle.Top
                    lblbookid.Font = New Font("Segoe UI", 8, FontStyle.Bold)
                    lblbookid.Text = dr("bookid").ToString()
                    lblbookid.Tag = dr.Item("bookid").ToString

                    Dim lblbookname As New Label()
                    lblbookname.ForeColor = Color.DimGray
                    lblbookname.BackColor = Color.WhiteSmoke
                    lblbookname.TextAlign = ContentAlignment.MiddleLeft
                    lblbookname.Dock = DockStyle.Top
                    lblbookname.Font = New Font("Segoe UI", 8, FontStyle.Bold)
                    lblbookname.Text = dr("bookname").ToString()
                    lblbookname.Tag = dr.Item("bookid").ToString

                    Dim lblprice As New Label()
                    lblprice.ForeColor = Color.Orange
                    lblprice.BackColor = Color.WhiteSmoke
                    lblprice.TextAlign = ContentAlignment.MiddleLeft
                    lblprice.Dock = DockStyle.Bottom
                    lblprice.Font = New Font("Segoe UI", 8, FontStyle.Bold)
                    lblprice.Text = dr("totalprice").ToString()
                    lblprice.Tag = dr.Item("bookid").ToString

                    ' Charger l'image depuis la base de données
                    Dim imageData As Byte() = DirectCast(dr("img"), Byte())
                    If Not imageData Is Nothing AndAlso imageData.Length > 0 Then
                        Using ms As New MemoryStream(imageData)
                            Dim image As Image = Image.FromStream(ms)
                            pic.BackgroundImage = image
                        End Using
                    End If

                    ' Ajouter les contrôles au PictureBox
                    pic.Controls.Add(lblbookid)
                    pic.Controls.Add(lblbookname)
                    pic.Controls.Add(lblprice)

                    ' Ajouter le PictureBox au FlowLayoutPanel2
                    FlowLayoutPanel2.Controls.Add(pic)

                    AddHandler pic.Click, AddressOf Selectimg_click
                    AddHandler lblbookid.Click, AddressOf Selectimg_click
                    AddHandler lblbookname.Click, AddressOf Selectimg_click
                    AddHandler lblprice.Click, AddressOf Selectimg_click

                End If
            End While
        End If

    End Sub

    Sub Selectimg_click(sender As Object, e As EventArgs)
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `bookid`, `bookname`, `author`, `price`, `tax`, `totalprice`, `img` FROM `tblbookmaster` WHERE bookid like '%" & sender.tag.ToString & "%' ", conn)

            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("bookid"), dr.Item("bookname"), dr.Item("author"), dr.Item("price"), dr.Item("tax"), dr.Item("totalprice"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Public Sub Load_Books()
        FlowLayoutPanel2.AutoScroll = True
        FlowLayoutPanel2.Controls.Clear()
        conn.Open()
        cmd = New MySqlCommand("SELECT `bookid`, `bookname`, `author`, `price`, `tax`, `totalprice`, `img`,`status` FROM `tblbookmaster` WHERE status=''", conn)
        dr = cmd.ExecuteReader
        Load_controls()
        dr.Dispose()
        conn.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Total()
    End Sub

    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        FlowLayoutPanel2.AutoScroll = True
        FlowLayoutPanel2.Controls.Clear()

        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `bookid`, `bookname`, `author`, `price`, `tax`, `totalprice`, `img`,`status` FROM `tblbookmaster` WHERE status ='' AND bookid LIKE '%" & txt_Search.Text & "%' OR bookname LIKE '%" & txt_Search.Text & "%'", conn)

            dr = cmd.ExecuteReader()
            Load_controls()
        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            If dr IsNot Nothing Then
                dr.Dispose()
            End If
        End Try

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs)


    End Sub

    Sub clear()
        DataGridView1.Rows.Clear()
        Load_Books()
        Auto_generateTransNo()
        txt_enteramount.Clear()
        txt_Search.Clear()
        lbl_GrandTota.Text = "0.00"
    End Sub

    Sub update_bookstok()
        Try
            conn.Open()
            cmd = New MySqlCommand("UPDATE `tblbookmaster` SET `status`=@status WHERE `bookid` =@bookid", conn)
            For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@status", "VENDU")
                cmd.Parameters.AddWithValue("@bookid", DataGridView1.Rows(j).Cells(1).Value)
                i = cmd.ExecuteNonQuery
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub


    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Close()
        login.Show()

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        frm_Cancel.ShowDialog()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        frm_report.ShowDialog()
    End Sub

    Private Sub FlowLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel2.Paint

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click

        If Val(lbl_GrandTota.Text) > Val(txt_enteramount.Text) Then ' Convertir en valeurs numériques pour la comparaison
            MsgBox("Votre solde est insuffisant !", vbExclamation)
        Else
            Try
                conn.Open()
                cmd = New MySqlCommand("INSERT INTO `tblbookinventory`(`transno`, `transdate`, `transmonth`, `bookid`, `bookname`, `author`, `price`, `tax`, `totalprice`, `grandtotal`) VALUES (@transno, @transdate, @transmonth, @bookid, @bookname, @author, @price, @tax, @totalprice, @grandtotal)", conn)

                For j = 0 To DataGridView1.Rows.Count - 1 Step +1
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@transno", lbl_TransationNo.Text)
                    cmd.Parameters.AddWithValue("@transdate", lbl_TransationDate.Text) ' Ajout de .Text pour obtenir la valeur de la propriété Text
                    cmd.Parameters.AddWithValue("@transmonth", Date.Now.ToString("MM"))

                    cmd.Parameters.AddWithValue("@bookid", DataGridView1.Rows(j).Cells(1).Value) ' Utilisation de l'index correct pour accéder aux valeurs de chaque colonne
                    cmd.Parameters.AddWithValue("@bookname", DataGridView1.Rows(j).Cells(2).Value) ' Utilisation de l'index correct pour accéder aux valeurs de chaque colonne
                    cmd.Parameters.AddWithValue("@author", DataGridView1.Rows(j).Cells(3).Value) ' Utilisation de l'index correct pour accéder aux valeurs de chaque colonne
                    cmd.Parameters.AddWithValue("@price", DataGridView1.Rows(j).Cells(4).Value) ' Utilisation de l'index correct pour accéder aux valeurs de chaque colonne
                    cmd.Parameters.AddWithValue("@tax", DataGridView1.Rows(j).Cells(5).Value) ' Utilisation de l'index correct pour accéder aux valeurs de chaque colonne
                    cmd.Parameters.AddWithValue("@totalprice", DataGridView1.Rows(j).Cells(6).Value) ' Utilisation de l'index correct pour accéder aux valeurs de chaque colonne

                    cmd.Parameters.AddWithValue("@grandtotal", CDec(lbl_GrandTota.Text))
                    i += cmd.ExecuteNonQuery
                Next
                If i > 0 Then
                    MsgBox("Paiement réussi !", vbInformation)
                Else
                    MsgBox("Attention : quelques échecs !", vbExclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
                update_bookstok()
                PrintDocument1.Print()
                clear()
                leReste()

            End Try
        End If

    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        frm_option.Show()
    End Sub

    Private Sub Guna2Button5_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_enteramount_TextChanged(sender As Object, e As EventArgs) Handles txt_enteramount.TextChanged
        leReste()
    End Sub


    Sub leReste()
        ' Déclaration des variables pour le montant total et le montant payé
        Dim montant As Decimal
        Dim prix As Decimal
        Dim reste As Decimal

        ' Valider et convertir le texte en valeurs numériques
        Decimal.TryParse(txt_enteramount.Text, prix)
        Decimal.TryParse(lbl_GrandTota.Text, montant)

        ' Calculer la monnaie à rendre
        reste = prix - montant
        ' Afficher le résultat dans txt_reste

        If (reste > 0) Then
            txt_reste.Text = reste.ToString("0.00")
        Else
            txt_reste.Text = "00.00F"
        End If

    End Sub



    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles txt_reste.Click
        leReste()
    End Sub

    Private Sub lbl_GrandTota_Click(sender As Object, e As EventArgs) Handles lbl_GrandTota.Click
        leReste()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Sub impression()

    End Sub



    ' Exemple d'appel des fonctions pour configurer et afficher la prévisualisation d'impression






End Class
