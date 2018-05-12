Public Class FeldTeil
    Inherits PictureBox

    Private innerSchiff As Schiff
    Private innerZustand As FeldTeilStatus
    Public Shadows Event Klick(sender As Object, e As MouseEventArgs)
    Public getroffenAktiv As Boolean = True

    Public Sub New()
        Me.innerZustand = FeldTeilStatus.Wasser
        Bild(My.Resources.Wasser, SchiffRichtung.None)
        Me.SizeMode = PictureBoxSizeMode.StretchImage
        Me.Size = New Point(40)
        AddHandler Me.MouseClick, AddressOf _Click
    End Sub

    Private Sub _Click(sender As Object, e As MouseEventArgs)
        RaiseEvent Klick(sender, e)
    End Sub

    Public Property Zustand As FeldTeilStatus
        Get
            Return innerZustand
        End Get
        Set(value As FeldTeilStatus)
            innerZustand = value
            Select Case innerZustand
                Case FeldTeilStatus.Daneben
                    Bild(My.Resources.Kreuz, SchiffRichtung.None)

                Case FeldTeilStatus.Wasser
                    Bild(My.Resources.Wasser, SchiffRichtung.None)

                Case FeldTeilStatus.Getroffen
                    If getroffenAktiv Then
                        Bild(My.Resources.Kreis, SchiffRichtung.None)
                    Else
                        Try
                            Dim x As Integer = getX()
                            Dim y As Integer = getY()
                            Bild(innerSchiff.getImage_g(getSchiffInnerPos(Me.innerSchiff, x, y)), Me.innerSchiff.direction)
                        Catch ex As Exception
                            Throw ex
                        End Try
                    End If

                Case FeldTeilStatus.Schiff
                    Try
                        Dim x As Integer = getX()
                        Dim y As Integer = getY()
                        Bild(innerSchiff.getImage(getSchiffInnerPos(Me.innerSchiff, x, y)), Me.innerSchiff.direction)
                    Catch ex As Exception
                        Throw ex
                    End Try

                Case FeldTeilStatus.Versenkt
                    Try
                        Dim x As Integer = getX()
                        Dim y As Integer = getY()
                        Bild(innerSchiff.getImage_g(getSchiffInnerPos(Me.innerSchiff, x, y)), Me.innerSchiff.direction)
                    Catch ex As Exception
                        Throw ex
                    End Try

                Case Else
                    Bild(My.Resources.Wasser, SchiffRichtung.None)
                    Throw New Exception("Fehler bei FeldTeil.Zustand")
            End Select
        End Set
    End Property

    Private Function getSchiffInnerPos(schiff As Schiff, x As Integer, y As Integer) As Integer
        Dim pos As Integer = -1
        If (schiff.direction = SchiffRichtung.LR Or schiff.direction = SchiffRichtung.RL) And schiff.startPoint.Y = y Then
            pos = Math.Abs(schiff.endPoint.X - x)
        End If
        If (schiff.direction = SchiffRichtung.OU Or schiff.direction = SchiffRichtung.UO) And schiff.startPoint.X = x Then
            pos = Math.Abs(schiff.endPoint.Y - y)
        End If
        Return pos
    End Function

    Public Property Schiff As Schiff
        Get
            Return innerSchiff
        End Get
        Set(value As Schiff)
            innerSchiff = value
        End Set
    End Property

    Private Sub Bild(im As Image, dr As SchiffRichtung)
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

    Public Function getX() As Integer
        Return CInt(Me.Name.Substring(1, Me.Name.IndexOf("v") - 1))
    End Function

    Public Function getY() As Integer
        Return CInt(Me.Name.Substring(Me.Name.IndexOf("v") + 1))
    End Function
End Class

Public Enum FeldTeilStatus
    Wasser
    Daneben
    Schiff
    Getroffen
    Versenkt
    'Sonstiges 'zb Insel ?
End Enum

