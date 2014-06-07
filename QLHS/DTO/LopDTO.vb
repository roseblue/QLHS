Public Class LopDTO
    Private _MaLop As Integer
    Public Property MaLop() As Integer
        Get
            Return _MaLop
        End Get
        Set(value As Integer)
            _MaLop = value
        End Set
    End Property

    Private _TenLop As String
    Public Property TenLop() As String
        Get
            Return _TenLop
        End Get
        Set(value As String)
            _TenLop = value
        End Set
    End Property

    Private _SiSo As Integer
    Public Property SiSo() As Integer
        Get
            Return _SiSo
        End Get
        Set(value As Integer)
            _SiSo = value
        End Set
    End Property

    Private _MaKhoi As Integer
    Public Property MaKhoi() As Integer
        Get
            Return _MaKhoi
        End Get
        Set(value As Integer)
            _MaKhoi = value
        End Set
    End Property
End Class
