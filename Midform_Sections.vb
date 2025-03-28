Imports System.Runtime.CompilerServices

Public Class Midform_Sections
    Private Sub SectionFormat1_Load(sender As Object, e As EventArgs) Handles SectionFormat1.Load

    End Sub

    Private Sub SectionFormat1_MouseClick(sender As Object, e As MouseEventArgs) Handles SectionFormat1.MouseClick
        Dim main = New Mainform()
        main.Show()
        Dim mid = New MidForm
        mid.Close()
    End Sub
End Class
