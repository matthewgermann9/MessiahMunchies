Public Class Checkout

    Private cart As New List(Of CartItem)

    Private Sub Checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cart.Add(New CartItem With {.Name = "Item 1", .Quantity = 2, .Price = 5.99D})
        cart.Add(New CartItem With {.Name = "Item 2", .Quantity = 1, .Price = 10D})
        cart.Add(New CartItem With {.Name = "Item 3", .Quantity = 3, .Price = 2.5D})

        FillListBox()
    End Sub

    Private Sub FillListBox()
        Orders.Items.Clear()
        Orders.Items.Add("Item".PadRight(15) & "Quantity".PadRight(10) & "Price")
        Orders.Items.Add(New String("-"c, 35))

        For Each item As CartItem In cart
            Orders.Items.Add(item.ToString())
        Next
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim newOrderForm As New NewOrder()
        newOrderForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        Dim homeForm As New Home()
        homeForm.Show()
        Me.Hide()
    End Sub

End Class

Public Class CartItem

    Public Property Name As String
    Public Property Quantity As Integer
    Public Property Price As Decimal

    Public Overrides Function ToString() As String
        Return Name.PadRight(15) & Quantity.ToString().PadRight(10) & Price.ToString("C2")
    End Function
End Class

