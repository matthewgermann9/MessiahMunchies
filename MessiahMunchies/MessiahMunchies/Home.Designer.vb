<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnNewOrder = New Button()
        btnPrevOrders = New Button()
        SuspendLayout()
        ' 
        ' btnNewOrder
        ' 
        btnNewOrder.Location = New Point(345, 857)
        btnNewOrder.Name = "btnNewOrder"
        btnNewOrder.Size = New Size(259, 58)
        btnNewOrder.TabIndex = 0
        btnNewOrder.Text = "New Order"
        btnNewOrder.UseVisualStyleBackColor = True
        ' 
        ' btnPrevOrders
        ' 
        btnPrevOrders.Location = New Point(624, 857)
        btnPrevOrders.Name = "btnPrevOrders"
        btnPrevOrders.Size = New Size(259, 58)
        btnPrevOrders.TabIndex = 1
        btnPrevOrders.Text = "Previous Orders"
        btnPrevOrders.UseVisualStyleBackColor = True
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1272, 1144)
        Controls.Add(btnPrevOrders)
        Controls.Add(btnNewOrder)
        Name = "Home"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnNewOrder As Button
    Friend WithEvents btnPrevOrders As Button

End Class
