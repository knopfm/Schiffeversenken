<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatistikDialog
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StatistikDialog))
        Me.SchließenBT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SchließenBT
        '
        Me.SchließenBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SchließenBT.BackgroundImage = Global.Schiffeversenken.My.Resources.Resources.Metallplatte
        Me.SchließenBT.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SchließenBT.Location = New System.Drawing.Point(747, 414)
        Me.SchließenBT.Name = "SchließenBT"
        Me.SchließenBT.Size = New System.Drawing.Size(71, 23)
        Me.SchließenBT.TabIndex = 0
        Me.SchließenBT.Text = "schließen"
        Me.SchließenBT.UseVisualStyleBackColor = True
        '
        'StatistikDialog
        '
        Me.AcceptButton = Me.SchließenBT
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Schiffeversenken.My.Resources.Resources.Metallplatte_skretched
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.SchließenBT
        Me.ClientSize = New System.Drawing.Size(830, 449)
        Me.Controls.Add(Me.SchließenBT)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StatistikDialog"
        Me.Text = "Statistik"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SchließenBT As Button
End Class
