Imports DTO
Imports System.Data.OleDb
Public Class KhoiDAO
    Public Shared Function laykhoi() As List(Of KhoiDTO)
        Dim sql = "select MaKhoi,TenKhoi from Khoi"
        Dim conn As OleDbConnection
        conn = DataProvider.ConnectDB()
        Dim cmd As New OleDbCommand(sql, conn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

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
