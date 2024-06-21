<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtName = New TextBox()
        txtPhone = New TextBox()
        txtGitHub = New TextBox()
        txtStopwatch = New TextBox()
        txtEmail = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        btnDelete = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(222, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(305, 20)
        Label1.TabIndex = 0
        Label1.Text = "Ashmit Jain, Slidely Task 2 -View Submissions"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(109, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(109, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 2
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(92, 213)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 3
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(73, 263)
        Label5.Name = "Label5"
        Label5.Size = New Size(149, 20)
        Label5.TabIndex = 4
        Label5.Text = "Github Link for Task 2"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(92, 317)
        Label6.Name = "Label6"
        Label6.Size = New Size(116, 20)
        Label6.TabIndex = 5
        Label6.Text = "Stopwatch Time"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(351, 105)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(262, 27)
        txtName.TabIndex = 6
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(351, 210)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(262, 27)
        txtPhone.TabIndex = 7
        ' 
        ' txtGitHub
        ' 
        txtGitHub.Location = New Point(351, 263)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.ReadOnly = True
        txtGitHub.Size = New Size(262, 27)
        txtGitHub.TabIndex = 8
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.Location = New Point(351, 310)
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.ReadOnly = True
        txtStopwatch.Size = New Size(262, 27)
        txtStopwatch.TabIndex = 9
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(351, 160)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(262, 27)
        txtEmail.TabIndex = 10
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Yellow
        btnPrevious.Location = New Point(3, 362)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(291, 40)
        btnPrevious.TabIndex = 12
        btnPrevious.Text = "PREVIOUS (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.LightBlue
        btnNext.Location = New Point(275, 408)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(298, 40)
        btnNext.TabIndex = 13
        btnNext.Text = "NEXT (CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.Location = New Point(470, 362)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(291, 40)
        btnDelete.TabIndex = 14
        btnDelete.Text = "DELETE (CTRL + D)"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnDelete)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtEmail)
        Controls.Add(txtStopwatch)
        Controls.Add(txtGitHub)
        Controls.Add(txtPhone)
        Controls.Add(txtName)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnDelete As Button
End Class
