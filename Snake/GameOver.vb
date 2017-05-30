Public Class GameOver
    Private Sub GameOver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Score As Integer = CInt(Snake.lblScore.Text)
        lblScore.Text = Score
    End Sub
End Class