Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize form controls
        Me.Text = "John Doe, Slidely Task 2 - View Submissions"

        ' Retrieve submissions from backend
        submissions = Await GetSubmissions()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            DisplaySubmission(currentIndex)
        Else
            MessageBox.Show("No submissions found.")
        End If
    End Sub

    Private Async Function GetSubmissions() As Task(Of List(Of Submission))
        Dim client As New HttpClient()
        Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/read")

        If response.IsSuccessStatusCode Then
            Dim responseData As String = Await response.Content.ReadAsStringAsync()
            Console.WriteLine(responseData) ' Add this line for debugging
            ' Deserialize responseData into a list of Submission objects
            Dim submissionList As List(Of Submission) = JsonConvert.DeserializeObject(Of List(Of Submission))(responseData)
            Return submissionList
        Else
            MessageBox.Show("Failed to retrieve submissions.")
            Return New List(Of Submission)
        End If
    End Function

    Private Sub DisplaySubmission(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            Dim submission = submissions(index)
            txtName.Text = submission.Name
            txtEmail.Text = submission.Email
            txtPhone.Text = submission.Phone
            txtGitHub.Text = submission.GitHub
            txtStopwatch.Text = submission.Stopwatch
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.P) Then
            btnPrevious.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.N) Then
            btnNext.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GitHub As String
    Public Property Stopwatch As String
End Class
