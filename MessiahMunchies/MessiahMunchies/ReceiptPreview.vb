Public Class ReceiptPreview

    Private Sub ReceiptPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim inFile As IO.StreamReader
        Dim order As String

        If IO.File.Exists("orders.txt") Then
            inFile = IO.File.OpenText("orders.txt")
            Do Until inFile.Peek = -1
                order = inFile.ReadLine
                'code what to do with order
            Loop
            inFile.Close()
        Else
            MessageBox.Show("Can't find the eBooks file", "eBooks", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

End Class