Public Class ShoppingList
    Private listName As String
    Private itemArr As New ArrayList()

    Public Sub New(listName As String, Optional itemArr As ArrayList = Nothing)
        Me.listName = listName

        If itemArr Is Nothing Then
            Me.itemArr = New ArrayList()
        Else
            Me.itemArr = itemArr
        End If
    End Sub

    Public Function GetListName() As String
        Return listName
    End Function

    Public Sub SetListName(value As String)
        listName = value
    End Sub

    Public Sub AddItem(newItem As Item)
        itemArr.Add(newItem)
    End Sub

    Public Function GetItems() As ArrayList
        Return itemArr
    End Function

    Public Sub RemoveItem(index As Integer)
        If index >= 0 AndAlso index < itemArr.Count Then
            itemArr.RemoveAt(index)
        End If
    End Sub

    Public Sub ChangeItemQuantity(index As Integer, value As Integer)
        If index >= 0 AndAlso index < itemArr.Count Then
            itemArr(index).SetQuantity(value)
        End If
    End Sub

    Public Function changeItemPurchasedStatus(index As Integer)
        If index >= 0 AndAlso index < itemArr.Count Then
            If itemArr(index).GetPurchased() = True Then
                itemArr(index).SetPurchased(False)
                Return False
            Else
                itemArr(index).SetPurchased(True)
                Return True
            End If
        End If
        Return False
    End Function
End Class
