Public Class NewOrder

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Me.Hide()
        Checkout.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub NewOrder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Home.Show()
    End Sub
End Class