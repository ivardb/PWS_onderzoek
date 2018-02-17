Imports System.Math
Public Class Form1
    Dim goede(19) As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        goede(0) = "verschillend"
        goede(1) = "hetzelfde"
        goede(2) = "hetzelfde"
        goede(3) = "verschillend"
        goede(4) = "verschillend"
        goede(5) = "verschillend"
        goede(6) = "hetzelfde"
        goede(7) = "verschillend"
        goede(8) = "hetzelfde"
        goede(9) = "hetzelfde"
        goede(10) = "hetzelfde"
        goede(11) = "hetzelfde"
        goede(12) = "verschillend"
        goede(13) = "verschillend"
        goede(14) = "hetzelfde"
        goede(15) = "verschillend"
        goede(16) = "hetzelfde"
        goede(17) = "hetzelfde"
        goede(18) = "verschillend"
        goede(19) = "verschillend"
    End Sub

    Private Function checkAnswers(ByVal answers As String())
        Dim total As Integer
        Dim goedFout(19) As Integer
        For i As Integer = 0 To answers.Count - 1
            If answers(i) = goede(i) Then
                total += 1
                goedFout(i) = 1
            Else
                goedFout(i) = 0
            End If
        Next
        lblPercentage.Text = Str(Round(total / 20 * 100)) + "%"
        Return goedFout
    End Function

    Private Sub gemTijd(ByVal tijd As Integer())
        Dim total As Integer
        For Each time As Integer In tijd
            total += time
        Next
        lblGemTijd.Text = Str(total / 20) + " miliseconde"
    End Sub

    Private Sub gemTijdGoed(ByVal tijd As Integer(), ByVal goedFout As Integer())
        Dim goed As Integer
        Dim total As Integer
        Dim index As Integer = 0
        For Each item In goedFout
            If item = 1 Then
                goed += 1
                total += tijd(index)
            End If
            index += 1
        Next
        lblGemTijdGoed.Text = Str(Round(total / goed)) + " miliseconde"
    End Sub

    Private Sub gemTijdFout(ByVal tijd As Integer(), ByVal goedFout As Integer())
        Dim fout As Integer
        Dim total As Integer
        Dim index As Integer = 0
        For Each item In goedFout
            If item = 0 Then
                fout += 1
                total += tijd(index)
            End If
            index += 1
        Next
        lblGemTijdFout.Text = Str(Round(total / fout)) + " miliseconde"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim antwoord(19) As String
        Dim tijd(19) As Integer
        Dim antwoorden() As String = TextBox1.Text.Split(New String() {Environment.NewLine}, StringSplitOptions.None)
        For i As Integer = 0 To antwoorden.Count - 1
            Dim index As Integer = antwoorden(i).IndexOf(" ")
            antwoord(i) = antwoorden(i).Substring(0, index)
            tijd(i) = antwoorden(i).Substring(index + 1)
        Next
        Dim goedFout() As Integer = checkAnswers(antwoord)
        gemTijd(tijd)
        gemTijdGoed(tijd, goedFout)
        gemTijdFout(tijd, goedFout)
    End Sub
End Class
