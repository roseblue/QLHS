<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtimkiem
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
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.gridhs = New System.Windows.Forms.DataGridView()
        Me.stt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ht = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lop = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbhk1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbhk2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnfirst = New System.Windows.Forms.Button()
        Me.btnprev = New System.Windows.Forms.Button()
        Me.btnlast = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.lbpaing = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtht = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btntim = New System.Windows.Forms.Button()
        Me.cblop = New System.Windows.Forms.ComboBox()
        CType(Me.gridhs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(424, 298)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(77, 22)
        Me.btnthoat.TabIndex = 0
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'gridhs
        '
        Me.gridhs.AllowUserToAddRows = False
        Me.gridhs.AllowUserToDeleteRows = False
        Me.gridhs.AllowUserToResizeColumns = False
        Me.gridhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridhs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.stt, Me.ht, Me.lop, Me.tbhk1, Me.tbhk2})
        Me.gridhs.Location = New System.Drawing.Point(12, 69)
        Me.gridhs.Name = "gridhs"
        Me.gridhs.RowHeadersVisible = False
        Me.gridhs.Size = New System.Drawing.Size(556, 206)
        Me.gridhs.TabIndex = 1
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
        'lop
        '
        Me.lop.HeaderText = "Lớp"
        Me.lop.Name = "lop"
        Me.lop.ReadOnly = True
        '
        'tbhk1
        '
        Me.tbhk1.HeaderText = "TB Học Kỳ 1"
        Me.tbhk1.Name = "tbhk1"
        Me.tbhk1.ReadOnly = True
        '
        'tbhk2
        '
        Me.tbhk2.HeaderText = "TB Học Kỳ 2"
        Me.tbhk2.Name = "tbhk2"
        Me.tbhk2.ReadOnly = True
        '
        'btnfirst
        '
        Me.btnfirst.Enabled = False
        Me.btnfirst.Location = New System.Drawing.Point(12, 298)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(37, 23)
        Me.btnfirst.TabIndex = 2
        Me.btnfirst.Text = "<<"
        Me.btnfirst.UseVisualStyleBackColor = True
        '
        'btnprev
        '
        Me.btnprev.Enabled = False
        Me.btnprev.Location = New System.Drawing.Point(55, 298)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(37, 23)
        Me.btnprev.TabIndex = 3
        Me.btnprev.Text = "<"
        Me.btnprev.UseVisualStyleBackColor = True
        '
        'btnlast
        '
        Me.btnlast.Enabled = False
        Me.btnlast.Location = New System.Drawing.Point(192, 298)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(40, 23)
        Me.btnlast.TabIndex = 4
        Me.btnlast.Text = ">>"
        Me.btnlast.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Enabled = False
        Me.btnnext.Location = New System.Drawing.Point(144, 298)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(42, 23)
        Me.btnnext.TabIndex = 5
        Me.btnnext.Text = ">"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'lbpaing
        '
        Me.lbpaing.AutoSize = True
        Me.lbpaing.Location = New System.Drawing.Point(98, 303)
        Me.lbpaing.Name = "lbpaing"
        Me.lbpaing.Size = New System.Drawing.Size(40, 13)
        Me.lbpaing.TabIndex = 6
        Me.lbpaing.Text = "{0}/{1}"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Họ Tên"
        '
        'txtht
        '
        Me.txtht.Location = New System.Drawing.Point(55, 20)
        Me.txtht.Name = "txtht"
        Me.txtht.Size = New System.Drawing.Size(100, 20)
        Me.txtht.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Lớp"
        '
        'btntim
        '
        Me.btntim.Location = New System.Drawing.Point(378, 17)
        Me.btntim.Name = "btntim"
        Me.btntim.Size = New System.Drawing.Size(75, 23)
        Me.btntim.TabIndex = 11
        Me.btntim.Text = "Tìm"
        Me.btntim.UseVisualStyleBackColor = True
        '
        'cblop
        '
        Me.cblop.FormattingEnabled = True
        Me.cblop.Location = New System.Drawing.Point(220, 18)
        Me.cblop.Name = "cblop"
        Me.cblop.Size = New System.Drawing.Size(121, 21)
        Me.cblop.TabIndex = 12
        '
        'frmtimkiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 332)
        Me.Controls.Add(Me.cblop)
        Me.Controls.Add(Me.btntim)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtht)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbpaing)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnlast)
        Me.Controls.Add(Me.btnprev)
        Me.Controls.Add(Me.btnfirst)
        Me.Controls.Add(Me.gridhs)
        Me.Controls.Add(Me.btnthoat)
        Me.Name = "frmtimkiem"
        Me.Text = "frmtimkiem"
        CType(Me.gridhs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents gridhs As System.Windows.Forms.DataGridView
    Friend WithEvents btnfirst As System.Windows.Forms.Button
    Friend WithEvents btnprev As System.Windows.Forms.Button
    Friend WithEvents btnlast As System.Windows.Forms.Button
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents lbpaing As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtht As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btntim As System.Windows.Forms.Button
    Friend WithEvents cblop As System.Windows.Forms.ComboBox
    Friend WithEvents stt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ht As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbhk1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbhk2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
