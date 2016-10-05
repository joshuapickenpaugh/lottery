Public Class LotteryNumbers

    Private _intRandomNum As Integer

    Public Function GetRandNum() As Integer

        'I know, I know, this is really verbose and akward, but whatever...:
        Dim randGen As New Random

        _intRandomNum = randGen.Next(1, 54)

        Return _intRandomNum

    End Function

End Class
