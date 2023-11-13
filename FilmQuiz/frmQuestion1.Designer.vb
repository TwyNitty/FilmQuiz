<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion1
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
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnAnswer1 = New System.Windows.Forms.RadioButton()
        Me.btnAnswer2 = New System.Windows.Forms.RadioButton()
        Me.btnAnswer3 = New System.Windows.Forms.RadioButton()
        Me.btnAnswer4 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(775, 66)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "What is the name of the hotel concierge in the john wick films?"
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(725, 427)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(175, 63)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnAnswer1
        '
        Me.btnAnswer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer1.Location = New System.Drawing.Point(32, 6)
        Me.btnAnswer1.Name = "btnAnswer1"
        Me.btnAnswer1.Size = New System.Drawing.Size(97, 26)
        Me.btnAnswer1.TabIndex = 3
        Me.btnAnswer1.TabStop = True
        Me.btnAnswer1.Text = "Francis"
        Me.btnAnswer1.UseVisualStyleBackColor = True
        '
        'btnAnswer2
        '
        Me.btnAnswer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer2.Location = New System.Drawing.Point(32, 49)
        Me.btnAnswer2.Name = "btnAnswer2"
        Me.btnAnswer2.Size = New System.Drawing.Size(140, 29)
        Me.btnAnswer2.TabIndex = 4
        Me.btnAnswer2.TabStop = True
        Me.btnAnswer2.Text = "Winston"
        Me.btnAnswer2.UseVisualStyleBackColor = True
        '
        'btnAnswer3
        '
        Me.btnAnswer3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer3.Location = New System.Drawing.Point(32, 93)
        Me.btnAnswer3.Name = "btnAnswer3"
        Me.btnAnswer3.Size = New System.Drawing.Size(135, 33)
        Me.btnAnswer3.TabIndex = 5
        Me.btnAnswer3.TabStop = True
        Me.btnAnswer3.Text = "Charon"
        Me.btnAnswer3.UseVisualStyleBackColor = True
        '
        'btnAnswer4
        '
        Me.btnAnswer4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer4.Location = New System.Drawing.Point(32, 141)
        Me.btnAnswer4.Name = "btnAnswer4"
        Me.btnAnswer4.Size = New System.Drawing.Size(125, 32)
        Me.btnAnswer4.TabIndex = 6
        Me.btnAnswer4.TabStop = True
        Me.btnAnswer4.Text = "Marcus"
        Me.btnAnswer4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.btnAnswer4)
        Me.GroupBox1.Controls.Add(Me.btnAnswer3)
        Me.GroupBox1.Controls.Add(Me.btnAnswer2)
        Me.GroupBox1.Controls.Add(Me.btnAnswer1)
        Me.GroupBox1.Location = New System.Drawing.Point(341, 169)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 206)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.FilmQuiz.My.Resources.Resources._0_hewDCiphOeqAjs0B
        Me.PictureBox2.Location = New System.Drawing.Point(702, 169)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(235, 206)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FilmQuiz.My.Resources.Resources.Lance_Reddick_John_Wick_4_031723_6d05984810cb42d6a09e41623fbab4e1
        Me.PictureBox1.Location = New System.Drawing.Point(49, 169)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(235, 206)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmQuestion1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 549)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmQuestion1"
        Me.Text = "frmQuestion1"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnAnswer1 As RadioButton
    Friend WithEvents btnAnswer2 As RadioButton
    Friend WithEvents btnAnswer3 As RadioButton
    Friend WithEvents btnAnswer4 As RadioButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
