Public Class Hauptmenü
    Dim WithEvents NetzwerkClient As Krypter.KrypterInterface
    Dim EinstellungForm As Einstellungen
    Dim ShopForm As Shop
    Dim ProfilForm As Profil

    Private Sub Hauptmenü_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NetzwerkClient = New Krypter.Krypter
        NetzwerkClient.Load()
    End Sub

    Private Sub Hauptmenü_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        NetzwerkClient.Close()
    End Sub

    Private Sub PlayBT_Click(sender As Object, e As EventArgs) Handles PlayBT.Click
        Dim x As New GameChoose
        Me.Hide()
        x.ShowDialog()
        Me.Show()
    End Sub

    Private Sub ProfileBT_Click(sender As Object, e As EventArgs) Handles ProfileBT.Click
        ProfilForm = New Profil
        ProfilForm.ShowDialog()
    End Sub

    Private Sub ShopBT_Click(sender As Object, e As EventArgs) Handles ShopBT.Click
        ShopForm = New Shop
        ShopForm.ShowDialog()
    End Sub

    Private Sub SettingsBT_Click(sender As Object, e As EventArgs) Handles SettingsBT.Click
        EinstellungForm = New Einstellungen
        EinstellungForm.ShowDialog()
    End Sub

    Private Sub LogoPB_Click(sender As Object, e As EventArgs) Handles LogoPB.Click

    End Sub
End Class
'TODO: Schiffeversenken Programmieren
'hallo