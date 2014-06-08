Imports DAO
Imports DTO
Public Class HocKyBUS
    Public Shared Function layHK() As List(Of HocKyDTO)
        Return HocKyDAO.layHK()
    End Function
End Class
