Public Class AddItemFromRecipe
    Private Sub AddBut_Click(sender As Object, e As EventArgs) Handles AddBut.Click
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

    Private Sub CancelBut_Click(sender As Object, e As EventArgs) Handles CancelBut.Click
        Me.Close()
    End Sub

    Private Sub AddItemFromRecipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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