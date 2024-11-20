Public Class AddForm
    Public itemName As String
    Public quantity As Integer

    Private Sub AddConfirm_Click(sender As Object, e As EventArgs) Handles AddConfirm.Click
        Dim isValid As Boolean = True

        If String.IsNullOrWhiteSpace(itemnameinput.Text) Then
            MessageBox.Show("Please enter an item name!")
            isValid = False
        End If

        If quantityinput.Value < 0 Or quantityinput.Value > 100 Then
            MessageBox.Show("Please enter item quantity within 0-100 range")
            isValid = False
        End If

        If Not isValid Then
            Return
        End If

        Me.itemName = itemnameinput.Text
        Me.quantity = quantityinput.Value

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub CancelConfirm_Click(sender As Object, e As EventArgs) Handles CancelConfirm.Click
        Me.Close()
    End Sub

    Private Sub AddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class