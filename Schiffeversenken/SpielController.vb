Imports Schiffeversenken

Public Class SpielController
    Public Event NetzwerkSend(msgs As String)
    Public Event UnHide()
    Public Event Online()
    Public ichID As Integer
    Public duID As Integer
    Private WithEvents bottomForm As FeldDialog10
    Private WithEvents topForm As FeldDialog10
    Private status As SpielControllerStatus
    Private statusAnderer As SpielControllerStatus
    Private schiffe2ueberigPlatzieren As Integer = 1
    Private schiffe3ueberigPlatzieren As Integer = 2
    Private schiffe4ueberigPlatzieren As Integer = 1
    Private schiffe5ueberigPlatzieren As Integer = 1
    Private meineSchiffeListe As New List(Of Schiff)
    Private meineSchiffeFeld(9, 9) As Integer
    Private Zeitwächter As New Threading.Thread(AddressOf OwenTimer)
    Private startZeit As DateTime
    Private endZeit As DateTime
    Private lastX, lastY As Integer
    Private meineSchiffe2uebrig As Integer = schiffe2ueberigPlatzieren
    Private meineSchiffe3uebrig As Integer = schiffe3ueberigPlatzieren
    Private meineSchiffe4uebrig As Integer = schiffe4ueberigPlatzieren
    Private meineSchiffe5uebrig As Integer = schiffe5ueberigPlatzieren
    Private deineSchiffe2uebrig As Integer = meineSchiffe2uebrig
    Private deineSchiffe3uebrig As Integer = meineSchiffe3uebrig
    Private deineSchiffe4uebrig As Integer = meineSchiffe4uebrig
    Private deineSchiffe5uebrig As Integer = meineSchiffe5uebrig
    Private meineTreffer As Integer = 0
    Private meineDaneben As Integer = 0
    Private deineTreffer As Integer = 0
    Private deineDaneben As Integer = 0

    Public Sub New(ichID As Integer, duID As Integer)
        Me.ichID = ichID
        Me.duID = duID
    End Sub

    Public Sub PlanenPhaseBeginen()
        bottomForm = New FeldDialog10(Sprachpakete.GetUbersetzung("your_field"))
        topForm = New FeldDialog10(Sprachpakete.GetUbersetzung("my_field"))
        topForm.Show()
        topForm.setLocation(New Point(CInt(My.Computer.Screen.WorkingArea.Size.Width / 2 - topForm.Size.Width / 2), CInt(My.Computer.Screen.WorkingArea.Size.Height / 2 - topForm.Size.Height / 2)))
        Me.status = SpielControllerStatus.Planen
        Me.statusAnderer = SpielControllerStatus.Planen
        topForm.setTime(berechneInfoBoxPlanen())
    End Sub

    Private Function berechneInfoBoxPlanen() As String
        Dim s As String
        s = Sprachpakete.GetUbersetzung("msg_placeShip") & vbCrLf & vbCrLf
        s &= Sprachpakete.GetUbersetzung("shipsLeft") & ": " & vbCrLf
        s &= Sprachpakete.GetUbersetzung("_2erShips") & ": " & schiffe2ueberigPlatzieren & vbCrLf
        s &= Sprachpakete.GetUbersetzung("_3erShips") & ": " & schiffe3ueberigPlatzieren & vbCrLf
        s &= Sprachpakete.GetUbersetzung("_4erShips") & ": " & schiffe4ueberigPlatzieren & vbCrLf
        s &= Sprachpakete.GetUbersetzung("_5erShips") & ": " & schiffe5ueberigPlatzieren & vbCrLf
        If (schiffe2ueberigPlatzieren + schiffe3ueberigPlatzieren + schiffe4ueberigPlatzieren + schiffe5ueberigPlatzieren) = 0 Then
            s &= vbCrLf & Sprachpakete.GetUbersetzung("msg_startPress")
        End If
        If Me.status = SpielControllerStatus.ReadyStart Then
            s &= vbCrLf & Sprachpakete.GetUbersetzung("msg_NotReady")
        End If
        If Me.statusAnderer = SpielControllerStatus.ReadyStart Then
            s &= vbCrLf & Sprachpakete.GetUbersetzung("msg_Ready")
        End If
        Return s
    End Function

    Private Sub topForm_FeldKlick(ft As FeldTeil, e As MouseEventArgs) Handles topForm.FeldKlick
        If Not e.Button = MouseButtons.Left Then
            Exit Sub
        End If
        Dim x As Integer = CInt(ft.Name.Substring(1, ft.Name.IndexOf("v") - 1))
        Dim y As Integer = CInt(ft.Name.Substring(ft.Name.IndexOf("v") + 1))
        If Me.status = SpielControllerStatus.Planen Then
            If schiffe2ueberigPlatzieren = 0 And schiffe3ueberigPlatzieren = 0 And schiffe4ueberigPlatzieren = 0 And schiffe5ueberigPlatzieren = 0 Then
                topForm.enableStart(True)
                If MessageBox.Show(Sprachpakete.GetUbersetzung("msg_StartGame"), Sprachpakete.GetUbersetzung("placeship"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    topForm.PerformStart()
                End If
            Else
                Dim norden As Integer = y
                Dim osten As Integer = 9 - x
                Dim suden As Integer = 9 - y
                Dim westen As Integer = x
                If schiffImWeg(x, y, norden, osten, suden, westen) Then
                    MessageBox.Show(Sprachpakete.GetUbersetzung("msg_NoShipThere") & vbCrLf & Sprachpakete.GetUbersetzung("msg_NoShipThere2"), Sprachpakete.GetUbersetzung("placeship"), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Dim eingabe As New FeldPlatzierenDialog(topForm)
                    eingabe.setMoeglichkeiten(schiffe2ueberigPlatzieren, schiffe3ueberigPlatzieren, schiffe4ueberigPlatzieren, schiffe5ueberigPlatzieren, norden, osten, suden, westen)
                    If eingabe.ShowDialog() = DialogResult.OK Then
                        Dim newSchiff As New Schiff
                        newSchiff.direction = eingabe.Richtung
                        newSchiff.type = eingabe.Type
                        newSchiff.startPoint = New Point(x, y)
                        newSchiff.EndPunktBerechnen()
                        Select Case newSchiff.type
                            Case SchiffType._2er
                                schiffe2ueberigPlatzieren -= 1
                            Case SchiffType._3er
                                schiffe3ueberigPlatzieren -= 1
                            Case SchiffType._4er
                                schiffe4ueberigPlatzieren -= 1
                            Case SchiffType._5er
                                schiffe5ueberigPlatzieren -= 1
                        End Select
                        platziereSchiff(newSchiff)
                        If schiffe2ueberigPlatzieren = 0 And schiffe3ueberigPlatzieren = 0 And schiffe4ueberigPlatzieren = 0 And schiffe5ueberigPlatzieren = 0 Then
                            topForm.enableStart(True)
                        End If
                    End If
                End If
            End If
            topForm.setTime(berechneInfoBoxPlanen())
        End If
    End Sub



    Private Function schiffImWeg(x As Integer, y As Integer, ByRef norden As Integer, ByRef osten As Integer, ByRef suden As Integer, ByRef westen As Integer) As Boolean
        westen = -1
        For i As Integer = x To 0 Step -1
            If meineSchiffeFeld(i, y) = 0 Then
                westen += 1
            Else
                Exit For
            End If
        Next
        norden = -1
        For i As Integer = y To 0 Step -1
            If meineSchiffeFeld(x, i) = 0 Then
                norden += 1
            Else
                Exit For
            End If
        Next
        suden = -1
        For i As Integer = y To 9
            If meineSchiffeFeld(x, i) = 0 Then
                suden += 1
            Else
                Exit For
            End If
        Next
        osten = -1
        For i As Integer = x To 9
            If meineSchiffeFeld(i, y) = 0 Then
                osten += 1
            Else
                Exit For
            End If
        Next
        Return norden < 2 And osten < 2 And suden < 2 And westen < 2
    End Function

    Private Sub platziereSchiff(ship As Schiff)
        meineSchiffeListe.Add(ship)
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
            meineSchiffeFeld(p.X, p.Y) = Me.ichID
        Next
        topForm.platziereSchiff(ship, FeldTeilStatus.Schiff)
    End Sub

    Public Sub NetzwerkReceive(msg As String)
        If msg.StartsWith("ReadyPlay:") Then
            If CInt(msg.Substring(msg.IndexOf(":") + 1, (msg.IndexOf(";") - msg.IndexOf(":")) - 1)) = ichID Then
                If Me.statusAnderer = SpielControllerStatus.Planen And Me.status = SpielControllerStatus.Planen Then
                    Me.statusAnderer = SpielControllerStatus.ReadyStart
                    topForm.setTime(berechneInfoBoxPlanen())
                ElseIf Me.statusAnderer = SpielControllerStatus.Planen And Me.status = SpielControllerStatus.ReadyStart Then
                    Me.status = SpielControllerStatus.Warten
                    Me.statusAnderer = SpielControllerStatus.Schießen
                    Feld_vorbereiten()
                End If
            End If

        ElseIf msg.StartsWith("ShotBack:") Then
            Dim rest As String = msg.Substring(msg.IndexOf(":") + 1)
            Dim g As String = rest.Substring(0, rest.IndexOf(";"))
            rest = rest.Substring(rest.IndexOf(";") + 1)
            If CInt(rest.Substring(0, rest.IndexOf(";"))) = ichID Then
                Dim ft As FeldTeil = bottomForm.FeldBackground1.getControl(lastX, lastY)
                lastX = -1
                lastY = -1
                ft.Zustand = g
                If ft.Zustand = FeldTeilStatus.Versenkt Then
                    bottomForm.platziereSchiff(ft.Schiff, ft.Zustand)
                    Select Case ft.Schiff.type
                        Case SchiffType._2er
                            deineSchiffe2uebrig -= 1
                        Case SchiffType._3er
                            deineSchiffe3uebrig -= 1
                        Case SchiffType._4er
                            deineSchiffe4uebrig -= 1
                        Case SchiffType._5er
                            deineSchiffe5uebrig -= 1
                    End Select
                    Me.status = SpielControllerStatus.Schießen
                    Me.statusAnderer = SpielControllerStatus.Warten
                    meineTreffer += 1
                ElseIf ft.Zustand = FeldTeilStatus.Getroffen Then
                    Me.status = SpielControllerStatus.Schießen
                    Me.statusAnderer = SpielControllerStatus.Warten
                    meineTreffer += 1
                ElseIf ft.Zustand = FeldTeilStatus.Daneben Then
                    Me.status = SpielControllerStatus.Warten
                    Me.statusAnderer = SpielControllerStatus.Schießen
                    meineDaneben += 1
                End If

            End If
            Me.SchiffeAktualisieren()
            If (deineSchiffe2uebrig + deineSchiffe3uebrig + deineSchiffe4uebrig + deineSchiffe5uebrig) = 0 Then
                Me.status = SpielControllerStatus.Gewonnen
                Me.statusAnderer = SpielControllerStatus.Verloren
                Zeitwächter.Abort()
                Me.SchiffeAktualisieren()
                Dim dial As New SiegerDialog(bottomForm)
                dial.setState(Me.status)
                dial.setStatistik(berechneInfoBoxUnten())
                If dial.ShowDialog() = DialogResult.Yes Then
                    RaiseEvent NetzwerkSend("TryConnect:" & duID & ";" & ichID)
                    Me.status = SpielControllerStatus.Aus
                    Me.statusAnderer = SpielControllerStatus.Aus
                Else
                    RaiseEvent Online()
                End If
                beenden(True)
            End If

        ElseIf msg.StartsWith("Shot:") Then
            Dim rest As String = msg.Substring(msg.IndexOf(":") + 1)
            Dim x As String = rest.Substring(0, rest.IndexOf(";"))
            rest = rest.Substring(rest.IndexOf(";") + 1)
            Dim y As String = rest.Substring(0, rest.IndexOf(";"))
            rest = rest.Substring(rest.IndexOf(";") + 1)
            If CInt(rest.Substring(0, rest.IndexOf(";"))) = ichID Then
                Dim found As Boolean = False
                For Each ship As Schiff In meineSchiffeListe
                    If ship.getroffen(x, y) Then
                        ship.treffer()
                        If ship.versenkt() Then
                            topForm.FeldBackground1.getControl(x, y).Zustand = FeldTeilStatus.Versenkt
                            RaiseEvent NetzwerkSend("ShipBack:" & ship.Convert & ";" & duID & ";" & ichID)
                            Select Case ship.type
                                Case SchiffType._2er
                                    meineSchiffe2uebrig -= 1
                                Case SchiffType._3er
                                    meineSchiffe3uebrig -= 1
                                Case SchiffType._4er
                                    meineSchiffe4uebrig -= 1
                                Case SchiffType._5er
                                    meineSchiffe5uebrig -= 1
                            End Select
                        Else
                            topForm.FeldBackground1.getControl(x, y).Zustand = FeldTeilStatus.Getroffen
                        End If
                        found = True
                        Me.status = SpielControllerStatus.Warten
                        Me.statusAnderer = SpielControllerStatus.Schießen
                        deineTreffer += 1
                    End If
                Next
                If Not found Then
                    topForm.FeldBackground1.getControl(x, y).Zustand = FeldTeilStatus.Daneben
                    Me.status = SpielControllerStatus.Schießen
                    Me.statusAnderer = SpielControllerStatus.Warten
                    deineDaneben += 1
                End If
                RaiseEvent NetzwerkSend("ShotBack:" & topForm.FeldBackground1.getControl(x, y).Zustand & ";" & duID & ";" & ichID)
            End If
            Me.SchiffeAktualisieren()
            If (meineSchiffe2uebrig + meineSchiffe3uebrig + meineSchiffe4uebrig + meineSchiffe5uebrig) = 0 Then
                Me.status = SpielControllerStatus.Verloren
                Me.statusAnderer = SpielControllerStatus.Gewonnen
                Zeitwächter.Abort()
                Me.SchiffeAktualisieren()
                If Me.ichID <> Me.duID Then
                    Dim dial As New SiegerDialog(bottomForm)
                    dial.setState(Me.status)
                    dial.setStatistik(berechneInfoBoxUnten())
                    If dial.ShowDialog() = DialogResult.Yes Then
                        RaiseEvent NetzwerkSend("TryConnect:" & duID & ";" & ichID)
                        Me.status = SpielControllerStatus.Aus
                        Me.statusAnderer = SpielControllerStatus.Aus
                    Else
                        RaiseEvent Online()
                    End If
                    beenden(True)
                End If
            End If

        ElseIf msg.StartsWith("ShipBack:") Then
            Dim rest As String = msg.Substring(msg.IndexOf(":") + 1)
            Dim s As String = rest.Substring(0, rest.IndexOf(";"))
            rest = rest.Substring(rest.IndexOf(";") + 1)
            If CInt(rest.Substring(0, rest.IndexOf(";"))) = ichID Then
                Dim nS As New Schiff(s)
                nS.EndPunktBerechnen()
                bottomForm.FeldBackground1.getControl(lastX, lastY).Schiff = nS
            End If

        ElseIf msg.StartsWith("AbortGame:") Then
            If CInt(msg.Substring(msg.IndexOf(":") + 1, (msg.IndexOf(";") - msg.IndexOf(":")) - 1)) = ichID Then
                MessageBox.Show(Sprachpakete.GetUbersetzung("msg_abortGame"), Sprachpakete.GetUbersetzung("msg_abortGameL"), MessageBoxButtons.OK, MessageBoxIcon.Information)
                RaiseEvent Online()
                beenden(True)
            End If
        End If
    End Sub

    Public Sub NetzwerkLost()
        MsgBox(Now.ToString("[dd.MM.YYYY-HH.mm:ss.fff] ") & "Connection Lost")
        RaiseEvent Online()
        beenden(True)
    End Sub

    Private Sub Feld_vorbereiten()
        Zeitwächter.Start()
        startZeit = Now
        bottomForm.Show()
        topForm.diasableStop()
        topForm.Location = New Point(CInt(topForm.Location.X), CInt(My.Computer.Screen.WorkingArea.Size.Height / 2 - topForm.Size.Height + 2))
        bottomForm.Location = New Point(CInt(topForm.Location.X), CInt(My.Computer.Screen.WorkingArea.Size.Height / 2 + 2))
    End Sub

    Private Sub topForm_Start() Handles topForm.Start
        If Me.statusAnderer = SpielControllerStatus.Planen And Me.statusAnderer = SpielControllerStatus.Planen Then
            Me.status = SpielControllerStatus.ReadyStart
            topForm.setTime(berechneInfoBoxPlanen())
        ElseIf Me.status = SpielControllerStatus.Planen And Me.statusAnderer = SpielControllerStatus.ReadyStart Then
            Me.status = SpielControllerStatus.Schießen
            Me.statusAnderer = SpielControllerStatus.Warten
            Feld_vorbereiten()
        End If
        RaiseEvent NetzwerkSend("ReadyPlay:" & duID & ";" & ichID)
        topForm.enableStart(False)
    End Sub

    Private Sub bottomForm_FeldKlick(ft As FeldTeil, e As MouseEventArgs) Handles bottomForm.FeldKlick
        If e.Button = MouseButtons.Left Then
            If Me.status = SpielControllerStatus.Schießen Or (Me.status = SpielControllerStatus.Warten And Me.duID = Me.ichID) Then
                If ft.Zustand = FeldTeilStatus.Wasser Then
                    lastX = ft.getX()
                    lastY = ft.getY()
                    RaiseEvent NetzwerkSend("Shot:" & ft.getX() & ";" & ft.getY() & ";" & duID & ";" & ichID)
                End If
            End If
        End If
    End Sub

    Private Sub SchiffeAktualisieren()
        bottomForm.SchiffeAktualisieren()
        topForm.SchiffeAktualisieren()
        bottomForm.setTime(berechneInfoBoxUnten())
        topForm.setTime(berechneInfoBoxOben())
    End Sub

    Private Function berechneInfoBoxOben() As String
        Dim ret As String = Sprachpakete.GetUbersetzung("points") & ":"
        If (deineTreffer + deineDaneben) = 0 Then
            ret &= ""
        Else
            ret &= Format((deineTreffer / (deineTreffer + deineDaneben)) * 100, "0.00")
        End If
        ret &= vbCrLf & vbCrLf
        ret &= Sprachpakete.GetUbersetzung("shipsLeft") & ": " & vbCrLf
        ret &= Sprachpakete.GetUbersetzung("_2erShips") & ": " & meineSchiffe2uebrig & vbCrLf
        ret &= Sprachpakete.GetUbersetzung("_3erShips") & ": " & meineSchiffe3uebrig & vbCrLf
        ret &= Sprachpakete.GetUbersetzung("_4erShips") & ": " & meineSchiffe4uebrig & vbCrLf
        ret &= Sprachpakete.GetUbersetzung("_5erShips") & ": " & meineSchiffe5uebrig & vbCrLf
        ret &= vbCrLf & Sprachpakete.GetUbersetzung("yourState") & ": " & translateState(Me.statusAnderer)
        Return ret
    End Function

    Private Function berechneInfoBoxUnten() As String
        Dim span As TimeSpan = endZeit - startZeit
        Dim ret As String = Sprachpakete.GetUbersetzung("gameTime") & ": "
        ret &= span.ToString("mm\:ss")
        ret &= vbCrLf & vbCrLf
        ret &= Sprachpakete.GetUbersetzung("points") & ":"
        If (meineTreffer + meineDaneben) = 0 Then
            ret &= ""
        Else
            ret &= Format((meineTreffer / (meineTreffer + meineDaneben)) * 100, "0.00")
        End If
        ret &= vbCrLf & vbCrLf
        ret &= Sprachpakete.GetUbersetzung("shipsLeft") & ": " & vbCrLf
        ret &= Sprachpakete.GetUbersetzung("_2erShips") & ": " & deineSchiffe2uebrig & vbCrLf
        ret &= Sprachpakete.GetUbersetzung("_3erShips") & ": " & deineSchiffe3uebrig & vbCrLf
        ret &= Sprachpakete.GetUbersetzung("_4erShips") & ": " & deineSchiffe4uebrig & vbCrLf
        ret &= Sprachpakete.GetUbersetzung("_5erShips") & ": " & deineSchiffe5uebrig & vbCrLf
        ret &= vbCrLf & Sprachpakete.GetUbersetzung("myState") & ": " & translateState(Me.status)
        Return ret
    End Function

    Private Sub OwenTimer()
        Do
            Try
                Threading.Thread.Sleep(100)
                endZeit = Now
                Zeitwächter_Tick()
            Catch ex As Threading.ThreadAbortException
                Exit Do
            Catch ex As Exception
                Throw ex
            End Try
        Loop
    End Sub

    Private Sub Zeitwächter_Tick()
        bottomForm.setTime(berechneInfoBoxUnten())
        topForm.setTime(berechneInfoBoxOben())
    End Sub

    Private Sub Form_Beenden() Handles bottomForm.Beenden, topForm.Beenden
        If MessageBox.Show(Sprachpakete.GetUbersetzung("msg_abortQ"), Sprachpakete.GetUbersetzung("msg_abortGameL"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            RaiseEvent Online()
            beenden(Me.status = SpielControllerStatus.Verloren Or Me.status = SpielControllerStatus.Gewonnen)
        End If
    End Sub

    Private Sub beenden(netzwerknachricht As Boolean)
        If Not netzwerknachricht Then
            RaiseEvent NetzwerkSend("AbortGame:" & duID & ";" & ichID)
        End If
        If Zeitwächter IsNot Nothing Then
            Zeitwächter.Abort()
        End If
        Me.Dispose()
        RaiseEvent UnHide()
    End Sub

    Public Sub Dispose()
        Try
            topForm.Dispose()
        Catch ex As Exception
        End Try
        Try
            bottomForm.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Public Shared Function translateState(s As SpielControllerStatus) As String
        Select Case s
            Case SpielControllerStatus.Gewonnen
                Return Sprachpakete.GetUbersetzung("state_win")
            Case SpielControllerStatus.Verloren
                Return Sprachpakete.GetUbersetzung("state_loose")
            Case SpielControllerStatus.Schießen
                Return Sprachpakete.GetUbersetzung("state_shot")
            Case SpielControllerStatus.Warten
                Return Sprachpakete.GetUbersetzung("state_wait")
            Case Else
                Return s.ToString()
        End Select
    End Function
End Class

Public Enum SpielControllerStatus
    Aus
    Planen
    ReadyStart
    Warten
    Schießen
    Verloren
    Gewonnen
End Enum