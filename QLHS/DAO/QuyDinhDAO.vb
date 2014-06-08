Imports DTO
Imports System.Data.SqlClient
Public Class QuyDinhDAO

    Public Shared Function layquydinh(ByVal maquydinh As Integer) As Integer
        Dim soluonghs As Integer = 0
        Dim s As String
        Dim sql = "select NoiDung from QuyDinh where MaQD = " & maquydinh

        Dim conn As SqlConnection
        conn = DataProvider.ConnectDB()
        Dim cmd As New SqlCommand(sql, conn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        With reader.Read()
            s = reader.GetString(0)
        End With
        soluonghs = Convert.ToInt32(s)
        Return soluonghs

    End Function
End Class
