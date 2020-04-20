Public Class Form1
    Function BMI(height As Double, weight As Double) As String
        Dim ans As Double
        Dim msg As String
        ans = weight / height / height
        Select Case ans
            Case >= 30
                msg = "：超肥満です"
            Case >= 25
                msg = "：肥満です"
            Case >= 18.5
                msg = "：標準"
            Case Else
                msg = "：痩せすぎです"
        End Select

        Return "BMI値：" & ans.ToString("##.0") & msg

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Label2.Text = BMI(1.67, 52)
        Label4.Text = BMI(1.82, 76)

    End Sub
End Class
