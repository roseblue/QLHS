Imports BUS
Imports DTO
Public Class frmThayDoiTuoi

    Private minAge As New QuyDinhDTO
    Private maxAge As New QuyDinhDTO

    Private Sub frmThayDoiTuoi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lst As List(Of QuyDinhDTO) = QuyDinhBUS.layQuyDinh(1)
        minAge = lst.Find(Function(x) x.TenQuyDinh = "Tuổi nhỏ nhất")
        maxAge = lst.Find(Function(x) x.TenQuyDinh = "Tuổi lớn nhất")

        nudMax.Value = maxAge.NoiDung
        nudMin.Value = minAge.NoiDung
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        minAge.NoiDung = nudMin.Value
        maxAge.NoiDung = nudMax.Value
        Dim str As String = ""
        If (QuyDinhBUS.capNhatQuyDinh(minAge) = 1) Then
            str &= "Cập nhật tuổi nhỏ nhất thành công"
            If (QuyDinhBUS.capNhatQuyDinh(maxAge) = 1) Then
                str &= ". Cập nhật tuổi lớn nhất thành công"
            End If
            MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK)

        End If
    End Sub
End Class