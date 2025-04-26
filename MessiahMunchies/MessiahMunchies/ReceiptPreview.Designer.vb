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
        SuspendLayout()
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(362, 1077)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(320, 58)
        btnReturn.TabIndex = 0
        btnReturn.Text = "Return to List"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' ReceiptPreview
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1068, 1232)
        Controls.Add(btnReturn)
        Name = "ReceiptPreview"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Receipt Preview – Messiah Munchies"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnReturn As Button
End Class
