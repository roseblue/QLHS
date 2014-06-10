Imports DTO
Imports BUS
Public Class frmthemlop

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Close()
    End Sub

    Private Sub frmthemlop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dskhoi As List(Of KhoiDTO) = KhoiBUS.laykhoi()

        cbkhoi.DataSource = dskhoi
        cbkhoi.DisplayMember = "TenKhoi"
        cbkhoi.ValueMember = "MaKhoi"



    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        If txttenlop.Text = "" Then
            MessageBox.Show("Chưa nhập tên lớp", "Thông Báo")
            Return
        End If
        Dim check As Integer = LopBUS.themlop(txttenlop.Text, cbkhoi.SelectedValue)
        If check = 1 Then
            MessageBox.Show("Thêm thành công", "Thông Báo")
            txttenlop.Text = ""
            cbkhoi.SelectedIndex = 0
        ElseIf check = 2 Then
            MessageBox.Show("Số lượng lớp đạt giới hạn.", "Thông Báo")
        Else
            MessageBox.Show("Thêm Thất bại", "Thông Báo")
        End If
    End Sub
End Class