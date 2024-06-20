<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnCS = New Button()
        btnVS = New Button()
        TextBox1 = New Label()
        SuspendLayout()
        ' 
        ' btnCS
        ' 
        btnCS.Location = New Point(462, 102)
        btnCS.Name = "btnCS"
        btnCS.Size = New Size(94, 29)
        btnCS.TabIndex = 0
        btnCS.UseVisualStyleBackColor = True
        ' 
        ' btnVS
        ' 
        btnVS.Location = New Point(362, 173)
        btnVS.Name = "btnVS"
        btnVS.Size = New Size(94, 29)
        btnVS.TabIndex = 1
        btnVS.Text = "Button2"
        btnVS.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.AutoSize = True
        TextBox1.Location = New Point(306, 68)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(53, 20)
        TextBox1.TabIndex = 2
        TextBox1.Text = "Label1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox1)
        Controls.Add(btnVS)
        Controls.Add(btnCS)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCS As Button
    Friend WithEvents btnVS As Button
    Friend WithEvents TextBox1 As Label

End Class
