Public Class ProfilDialog
    Private HauptmenüForm As HauptmenüDialog
    Private player As Profil

    Public Sub New(pHauptmenüForm As HauptmenüDialog, pPlayer As Profil)
        HauptmenüForm = pHauptmenüForm
        Me.player = pPlayer
        InitializeComponent()
    End Sub
    Private Sub ProfilDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setText(NameTB, player.getName)
        setText(NicknameTB, player.getNickname)
        setText(GlobaleIDTB, player.getGlobaleID)
        If player.getFeld.getHoehe() = 10 Then
            Feld10RB.Checked = True
            Feld20RB.Checked = False
        Else
            Feld10RB.Checked = False
        End If
        If player.getFeld.getHoehe() = 20 Then
            Feld20RB.Checked = True
            Feld10RB.Checked = False
        Else
            Feld20RB.Checked = False
        End If
    End Sub

    Private Sub setText(pTB As TextBox, pText As String)
        pTB.Text = pText
    End Sub

    Private Function getText(pTB As TextBox) As String
        Return pTB.Text
    End Function

    Private Function getFeld() As FeldSetting
        Dim hoehe As Integer
        Dim breite As Integer
        If Feld10RB.Checked Then
            hoehe = 10
            breite = 10
        ElseIf Feld20RB.Checked Then
            hoehe = 20
            breite = 20
        End If

        Return New FeldSetting(breite, hoehe)
    End Function

    Private Sub SchiffeBT_Click(sender As Object, e As EventArgs) Handles SchiffeBT.Click
        Dim ret As String = ""
        MsgBox(ret)
    End Sub

    Private Sub SaveBT_Click(sender As Object, e As EventArgs) Handles SaveBT.Click
        If Feld20RB.Checked Or Feld10RB.Checked Then
            player.setFeld(getFeld())
            player.setName(getText(NameTB))
            player.setNickname(getText(NicknameTB))
            HauptmenüForm.setPlayer(player)
            Me.Close()
        Else
            MessageBox.Show("Es muss eine Feldgröße ausgewählt werden!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub CancelBT_Click(sender As Object, e As EventArgs) Handles CancelBT.Click
        Me.Close()
    End Sub
End Class