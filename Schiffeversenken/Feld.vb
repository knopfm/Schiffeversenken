Public MustInherit Class Feld
    Private Feldgroeße As FeldSetting
    Private Feld(,) As Integer '0 = Wasser ; Nr = Spieler UID
    Private Schiffe As List(Of Schiff)


    Public Sub setFeld(pFeld As FeldSetting)
        Feldgroeße = pFeld
    End Sub

    Public Function getFeld() As FeldSetting
        Return Feldgroeße
    End Function

    Public Function schuss(px As Integer, py As Integer, pSchißer As Integer) As Integer
        For Each ship As Schiff In Schiffe
            If ship.getroffen(px, py) Then
                Return ship.getInhaber
            End If
        Next
        Return 0
    End Function

End Class
