<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Checkout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnBack = New Button()
        btnPlaceOrder = New Button()
        Orders = New ListBox()
        txtCheckout = New TextBox()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(133, 323)
        btnBack.Margin = New Padding(1)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(77, 21)
        btnBack.TabIndex = 0
        btnBack.Text = "Go Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnPlaceOrder
        ' 
        btnPlaceOrder.Location = New Point(213, 323)
        btnPlaceOrder.Margin = New Padding(1)
        btnPlaceOrder.Name = "btnPlaceOrder"
        btnPlaceOrder.Size = New Size(77, 21)
        btnPlaceOrder.TabIndex = 1
        btnPlaceOrder.Text = "Place Order"
        btnPlaceOrder.UseVisualStyleBackColor = True
        ' 
        ' Orders
        ' 
        Orders.FormattingEnabled = True
        Orders.ItemHeight = 15
        Orders.Location = New Point(106, 100)
        Orders.Name = "Orders"
        Orders.Size = New Size(226, 184)
        Orders.TabIndex = 2
        ' 
        ' txtCheckout
        ' 
        txtCheckout.Enabled = False
        txtCheckout.Font = New Font("Segoe UI", 15F)
        txtCheckout.Location = New Point(169, 38)
        txtCheckout.Name = "txtCheckout"
        txtCheckout.Size = New Size(100, 34)
        txtCheckout.TabIndex = 3
        txtCheckout.Text = "Checkout"
        txtCheckout.TextAlign = HorizontalAlignment.Center
        ' 
        ' Checkout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(449, 388)
        Controls.Add(txtCheckout)
        Controls.Add(Orders)
        Controls.Add(btnPlaceOrder)
        Controls.Add(btnBack)
        Margin = New Padding(1)
        Name = "Checkout"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Checkout – Messiah Munchies"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnPlaceOrder As Button
    Friend WithEvents Orders As ListBox
    Friend WithEvents txtCheckout As TextBox
End Class
