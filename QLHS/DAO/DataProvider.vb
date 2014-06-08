
Imports System.Data.SqlClient
Public Class DataProvider
    Public Shared Function ConnectDB() As SqlConnection
        Dim connectstring As String
        connectstring = "Server=MAP;Database=QLHocSinh;Trusted_Connection=True;"
        Dim conn As New SqlConnection(connectstring)
        conn.Open()
        Return conn
    End Function
End Class
