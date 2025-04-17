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
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(324, 884)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(188, 58)
        btnBack.TabIndex = 0
        btnBack.Text = "Go Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnPlaceOrder
        ' 
        btnPlaceOrder.Location = New Point(518, 884)
        btnPlaceOrder.Name = "btnPlaceOrder"
        btnPlaceOrder.Size = New Size(188, 58)
        btnPlaceOrder.TabIndex = 1
        btnPlaceOrder.Text = "Place Order"
        btnPlaceOrder.UseVisualStyleBackColor = True
        ' 
        ' Checkout
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1091, 1162)
        Controls.Add(btnPlaceOrder)
        Controls.Add(btnBack)
        Name = "Checkout"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Checkout"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnPlaceOrder As Button
End Class
