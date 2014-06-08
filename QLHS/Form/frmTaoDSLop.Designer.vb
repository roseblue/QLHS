<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaoDSLop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lisths = New System.Windows.Forms.ListBox()
        Me.listlop = New System.Windows.Forms.ListBox()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.cblop = New System.Windows.Forms.ComboBox()
        Me.btnnhap = New System.Windows.Forms.Button()
        Me.btnxemds = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lisths
        '
        Me.lisths.FormattingEnabled = True
        Me.lisths.Location = New System.Drawing.Point(13, 48)
        Me.lisths.Name = "lisths"
        Me.lisths.Size = New System.Drawing.Size(234, 290)
        Me.lisths.TabIndex = 0
        '
        'listlop
        '
        Me.listlop.FormattingEnabled = True
        Me.listlop.Location = New System.Drawing.Point(384, 47)
        Me.listlop.Name = "listlop"
        Me.listlop.Size = New System.Drawing.Size(234, 290)
        Me.listlop.TabIndex = 1
        '
        'btnthem
        '
        Me.btnthem.Enabled = False
        Me.btnthem.Location = New System.Drawing.Point(288, 129)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(58, 33)
        Me.btnthem.TabIndex = 2
        Me.btnthem.Text = ">>"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Enabled = False
        Me.btnxoa.Location = New System.Drawing.Point(290, 184)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(58, 33)
        Me.btnxoa.TabIndex = 3
        Me.btnxoa.Text = "<<"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'cblop
        '
        Me.cblop.FormattingEnabled = True
        Me.cblop.Location = New System.Drawing.Point(254, 350)
        Me.cblop.Name = "cblop"
        Me.cblop.Size = New System.Drawing.Size(112, 21)
        Me.cblop.TabIndex = 4
        '
        'btnnhap
        '
        Me.btnnhap.Enabled = False
        Me.btnnhap.Location = New System.Drawing.Point(130, 362)
        Me.btnnhap.Name = "btnnhap"
        Me.btnnhap.Size = New System.Drawing.Size(58, 21)
        Me.btnnhap.TabIndex = 5
        Me.btnnhap.Text = "Nhập danh sách"
        Me.btnnhap.UseVisualStyleBackColor = True
        '
        'btnxemds
        '
        Me.btnxemds.Location = New System.Drawing.Point(13, 360)
        Me.btnxemds.Name = "btnxemds"
        Me.btnxemds.Size = New System.Drawing.Size(111, 23)
        Me.btnxemds.TabIndex = 6
        Me.btnxemds.Text = "Xem danh sách lớp"
        Me.btnxemds.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(575, 363)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 23)
        Me.btnthoat.TabIndex = 7
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'frmTaoDSLop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 398)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btnxemds)
        Me.Controls.Add(Me.btnnhap)
        Me.Controls.Add(Me.cblop)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.listlop)
        Me.Controls.Add(Me.lisths)
        Me.Name = "frmTaoDSLop"
        Me.Text = "frmTaoDSLop"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lisths As System.Windows.Forms.ListBox
    Friend WithEvents listlop As System.Windows.Forms.ListBox
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents cblop As System.Windows.Forms.ComboBox
    Friend WithEvents btnnhap As System.Windows.Forms.Button
    Friend WithEvents btnxemds As System.Windows.Forms.Button
    Friend WithEvents btnthoat As System.Windows.Forms.Button
End Class
