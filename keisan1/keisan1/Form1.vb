Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ans1, ans2, ans3, ans5, ans7 As Integer
        Dim ans4, ans6, ans8 As Double
        ans1 = 3 + 4
        ans2 = 3 - 4
        ans3 = 3 * 4
        ans4 = 3 / 4
        ans5 = 3 \ 4
        ans6 = 3 Mod 4
        ans7 = 2 ^ 4

        MessageBox.Show("3 + 4=" & ans1, "足し算")
        MessageBox.Show("3 - 4=" & ans2, "引き算")
        MessageBox.Show("3 * 4=" & ans3, "掛け算")
        MessageBox.Show("3 / 4=" & ans4, "割り算")
        MessageBox.Show("3 \ 4=" & ans5, "割り算の商")
        MessageBox.Show("3 Mod 4=" & ans6, "割り算の余り")
        MessageBox.Show("2 ^ 4=" & ans7, "べき乗")

        ans8 = (182 - 100) * 0.9
        MessageBox.Show("身長182cmの標準体重：" & ans8, "標準体重")

    End Sub
End Class
