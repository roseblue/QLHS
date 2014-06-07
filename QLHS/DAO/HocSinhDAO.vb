Imports System.Data.OleDb
Imports DTO
Public Class HocSinhDAO
    Public Shared Function layhocsinhchuacolop() As List(Of HocSinhDTO)
        Dim sql As String

        sql = "select MaHS,HoTen from HocSinh where MaLop is NULL "

        Dim conn As OleDbConnection = DataProvider.ConnectDB()
        Dim cmd As New OleDbCommand(sql, conn)

        Dim reader As OleDbDataReader = cmd.ExecuteReader
        Dim dshs As New List(Of HocSinhDTO)
        While reader.Read()
            Dim hocsinh As New HocSinhDTO
            hocsinh.MaHS = reader.GetInt32(0)
            hocsinh.HoTen = reader.GetString(1)
            dshs.Add(hocsinh)
        End While
        Return dshs
    End Function

    Public Shared Function TimKiem(ByVal hs As HocSinhDTO) As List(Of HocSinhDTO)
        Dim sql As String

        sql = "select HoTen,DiaChi from HocSinh where HoTen like '%" & hs.HoTen & "' "

        Dim conn As OleDbConnection = DataProvider.ConnectDB()
        Dim cmd As New OleDbCommand(sql, conn)

        Dim reader As OleDbDataReader = cmd.ExecuteReader
        Dim dshs As New List(Of HocSinhDTO)
        While reader.Read()
            Dim hocsinh As New HocSinhDTO
            hocsinh.HoTen = reader.GetString(0)
            hocsinh.DiaChi = reader.GetString(1)
            dshs.Add(hocsinh)
        End While
        Return dshs
    End Function

End Class
