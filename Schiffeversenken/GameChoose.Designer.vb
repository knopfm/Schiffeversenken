<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameChoose
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
        Me.ConnectBT = New System.Windows.Forms.Button()
        Me.AbortBT = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.EinstellungenL = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DialogControlTP = New System.Windows.Forms.TableLayoutPanel()
        Me.Feld8RB = New System.Windows.Forms.RadioButton()
        Me.Feld10RB = New System.Windows.Forms.RadioButton()
        Me.NameTB = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.DialogControlTP.SuspendLayout()
        Me.SuspendLayout()
        '
        'ConnectBT
        '
        Me.ConnectBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConnectBT.Location = New System.Drawing.Point(3, 3)
        Me.ConnectBT.Name = "ConnectBT"
        Me.ConnectBT.Size = New System.Drawing.Size(75, 20)
        Me.ConnectBT.TabIndex = 0
        Me.ConnectBT.Text = "Verbinden"
        Me.ConnectBT.UseVisualStyleBackColor = True
        '
        'AbortBT
        '
        Me.AbortBT.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.AbortBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AbortBT.Location = New System.Drawing.Point(84, 3)
        Me.AbortBT.Name = "AbortBT"
        Me.AbortBT.Size = New System.Drawing.Size(75, 20)
        Me.AbortBT.TabIndex = 1
        Me.AbortBT.Text = "Abbrechen"
        Me.AbortBT.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.28374!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.71627!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(484, 211)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.EinstellungenL, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Feld8RB, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Feld10RB, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.NameTB, 0, 4)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(301, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(183, 211)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'EinstellungenL
        '
        Me.EinstellungenL.AutoSize = True
        Me.EinstellungenL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EinstellungenL.Location = New System.Drawing.Point(0, 0)
        Me.EinstellungenL.Margin = New System.Windows.Forms.Padding(0)
        Me.EinstellungenL.Name = "EinstellungenL"
        Me.EinstellungenL.Size = New System.Drawing.Size(183, 50)
        Me.EinstellungenL.TabIndex = 1
        Me.EinstellungenL.Text = "Einstellungen"
        Me.EinstellungenL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "[PH_Serversuche]"
        '
        'DialogControlTP
        '
        Me.DialogControlTP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DialogControlTP.ColumnCount = 2
        Me.DialogControlTP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.DialogControlTP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.DialogControlTP.Controls.Add(Me.ConnectBT, 0, 0)
        Me.DialogControlTP.Controls.Add(Me.AbortBT, 1, 0)
        Me.DialogControlTP.Location = New System.Drawing.Point(310, 173)
        Me.DialogControlTP.Name = "DialogControlTP"
        Me.DialogControlTP.RowCount = 1
        Me.DialogControlTP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.DialogControlTP.Size = New System.Drawing.Size(162, 26)
        Me.DialogControlTP.TabIndex = 3
        '
        'Feld8RB
        '
        Me.Feld8RB.AutoSize = True
        Me.Feld8RB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Feld8RB.Location = New System.Drawing.Point(3, 53)
        Me.Feld8RB.Name = "Feld8RB"
        Me.Feld8RB.Size = New System.Drawing.Size(177, 19)
        Me.Feld8RB.TabIndex = 2
        Me.Feld8RB.TabStop = True
        Me.Feld8RB.Text = "8x8"
        Me.Feld8RB.UseVisualStyleBackColor = True
        '
        'Feld10RB
        '
        Me.Feld10RB.AutoSize = True
        Me.Feld10RB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Feld10RB.Location = New System.Drawing.Point(3, 78)
        Me.Feld10RB.Name = "Feld10RB"
        Me.Feld10RB.Size = New System.Drawing.Size(177, 19)
        Me.Feld10RB.TabIndex = 3
        Me.Feld10RB.TabStop = True
        Me.Feld10RB.Text = "10x10"
        Me.Feld10RB.UseVisualStyleBackColor = True
        '
        'NameTB
        '
        Me.NameTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NameTB.Location = New System.Drawing.Point(3, 128)
        Me.NameTB.Name = "NameTB"
        Me.NameTB.ReadOnly = True
        Me.NameTB.Size = New System.Drawing.Size(177, 20)
        Me.NameTB.TabIndex = 4
        '
        'GameChoose
        '
        Me.AcceptButton = Me.ConnectBT
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.AbortBT
        Me.ClientSize = New System.Drawing.Size(484, 211)
        Me.Controls.Add(Me.DialogControlTP)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(500, 250)
        Me.Name = "GameChoose"
        Me.Text = "GameChoose"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.DialogControlTP.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ConnectBT As Button
    Friend WithEvents AbortBT As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents EinstellungenL As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DialogControlTP As TableLayoutPanel
    Friend WithEvents Feld8RB As RadioButton
    Friend WithEvents Feld10RB As RadioButton
    Friend WithEvents NameTB As TextBox
End Class
