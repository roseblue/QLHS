Imports DAO
Imports DTO
Public Class HocSinhBUS
    Public Shared Function layhocsinhtheolop(ByVal malop As Integer) As List(Of HocSinhDTO)
        Return HocSinhDAO.layhocsinhtheolop(malop)
    End Function
    Public Shared Function capnhaplopchohocsinh(ByVal arr As ArrayList, ByVal malop As Integer) As Integer
        Return HocSinhDAO.capnhaplopchohocsinh(arr, malop)
    End Function
    Public Shared Function layhocsinhchuacolop() As ArrayList
        Return HocSinhDAO.layhocsinhchuacolop
    End Function

    Public Shared Function TimKiem(ByVal hs As HocSinhDTO) As List(Of HocSinhDTO)
        Return HocSinhDAO.TimKiem(hs)
    End Function
End Class
