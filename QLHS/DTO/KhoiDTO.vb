Public Class KhoiDTO
    Private _MaKhoi As Integer
    Public Property MaKhoi() As Integer
        Get
            Return _MaKhoi
        End Get
        Set(value As Integer)
            _MaKhoi = value
        End Set
    End Property

    Private _TenKhoi As String
    Public Property TenKhoi() As String
        Get
            Return _TenKhoi
        End Get
        Set(value As String)
            _TenKhoi = value
        End Set
    End Property

    Private _SoLuong As Integer
    Public Property SoLuong() As Integer
        Get
            Return _SoLuong
        End Get
        Set(value As Integer)
            _SoLuong = value
        End Set
    End Property
End Class
