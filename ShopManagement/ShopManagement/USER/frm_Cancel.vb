Imports MySql.Data.MySqlClient
Public Class frm_Cancel
    Private Sub frm_Cancel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        Load_Transaction()
        Update_bookStatus()
        UpdateStatus()
    End Sub
    Sub Load_Transaction()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `ID`, `transno`, `transdate`, `transmonth`, `bookid`, `bookname`, `author`, `price`, `tax`, `totalprice`, `grandtotal` FROM `tblbookinventory` GROUP BY grandtotal ", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.ColumnCount + 1, dr.Item("transdate"), dr.Item("transno"), dr.Item("grandtotal"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "Column5" Then
            If MsgBox("Voulez-vous vraiment suprimer les commande", vbQuestion + vbYesNo) = vbYes Then
                conn.Open()
                cmd = New MySqlCommand("DELETE FROM `tblbookinventory` WHERE `transno`=@transno", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@transno", DataGridView1.CurrentRow.Cells(2).Value)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Commande annuler avec succes !", vbInformation)
                Else
                    MsgBox("Echec !", vbExclamation)
                End If
            End If
            conn.Close()
        End If
        Load_Transaction()
        Update_bookStatus()
        frm_UserMain.Load_Books()
        UpdateStatus()
    End Sub

    Sub Update_bookStatus()
        Try
            conn.Open()
            For j As Integer = 0 To DataGridView1.Rows.Count - 1
                Dim bookId As Integer = Convert.ToInt32(DataGridView1.Rows(j).Cells(2).Value)
                Dim query As String = "UPDATE `tblbookmaster` SET `status`='' WHERE `bookid`=@bookid"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@bookid", bookId)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    Console.WriteLine("Nombre de lignes mises à jour : " & rowsAffected)
                End Using
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub UpdateStatus()
        Dim query As String = "UPDATE tblbookmaster SET status = '' WHERE status = 'VENDU'"

        Using conn As New MySqlConnection("server=localhost;user=root;password=;port=3306;database=book_db")
            Using cmd As New MySqlCommand(query, conn)
                Try
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    Console.WriteLine("Nombre de lignes mises à jour : " & rowsAffected)
                Catch ex As Exception
                    Console.WriteLine("Erreur lors de la mise à jour : " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

End Class