Imports System.Net.Mail

Public Class Form1
    Dim pictureNumber = 0
    Dim resultaat As String

    Dim stopwatch As New Stopwatch()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadPictures()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        hetzelfde()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        verschillend()
    End Sub

    Private Sub hetzelfde()
        Dim time = stopwatch.ElapsedMilliseconds()
        resultaat += "hetzelfde" + Str(time) + vbNewLine
        loadPictures()
    End Sub

    Private Sub verschillend()
        Dim time = stopwatch.ElapsedMilliseconds()
        resultaat += "verschillend " + Str(time) + vbNewLine
        loadPictures()
    End Sub

    Private Sub loadPictures()
        If pictureNumber < ImageList1.Images.Count Then
            PictureBox1.Image = ImageList1.Images.Item(pictureNumber)
            PictureBox2.Image = ImageList1.Images.Item(pictureNumber + 1)
            pictureNumber += 2
            stopwatch.Restart()
        Else
            stopwatch.Reset()
            MsgBox(resultaat)
            FormLast.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub
End Class
