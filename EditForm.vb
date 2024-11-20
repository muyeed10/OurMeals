Public Class EditForm
    Public itemName As String
    Public quantity As String

    Public Sub New(item As Item)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.itemName = item.GetItemName()
        Me.quantity = item.GetQuantity()
        itemnameinput.Text = Me.itemName
        quantityinput.Value = Me.quantity
        Me.Text = "Editing Item " + item.GetItemName()
    End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
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

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class