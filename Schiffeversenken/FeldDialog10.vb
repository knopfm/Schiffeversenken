Public Class FeldDialog10
    Public Event FeldKlick(ft As FeldTeil, e As MouseEventArgs)
    Public Event Beenden()
    Public Event Start()

    Public Sub New(Name As String)
        InitializeComponent()
        Me.Text = Name
    End Sub

    Private Sub FeldDialog10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CloseBT.Text = Sprachpackete.GetUbersetzung("endingBT")
        StartBT.Text = Sprachpackete.GetUbersetzung("startenBT")
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

    Private Sub panel_Click(sender As Object, e As MouseEventArgs)
        Dim ft As FeldTeil = CType(sender, FeldTeil)
        RaiseEvent FeldKlick(ft, e)
    End Sub

    Public Sub platziereSchiff(schiff As Schiff, zustand As FeldTeilStatus)
        schiff.EndPunktBerechnen()

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
            ft.Zustand = zustand
        Next
    End Sub

    Private Sub StartBT_Click(sender As Object, e As EventArgs) Handles StartBT.Click
        RaiseEvent Start()
    End Sub

    Private Sub CloseBT_Click(sender As Object, e As EventArgs) Handles CloseBT.Click
        RaiseEvent Beenden()
    End Sub

    Public Sub setTime(pT As String)
        Invoke(New dSetT(AddressOf SetT), pT)
    End Sub
    Private Delegate Sub dSetT(pT As String)
    Private Sub SetT(pT As String)
         Me.TimeLeftL.Text = pT
    End Sub

    Public Sub diasableStop()
        Invoke(New ddS(AddressOf dS))
    End Sub
    Private Delegate Sub ddS()
    Private Sub dS()
        CloseBT.Visible = False
        StartBT.Visible = False
        For w As Integer = 0 To 9
            For h As Integer = 0 To 9
                Dim ft As FeldTeil = FeldBackground1.getControl(w, h)
                ft.getroffenAktiv = False
            Next
        Next
    End Sub

    Public Sub enableStart(e As Boolean)
        StartBT.Enabled = e
    End Sub

    Public Sub PerformStart()
        StartBT.PerformClick()
    End Sub

    Public Sub setLocation(p As Point)
        Invoke(New dsl(AddressOf sl), p)
    End Sub
    Private Delegate Sub dsl(p As Point)
    Private Sub sl(p As Point)
        Me.Location = p
    End Sub

    Public Sub SchiffeAktualisieren()
        For w As Integer = 0 To 9
            For h As Integer = 0 To 9
                Dim zustand As FeldTeilStatus = FeldBackground1.getControl(w, h).Zustand
                FeldBackground1.getControl(w, h).Zustand = zustand
            Next
        Next
    End Sub
End Class
