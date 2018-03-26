Public Class Schiff
    Inherits MultiplayerPaket

    Private laenge As Integer
    Private typ As Integer
    Private anzahlWaffen As Integer
    Private bild As Integer
    Public Const MAX_SCHIFF_LAENGE As Integer = 5
    Public Const MAX_SCHIFF_ANZAHL_WAFFEN As Integer = 1000

    Public Sub New()
        Me.New(MAX_SCHIFF_LAENGE, 0)
    End Sub

    Public Sub New(pLaenge As Integer, pTyp As Integer)
        Me.New(pLaenge, pTyp, MAX_SCHIFF_ANZAHL_WAFFEN / 10)
    End Sub

    Public Sub New(pLaenge As Integer, pTyp As Integer, pAnzahlWaffen As Integer)
        Me.New(pLaenge, pTyp, pAnzahlWaffen, 1)
    End Sub

    Public Sub New(pLaenge As Integer, pTyp As Integer, pAnzahlWaffen As Integer, pBild As Integer)
        setLaenge(pLaenge)
        setTyp(pTyp)
        setAnzahlWaffen(pAnzahlWaffen)
        setBild(pBild)
    End Sub

    Public Function getLaenge() As Integer
        Return laenge
    End Function

    Public Function getTyp() As Integer
        Return typ
    End Function

    Public Function getAnzahlWaffen() As Integer
        Return anzahlWaffen
    End Function

    Public Function getBild() As Integer
        Return bild
    End Function

    Public Sub setLaenge(pValue As Integer)
        If pValue <= MAX_SCHIFF_LAENGE And pValue >= 2 Then
            laenge = pValue
        Else
            laenge = MAX_SCHIFF_LAENGE
        End If
    End Sub

    Public Sub setTyp(pValue As Integer)
        typ = pValue
    End Sub

    Public Sub setAnzahlWaffen(pValue)
        If pValue <= MAX_SCHIFF_ANZAHL_WAFFEN And pValue >= 0 Then
            anzahlWaffen = pValue
        Else
            anzahlWaffen = MAX_SCHIFF_ANZAHL_WAFFEN / 10
        End If
    End Sub

    Public Sub setBild(pValue As Integer)
        bild = pValue
    End Sub

    Public Function getName(pTyp As Integer) As String
        Dim ret As String = ""
        Select Case pTyp
            Case 0
                ret = "Standart"
            Case 1
                ret = "Spezial"
            Case 2
                ret = "Krieger"
            Case Else
                ret = "Sonstige"
        End Select
        ret = ret & " (" & laenge & "er)"
        Return ret
    End Function

    Public Overrides Function serialize() As String
        Return serialize(Me)
    End Function

    Public Overrides Function serialize(pClass As MultiplayerPaket) As String
        Dim innerClass As Schiff = CType(pClass, Schiff)
        Return "{Laenge=" & innerClass.getLaenge().ToString & ";Typ=" & innerClass.getTyp().ToString & ";AnzahlWaffen=" & innerClass.getAnzahlWaffen().ToString & ";Bild=" & innerClass.getBild().ToString & "}"
    End Function

    Public Overrides Sub unserialize(pValue As String)
        unserialize(pValue, Me)
    End Sub

    Public Overrides Sub unserialize(pValue As String, pClass As MultiplayerPaket)
        Dim innerClass As Schiff = CType(pClass, Schiff)
        Dim work As List(Of String) = unserializeBlock(pValue)
        For Each obj As String In work
            Select Case obj.Substring(0, obj.IndexOf("="))
                Case "Laenge"
                    innerClass.setLaenge(CInt(obj.Substring(obj.IndexOf("=") + 1)))
                Case "Typ"
                    innerClass.setTyp(CInt(obj.Substring(obj.IndexOf("=") + 1)))
                Case "AnzahlWaffen"
                    innerClass.setAnzahlWaffen(CInt(obj.Substring(obj.IndexOf("=") + 1)))
                Case "Bild"
                    innerClass.setBild(CInt(obj.Substring(obj.IndexOf("=") + 1)))
            End Select
        Next
    End Sub
End Class
