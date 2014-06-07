Public Class HocSinhDTO
    Private _MaHS As Integer

    Public Property MaHS() As Integer
        Get
            Return _MaHS
        End Get
        Set(value As Integer)
            _MaHS = value
        End Set
    End Property

    Private _HoTen As String
    Public Property HoTen() As String
        Get
            Return _HoTen
        End Get
        Set(value As String)
            _HoTen = value
        End Set
    End Property

    Private _NgaySinh As Date
    Public Property NgaySinh() As Date
        Get
            Return _NgaySinh
        End Get
        Set(value As Date)
            _NgaySinh = value
        End Set
    End Property

    Private _GioiTinh As String
    Public Property GioiTinh() As String
        Get
            Return _GioiTinh
        End Get
        Set(value As String)
            _GioiTinh = value
        End Set
    End Property

    Private _DiaChi As String
    Public Property DiaChi() As String
        Get
            Return _DiaChi
        End Get
        Set(value As String)
            _DiaChi = value
        End Set
    End Property

    Private _Email As String
    Public Property Email() As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property

    Private _MaLop As Integer
    Public Property MaLop() As Integer
        Get
            Return _MaLop
        End Get
        Set(value As Integer)
            _MaLop = value
        End Set
    End Property
End Class
