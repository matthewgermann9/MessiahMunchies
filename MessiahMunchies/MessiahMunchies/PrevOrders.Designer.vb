<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrevOrders
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
        lstPrevOrders = New ListBox()
        btnViewReceipt = New Button()
        btnHome = New Button()
        lblCustomer = New Label()
        lblOrder = New Label()
        lblDateTime = New Label()
        lblCost = New Label()
        SuspendLayout()
        ' 
        ' lstPrevOrders
        ' 
        lstPrevOrders.Anchor = AnchorStyles.None
        lstPrevOrders.Font = New Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstPrevOrders.FormattingEnabled = True
        lstPrevOrders.ItemHeight = 20
        lstPrevOrders.Location = New Point(569, 343)
        lstPrevOrders.Margin = New Padding(2)
        lstPrevOrders.Name = "lstPrevOrders"
        lstPrevOrders.Size = New Size(756, 284)
        lstPrevOrders.TabIndex = 1
        ' 
        ' btnViewReceipt
        ' 
        btnViewReceipt.Anchor = AnchorStyles.None
        btnViewReceipt.Location = New Point(952, 673)
        btnViewReceipt.Margin = New Padding(2)
        btnViewReceipt.Name = "btnViewReceipt"
        btnViewReceipt.Size = New Size(186, 35)
        btnViewReceipt.TabIndex = 3
        btnViewReceipt.Text = "View &Receipt"
        btnViewReceipt.UseVisualStyleBackColor = True
        ' 
        ' btnHome
        ' 
        btnHome.Anchor = AnchorStyles.None
        btnHome.Location = New Point(766, 673)
        btnHome.Margin = New Padding(2)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(182, 35)
        btnHome.TabIndex = 2
        btnHome.Text = "Return &Home"
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' lblCustomer
        ' 
        lblCustomer.Anchor = AnchorStyles.None
        lblCustomer.AutoSize = True
        lblCustomer.Location = New Point(662, 316)
        lblCustomer.Margin = New Padding(2, 0, 2, 0)
        lblCustomer.Name = "lblCustomer"
        lblCustomer.Size = New Size(89, 25)
        lblCustomer.TabIndex = 5
        lblCustomer.Text = "Customer"
        ' 
        ' lblOrder
        ' 
        lblOrder.Anchor = AnchorStyles.None
        lblOrder.AutoSize = True
        lblOrder.Location = New Point(566, 316)
        lblOrder.Margin = New Padding(2, 0, 2, 0)
        lblOrder.Name = "lblOrder"
        lblOrder.Size = New Size(58, 25)
        lblOrder.TabIndex = 4
        lblOrder.Text = "Order"
        ' 
        ' lblDateTime
        ' 
        lblDateTime.Anchor = AnchorStyles.None
        lblDateTime.AutoSize = True
        lblDateTime.Location = New Point(948, 316)
        lblDateTime.Margin = New Padding(2, 0, 2, 0)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(94, 25)
        lblDateTime.TabIndex = 6
        lblDateTime.Text = "Date/Time"
        ' 
        ' lblCost
        ' 
        lblCost.Anchor = AnchorStyles.None
        lblCost.AutoSize = True
        lblCost.Location = New Point(1242, 316)
        lblCost.Margin = New Padding(2, 0, 2, 0)
        lblCost.Name = "lblCost"
        lblCost.Size = New Size(90, 25)
        lblCost.TabIndex = 7
        lblCost.Text = "Total Cost"
        ' 
        ' PrevOrders
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1898, 1024)
        Controls.Add(lblCost)
        Controls.Add(lblDateTime)
        Controls.Add(lblOrder)
        Controls.Add(lblCustomer)
        Controls.Add(btnHome)
        Controls.Add(btnViewReceipt)
        Controls.Add(lstPrevOrders)
        Margin = New Padding(2)
        Name = "PrevOrders"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Previous Orders – Messiah Munchies"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstPrevOrders As ListBox
    Friend WithEvents btnViewReceipt As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents lblCustomer As Label
    Friend WithEvents lblOrder As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents lblCost As Label
End Class
