Public Class NoteFormat
    Private Sub NoteFormat_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        Dim notepreview = New NoteView
        notepreview.Show()
    End Sub
End Class
