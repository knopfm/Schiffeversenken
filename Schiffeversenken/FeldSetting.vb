Public Class FeldSetting
    Private breite As Integer
    Private hoehe As Integer

    Public Const MAX_BREITE As Integer = 10
    Public Const MAX_HOEHE As Integer = 10

    Public Sub New()
        Me.New(MAX_BREITE, MAX_HOEHE)
    End Sub

    Public Sub New(pBreite As Integer, pHoehe As Integer)
        setBreite(pBreite)
        setHoehe(pHoehe)
    End Sub

    Public Function getBreite() As Integer
        Return breite
    End Function

    Public Function getHoehe() As Integer
        Return hoehe
    End Function

    Public Sub setBreite(pValue As Integer)
        If pValue <= MAX_BREITE And pValue > 0 Then
            breite = pValue
        Else
            breite = MAX_BREITE
        End If
    End Sub

    Public Sub setHoehe(pValue As Integer)
        If pValue <= MAX_HOEHE And pValue > 0 Then
            hoehe = pValue
        Else
            hoehe = MAX_HOEHE
        End If
    End Sub
End Class
