<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion2
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAnswer1 = New System.Windows.Forms.RadioButton()
        Me.btnAnswer2 = New System.Windows.Forms.RadioButton()
        Me.btnAnswer3 = New System.Windows.Forms.RadioButton()
        Me.btnAnswer4 = New System.Windows.Forms.RadioButton()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAnswer4)
        Me.GroupBox1.Controls.Add(Me.btnAnswer3)
        Me.GroupBox1.Controls.Add(Me.btnAnswer2)
        Me.GroupBox1.Controls.Add(Me.btnAnswer1)
        Me.GroupBox1.Location = New System.Drawing.Point(290, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 216)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnAnswer1
        '
        Me.btnAnswer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer1.Location = New System.Drawing.Point(44, 39)
        Me.btnAnswer1.Name = "btnAnswer1"
        Me.btnAnswer1.Size = New System.Drawing.Size(178, 33)
        Me.btnAnswer1.TabIndex = 0
        Me.btnAnswer1.TabStop = True
        Me.btnAnswer1.Text = " Darth Caedus"
        Me.btnAnswer1.UseVisualStyleBackColor = True
        '
        'btnAnswer2
        '
        Me.btnAnswer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer2.Location = New System.Drawing.Point(44, 78)
        Me.btnAnswer2.Name = "btnAnswer2"
        Me.btnAnswer2.Size = New System.Drawing.Size(178, 33)
        Me.btnAnswer2.TabIndex = 1
        Me.btnAnswer2.TabStop = True
        Me.btnAnswer2.Text = "Darth tyranus"
        Me.btnAnswer2.UseVisualStyleBackColor = True
        '
        'btnAnswer3
        '
        Me.btnAnswer3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer3.Location = New System.Drawing.Point(44, 117)
        Me.btnAnswer3.Name = "btnAnswer3"
        Me.btnAnswer3.Size = New System.Drawing.Size(178, 31)
        Me.btnAnswer3.TabIndex = 2
        Me.btnAnswer3.TabStop = True
        Me.btnAnswer3.Text = "Darth Atrius"
        Me.btnAnswer3.UseVisualStyleBackColor = True
        '
        'btnAnswer4
        '
        Me.btnAnswer4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer4.Location = New System.Drawing.Point(44, 154)
        Me.btnAnswer4.Name = "btnAnswer4"
        Me.btnAnswer4.Size = New System.Drawing.Size(178, 41)
        Me.btnAnswer4.TabIndex = 3
        Me.btnAnswer4.TabStop = True
        Me.btnAnswer4.Text = "Darth sidious"
        Me.btnAnswer4.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(684, 387)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(170, 65)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(808, 73)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Who Trained Anakin When He Turned To The Dark Side To Become Darth Vader?"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FilmQuiz.My.Resources.Resources.sidious
        Me.PictureBox1.Location = New System.Drawing.Point(27, 122)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 216)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.FilmQuiz.My.Resources.Resources.palpatine
        Me.PictureBox2.Location = New System.Drawing.Point(640, 122)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(252, 216)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'frmQuestion2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 510)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmQuestion2"
        Me.Text = "frmQuestion2"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAnswer4 As RadioButton
    Friend WithEvents btnAnswer3 As RadioButton
    Friend WithEvents btnAnswer2 As RadioButton
    Friend WithEvents btnAnswer1 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnNext As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
