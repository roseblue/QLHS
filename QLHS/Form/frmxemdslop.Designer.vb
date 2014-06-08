<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmxemdslop
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cblop = New System.Windows.Forms.ComboBox()
        Me.girdds = New System.Windows.Forms.DataGridView()
        Me.btnfirst = New System.Windows.Forms.Button()
        Me.btnprev = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.lbpaing = New System.Windows.Forms.Label()
        Me.btnlast = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtss = New System.Windows.Forms.TextBox()
        Me.stt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ht = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ns = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.girdds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lớp"
        '
        'cblop
        '
        Me.cblop.FormattingEnabled = True
        Me.cblop.Location = New System.Drawing.Point(43, 17)
        Me.cblop.Name = "cblop"
        Me.cblop.Size = New System.Drawing.Size(121, 21)
        Me.cblop.TabIndex = 1
        '
        'girdds
        '
        Me.girdds.AllowUserToAddRows = False
        Me.girdds.AllowUserToDeleteRows = False
        Me.girdds.AllowUserToResizeColumns = False
        Me.girdds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.girdds.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.stt, Me.ht, Me.gt, Me.ns, Me.dc})
        Me.girdds.Location = New System.Drawing.Point(12, 61)
        Me.girdds.Name = "girdds"
        Me.girdds.Size = New System.Drawing.Size(695, 188)
        Me.girdds.TabIndex = 2
        '
        'btnfirst
        '
        Me.btnfirst.Enabled = False
        Me.btnfirst.Location = New System.Drawing.Point(12, 268)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(42, 23)
        Me.btnfirst.TabIndex = 3
        Me.btnfirst.Text = "<<"
        Me.btnfirst.UseVisualStyleBackColor = True
        '
        'btnprev
        '
        Me.btnprev.Enabled = False
        Me.btnprev.Location = New System.Drawing.Point(60, 268)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(42, 23)
        Me.btnprev.TabIndex = 4
        Me.btnprev.Text = "<"
        Me.btnprev.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Enabled = False
        Me.btnnext.Location = New System.Drawing.Point(138, 268)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(44, 23)
        Me.btnnext.TabIndex = 5
        Me.btnnext.Text = ">"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'lbpaing
        '
        Me.lbpaing.AutoSize = True
        Me.lbpaing.Location = New System.Drawing.Point(108, 273)
        Me.lbpaing.Name = "lbpaing"
        Me.lbpaing.Size = New System.Drawing.Size(24, 13)
        Me.lbpaing.TabIndex = 6
        Me.lbpaing.Text = "0/0"
        '
        'btnlast
        '
        Me.btnlast.Enabled = False
        Me.btnlast.Location = New System.Drawing.Point(188, 268)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(43, 23)
        Me.btnlast.TabIndex = 7
        Me.btnlast.Text = ">>"
        Me.btnlast.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(627, 263)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 23)
        Me.btnthoat.TabIndex = 8
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Sĩ số "
        '
        'txtss
        '
        Me.txtss.Location = New System.Drawing.Point(234, 17)
        Me.txtss.Name = "txtss"
        Me.txtss.ReadOnly = True
        Me.txtss.Size = New System.Drawing.Size(133, 20)
        Me.txtss.TabIndex = 10
        '
        'stt
        '
        Me.stt.HeaderText = "STT"
        Me.stt.Name = "stt"
        Me.stt.ReadOnly = True
        '
        'ht
        '
        Me.ht.HeaderText = "Họ Tên"
        Me.ht.Name = "ht"
        Me.ht.ReadOnly = True
        Me.ht.Width = 150
        '
        'gt
        '
        Me.gt.HeaderText = "Giới Tính"
        Me.gt.Name = "gt"
        Me.gt.ReadOnly = True
        '
        'ns
        '
        Me.ns.HeaderText = "Năm Sinh"
        Me.ns.Name = "ns"
        Me.ns.ReadOnly = True
        '
        'dc
        '
        Me.dc.HeaderText = "Địa chỉ"
        Me.dc.Name = "dc"
        Me.dc.ReadOnly = True
        Me.dc.Width = 200
        '
        'frmxemdslop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 314)
        Me.Controls.Add(Me.txtss)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btnlast)
        Me.Controls.Add(Me.lbpaing)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnprev)
        Me.Controls.Add(Me.btnfirst)
        Me.Controls.Add(Me.girdds)
        Me.Controls.Add(Me.cblop)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmxemdslop"
        Me.Text = "frmxemdslop"
        CType(Me.girdds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cblop As System.Windows.Forms.ComboBox
    Friend WithEvents girdds As System.Windows.Forms.DataGridView
    Friend WithEvents btnfirst As System.Windows.Forms.Button
    Friend WithEvents btnprev As System.Windows.Forms.Button
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents lbpaing As System.Windows.Forms.Label
    Friend WithEvents btnlast As System.Windows.Forms.Button
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtss As System.Windows.Forms.TextBox
    Friend WithEvents stt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ht As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ns As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dc As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
