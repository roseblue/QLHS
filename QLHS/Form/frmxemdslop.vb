Imports BUS
Imports DTO
Public Class frmxemdslop
    Dim ds As List(Of HocSinhDTO)
    Const PAGE_SIZE As Integer = 10
    Dim curPage As Integer = 1
    Dim numberofpages As Integer
    Dim start As Integer
    Dim endpage As Integer

    Sub setnavigationstate()
        btnnext.Enabled = (curPage < numberofpages)
        btnlast.Enabled = (curPage < numberofpages)
        btnprev.Enabled = (curPage > 1)
        btnfirst.Enabled = (curPage > 1)
    End Sub

    Private Sub frmxemdslop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'tao combobox
        Dim dslophoc As List(Of LopDTO) = LopBUS.laylop()
      
        cblop.DataSource = dslophoc
        cblop.DisplayMember = "TenLop"
        cblop.ValueMember = "MaLop"

        txtss.Text = LopBUS.laysosshienco(cblop.SelectedValue)

        lbpaing.Text = "0/0"
        setnavigationstate()

        loadds(cblop.SelectedValue)
    End Sub

    Public Sub loadds(ByVal malop As Integer)
        ds = HocSinhBUS.layhocsinhtheolop(malop)
        numberofpages = Math.Ceiling(ds.Count() / PAGE_SIZE)
        lbpaing.Text = String.Format("{0}/{1}", curPage, numberofpages)
        girdds.Rows.Clear()
        start = 0
        endpage = PAGE_SIZE - 1
        For i As Integer = start To endpage
            If (ds.Count = i) Then
                Exit For
            End If
            girdds.Rows.Add(i + 1, ds(i).HoTen, ds(i).GioiTinh, ds(i).NgaySinh.Year, ds(i).DiaChi)
        Next
        setnavigationstate()
    End Sub
    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Close()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        start = curPage * PAGE_SIZE
        endpage = start + (PAGE_SIZE - 1)
        curPage += 1
        lbpaing.Text = String.Format("{0}/{1}", curPage, numberofpages)

        If endpage > ds.Count - 1 Then
            endpage = ds.Count - 1
        End If
        girdds.Rows.Clear()
        For i As Integer = start To endpage
            girdds.Rows.Add(i + 1, ds(i).HoTen, ds(i).GioiTinh, ds(i).NgaySinh.Year, ds(i).DiaChi)
        Next
        setnavigationstate()
    End Sub

    Private Sub btnlast_Click(sender As Object, e As EventArgs) Handles btnlast.Click
        curPage = numberofpages
        start = (curPage - 1) * PAGE_SIZE
        endpage = ds.Count - 1
        lbpaing.Text = String.Format("{0}/{1}", curPage, numberofpages)

        girdds.Rows.Clear()
        For i As Integer = start To endpage
            girdds.Rows.Add(i + 1, ds(i).HoTen, ds(i).GioiTinh, ds(i).NgaySinh.Year, ds(i).DiaChi)
        Next
        setnavigationstate()
    End Sub

    Private Sub btnprev_Click(sender As Object, e As EventArgs) Handles btnprev.Click
        curPage -= 1
        endpage = curPage * PAGE_SIZE - 1
        start = endpage - PAGE_SIZE + 1
        lbpaing.Text = String.Format("{0}/{1}", curPage, numberofpages)

        If start <= 0 Then
            start = 0
            endpage = PAGE_SIZE - 1
        End If
        girdds.Rows.Clear()
        For i As Integer = start To endpage
            girdds.Rows.Add(i + 1, ds(i).HoTen, ds(i).GioiTinh, ds(i).NgaySinh.Year, ds(i).DiaChi)
        Next
        setnavigationstate()
    End Sub

    Private Sub btnfirst_Click(sender As Object, e As EventArgs) Handles btnfirst.Click
        curPage = 1
        start = 0
        endpage = PAGE_SIZE - 1
        lbpaing.Text = String.Format("{0}/{1}", curPage, numberofpages)
        girdds.Rows.Clear()
        For i As Integer = start To endpage
            girdds.Rows.Add(i + 1, ds(i).HoTen, ds(i).GioiTinh, ds(i).NgaySinh.Year, ds(i).DiaChi)
        Next
        setnavigationstate()
    End Sub

    Private Sub cblop_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cblop.SelectionChangeCommitted
        txtss.Text = LopBUS.laysosshienco(cblop.SelectedValue)
        loadds(cblop.SelectedValue)
    End Sub
End Class