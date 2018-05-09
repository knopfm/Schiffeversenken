<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HauptmenüDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HauptmenüDialog))
        Me.StatistikBT = New System.Windows.Forms.Button()
        Me.ShopBT = New System.Windows.Forms.Button()
        Me.CloseBT = New System.Windows.Forms.Button()
        Me.PlayBT = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.LogoPB = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.LogoPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatistikBT
        '
        Me.StatistikBT.BackgroundImage = CType(resources.GetObject("StatistikBT.BackgroundImage"), System.Drawing.Image)
        Me.StatistikBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatistikBT.Enabled = False
        Me.StatistikBT.Location = New System.Drawing.Point(3, 155)
        Me.StatistikBT.Name = "StatistikBT"
        Me.StatistikBT.Size = New System.Drawing.Size(380, 70)
        Me.StatistikBT.TabIndex = 1
        Me.StatistikBT.Text = "Statistik"
        Me.StatistikBT.UseVisualStyleBackColor = True
        '
        'ShopBT
        '
        Me.ShopBT.BackgroundImage = CType(resources.GetObject("ShopBT.BackgroundImage"), System.Drawing.Image)
        Me.ShopBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShopBT.Enabled = False
        Me.ShopBT.Location = New System.Drawing.Point(3, 231)
        Me.ShopBT.Name = "ShopBT"
        Me.ShopBT.Size = New System.Drawing.Size(380, 70)
        Me.ShopBT.TabIndex = 2
        Me.ShopBT.Text = "Shop"
        Me.ShopBT.UseVisualStyleBackColor = True
        '
        'CloseBT
        '
        Me.CloseBT.BackgroundImage = CType(resources.GetObject("CloseBT.BackgroundImage"), System.Drawing.Image)
        Me.CloseBT.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CloseBT.Location = New System.Drawing.Point(3, 307)
        Me.CloseBT.Name = "CloseBT"
        Me.CloseBT.Size = New System.Drawing.Size(380, 70)
        Me.CloseBT.TabIndex = 3
        Me.CloseBT.Text = "Ende"
        Me.CloseBT.UseVisualStyleBackColor = True
        '
        'PlayBT
        '
        Me.PlayBT.BackgroundImage = CType(resources.GetObject("PlayBT.BackgroundImage"), System.Drawing.Image)
        Me.PlayBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlayBT.Location = New System.Drawing.Point(3, 79)
        Me.PlayBT.Name = "PlayBT"
        Me.PlayBT.Size = New System.Drawing.Size(380, 70)
        Me.PlayBT.TabIndex = 0
        Me.PlayBT.Text = "Spielen"
        Me.PlayBT.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Courier New", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 76)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "SCHIFFE VERSENKEN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LogoPB, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(784, 386)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 386.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.CloseBT, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.ShopBT, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.PlayBT, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.StatistikBT, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(386, 380)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'LogoPB
        '
        Me.LogoPB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogoPB.Location = New System.Drawing.Point(395, 3)
        Me.LogoPB.Name = "LogoPB"
        Me.LogoPB.Size = New System.Drawing.Size(386, 380)
        Me.LogoPB.TabIndex = 1
        Me.LogoPB.TabStop = False
        '
        'HauptmenüDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.CloseBT
        Me.ClientSize = New System.Drawing.Size(784, 386)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "HauptmenüDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hauptmenü"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.LogoPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StatistikBT As Button
    Friend WithEvents ShopBT As Button
    Friend WithEvents CloseBT As Button
    Friend WithEvents PlayBT As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents LogoPB As PictureBox
End Class
