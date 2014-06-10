Imports DTO
Imports DAO
Public Class KhoiBUS
    Public Shared Function laykhoi() As List(Of KhoiDTO)
        Return KhoiDAO.laykhoi
    End Function
End Class
