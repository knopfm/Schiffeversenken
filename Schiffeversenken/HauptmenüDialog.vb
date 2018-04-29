Public Class HauptmenüDialog
    Private EinstellungForm As EinstellungenDialog
    Private ShopForm As ShopDialog
    Private ProfilForm As ProfilDialog
    Private player As Profil
    Private MPClient As New MultiplayerClient(New Net.IPEndPoint(New Net.IPAddress({127, 0, 0, 1}), 8130))

    Private Sub Hauptmenü_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fs As New IO.FileStream("config.txt", IO.FileMode.OpenOrCreate)
        Dim sr As New IO.StreamReader(fs)
        Dim players As New List(Of String)
        Do Until sr.Peek() = -1
            players.Add(sr.ReadLine())
        Loop
        sr.Close()
        players.Remove("")
        If players.Count = 0 Then
            player = New Profil(10, "Spieler", "Nickname", New FeldSetting(10, 10))
            Dim Anmeldung As New Login_Neu_Dialog(MPClient)
            If Anmeldung.ShowDialog() <> DialogResult.Yes Then
                Me.Close()
            Else
                Dim fs1 As New IO.FileStream("config.txt", IO.FileMode.Append)
                Dim sw1 As New IO.StreamWriter(fs1)
                sw1.WriteLine(player.serialize & vbCrLf)
                sw1.Flush()
                sw1.Close()
            End If
        Else
            Dim Anmeldung As New Login_Dialog(Me, MPClient, players.ToArray)
            Dim DR As DialogResult = Anmeldung.ShowDialog()
            If DR = DialogResult.Abort Then
                Me.Close()
            ElseIf DR = DialogResult.Yes Then
                Dim fs2 As New IO.FileStream("config.txt", IO.FileMode.Append)
                Dim sw2 As New IO.StreamWriter(fs2)
                sw2.WriteLine(player.serialize & vbCrLf)
                sw2.Flush()
                sw2.Close()
            End If
        End If

    End Sub

    Private Sub Hauptmenü_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MPClient.disconnect()
        Dim fs As New IO.FileStream("config.txt", IO.FileMode.Open)
        Dim sw As New IO.StreamWriter(fs)
        ' sw.WriteLine(player.serialize)
        sw.Flush()
        sw.Close()
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
