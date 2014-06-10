Public Class frmMain
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PhânLớpChoHọcSinhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhânLớpChoHọcSinhToolStripMenuItem.Click
        Dim frm As New frmTaoDSLop
        frm.ShowDialog()
    End Sub

    Private Sub TraCứuHọcSinhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TraCứuHọcSinhToolStripMenuItem.Click
        Dim frm As New frmtimkiem
        frm.ShowDialog()
    End Sub

    Private Sub XuấtBảngĐiểmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XuấtBảngĐiểmToolStripMenuItem.Click
        Dim frm As New frmXuatDiem
        frm.ShowDialog()
    End Sub

    Private Sub ThayĐổiTuổiNhậpHọcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThayĐổiTuổiNhậpHọcToolStripMenuItem.Click
        Dim frm As New frmThayDoiTuoi
        frm.ShowDialog()
    End Sub

    Private Sub ThayĐổiĐiemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThayĐổiĐiemToolStripMenuItem.Click
        Dim frm As New frmThayDoiDiem
        frm.ShowDialog()
    End Sub
End Class
