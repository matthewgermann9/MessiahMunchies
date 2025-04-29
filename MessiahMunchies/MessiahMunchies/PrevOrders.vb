Public Class PrevOrders

    Private Sub btnViewReceipt_Click(sender As Object, e As EventArgs) Handles btnViewReceipt.Click
        ReceiptPreview.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub PrevOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Read from file all past orders
        Dim inFile As IO.StreamReader
        Dim strName As String

        'Clears previous names from the list box
        lstPrevOrders.Items.Clear()

        'Determines whether the file exists
        If IO.File.Exists("orders.txt") Then
            'Opens the file for input
            inFile = IO.File.OpenText("orders.txt")
            'Processes the loop instructions until the end of the file
            Do Until inFile.Peek = -1
                'Reads line of data
                strName = inFile.ReadLine
                'Adds the data to the list box
                lstPrevOrders.Items.Add(strName)
            Loop
            'Closeses the file
            inFile.Close()
        Else
            MessageBox.Show("Previous orders could not be retrieved.", "Error – Messiah Munchies", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lstPrevOrders.Items.Add("Previous orders could Not be retrieved. Please exit and then try again.")
            btnViewReceipt.Enabled = False
        End If
    End Sub

    Private Sub PrevOrders_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Home.Show()
    End Sub
End Class
