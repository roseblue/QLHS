<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmthemlop
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
        Me.txttenlop = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbkhoi = New System.Windows.Forms.ComboBox()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txttenlop
        '
        Me.txttenlop.Location = New System.Drawing.Point(87, 29)
        Me.txttenlop.Name = "txttenlop"
        Me.txttenlop.Size = New System.Drawing.Size(100, 20)
        Me.txttenlop.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tên lớp"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Khối"
        '
        'cbkhoi
        '
        Me.cbkhoi.FormattingEnabled = True
        Me.cbkhoi.Location = New System.Drawing.Point(87, 61)
        Me.cbkhoi.Name = "cbkhoi"
        Me.cbkhoi.Size = New System.Drawing.Size(100, 21)
        Me.cbkhoi.TabIndex = 3
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(33, 114)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 4
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(142, 114)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 23)
        Me.btnthoat.TabIndex = 5
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'frmthemlop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 149)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.cbkhoi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttenlop)
        Me.Name = "frmthemlop"
        Me.Text = "frmthemlop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txttenlop As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbkhoi As System.Windows.Forms.ComboBox
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnthoat As System.Windows.Forms.Button
End Class
