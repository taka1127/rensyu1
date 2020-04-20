Public Class Form1
    Sub ColorChange(myControl As Control)
        myControl.ForeColor = Color.White
        myControl.BackColor = Color.Black
    End Sub

    Sub WhatTime()
        MessageBox.Show("現在の時刻は、" &
                        DateTime.Now.ToShortTimeString(), "何時？")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ColorChange(sender)
        WhatTime()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WhatTime()
        ColorChange(sender)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ColorChange(sender)
        WhatTime()
    End Sub

End Class
