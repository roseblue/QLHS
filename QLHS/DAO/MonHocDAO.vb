Imports DTO
Imports System.Data.SqlClient
Public Class MonHocDAO
    Public Shared Function layMonHoc() As List(Of MonDTO)
        Dim conn As SqlConnection = DataProvider.getConnection()
        Dim cmd As New SqlCommand("select * from monhoc", conn)
        conn.Open()
        Dim lstMon As New List(Of MonDTO)
        Dim reader As SqlDataReader = cmd.ExecuteReader
        If reader.HasRows Then
            While (reader.Read)
                Dim mon As New MonDTO
                mon.MaMonHoc = reader.GetInt32(0)
                mon.TenMonHoc = reader.GetString(1)
                lstMon.Add(mon)
            End While
        End If

        conn.Close()

        Return lstMon


    End Function
End Class
