Imports DAO
Imports DTO
Public Class MonBUS
    Public Shared Function layMonHoc() As List(Of MonDTO)
        Return MonHocDAO.layMonHoc
    End Function
End Class
