Public Class Form1

    Private Sub btntim_Click(sender As Object, e As EventArgs) Handles btntim.Click
        Dim frm As New frmtimkiem()
        frm.ShowDialog()
    End Sub

    Private Sub btntaods_Click(sender As Object, e As EventArgs) Handles btntaods.Click
        Dim frm As New frmthemlop()
        frm.ShowDialog()
    End Sub

    Private Sub btnds_Click(sender As Object, e As EventArgs) Handles btnds.Click
        Dim frm As New frmTaoDSLop()
        frm.ShowDialog()
    End Sub
End Class
