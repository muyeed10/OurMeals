Public Class AddItemFromSupply
    Private Sub ItemNameLabel_Click(sender As Object, e As EventArgs) Handles ItemNameLabel.Click

    End Sub

    Private Sub AddSupButton2_Click(sender As Object, e As EventArgs) Handles AddSupButton2.Click
        If quantityBox.Value < 1 Then
            MessageBox.Show("Invalid Quantity. Please ensure quantity is at least 1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            For Each shoppingListControl As ShoppingListControl In Form1.shoppingListArr
                If shoppingListControl.GetShoppingList().GetListName() = ComboBox1.SelectedItem.ToString() Then

                    Dim shoppingList As ShoppingList = shoppingListControl.GetShoppingList()
                    shoppingList.AddItem(New Item(ItemNameLabel.Text, quantityBox.Value))

                    Form1.DisplayItemsInForm()
                    MessageBox.Show($"Item '{ItemNameLabel.Text}' with quantity '{quantityBox.Value}' added to '{shoppingListControl.GetShoppingList().GetListName()}'.", "Item Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            Next
        End If
    End Sub

    Private Sub Canceling_Click(sender As Object, e As EventArgs) Handles Canceling.Click
        Me.Close()
    End Sub

    Private Sub AddItemFromSupply_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()

        For Each shoppingListControl As ShoppingListControl In Form1.shoppingListArr
            ComboBox1.Items.Add(shoppingListControl.GetShoppingList().GetListName())
        Next

        If ComboBox1.Items.Count > 0 Then
            ComboBox1.SelectedIndex = 0
        End If
    End Sub

    Public Sub DefaultInputs(Item As String, Quantity As String)
        quantityBox.Value = Int(Quantity)
        ItemNameLabel.Text = Item
    End Sub
End Class