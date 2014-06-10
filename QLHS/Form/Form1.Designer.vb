<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
<<<<<
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(75, 56)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(149, 43)
        Me.ListBox1.TabIndex = 0
=======
        Me.btntaods = New System.Windows.Forms.Button()
        Me.btntim = New System.Windows.Forms.Button()
        Me.btnds = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btntaods
        '
        Me.btntaods.Location = New System.Drawing.Point(77, 90)
        Me.btntaods.Name = "btntaods"
        Me.btntaods.Size = New System.Drawing.Size(75, 23)
        Me.btntaods.TabIndex = 0
        Me.btntaods.Text = "tao lop"
        Me.btntaods.UseVisualStyleBackColor = True
        '
        'btntim
        '
        Me.btntim.Location = New System.Drawing.Point(186, 90)
        Me.btntim.Name = "btntim"
        Me.btntim.Size = New System.Drawing.Size(75, 23)
        Me.btntim.TabIndex = 1
        Me.btntim.Text = "Tim kiem"
        Me.btntim.UseVisualStyleBackColor = True
        '
        'btnds
        '
        Me.btnds.Location = New System.Drawing.Point(77, 142)
        Me.btnds.Name = "btnds"
        Me.btnds.Size = New System.Drawing.Size(126, 24)
        Me.btnds.TabIndex = 2
        Me.btnds.Text = "Lập danh sách lớp"
        Me.btnds.UseVisualStyleBackColor = True
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
