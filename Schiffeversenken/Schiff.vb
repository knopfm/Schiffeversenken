Public Class Schiff
    Public startPoint As Point
    Public endPoint As Point
    Public inhaber As Integer
    Public type As SchiffType
    Public direction As SchiffRichtung
    Private innerGetroffen As Integer = 0

    Public Function getroffen(pX As Integer, pY As Integer) As Boolean
        Select Case direction
            Case SchiffRichtung.LR
                Return startPoint.X <= pX And endPoint.X >= pX And startPoint.Y = pY
            Case SchiffRichtung.RL
                Return startPoint.X >= pX And endPoint.X <= pX And startPoint.Y = pY
            Case SchiffRichtung.OU
                Return startPoint.Y <= pY And endPoint.Y >= pY And startPoint.X = pX
            Case SchiffRichtung.UO
                Return startPoint.Y >= pY And endPoint.Y <= pY And startPoint.X = pX
            Case Else
                Return False
        End Select
    End Function

    Public Function getLaenge() As Integer
        Select Case type
            Case SchiffType._2er
                Return 2
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
            Case SchiffType._2er
                Select Case nr
                    Case 0
                        Return My.Resources.schiff_2_0
                    Case 1
                        Return My.Resources.schiff_2_1
                End Select
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
                        Return My.Resources.schiff_4_0
                    Case 1
                        Return My.Resources.schiff_4_1
                    Case 2
                        Return My.Resources.schiff_4_2
                    Case 3
                        Return My.Resources.schiff_4_3
                End Select
            Case SchiffType._5er
                Select Case nr
                    Case 0
                        Return My.Resources.schiff_5_0
                    Case 1
                        Return My.Resources.schiff_5_1
                    Case 2
                        Return My.Resources.schiff_5_2
                    Case 3
                        Return My.Resources.schiff_5_3
                    Case 4
                        Return My.Resources.schiff_5_4
                End Select
        End Select
        Return My.Resources.Wasser
    End Function

    Public Function getImage_g(nr As Integer) As Image
        Select Case type
            Case SchiffType._2er
                Select Case nr
                    Case 0
                        Return My.Resources.schiff_2_0_v
                    Case 1
                        Return My.Resources.schiff_2_1_v
                End Select
            Case SchiffType._3er
                Select Case nr
                    Case 0
                        Return My.Resources.schiff_3_0_v
                    Case 1
                        Return My.Resources.schiff_3_1_v
                    Case 2
                        Return My.Resources.schiff_3_2_v
                End Select
            Case SchiffType._4er
                Select Case nr
                    Case 0
                        Return My.Resources.schiff_4_0_v
                    Case 1
                        Return My.Resources.schiff_4_1_v
                    Case 2
                        Return My.Resources.schiff_4_2_v
                    Case 3
                        Return My.Resources.schiff_4_3_v
                End Select
            Case SchiffType._5er
                Select Case nr
                    Case 0
                        Return My.Resources.schiff_5_0_v
                    Case 1
                        Return My.Resources.schiff_5_1_v
                    Case 2
                        Return My.Resources.schiff_5_2_v
                    Case 3
                        Return My.Resources.schiff_5_3_v
                    Case 4
                        Return My.Resources.schiff_5_4_v
                End Select
        End Select
        Return My.Resources.Kreis
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

    Public Sub treffer()
        innerGetroffen += 1
    End Sub

    Public Function versenkt() As Boolean
        Return innerGetroffen >= getLaenge()
    End Function

    Public Property Convert As String
        Get
            Return "{" & startPoint.X & "#" & startPoint.Y & "#" & type & "#" & direction & "}"
        End Get
        Set(value As String)
            Dim rest As String = value.Substring(1)
            Dim x As Integer = rest.Substring(0, rest.IndexOf("#"))
            rest = rest.Substring(rest.IndexOf("#") + 1)
            startPoint = New Point(x, rest.Substring(0, rest.IndexOf("#")))
            rest = rest.Substring(rest.IndexOf("#") + 1)
            type = rest.Substring(0, rest.IndexOf("#"))
            rest = rest.Substring(rest.IndexOf("#") + 1)
            direction = rest.Substring(0, rest.IndexOf("}"))
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(s As String)
        Convert = s
    End Sub


End Class

Public Enum SchiffType
    _2er
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
