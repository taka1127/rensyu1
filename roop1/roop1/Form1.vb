Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        For i As Integer = 1 To 5
            ListBox1.Items.Add(i & "個：" & i * 45 & "円")
        Next
    End Sub
End Class
