Imports Schiffeversenken

Public Class Profil
    Inherits MultiplayerPaket

    Private Name As String
    Private Nickname As String
    Private GlobaleID As ULong

    Private Schiffe As New List(Of Schiff)
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

    Public Sub setGlobaleID(pValue As ULong)
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

    Public Overrides Function serialize() As String
        Return serialize(Me)
    End Function

    Public Overrides Function serialize(pClass As MultiplayerPaket) As String
        Dim innerClass As Profil = CType(pClass, Profil)
        Dim ret As String = "{Name=" & innerClass.getName() & ";Nickname=" & innerClass.getNickname() & ";GID=" & innerClass.getGlobaleID().ToString & ";Feld=" & Feld_Config.serialize() & ";Schiffe={Schiff="
        For Each _Schiff As Schiff In Schiffe
            ret = ret & _Schiff.serialize() & ";Schiff="
        Next
        ret = ret.Substring(0, ret.Length - 8)
        Return ret & "}}"
    End Function

    Public Overrides Sub unserialize(pValue As String)
        unserialize(pValue, Me)
    End Sub

    Public Overrides Sub unserialize(pValue As String, pClass As MultiplayerPaket)
        Dim innerClass As Profil = CType(pClass, Profil)
        Dim work As List(Of String) = unserializeBlock(pValue)
        For Each obj As String In work
            Select Case obj.Substring(0, obj.IndexOf("="))
                Case "Name"
                    innerClass.setName(obj.Substring(obj.IndexOf("=") + 1))
                Case "Nickname"
                    innerClass.setNickname(obj.Substring(obj.IndexOf("=") + 1))
                Case "GID"
                    innerClass.setGlobaleID(CULng(obj.Substring(obj.IndexOf("=") + 1)))
                Case "Feld"
                    Dim Feld As New FeldSetting
                    Feld.unserialize(obj.Substring(obj.IndexOf("=") + 1))
                    innerClass.setFeld(Feld)
                Case "Schiffe"
                    Dim sf As New Schiff
                    innerClass.clearSchiffe()
                    Dim arbeit As List(Of String) = unserializeBlock(obj.Substring(obj.IndexOf("=") + 1))
                    For Each schf As String In arbeit
                        sf.unserialize(schf.Substring(schf.IndexOf("=") + 1))
                        innerClass.addSchiff(sf)
                        sf = New Schiff
                    Next
            End Select
        Next
    End Sub
End Class
