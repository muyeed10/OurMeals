
Public Class FridgeForm

    Private Sub Fridge_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles FridgeInventory.CellContentClick

        If FridgeInventory.Columns(e.ColumnIndex).Name = "RemoveItem" Then
            Dim selectedRow As DataGridViewRow = FridgeInventory.Rows(e.RowIndex)
            Dim itemName As String = selectedRow.Cells("itemName").Value.ToString()
            Dim itemQuantity As String = selectedRow.Cells("Quantity").Value.ToString()
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                FridgeInventory.Rows.Remove(selectedRow)
            End If
        End If

        If FridgeInventory.Columns(e.ColumnIndex).Name = "EditItem" Then
            Dim rowIndex As Integer = e.RowIndex
            Dim currentItem As Item = Form1.fridgeSupplies(rowIndex) ' Fetch the corresponding item from the collection

            Dim editItemForm As New EditForm(currentItem)
            If editItemForm.ShowDialog() = DialogResult.OK Then
                currentItem.SetItemName(editItemForm.itemName)
                currentItem.SetQuantity(editItemForm.quantity)

                FridgeInventory.Rows(rowIndex).Cells("itemName").Value = currentItem.GetItemName()
                FridgeInventory.Rows(rowIndex).Cells("Quantity").Value = currentItem.GetQuantity()
            End If
        End If

        If FridgeInventory.Columns(e.ColumnIndex).Name = "AddItemFrom" Then
            Dim itemName As String = FridgeInventory.Rows(e.RowIndex).Cells("itemName").Value.ToString()
            Dim quantity As String = FridgeInventory.Rows(e.RowIndex).Cells("Quantity").Value.ToString()
            AddItemFromFridge.Show()
            AddItemFromFridge.DefaultInputs(itemName, quantity)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each x In Form1.fridgeSupplies
            FridgeInventory.Rows.Add(x.GetItemName, x.GetQuantity)
        Next

        For Each x In Form1.otherSupplies
            Supplies.Rows.Add(x.GetItemName, x.GetQuantity)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddItem.Click
        Dim newItemForm As New AddForm()

        If newItemForm.ShowDialog() = DialogResult.OK Then

            Dim newItem As New Item(newItemForm.itemName, newItemForm.quantity)

            Form1.fridgeSupplies.Add(newItem)
            FridgeInventory.Rows.Add(newItem.GetItemName(), newItem.GetQuantity())
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Backkk.Click
        Me.Hide()
    End Sub

    Private Sub AddSupply_Click(sender As Object, e As EventArgs) Handles AddSupply.Click
        Dim newItemForm As New AddForm()

        If newItemForm.ShowDialog() = DialogResult.OK Then

            Dim newItem As New Item(newItemForm.itemName, newItemForm.quantity)

            Form1.otherSupplies.Add(newItem)
            Supplies.Rows.Add(newItem.GetItemName(), newItem.GetQuantity())
        End If
    End Sub

    Private Sub Supplies_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Supplies.CellContentClick
        If Supplies.Columns(e.ColumnIndex).Name = "RemoveSupply" Then
            Dim selectedRow As DataGridViewRow = Supplies.Rows(e.RowIndex)
            Dim itemName As String = selectedRow.Cells("Item").Value.ToString()
            Dim itemQuantity As String = selectedRow.Cells("QuantitySupplies").Value.ToString()
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Supplies.Rows.Remove(selectedRow)
            End If
        End If

        If Supplies.Columns(e.ColumnIndex).Name = "EditSupply" Then
            Dim rowIndex As Integer = e.RowIndex
            Dim currentItem As Item = Form1.otherSupplies(rowIndex) ' Fetch the corresponding item from the collection

            Dim editItemForm As New EditForm(currentItem)
            If editItemForm.ShowDialog() = DialogResult.OK Then
                currentItem.SetItemName(editItemForm.itemName)
                currentItem.SetQuantity(editItemForm.quantity)

                Supplies.Rows(rowIndex).Cells("Item").Value = currentItem.GetItemName()
                Supplies.Rows(rowIndex).Cells("QuantitySupplies").Value = currentItem.GetQuantity()
            End If
        End If

        If Supplies.Columns(e.ColumnIndex).Name = "AddSupFrom" Then
            Dim itemName As String = Supplies.Rows(e.RowIndex).Cells("Item").Value.ToString()
            Dim quantity As String = Supplies.Rows(e.RowIndex).Cells("QuantitySupplies").Value.ToString()
            AddItemFromSupply.Show()
            AddItemFromSupply.DefaultInputs(itemName, quantity)
        End If
    End Sub

    Private Sub CreateListBtn_Click(sender As Object, e As EventArgs) Handles CreateListBtn.Click
        Dim newList As New ShoppingList("Missing Supplies")

        For Each x In Form1.fridgeSupplies
            If x.GetQuantity < 1 Then
                newList.AddItem(New Item(x.GetItemName, 1))
            End If
        Next

        For Each x In Form1.otherSupplies
            If x.GetQuantity < 1 Then
                newList.AddItem(New Item(x.GetItemName, 1))
            End If
        Next

        Form1.AddShoppingListControl(newList)
    End Sub

    Private Sub FindSales_Click(sender As Object, e As EventArgs) Handles FindSales.Click
        Sales.Show()
    End Sub
End Class
