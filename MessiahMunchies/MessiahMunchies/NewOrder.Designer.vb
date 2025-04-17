<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewOrder
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
        btnCheckout = New Button()
        btnHome = New Button()
        SuspendLayout()
        ' 
        ' btnCheckout
        ' 
        btnCheckout.Location = New Point(386, 906)
        btnCheckout.Name = "btnCheckout"
        btnCheckout.Size = New Size(188, 58)
        btnCheckout.TabIndex = 0
        btnCheckout.Text = "Checkout"
        btnCheckout.UseVisualStyleBackColor = True
        ' 
        ' btnHome
        ' 
        btnHome.Location = New Point(594, 906)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(306, 58)
        btnHome.TabIndex = 1
        btnHome.Text = "Return Home"
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' NewOrder
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1151, 1185)
        Controls.Add(btnHome)
        Controls.Add(btnCheckout)
        Name = "NewOrder"
        StartPosition = FormStartPosition.CenterScreen
        Text = "New Order"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnCheckout As Button
    Friend WithEvents btnHome As Button
End Class
