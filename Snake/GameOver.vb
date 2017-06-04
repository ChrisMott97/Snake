Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Public Class GameOver
    Dim url = "http://thesnake.herokuapp.com/snakes"
    Class SnakeRecord
        Public Sub New(name As String, score As Integer, deathWalls As Boolean, speedIncrease As Boolean, lengthIncrease As Boolean)
            Me.name = name
            Me.score = score
            Me.deathWalls = deathWalls
            Me.speedIncrease = speedIncrease
            Me.lengthIncrease = lengthIncrease
        End Sub
        Public name As String
        Public score As Integer
        Public deathWalls As Boolean
        Public speedIncrease As Boolean
        Public lengthIncrease As Boolean
    End Class
    Private Sub GameOver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Score As Integer = CInt(Main.lblScore.Text)
        lblScore.Text = Score
        lvLeaderboard.Columns.Add("Name", 80, HorizontalAlignment.Center)
        lvLeaderboard.Columns.Add("Score", 50, HorizontalAlignment.Center)
        lvLeaderboard.Columns.Add("Death Wall", 80, HorizontalAlignment.Center)
        lvLeaderboard.Columns.Add("Increment Length", 100, HorizontalAlignment.Center)
        lvLeaderboard.Columns.Add("Increment Speed", 100, HorizontalAlignment.Center)
        RetrieveRequest(url)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newobject = New SnakeRecord(txtName.Text, lblScore.Text, deathWalls, speedIncrease, lengthIncrease)
        Dim unencoded = JsonConvert.SerializeObject(newobject)
        Dim data = Encoding.UTF8.GetBytes(unencoded)
        Dim result_post = SendRequest(url, data, "application/json", "POST")
        lvLeaderboard.Items.Clear()
        RetrieveRequest(url)
        Button1.Enabled = False
    End Sub
    Private Function SendRequest(uri As String, jsonDataBytes As Byte(), contentType As String, method As String) As String
        Dim req As WebRequest = WebRequest.Create(uri)
        req.ContentType = contentType
        req.Method = method
        req.ContentLength = jsonDataBytes.Length


        Dim stream = req.GetRequestStream()
        stream.Write(jsonDataBytes, 0, jsonDataBytes.Length)
        stream.Close()

        Dim response = req.GetResponse().GetResponseStream()

        Dim reader As New StreamReader(response)
        Dim res = reader.ReadToEnd()
        reader.Close()
        response.Close()

        Return res
    End Function
    Sub RetrieveRequest(uri As String)
        Dim request As WebRequest = WebRequest.Create(uri)
        request.Credentials = CredentialCache.DefaultCredentials
        Dim response As WebResponse = request.GetResponse()
        Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
        Dim dataStream As Stream = response.GetResponseStream()
        Dim reader As New StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd()
        Dim newData = JsonConvert.DeserializeObject(Of IList)(responseFromServer)

        Dim newItem(4) As String
        For i = 0 To 9
            If newData.Count > i Then
                newItem(0) = newData.Item(i).Item("name")
                newItem(1) = newData.Item(i).Item("score")
                newItem(2) = newData.Item(i).Item("deathWalls")
                newItem(3) = newData.Item(i).Item("speedIncrease")
                newItem(4) = newData.Item(i).Item("lengthIncrease")
                lvLeaderboard.Items.Add(New ListViewItem(newItem))
            End If
        Next
        reader.Close()
        response.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class