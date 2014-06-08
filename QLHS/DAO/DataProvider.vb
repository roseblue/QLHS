Public Class DataProvider
    Public Shared Function getConnection() As SqlClient.SqlConnection
        Dim str = "Data Source=(local);Initial Catalog=QLHocSinh;Integrated Security=True"
        Dim conn As New SqlClient.SqlConnection(str)
        Return conn
    End Function
End Class
