Imports BUS
Imports DTO
Public Class frmXuatDiem

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmXuatDiem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lstLop As List(Of LopDTO) = LopBUS.layLop
        cboLop.DataSource = lstLop
        cboLop.DisplayMember = "TenLop"
        cboLop.ValueMember = "MaLop"

        cboMon.DataSource = MonBUS.layMonHoc
        cboMon.DisplayMember = "TenMonHoc"
        cboMon.ValueMember = "MaMonHoc"

        cboHocKy.DataSource = HocKyBUS.layHK
        cboHocKy.DisplayMember = "TenHKDayDU"
        cboHocKy.ValueMember = "MaHK"
    End Sub

    Private Sub btnLoc_Click(sender As Object, e As EventArgs) Handles btnLoc.Click
        Dim dt As List(Of BangDiemDTO) = BangDiemBUS.layDiem(cboLop.SelectedValue, cboHocKy.SelectedValue, cboMon.SelectedValue)
        DataGridView1.DataSource = dt
        DataGridView1.Columns(0).HeaderText = "Tên học sinh"
        DataGridView1.Columns(1).HeaderText = "Điểm 15'"
        DataGridView1.Columns(2).HeaderText = "Điểm 1 tiết"
        DataGridView1.Columns(3).HeaderText = "Điểm học kỳ"

    End Sub
End Class