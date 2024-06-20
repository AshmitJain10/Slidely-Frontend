Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private stopwatchRunning As Boolean = False
    Private stopwatchTime As TimeSpan = TimeSpan.Zero
    Private stopwatchTimer As New Timer()

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Ashmit Jain, Slidely Task 2 -  Create Task"
        Label2.Size = New Size(350, 50)
        Label2.Font = New Font("Inter", 10)

        ' Timer setup
        stopwatchTimer.Interval = 1000
        AddHandler stopwatchTimer.Tick, AddressOf OnStopwatchTick

        ' Set initial stopwatch text
        txtStopwatch.Text = stopwatchTime.ToString("hh\:mm\:ss")
    End Sub

    Private Sub OnStopwatchTick(sender As Object, e As EventArgs)
        If stopwatchRunning Then
            stopwatchTime = stopwatchTime.Add(TimeSpan.FromSeconds(1))
            txtStopwatch.Text = stopwatchTime.ToString("hh\:mm\:ss")
        End If
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        stopwatchRunning = Not stopwatchRunning
        If stopwatchRunning Then
            stopwatchTimer.Start()
        Else
            stopwatchTimer.Stop()
        End If
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Collect data from text boxes
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhone.Text
        Dim githubLink As String = txtGitHub.Text
        Dim stopwatchTimeStr As String = txtStopwatch.Text

        ' Submit data to backend
        Await SubmitForm(name, email, phone, githubLink, stopwatchTimeStr)
    End Sub

    Private Async Function SubmitForm(name As String, email As String, phone As String, Github As String, StopwatchTime As String) As Task
        Dim client As New HttpClient()
        Dim values As New Dictionary(Of String, String) From {
            {"name", name},
            {"email", email},
            {"phone", phone},
            {"github_link", Github},
            {"stopwatch_time", stopwatchTime}
        }

        Dim content As New StringContent(JsonConvert.SerializeObject(values), Encoding.UTF8, "application/json")
        Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)

        If response.IsSuccessStatusCode Then
            MessageBox.Show("Submission successful!")
        Else
            MessageBox.Show("Submission failed.")
        End If
    End Function

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.T) Then
            btnToggleStopwatch.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.S) Then
            btnSubmit.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class
