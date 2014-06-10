Imports DAO
Imports DTO
Public Class frmTaoDSLop
    Dim sohstoida As Integer
    Dim sohshienco As Integer
    Dim slhscon As Integer
    Dim dshs As New ArrayList
    Dim layhocsinhs As New ArrayList

    Public Sub setenabled()
        btnthem.Enabled = lisths.SelectedIndex <> -1
        btnxoa.Enabled = listlop.SelectedIndex <> -1
        btnnhap.Enabled = listlop.Items.Count <> 0
    End Sub

    Private Sub frmTaoDSLop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'tao combobox
        Dim dslophoc As List(Of LopDTO) = LopDAO.laylop()

        cblop.DataSource = dslophoc
        cblop.DisplayMember = "TenLop"
        cblop.ValueMember = "MaLop"

        'lay ds hoc sinh chua co lop
        dshs = HocSinhDAO.layhocsinhchuacolop()

        lisths.DataSource = dshs
        lisths.DisplayMember = "HoTen"
        lisths.ValueMember = "MaHS"

        'tinh so hoc sinh con trong cua lop dang chon

        sohshienco = LopDAO.laysosshienco(cblop.SelectedValue)
        sohstoida = QuyDinhDAO.layquydinh(1)
        slhscon = sohstoida - sohshienco

        'clear 
        lisths.ClearSelected()
        listlop.ClearSelected()
        'khoa nut bam
        setenabled()
    End Sub
    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click

        If lisths.SelectedIndex = -1 Then
            MessageBox.Show("Chọn Học sinh cần thêm vào danh sách lớp", "Thông Báo")
            Return
        End If

        If slhscon = 0 Then
            MessageBox.Show("Lớp đạt số lượng học sinh giới hạn.", "Thông Báo")
            Return
        End If
        'add hs da chon vao listbox2
        Dim hs As New HocSinhDTO
        hs.HoTen = CType(lisths.SelectedItem, HocSinhDTO).HoTen
        hs.MaHS = lisths.SelectedValue
        layhocsinhs.Add(hs)
        listlop.DataSource = Nothing
        listlop.DataSource = layhocsinhs
        listlop.DisplayMember = "HoTen"
        listlop.ValueMember = "MaHS"

        'xoa hoc sinh da chon o listbox1
        dshs.RemoveAt(lisths.SelectedIndex)
        lisths.DataSource = Nothing
        lisths.DataSource = dshs
        lisths.DisplayMember = "HoTen"
        lisths.ValueMember = "MaHS"

        'clear 
        lisths.ClearSelected()
        listlop.ClearSelected()

        slhscon = slhscon - 1
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        If listlop.SelectedIndex = -1 Then
            MessageBox.Show("Chọn Học sinh cần xóa trong danh sách lớp", "Thông Báo")
            Return
        End If

        'add hs da chon vao listbox1
        Dim hs As New HocSinhDTO
        hs.HoTen = CType(listlop.SelectedItem, HocSinhDTO).HoTen
        hs.MaHS = listlop.SelectedValue
        dshs.Add(hs)
        lisths.DataSource = Nothing
        lisths.DataSource = dshs
        lisths.DisplayMember = "HoTen"
        lisths.ValueMember = "MaHS"

        'xoa hoc sinh da chon o listbox
        layhocsinhs.RemoveAt(listlop.SelectedIndex)
        listlop.DataSource = Nothing
        listlop.DataSource = layhocsinhs
        listlop.DisplayMember = "HoTen"
        listlop.ValueMember = "MaHS"

        slhscon = slhscon + 1
        'clear 
        lisths.ClearSelected()
        listlop.ClearSelected()
    End Sub

   

    Private Sub btnnhap_Click(sender As Object, e As EventArgs) Handles btnnhap.Click
        Dim check As Integer = HocSinhDAO.capnhaplopchohocsinh(layhocsinhs, cblop.SelectedValue)
        If check = 1 Then
            MessageBox.Show("Thêm danh sách lớp thành công", "Thông Báo")
            layhocsinhs.Clear()
            listlop.DataSource = Nothing
        ElseIf check = 2 Then
            MessageBox.Show("Lớp đạt đến giới hạn học sinh.", "Thông Báo")
        Else
            MessageBox.Show("Thêm Thất bại", "Thông Báp")
        End If
    End Sub

    Private Sub lisths_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lisths.SelectedIndexChanged
        setenabled()

    End Sub

    Private Sub listlop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listlop.SelectedIndexChanged
        setenabled()
    End Sub

  
    Private Sub cblop_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cblop.SelectionChangeCommitted
        sohshienco = LopDAO.laysosshienco(cblop.SelectedValue)
        slhscon = sohstoida - sohshienco
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Close()
    End Sub

    Private Sub btnxemds_Click(sender As Object, e As EventArgs) Handles btnxemds.Click
        Dim frm = New frmxemdslop()
        frm.ShowDialog()
    End Sub
End Class
