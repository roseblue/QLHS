Imports DTO
Imports System.Data.SqlClient
Public Class BangDiemDAO
    Public Shared Function layDiem(maHK As Integer, maMon As Integer) As DataTable

        Dim conn As SqlConnection = DataProvider.getConnection()
        Dim sql = String.Format("select hs.mahs, hs.malop, hs.hoten, d.maloaidiem, d.diem, d.mamh from Diem d, hocsinh hs where hs.mahs = d.mahs and d.mamh = {0} and d.mahk = {1}", maMon, maHK)
        conn.Open()
        Dim adaper As New SqlDataAdapter(New SqlCommand(sql, conn))
        Dim dt As New DataTable
        adaper.Fill(dt)
        conn.Close()

        Return dt
    End Function
End Class
