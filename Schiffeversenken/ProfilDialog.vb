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
        setText(FeldWTB, player.getFeld.getBreite.ToString)
        setText(FeldHTB, player.getFeld.getHoehe.ToString)
    End Sub

    Private Sub setText(pTB As TextBox, pText As String)
        pTB.Text = pText
    End Sub

    Private Function getText(pTB As TextBox) As String
        Return pTB.Text
    End Function

    Private Function getFeld() As FeldSetting
        Dim hoehe As Integer
        Try
            hoehe = CInt(getText(FeldHTB))
            If hoehe > FeldSetting.MAX_HOEHE Then
                hoehe = FeldSetting.MAX_HOEHE
            End If
            If hoehe <= 0 Then
                hoehe = FeldSetting.MAX_HOEHE
            End If
        Catch ex As Exception
            hoehe = FeldSetting.MAX_HOEHE
        End Try
        Dim breite As Integer
        Try
            breite = CInt(getText(FeldWTB))
            If breite > FeldSetting.MAX_BREITE Then
                breite = FeldSetting.MAX_BREITE
            End If
            If breite <= 0 Then
                breite = FeldSetting.MAX_BREITE
            End If
        Catch ex As Exception
            breite = FeldSetting.MAX_BREITE
        End Try
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
        player.setFeld(getFeld())
        player.setName(getText(NameTB))
        player.setNickname(getText(NicknameTB))
        HauptmenüForm.setPlayer(HauptmenüForm.getAktullerPlayer, player)
        Me.Close()
    End Sub

    Private Sub CancelBT_Click(sender As Object, e As EventArgs) Handles CancelBT.Click
        Me.Close()
    End Sub
End Class