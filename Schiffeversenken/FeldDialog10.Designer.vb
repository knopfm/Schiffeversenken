<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeldDialog10
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
        Me.BackgroundTLP = New System.Windows.Forms.TableLayoutPanel()
        Me.FeldTLP = New System.Windows.Forms.TableLayoutPanel()
        Me.RightTLP = New System.Windows.Forms.TableLayoutPanel()
        Me.TimeLeftL = New System.Windows.Forms.Label()
        Me.BackgroundTLP.SuspendLayout()
        Me.RightTLP.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackgroundTLP
        '
        Me.BackgroundTLP.ColumnCount = 2
        Me.BackgroundTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.09711!))
        Me.BackgroundTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.90289!))
        Me.BackgroundTLP.Controls.Add(Me.FeldTLP, 0, 0)
        Me.BackgroundTLP.Controls.Add(Me.RightTLP, 1, 0)
        Me.BackgroundTLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackgroundTLP.Location = New System.Drawing.Point(0, 0)
        Me.BackgroundTLP.Margin = New System.Windows.Forms.Padding(0)
        Me.BackgroundTLP.Name = "BackgroundTLP"
        Me.BackgroundTLP.RowCount = 1
        Me.BackgroundTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BackgroundTLP.Size = New System.Drawing.Size(762, 422)
        Me.BackgroundTLP.TabIndex = 0
        '
        'FeldTLP
        '
        Me.FeldTLP.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.FeldTLP.ColumnCount = 10
        Me.FeldTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.FeldTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.FeldTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.FeldTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.FeldTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.FeldTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.FeldTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.FeldTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.FeldTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.FeldTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.FeldTLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FeldTLP.Location = New System.Drawing.Point(20, 20)
        Me.FeldTLP.Margin = New System.Windows.Forms.Padding(20)
        Me.FeldTLP.Name = "FeldTLP"
        Me.FeldTLP.RowCount = 10
        Me.FeldTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.FeldTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.FeldTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.FeldTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.FeldTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.FeldTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.FeldTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.FeldTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.FeldTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.FeldTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.FeldTLP.Size = New System.Drawing.Size(516, 382)
        Me.FeldTLP.TabIndex = 0
        '
        'RightTLP
        '
        Me.RightTLP.ColumnCount = 1
        Me.RightTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RightTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.RightTLP.Controls.Add(Me.TimeLeftL, 0, 0)
        Me.RightTLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RightTLP.Location = New System.Drawing.Point(559, 3)
        Me.RightTLP.Name = "RightTLP"
        Me.RightTLP.RowCount = 5
        Me.RightTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.RightTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.RightTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.RightTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.RightTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.RightTLP.Size = New System.Drawing.Size(200, 416)
        Me.RightTLP.TabIndex = 1
        '
        'TimeLeftL
        '
        Me.TimeLeftL.AutoSize = True
        Me.TimeLeftL.Location = New System.Drawing.Point(3, 0)
        Me.TimeLeftL.Name = "TimeLeftL"
        Me.TimeLeftL.Size = New System.Drawing.Size(39, 13)
        Me.TimeLeftL.TabIndex = 0
        Me.TimeLeftL.Text = "Label1"
        '
        'FeldDialog10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 422)
        Me.Controls.Add(Me.BackgroundTLP)
        Me.Name = "FeldDialog10"
        Me.Text = "Feld"
        Me.BackgroundTLP.ResumeLayout(False)
        Me.RightTLP.ResumeLayout(False)
        Me.RightTLP.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundTLP As TableLayoutPanel
    Friend WithEvents FeldTLP As TableLayoutPanel
    Friend WithEvents RightTLP As TableLayoutPanel
    Friend WithEvents TimeLeftL As Label
End Class
