Public Class frmHighScore
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmMain.Show()
        Me.Hide()
    End Sub
    Public Sub doScore()
        If playerScore < 1 Then
            lblMessage.Text = "Sorry Your Score Was Not Good Enough"
        Else
            lblMessage.Text = "Congratulations Your Score Will Be Added To The Hall Of Fame"
            lstHighscore.Items.Add(PlayerName & vbTab & playerScore)
        End If
    End Sub
    End If
    End Sub
End Class