Public Class HauptmenüDialog
    Private EinstellungForm As EinstellungenDialog
    Private ShopForm As ShopDialog
    Private ProfilForm As ProfilDialog
    Private PlayerListe As New List(Of Profil)
    Private aktuellerPlayer As Integer

    Private Sub Hauptmenü_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As New Schiff(3, 3, 30, 3)
        PlayerListe.Add(New Profil(10, "Spieler", "Nickname", New FeldSetting(5, 5)))
        PlayerListe.Add(New Profil(11, "Julius", "juli", New FeldSetting(10, 10)))
        PlayerListe.Add(New Profil(12, "Maxmilian", "Max", New FeldSetting(8, 8)))
        getPlayer(0).addSchiff(x)
        getPlayer(1).addSchiff(x)
        getPlayer(2).addSchiff(x)
        getPlayer(0).addSchiff(x)
        getPlayer(1).addSchiff(x)
        getPlayer(2).addSchiff(x)
        aktuellerPlayer = 2
    End Sub

    Private Sub Hauptmenü_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub PlayBT_Click(sender As Object, e As EventArgs) Handles PlayBT.Click
        Dim x As New GameChoose(Me)
        Me.Hide()
        x.ShowDialog()
        Me.Show()
    End Sub

    Private Sub ProfileBT_Click(sender As Object, e As EventArgs) Handles ProfileBT.Click
        ProfilForm = New ProfilDialog(Me)
        ProfilForm.ShowDialog()
    End Sub

    Private Sub ShopBT_Click(sender As Object, e As EventArgs) Handles ShopBT.Click
        ShopForm = New ShopDialog
        ShopForm.ShowDialog()
    End Sub

    Private Sub SettingsBT_Click(sender As Object, e As EventArgs) Handles SettingsBT.Click
        EinstellungForm = New EinstellungenDialog(Me)
        EinstellungForm.ShowDialog()
    End Sub

    Public Function getPlayerCount() As Integer
        Return PlayerListe.Count
    End Function

    Public Function getPlayer(pIndex As Integer) As Profil
        If pIndex < getPlayerCount() And pIndex >= 0 Then
            Return PlayerListe(pIndex)
        Else
            Return Nothing
        End If
    End Function

    Public Sub setPlayer(pIndex As Integer, pPlayer As Profil)
        If pIndex < getPlayerCount() And pIndex >= 0 Then
            PlayerListe(pIndex) = pPlayer
        End If
    End Sub

    Public Function getAktullerPlayer() As Integer
        Return aktuellerPlayer
    End Function

    Public Sub setAktuellerPlayer(pValue As Integer)
        aktuellerPlayer = pValue
    End Sub
End Class

'TODO: Schiffeversenken Programmieren