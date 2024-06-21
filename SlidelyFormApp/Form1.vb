Public Class Form1

    Private submissions As New List(Of Submission)
    Private viewSubmissionsForm As ViewSubmissionsForm

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        viewSubmissionsForm = New ViewSubmissionsForm(submissions)
        viewSubmissionsForm.Show()
    End Sub


    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createForm As New CreateSubmissionForm(submissions)
        createForm.Show()
    End Sub

    Private Sub btnViewSubmissions_Paint(sender As Object, e As PaintEventArgs) Handles btnViewSubmissions.Paint
        ' Clear the background to avoid overdraw issues
        e.Graphics.Clear(btnViewSubmissions.BackColor)

        ' Define a smaller border radius for less curve
        Dim borderRadius As Integer = 5 ' Adjust this value for less curve

        ' Create a path with rounded corners
        Dim path As New Drawing2D.GraphicsPath()
        Dim rect As New Rectangle(0, 0, btnViewSubmissions.Width - 1, btnViewSubmissions.Height - 1)
        Dim radius As Integer = borderRadius * 2

        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()

        ' Fill the button background
        Using brush As New SolidBrush(btnViewSubmissions.BackColor)
            e.Graphics.FillPath(brush, path)
        End Using

        ' Draw border around the button
        Using pen As New Pen(Color.Black, 1) ' Adjust color and width as needed
            e.Graphics.DrawPath(pen, path)
        End Using

        ' Draw the button text
        TextRenderer.DrawText(e.Graphics, btnViewSubmissions.Text, btnViewSubmissions.Font, rect, btnViewSubmissions.ForeColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub

    Private Sub btnCreateSubmission_Paint(sender As Object, e As PaintEventArgs) Handles btnCreateSubmission.Paint
        ' Clear the background to avoid overdraw issues
        e.Graphics.Clear(btnCreateSubmission.BackColor)

        ' Define a smaller border radius for less curve
        Dim borderRadius As Integer = 5 ' Adjust this value for less curve

        ' Create a path with rounded corners
        Dim path As New Drawing2D.GraphicsPath()
        Dim rect As New Rectangle(0, 0, btnCreateSubmission.Width - 1, btnCreateSubmission.Height - 1)
        Dim radius As Integer = borderRadius * 2

        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()

        ' Fill the button background
        Using brush As New SolidBrush(btnCreateSubmission.BackColor)
            e.Graphics.FillPath(brush, path)
        End Using

        ' Draw border around the button
        Using pen As New Pen(Color.Black, 1) ' Adjust color and width as needed
            e.Graphics.DrawPath(pen, path)
        End Using

        ' Draw the button text
        TextRenderer.DrawText(e.Graphics, btnCreateSubmission.Text, btnCreateSubmission.Font, rect, btnCreateSubmission.ForeColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Check for Ctrl + V shortcut
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ' Simulate click on the View Submissions button
            btnViewSubmissions.PerformClick()
        End If

        ' Check for Ctrl + N shortcut
        If e.Control AndAlso e.KeyCode = Keys.N Then
            ' Simulate click on the Create Submission button
            btnCreateSubmission.PerformClick()
        End If
    End Sub


End Class
