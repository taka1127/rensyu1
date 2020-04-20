Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myAry(5) As String

        myAry(0) = "1組"
        myAry(1) = "2組"
        myAry(2) = "3組"
        myAry(3) = "4組"
        myAry(4) = "5組"
        myAry(5) = "6組"

        For i As Integer = 0 To 5
            ListBox1.Items.Add(myAry(i))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim myAry2() As Integer = {35, 32, 40, 38, 36, 39}

        Dim myItem As String, goukei As Integer

        ListBox1.Items.Clear()

        For i As Integer = 0 To myAry2.GetUpperBound(0)

            myItem = (i + 1) & "組：" & myAry2(i) & "人"


            ListBox1.Items.Add(myItem)
            goukei += myAry2(i)
        Next

        MessageBox.Show(goukei & "人", "合計")

    End Sub
End Class
