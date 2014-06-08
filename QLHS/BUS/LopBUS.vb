Imports DTO
Imports DAO
Public Class LopBUS
    Public Shared Function layLop() As List(Of LopDTO)
        Return LopDAO.layLop
    End Function
End Class
