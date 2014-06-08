Imports DTO
Imports BUS
Public Class frmThayDoiDiem
    Private diemChuan As New QuyDinhDTO
    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        diemChuan.NoiDung = NumericUpDown1.Value
        If (QuyDinhBUS.capNhatQuyDinh(diemChuan) = 1) Then
            MessageBox.Show("Cập nhật điểm chuẩn thành công", "Thông báo", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub frmThayDoiDiem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lst As List(Of QuyDinhDTO) = QuyDinhBUS.layQuyDinh(2)
        diemChuan = lst.Find(Function(x) x.TenQuyDinh = "Điểm đạt môn")
        NumericUpDown1.Value = diemChuan.NoiDung
        NumericUpDown1.Maximum = 10
        NumericUpDown1.Minimum = 0
        NumericUpDown1.Increment = 0.1
        NumericUpDown1.DecimalPlaces = 1
    End Sub
End Class