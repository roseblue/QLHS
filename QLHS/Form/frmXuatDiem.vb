﻿Imports DAO
Imports DTO
Public Class frmXuatDiem

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmXuatDiem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lstLop As List(Of LopDTO) = LopDAO.layLop
        cboLop.DataSource = lstLop
        cboLop.DisplayMember = "TenLop"
        cboLop.ValueMember = "MaLop"

        cboMon.DataSource = MonHocDAO.layMonHoc
        cboMon.DisplayMember = "TenMonHoc"
        cboMon.ValueMember = "MaMonHoc"

        cboHocKy.DataSource = HocKyDAO.layHK
        cboHocKy.DisplayMember = "TenHKDayDU"
        cboHocKy.ValueMember = "MaHK"
    End Sub

    Private Sub btnLoc_Click(sender As Object, e As EventArgs) Handles btnLoc.Click

    End Sub
End Class