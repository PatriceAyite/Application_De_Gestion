Imports MySql.Data.MySqlClient
Public Class frm_report
    Private Sub frm_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 25
        Load_Report()
        total()
    End Sub

    Sub Load_Report()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `transno`, `transdate`, `transmonth`, `bookid`, `bookname`, `author`, `price`, `tax`, `totalprice`, `grandtotal` FROM `tblbookinventory`", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("transdate"), dr.Item("transno"), dr.Item("bookid"), dr.Item("bookname"), dr.Item("author"), dr.Item("price"), dr.Item("tax"), dr.Item("totalprice"), dr.Item("grandtotal"))

            End While
        Catch ex As Exception
            MsgBox("message3")
        End Try
        conn.Close()

    End Sub

    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `transno`, `transdate`, `transmonth`, `bookid`, `bookname`,  `author`, `price`, `tax`, `totalprice`, `grandtotal` FROM `tblbookinventory` WHERE transno like '%" & txt_Search.Text & "%' or bookid like '%" & txt_Search.Text & "%' or bookname like '%" & txt_Search.Text & "%' or author like '%" & txt_Search.Text & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read()
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("transdate"), dr.Item("transno"), dr.Item("bookid"), dr.Item("bookname"), dr.Item("author"), dr.Item("price"), dr.Item("tax"), dr.Item("totalprice"), dr.Item("grandtotal"))
            End While
        Catch ex As Exception
            'MsgBox("Une erreur s'est produite lors de la recherche : " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim date1 As String = Guna2DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim date2 As String = Guna2DateTimePicker2.Value.ToString("yyyy-MM-dd")
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `transno`, `transdate`, `transmonth`, `bookid`, `bookname`, `author`, `price`, `tax`, `totalprice`, `grandtotal` FROM `tblbookinventory` WHERE transdate BETWEEN '" & date1 & "' AND '" & date2 & "'", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("transdate"), dr.Item("transno"), dr.Item("bookid"), dr.Item("bookname"), dr.Item("author"), dr.Item("price"), dr.Item("tax"), dr.Item("totalprice"), dr.Item("grandtotal"))

            End While
        Catch ex As Exception
            MsgBox("message1")
        End Try
        conn.Close()

    End Sub



    Sub total()
        Try
            Dim sum As Double = 0
            For j As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
                sum += DataGridView1.Rows(j).Cells(8).Value
            Next
            lbl_total.Text = sum
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors du calcul du total : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        total()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class