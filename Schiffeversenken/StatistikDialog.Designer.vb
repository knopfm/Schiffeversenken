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
        Me.CloseBT = New System.Windows.Forms.Button()
        Me.StatistikL = New System.Windows.Forms.Label()
        Me.ResetBT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CloseBT
        '
        Me.CloseBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseBT.BackgroundImage = Global.Schiffeversenken.My.Resources.Resources.Metallplatte
        Me.CloseBT.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.CloseBT.Location = New System.Drawing.Point(315, 414)
        Me.CloseBT.Name = "CloseBT"
        Me.CloseBT.Size = New System.Drawing.Size(71, 23)
        Me.CloseBT.TabIndex = 0
        Me.CloseBT.Text = "schließen"
        Me.CloseBT.UseVisualStyleBackColor = True
        '
        'StatistikL
        '
        Me.StatistikL.BackColor = System.Drawing.Color.Transparent
        Me.StatistikL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatistikL.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatistikL.Location = New System.Drawing.Point(0, 0)
        Me.StatistikL.Margin = New System.Windows.Forms.Padding(0)
        Me.StatistikL.Name = "StatistikL"
        Me.StatistikL.Padding = New System.Windows.Forms.Padding(15)
        Me.StatistikL.Size = New System.Drawing.Size(398, 449)
        Me.StatistikL.TabIndex = 1
        Me.StatistikL.Text = "Statistik"
        '
        'ResetBT
        '
        Me.ResetBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResetBT.BackgroundImage = Global.Schiffeversenken.My.Resources.Resources.Metallplatte
        Me.ResetBT.Location = New System.Drawing.Point(224, 414)
        Me.ResetBT.Name = "ResetBT"
        Me.ResetBT.Size = New System.Drawing.Size(85, 23)
        Me.ResetBT.TabIndex = 2
        Me.ResetBT.Text = "Zurücksetzten"
        Me.ResetBT.UseVisualStyleBackColor = True
        '
        'StatistikDialog
        '
        Me.AcceptButton = Me.CloseBT
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Schiffeversenken.My.Resources.Resources.Metallplatte_skretched
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CancelButton = Me.CloseBT
        Me.ClientSize = New System.Drawing.Size(398, 449)
        Me.Controls.Add(Me.ResetBT)
        Me.Controls.Add(Me.CloseBT)
        Me.Controls.Add(Me.StatistikL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StatistikDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Statistik"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CloseBT As Button
    Friend WithEvents StatistikL As Label
    Friend WithEvents ResetBT As Button
End Class
