Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        'ボタンをクリックしたときの処理
        Label1.Text = "VBの世界へようこそ" 'ラベルに表示する文字設定
        Label1.BackColor = Color.Black
        Label1.ForeColor = Color.White
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Move(sender As Object, e As EventArgs) Handles MyBase.Move

    End Sub
End Class
