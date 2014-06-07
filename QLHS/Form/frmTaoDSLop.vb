Imports DAO
Imports DTO
Public Class frmTaoDSLop
    Dim sohstoida As Integer
    Dim sohshienco As Integer

    Private Sub frmTaoDSLop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dslophoc As List(Of LopDTO) = LopDAO.laylop()

        cblop.DataSource = dslophoc
        cblop.DisplayMember = "TenLop"
        cblop.ValueMember = "MaLop"

        Dim dshs As List(Of HocSinhDTO) = HocSinhDAO.layhocsinhchuacolop()

        lisths.DataSource = dshs
        lisths.DisplayMember = "HoTen"
        lisths.ValueMember = "MaHS"

        sohshienco = LopDAO.laysosshienco(cblop.SelectedValue)

    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        If lisths.Items.Count = 0 Then Exit Sub
        MessageBox.Show(lisths.SelectedValue)
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        If listlop.Items.Count = 0 Then Exit Sub
        lisths.Items.Add(listlop.SelectedItem)
        listlop.Items.Remove(listlop.SelectedItem)
    End Sub
End Class