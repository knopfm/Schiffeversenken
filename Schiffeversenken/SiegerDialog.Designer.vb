<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SiegerDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SiegerDialog))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GewonnenL = New System.Windows.Forms.Label()
        Me.SpielStatistikL = New System.Windows.Forms.Label()
        Me.CloseBT = New System.Windows.Forms.Button()
        Me.NeuesSpielBT = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.20755!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.79245!))
        Me.TableLayoutPanel1.Controls.Add(Me.GewonnenL, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SpielStatistikL, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(530, 192)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GewonnenL
        '
        Me.GewonnenL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GewonnenL.Font = New System.Drawing.Font("Stencil", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GewonnenL.Location = New System.Drawing.Point(0, 0)
        Me.GewonnenL.Margin = New System.Windows.Forms.Padding(0)
        Me.GewonnenL.Name = "GewonnenL"
        Me.GewonnenL.Size = New System.Drawing.Size(334, 192)
        Me.GewonnenL.TabIndex = 0
        Me.GewonnenL.Text = "Gewonnen"
        Me.GewonnenL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SpielStatistikL
        '
        Me.SpielStatistikL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpielStatistikL.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpielStatistikL.Location = New System.Drawing.Point(334, 0)
        Me.SpielStatistikL.Margin = New System.Windows.Forms.Padding(0)
        Me.SpielStatistikL.Name = "SpielStatistikL"
        Me.SpielStatistikL.Size = New System.Drawing.Size(196, 192)
        Me.SpielStatistikL.TabIndex = 1
        Me.SpielStatistikL.Text = "Spiel Statistik"
        Me.SpielStatistikL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CloseBT
        '
        Me.CloseBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CloseBT.BackgroundImage = CType(resources.GetObject("CloseBT.BackgroundImage"), System.Drawing.Image)
        Me.CloseBT.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseBT.Location = New System.Drawing.Point(12, 157)
        Me.CloseBT.Name = "CloseBT"
        Me.CloseBT.Size = New System.Drawing.Size(84, 23)
        Me.CloseBT.TabIndex = 1
        Me.CloseBT.Text = "Schließen"
        Me.CloseBT.UseVisualStyleBackColor = True
        '
        'NeuesSpielBT
        '
        Me.NeuesSpielBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NeuesSpielBT.BackgroundImage = CType(resources.GetObject("NeuesSpielBT.BackgroundImage"), System.Drawing.Image)
        Me.NeuesSpielBT.Location = New System.Drawing.Point(195, 157)
        Me.NeuesSpielBT.Name = "NeuesSpielBT"
        Me.NeuesSpielBT.Size = New System.Drawing.Size(92, 23)
        Me.NeuesSpielBT.TabIndex = 2
        Me.NeuesSpielBT.Text = "Neues Spiel"
        Me.NeuesSpielBT.UseVisualStyleBackColor = True
        '
        'SiegerDialog
        '
        Me.AcceptButton = Me.CloseBT
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.CancelButton = Me.CloseBT
        Me.ClientSize = New System.Drawing.Size(530, 192)
        Me.Controls.Add(Me.NeuesSpielBT)
        Me.Controls.Add(Me.CloseBT)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SiegerDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SiegerDialog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GewonnenL As Label
    Friend WithEvents SpielStatistikL As Label
    Friend WithEvents CloseBT As Button
    Friend WithEvents NeuesSpielBT As Button
End Class
