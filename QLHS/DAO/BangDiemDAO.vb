Imports DTO
Imports System.Data.SqlClient
Public Class BangDiemDAO
    Public Shared Function layMonHoc(maLop As Integer, maHK As Integer, maMon As Integer) As DataTable

        Dim conn As SqlConnection = DataProvider.getConnection()
        Dim sql = String.Format("select ")
        conn.Open()
        Dim adaper As New SqlDataAdapter(New SqlCommand(sql, conn))
        Dim dt As New DataTable
        adaper.Fill(dt)
        conn.Close()

        Return dt
    End Function
End Class
