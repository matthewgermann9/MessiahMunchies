Imports System.Runtime.Intrinsics

Public Class Home
    Private Sub btnPrevOrders_Click(sender As Object, e As EventArgs) Handles btnPrevOrders.Click
        Me.Hide()
        PrevOrders.Show()
    End Sub

    Public Sub CloseAll()
        Dim OpenForms() As Form = Application.OpenForms.Cast(Of Form).ToArray()
        '.NET LINQ (Language Integrated Query) method ".Cast(Of T)"
        For Each UserForm As Form In OpenForms
            If UserForm IsNot Me Then
                UserForm.Close()
            End If
        Next UserForm
        Me.Close()
    End Sub
End Class
