<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiptPreview
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
        btnReturn = New Button()
        lblCost = New Label()
        lblDateTime = New Label()
        lblOrder = New Label()
        lblCustomer = New Label()
        lstPrevOrders = New ListBox()
        SuspendLayout()
        ' 
        ' btnReturn
        ' 
        btnReturn.Anchor = AnchorStyles.None
        btnReturn.Location = New Point(345, 489)
        btnReturn.Margin = New Padding(2)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(188, 35)
        btnReturn.TabIndex = 0
        btnReturn.Text = "Return to List"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' lblCost
        ' 
        lblCost.Anchor = AnchorStyles.None
        lblCost.AutoSize = True
        lblCost.Location = New Point(732, 120)
        lblCost.Margin = New Padding(2, 0, 2, 0)
        lblCost.Name = "lblCost"
        lblCost.Size = New Size(90, 25)
        lblCost.TabIndex = 12
        lblCost.Text = "Total Cost"
        ' 
        ' lblDateTime
        ' 
        lblDateTime.Anchor = AnchorStyles.None
        lblDateTime.AutoSize = True
        lblDateTime.Location = New Point(438, 120)
        lblDateTime.Margin = New Padding(2, 0, 2, 0)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(94, 25)
        lblDateTime.TabIndex = 11
        lblDateTime.Text = "Date/Time"
        ' 
        ' lblOrder
        ' 
        lblOrder.Anchor = AnchorStyles.None
        lblOrder.AutoSize = True
        lblOrder.Location = New Point(56, 120)
        lblOrder.Margin = New Padding(2, 0, 2, 0)
        lblOrder.Name = "lblOrder"
        lblOrder.Size = New Size(58, 25)
        lblOrder.TabIndex = 9
        lblOrder.Text = "Order"
        ' 
        ' lblCustomer
        ' 
        lblCustomer.Anchor = AnchorStyles.None
        lblCustomer.AutoSize = True
        lblCustomer.Location = New Point(152, 120)
        lblCustomer.Margin = New Padding(2, 0, 2, 0)
        lblCustomer.Name = "lblCustomer"
        lblCustomer.Size = New Size(89, 25)
        lblCustomer.TabIndex = 10
        lblCustomer.Text = "Customer"
        ' 
        ' lstPrevOrders
        ' 
        lstPrevOrders.Anchor = AnchorStyles.None
        lstPrevOrders.Font = New Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstPrevOrders.FormattingEnabled = True
        lstPrevOrders.ItemHeight = 20
        lstPrevOrders.Location = New Point(59, 147)
        lstPrevOrders.Margin = New Padding(2)
        lstPrevOrders.Name = "lstPrevOrders"
        lstPrevOrders.Size = New Size(756, 284)
        lstPrevOrders.TabIndex = 8
        ' 
        ' ReceiptPreview
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(878, 644)
        Controls.Add(lblCost)
        Controls.Add(lblDateTime)
        Controls.Add(lblOrder)
        Controls.Add(lblCustomer)
        Controls.Add(lstPrevOrders)
        Controls.Add(btnReturn)
        Margin = New Padding(2)
        Name = "ReceiptPreview"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Receipt Preview – Messiah Munchies"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents lblCost As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents lblOrder As Label
    Friend WithEvents lblCustomer As Label
    Friend WithEvents lstPrevOrders As ListBox
End Class
