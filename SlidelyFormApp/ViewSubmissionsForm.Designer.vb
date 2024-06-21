<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
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
        Me.components = New System.ComponentModel.Container()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.view_git = New System.Windows.Forms.TextBox()
        Me.view_phone = New System.Windows.Forms.TextBox()
        Me.view_email = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.view_name = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.view_stopwatch = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Location = New System.Drawing.Point(464, 303)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(234, 42)
        Me.btnNext.TabIndex = 23
        Me.btnNext.Text = "NEXT (CTRL + N)"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.Khaki
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious.Location = New System.Drawing.Point(212, 303)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(216, 42)
        Me.btnPrevious.TabIndex = 22
        Me.btnPrevious.Text = "PREVIOUS (CTRL + P)"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'view_git
        '
        Me.view_git.Location = New System.Drawing.Point(326, 191)
        Me.view_git.Multiline = True
        Me.view_git.Name = "view_git"
        Me.view_git.ReadOnly = True
        Me.view_git.Size = New System.Drawing.Size(372, 30)
        Me.view_git.TabIndex = 21
        '
        'view_phone
        '
        Me.view_phone.Location = New System.Drawing.Point(326, 141)
        Me.view_phone.Multiline = True
        Me.view_phone.Name = "view_phone"
        Me.view_phone.ReadOnly = True
        Me.view_phone.Size = New System.Drawing.Size(372, 30)
        Me.view_phone.TabIndex = 20
        '
        'view_email
        '
        Me.view_email.Location = New System.Drawing.Point(326, 77)
        Me.view_email.Multiline = True
        Me.view_email.Name = "view_email"
        Me.view_email.ReadOnly = True
        Me.view_email.Size = New System.Drawing.Size(372, 30)
        Me.view_email.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(209, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 34)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "GitHub link for Task 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Phone Num"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(233, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Email"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(233, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Name"
        '
        'view_name
        '
        Me.view_name.Location = New System.Drawing.Point(326, 25)
        Me.view_name.Multiline = True
        Me.view_name.Name = "view_name"
        Me.view_name.ReadOnly = True
        Me.view_name.Size = New System.Drawing.Size(372, 30)
        Me.view_name.TabIndex = 14
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'view_stopwatch
        '
        Me.view_stopwatch.Location = New System.Drawing.Point(326, 242)
        Me.view_stopwatch.Multiline = True
        Me.view_stopwatch.Name = "view_stopwatch"
        Me.view_stopwatch.ReadOnly = True
        Me.view_stopwatch.Size = New System.Drawing.Size(372, 30)
        Me.view_stopwatch.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(212, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 40)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Stopwatch time"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(326, 377)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(234, 40)
        Me.btnDelete.TabIndex = 26
        Me.btnDelete.Text = "DELETE (CTRL + D)"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.view_stopwatch)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.view_git)
        Me.Controls.Add(Me.view_phone)
        Me.Controls.Add(Me.view_email)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.view_name)
        Me.KeyPreview = True
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "ViewSubmissionsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents view_git As TextBox
    Friend WithEvents view_phone As TextBox
    Friend WithEvents view_email As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents view_name As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents view_stopwatch As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDelete As Button
End Class
