Public Class Form1

    'shoppinglistArr contains ShoppingListControls which contains ShoppingList object that contains listname, array of Items Object
    Public shoppingListArr As New ArrayList

    'Private shoppingListDict As New Dictionary(Of ShoppingListControl, ShoppingList)

    Public Sub New()
        InitializeComponent()

        'default grocery list instances below
        CreateDefaultShoppingLists()
    End Sub

    Private Sub CreateNewBut_Click(sender As Object, e As EventArgs) Handles CreateNewBut.Click
        Dim newShoppingListForm As New newShoppingListForm()

        If newShoppingListForm.ShowDialog() = DialogResult.OK Then

            Dim newShoppingList As New ShoppingList(newShoppingListForm.listName)

            Dim newShoppingListControl As New ShoppingListControl(Me, newShoppingList)

            Dim xCord = 8
            Dim yCord = If(shoppingListArr.Count > 0, shoppingListArr(shoppingListArr.Count - 1).Location.Y + shoppingListArr(shoppingListArr.Count - 1).Height + 10, 8)

            newShoppingListControl.SetLocation(New Point(xCord, yCord))

            Me.shoppingListArr.Add(newShoppingListControl)
            'Me.shoppingListDict.Add(newShoppingListControl, newShoppingList)

            DisplayItemsInForm()
        End If
    End Sub

    Public Sub AddShoppingListControl(shoppingList As ShoppingList)
        Dim shoppingListControl As New ShoppingListControl(Me, shoppingList)

        Dim xCord = 8
        Dim yCord = If(shoppingListArr.Count > 0, shoppingListArr(shoppingListArr.Count - 1).Location.Y + shoppingListArr(shoppingListArr.Count - 1).Height + 10, 8)

        shoppingListControl.SetLocation(New Point(xCord, yCord))

        shoppingListArr.Add(shoppingListControl)

        shoppingListControl.UpdateRoutineIndicator()
        DisplayItemsInForm()
    End Sub

    Public Sub DisplayItemsInForm()
        ListPanel.Controls.Clear()

        For Each list As ShoppingListControl In shoppingListArr
            If list IsNot Nothing Then
                ListPanel.Controls.Add(list)
            End If
        Next
    End Sub

    'helper function to adjust the positons of the shoppingList extended control after deletion of some list
    Private Sub UpdateItemPositions()
        Dim yCord As Integer = 8

        For Each list As ShoppingListControl In shoppingListArr
            list.SetLocation(New Point(8, yCord))
            yCord += list.Height + 10
        Next
    End Sub

    'method to remove the shopping list/grocery list
    Public Sub RemoveShoppingListControl(controlToRemove As ShoppingListControl)

        shoppingListArr.Remove(controlToRemove)
        'shoppingListDict.Remove(controlToRemove)

        UpdateItemPositions()
        DisplayItemsInForm()
    End Sub

    'Method to view the contents of the shopping list
    Public Sub ViewList(shoppingListControlToView As ShoppingListControl)
        Dim newForm As New Form2(shoppingListControlToView)
        newForm.Show()
    End Sub

    'Method to create default shopping lists and add them to the form dynamically
    Private Sub CreateDefaultShoppingLists()

        'Creating some default shopping lists
        Dim weeklyList As New ShoppingList("Weekly Grocery List")
        weeklyList.AddItem(New Item("Milk", 2))
        weeklyList.AddItem(New Item("Eggs", 12))
        weeklyList.AddItem(New Item("Bread", 1))
        weeklyList.changeRoutine()

        Dim bakingList As New ShoppingList("Baking Supplies")
        bakingList.AddItem(New Item("Flour", 1))
        bakingList.AddItem(New Item("Sugar", 1))
        bakingList.AddItem(New Item("Baking Soda", 1))

        Dim meatList As New ShoppingList("Meat Purchases")
        meatList.AddItem(New Item("Chicken Breast", 3))
        meatList.AddItem(New Item("Ground Beef", 2))

        'Creating ShoppingListControl for each list and add to the shoppingListArr
        AddShoppingListControl(weeklyList)
        AddShoppingListControl(bakingList)
        AddShoppingListControl(meatList)
    End Sub

    Private Sub RecipesButton_Click(sender As Object, e As EventArgs) Handles RecipesButton.Click
        Recipes.Show()
    End Sub
End Class
