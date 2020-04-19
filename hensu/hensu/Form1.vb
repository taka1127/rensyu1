Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim moji As String = "赤"
        Label1.Text = moji

        moji = "リンゴ"
        Label2.Text = moji

        moji = moji & TextBox1.Text
        Label3.Text = moji

    End Sub
End Class
