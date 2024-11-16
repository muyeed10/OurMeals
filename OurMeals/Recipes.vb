Public Class Recipes
    Private Sub Recipes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Add("Alfredo Pasta")
        DataGridView1.Rows.Add("Pumpkin Pie")
        DataGridView1.Columns("RecipeView").DefaultCellStyle.NullValue = "Click To View"
        DataGridView1.Columns("Items").DefaultCellStyle.NullValue = "Click To View"
        DataGridView1.Columns("CreateList").DefaultCellStyle.NullValue = "Click To Create"
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.ColumnIndex = DataGridView1.Columns("RecipeView").Index Then
            Dim recipeName As String = DataGridView1.Rows(e.RowIndex).Cells("RecipeName").Value.ToString()
            ShowRecipe(recipeName)
        End If

        If e.ColumnIndex = DataGridView1.Columns("Items").Index Then
            Dim recipeName As String = DataGridView1.Rows(e.RowIndex).Cells("RecipeName").Value.ToString()
            RecipeItems.Show()
            RecipeItems.LoadDetails(recipeName)
        End If

        If e.ColumnIndex = DataGridView1.Columns("CreateList").Index Then
            Dim recipeName As String = DataGridView1.Rows(e.RowIndex).Cells("RecipeName").Value.ToString()
            CreateNewList(recipeName)
        End If

    End Sub

    Public Sub ShowRecipe(recipe As String)

        If recipe = "Alfredo Pasta" Then
            Dim recipeName As String = "Alfredo Pasta"
            Dim recipeDetails As String = "Here's the recipe for Alfredo Pasta:" & vbCrLf & vbCrLf &
                                          "1. Cook 200g of fettuccine according to the package instructions." & vbCrLf &
                                          "2. In a pan, melt 2 tablespoons of butter over medium heat, then stir in 1 cup of cream." & vbCrLf &
                                          "3. Let it simmer for 2 minutes, then add 1 cup of grated Parmesan cheese and stir until the sauce thickens." & vbCrLf &
                                          "4. Season with salt, pepper, and a pinch of garlic powder." & vbCrLf &
                                          "5. Toss the cooked pasta in the sauce, garnish with parsley if desired, and serve warm."

            MessageBox.Show(recipeDetails, $"Recipe: {recipeName}", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf recipe = "Pumpkin Pie" Then
            Dim recipeName As String = "Pumpkin Pie"
            Dim recipeDetails As String = "Here's the recipe for Pumpkin Pie:" & vbCrLf & vbCrLf &
                                          "1. Preheat the oven to 375°F (190°C)." & vbCrLf &
                                          "2. In a bowl, mix the following ingredients:" & vbCrLf &
                                          "   - 1 can (15 oz) of pumpkin puree" & vbCrLf &
                                          "   - 1 cup of heavy cream" & vbCrLf &
                                          "   - 2 eggs" & vbCrLf &
                                          "   - 1/2 cup of sugar" & vbCrLf &
                                          "   - 1 teaspoon of cinnamon" & vbCrLf &
                                          "   - A pinch of nutmeg and salt" & vbCrLf &
                                          "3. Pour the mixture into a 9-inch pie crust." & vbCrLf &
                                          "4. Bake for 45-50 minutes, or until the filling is set." & vbCrLf &
                                          "5. Let it cool before serving, and top with whipped cream if desired."

            MessageBox.Show(recipeDetails, $"Recipe: {recipeName}", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Public Sub CreateNewList(RecipeName As String)

        If RecipeName = "Alfredo Pasta" Then
            Dim alfredoPasta As New ShoppingList("Alfredo Pasta List")
            alfredoPasta.AddItem(New Item("Fettucine Pasta", 1))
            alfredoPasta.AddItem(New Item("Butter", 2))
            alfredoPasta.AddItem(New Item("Cream", 2))
            alfredoPasta.AddItem(New Item("Parmesan Cheese", 1))
            alfredoPasta.AddItem(New Item("Salt", 1))
            alfredoPasta.AddItem(New Item("Pepper", 1))
            alfredoPasta.AddItem(New Item("Garlic Powder", 1))
            alfredoPasta.AddItem(New Item("Parsley", 1))
            Form1.AddShoppingListControl(alfredoPasta)
        ElseIf RecipeName = "Pumpkin Pie" Then
            Dim pumpkinPie As New ShoppingList("Pumkpin Pie List")
            pumpkinPie.AddItem(New Item("Pumpkin Puree", 1))
            pumpkinPie.AddItem(New Item("Heavy Cream", 1))
            pumpkinPie.AddItem(New Item("Eggs", 2))
            pumpkinPie.AddItem(New Item("Sugar", 1))
            pumpkinPie.AddItem(New Item("Cinnamon", 1))
            pumpkinPie.AddItem(New Item("Salt", 1))
            pumpkinPie.AddItem(New Item("Nutmeg", 1))
            pumpkinPie.AddItem(New Item("Whipped Cream", 1))
            Form1.AddShoppingListControl(pumpkinPie)
        End If

    End Sub

End Class