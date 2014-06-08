Imports DAO
Imports DTO

Public Class BangDiemBUS
    Public Shared Function layDiem(maLop As Integer, maHK As Integer, maMon As Integer) As List(Of BangDiemDTO)

        Dim lst As New List(Of BangDiemDTO)
        Dim dt As DataTable = BangDiemDAO.layDiem(maHK, maMon)
        For i As Integer = dt.Rows.Count - 1 To 0 Step -1
            If (dt.Rows(i)(1) <> maLop) Then
                dt.Rows.Remove(dt.Rows(i))
            End If
        Next

        dt.AcceptChanges()

        For Each row As DataRow In dt.Rows
            Dim bd As New BangDiemDTO
            bd.TenHocSinh = row(2)
            If (Not lst.Exists(Function(x) x.TenHocSinh = bd.TenHocSinh)) Then
                If (row(3) = 1) Then
                    bd.Diem15 = row(5)
                ElseIf (row(3) = 2) Then
                    bd.Diem45 = row(5)
                Else
                    bd.DiemHK = row(5)
                End If
                lst.Add(bd)

            Else
                For Each b As BangDiemDTO In lst
                    If (b.TenHocSinh = row(2)) Then
                        bd = b
                        Exit For
                    End If
                Next
                If (row(3) = 1) Then
                    bd.Diem15 = row(5)
                ElseIf (row(3) = 2) Then
                    bd.Diem45 = row(5)
                Else
                    bd.DiemHK = row(5)
                End If
            End If

        Next
        Return lst
    End Function
End Class
