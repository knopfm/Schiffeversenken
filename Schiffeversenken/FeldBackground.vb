Public Class FeldBackground
    Inherits Panel

    Public Sub New()
        Me.BackColor = Color.Gray
        Me.Size = New Point(422, 422)
        Me.Margin = New Padding(19)
        Me.Padding = New Padding(19)
    End Sub

    Public Sub Add(ft As FeldTeil, x As Integer, y As Integer)
        If Not exists(x, y) Then
            ft.Name = "p" & x & "v" & y
            ft.Location = New Point(2 + x * 42, 2 + y * 42)
            ft.Size = New Point(40, 40)
            Me.Controls.Add(ft)
        End If
    End Sub

    Private Function exists(x, y) As Boolean
        For Each c As Control In Me.Controls
            If c.Location = New Point(2 + x * 42, 2 + y * 42) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function getControl(x As Integer, y As Integer) As FeldTeil
        Return Me.Controls("p" & x & "v" & y)
    End Function
End Class
