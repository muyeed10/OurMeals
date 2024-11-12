Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Controls.Remove(GroupBox5)
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)
        ComboBox4.BringToFront()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Controls.Remove(GroupBox6)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) 
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Controls.Remove(GroupBox4)
    End Sub
End Class