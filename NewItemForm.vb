Public Class NewItemForm
    Public itemName As String
    Public quantity As Integer

    Private Sub AddBut_Click(sender As Object, e As EventArgs) Handles AddBut.Click
        Dim isValid As Boolean = True

        If String.IsNullOrWhiteSpace(itemNameTextbox.Text) Then
            MessageBox.Show("Please enter an item name!")
            isValid = False
        End If

        If quantityBox.Value < 0 Or quantityBox.Value > 100 Then
            MessageBox.Show("Please enter item quantity within 0-100 range")
            isValid = False
        End If

        If Not isValid Then
            Return
        End If

        Me.itemName = itemNameTextbox.Text
        Me.quantity = quantityBox.Value

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub CancelBut_Click(sender As Object, e As EventArgs) Handles CancelBut.Click
        Me.Close()
    End Sub
End Class