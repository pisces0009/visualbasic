Option Strict On

Public Class Form1

    Private Sub btnScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScore.Click
        Answers()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txt1.Text = String.Empty
        txt2.Text = String.Empty
        txt3.Text = String.Empty
        txt4.Text = String.Empty
        txt5.Text = String.Empty
        txt6.Text = String.Empty
        txt7.Text = String.Empty
        txt8.Text = String.Empty
        txt9.Text = String.Empty
        txt10.Text = String.Empty
        txt11.Text = String.Empty
        txt12.Text = String.Empty
        txt13.Text = String.Empty
        txt14.Text = String.Empty
        txt15.Text = String.Empty
        txt16.Text = String.Empty
        txt17.Text = String.Empty
        txt18.Text = String.Empty
        txt19.Text = String.Empty
        txt20.Text = String.Empty

        lblCorrect.Text = String.Empty
        lblResults.Text = String.Empty
        lblPoF.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Sub Answers()
        Dim strCorrectAnswers() As String = {"B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A"}

        Const intLENGTH As Integer = 19
        Dim strAnswers(intLENGTH) As String
        Dim intStep As Integer
        Dim intCorrect As Integer
        Dim dblTotal As Double
        Dim strPoF As String

        strAnswers(0) = txt1.Text
        strAnswers(1) = txt2.Text
        strAnswers(2) = txt3.Text
        strAnswers(3) = txt4.Text
        strAnswers(4) = txt5.Text
        strAnswers(5) = txt6.Text
        strAnswers(6) = txt7.Text
        strAnswers(7) = txt8.Text
        strAnswers(8) = txt9.Text
        strAnswers(9) = txt10.Text
        strAnswers(10) = txt11.Text
        strAnswers(11) = txt12.Text
        strAnswers(12) = txt13.Text
        strAnswers(13) = txt14.Text
        strAnswers(14) = txt15.Text
        strAnswers(15) = txt16.Text
        strAnswers(16) = txt17.Text
        strAnswers(17) = txt18.Text
        strAnswers(18) = txt19.Text
        strAnswers(19) = txt20.Text


        For intStep = 0 To intLENGTH
            If strAnswers(intStep) = strCorrectAnswers(intStep) Then
                intCorrect = intCorrect + 1
            End If
        Next


        dblTotal = intCorrect / 20

        If dblTotal >= 0.5 Then
            strPoF = "Pass"
        Else
            strPoF = "Fail"
        End If

        lblResults.Text = dblTotal.ToString("P")
        lblCorrect.Text = intCorrect.ToString()
        lblPoF.Text = strPoF.ToString

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub lblPoF_Click(sender As Object, e As EventArgs) Handles lblPoF.Click

    End Sub

    Private Sub lblCorrect_Click(sender As Object, e As EventArgs) Handles lblCorrect.Click

    End Sub

    Private Sub lblResults_Click(sender As Object, e As EventArgs) Handles lblResults.Click

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub
End Class
