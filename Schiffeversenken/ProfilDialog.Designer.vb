<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfilDialog
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.NameL = New System.Windows.Forms.Label()
        Me.NicknameL = New System.Windows.Forms.Label()
        Me.GlobaleIDL = New System.Windows.Forms.Label()
        Me.NicknameTB = New System.Windows.Forms.TextBox()
        Me.GlobaleIDTB = New System.Windows.Forms.TextBox()
        Me.NameTB = New System.Windows.Forms.TextBox()
        Me.SchiffeBT = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.SaveBT = New System.Windows.Forms.Button()
        Me.CancelBT = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Chart1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(784, 411)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Chart1
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(395, 3)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(386, 344)
        Me.Chart1.TabIndex = 0
        Me.Chart1.TabStop = False
        Me.Chart1.Text = "Statistiken"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.NameL, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.NicknameL, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.GlobaleIDL, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.NicknameTB, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.GlobaleIDTB, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.NameTB, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.SchiffeBT, 0, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(386, 171)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'NameL
        '
        Me.NameL.AutoSize = True
        Me.NameL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NameL.Location = New System.Drawing.Point(3, 0)
        Me.NameL.Name = "NameL"
        Me.NameL.Size = New System.Drawing.Size(187, 40)
        Me.NameL.TabIndex = 5
        Me.NameL.Text = "Name"
        Me.NameL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NicknameL
        '
        Me.NicknameL.AutoSize = True
        Me.NicknameL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NicknameL.Location = New System.Drawing.Point(3, 40)
        Me.NicknameL.Name = "NicknameL"
        Me.NicknameL.Size = New System.Drawing.Size(187, 40)
        Me.NicknameL.TabIndex = 6
        Me.NicknameL.Text = "Nickname"
        Me.NicknameL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GlobaleIDL
        '
        Me.GlobaleIDL.AutoSize = True
        Me.GlobaleIDL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GlobaleIDL.Location = New System.Drawing.Point(3, 80)
        Me.GlobaleIDL.Name = "GlobaleIDL"
        Me.GlobaleIDL.Size = New System.Drawing.Size(187, 40)
        Me.GlobaleIDL.TabIndex = 7
        Me.GlobaleIDL.Text = "Globale ID"
        Me.GlobaleIDL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NicknameTB
        '
        Me.NicknameTB.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NicknameTB.Location = New System.Drawing.Point(196, 50)
        Me.NicknameTB.Name = "NicknameTB"
        Me.NicknameTB.Size = New System.Drawing.Size(187, 20)
        Me.NicknameTB.TabIndex = 1
        '
        'GlobaleIDTB
        '
        Me.GlobaleIDTB.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GlobaleIDTB.Location = New System.Drawing.Point(196, 90)
        Me.GlobaleIDTB.Name = "GlobaleIDTB"
        Me.GlobaleIDTB.ReadOnly = True
        Me.GlobaleIDTB.Size = New System.Drawing.Size(187, 20)
        Me.GlobaleIDTB.TabIndex = 2
        '
        'NameTB
        '
        Me.NameTB.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NameTB.Location = New System.Drawing.Point(196, 10)
        Me.NameTB.Name = "NameTB"
        Me.NameTB.Size = New System.Drawing.Size(187, 20)
        Me.NameTB.TabIndex = 0
        '
        'SchiffeBT
        '
        Me.SchiffeBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SchiffeBT.Location = New System.Drawing.Point(3, 123)
        Me.SchiffeBT.Name = "SchiffeBT"
        Me.SchiffeBT.Size = New System.Drawing.Size(187, 45)
        Me.SchiffeBT.TabIndex = 10
        Me.SchiffeBT.Text = "Zeige Schiffe"
        Me.SchiffeBT.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.SaveBT, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.CancelBT, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(395, 353)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(386, 55)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'SaveBT
        '
        Me.SaveBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaveBT.Location = New System.Drawing.Point(3, 3)
        Me.SaveBT.Name = "SaveBT"
        Me.SaveBT.Size = New System.Drawing.Size(187, 49)
        Me.SaveBT.TabIndex = 0
        Me.SaveBT.Text = "Speichern"
        Me.SaveBT.UseVisualStyleBackColor = True
        '
        'CancelBT
        '
        Me.CancelBT.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CancelBT.Location = New System.Drawing.Point(196, 3)
        Me.CancelBT.Name = "CancelBT"
        Me.CancelBT.Size = New System.Drawing.Size(187, 49)
        Me.CancelBT.TabIndex = 1
        Me.CancelBT.Text = "Abbrechen"
        Me.CancelBT.UseVisualStyleBackColor = True
        '
        'ProfilDialog
        '
        Me.AcceptButton = Me.SaveBT
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelBT
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProfilDialog"
        Me.Text = "Profil"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents NameL As Label
    Friend WithEvents NicknameL As Label
    Friend WithEvents GlobaleIDL As Label
    Friend WithEvents NicknameTB As TextBox
    Friend WithEvents GlobaleIDTB As TextBox
    Friend WithEvents NameTB As TextBox
    Friend WithEvents SchiffeBT As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents SaveBT As Button
    Friend WithEvents CancelBT As Button
End Class
