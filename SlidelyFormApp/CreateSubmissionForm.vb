Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateSubmissionForm

    Private stopwatchTime As TimeSpan = TimeSpan.Zero
    Private submissions As List(Of Submission)

    Public Sub New(ByRef submissions As List(Of Submission))
        InitializeComponent()
        Me.submissions = submissions
    End Sub


    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Capture submission details from text boxes
        Dim name As String = txt_name.Text
        Dim email As String = txt_email.Text
        Dim phone As String = txt_phone.Text
        Dim githubLink As String = txt_git.Text
        Dim stopwatchTime As String = txt_stopwatch.Text

        ' Create a new Submission object
        Dim newSubmission As New Submission() With {
            .Name = name,
            .Email = email,
            .Phone = phone,
            .GithubLink = githubLink,
            .StopwatchTime = stopwatchTime
        }

        ' Send the submission to the backend
        Dim success As Boolean = Await SubmitDataToBackend(newSubmission)

        If success Then
            MessageBox.Show("Submission successful!")
            ' Optionally, clear the form fields or perform any other actions
        Else
            MessageBox.Show("Failed to submit. Please try again.")
        End If

        ' Close the form or perform any other necessary actions
        Me.Close()
    End Sub

    Private Async Function SubmitDataToBackend(submission As Submission) As Task(Of Boolean)
        Dim client As New HttpClient()
        Dim json As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Try
            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)

            If response.IsSuccessStatusCode Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show($"Error submitting data: {ex.Message}")
            Return False
        End Try
    End Function




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_stopwatch.Text = "00:00:00" ' Initialize TextBox5 to start from 00:00:00
        Timer1.Start() ' Start the timer
    End Sub


    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Check for Ctrl + S shortcut
        If e.Control AndAlso e.KeyCode = Keys.S Then
            ' Call the Submit method or simulate click on the Submit button
            btnSubmit.PerformClick() ' Simulate click on the Submit button
        End If

        ' Check for Ctrl + T shortcut
        If e.Control AndAlso e.KeyCode = Keys.T Then
            ' Simulate click on the Toggle Stopwatch button
            btnToggleStopwatch.PerformClick() ' Simulate click on the Toggle Stopwatch button
        End If
    End Sub



    Private Sub btnToggleStopwatch_Paint(sender As Object, e As PaintEventArgs) Handles btnToggleStopwatch.Paint
        ' Clear the background to avoid overdraw issues
        e.Graphics.Clear(Me.BackColor)

        ' Define a smaller border radius for less curve
        Dim borderRadius As Integer = 5 ' Adjust this value for less curve

        ' Create a path with rounded corners
        Dim path As New Drawing2D.GraphicsPath()
        Dim rect As New Rectangle(0, 0, btnToggleStopwatch.Width - 1, btnToggleStopwatch.Height - 1)
        Dim radius As Integer = borderRadius * 2

        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()

        ' Fill the button background
        Using brush As New SolidBrush(btnToggleStopwatch.BackColor)
            e.Graphics.FillPath(brush, path)
        End Using

        ' Draw border around the button
        Using pen As New Pen(Color.Black, 1) ' Adjust color and width as needed
            e.Graphics.DrawPath(pen, path)
        End Using

        ' Draw the button text
        TextRenderer.DrawText(e.Graphics, btnToggleStopwatch.Text, Me.Font, rect, Me.ForeColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub




    Private Sub btnSubmit_Paint(sender As Object, e As PaintEventArgs) Handles btnSubmit.Paint
        ' Clear the background to avoid overdraw issues
        e.Graphics.Clear(Me.BackColor)

        ' Define a smaller border radius for less curve
        Dim borderRadius As Integer = 5 ' Adjust this value for less curve

        ' Create a path with rounded corners
        Dim path As New Drawing2D.GraphicsPath()
        Dim rect As New Rectangle(0, 0, btnSubmit.Width - 1, btnSubmit.Height - 1)
        Dim radius As Integer = borderRadius * 2

        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()

        ' Fill the button background
        Using brush As New SolidBrush(btnSubmit.BackColor)
            e.Graphics.FillPath(brush, path)
        End Using

        ' Draw border around the button
        Using pen As New Pen(Color.Black, 1) ' Adjust color and width as needed
            e.Graphics.DrawPath(pen, path)
        End Using

        ' Draw the button text
        TextRenderer.DrawText(e.Graphics, btnSubmit.Text, Me.Font, rect, Me.ForeColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub


    Private timerRunning As Boolean = True ' Set initial state

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If timerRunning Then
            Timer1.Stop()
            timerRunning = False
            btnToggleStopwatch.Text = "Resume"
        Else
            Timer1.Start()
            timerRunning = True
            btnToggleStopwatch.Text = "Pause"
        End If
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        stopwatchTime = stopwatchTime.Add(TimeSpan.FromSeconds(1))
        txt_stopwatch.Text = stopwatchTime.ToString("hh\:mm\:ss")
    End Sub









End Class