﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EinstellungenDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EinstellungenDialog))
        Me.CloseBT = New System.Windows.Forms.Button()
        Me.FarbenGB = New System.Windows.Forms.GroupBox()
        Me.OtherBT = New System.Windows.Forms.Button()
        Me.OtherRB = New System.Windows.Forms.RadioButton()
        Me.CornflowerBlueRB = New System.Windows.Forms.RadioButton()
        Me.DeepSkyBlueRB = New System.Windows.Forms.RadioButton()
        Me.LightGreenRB = New System.Windows.Forms.RadioButton()
        Me.LightSeaGreenRB = New System.Windows.Forms.RadioButton()
        Me.FarbenDialog = New System.Windows.Forms.ColorDialog()
        Me.GrafikTB = New System.Windows.Forms.TrackBar()
        Me.GrafikL = New System.Windows.Forms.Label()
        Me.FarbenGB.SuspendLayout()
        CType(Me.GrafikTB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CloseBT
        '
        Me.CloseBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseBT.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseBT.Location = New System.Drawing.Point(694, 376)
        Me.CloseBT.Name = "CloseBT"
        Me.CloseBT.Size = New System.Drawing.Size(78, 23)
        Me.CloseBT.TabIndex = 0
        Me.CloseBT.Text = "Übernehmen"
        Me.CloseBT.UseVisualStyleBackColor = True
        '
        'FarbenGB
        '
        Me.FarbenGB.Controls.Add(Me.OtherBT)
        Me.FarbenGB.Controls.Add(Me.OtherRB)
        Me.FarbenGB.Controls.Add(Me.CornflowerBlueRB)
        Me.FarbenGB.Controls.Add(Me.DeepSkyBlueRB)
        Me.FarbenGB.Controls.Add(Me.LightGreenRB)
        Me.FarbenGB.Controls.Add(Me.LightSeaGreenRB)
        Me.FarbenGB.Location = New System.Drawing.Point(12, 12)
        Me.FarbenGB.Name = "FarbenGB"
        Me.FarbenGB.Size = New System.Drawing.Size(101, 138)
        Me.FarbenGB.TabIndex = 1
        Me.FarbenGB.TabStop = False
        Me.FarbenGB.Text = "Farben"
        '
        'OtherBT
        '
        Me.OtherBT.Location = New System.Drawing.Point(25, 106)
        Me.OtherBT.Name = "OtherBT"
        Me.OtherBT.Size = New System.Drawing.Size(66, 23)
        Me.OtherBT.TabIndex = 5
        Me.OtherBT.Text = "Andere"
        Me.OtherBT.UseVisualStyleBackColor = True
        '
        'OtherRB
        '
        Me.OtherRB.AutoSize = True
        Me.OtherRB.BackColor = System.Drawing.Color.LightSeaGreen
        Me.OtherRB.Location = New System.Drawing.Point(9, 111)
        Me.OtherRB.Name = "OtherRB"
        Me.OtherRB.Size = New System.Drawing.Size(14, 13)
        Me.OtherRB.TabIndex = 4
        Me.OtherRB.UseVisualStyleBackColor = False
        '
        'CornflowerBlueRB
        '
        Me.CornflowerBlueRB.AutoSize = True
        Me.CornflowerBlueRB.BackColor = System.Drawing.Color.CornflowerBlue
        Me.CornflowerBlueRB.Location = New System.Drawing.Point(9, 88)
        Me.CornflowerBlueRB.Name = "CornflowerBlueRB"
        Me.CornflowerBlueRB.Size = New System.Drawing.Size(82, 17)
        Me.CornflowerBlueRB.TabIndex = 3
        Me.CornflowerBlueRB.Text = "                   "
        Me.CornflowerBlueRB.UseVisualStyleBackColor = False
        '
        'DeepSkyBlueRB
        '
        Me.DeepSkyBlueRB.AutoSize = True
        Me.DeepSkyBlueRB.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.DeepSkyBlueRB.Location = New System.Drawing.Point(9, 65)
        Me.DeepSkyBlueRB.Name = "DeepSkyBlueRB"
        Me.DeepSkyBlueRB.Size = New System.Drawing.Size(82, 17)
        Me.DeepSkyBlueRB.TabIndex = 2
        Me.DeepSkyBlueRB.Text = "                   "
        Me.DeepSkyBlueRB.UseVisualStyleBackColor = False
        '
        'LightGreenRB
        '
        Me.LightGreenRB.AutoSize = True
        Me.LightGreenRB.BackColor = System.Drawing.Color.LightGreen
        Me.LightGreenRB.Location = New System.Drawing.Point(9, 42)
        Me.LightGreenRB.Name = "LightGreenRB"
        Me.LightGreenRB.Size = New System.Drawing.Size(82, 17)
        Me.LightGreenRB.TabIndex = 1
        Me.LightGreenRB.Text = "                   "
        Me.LightGreenRB.UseVisualStyleBackColor = False
        '
        'LightSeaGreenRB
        '
        Me.LightSeaGreenRB.AutoSize = True
        Me.LightSeaGreenRB.BackColor = System.Drawing.Color.LightSeaGreen
        Me.LightSeaGreenRB.Checked = True
        Me.LightSeaGreenRB.Location = New System.Drawing.Point(9, 19)
        Me.LightSeaGreenRB.Name = "LightSeaGreenRB"
        Me.LightSeaGreenRB.Size = New System.Drawing.Size(82, 17)
        Me.LightSeaGreenRB.TabIndex = 0
        Me.LightSeaGreenRB.TabStop = True
        Me.LightSeaGreenRB.Text = "                   "
        Me.LightSeaGreenRB.UseVisualStyleBackColor = False
        '
        'FarbenDialog
        '
        Me.FarbenDialog.Color = System.Drawing.Color.LightSeaGreen
        Me.FarbenDialog.FullOpen = True
        '
        'GrafikTB
        '
        Me.GrafikTB.Location = New System.Drawing.Point(191, 12)
        Me.GrafikTB.Name = "GrafikTB"
        Me.GrafikTB.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.GrafikTB.Size = New System.Drawing.Size(45, 138)
        Me.GrafikTB.TabIndex = 2
        Me.GrafikTB.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.GrafikTB.Value = 5
        '
        'GrafikL
        '
        Me.GrafikL.AutoSize = True
        Me.GrafikL.Location = New System.Drawing.Point(147, 16)
        Me.GrafikL.Name = "GrafikL"
        Me.GrafikL.Size = New System.Drawing.Size(38, 13)
        Me.GrafikL.TabIndex = 3
        Me.GrafikL.Text = "Grafik:"
        '
        'EinstellungenDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CloseBT
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.GrafikL)
        Me.Controls.Add(Me.GrafikTB)
        Me.Controls.Add(Me.FarbenGB)
        Me.Controls.Add(Me.CloseBT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EinstellungenDialog"
        Me.Text = "Einstellungen"
        Me.FarbenGB.ResumeLayout(False)
        Me.FarbenGB.PerformLayout()
        CType(Me.GrafikTB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CloseBT As Button
    Friend WithEvents FarbenGB As GroupBox
    Friend WithEvents OtherRB As RadioButton
    Friend WithEvents CornflowerBlueRB As RadioButton
    Friend WithEvents DeepSkyBlueRB As RadioButton
    Friend WithEvents LightGreenRB As RadioButton
    Friend WithEvents LightSeaGreenRB As RadioButton
    Friend WithEvents OtherBT As Button
    Friend WithEvents FarbenDialog As ColorDialog
    Friend WithEvents GrafikTB As TrackBar
    Friend WithEvents GrafikL As Label
End Class
