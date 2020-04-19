Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label2.Text = DateTime.Now.ToString("yyyy年MM月dd日(dddd)")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim myYear, myMonth, myDay As Integer
        Dim myDate As DateTime
        Try
            myYear = Integer.Parse(ComboBox1.Text)
            myMonth = Integer.Parse(ComboBox2.Text)
            myDay = Integer.Parse(ComboBox3.Text)

            myDate = New DateTime(myYear, myMonth, myDay)

            Label7.Text = myDate.ToLongDateString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "エラーです。")

        End Try

    End Sub
End Class
