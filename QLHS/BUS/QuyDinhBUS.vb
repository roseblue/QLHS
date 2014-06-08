Imports DAO
Imports DTO
Public Class QuyDinhBUS
    Public Shared Function layQuyDinh(type As Integer) As List(Of QuyDinhDTO)
        Return QuyDinhDAO.layQuyDinh(type)
    End Function

    Public Shared Function capNhatQuyDinh(qd As QuyDinhDTO) As Integer
        Return QuyDinhDAO.capNhatQD(qd)
    End Function
End Class
