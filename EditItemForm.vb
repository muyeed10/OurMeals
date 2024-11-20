Public Class EditItemForm

    Public itemName As String
    Public quantity As String
    Public purchased As Boolean

    Public Sub New(item As Item)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.itemName = item.GetItemName()
        Me.quantity = item.GetQuantity()
        Me.purchased = item.GetPurchased()

        itemNameTextbox.Text = Me.itemName
        quantityBox.Value = Me.quantity
        CheckBox.Checked = Me.purchased

        Me.Text = "Editing Item " + item.GetItemName()

    End Sub
    Private Sub ConfirmBut_Click(sender As Object, e As EventArgs) Handles ConfirmBut.Click
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
        Me.purchased = CheckBox.Checked

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub CancelBut_Click(sender As Object, e As EventArgs) Handles CancelBut.Click
        Me.Close()
    End Sub
End Class