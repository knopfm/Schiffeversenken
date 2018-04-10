Public Class FeldSetting
    Inherits MultiplayerPaket

    Private breite As Integer
    Private hoehe As Integer

    Public Const MAX_BREITE As Integer = 100
    Public Const MAX_HOEHE As Integer = 100

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

    Public Overrides Function serialize() As String
        Return serialize(Me)
    End Function

    Public Overrides Function serialize(pClass As MultiplayerPaket) As String
        Dim innerClass As FeldSetting = CType(pClass, FeldSetting)
        Return "{Breite=" & innerClass.getBreite().ToString & ";Hoehe=" & innerClass.getHoehe().ToString & "}"
    End Function

    Public Overrides Sub unserialize(pValue As String)
        unserialize(pValue, Me)
    End Sub

    Public Overrides Sub unserialize(pValue As String, pClass As MultiplayerPaket)
        Dim innerClass As FeldSetting = CType(pClass, FeldSetting)
        Dim work As List(Of String) = unserializeBlock(pValue)
        For Each obj As String In work
            Select Case obj.Substring(0, obj.IndexOf("="))
                Case "Breite"
                    innerClass.setBreite(obj.Substring(obj.IndexOf("=") + 1))
                Case "Hoehe"
                    innerClass.setHoehe(obj.Substring(obj.IndexOf("=") + 1))
            End Select
        Next
    End Sub
End Class
