Public Class EinstellungenDialog
    Private HauptmenüForm As HauptmenüDialog
    Private ProfilForm As ProfilDialog

    Public Sub New(pHauptmenüForm As HauptmenüDialog)
        HauptmenüForm = pHauptmenüForm
        InitializeComponent()
    End Sub
    Private Sub EinstellungenDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SpielerCB.Items.Clear()
        For i As Integer = 0 To HauptmenüForm.getPlayerCount() - 1
            SpielerCB.Items.Add(HauptmenüForm.getPlayer(i).getName())
        Next
        SpielerCB.SelectedIndex = HauptmenüForm.getAktullerPlayer()
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        HauptmenüForm.setAktuellerPlayer(SpielerCB.SelectedIndex)
        Me.Close()
    End Sub

    Private Sub EditBT_Click(sender As Object, e As EventArgs) Handles EditBT.Click
        Dim localselectedPlayer As Integer = HauptmenüForm.getAktullerPlayer
        HauptmenüForm.setAktuellerPlayer(SpielerCB.SelectedIndex)
        ProfilForm = New ProfilDialog(HauptmenüForm)
        ProfilForm.ShowDialog()
        EinstellungenDialog_Load(Me, Nothing)
        HauptmenüForm.setAktuellerPlayer(localselectedPlayer)
    End Sub
End Class