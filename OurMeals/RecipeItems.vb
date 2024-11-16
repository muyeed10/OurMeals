Public Class RecipeItems

    Private Sub RecipeItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Columns("AddItem").DefaultCellStyle.NullValue = "Click To Add"
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = DataGridView1.Columns("AddItem").Index Then
            Dim itemName As String = DataGridView1.Rows(e.RowIndex).Cells("Item").Value.ToString()
            Dim quantity As String = DataGridView1.Rows(e.RowIndex).Cells("Quantity").Value.ToString()
            AddItemFromRecipe.Show()
            AddItemFromRecipe.DefaultInputs(itemName, quantity)
        End If
    End Sub

    Public Sub LoadDetails(RecipeName As String)
        RecipeNameLabel.Text = RecipeName + " List"

        If RecipeName = "Alfredo Pasta" Then
            DataGridView1.Rows.Add("Fettucine Pasta", "1")
            DataGridView1.Rows.Add("Butter", "2")
            DataGridView1.Rows.Add("Cream", "2")
            DataGridView1.Rows.Add("Parmesan Cheese", "1")
            DataGridView1.Rows.Add("Salt", "1")
            DataGridView1.Rows.Add("Pepper", "1")
            DataGridView1.Rows.Add("Garlic Powder", "1")
            DataGridView1.Rows.Add("Parsley", "1")
        ElseIf RecipeName = "Pumpkin Pie" Then
            DataGridView1.Rows.Add("Pumpkin Puree", "1")
            DataGridView1.Rows.Add("Heavy Cream", "1")
            DataGridView1.Rows.Add("Eggs", "2")
            DataGridView1.Rows.Add("Sugar", "1")
            DataGridView1.Rows.Add("Cinnamon", "1")
            DataGridView1.Rows.Add("Salt", "1")
            DataGridView1.Rows.Add("Nutmeg", "1")
            DataGridView1.Rows.Add("Whipped Cream", "1")
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub

    Public Sub AddItemToList(Item As String, Quantity As String)

    End Sub


End Class