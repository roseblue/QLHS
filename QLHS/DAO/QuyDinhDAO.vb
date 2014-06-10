Imports DTO
Imports System.Data.SqlClient
Public Class QuyDinhDAO
    Public Shared Function layQuyDinh(type As Integer) As List(Of QuyDinhDTO)
        Dim conn As SqlConnection = DataProvider.getConnection()
        Dim cmd As SqlCommand
        If (type = 1) Then
            cmd = New SqlCommand("select * from QuyDinh where TenQD = N'Tuổi nhỏ nhất' or TenQD = N'Tuổi lớn nhất'", conn)
        ElseIf type = 2 Then
            cmd = New SqlCommand("select * from quydinh where TenQD = N'Điểm đạt môn'", conn)
        Else
            cmd = New SqlCommand("select * from quydinh where tenqd = N'Sỉ số tối đa'", conn)
        End If

        conn.Open()
        Dim lst As New List(Of QuyDinhDTO)
        Dim reader As SqlDataReader = cmd.ExecuteReader
        If reader.HasRows Then
            While (reader.Read)
                Dim ql As New QuyDinhDTO
                ql.MaQuyDinh = reader.GetInt32(0)
                ql.TenQuyDinh = reader.GetString(1)
                ql.NoiDung = reader.GetString(2)
                lst.Add(ql)
            End While
        End If

        conn.Close()

        Return lst

    End Function

    Public Shared Function capNhatQD(qd As QuyDinhDTO) As Integer
        Dim conn As SqlConnection = DataProvider.getConnection()
        Dim sql = String.Format("update quydinh set noidung = N'{0}' where maqd = {1}", qd.NoiDung, qd.MaQuyDinh)
        Dim cmd As New SqlCommand(sql, conn)
        conn.Open()
        Dim kq As Integer = -1
        kq = cmd.ExecuteNonQuery()
        conn.Close()
        Return kq
    End Function
End Class
