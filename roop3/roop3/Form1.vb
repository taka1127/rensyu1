Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For Each myControl As Control In Controls

            If TypeOf myControl Is TextBox Then

                myControl.Text = ""

            End If

        Next

    End Sub
End Class
