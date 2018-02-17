Public Class FormMenu
    Private Sub FormMenu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class