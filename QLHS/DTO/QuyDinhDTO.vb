Public Class QuyDinhDTO
    Private _MaQD As Integer
    Public Property MaQD() As Integer
        Get
            Return _MaQD
        End Get
        Set(value As Integer)
            _MaQD = value
        End Set
    End Property

    Private _TenQD As String
    Public Property TenQD() As String
        Get
            Return _TenQD
        End Get
        Set(value As String)
            _TenQD = value
        End Set
    End Property

    Private _NoiDung As String
    Public Property NoiDung() As String
        Get
            Return _NoiDung
        End Get
        Set(value As String)
            _NoiDung = value
        End Set
    End Property
End Class
