﻿Public Class GameChoose
    Dim FL As New List(Of FeldDialog)

    Public Property x As FeldDialog
        Get
            Return Nothing
        End Get
        Set(value As FeldDialog)
        End Set
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As New FeldDialog
        x.Show()
        FL.Add(x)
    End Sub

    Private Sub GameChoose_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        For Each x As FeldDialog In FL
            x.Close()
        Next
    End Sub
End Class