Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer = 1
        ListBox1.Items.Clear()
        While i * 45 <= 1000
            If i = 11 Then Exit While
            ListBox1.Items.Add(i & "個：" & i * 45 & "円")
            i += 1
        End While
    End Sub
End Class
