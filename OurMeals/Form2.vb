Public Class Form2

    Private shoppingList As ShoppingList

    Public Sub New(shoppingListControl As ShoppingListControl)
        InitializeComponent()
        Me.shoppingList = shoppingListControl.GetShoppingList()
        Me.Text = Me.shoppingList.GetListName()
        Me.ShoppingListName.Text = Me.shoppingList.GetListName()
        PopulateDataGridView()

    End Sub
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim newItemForm As New NewItemForm()

        If newItemForm.ShowDialog() = DialogResult.OK Then

            Dim newItem As New Item(newItemForm.itemName, newItemForm.quantity)

            shoppingList.AddItem(newItem)

            DataGridView1.Rows.Add(newItem.GetItemName(), newItem.GetQuantity(), False)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.ColumnIndex = DataGridView1.Columns("DeleteBut").Index Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DataGridView1.Rows.RemoveAt(e.RowIndex)
                shoppingList.RemoveItem(e.RowIndex)
            End If
        End If

        If e.ColumnIndex = DataGridView1.Columns("PurchasedCheckbox").Index Then
            DataGridView1.Rows(e.RowIndex).Cells("PurchasedCheckbox").Value = shoppingList.changeItemPurchasedStatus(e.RowIndex)
        End If

        If e.ColumnIndex = DataGridView1.Columns("EditBut").Index Then
            Dim editItemForm As New EditItemForm(shoppingList.GetItems()(e.RowIndex))

            If editItemForm.ShowDialog() = DialogResult.OK Then
                Dim item As Item = shoppingList.GetItems()(e.RowIndex)
                item.SetItemName(editItemForm.itemName)
                item.SetQuantity(editItemForm.quantity)
                item.SetPurchased(editItemForm.purchased)
                DataGridView1.Rows(e.RowIndex).Cells("ItemsCol").Value = item.GetItemName()
                DataGridView1.Rows(e.RowIndex).Cells("QuantityCol").Value = item.GetQuantity()
                DataGridView1.Rows(e.RowIndex).Cells("PurchasedCheckbox").Value = item.GetPurchased()
            End If

        End If
    End Sub

    Private Sub PopulateDataGridView()
        DataGridView1.Rows.Clear()

        Dim items = shoppingList.GetItems()

        For Each item As Item In items
            DataGridView1.Rows.Add(item.GetItemName(), item.GetQuantity(), item.GetPurchased())
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ChangeTitleBtn_Click(sender As Object, e As EventArgs) Handles ChangeTitleBtn.Click
        Dim userInput As String
        userInput = InputBox("Please enter what you would like to change the list title to:", "Change Title")

        If Not String.IsNullOrWhiteSpace(userInput) Then
            shoppingList.SetListName(userInput)
            ShoppingListName.Text = shoppingList.GetListName()

            Dim parentControl = CType(Form1.shoppingListArr.Cast(Of ShoppingListControl).FirstOrDefault(Function(ctrl) ctrl.GetShoppingList() Is shoppingList), ShoppingListControl)
            If parentControl IsNot Nothing Then
                parentControl.UpdateTitle()
            End If

            MessageBox.Show($"The title of the shopping list is now {userInput}", "List Title Changed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("List Title was not changed. Ensure non-blank input is given.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ChangeDescriptionBtn_Click(sender As Object, e As EventArgs) Handles ChangeDescriptionBtn.Click
        Dim userInput As String
        userInput = InputBox("Please enter what you would like to change the list description to:", "Change Description")

        If Not String.IsNullOrWhiteSpace(userInput) Then
            shoppingList.changeDescription(userInput)

            Dim parentControl = CType(Form1.shoppingListArr.Cast(Of ShoppingListControl).FirstOrDefault(Function(ctrl) ctrl.GetShoppingList() Is shoppingList), ShoppingListControl)
            If parentControl IsNot Nothing Then
                parentControl.UpdateDescription()
            End If

            MessageBox.Show($"The description of the shopping list is now {userInput}", "List Description Changed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("List Description was not changed. Ensure non-blank input is given.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class