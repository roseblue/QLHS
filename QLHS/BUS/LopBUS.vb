Imports DTO
Imports DAO
Public Class LopBUS
    Public Shared Function layLop() As List(Of LopDTO)
        Return LopDAO.layLop
    End Function

    Public Shared Function laysosshienco(ByVal malop As Integer) As Integer
        Return LopDAO.laysosshienco(malop)
    End Function

    Public Shared Function themlop(ByVal tenlop As String, ByVal makhoi As Integer) As Integer
        Return LopDAO.themlop(tenlop, makhoi)
    End Function
End Class
