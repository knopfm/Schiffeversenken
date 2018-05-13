<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SpielerSucheDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SpielerSucheDialog))
        Me.AbortBT = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ConnectBT = New System.Windows.Forms.Button()
        Me.ServerBT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AbortBT
        '
        Me.AbortBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AbortBT.BackColor = System.Drawing.SystemColors.Control
        Me.AbortBT.BackgroundImage = Global.Schiffeversenken.My.Resources.Resources.Metallplatte
        Me.AbortBT.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.AbortBT.ForeColor = System.Drawing.Color.Black
        Me.AbortBT.Location = New System.Drawing.Point(497, 179)
        Me.AbortBT.Name = "AbortBT"
        Me.AbortBT.Size = New System.Drawing.Size(75, 20)
        Me.AbortBT.TabIndex = 2
        Me.AbortBT.Text = "Zurück"
        Me.AbortBT.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(491, 211)
        Me.ListBox1.TabIndex = 0
        '
        'ConnectBT
        '
        Me.ConnectBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConnectBT.BackgroundImage = CType(resources.GetObject("ConnectBT.BackgroundImage"), System.Drawing.Image)
        Me.ConnectBT.Enabled = False
        Me.ConnectBT.ForeColor = System.Drawing.Color.Black
        Me.ConnectBT.Location = New System.Drawing.Point(497, 153)
        Me.ConnectBT.Name = "ConnectBT"
        Me.ConnectBT.Size = New System.Drawing.Size(75, 20)
        Me.ConnectBT.TabIndex = 1
        Me.ConnectBT.Text = "Verbinden"
        Me.ConnectBT.UseVisualStyleBackColor = True
        '
        'ServerBT
        '
        Me.ServerBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ServerBT.BackgroundImage = CType(resources.GetObject("ServerBT.BackgroundImage"), System.Drawing.Image)
        Me.ServerBT.ForeColor = System.Drawing.Color.Black
        Me.ServerBT.Location = New System.Drawing.Point(497, 12)
        Me.ServerBT.Name = "ServerBT"
        Me.ServerBT.Size = New System.Drawing.Size(75, 23)
        Me.ServerBT.TabIndex = 3
        Me.ServerBT.Text = "Server..."
        Me.ServerBT.UseVisualStyleBackColor = True
        '
        'SpielerSucheDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Schiffeversenken.My.Resources.Resources.Metallplatte_skretched
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.AbortBT
        Me.ClientSize = New System.Drawing.Size(584, 211)
        Me.Controls.Add(Me.ServerBT)
        Me.Controls.Add(Me.AbortBT)
        Me.Controls.Add(Me.ConnectBT)
        Me.Controls.Add(Me.ListBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(300, 200)
        Me.Name = "SpielerSucheDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spieler Suche"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AbortBT As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ConnectBT As Button
    Friend WithEvents ServerBT As Button
End Class
