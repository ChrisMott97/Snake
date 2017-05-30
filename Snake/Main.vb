Public Class Snake
    Dim gameWidth As Integer = 40
    Dim gameHeight As Integer = 40
    Dim Map(gameWidth, gameHeight) As Integer
    Dim Grid(gameWidth, gameHeight) As PictureBox
    Dim Score As Integer
    Dim currentSnake As Snake
    Dim Direction As String = "Right"
    Dim currentSnakeLength As Integer = 5
    Dim currentSnakeBody As New List(Of Point)
    Dim paused As Boolean = False
    Class Snake
        Private x As Integer = 1
        Private y As Integer = 1
        Public Sub New(x, y)
            Me.x = x
            Me.y = y
        End Sub
        Public Sub moveUp()
            y = y - 1
        End Sub
        Public Sub moveDown()
            y = y + 1
        End Sub
        Public Sub moveRight()
            x = x + 1
        End Sub
        Public Sub moveLeft()
            x = x - 1
        End Sub
        Public Function getX()
            Return x
        End Function
        Public Function getY()
            Return y
        End Function
        Public Sub setX(x)
            Me.x = x
        End Sub
        Public Sub setY(y)
            Me.y = y
        End Sub
    End Class
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gameWidth = Options.gameWidth
        gameHeight = Options.gameHeight
        Update.Interval = Options.startSpeed
        currentSnake = New Snake(Math.Floor(gameWidth / 2), Math.Floor(gameHeight / 2))
        Me.Width = (20 * gameWidth) + 60
        Me.Height = (20 * gameHeight) + 120
        renderGrid(Grid)
        fillZero()
        updateSnake()
        randomApple()
        mapToGrid()
    End Sub
    Private Function checkWall()
        If Options.deathWalls Then
            If (currentSnake.getX > gameWidth Or currentSnake.getX < 0) Then
                endGame()
                Return False
            ElseIf (currentSnake.getY > gameHeight Or currentSnake.getY < 0) Then
                endGame()
                Return False
            End If
            Return True
        Else
            If currentSnake.getX > gameWidth Then
                currentSnake.setX(0)
            ElseIf currentSnake.getX < 0 Then
                currentSnake.setX(gameWidth)
            ElseIf currentSnake.getY > gameHeight Then
                currentSnake.setY(0)
            ElseIf currentSnake.getY < 0 Then
                currentSnake.setY(gameHeight)
            End If
            Return True
        End If
    End Function
    Private Function checkSelf()
        If Map(currentSnake.getX, currentSnake.getY) = 1 Then
            endGame()
            Return False
        End If
        Return True
    End Function
    Private Sub endGame()
        GameOver.Show()
        Update.Enabled = False
    End Sub
    Private Sub updateSnake()
        Map(currentSnake.getX, currentSnake.getY) = 1
        currentSnakeBody.Add(New Point(currentSnake.getX, currentSnake.getY))
        If currentSnakeBody.Count > currentSnakeLength Then
            Map(currentSnakeBody.First.X, currentSnakeBody.First.Y) = 0
            currentSnakeBody.RemoveAt(0)
        End If
    End Sub
    Private Sub fillZero()
        For i = 0 To gameWidth
            For j = 0 To gameHeight
                Map(i, j) = 0
            Next
        Next
    End Sub
    Private Sub renderGrid(ByRef Grid)
        For i = 0 To gameWidth
            For j = 0 To gameHeight
                Grid(i, j) = New PictureBox
                With Grid(i, j)
                    .Name = "Cell" & Str(i) & Str(j)
                    .Width = 20
                    .Height = 20
                    .Location = New Point(10 + (20 * i), 50 + (20 * j))
                    .BackColor = Options.boardColour
                End With
                Controls.Add(Grid(i, j))
            Next
        Next
        Dim lblScoreY = lblScore.Location.Y
        lblScore.Location = New Point(Math.Floor(gameWidth / 2) * 20, lblScoreY)
        Debug.WriteLine(lblScore.Location)
    End Sub
    Private Sub mapToGrid()
        For i = 0 To gameWidth
            For j = 0 To gameHeight
                If (Map(i, j) = 1) Then
                    Grid(i, j).BackColor = Options.snakeColour
                ElseIf (Map(i, j) = 2) Then
                    Grid(i, j).BackColor = Options.foodColour
                Else
                    Grid(i, j).BackColor = Options.boardColour
                End If
            Next
        Next
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, keyData As System.Windows.Forms.Keys) As Boolean
        Select Case keyData
            Case Keys.Up
                If Direction <> "Down" Then
                    Direction = "Up"
                End If
                Return True 'suppress default handling of arrow keys

            Case Keys.Right
                If Direction <> "Left" Then
                    Direction = "Right"
                End If
                Return True

            Case Keys.Down
                If Direction <> "Up" Then
                    Direction = "Down"
                End If
                Return True

            Case Keys.Left
                If Direction <> "Right" Then
                    Direction = "Left"
                End If
                Return True

        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Update_Tick(sender As Object, e As EventArgs) Handles Update.Tick
        Select Case Direction
            Case "Right"
                currentSnake.moveRight()
            Case "Left"
                currentSnake.moveLeft()
            Case "Up"
                currentSnake.moveUp()
            Case "Down"
                currentSnake.moveDown()
        End Select
        If Not checkWall() Then
            Exit Sub
        End If
        If Not checkSelf() Then
            Exit Sub
        End If
        checkApple()
        updateSnake()
        mapToGrid()
    End Sub
    Private Sub checkApple()
        If Map(currentSnake.getX, currentSnake.getY) = 2 Then
            If Options.lengthIncrease Then
                currentSnakeLength += 1
            End If
            If Options.speedIncrease Then
                Update.Interval -= 5
            End If
            Score += 1
            lblScore.Text = Score
            randomApple()
        End If
    End Sub
    Private Sub randomApple()
        Dim x = GetRandom(0, gameWidth)
        Dim y = GetRandom(0, gameHeight)
        If Map(x, y) = 0 Then
            Map(x, y) = 2
        Else
            randomApple()
        End If
    End Sub
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        ' by making Generator static, we preserve the same instance '
        ' (i.e., do not create new instances with the same seed over and over) '
        ' between calls '
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Sub btnPlayPause_Click(sender As Object, e As EventArgs) Handles btnPlayPause.Click
        If Not paused Then
            paused = True
            Update.Enabled = False
            btnPlayPause.BackgroundImage = My.Resources.ResourceManager.GetObject("play")
        ElseIf paused Then
            paused = False
            Update.Enabled = True
            btnPlayPause.BackgroundImage = My.Resources.ResourceManager.GetObject("pause")
        End If
    End Sub
End Class
