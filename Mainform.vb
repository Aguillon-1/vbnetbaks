Public Class Mainform
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Application.Exit()
        End
    End Sub

    Private Sub calendarButton_Click(sender As Object, e As EventArgs) Handles calendarButton.Click
        Calendar1.Show()
        Calendar1.BringToFront()

    End Sub

    Private Sub announcementButton_Click(sender As Object, e As EventArgs) Handles announcementButton.Click
        Announcement1.Show()
        Announcement1.BringToFront()

    End Sub

    Private Sub notesButton_Click(sender As Object, e As EventArgs) Handles notesButton.Click
        Notes1.Show()
        Notes1.BringToFront()

    End Sub

    Private Sub uploadButton_Click(sender As Object, e As EventArgs) Handles uploadButton.Click
        Upload1.Show()
        Upload1.BringToFront()
    End Sub

    Private Sub helpButton_Click(sender As Object, e As EventArgs) Handles helpButton.Click
        Help1.Show()
        Help1.BringToFront()
    End Sub

    Private Sub sectionButton_Click(sender As Object, e As EventArgs) Handles sectionButton.Click
        Section1.Show()
        Section1.BringToFront()
    End Sub
End Class
