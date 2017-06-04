Imports System.IO
Imports System.Net
Imports Newtonsoft.Json
Public Class Leaderboard
    Dim url = "http://thesnake.herokuapp.com/snakes"
    Private Sub Leaderboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvLeaderboard.Columns.Add("Name", 80, HorizontalAlignment.Center)
        lvLeaderboard.Columns.Add("Score", 50, HorizontalAlignment.Center)
        lvLeaderboard.Columns.Add("Death Wall", 80, HorizontalAlignment.Center)
        lvLeaderboard.Columns.Add("Increment Length", 100, HorizontalAlignment.Center)
        lvLeaderboard.Columns.Add("Increment Speed", 100, HorizontalAlignment.Center)
        RetrieveRequest(url)
    End Sub
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
        Me.Close()
    End Sub
End Class