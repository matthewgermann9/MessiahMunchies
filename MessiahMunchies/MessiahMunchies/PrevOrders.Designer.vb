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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        lblCustomer = New Label()
        lblOrder = New Label()
        lblDateTime = New Label()
        lblCost = New Label()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lstPrevOrders
        ' 
        lstPrevOrders.Font = New Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstPrevOrders.FormattingEnabled = True
        lstPrevOrders.ItemHeight = 33
        lstPrevOrders.Location = New Point(20, 107)
        lstPrevOrders.Name = "lstPrevOrders"
        lstPrevOrders.Size = New Size(1282, 466)
        lstPrevOrders.TabIndex = 1
        ' 
        ' btnViewReceipt
        ' 
        btnViewReceipt.Location = New Point(671, 648)
        btnViewReceipt.Name = "btnViewReceipt"
        btnViewReceipt.Size = New Size(317, 58)
        btnViewReceipt.TabIndex = 3
        btnViewReceipt.Text = "View &Receipt"
        btnViewReceipt.UseVisualStyleBackColor = True
        ' 
        ' btnHome
        ' 
        btnHome.Location = New Point(356, 648)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(309, 58)
        btnHome.TabIndex = 2
        btnHome.Text = "Return &Home"
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(40, 40)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1320, 49)
        MenuStrip1.TabIndex = 3
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(87, 45)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(230, 54)
        ExitToolStripMenuItem.Text = "&Exit"
        ' 
        ' lblCustomer
        ' 
        lblCustomer.AutoSize = True
        lblCustomer.Location = New Point(178, 63)
        lblCustomer.Name = "lblCustomer"
        lblCustomer.Size = New Size(147, 41)
        lblCustomer.TabIndex = 5
        lblCustomer.Text = "Customer"
        ' 
        ' lblOrder
        ' 
        lblOrder.AutoSize = True
        lblOrder.Location = New Point(15, 63)
        lblOrder.Name = "lblOrder"
        lblOrder.Size = New Size(95, 41)
        lblOrder.TabIndex = 4
        lblOrder.Text = "Order"
        ' 
        ' lblDateTime
        ' 
        lblDateTime.AutoSize = True
        lblDateTime.Location = New Point(665, 63)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(157, 41)
        lblDateTime.TabIndex = 6
        lblDateTime.Text = "Date/Time"
        ' 
        ' lblCost
        ' 
        lblCost.AutoSize = True
        lblCost.Location = New Point(1164, 63)
        lblCost.Name = "lblCost"
        lblCost.Size = New Size(149, 41)
        lblCost.TabIndex = 7
        lblCost.Text = "Total Cost"
        ' 
        ' PrevOrders
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1320, 786)
        Controls.Add(lblCost)
        Controls.Add(lblDateTime)
        Controls.Add(lblOrder)
        Controls.Add(lblCustomer)
        Controls.Add(btnHome)
        Controls.Add(btnViewReceipt)
        Controls.Add(lstPrevOrders)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "PrevOrders"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Previous Orders – Messiah Munchies"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstPrevOrders As ListBox
    Friend WithEvents btnViewReceipt As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblCustomer As Label
    Friend WithEvents lblOrder As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents lblCost As Label
End Class
