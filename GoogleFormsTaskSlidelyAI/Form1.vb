Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = "Ashmit Jain, Slidely Task 2 - Slidely Form App"
        TextBox1.Size = New Size(350, 50)
        TextBox1.Location = New Point(200, 100)
        TextBox1.Font = New Font("Inter", 10)

        btnVS.text = "VIEW SUBMISSIONS(CTRL+V)"
        btnVS.BackColor = Color.Yellow
        btnVS.Font = New Font("Inter", 9, FontStyle.Bold)
        btnVS.Size = New Size(350, 50)
        btnVS.Location = New Point((TextBox1.ClientSize.Width + 70) / 2, 160)

        btnCS.Text = "CREATE NEW SUBMISSION(CTRL+C)"
        btnCS.BackColor = Color.LightBlue
        btnCS.Font = New Font("Inter", 9, FontStyle.Bold)
        btnCS.Size = New Size(350, 50)
        btnCS.Location = New Point((TextBox1.ClientSize.Width + 70) / 2, 225)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVS.Click
        Dim viewSubmissionsForm As New ViewSubmissionsForm()
        viewSubmissionsForm.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnCS.Click
        Dim createSubmissionForm As New CreateSubmissionForm()
        createSubmissionForm.Show()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.V) Then
            btnVS.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.N) Then
            btnCS.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class
