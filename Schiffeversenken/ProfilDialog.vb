Public Class ProfilDialog
    Private HauptmenüForm As HauptmenüDialog
    Private player As Profil

    Public Sub New(pHauptmenüForm As HauptmenüDialog)
        HauptmenüForm = pHauptmenüForm
        InitializeComponent()
    End Sub
    Private Sub ProfilDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        player = HauptmenüForm.getPlayer(HauptmenüForm.getAktullerPlayer)
        setText(NameTB, player.getName)
        setText(NicknameTB, player.getNickname)
        setText(GlobaleIDTB, player.getGlobaleID)
        If player.getFeld.getHoehe() = 8 Then
            Feld8RB.Checked = True
        End If
        If player.getFeld.getHoehe() = 10 Then
            Feld10RB.Checked = True
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
        If Feld8RB.Checked Then
            hoehe = 8
            breite = 8
        ElseIf Feld10RB.Checked Then
            hoehe = 10
            breite = 10
        End If

        Return New FeldSetting(breite, hoehe)
    End Function

    Private Sub SchiffeBT_Click(sender As Object, e As EventArgs) Handles SchiffeBT.Click
        Dim ret As String = ""
        For i As Integer = 0 To player.getSchiffe_maxIndex - 1
            ret &= player.getSchiff(i).serialize() & vbCrLf
        Next
        MsgBox(ret.Trim(vbCrLf))
    End Sub

    Private Sub SaveBT_Click(sender As Object, e As EventArgs) Handles SaveBT.Click
        If Feld10RB.Checked Or Feld8RB.Checked Then
            player.setFeld(getFeld())
            player.setName(getText(NameTB))
            player.setNickname(getText(NicknameTB))
            HauptmenüForm.setPlayer(HauptmenüForm.getAktullerPlayer, player)
            Me.Close()
        Else
            MessageBox.Show("Es muss eine Feldgröße ausgewählt werden!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub CancelBT_Click(sender As Object, e As EventArgs) Handles CancelBT.Click
        Me.Close()
    End Sub
End Class