Public Class Main
    Public map(gameWidth, gameHeight) As Integer
    Dim grid(gameWidth, gameHeight) As PictureBox
    Dim score As Integer
    Dim Player1 As Snake
    Dim paused As Boolean = False
    Class Snake
        Public body As New List(Of Point)
        Private direction As String = "Right"
        Private length As Integer = 5
        Private x As Integer = 1
        Private y As Integer = 1
        Public Sub New(x, y)
            setX(x)
            setY(y)
        End Sub
        Public Function getX()
            Return x
        End Function
        Public Sub setX(x As Integer)
            Me.x = x
        End Sub
        Public Function getY()
            Return y
        End Function
        Public Sub setY(y As Integer)
            Me.y = y
        End Sub
        Public Function getDirection()
            Return direction
        End Function
        Public Sub setDirection(direction As String)
            Me.direction = direction
        End Sub
        Public Function getLength()
            Return length
        End Function
        Public Sub setLength(length As Integer)
            Me.length = length
        End Sub
        Public Sub incrementLength()
            length += 1
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
    End Class
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.Up
                If Player1.getDirection <> "Down" Then
                    Player1.setDirection("Up")
                End If
                Return True 'suppress default handling of arrow keys

            Case Keys.Right
                If Player1.getDirection <> "Left" Then
                    Player1.setDirection("Right")
                End If
                Return True

            Case Keys.Down
                If Player1.getDirection <> "Up" Then
                    Player1.setDirection("Down")
                End If
                Return True

            Case Keys.Left
                If Player1.getDirection <> "Right" Then
                    Player1.setDirection("Left")
                End If
                Return True

        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Private Sub Update_Tick(sender As Object, e As EventArgs) Handles UpdateTimer.Tick
        Select Case Player1.getDirection
            Case "Right"
                Player1.moveRight()
            Case "Left"
                Player1.moveLeft()
            Case "Up"
                Player1.moveUp()
            Case "Down"
                Player1.moveDown()
        End Select
        If Not checkWall() Then
            Exit Sub
        End If
        If Not checkSelf() Then
            Exit Sub
        End If
        checkApple()
        updateSnake()
        updateVisual()
    End Sub
    Private Sub Snake_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTimer.Interval = startSpeed
        Player1 = New Snake(Math.Floor(gameWidth / 2), Math.Floor(gameHeight / 2))
        Width = (20 * gameWidth) + 60
        Height = (20 * gameHeight) + 120
        initialRender()
        initialFillZero()
        updateSnake()
        For i = 1 To appleAmount
            randomApple()
        Next
        updateVisual()
    End Sub
    Private Sub initialRender()
        For i = 0 To gameWidth
            For j = 0 To gameHeight
                grid(i, j) = New PictureBox
                With grid(i, j)
                    .Name = "Cell" & Str(i) & Str(j)
                    .Width = 20
                    .Height = 20
                    .Location = New Point(10 + (20 * i), 50 + (20 * j))
                    .BackColor = boardColour
                End With
                Controls.Add(grid(i, j))
            Next
        Next
        Dim lblScoreY = lblScore.Location.Y
        lblScore.Location = New Point(Math.Floor(gameWidth / 2) * 20, lblScoreY)
    End Sub
    Private Sub initialFillZero()
        For i = 0 To gameWidth
            For j = 0 To gameHeight
                map(i, j) = 0
            Next
        Next
    End Sub
    Private Sub updateSnake()
        map(Player1.getX, Player1.getY) = 1
        Player1.body.Add(New Point(Player1.getX, Player1.getY))
        If Player1.body.Count > Player1.getLength() Then
            map(Player1.body.First.X, Player1.body.First.Y) = 0
            Player1.body.RemoveAt(0)
        End If
    End Sub
    Private Sub updateVisual()
        For i = 0 To gameWidth
            For j = 0 To gameHeight
                If (map(i, j) = 1) Then
                    grid(i, j).BackColor = snakeColour
                ElseIf (map(i, j) = 2) Then
                    grid(i, j).BackColor = foodColour
                Else
                    grid(i, j).BackColor = boardColour
                End If
            Next
        Next
    End Sub
    Private Sub checkApple()
        If map(Player1.getX, Player1.getY) = 2 Then
            If lengthIncrease Then
                Player1.incrementLength()
            End If
            If speedIncrease Then
                If UpdateTimer.Interval > 10 Then
                    UpdateTimer.Interval -= 5

                End If
            End If
            score += 1
            lblScore.Text = score
            randomApple()
        End If
    End Sub
    Private Function checkWall()
        If deathWalls Then
            If (Player1.getX > gameWidth Or Player1.getX < 0) Then
                endGame()
                Return False
            ElseIf (Player1.getY > gameHeight Or Player1.getY < 0) Then
                endGame()
                Return False
            End If
            Return True
        Else
            If Player1.getX > gameWidth Then
                Player1.setX(0)
            ElseIf Player1.getX < 0 Then
                Player1.setX(gameWidth)
            ElseIf Player1.getY > gameHeight Then
                Player1.setY(0)
            ElseIf Player1.getY < 0 Then
                Player1.setY(gameHeight)
            End If
            Return True
        End If
    End Function
    Private Function checkSelf()
        If map(Player1.getX, Player1.getY) = 1 Then
            endGame()
            Return False
        End If
        Return True
    End Function
    Private Sub endGame()
        GameOver.Show()
        UpdateTimer.Enabled = False
    End Sub
    Private Sub randomApple()
        Dim x = GetRandom(0, gameWidth)
        Dim y = GetRandom(0, gameHeight)
        If map(x, y) = 0 Then
            map(x, y) = 2
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
            UpdateTimer.Enabled = False
            btnPlayPause.BackgroundImage = My.Resources.ResourceManager.GetObject("play")
        ElseIf paused Then
            paused = False
            UpdateTimer.Enabled = True
            btnPlayPause.BackgroundImage = My.Resources.ResourceManager.GetObject("pause")
        End If
    End Sub
End Class
