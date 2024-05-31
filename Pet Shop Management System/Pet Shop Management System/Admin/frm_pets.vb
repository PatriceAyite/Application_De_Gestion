Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frm_pets

    Private Sub frm_pets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30

        auto_PetID()
        Load_petdata()

    End Sub
    Sub Load_petdata()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `petid`, `petname`, `pettype`, `age`, `colour`, `price`, `pic` FROM `tbl_pets`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("petid"), dr.Item("petname"), dr.Item("pettype"), dr.Item("age"), dr.Item("colour"), dr.Item("price"), dr.Item("pic"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub pet_pic_Click(sender As Object, e As EventArgs) Handles pet_pic.Click
        Dim pop As OpenFileDialog = New OpenFileDialog
        If pop.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            pet_pic.Image = Image.FromFile(pop.FileName)
        End If
    End Sub

    Sub auto_PetID()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tbl_pets` order by id desc", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                txt_petID.Text = dr.Item("petid").ToString + 1

            Else
                txt_petID.Text = Date.Now.ToString("yyyyMM") & "001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub clear()
        txt_petID.Clear()
        txt_petname.Clear()
        cbo_pettype.SelectedIndex = -1
        txt_age.Clear()
        txt_Color.Clear()
        txt_price.Clear()
        txt_search.Clear()
        pet_pic.Image = Nothing

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `tbl_pets`(`petid`, `petname`, `pettype`, `age`, `colour`, `price`, `pic`) VALUES (@petid,@petname,@pettype,@age,@colour,@price,@pic)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@petid", txt_petID.Text)
            cmd.Parameters.AddWithValue("@petname", txt_petname.Text)
            cmd.Parameters.AddWithValue("@pettype", cbo_pettype.Text)
            cmd.Parameters.AddWithValue("@age", txt_age.Text)
            cmd.Parameters.AddWithValue("@colour", txt_Color.Text)
            cmd.Parameters.AddWithValue("@price", CDec(txt_price.Text))

            Dim FileSize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            pet_pic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim picture() As Byte = mstream.GetBuffer
            FileSize = mstream.Length
            mstream.Close()
            cmd.Parameters.AddWithValue("@pic", picture)

            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Sauvegarde réussie d'un nouvel animal de compagnie !", vbInformation, "ANIMALERIE")
            Else
                MsgBox("Avertissement : échec de la sauvegarde de l'animal !", vbCritical, "ANIMALERIE")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        clear()

        auto_PetID()
        Load_petdata()


    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `tbl_pets` SET `petname`=@petname,`pettype`=@pettype,`age`=@age,`colour`=@colour,`price`=@price,`pic`=@pic WHERE `petid`=@petid", conn)
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@petname", txt_petname.Text)
            cmd.Parameters.AddWithValue("@pettype", cbo_pettype.Text)
            cmd.Parameters.AddWithValue("@age", txt_age.Text)
            cmd.Parameters.AddWithValue("@colour", txt_Color.Text)
            cmd.Parameters.AddWithValue("@price", CDec(txt_price.Text))

            Dim FileSize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            pet_pic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim picture() As Byte = mstream.GetBuffer
            FileSize = mstream.Length
            mstream.Close()
            cmd.Parameters.AddWithValue("@pic", picture)
            cmd.Parameters.AddWithValue("@petid", txt_petID.Text)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Animal modifier !", vbInformation, "ANIMALERIE")
            Else
                MsgBox("Echec de modification  !", vbCritical, "ANIMALERIE")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        clear()

        auto_PetID()
        Load_petdata()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MsgBox("Voullez-vous supprimer l'animal !", vbQuestion + vbYesNo, "ANIMALERIE") = vbYes Then
            Try
                conn.Open()
                cmd = New MySqlCommand("DELETE FROM `tbl_pets` WHERE `petid`=@petid", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@petid", txt_petID.Text)
                Dim i As Integer
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Suppression !", vbInformation, "ANIMALERIE")
                Else
                    MsgBox("Echec !", vbCritical, "ANIMALERIE")
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
            clear()
            auto_PetID()
            Load_petdata()
        Else
            Return

        End If

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        clear()
    End Sub

    Private Sub btn_find_Click(sender As Object, e As EventArgs) Handles btn_find.Click

        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tbl_pets` WHERE `petid`=@petid", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@petid", txt_search.Text)
            dr = cmd.ExecuteReader
            While dr.Read

                Dim petid As String = dr.Item("petid")
                Dim petname As String = dr.Item("petname")
                Dim pettype As String = dr.Item("pettype")
                Dim age As String = dr.Item("age")
                Dim colour As String = dr.Item("colour")
                Dim price As Decimal = dr.Item("price")

                txt_petID.Text = petid
                txt_petname.Text = petname
                cbo_pettype.Text = pettype
                txt_age.Text = age
                txt_Color.Text = colour
                txt_price.Text = price
                Dim bytes As [Byte]() = dr.Item("pic")
                Dim ms As New MemoryStream(bytes)
                pet_pic.Image = Image.FromStream(ms)

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub txt_SearchForDGV_TextChanged(sender As Object, e As EventArgs) Handles txt_SearchForDGV.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `petid`, `petname`, `pettype`, `age`, `colour`, `price`, `pic` FROM `tbl_pets` WHERE  petid like '%" & txt_SearchForDGV.Text & "%' or petname like '%" & txt_SearchForDGV.Text & "%' or pettype like '%" & txt_SearchForDGV.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("petid"), dr.Item("petname"), dr.Item("pettype"), dr.Item("age"), dr.Item("colour"), dr.Item("price"), dr.Item("pic"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Close()
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub
End Class