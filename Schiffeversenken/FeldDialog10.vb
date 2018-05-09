Public Class FeldDialog10
    Public Event FeldKlick(ft As FeldTeil)
    Public Event Beenden()
    Public Event Start()

    Public Sub New(Name As String)
        InitializeComponent()
        Me.Text = Name
    End Sub

    Private Sub FeldDialog10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For w As Integer = 0 To 9
            For h As Integer = 0 To 9
                Dim p As New FeldTeil
                p.Name = "p" & w & "v" & h
                p.Margin = New Padding(0)
                p.Padding = New Padding(0)
                AddHandler p.Klick, AddressOf panel_Click
                FeldBackground1.Add(p, w, h)
            Next
        Next
    End Sub

    Private Sub panel_Click(sender As Object, e As EventArgs)
        Dim ft As FeldTeil = CType(sender, FeldTeil)
        RaiseEvent FeldKlick(ft)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim ship As New Schiff
        ship.direction = SchiffRichtung.OU
        ship.type = SchiffType._4er
        ship.inhaber = 1
        ship.startPoint = New Point(5, 5)
        platziereSchiff(ship)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim ship As New Schiff
        ship.direction = SchiffRichtung.UO
        ship.type = SchiffType._4er
        ship.inhaber = 1
        ship.startPoint = New Point(5, 5)
        platziereSchiff(ship)
    End Sub

    Public Function platziereSchiff(schiff As Schiff) As Boolean
        schiff.EndPunktBerechnen()
        'Mittelpunkte berechnen
        Dim mittelPunkte As New List(Of Point)
        If schiff.direction = SchiffRichtung.LR Then
            For i As Integer = 0 To schiff.getLaenge() - 1
                mittelPunkte.Add(New Point(schiff.startPoint.X + i, schiff.startPoint.Y))
            Next
        ElseIf schiff.direction = SchiffRichtung.RL Then
            For i As Integer = 0 To schiff.getLaenge() - 1
                mittelPunkte.Add(New Point(schiff.startPoint.X - i, schiff.startPoint.Y))
            Next
        ElseIf schiff.direction = SchiffRichtung.OU Then
            For i As Integer = 0 To schiff.getLaenge() - 1
                mittelPunkte.Add(New Point(schiff.startPoint.X, schiff.startPoint.Y + i))
            Next
        ElseIf schiff.direction = SchiffRichtung.UO Then
            For i As Integer = 0 To schiff.getLaenge() - 1
                mittelPunkte.Add(New Point(schiff.startPoint.X, schiff.startPoint.Y - i))
            Next
        End If

        For Each p As Point In mittelPunkte
            Dim ft As FeldTeil = FeldBackground1.getControl(p.X, p.Y)
            ft.Schiff = schiff
            ft.Zustand = FeldTeilState.Schiff
        Next
        Return False
    End Function

    Public Sub setTime(pT As String)
        Me.TimeLeftL.Text = pT
    End Sub

    Private Sub CloseBT_Click(sender As Object, e As EventArgs) Handles CloseBT.Click
        RaiseEvent Beenden()
    End Sub

    Public Sub diasableStop()
        CloseBT.Visible = False
        StartBT.Visible = False
    End Sub

    Private Sub StartBT_Click(sender As Object, e As EventArgs) Handles StartBT.Click
        RaiseEvent Start()
    End Sub

    Public Sub enableStart(e As Boolean)
        StartBT.Enabled = e
    End Sub
End Class
