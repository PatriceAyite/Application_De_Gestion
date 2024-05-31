Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Drawing
Public Class frm_report

    Private Sub frm_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 35
        Load_report()
    End Sub
    Sub Load_report()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `transdate`, `transmonth`, `transno`, `petid`, `petname`, `pettype`, `age`, `color`, `price`, `qty`, `total`, `grandtotal` FROM `tbl_pos`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("transdate"), dr.Item("transmonth"), dr.Item("transno"), dr.Item("petid"), dr.Item("petname"), dr.Item("pettype"), dr.Item("age"), dr.Item("color"), dr.Item("price"), dr.Item("qty"), dr.Item("total"), dr.Item("grandtotal"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `transdate`, `transmonth`, `transno`, `petid`, `petname`, `pettype`, `age`, `color`, `price`, `qty`, `total`, `grandtotal` FROM `tbl_pos` WHERE transno like '%" & txt_search.Text & "%' or petid like '%" & txt_search.Text & "%' or petname like '%" & txt_search.Text & "%' or pettype like '%" & txt_search.Text & "%' or color like '%" & txt_search.Text & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("transdate"), dr.Item("transmonth"), dr.Item("transno"), dr.Item("petid"), dr.Item("petname"), dr.Item("pettype"), dr.Item("age"), dr.Item("color"), dr.Item("price"), dr.Item("qty"), dr.Item("total"), dr.Item("grandtotal"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btn_Filter_Click(sender As Object, e As EventArgs) Handles btn_Filter.Click
        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")

        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `transdate`, `transmonth`, `transno`, `petid`, `petname`, `pettype`, `age`, `color`, `price`, `qty`, `total`, `grandtotal` FROM `tbl_pos` WHERE transdate between '" & date1 & "' and '" & date2 & "'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("transdate"), dr.Item("transmonth"), dr.Item("transno"), dr.Item("petid"), dr.Item("petname"), dr.Item("pettype"), dr.Item("age"), dr.Item("color"), dr.Item("price"), dr.Item("qty"), dr.Item("total"), dr.Item("grandtotal"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btn_Excel_Click(sender As Object, e As EventArgs) 

    End Sub
    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class