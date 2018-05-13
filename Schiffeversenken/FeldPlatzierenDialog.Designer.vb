<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FeldPlatzierenDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FeldPlatzierenDialog))
        Me.SchiffTypeGB = New System.Windows.Forms.GroupBox()
        Me.Schiff2RB = New System.Windows.Forms.RadioButton()
        Me.Schiff5RB = New System.Windows.Forms.RadioButton()
        Me.Schiff4RB = New System.Windows.Forms.RadioButton()
        Me.Schiff3RB = New System.Windows.Forms.RadioButton()
        Me.RichtungGB = New System.Windows.Forms.GroupBox()
        Me.SudenRB = New System.Windows.Forms.RadioButton()
        Me.OstenRB = New System.Windows.Forms.RadioButton()
        Me.WestenRB = New System.Windows.Forms.RadioButton()
        Me.NordenRB = New System.Windows.Forms.RadioButton()
        Me.OkBT = New System.Windows.Forms.Button()
        Me.AbortBT = New System.Windows.Forms.Button()
        Me.SchiffTypeGB.SuspendLayout()
        Me.RichtungGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'SchiffTypeGB
        '
        Me.SchiffTypeGB.BackColor = System.Drawing.Color.Black
        Me.SchiffTypeGB.Controls.Add(Me.Schiff2RB)
        Me.SchiffTypeGB.Controls.Add(Me.Schiff5RB)
        Me.SchiffTypeGB.Controls.Add(Me.Schiff4RB)
        Me.SchiffTypeGB.Controls.Add(Me.Schiff3RB)
        Me.SchiffTypeGB.ForeColor = System.Drawing.SystemColors.Info
        Me.SchiffTypeGB.Location = New System.Drawing.Point(12, 12)
        Me.SchiffTypeGB.Name = "SchiffTypeGB"
        Me.SchiffTypeGB.Size = New System.Drawing.Size(89, 114)
        Me.SchiffTypeGB.TabIndex = 0
        Me.SchiffTypeGB.TabStop = False
        Me.SchiffTypeGB.Text = "Schiff Typ"
        '
        'Schiff2RB
        '
        Me.Schiff2RB.AutoSize = True
        Me.Schiff2RB.Location = New System.Drawing.Point(6, 19)
        Me.Schiff2RB.Name = "Schiff2RB"
        Me.Schiff2RB.Size = New System.Drawing.Size(73, 17)
        Me.Schiff2RB.TabIndex = 0
        Me.Schiff2RB.TabStop = True
        Me.Schiff2RB.Text = "3-er Schiff"
        Me.Schiff2RB.UseVisualStyleBackColor = True
        '
        'Schiff5RB
        '
        Me.Schiff5RB.AutoSize = True
        Me.Schiff5RB.Location = New System.Drawing.Point(6, 88)
        Me.Schiff5RB.Name = "Schiff5RB"
        Me.Schiff5RB.Size = New System.Drawing.Size(73, 17)
        Me.Schiff5RB.TabIndex = 3
        Me.Schiff5RB.TabStop = True
        Me.Schiff5RB.Text = "5-er Schiff"
        Me.Schiff5RB.UseVisualStyleBackColor = True
        '
        'Schiff4RB
        '
        Me.Schiff4RB.AutoSize = True
        Me.Schiff4RB.Location = New System.Drawing.Point(6, 65)
        Me.Schiff4RB.Name = "Schiff4RB"
        Me.Schiff4RB.Size = New System.Drawing.Size(73, 17)
        Me.Schiff4RB.TabIndex = 2
        Me.Schiff4RB.TabStop = True
        Me.Schiff4RB.Text = "4-er Schiff"
        Me.Schiff4RB.UseVisualStyleBackColor = True
        '
        'Schiff3RB
        '
        Me.Schiff3RB.AutoSize = True
        Me.Schiff3RB.Location = New System.Drawing.Point(6, 42)
        Me.Schiff3RB.Name = "Schiff3RB"
        Me.Schiff3RB.Size = New System.Drawing.Size(73, 17)
        Me.Schiff3RB.TabIndex = 1
        Me.Schiff3RB.TabStop = True
        Me.Schiff3RB.Text = "3-er Schiff"
        Me.Schiff3RB.UseVisualStyleBackColor = True
        '
        'RichtungGB
        '
        Me.RichtungGB.BackColor = System.Drawing.Color.Transparent
        Me.RichtungGB.BackgroundImage = Global.Schiffeversenken.My.Resources.Resources.Radar
        Me.RichtungGB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RichtungGB.Controls.Add(Me.SudenRB)
        Me.RichtungGB.Controls.Add(Me.OstenRB)
        Me.RichtungGB.Controls.Add(Me.WestenRB)
        Me.RichtungGB.Controls.Add(Me.NordenRB)
        Me.RichtungGB.Enabled = False
        Me.RichtungGB.ForeColor = System.Drawing.SystemColors.Info
        Me.RichtungGB.Location = New System.Drawing.Point(107, 12)
        Me.RichtungGB.Name = "RichtungGB"
        Me.RichtungGB.Size = New System.Drawing.Size(161, 114)
        Me.RichtungGB.TabIndex = 1
        Me.RichtungGB.TabStop = False
        Me.RichtungGB.Text = "Richtung"
        '
        'SudenRB
        '
        Me.SudenRB.AutoSize = True
        Me.SudenRB.BackColor = System.Drawing.Color.Transparent
        Me.SudenRB.Location = New System.Drawing.Point(59, 65)
        Me.SudenRB.Name = "SudenRB"
        Me.SudenRB.Size = New System.Drawing.Size(56, 17)
        Me.SudenRB.TabIndex = 2
        Me.SudenRB.TabStop = True
        Me.SudenRB.Text = "Süden"
        Me.SudenRB.UseVisualStyleBackColor = False
        '
        'OstenRB
        '
        Me.OstenRB.AutoSize = True
        Me.OstenRB.BackColor = System.Drawing.Color.Transparent
        Me.OstenRB.Location = New System.Drawing.Point(102, 42)
        Me.OstenRB.Name = "OstenRB"
        Me.OstenRB.Size = New System.Drawing.Size(53, 17)
        Me.OstenRB.TabIndex = 1
        Me.OstenRB.TabStop = True
        Me.OstenRB.Text = "Osten"
        Me.OstenRB.UseVisualStyleBackColor = False
        '
        'WestenRB
        '
        Me.WestenRB.AutoSize = True
        Me.WestenRB.BackColor = System.Drawing.Color.Transparent
        Me.WestenRB.Location = New System.Drawing.Point(6, 42)
        Me.WestenRB.Name = "WestenRB"
        Me.WestenRB.Size = New System.Drawing.Size(62, 17)
        Me.WestenRB.TabIndex = 3
        Me.WestenRB.TabStop = True
        Me.WestenRB.Text = "Westen"
        Me.WestenRB.UseVisualStyleBackColor = False
        '
        'NordenRB
        '
        Me.NordenRB.AutoSize = True
        Me.NordenRB.BackColor = System.Drawing.Color.Transparent
        Me.NordenRB.Location = New System.Drawing.Point(59, 19)
        Me.NordenRB.Name = "NordenRB"
        Me.NordenRB.Size = New System.Drawing.Size(60, 17)
        Me.NordenRB.TabIndex = 0
        Me.NordenRB.TabStop = True
        Me.NordenRB.Text = "Norden"
        Me.NordenRB.UseVisualStyleBackColor = False
        '
        'OkBT
        '
        Me.OkBT.BackgroundImage = CType(resources.GetObject("OkBT.BackgroundImage"), System.Drawing.Image)
        Me.OkBT.Enabled = False
        Me.OkBT.Location = New System.Drawing.Point(113, 132)
        Me.OkBT.Name = "OkBT"
        Me.OkBT.Size = New System.Drawing.Size(75, 23)
        Me.OkBT.TabIndex = 2
        Me.OkBT.Text = "OK"
        Me.OkBT.UseVisualStyleBackColor = True
        '
        'AbortBT
        '
        Me.AbortBT.BackgroundImage = CType(resources.GetObject("AbortBT.BackgroundImage"), System.Drawing.Image)
        Me.AbortBT.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.AbortBT.Location = New System.Drawing.Point(193, 132)
        Me.AbortBT.Name = "AbortBT"
        Me.AbortBT.Size = New System.Drawing.Size(75, 23)
        Me.AbortBT.TabIndex = 3
        Me.AbortBT.Text = "Abbrechen"
        Me.AbortBT.UseVisualStyleBackColor = True
        '
        'FeldPlatzierenDialog
        '
        Me.AcceptButton = Me.OkBT
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Schiffeversenken.My.Resources.Resources.Metallplatte_skretched
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.AbortBT
        Me.ClientSize = New System.Drawing.Size(280, 167)
        Me.Controls.Add(Me.AbortBT)
        Me.Controls.Add(Me.OkBT)
        Me.Controls.Add(Me.RichtungGB)
        Me.Controls.Add(Me.SchiffTypeGB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FeldPlatzierenDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schiff platzieren"
        Me.SchiffTypeGB.ResumeLayout(False)
        Me.SchiffTypeGB.PerformLayout()
        Me.RichtungGB.ResumeLayout(False)
        Me.RichtungGB.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SchiffTypeGB As GroupBox
    Friend WithEvents Schiff5RB As RadioButton
    Friend WithEvents Schiff4RB As RadioButton
    Friend WithEvents Schiff3RB As RadioButton
    Friend WithEvents RichtungGB As GroupBox
    Friend WithEvents SudenRB As RadioButton
    Friend WithEvents OstenRB As RadioButton
    Friend WithEvents WestenRB As RadioButton
    Friend WithEvents NordenRB As RadioButton
    Friend WithEvents OkBT As Button
    Friend WithEvents AbortBT As Button
    Friend WithEvents Schiff2RB As RadioButton
End Class
