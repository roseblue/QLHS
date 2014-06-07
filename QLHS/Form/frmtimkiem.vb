Imports DTO
Imports DAO
Public Class frmtimkiem
    Dim ds As List(Of HocSinhDTO)
    Const PAGE_SIZE As Integer = 6
    Dim curPage As Integer = 1
    Dim numberofpages As Integer
    Dim start As Integer
    Dim endpage As Integer
    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Close()
    End Sub

    Sub setnavigationstate()
        btnnext.Enabled = (curPage < numberofpages)
        btnlast.Enabled = (curPage < numberofpages)
        btnprev.Enabled = (curPage > 1)
        btnfirst.Enabled = (curPage > 1)
    End Sub

    Private Sub btntim_Click(sender As Object, e As EventArgs) Handles btntim.Click
        Dim hs As New HocSinhDTO
        hs.HoTen = txtht.Text

        ds = HocSinhDAO.TimKiem(hs)
        numberofpages = Math.Ceiling(ds.Count() / PAGE_SIZE)
        lbpaing.Text = String.Format("{0}/{1}", curPage, numberofpages)
        gridhs.Rows.Clear()
        start = 0
        endpage = PAGE_SIZE - 1
        For i As Integer = start To endpage
            gridhs.Rows.Add(i + 1, ds(i).HoTen, ds(i).DiaChi, 0, 0)
        Next
        setnavigationstate()
    End Sub

    Private Sub frmtimkiem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbpaing.Text = "0/0"
        setnavigationstate()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        start = curPage * PAGE_SIZE
        endpage = start + (PAGE_SIZE - 1)
        curPage += 1
        lbpaing.Text = String.Format("{0}/{1}", curPage, numberofpages)

        If endpage > ds.Count - 1 Then
            endpage = ds.Count - 1
        End If
        gridhs.Rows.Clear()
        For i As Integer = start To endpage
            gridhs.Rows.Add(i + 1, ds(i).HoTen, ds(i).DiaChi, 0, 0)
        Next
        setnavigationstate()
    End Sub

    Private Sub btnlast_Click(sender As Object, e As EventArgs) Handles btnlast.Click
        curPage = numberofpages
        start = (curPage - 1) * PAGE_SIZE
        endpage = ds.Count - 1
        lbpaing.Text = String.Format("{0}/{1}", curPage, numberofpages)
        
        gridhs.Rows.Clear()
        For i As Integer = start To endpage
            gridhs.Rows.Add(i + 1, ds(i).HoTen, ds(i).DiaChi, 0, 0)
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
        gridhs.Rows.Clear()
        For i As Integer = start To endpage
            gridhs.Rows.Add(i + 1, ds(i).HoTen, ds(i).DiaChi, 0, 0)
        Next
        setnavigationstate()
    End Sub

    Private Sub btnfirst_Click(sender As Object, e As EventArgs) Handles btnfirst.Click
        curPage = 1
        start = 0
        endpage = PAGE_SIZE - 1
        lbpaing.Text = String.Format("{0}/{1}", curPage, numberofpages)
        gridhs.Rows.Clear()
        For i As Integer = start To endpage
            gridhs.Rows.Add(i + 1, ds(i).HoTen, ds(i).DiaChi, 0, 0)
        Next
        setnavigationstate()
    End Sub
End Class