Imports System.Runtime.Intrinsics

Public Class Home
    Private Sub btnPrevOrders_Click(sender As Object, e As EventArgs) Handles btnPrevOrders.Click
        Me.Hide()
        PrevOrders.Show()
    End Sub
    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        Me.Hide()
        NewOrder.Show()
    End Sub

End Class
