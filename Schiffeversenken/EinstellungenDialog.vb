Public Class EinstellungenDialog
    Private HauptmenüForm As HauptmenüDialog
    Private ProfilForm As ProfilDialog
    Private player As Profil

    Public Sub New(pHauptmenüForm As HauptmenüDialog)
        HauptmenüForm = pHauptmenüForm
        InitializeComponent()
    End Sub
    Private Sub EinstellungenDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SpielerCB.Items.Clear()
        SpielerCB.Items.Add(HauptmenüForm.getPlayer.getName())
        SpielerCB.SelectedIndex = 0
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Me.Close()
    End Sub

    Private Sub EditBT_Click(sender As Object, e As EventArgs) Handles EditBT.Click
        Dim locSI = SpielerCB.SelectedIndex
        player = HauptmenüForm.getPlayer
        ProfilForm = New ProfilDialog(HauptmenüForm, player)
        ProfilForm.ShowDialog()
        EinstellungenDialog_Load(Me, Nothing)
        SpielerCB.SelectedIndex = locSI
    End Sub
End Class