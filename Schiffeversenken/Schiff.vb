Public Class Schiff
    Public startPoint As Point
    Public endPoint As Point
    Public inhaber As Integer
    Public type As SchiffType
    Public direction As SchiffRichtung
    Private innerGetroffen As Integer = 0

    Public Function getroffen(pX As Integer, pY As Integer) As Boolean
        If (pX >= startPoint.X And pX <= endPoint.X And pY >= startPoint.Y And pY <= endPoint.y) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function getLaenge() As Integer
        Select Case type
            Case SchiffType._3er
                Return 3
            Case SchiffType._4er
                Return 4
            Case SchiffType._5er
                Return 5
            Case Else
                Return 0
        End Select
    End Function

    Public Function getImage(nr As Integer) As Image
        Select Case type
            Case SchiffType._3er
                Select Case nr
                    Case 0
                        Return My.Resources.schiff_3_0
                    Case 1
                        Return My.Resources.schiff_3_1
                    Case 2
                        Return My.Resources.schiff_3_2
                End Select
            Case SchiffType._4er
                Select Case nr
                    Case 0
                        Return My.Resources.schiff_3_0
                    Case 1
                        Return My.Resources.schiff_3_1
                    Case 2
                        Return My.Resources.schiff_3_1
                    Case 3
                        Return My.Resources.schiff_3_2
                End Select
            Case SchiffType._5er
                Select Case nr
                    Case 0
                        Return My.Resources.schiff_3_0
                    Case 1
                        Return My.Resources.schiff_3_1
                    Case 2
                        Return My.Resources.schiff_3_1
                    Case 3
                        Return My.Resources.schiff_3_1
                    Case 4
                        Return My.Resources.schiff_3_2
                End Select
        End Select
        Return My.Resources.Wasser
    End Function

    Public Function getImage_g(nr As Integer) As Image
        Select Case type
            Case SchiffType._3er
                Select Case nr
                    Case 0
                        Return My.Resources.schiff_3_0_g
                    Case 1
                        Return My.Resources.schiff_3_1_g
                    Case 2
                        Return My.Resources.schiff_3_2_g
                End Select
            Case SchiffType._4er
                Select Case nr
                    Case 0
                        Return My.Resources.schiff_3_0_g
                    Case 1
                        Return My.Resources.schiff_3_1_g
                    Case 2
                        Return My.Resources.schiff_3_1_g
                    Case 3
                        Return My.Resources.schiff_3_2_g
                End Select
            Case SchiffType._5er
                Select Case nr
                    Case 0
                        Return My.Resources.schiff_3_0_g
                    Case 1
                        Return My.Resources.schiff_3_1_g
                    Case 2
                        Return My.Resources.schiff_3_1_g
                    Case 3
                        Return My.Resources.schiff_3_1_g
                    Case 4
                        Return My.Resources.schiff_3_2_g
                End Select
        End Select
        Return My.Resources.Kreuz
    End Function

    Public Sub EndPunktBerechnen()
        Select Case Me.direction
            Case SchiffRichtung.LR
                Me.endPoint = New Point(Me.startPoint.X + (Me.getLaenge() - 1), Me.startPoint.Y)
            Case SchiffRichtung.RL
                Me.endPoint = New Point(Me.startPoint.X - (Me.getLaenge() - 1), Me.startPoint.Y)
            Case SchiffRichtung.OU
                Me.endPoint = New Point(Me.startPoint.X, Me.startPoint.Y + (Me.getLaenge() - 1))
            Case SchiffRichtung.UO
                Me.endPoint = New Point(Me.startPoint.X, Me.startPoint.Y - (Me.getLaenge() - 1))
        End Select
    End Sub

    Public Sub getroffen()
        innerGetroffen += 1
    End Sub

    Public Function versenkt() As Boolean
        Return innerGetroffen >= getLaenge()
    End Function
End Class

Public Enum SchiffType
    _3er
    _4er
    _5er
End Enum

Public Enum SchiffRichtung
    None 'Egal
    LR 'Links -> Rechts
    RL 'Rechts -> Links
    OU 'Oben -> Unten
    UO 'Unten -> Oben
End Enum
