Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Drawing
Public Class frm_cashier
    Private WithEvents pan As Panel
    Private WithEvents pan_top As Panel
    Private WithEvents petcode As Label
    Private WithEvents petname As Label
    Private WithEvents price As Label
    Private WithEvents img As CirclePicturBox


    Private Sub frm_cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        lbl_date.Text = Date.Now.ToString("yyyy-MM-dd")
        DataGridView1.RowTemplate.Height = 40
        auto_Transno()
        load_pets()
    End Sub
    Sub auto_Transno()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tbl_pos` order by id desc", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                txt_transno.Text = dr.Item("transno").ToString + 1

            Else
                txt_transno.Text = Date.Now.ToString("yyyyMM") & "001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Sub Load_controls()
        Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
        Dim array(CInt(len)) As Byte
        dr.GetBytes(0, 0, array, 0, CInt(len))


        pan = New Panel
        With pan
            .Width = 150
            .Height = 230
            .BackColor = Color.FromArgb(243, 243, 243)
            .Tag = dr.Item("petid").ToString
        End With
        pan_top = New Panel
        With pan_top
            .Width = 150
            .Height = 10
            .BackColor = Color.FromArgb(243, 243, 243)
            .Dock = DockStyle.Top
            .Tag = dr.Item("petid").ToString
        End With

        img = New CirclePicturBox
        With img
            .Height = 140
            .BackgroundImageLayout = ImageLayout.Stretch
            .Dock = DockStyle.Top
            .Tag = dr.Item("petid").ToString
        End With

        petcode = New Label
        With petcode
            .ForeColor = Color.FromArgb(236, 29, 99)
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = dr.Item("petid").ToString
        End With
        petname = New Label
        With petname
            .ForeColor = Color.FromArgb(44, 44, 45)
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = dr.Item("petid").ToString
        End With

        price = New Label
        With price
            .ForeColor = Color.FromArgb(44, 44, 45)
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = dr.Item("petid").ToString
        End With

        Dim ms As New System.IO.MemoryStream(array)
        Dim bitmap As New System.Drawing.Bitmap(ms)
        img.BackgroundImage = bitmap

        petcode.Text = " Pet Code   : " & dr.Item("petid").ToString
        petname.Text = " Pet Name  : " & dr.Item("petname").ToString
        price.Text = " Price          : " & dr.Item("price").ToString

        pan.Controls.Add(price)
        pan.Controls.Add(petname)
        pan.Controls.Add(petcode)
        pan.Controls.Add(img)


        pan.Controls.Add(pan_top)
        FlowLayoutPanel1.Controls.Add(pan)

        AddHandler petcode.Click, AddressOf Selectimg_Click
        AddHandler petname.Click, AddressOf Selectimg_Click
        AddHandler price.Click, AddressOf Selectimg_Click
        AddHandler img.Click, AddressOf Selectimg_Click
        AddHandler pan.Click, AddressOf Selectimg_Click
    End Sub
    Public Sub Selectimg_Click(sender As Object, e As EventArgs)
        conn.Open()
        Try
            cmd = New MySqlCommand("SELECT `petid`, `petname`, `price`,`age`,`pettype`,`colour` FROM `tbl_pets` WHERE `petid` like '" & sender.tag.ToString & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim exist As Boolean = False, numrow As Integer = 0, numtext As Integer
                For Each itm As DataGridViewRow In DataGridView1.Rows
                    If itm.Cells(1).Value IsNot Nothing Then
                        If itm.Cells(1).Value.ToString = dr.Item("petid") Then
                            exist = True
                            numrow = itm.Index
                            numtext = CInt(itm.Cells(7).Value)
                            Exit For
                        End If
                    End If
                Next
                If exist = False Then
                    Dim price As Decimal = dr("price")
                    Dim subtotalprice As Double
                    subtotalprice = price * 1
                    DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("petid"), dr.Item("petname"), dr.Item("age"), dr.Item("pettype"), dr.Item("colour"), dr.Item("price"), 1, subtotalprice)
                Else
                    DataGridView1.Rows(numrow).Cells(7).Value = CInt("1") + numtext
                    DataGridView1.Rows(numrow).Cells(8).Value = DataGridView1.Rows(numrow).Cells(6).Value * DataGridView1.Rows(numrow).Cells(7).Value
                End If

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dr.Dispose()
        conn.Close()

    End Sub

    Sub load_pets()
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.AutoScroll = True
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `pic`, `petid`, `petname`, `price` FROM `tbl_pets`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Load_controls()
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub


    Sub Get_grandTotal()
        Try
            Dim grandtotal As Double = 0
            For i As Double = 0 To DataGridView1.Rows.Count() - 1 Step +1
                grandtotal = grandtotal + DataGridView1.Rows(i).Cells(8).Value

            Next
            lbl_overallTotal.Text = Format(CDec(grandtotal), "#,##0.00")
            lbl_GrandTotal.Text = Format(CDec(grandtotal), "#,##0.00")
            
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Get_grandTotal()
        lbl_cdate.Text = Date.Now.ToString("dd-MM-yyyy")
        lbl_day.Text = Date.Now.ToString("dddd")
        lbl_time.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    
    Private Sub btn_Pay_Click(sender As Object, e As EventArgs) Handles btn_Pay.Click
        If MsgBox("Are You Sure Order Conform ?", vbQuestion + vbYesNo) = vbYes Then
            Try
                conn.Open()
                cmd = New MySqlCommand("INSERT INTO `tbl_pos`(`transdate`, `transmonth`, `transno`, `petid`, `petname`, `pettype`, `age`, `color`, `price`, `qty`, `total`, `grandtotal`) VALUES (@transdate,@transmonth,@transno,@petid,@petname,@pettype,@age,@color,@price,@qty,@total,@grandtotal)", conn)
                For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@transdate", CDate(lbl_date.Text))
                    cmd.Parameters.AddWithValue("@transmonth", Date.Now.ToString("MM"))
                    cmd.Parameters.AddWithValue("@transno", txt_transno.Text)
                    cmd.Parameters.AddWithValue("@petid", DataGridView1.Rows(j).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@petname", DataGridView1.Rows(j).Cells(2).Value)
                    cmd.Parameters.AddWithValue("@age", DataGridView1.Rows(j).Cells(3).Value)
                    cmd.Parameters.AddWithValue("@pettype", DataGridView1.Rows(j).Cells(4).Value)
                    cmd.Parameters.AddWithValue("@color", DataGridView1.Rows(j).Cells(5).Value)
                    cmd.Parameters.AddWithValue("@price", DataGridView1.Rows(j).Cells(6).Value)
                    cmd.Parameters.AddWithValue("@qty", DataGridView1.Rows(j).Cells(7).Value)
                    cmd.Parameters.AddWithValue("@total", DataGridView1.Rows(j).Cells(8).Value)

                    cmd.Parameters.AddWithValue("@grandtotal", CDec(lbl_GrandTotal.Text))

                    i = cmd.ExecuteNonQuery
                Next
                If i > 0 Then
                    MsgBox("Info : Paiement réussi !", vbInformation)
                Else
                    MsgBox("Attention : quelques échecs !", vbExclamation)
                End If
            Catch ex As Exception

            End Try
            conn.Close()
        End If
        DataGridView1.Rows.Clear()
        load_pets()
        auto_Transno()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.AutoScroll = True
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `pic`, `petid`, `petname`, `price`,`age`,`pettype`,`colour` FROM `tbl_pets` WHERE petid like '%" & txt_search.Text & "%' or petname like '%" & txt_search.Text & "%' or pettype like '%" & txt_search.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Load_controls()
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub lbbl_close_Click(sender As Object, e As EventArgs) Handles lbbl_close.Click
        Me.Close()
        frm_login.Show()
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class