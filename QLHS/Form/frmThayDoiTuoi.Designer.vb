<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThayDoiTuoi
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudMin = New System.Windows.Forms.NumericUpDown()
        Me.nudMax = New System.Windows.Forms.NumericUpDown()
        Me.btnLuu = New System.Windows.Forms.Button()
        CType(Me.nudMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tuổi nhỏ nhất"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tuổi lớn nhất"
        '
        'nudMin
        '
        Me.nudMin.Location = New System.Drawing.Point(213, 110)
        Me.nudMin.Name = "nudMin"
        Me.nudMin.Size = New System.Drawing.Size(152, 20)
        Me.nudMin.TabIndex = 2
        '
        'nudMax
        '
        Me.nudMax.Location = New System.Drawing.Point(213, 169)
        Me.nudMax.Name = "nudMax"
        Me.nudMax.Size = New System.Drawing.Size(152, 20)
        Me.nudMax.TabIndex = 3
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(323, 269)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(78, 39)
        Me.btnLuu.TabIndex = 4
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'frmThayDoiTuoi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 320)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.nudMax)
        Me.Controls.Add(Me.nudMin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmThayDoiTuoi"
        Me.Text = "Thay đổi tuổi nhập học"
        CType(Me.nudMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nudMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudMax As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnLuu As System.Windows.Forms.Button
End Class
