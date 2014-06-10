Imports DTO
Imports System.Data.SqlClient
Public Class KhoiDAO
    Public Shared Function laykhoi() As List(Of KhoiDTO)
        Dim sql = "select MaKhoi,TenKhoi from Khoi"
        Dim conn As SqlConnection
        conn = DataProvider.getConnection()
        Dim cmd As New SqlCommand(sql, conn)
        conn.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        Dim ds As New List(Of KhoiDTO)
        While reader.Read()
            Dim khoi As New KhoiDTO
            khoi.MaKhoi = reader.GetInt32(0)
            khoi.TenKhoi = reader.GetString(1)
            ds.Add(khoi)
        End While
        conn.Close()
        Return ds
    End Function
End Class
