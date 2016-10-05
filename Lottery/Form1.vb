'Joshua Pickenpaugh
'October 2nd, 2016
'Lottery Number Gen.

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Sub btnSelectNum_Click(sender As Object, e As EventArgs) Handles btnSelectNum.Click

        Dim lotNum As New LotteryNumbers()

        lblLotteryNums.Text = lotNum.GetRandNum()
    End Sub
End Class
