Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True

        suji1 = Nothing
        suji2 = Nothing
        suji3 = Nothing

    End Sub

    'Random型のオブジェクトmyRandを作成
    Dim myRand As New Random

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '0～9の乱数を発生させ、発生した乱数をLabel1に表示
        Label1.Text = myRand.Next(10)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        '0～9の乱数を発生させ、発生した乱数をLabel2に表示
        Label2.Text = myRand.Next(10)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        '0～9の乱数を発生させ、発生した乱数をLabel3に表示
        Label3.Text = myRand.Next(10)
    End Sub

    Dim suji1, suji2, suji3 As String
    Sub checkSuji()
        If (suji1 = suji2) And (suji1 = suji3) Then
            MessageBox.Show(suji1 & "で揃ったよ！", "スロット")
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        'Timer1のタイマーを止める
        Timer1.Enabled = False

        suji1 = Label1.Text

        checkSuji()

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        'Timer2のタイマーを止める
        Timer2.Enabled = False

        suji2 = Label2.Text

        checkSuji()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        'Timer3のタイマーを止める
        Timer3.Enabled = False

        suji3 = Label3.Text

        checkSuji()

    End Sub


End Class
