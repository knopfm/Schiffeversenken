Public Class HauptmenüDialog
    Private EinstellungForm As EinstellungenDialog
    Private ShopForm As ShopDialog
    Private ProfilForm As ProfilDialog
    Private player As Profil
    Private MPClient As New MultiplayerClient(New Net.IPEndPoint(New Net.IPAddress({127, 0, 0, 1}), 8130))

    Private Sub Hauptmenü_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Anmeldung As New Login_Dialog(MPClient)
        If Anmeldung.ShowDialog() <> DialogResult.OK Then
            Me.Close()
        End If
        player = New Profil(10, "Spieler", "Nickname", New FeldSetting(5, 5))
    End Sub

    Private Sub Hauptmenü_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MPClient.disconnect()
    End Sub

    Private Sub PlayBT_Click(sender As Object, e As EventArgs) Handles PlayBT.Click
        Dim x As New GameChoose(Me, player)
        Me.Hide()
        x.ShowDialog()
        Me.Show()
    End Sub

    Private Sub ProfileBT_Click(sender As Object, e As EventArgs) Handles ProfileBT.Click
        ProfilForm = New ProfilDialog(Me, player)
        ProfilForm.ShowDialog()
    End Sub

    Private Sub ShopBT_Click(sender As Object, e As EventArgs) Handles ShopBT.Click
        ShopForm = New ShopDialog
        ShopForm.ShowDialog()
    End Sub

    Private Sub SettingsBT_Click(sender As Object, e As EventArgs) Handles SettingsBT.Click
        ' EinstellungForm = New EinstellungenDialog(Me)
        ' EinstellungForm.ShowDialog()
        Me.Close()
    End Sub

    Public Function getPlayer() As Profil
        Return player
    End Function

    Public Sub setPlayer(pPlayer As Profil)
        player = pPlayer
    End Sub
End Class
