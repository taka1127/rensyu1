Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x1, x2 As Boolean
        x1 = 10 > 20 And 20 < 40
        x2 = 10 < 20 Or 20 < 40
        MessageBox.Show(x1, "条件式10>20 And 20 < 40の結果")
        MessageBox.Show(x2, "条件式10<20 Or 20 < 40の結果")
    End Sub
End Class
