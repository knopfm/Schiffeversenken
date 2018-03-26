Public Class Schiff
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

    Public Function getAnzahlWaffe() As Integer
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
End Class
