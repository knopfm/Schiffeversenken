Public Class HauptmenüDialog
    Dim EinstellungForm As EinstellungenDialog
    Dim ShopForm As ShopDialog
    Dim ProfilForm As ProfilDialog

    Private Sub Hauptmenü_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Hauptmenü_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub PlayBT_Click(sender As Object, e As EventArgs) Handles PlayBT.Click
        Dim x As New GameChoose
        Me.Hide()
        x.ShowDialog()
        Me.Show()
    End Sub

    Private Sub ProfileBT_Click(sender As Object, e As EventArgs) Handles ProfileBT.Click
        ProfilForm = New ProfilDialog
        ProfilForm.ShowDialog()
    End Sub

    Private Sub ShopBT_Click(sender As Object, e As EventArgs) Handles ShopBT.Click
        ShopForm = New ShopDialog
        ShopForm.ShowDialog()
    End Sub

    Private Sub SettingsBT_Click(sender As Object, e As EventArgs) Handles SettingsBT.Click
        EinstellungForm = New EinstellungenDialog
        EinstellungForm.ShowDialog()
    End Sub

    Private Sub LogoPB_Click(sender As Object, e As EventArgs) Handles LogoPB.Click

    End Sub
End Class

'TODO: Schiffeversenken Programmieren