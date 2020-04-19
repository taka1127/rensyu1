Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ans As Integer = TextBox1.Text + TextBox2.Text

        MessageBox.Show(ans, "合計")
    End Sub
End Class