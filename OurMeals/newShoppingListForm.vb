Public Class newShoppingListForm
    Public listName As String
    Private Sub CreateBut_Click(sender As Object, e As EventArgs) Handles CreateBut.Click
        Dim isValid As Boolean = True

        If String.IsNullOrWhiteSpace(listNameTextbox.Text) Then
            MessageBox.Show("Please enter a list name!")
            isValid = False
        End If

        If Not isValid Then
            Return
        End If

        Me.listName = listNameTextbox.Text

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub CancelBut_Click(sender As Object, e As EventArgs) Handles CancelBut.Click
        Me.Close()
    End Sub
End Class