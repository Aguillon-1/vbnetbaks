Public Class MidForm
    Private Sub sectionButton_Click(sender As Object, e As EventArgs) Handles sectionButton.Click
        Sections1.Show()
        Sections1.BringToFront()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Application.Exit()
    End Sub
End Class