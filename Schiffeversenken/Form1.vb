Public Class Hauptmenü
    Dim WithEvents NetzwerkClient As Krypter.KrypterInterface

    Private Sub Hauptmenü_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NetzwerkClient = New Krypter.Krypter
        NetzwerkClient.Load()
    End Sub

    Private Sub Hauptmenü_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        NetzwerkClient.Close()
    End Sub
End Class
'TODO: Schiffeversenken Programmieren
'hallo