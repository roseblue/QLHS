Imports DTO
Imports System.Data.SqlClient
Public Class LopDAO

    Public Shared Function laysosshienco(ByVal malop As Integer) As Integer
        Dim sohs = 0
        Dim sql = "select SiSo from Lop where MaLop = " & malop
        Dim conn As SqlConnection
        conn = DataProvider.ConnectDB()
        Dim cmd As New SqlCommand(sql, conn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        With reader.Read()
            sohs = reader.GetInt32(0)
        End With
        Return sohs
    End Function
    Public Shared Function laylop() As List(Of LopDTO)
        Dim sql = "select MaLop,TenLop from Lop  order by TenLop"
        Dim conn As SqlConnection
        conn = DataProvider.ConnectDB()
        Dim cmd As New SqlCommand(sql, conn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        Dim ds As New List(Of LopDTO)
        While reader.Read()
            Dim lop As New LopDTO
            lop.MaLop = reader.GetInt32(0)
            lop.TenLop = reader.GetString(1)
            ds.Add(lop)
        End While
        conn.Close()
        Return ds
    End Function
    Public Shared Function themlop(ByVal tenlop As String, ByVal makhoi As Integer) As Integer
        Dim sql As String
        Dim conn As SqlConnection
        conn = DataProvider.ConnectDB()
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader

        sql = "select count(*) from Lop where Makhoi = " & makhoi
        cmd = New SqlCommand(sql, conn)
        reader = cmd.ExecuteReader()
        Dim count As Integer
        With reader.Read()
            count = reader.GetInt32(0)
        End With

        sql = "select SoLuong from Khoi where Makhoi = " & makhoi
        cmd = New SqlCommand(sql, conn)
        reader = cmd.ExecuteReader()
        Dim soluong As Integer
        With reader.Read()
            soluong = reader.GetInt32(0)
        End With

        If count = soluong Then
            conn.Close()
            Return 2
        End If

        sql = "insert into Lop(TenLop,SiSo,MaKhoi) values(N'" & tenlop & "',0," & makhoi & ")"
        cmd = New SqlCommand(sql, conn)

        Dim i As Integer = cmd.ExecuteNonQuery()
        conn.Close()
        If i >= 0 Then
            Return 1
        Else
            Return 0
        End If
    End Function
End Class
