Public Class FridgeView
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub FridgeView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = My.Resources.fridgeview
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
End Class