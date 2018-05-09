Public Class FeldTeil
    Inherits PictureBox

    Private innerSchiff As Schiff
    Private innerZustand As FeldTeilState
    Public Shadows Event Klick(sender As Object, e As MouseEventArgs)

    Public Sub New()
        Me.innerZustand = FeldTeilState.Wasser
        Bild(My.Resources.Wasser, SchiffRichtung.None)
        Me.SizeMode = PictureBoxSizeMode.StretchImage
        Me.Size = New Point(40)
        AddHandler Me.MouseClick, AddressOf _Click
    End Sub

    Private Sub _Click(sender As Object, e As MouseEventArgs)
        RaiseEvent Klick(sender, e)
    End Sub

    Public Property Zustand As FeldTeilState
        Get
            Return innerZustand
        End Get
        Set(value As FeldTeilState)
            innerZustand = value
            Select Case innerZustand
                Case FeldTeilState.Daneben
                    Bild(My.Resources.Kreuz, SchiffRichtung.None)
                Case FeldTeilState.Wasser
                    Bild(My.Resources.Wasser, SchiffRichtung.None)
                Case FeldTeilState.Schiff
                    Try
                        Dim x As Integer = CInt(Me.Name.Substring(1, Me.Name.IndexOf("v") - 1))
                        Dim y As Integer = CInt(Me.Name.Substring(Me.Name.IndexOf("v") + 1))
                        Bild(innerSchiff.getImage(getSchiffInnerPos(Me.innerSchiff, x, y)), Me.innerSchiff.direction)
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                Case FeldTeilState.Getroffen
                    Try
                        Dim x As Integer = CInt(Me.Name.Substring(1, Me.Name.IndexOf("v") - 1))
                        Dim y As Integer = CInt(Me.Name.Substring(Me.Name.IndexOf("v") + 1))
                        Bild(innerSchiff.getImage_g(getSchiffInnerPos(Me.innerSchiff, x, y)), Me.innerSchiff.direction)
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                Case Else
                    Bild(My.Resources.Wasser, SchiffRichtung.None)
            End Select
        End Set
    End Property

    Private Function getSchiffInnerPos(schiff As Schiff, x As Integer, y As Integer) As Integer
        Dim pos As Integer = -1
        If (schiff.direction = SchiffRichtung.LR Or schiff.direction = SchiffRichtung.RL) And schiff.startPoint.Y = y Then
            If x = schiff.startPoint.X Then
                pos = schiff.getLaenge() - 1
            ElseIf x = schiff.endPoint.X Then
                pos = 0
            Else
                pos = 1
            End If
        End If
        If (schiff.direction = SchiffRichtung.OU Or schiff.direction = SchiffRichtung.UO) And schiff.startPoint.X = x Then
            If y = schiff.startPoint.Y Then
                pos = schiff.getLaenge() - 1
            ElseIf y = schiff.endPoint.Y Then
                pos = 0
            Else
                pos = 1
            End If
        End If
        Return pos
    End Function

    Public Property Schiff As Schiff
        Get
            Return innerSchiff
        End Get
        Set(value As Schiff)
            innerSchiff = value
            Zustand = FeldTeilState.Schiff
        End Set
    End Property

    Public Sub Bild(im As Image, dr As SchiffRichtung)
        Me.Image = im
        Select Case dr
            Case SchiffRichtung.None
                Me.Image.RotateFlip(RotateFlipType.RotateNoneFlipNone)
            Case SchiffRichtung.LR
                Me.Image.RotateFlip(RotateFlipType.RotateNoneFlipNone)
            Case SchiffRichtung.RL
                Me.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
            Case SchiffRichtung.OU
                Me.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
            Case SchiffRichtung.UO
                Me.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
            Case Else
        End Select
    End Sub
End Class

Public Enum FeldTeilState
    Wasser
    Daneben
    Schiff
    Getroffen
    'Versenkt
    'Sonstiges 'zb Insel ?
End Enum

