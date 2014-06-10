
Imports DTO
Imports System.Data.SqlClient

Public Class HocSinhDAO

    Public Shared Function layhocsinhtheolop(ByVal malop As Integer) As List(Of HocSinhDTO)
        Dim sql As String

        sql = "select HoTen,GioiTinh,NgaySinh,DiaChi from HocSinh where MaLop = " & malop
        Dim conn As SqlConnection = DataProvider.getConnection
        Dim cmd As New SqlCommand(sql, conn)
        conn.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader
        Dim dshs As New List(Of HocSinhDTO)
        While reader.Read()
            Dim hocsinh As New HocSinhDTO
            hocsinh.HoTen = reader.GetString(0)
            hocsinh.GioiTinh = reader.GetString(1)
            hocsinh.NgaySinh = reader.GetDateTime(2)
            hocsinh.DiaChi = reader.GetString(3)
            dshs.Add(hocsinh)
        End While
        conn.Close()
        Return dshs
    End Function
    Public Shared Function capnhaplopchohocsinh(ByVal arr As ArrayList, ByVal malop As Integer) As Integer
        Dim dt As List(Of QuyDinhDTO) = QuyDinhDAO.layQuyDinh(3)
        Dim slhsgioihan As Integer = dt.Find(Function(x) x.TenQuyDinh = "Sỉ số tối đa").NoiDung
        Dim sisolop As Integer = LopDAO.laysosshienco(malop)
        Dim check As Integer = 0
        Dim count As Integer = 0
        Dim conn As SqlConnection = DataProvider.getConnection()
        conn.Open()
        Dim command As SqlCommand = conn.CreateCommand()
        Dim transaction As SqlTransaction
        transaction = conn.BeginTransaction("SampleTransaction")

        command.Connection = conn
        command.Transaction = transaction
        Try
            For Each hs As HocSinhDTO In arr
                If (sisolop >= slhsgioihan) Then
                    check = 2
                    Exit For
                End If
                command.CommandText = "UPDATE HocSinh set MaLop = " & malop & " where MaHS = " & hs.MaHS

                Dim i As Integer = command.ExecuteNonQuery()
                If i >= 0 Then
                    sisolop = sisolop + 1
                    command.CommandText = "UPDATE Lop set SiSo = " & sisolop & " where MaLop = " & malop
                    Dim j As Integer = command.ExecuteNonQuery()
                    If j < 0 Then
                        transaction.Rollback()
                        Exit For
                    End If
                Else
                    transaction.Rollback()
                End If

                count = count + 1
            Next
            transaction.Commit()
        Catch ex As Exception
            Try
                transaction.Rollback()

            Catch ex1 As Exception

            End Try
        End Try
        
        If count = arr.Count Then
            check = 1
        End If
        conn.Close()
        Return check
    End Function
    Public Shared Function layhocsinhchuacolop() As ArrayList
        Dim sql As String

        sql = "select MaHS,HoTen from HocSinh where MaLop is NULL "

        Dim conn As SqlConnection = DataProvider.getConnection()
        Dim cmd As New SqlCommand(sql, conn)
        conn.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader
        Dim dshs As New ArrayList
        While reader.Read()
            Dim hocsinh As New HocSinhDTO
            hocsinh.MaHS = reader.GetInt32(0)
            hocsinh.HoTen = reader.GetString(1)
            dshs.Add(hocsinh)
        End While
        conn.Close()
        Return dshs
    End Function

    Public Shared Function TimKiem(ByVal hs As HocSinhDTO) As List(Of HocSinhDTO)
        Dim sql As String
        If String.IsNullOrEmpty(hs.HoTen) Then
            sql = "select HocSinh.HoTen,Lop.TenLop  from HocSinh left join Lop on HocSinh.MaLop = Lop.MaLop where  HocSinh.MaLop =  " & hs.MaLop
        Else
            sql = "select HocSinh.HoTen,Lop.TenLop  from HocSinh left join Lop on HocSinh.MaLop = Lop.MaLop where HocSinh.HoTen like '%" & hs.HoTen & "' and HocSinh.MaLop =  " & hs.MaLop

        End If


        Dim conn As SqlConnection = DataProvider.getConnection()
        Dim cmd As New SqlCommand(sql, conn)
        conn.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader
        Dim dshs As New List(Of HocSinhDTO)
        While reader.Read()
            Dim hocsinh As New HocSinhDTO
            hocsinh.HoTen = reader.GetString(0)

            Try
                hocsinh.TenLop = reader.GetString(1)
            Catch ex As Exception
                hocsinh.TenLop = "Chưa có lớp"
            End Try

            dshs.Add(hocsinh)
        End While
        conn.Close()
        Return dshs
    End Function

End Class
