Public Class Start
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gameWidth = udGameWidth.Value
        gameHeight = udGameHeight.Value
        startSpeed = Math.Floor((1 / tbStartSpeed.Value) * 1000)
        deathWalls = cbDeathWalls.Checked
        speedIncrease = cbSpeedIncrease.Checked
        lengthIncrease = cbLengthIncrease.Checked
        appleAmount = udAppleAmount.Value
        boardColour = btnBoardColour.BackColor
        snakeColour = btnSnakeColour.BackColor
        foodColour = btnFoodColour.BackColor

        My.Settings.gameWidth = gameWidth
        My.Settings.gameHeight = gameHeight
        My.Settings.boardColour = boardColour
        My.Settings.snakeColour = snakeColour
        My.Settings.foodColour = foodColour
        My.Settings.startSpeed = tbStartSpeed.Value
        My.Settings.deathWalls = deathWalls
        My.Settings.speedIncrease = speedIncrease
        My.Settings.lengthIncrease = lengthIncrease
        My.Settings.appleAmount = appleAmount
        My.Settings.Save()

        Main.Show()
        Hide()
    End Sub

    Private Sub btnBoardColour_Click(sender As Object, e As EventArgs) Handles btnBoardColour.Click
        If selectColour.ShowDialog <> DialogResult.Cancel Then
            btnBoardColour.BackColor = selectColour.Color
        End If
    End Sub

    Private Sub btnSnakeColour_Click(sender As Object, e As EventArgs) Handles btnSnakeColour.Click
        If selectColour.ShowDialog <> DialogResult.Cancel Then
            btnSnakeColour.BackColor = selectColour.Color
        End If
    End Sub

    Private Sub btnFoodColour_Click(sender As Object, e As EventArgs) Handles btnFoodColour.Click
        If selectColour.ShowDialog <> DialogResult.Cancel Then
            btnFoodColour.BackColor = selectColour.Color
        End If
    End Sub

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        udGameWidth.Value = My.Settings.gameWidth
        udGameHeight.Value = My.Settings.gameHeight
        btnBoardColour.BackColor = My.Settings.boardColour
        btnSnakeColour.BackColor = My.Settings.snakeColour
        btnFoodColour.BackColor = My.Settings.foodColour
        tbStartSpeed.Value = My.Settings.startSpeed
        cbDeathWalls.Checked = My.Settings.deathWalls
        cbSpeedIncrease.Checked = My.Settings.speedIncrease
        cbLengthIncrease.Checked = My.Settings.lengthIncrease
        udAppleAmount.Value = My.Settings.appleAmount
    End Sub

    Private Sub btnLeaderboard_Click(sender As Object, e As EventArgs) Handles btnLeaderboard.Click
        Leaderboard.Show()
    End Sub
End Class