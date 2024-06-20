<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGitHub = New TextBox()
        txtName = New TextBox()
        txtStopwatch = New TextBox()
        Label1 = New Label()
        btnSubmit = New Button()
        btnToggleStopwatch = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(364, 160)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(225, 27)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(364, 203)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(225, 27)
        txtPhone.TabIndex = 2
        ' 
        ' txtGitHub
        ' 
        txtGitHub.Location = New Point(364, 248)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.Size = New Size(225, 27)
        txtGitHub.TabIndex = 3
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(364, 107)
        txtName.Name = "txtName"
        txtName.Size = New Size(225, 27)
        txtName.TabIndex = 4
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.BackColor = Color.LightGray
        txtStopwatch.Location = New Point(364, 295)
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.ReadOnly = True
        txtStopwatch.Size = New Size(225, 27)
        txtStopwatch.TabIndex = 5
        txtStopwatch.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(108, 302)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 6
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.LightBlue
        btnSubmit.Location = New Point(134, 359)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(419, 49)
        btnSubmit.TabIndex = 7
        btnSubmit.Text = "SUBMIT (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.Yellow
        btnToggleStopwatch.Location = New Point(43, 293)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(280, 31)
        btnToggleStopwatch.TabIndex = 8
        btnToggleStopwatch.Text = "TOGGLE STOPWATCH(CTRL+T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(176, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(321, 20)
        Label2.TabIndex = 9
        Label2.Text = "Ashmit Jain, Slidely Task - 2 , Create Submission"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(109, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 20)
        Label3.TabIndex = 10
        Label3.Text = "Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(109, 163)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 20)
        Label4.TabIndex = 11
        Label4.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(85, 210)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 20)
        Label5.TabIndex = 12
        Label5.Text = "Phone Num"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(68, 255)
        Label6.Name = "Label6"
        Label6.Size = New Size(149, 20)
        Label6.TabIndex = 13
        Label6.Text = "Github Link for Task 2"
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(btnSubmit)
        Controls.Add(Label1)
        Controls.Add(txtStopwatch)
        Controls.Add(txtName)
        Controls.Add(txtGitHub)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
