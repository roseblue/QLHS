Imports System.Data.OleDb

Public Class DataProvider
    Public Shared Function ConnectDB() As OleDbConnection
        Dim connectstring As String
        connectstring = "Provider=SQLNCLI10;Server=MAP;Database=QLHocSinh;Trusted_Connection=yes;"
        Dim conn As New OleDbConnection(connectstring)
        conn.Open()
        Return conn
    End Function
End Class
