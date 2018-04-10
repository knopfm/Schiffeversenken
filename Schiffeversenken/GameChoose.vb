Public Class GameChoose
    Private FL As New List(Of FeldDialog)
    Private player As Profil
    Private HauptmenüForm As HauptmenüDialog

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ConnectBT.Click
        Dim x As New FeldDialog
        x.Show()
        FL.Add(x)
    End Sub

    Private Sub GameChoose_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        For Each x As FeldDialog In FL
            x.Close()
        Next
    End Sub

    Private Sub AbortBT_Click(sender As Object, e As EventArgs) Handles AbortBT.Click
        Me.Close()
    End Sub

    Private Sub GameChoose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setText(NameTB, player.getNickname)
        If player.getFeld.getHoehe() = 10 Then
            Feld10RB.Checked = True
        Else
            Feld10RB.Checked = False
        End If
        If player.getFeld.getHoehe() = 20 Then
            Feld20RB.Checked = True
        Else
            Feld20RB.Checked = False
        End If
    End Sub

    Public Sub New(HauptmenüForm As HauptmenüDialog, pPlayer As Profil)
        Me.player = pPlayer
        Me.HauptmenüForm = HauptmenüForm
        InitializeComponent()
    End Sub

    Private Sub setText(pTB As TextBox, pText As String)
        pTB.Text = pText
    End Sub
End Class