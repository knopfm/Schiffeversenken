Public Class StatistikDialog

    Private Sub CloseBT_Click(sender As Object, e As EventArgs) Handles CloseBT.Click
        Me.Close()
    End Sub

    Private Sub StatistikDialog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub StatistikDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        CloseBT.Text = Sprachpakete.GetUbersetzung("closeBT")
        ResetBT.Text = Sprachpakete.GetUbersetzung("stat_resetBT")
        StatistikL.Text = berechneInfoBox()
    End Sub

    Private Function berechneInfoBox() As String
        Dim ret As String = ""

        ret &= Sprachpakete.GetUbersetzung("stat_Head") & vbCrLf
        ret &= vbCrLf
        ret &= vbCrLf
        ret &= Sprachpakete.GetUbersetzung("stat_GameWin") & ": " & HauptmenüDialog.config.Stats.gewonnen & vbCrLf
        ret &= Sprachpakete.GetUbersetzung("stat_GameLoose") & ": " & HauptmenüDialog.config.Stats.verloren & vbCrLf
        ret &= Sprachpakete.GetUbersetzung("stat_GamePlayed") & ": " & HauptmenüDialog.config.Stats.verloren + HauptmenüDialog.config.Stats.gewonnen & vbCrLf
        Dim x As Double = HauptmenüDialog.config.Stats.gewonnen / (HauptmenüDialog.config.Stats.verloren + HauptmenüDialog.config.Stats.gewonnen)
        If Not Double.NaN.Equals(x) Then
            ret &= Sprachpakete.GetUbersetzung("stat_GamePercent") & ": " & Format(x, "0.00%") & vbCrLf
        Else
            ret &= Sprachpakete.GetUbersetzung("stat_GamePercent") & ": 0%" & vbCrLf
        End If
        ret &= vbCrLf
        ret &= vbCrLf
        ret &= Sprachpakete.GetUbersetzung("stat_ShotLoose") & ": " & HauptmenüDialog.config.Stats.daneben & vbCrLf
        ret &= Sprachpakete.GetUbersetzung("stat_ShotPoint") & ": " & HauptmenüDialog.config.Stats.getroffen & vbCrLf
        ret &= Sprachpakete.GetUbersetzung("stat_ShipDown") & ": " & HauptmenüDialog.config.Stats.versenkt & vbCrLf
        x = HauptmenüDialog.config.Stats.getroffen / (HauptmenüDialog.config.Stats.daneben + HauptmenüDialog.config.Stats.getroffen)
        If Not Double.NaN.Equals(x) Then
            ret &= Sprachpakete.GetUbersetzung("stat_Points") & ": " & Format(x, "0.00%") & vbCrLf
        Else
            ret &= Sprachpakete.GetUbersetzung("stat_Points") & ": 0%" & vbCrLf
        End If
        ret &= vbCrLf
        ret &= vbCrLf
        Try
            ret &= Sprachpakete.GetUbersetzung("stat_TimePlay") & ": " & TimeSpan.FromTicks(HauptmenüDialog.config.Stats.ticks / (HauptmenüDialog.config.Stats.verloren + HauptmenüDialog.config.Stats.gewonnen)).ToString("mm\:ss") & " min" & vbCrLf
        Catch ex As Exception
            ret &= Sprachpakete.GetUbersetzung("stat_TimePlay") & ": 00:00 min" & vbCrLf
        End Try
        ret &= Sprachpakete.GetUbersetzung("stat_TimeGame") & ": " & HauptmenüDialog.config.Stats.spielzeit.ToString("hh\:mm\:ss") & " h" & vbCrLf
        Return ret
    End Function

    Private Sub ResetBT_Click(sender As Object, e As EventArgs) Handles ResetBT.Click
        If MessageBox.Show(Sprachpakete.GetUbersetzung("stat_reset"), Sprachpakete.GetUbersetzung("stat_resetBT"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            HauptmenüDialog.config.Stats = New StatistikObject
            StatistikL.Text = berechneInfoBox()
        End If
    End Sub
End Class

'TODO: Statistik 