Public Class SpielController
    Public Event NetzwerkSend(msg As String)
    Public Event Time(pT As String)
    Public Event Beenden()
    Public Event changeLayout()
    Public Event placeSchip(schip As Schiff)
    Public Event Start(e As Boolean)
    Public ichID As Integer
    Public duID As Integer
    Private Zeitwächter As Timer
    Private startZeit As DateTime
    Private status As SpielControllerStatus = SpielControllerStatus.Aus
    Private schiffe2ueberig As Integer = 1
    Private schiffe3ueberig As Integer = 2
    Private schiffe4ueberig As Integer = 1
    Private schiffe5ueberig As Integer = 1
    Private schiffListe As New List(Of Schiff)
    Private schiffFeld(10, 10) As Integer
    Private statusAnderer As SpielControllerStatus = SpielControllerStatus.Aus

    Public Sub New(ichID As Integer, duID As Integer)
        Me.ichID = ichID
        Me.duID = duID
    End Sub

    Public Sub NetzwerkReceive(msg As String)
        If msg.StartsWith("ReadyPlay:") Then
            If Me.statusAnderer = SpielControllerStatus.Planen And Me.status = SpielControllerStatus.Planen Then
                Me.statusAnderer = SpielControllerStatus.ReadyStart
            ElseIf Me.statusAnderer = SpielControllerStatus.Planen And Me.status = SpielControllerStatus.ReadyStart Then
                Me.status = SpielControllerStatus.Warten
                Me.statusAnderer = SpielControllerStatus.Schießen
                Feld_vorbereiten()
            End If

            'TODO: weitere nachrichten
        End If
    End Sub

    Public Sub NetzwerkLost()

    End Sub

    Public Sub EigenesFeldKlick(ft As FeldTeil)
        Dim x As Integer = CInt(ft.Name.Substring(1, ft.Name.IndexOf("v") - 1))
        Dim y As Integer = CInt(ft.Name.Substring(ft.Name.IndexOf("v") + 1))
        Select Case Me.status
            Case SpielControllerStatus.Planen
                Dim eingabe As New FeldPlatzierenDialog
                Dim norden As Integer = y
                Dim osten As Integer = 9 - x
                Dim suden As Integer = 9 - y
                Dim westen As Integer = x
                If schiffImWeg(x, y, norden, osten, suden, westen) Then
                    MessageBox.Show(Sprachpackete.GetUbersetzung("msg_NoShipThere") & vbCrLf & Sprachpackete.GetUbersetzung("msg_NoShipThere2"), Sprachpackete.GetUbersetzung("placeship"), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    eingabe.setMoeglichkeiten(schiffe2ueberig, schiffe3ueberig, schiffe4ueberig, schiffe5ueberig, norden, osten, suden, westen)
                    If eingabe.ShowDialog() = DialogResult.OK Then
                        Dim newSchiff As New Schiff
                        newSchiff.direction = eingabe.Richtung
                        newSchiff.type = eingabe.Type
                        newSchiff.startPoint = New Point(x, y)
                        newSchiff.EndPunktBerechnen()
                        Select Case newSchiff.type
                            Case SchiffType._2er
                                schiffe2ueberig -= 1
                            Case SchiffType._3er
                                schiffe3ueberig -= 1
                            Case SchiffType._4er
                                schiffe4ueberig -= 1
                            Case SchiffType._5er
                                schiffe5ueberig -= 1
                        End Select
                        platziereSchiff(newSchiff)
                        If schiffe2ueberig = 0 And schiffe3ueberig = 0 And schiffe4ueberig = 0 And schiffe5ueberig = 0 Then
                            RaiseEvent Start(True)
                        End If
                    End If
                End If
            Case SpielControllerStatus.Schießen
                'TODO: schießen

            Case Else
                'Case SpielControllerState.Warten
                'Case SpielControllerState.Start
                'Case SpielControllerState.Ende

        End Select
    End Sub

    Private Sub platziereSchiff(ship As Schiff)
        schiffListe.Add(ship)
        ship.EndPunktBerechnen()
        Dim mittelPunkte As New List(Of Point)
        If ship.direction = SchiffRichtung.LR Then
            For i As Integer = 0 To ship.getLaenge() - 1
                mittelPunkte.Add(New Point(ship.startPoint.X + i, ship.startPoint.Y))
            Next
        ElseIf ship.direction = SchiffRichtung.RL Then
            For i As Integer = 0 To ship.getLaenge() - 1
                mittelPunkte.Add(New Point(ship.startPoint.X - i, ship.startPoint.Y))
            Next
        ElseIf ship.direction = SchiffRichtung.OU Then
            For i As Integer = 0 To ship.getLaenge() - 1
                mittelPunkte.Add(New Point(ship.startPoint.X, ship.startPoint.Y + i))
            Next
        ElseIf ship.direction = SchiffRichtung.UO Then
            For i As Integer = 0 To ship.getLaenge() - 1
                mittelPunkte.Add(New Point(ship.startPoint.X, ship.startPoint.Y - i))
            Next
        End If
        For Each p As Point In mittelPunkte
            schiffFeld(p.X, p.Y) = Me.ichID
        Next
        RaiseEvent placeSchip(ship)
    End Sub

    Private Function schiffImWeg(x As Integer, y As Integer, norden As Integer, osten As Integer, suden As Integer, westen As Integer) As Boolean
        'TODO: schiffe überprüfen, oder in FeldPlatzierenDialog auslagern
        Return norden < 3 And osten < 3 And suden < 3 And westen < 3
    End Function

    Private Sub Zeitwächter_Tick()
        Dim span As TimeSpan = Now - startZeit
        RaiseEvent Time(span.ToString("mm\:ss"))
    End Sub

    Public Sub stopGame()
        If Zeitwächter IsNot Nothing Then
            Zeitwächter.Enabled = False
        End If
    End Sub

    Public Sub startGame()
        Me.status = SpielControllerStatus.Planen
        Me.statusAnderer = SpielControllerStatus.Planen
    End Sub

    Public Sub startKlick()
        If Me.statusAnderer = SpielControllerStatus.Planen And Me.statusAnderer = SpielControllerStatus.Planen Then
            Me.status = SpielControllerStatus.ReadyStart
        ElseIf Me.status = SpielControllerStatus.Planen And Me.statusAnderer = SpielControllerStatus.ReadyStart Then
            Me.status = SpielControllerStatus.Schießen
            Me.statusAnderer = SpielControllerStatus.Warten
            Feld_vorbereiten()
        End If
        RaiseEvent NetzwerkSend("ReadyPlay:" & duID & ";" & ichID)
        RaiseEvent Start(False)
    End Sub

    Private Sub Feld_vorbereiten()
        Zeitwächter = New Timer
        AddHandler Zeitwächter.Tick, AddressOf Zeitwächter_Tick
        Zeitwächter.Interval = 100
        Zeitwächter.Start()
        Zeitwächter.Enabled = True
        startZeit = Now
        RaiseEvent changeLayout()

    End Sub

End Class

Public Enum SpielControllerStatus
    Aus
    Planen
    ReadyStart
    Warten
    Schießen
    Ende
End Enum

'TODO: hierrüber läuft das spiel 
'       Zeit, Mausklicks, netzwerk, anzeige, schiffe, statistik
'TODO: übrige schiffe einbinden
