Public Class Schiff
    Inherits MultiplayerPaket

    Private laenge As Integer
    Private inhaber As Integer
    Private anzahlWaffen As Integer
    Private bild As Integer
    Public Const MAX_SCHIFF_LAENGE As Integer = 5
    Public Const MAX_SCHIFF_ANZAHL_WAFFEN As Integer = 1000
    Public min_X As Integer
    Public min_Y As Integer
    Public max_X As Integer
    Public max_Y As Integer
    

    Public Sub New()
        Me.New(MAX_SCHIFF_LAENGE, 0)
    End Sub

    Public Sub New(pLaenge As Integer, pInhaber As Integer)
        Me.New(pLaenge, pInhaber, MAX_SCHIFF_ANZAHL_WAFFEN / 10)
    End Sub

    Public Sub New(pLaenge As Integer, pInhaber As Integer, pAnzahlWaffen As Integer)
        Me.New(pLaenge, pInhaber, pAnzahlWaffen, 1)
    End Sub

    Public Sub New(pLaenge As Integer, pInhaber As Integer, pAnzahlWaffen As Integer, pBild As Integer)
        setLaenge(pLaenge)
        setInhaber(pInhaber)
        setAnzahlWaffen(pAnzahlWaffen)
        setBild(pBild)
    End Sub

    Public Function getLaenge() As Integer
        Return laenge
    End Function

    Public Function getInhaber() As Integer
        Return inhaber
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

    Public Sub setInhaber(pValue As Integer)
        inhaber = pValue
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

    Public Function getroffen(pX As Integer, pY As Integer) As Boolean
        If (pX >= min_X And pX <= max_X And pY >= min_X And pY <= max_Y) Then
            Return True
        Else
            Return False
        End If
    End Function
    
    Public Overrides Function serialize() As String
        Return serialize(Me)
    End Function

    Public Overrides Function serialize(pClass As MultiplayerPaket) As String
        Dim innerClass As Schiff = CType(pClass, Schiff)
        Return "{Laenge=" & innerClass.getLaenge().ToString & ";Inhaber=" & innerClass.getInhaber().ToString & ";AnzahlWaffen=" & innerClass.getAnzahlWaffen().ToString & ";Bild=" & innerClass.getBild().ToString & ";min_X=" & innerClass.min_X.ToString() & ";min_Y=" & innerClass.min_Y.ToString() & ";max_X=" & innerClass.max_X.ToString() & ";max_Y=" & innerClass.max_Y.ToString() & "}"
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
                Case "Inhaber"
                    innerClass.setInhaber(CInt(obj.Substring(obj.IndexOf("=") + 1)))
                Case "AnzahlWaffen"
                    innerClass.setAnzahlWaffen(CInt(obj.Substring(obj.IndexOf("=") + 1)))
                Case "Bild"
                    innerClass.setBild(CInt(obj.Substring(obj.IndexOf("=") + 1)))
                Case "min_x"
                    innerClass.min_X = CInt(obj.Substring(obj.IndexOf("=") + 1))
                Case "min_Y"
                    innerClass.min_Y = CInt(obj.Substring(obj.IndexOf("=") + 1))
                Case "max_X"
                    innerClass.max_X = CInt(obj.Substring(obj.IndexOf("=") + 1))
                Case "max_Y"
                    innerClass.max_Y = CInt(obj.Substring(obj.IndexOf("=") + 1))
            End Select
        Next
    End Sub
End Class
