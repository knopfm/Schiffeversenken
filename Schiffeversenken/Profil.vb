Public Class Profil
    Private Name As String
    Private Nickname As String
    Private GlobaleID As ULong

    Private Schiffe As List(Of Schiff)
    Private Feld_Config As FeldSetting

    Public Sub New()
        Me.New(0)
    End Sub

    Public Sub New(pGID As ULong)
        Me.New(pGID, "", "")
    End Sub

    Public Sub New(pGID As ULong, pName As String, pNickname As String)
        Me.New(pGID, pName, pNickname, Nothing)
    End Sub

    Public Sub New(pFeld As FeldSetting)
        Me.New(0, "", "", pFeld)
    End Sub

    Public Sub New(pGID As ULong, pName As String, pNickname As String, pFeld As FeldSetting)
        setGlobaleID(pGID)
        setName(pName)
        setNickname(pNickname)
        setFeld(pFeld)
    End Sub

    Public Function getName() As String
        Return Name
    End Function

    Public Function getNickname() As String
        Return Nickname
    End Function

    Public Function getGlobaleID() As ULong
        Return GlobaleID
    End Function
    Public Function getFeld() As FeldSetting
        Return Feld_Config
    End Function

    Public Sub setName(pValue As String)
        Name = pValue
    End Sub

    Public Sub setNickname(pValue As String)
        Nickname = pValue
    End Sub

    Private Sub setGlobaleID(pValue As ULong)
        GlobaleID = pValue
    End Sub

    Public Sub setFeld(pValue As FeldSetting)
        Feld_Config = pValue
    End Sub


    Public Function getSchiffe_maxIndex() As Integer
        Return Schiffe.Count
    End Function

    Public Function getSchiff(index As Integer) As Schiff
        If index < getSchiffe_maxIndex() And index >= 0 Then
            Return Schiffe(index)
        Else
            Return Nothing
        End If
    End Function

    Public Sub addSchiff(pValue As Schiff)
        Schiffe.Add(pValue)
    End Sub

    Public Sub delSchiff(pValue As Integer)
        Schiffe.RemoveAt(pValue)
    End Sub

    Public Sub clearSchiffe()
        Schiffe.Clear()
    End Sub
End Class
