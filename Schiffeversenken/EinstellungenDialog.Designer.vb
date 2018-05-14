<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.HighL = New System.Windows.Forms.Label()
        Me.LowL = New System.Windows.Forms.Label()
        Me.GrafikGB = New System.Windows.Forms.GroupBox()
        Me.SpracheGB = New System.Windows.Forms.GroupBox()
        Me.SpracheL = New System.Windows.Forms.Label()
        Me.SpracheBT = New System.Windows.Forms.Button()
        Me.LanguageOFD = New System.Windows.Forms.OpenFileDialog()
        Me.ServerBT = New System.Windows.Forms.Button()
        Me.ServerGB = New System.Windows.Forms.GroupBox()
        Me.ServerL = New System.Windows.Forms.Label()
        Me.FarbenGB.SuspendLayout()
        CType(Me.GrafikTB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrafikGB.SuspendLayout()
        Me.SpracheGB.SuspendLayout()
        Me.ServerGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'CloseBT
        '
        Me.CloseBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseBT.BackgroundImage = CType(resources.GetObject("CloseBT.BackgroundImage"), System.Drawing.Image)
        Me.CloseBT.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseBT.Location = New System.Drawing.Point(390, 160)
        Me.CloseBT.Name = "CloseBT"
        Me.CloseBT.Size = New System.Drawing.Size(78, 23)
        Me.CloseBT.TabIndex = 0
        Me.CloseBT.Text = "Übernehmen"
        Me.CloseBT.UseVisualStyleBackColor = True
        '
        'FarbenGB
        '
        Me.FarbenGB.BackColor = System.Drawing.Color.Transparent
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
        Me.FarbenDialog.Color = System.Drawing.Color.White
        Me.FarbenDialog.FullOpen = True
        '
        'GrafikTB
        '
        Me.GrafikTB.BackColor = System.Drawing.Color.White
        Me.GrafikTB.Location = New System.Drawing.Point(6, 19)
        Me.GrafikTB.Name = "GrafikTB"
        Me.GrafikTB.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.GrafikTB.Size = New System.Drawing.Size(45, 110)
        Me.GrafikTB.TabIndex = 2
        Me.GrafikTB.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.GrafikTB.Value = 5
        '
        'HighL
        '
        Me.HighL.AutoSize = True
        Me.HighL.Location = New System.Drawing.Point(57, 21)
        Me.HighL.Name = "HighL"
        Me.HighL.Size = New System.Drawing.Size(33, 13)
        Me.HighL.TabIndex = 4
        Me.HighL.Text = "Hoch"
        '
        'LowL
        '
        Me.LowL.AutoSize = True
        Me.LowL.Location = New System.Drawing.Point(50, 111)
        Me.LowL.Name = "LowL"
        Me.LowL.Size = New System.Drawing.Size(40, 13)
        Me.LowL.TabIndex = 5
        Me.LowL.Text = "Niedrig"
        '
        'GrafikGB
        '
        Me.GrafikGB.BackColor = System.Drawing.Color.Transparent
        Me.GrafikGB.Controls.Add(Me.GrafikTB)
        Me.GrafikGB.Controls.Add(Me.LowL)
        Me.GrafikGB.Controls.Add(Me.HighL)
        Me.GrafikGB.Location = New System.Drawing.Point(119, 12)
        Me.GrafikGB.Name = "GrafikGB"
        Me.GrafikGB.Size = New System.Drawing.Size(110, 138)
        Me.GrafikGB.TabIndex = 6
        Me.GrafikGB.TabStop = False
        Me.GrafikGB.Text = "Grafik"
        '
        'SpracheGB
        '
        Me.SpracheGB.BackColor = System.Drawing.Color.Transparent
        Me.SpracheGB.Controls.Add(Me.SpracheL)
        Me.SpracheGB.Controls.Add(Me.SpracheBT)
        Me.SpracheGB.Location = New System.Drawing.Point(235, 12)
        Me.SpracheGB.Name = "SpracheGB"
        Me.SpracheGB.Size = New System.Drawing.Size(136, 138)
        Me.SpracheGB.TabIndex = 7
        Me.SpracheGB.TabStop = False
        Me.SpracheGB.Text = "Sprache"
        '
        'SpracheL
        '
        Me.SpracheL.AutoSize = True
        Me.SpracheL.Location = New System.Drawing.Point(6, 21)
        Me.SpracheL.Name = "SpracheL"
        Me.SpracheL.Size = New System.Drawing.Size(45, 13)
        Me.SpracheL.TabIndex = 1
        Me.SpracheL.Text = "DE.lang"
        '
        'SpracheBT
        '
        Me.SpracheBT.BackgroundImage = CType(resources.GetObject("SpracheBT.BackgroundImage"), System.Drawing.Image)
        Me.SpracheBT.Location = New System.Drawing.Point(9, 39)
        Me.SpracheBT.Name = "SpracheBT"
        Me.SpracheBT.Size = New System.Drawing.Size(75, 23)
        Me.SpracheBT.TabIndex = 0
        Me.SpracheBT.Text = "Sprache"
        Me.SpracheBT.UseVisualStyleBackColor = True
        '
        'ServerBT
        '
        Me.ServerBT.BackgroundImage = CType(resources.GetObject("ServerBT.BackgroundImage"), System.Drawing.Image)
        Me.ServerBT.Location = New System.Drawing.Point(6, 39)
        Me.ServerBT.Name = "ServerBT"
        Me.ServerBT.Size = New System.Drawing.Size(75, 23)
        Me.ServerBT.TabIndex = 8
        Me.ServerBT.Text = "Server"
        Me.ServerBT.UseVisualStyleBackColor = True
        '
        'ServerGB
        '
        Me.ServerGB.BackColor = System.Drawing.Color.Transparent
        Me.ServerGB.Controls.Add(Me.ServerL)
        Me.ServerGB.Controls.Add(Me.ServerBT)
        Me.ServerGB.Location = New System.Drawing.Point(377, 12)
        Me.ServerGB.Name = "ServerGB"
        Me.ServerGB.Size = New System.Drawing.Size(89, 138)
        Me.ServerGB.TabIndex = 9
        Me.ServerGB.TabStop = False
        Me.ServerGB.Text = "Server"
        '
        'ServerL
        '
        Me.ServerL.AutoSize = True
        Me.ServerL.Location = New System.Drawing.Point(6, 21)
        Me.ServerL.Name = "ServerL"
        Me.ServerL.Size = New System.Drawing.Size(52, 13)
        Me.ServerL.TabIndex = 9
        Me.ServerL.Text = "127.0.0.1"
        '
        'EinstellungenDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Schiffeversenken.My.Resources.Resources.Metallplatte_skretched
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.CloseBT
        Me.ClientSize = New System.Drawing.Size(478, 195)
        Me.Controls.Add(Me.ServerGB)
        Me.Controls.Add(Me.SpracheGB)
        Me.Controls.Add(Me.GrafikGB)
        Me.Controls.Add(Me.FarbenGB)
        Me.Controls.Add(Me.CloseBT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EinstellungenDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Einstellungen"
        Me.FarbenGB.ResumeLayout(False)
        Me.FarbenGB.PerformLayout()
        CType(Me.GrafikTB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrafikGB.ResumeLayout(False)
        Me.GrafikGB.PerformLayout()
        Me.SpracheGB.ResumeLayout(False)
        Me.SpracheGB.PerformLayout()
        Me.ServerGB.ResumeLayout(False)
        Me.ServerGB.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents HighL As Label
    Friend WithEvents LowL As Label
    Friend WithEvents GrafikGB As GroupBox
    Friend WithEvents SpracheGB As GroupBox
    Friend WithEvents LanguageOFD As OpenFileDialog
    Friend WithEvents SpracheL As Label
    Friend WithEvents SpracheBT As Button
    Friend WithEvents ServerBT As Button
    Friend WithEvents ServerGB As GroupBox
    Friend WithEvents ServerL As Label
End Class
