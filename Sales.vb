Public Class Sales

    Private sales As New List(Of (String, Double, Double, String, String, String, Integer))

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sales.Add(("Milk", 5.99, 6.99, "FreshCo", "123 Mark Street", "06/12/2024", GetCurrentQuantity("Milk")))
        sales.Add(("Apples", 1.99, 2.75, "FreshCo", "123 Mark Street", "06/12/2024", GetCurrentQuantity("Apples")))
        sales.Add(("Blueberries", 1.99, 2.86, "Nofrills", "1 Bae Avenue", "04/12/2024", GetCurrentQuantity("Blueberries")))
        sales.Add(("Bread", 1.25, 2.65, "Shoppers Drug Mart", "39 TMU Way", "09/12/2024", GetCurrentQuantity("Bread")))
        sales.Add(("Sugar", 4.0, 7.76, "Nofrills", "1 Bae Avenue", "04/12/2024", GetCurrentQuantity("Sugar")))
        sales.Add(("Detergent", 3.5, 4.99, "Metro", "613 UI Road", "10/12/2024", GetCurrentQuantity("Detergent")))

        For Each x In sales
            DataGridView1.Rows.Add(x.Item1, x.Item2, x.Item3, x.Item4, x.Item5, x.Item6, x.Item7)
        Next
    End Sub

    Private Function GetCurrentQuantity(itemName As String) As Integer

        For Each x In Form1.fridgeSupplies
            If x.GetItemName() = itemName Then
                Return x.GetQuantity()
            End If
        Next

        Return 0
    End Function

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        DataGridView1.Rows.Clear()

        If CheckBox1.Checked = True Then
            For Each x In sales
                If x.Item7 = 0 Then
                    DataGridView1.Rows.Add(x.Item1, x.Item2, x.Item3, x.Item4, x.Item5, x.Item6, x.Item7)
                End If
            Next
        Else
            For Each x In sales
                DataGridView1.Rows.Add(x.Item1, x.Item2, x.Item3, x.Item4, x.Item5, x.Item6, x.Item7)
            Next
        End If
    End Sub
End Class