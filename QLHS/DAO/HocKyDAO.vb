Imports DTO
Imports System.Data.SqlClient
Public Class HocKyDAO
    Public Shared Function layHK() As List(Of HocKyDTO)
        Dim conn As SqlConnection = DataProvider.getConnection()
        Dim cmd As New SqlCommand("select * from hocky", conn)
        conn.Open()
        Dim lstHK As New List(Of HocKyDTO)
        Dim reader As SqlDataReader = cmd.ExecuteReader
        If reader.HasRows Then
            While (reader.Read)
                Dim hk As New HocKyDTO
                hk.MaHK = reader.GetInt32(0)
                hk.TenHK = reader.GetString(1)
                hk.NamHoc = reader.GetString(2)
                hk.TenHKDayDU = hk.TenHK & " - " & hk.NamHoc
                lstHK.Add(hk)
            End While
        End If

        conn.Close()

        Return lstHK


    End Function
End Class
