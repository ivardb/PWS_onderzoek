Public Class FormLast
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        FormMenu.Show()
    End Sub

    Private Sub FormLast_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub
End Class