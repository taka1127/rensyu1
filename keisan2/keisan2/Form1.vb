Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ans As Integer = Integer.Parse(TextBox1.Text) + Integer.Parse(TextBox2.Text)

        MessageBox.Show(ans, "合計")
    End Sub
End Class
