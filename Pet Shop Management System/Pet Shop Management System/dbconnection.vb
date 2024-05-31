Imports MySql.Data.MySqlClient
Imports System.IO
Module dbconnection

    Public conn As New MySqlConnection
    Dim result As Boolean
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public i As Integer

    Public name As String
    Public user As String
    Public pass As String
    Public role As String
    Public Function dbconn() As Boolean
        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "server=localhost;user=root;password=;port=3306;database=pet_shop_db"
                result = True
            End If
        Catch ex As Exception
            result = False
            MsgBox("Server Not Connected !", vbExclamation)
        End Try
        Return result
    End Function

End Module
