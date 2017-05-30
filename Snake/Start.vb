Public Class Start
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gameWidth = udGameWidth.Value
        gameHeight = udGameHeight.Value
        startSpeed = Math.Floor((1 / tbStartSpeed.Value) * 1000)
        deathWalls = cbDeathWalls.Checked
        speedIncrease = cbSpeedIncrease.Checked
        lengthIncrease = cbLengthIncrease.Checked
        Snake.Show()
        Hide()
    End Sub

    Private Sub btnBoardColour_Click(sender As Object, e As EventArgs) Handles btnBoardColour.Click
        If selectColour.ShowDialog <> DialogResult.Cancel Then
            btnBoardColour.BackColor = selectColour.Color
            boardColour = selectColour.Color
        End If
    End Sub

    Private Sub btnSnakeColour_Click(sender As Object, e As EventArgs) Handles btnSnakeColour.Click
        If selectColour.ShowDialog <> DialogResult.Cancel Then
            btnSnakeColour.BackColor = selectColour.Color
            snakeColour = selectColour.Color
        End If
    End Sub

    Private Sub btnFoodColour_Click(sender As Object, e As EventArgs) Handles btnFoodColour.Click
        If selectColour.ShowDialog <> DialogResult.Cancel Then
            btnFoodColour.BackColor = selectColour.Color
            foodColour = selectColour.Color
        End If
    End Sub
End Class