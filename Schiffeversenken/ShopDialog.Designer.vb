<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ShopDialog
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CloseBT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CloseBT
        '
        Me.CloseBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseBT.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseBT.Location = New System.Drawing.Point(697, 376)
        Me.CloseBT.Name = "CloseBT"
        Me.CloseBT.Size = New System.Drawing.Size(75, 23)
        Me.CloseBT.TabIndex = 0
        Me.CloseBT.Text = "schließen"
        Me.CloseBT.UseVisualStyleBackColor = True
        '
        'ShopDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CloseBT
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.CloseBT)
        Me.Name = "ShopDialog"
        Me.Text = "Shop"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CloseBT As Button
End Class
