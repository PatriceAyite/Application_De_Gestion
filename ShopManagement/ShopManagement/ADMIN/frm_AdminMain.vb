Imports MySql.Data.MySqlClient

Public Class frm_AdminMain

    Private Sub frm_AdminMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Get_DashBoard()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        frm_ManageUser.ShowDialog()
        Get_DashBoard()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        frm_report.ShowDialog()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Me.Close()
        login.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        frm_ManageBook.ShowDialog()
        Get_DashBoard()
    End Sub

    Sub Get_DashBoard()
        Dim connectionString As String = "server=localhost;user=root;password=;port=3306;database=book_db"

        Using conn As New MySqlConnection(connectionString)
            conn.Open()

            ' Récupérer le total des ventes d'aujourd'hui
            Dim totalSaleTodayQuery As String = "SELECT SUM(`totalprice`) FROM `tblbookinventory` WHERE `transdate`=@transdate"
            Using cmd As New MySqlCommand(totalSaleTodayQuery, conn)
                cmd.Parameters.AddWithValue("@transdate", Date.Now.ToString("yyyy-MM-dd"))
                Dim totalSaleToday As Object = cmd.ExecuteScalar()
                lbl_totalSale.Text = If(totalSaleToday IsNot Nothing AndAlso Not IsDBNull(totalSaleToday), Convert.ToString(totalSaleToday), "0")
            End Using

            ' Récupérer le nombre de ventes d'aujourd'hui
            Dim countTodaySaleQuery As String = "SELECT COUNT(`bookid`) FROM `tblbookinventory` WHERE `transdate`=@transdate"
            Using cmd As New MySqlCommand(countTodaySaleQuery, conn)
                cmd.Parameters.AddWithValue("@transdate", Date.Now.ToString("yyyy-MM-dd"))
                Dim countTodaySale As Object = cmd.ExecuteScalar()
                lbl_NoofTodaySale.Text = If(countTodaySale IsNot Nothing AndAlso Not IsDBNull(countTodaySale), Convert.ToString(countTodaySale), "0")
            End Using

            ' Récupérer le total des ventes du mois en cours
            Dim totalMonthSaleQuery As String = "SELECT SUM(`totalprice`) FROM `tblbookinventory` WHERE `transmonth`=@transmonth"
            Using cmd As New MySqlCommand(totalMonthSaleQuery, conn)
                cmd.Parameters.AddWithValue("@transmonth", Date.Now.ToString("MM"))
                Dim totalMonthSale As Object = cmd.ExecuteScalar()
                lbl_currentMonthSal.Text = If(totalMonthSale IsNot Nothing AndAlso Not IsDBNull(totalMonthSale), Convert.ToString(totalMonthSale), "0")
            End Using

            ' Récupérer le nombre de ventes du mois en cours
            Dim countMonthSaleQuery As String = "SELECT COUNT(`bookid`) FROM `tblbookinventory` WHERE `transmonth`=@transmonth"
            Using cmd As New MySqlCommand(countMonthSaleQuery, conn)
                cmd.Parameters.AddWithValue("@transmonth", Date.Now.ToString("MM"))
                Dim countMonthSale As Object = cmd.ExecuteScalar()
                lbl_noOfMonth.Text = If(countMonthSale IsNot Nothing AndAlso Not IsDBNull(countMonthSale), Convert.ToString(countMonthSale), "0")
            End Using

            ' Récupérer le nombre total de livres
            Dim totalBookQuery As String = "SELECT COUNT(`bookid`) FROM `tblbookmaster`"
            Using cmd As New MySqlCommand(totalBookQuery, conn)
                Dim totalBookCount As Object = cmd.ExecuteScalar()
                lbl_totalBook.Text = If(totalBookCount IsNot Nothing AndAlso Not IsDBNull(totalBookCount), Convert.ToString(totalBookCount), "0")
            End Using

            ' Récupérer le nombre total d'utilisateurs
            Dim totalUserQuery As String = "SELECT COUNT(`name`) FROM `tbluser`"
            Using cmd As New MySqlCommand(totalUserQuery, conn)
                Dim totalUserCount As Object = cmd.ExecuteScalar()
                lbl_userTotal.Text = If(totalUserCount IsNot Nothing AndAlso Not IsDBNull(totalUserCount), Convert.ToString(totalUserCount), "0")
            End Using

            conn.Close()
        End Using
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_time.Text = Date.Now.ToString("hh:mm:ss tt")
        lbl_date.Text = Date.Now.ToString("dddd MMMM-yyyy")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub lbl_time_Click(sender As Object, e As EventArgs) Handles lbl_time.Click

    End Sub

    Private Sub lbl_totalBook_Click(sender As Object, e As EventArgs) Handles lbl_totalBook.Click

    End Sub
End Class
