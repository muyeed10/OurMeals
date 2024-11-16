Public Class Item
    Private itemName As String
    Private quantity As Integer
    Private purchased As Boolean

    Public Sub New(itemName As String, Optional quantity As Integer = 1, Optional purchased As Boolean = False)
        Me.itemName = itemName
        Me.quantity = quantity
        Me.purchased = purchased
    End Sub

    Public Function GetItemName() As String
        Return itemName
    End Function

    Public Sub SetItemName(value As String)
        itemName = value
    End Sub

    Public Function GetQuantity() As Integer
        Return quantity
    End Function

    Public Sub SetQuantity(value As Integer)
        quantity = value
    End Sub

    Public Function GetPurchased() As Boolean
        Return purchased
    End Function

    Public Sub SetPurchased(value As Boolean)
        purchased = value
    End Sub

End Class
