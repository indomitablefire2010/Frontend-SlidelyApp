Imports System.Net
Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ViewSubmissionsForm

    Private currentSubmissionIndex As Integer = 0
    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0

    Public Sub New(submissions As List(Of Submission))
        InitializeComponent()
        Me.submissions = submissions
        FetchSubmissions() ' Fetch submissions when form is initialized
    End Sub

    Private Async Sub FetchSubmissions()
        Dim client As New HttpClient()

        Try
            Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/submissions")

            If response.IsSuccessStatusCode Then
                Dim json As String = Await response.Content.ReadAsStringAsync()
                submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(json)
                DisplayCurrentSubmission() ' Display the first submission
            Else
                MessageBox.Show("Failed to fetch submissions.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error fetching submissions: {ex.Message}")
        End Try
    End Sub

    Private Sub DisplayCurrentSubmission()
        If submissions.Count > 0 AndAlso currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            Dim submission As Submission = submissions(currentIndex)
            view_name.Text = submission.Name
            view_email.Text = submission.Email
            view_phone.Text = submission.Phone
            view_git.Text = submission.GithubLink
            view_stopwatch.Text = submission.StopwatchTime
        Else
            ' Handle case where there are no submissions
            view_name.Text = ""
            view_email.Text = ""
            view_phone.Text = ""
            view_git.Text = ""
            view_stopwatch.Text = ""
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplayCurrentSubmission() ' Display the next submission
        Else
            MessageBox.Show("No more submissions.")
        End If
    End Sub


    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplayCurrentSubmission() ' Display the previous submission
        Else
            MessageBox.Show("This is the first submission.")
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick() ' Simulate click on the Next button
        End If

        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick() ' Simulate click on the Previous button
        End If

        If e.Control AndAlso e.KeyCode = Keys.D Then
            btnDelete.PerformClick() ' Simulate click on the Delete button
        End If

    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Get the current submission index
        Dim currentIndex As Integer = Me.currentIndex

        ' Confirm deletion
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this submission?", "Confirm Delete", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ' Call the backend API to delete the submission
            Dim apiUrl As String = $"http://localhost:3000/delete?index={currentIndex}"

            Try
                Using client As New HttpClient()
                    Dim response As HttpResponseMessage = Await client.DeleteAsync(apiUrl)

                    If response.IsSuccessStatusCode Then
                        ' Remove the submission from the local list
                        submissions.RemoveAt(currentIndex)

                        ' Adjust currentIndex if needed
                        If currentIndex >= submissions.Count Then
                            currentIndex = submissions.Count - 1
                        End If

                        ' Update the UI
                        Me.currentIndex = currentIndex
                        DisplayCurrentSubmission()

                        MessageBox.Show("Submission deleted successfully.")
                    Else
                        MessageBox.Show("Failed to delete the submission.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Failed to delete the submission: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub UpdateSubmissionForm()
        ' Check if there are any submissions
        If submissions.Count > 0 AndAlso currentSubmissionIndex >= 0 AndAlso currentSubmissionIndex < submissions.Count Then
            ' Get the current submission
            Dim submission As Submission = submissions(currentSubmissionIndex)

            ' Update form controls with the current submission data
            view_name.Text = submission.Name
            view_email.Text = submission.Email
            view_phone.Text = submission.Phone
            view_git.Text = submission.GithubLink
            view_stopwatch.Text = submission.StopwatchTime.ToString()
        Else
            ' If no submissions, clear the form controls
            view_name.Text = String.Empty
            view_email.Text = String.Empty
            view_phone.Text = String.Empty
            view_git.Text = String.Empty
            view_stopwatch.Text = "00:00:00"
        End If
    End Sub




End Class
