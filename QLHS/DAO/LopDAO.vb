Imports DTO
Imports System.Data.SqlClient
Public Class LopDAO
    Public Shared Function layLop() As List(Of LopDTO)
        Dim conn As SqlConnection = DataProvider.getConnection()
        Dim cmd As New SqlCommand("select * from Lop", conn)
        conn.Open()
        Dim lstLop As New List(Of LopDTO)
        Dim reader As SqlDataReader = cmd.ExecuteReader
        If reader.HasRows Then
            While (reader.Read)
                Dim lop As New LopDTO
                lop.MaLop = reader.GetInt32(0)
                lop.TenLop = reader.GetString(1)
                lop.SiSo = reader.GetInt32(2)
                lop.MaKhoi = reader.GetInt32(3)
                lstLop.Add(lop)
            End While
        End If

        conn.Close()

        Return lstLop

    End Function
End Class
