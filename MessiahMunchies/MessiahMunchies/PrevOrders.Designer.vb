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
        ListBox1 = New ListBox()
        btnViewReceipt = New Button()
        btnHome = New Button()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 41
        ListBox1.Location = New Point(114, 63)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(931, 455)
        ListBox1.TabIndex = 0
        ' 
        ' btnViewReceipt
        ' 
        btnViewReceipt.Location = New Point(606, 577)
        btnViewReceipt.Name = "btnViewReceipt"
        btnViewReceipt.Size = New Size(317, 58)
        btnViewReceipt.TabIndex = 1
        btnViewReceipt.Text = "View Receipt"
        btnViewReceipt.UseVisualStyleBackColor = True
        ' 
        ' btnHome
        ' 
        btnHome.Location = New Point(268, 577)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(309, 58)
        btnHome.TabIndex = 2
        btnHome.Text = "Return Home"
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' PrevOrders
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1164, 1093)
        Controls.Add(btnHome)
        Controls.Add(btnViewReceipt)
        Controls.Add(ListBox1)
        Name = "PrevOrders"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Previous Orders"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnViewReceipt As Button
    Friend WithEvents btnHome As Button
End Class
