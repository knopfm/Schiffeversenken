Imports Krypter

Public Class Form1
    Dim WithEvents NetzwerkClient As Krypter.KrypterInterface

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Hi")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NetzwerkClient = New Krypter.Krypter
        NetzwerkClient.Load()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        NetzwerkClient.Close()
    End Sub
End Class
'TODO: Schiffeversenken Programmieren
