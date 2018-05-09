<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FeldDialog10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FeldDialog10))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.AktionTSSL = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StartBT = New System.Windows.Forms.Button()
        Me.CloseBT = New System.Windows.Forms.Button()
        Me.BackgroundTLP = New System.Windows.Forms.TableLayoutPanel()
        Me.TimeLeftL = New System.Windows.Forms.Label()
        Me.FeldBackground1 = New Schiffeversenken.FeldBackground()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackgroundTLP.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 460)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(630, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'AktionTSSL
        '
        Me.AktionTSSL.Name = "AktionTSSL"
        Me.AktionTSSL.Size = New System.Drawing.Size(133, 17)
        Me.AktionTSSL.Text = "Fehler: Beende das Spiel"
        '
        'StartBT
        '
        Me.StartBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartBT.BackColor = System.Drawing.SystemColors.Control
        Me.StartBT.BackgroundImage = CType(resources.GetObject("StartBT.BackgroundImage"), System.Drawing.Image)
        Me.StartBT.Enabled = False
        Me.StartBT.Location = New System.Drawing.Point(543, 405)
        Me.StartBT.Name = "StartBT"
        Me.StartBT.Size = New System.Drawing.Size(75, 23)
        Me.StartBT.TabIndex = 3
        Me.StartBT.Text = "Start"
        Me.StartBT.UseVisualStyleBackColor = False
        '
        'CloseBT
        '
        Me.CloseBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseBT.BackColor = System.Drawing.SystemColors.Control
        Me.CloseBT.BackgroundImage = CType(resources.GetObject("CloseBT.BackgroundImage"), System.Drawing.Image)
        Me.CloseBT.Location = New System.Drawing.Point(543, 434)
        Me.CloseBT.Name = "CloseBT"
        Me.CloseBT.Size = New System.Drawing.Size(75, 23)
        Me.CloseBT.TabIndex = 1
        Me.CloseBT.Text = "Beenden"
        Me.CloseBT.UseVisualStyleBackColor = False
        '
        'BackgroundTLP
        '
        Me.BackgroundTLP.BackgroundImage = Global.Schiffeversenken.My.Resources.Resources.Wasser
        Me.BackgroundTLP.ColumnCount = 2
        Me.BackgroundTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.09711!))
        Me.BackgroundTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.90289!))
        Me.BackgroundTLP.Controls.Add(Me.FeldBackground1, 0, 0)
        Me.BackgroundTLP.Controls.Add(Me.Panel1, 1, 0)
        Me.BackgroundTLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackgroundTLP.Location = New System.Drawing.Point(0, 0)
        Me.BackgroundTLP.Margin = New System.Windows.Forms.Padding(0)
        Me.BackgroundTLP.Name = "BackgroundTLP"
        Me.BackgroundTLP.RowCount = 1
        Me.BackgroundTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BackgroundTLP.Size = New System.Drawing.Size(630, 482)
        Me.BackgroundTLP.TabIndex = 0
        '
        'TimeLeftL
        '
        Me.TimeLeftL.Location = New System.Drawing.Point(18, 95)
        Me.TimeLeftL.Name = "TimeLeftL"
        Me.TimeLeftL.Size = New System.Drawing.Size(140, 142)
        Me.TimeLeftL.TabIndex = 0
        '
        'FeldBackground1
        '
        Me.FeldBackground1.BackColor = System.Drawing.Color.Gray
        Me.FeldBackground1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FeldBackground1.Location = New System.Drawing.Point(19, 19)
        Me.FeldBackground1.Margin = New System.Windows.Forms.Padding(19)
        Me.FeldBackground1.Name = "FeldBackground1"
        Me.FeldBackground1.Padding = New System.Windows.Forms.Padding(19)
        Me.FeldBackground1.Size = New System.Drawing.Size(422, 422)
        Me.FeldBackground1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.Schiffeversenken.My.Resources.Resources.Metallplatte_skretched
        Me.Panel1.Controls.Add(Me.TimeLeftL)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(460, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(170, 482)
        Me.Panel1.TabIndex = 3
        '
        'FeldDialog10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 482)
        Me.Controls.Add(Me.StartBT)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.CloseBT)
        Me.Controls.Add(Me.BackgroundTLP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FeldDialog10"
        Me.Text = "Feld"
        Me.BackgroundTLP.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackgroundTLP As TableLayoutPanel
    Friend WithEvents TimeLeftL As Label
    Friend WithEvents CloseBT As Button
    Friend WithEvents FeldBackground1 As FeldBackground
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents AktionTSSL As ToolStripStatusLabel
    Friend WithEvents StartBT As Button
    Friend WithEvents Panel1 As Panel
End Class
