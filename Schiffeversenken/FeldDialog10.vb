Public Class FeldDialog10

    Public Sub New(Name As String)
        InitializeComponent()
        Me.Text = Name
    End Sub

    Public Sub fillPanel()
        For w As Integer = 0 To FeldTLP.ColumnCount - 1
            For h As Integer = 0 To FeldTLP.RowCount - 1
                Dim p As New Panel
                p.Name = "p" & w & "v" & h
                p.Dock = DockStyle.Fill
                p.Margin = New Padding(0)
                p.Padding = New Padding(0)
                p.BackColor = Color.SteelBlue
                AddHandler p.Click, AddressOf panel_Click
                FeldTLP.Controls.Add(p, w, h)
            Next
        Next
    End Sub

    Private Sub FeldDialog10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub panel_Click(sender As Object, e As EventArgs)
        Dim p As Panel = CType(sender, Panel)
        p.BackColor = Color.LimeGreen
    End Sub

End Class
