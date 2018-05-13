Public Class FeldPlatzierenDialog
    Public Richtung As SchiffRichtung
    Public Type As SchiffType
    Private norden, osten, suden, westen As Integer
    Private base As FeldDialog10

    Public Sub New(pSC As FeldDialog10)
        InitializeComponent()
        base = pSC
    End Sub

    Private Sub Schiff3RB_CheckedChanged(sender As Object, e As EventArgs) Handles Schiff3RB.CheckedChanged, Schiff4RB.CheckedChanged, Schiff5RB.CheckedChanged, Schiff2RB.CheckedChanged
        RichtungGB.Enabled = True
        NordenRB.Enabled = False
        OstenRB.Enabled = False
        SudenRB.Enabled = False
        WestenRB.Enabled = False

        If Schiff2RB.Checked Then
            If norden >= 1 Then
                NordenRB.Enabled = True
            End If
            If westen >= 1 Then
                WestenRB.Enabled = True
            End If
            If suden >= 1 Then
                SudenRB.Enabled = True
            End If
            If osten >= 1 Then
                OstenRB.Enabled = True
            End If
        ElseIf Schiff3RB.Checked Then
            If norden >= 2 Then
                NordenRB.Enabled = True
            End If
            If westen >= 2 Then
                WestenRB.Enabled = True
            End If
            If suden >= 2 Then
                SudenRB.Enabled = True
            End If
            If osten >= 2 Then
                OstenRB.Enabled = True
            End If
        ElseIf Schiff4RB.Checked Then
            If norden >= 3 Then
                NordenRB.Enabled = True
            End If
            If westen >= 3 Then
                WestenRB.Enabled = True
            End If
            If suden >= 3 Then
                SudenRB.Enabled = True
            End If
            If osten >= 3 Then
                OstenRB.Enabled = True
            End If
        ElseIf Schiff5RB.Checked Then
            If norden >= 4 Then
                NordenRB.Enabled = True
            End If
            If westen >= 4 Then
                WestenRB.Enabled = True
            End If
            If suden >= 4 Then
                SudenRB.Enabled = True
            End If
            If osten >= 4 Then
                OstenRB.Enabled = True
            End If
        End If
    End Sub

    Private Sub NordenRB_CheckedChanged(sender As Object, e As EventArgs) Handles NordenRB.CheckedChanged, OstenRB.CheckedChanged, SudenRB.CheckedChanged, WestenRB.CheckedChanged
        OkBT.Enabled = True
    End Sub

    Private Sub FeldPlatzierenDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Sprachpakete.GetUbersetzung("placeship")
        SchiffTypeGB.Text = Sprachpakete.GetUbersetzung("shiptypeGB")
        Schiff2RB.Text = Sprachpakete.GetUbersetzung("_2erShipRB")
        Schiff3RB.Text = Sprachpakete.GetUbersetzung("_3erShipRB")
        Schiff4RB.Text = Sprachpakete.GetUbersetzung("_4erShipRB")
        Schiff5RB.Text = Sprachpakete.GetUbersetzung("_5erShipRB")
        RichtungGB.Text = Sprachpakete.GetUbersetzung("directionGB")
        NordenRB.Text = Sprachpakete.GetUbersetzung("northRB")
        OstenRB.Text = Sprachpakete.GetUbersetzung("eastRB")
        SudenRB.Text = Sprachpakete.GetUbersetzung("sudenRB")
        WestenRB.Text = Sprachpakete.GetUbersetzung("westRB")
        OkBT.Text = Sprachpakete.GetUbersetzung("okBT")
        AbortBT.Text = Sprachpakete.GetUbersetzung("abortBT")
        Me.Location = New Point(base.Location.X + (base.Width / 2 - Width / 2), base.Location.Y + (base.Height / 2 - Height / 2))
    End Sub

    Private Sub OkBT_Click(sender As Object, e As EventArgs) Handles OkBT.Click
        If Schiff2RB.Checked Then
            Type = SchiffType._2er
        End If
        If Schiff3RB.Checked Then
            Type = SchiffType._3er
        End If
        If Schiff4RB.Checked Then
            Type = SchiffType._4er
        End If
        If Schiff5RB.Checked Then
            Type = SchiffType._5er
        End If
        If NordenRB.Checked Then
            Richtung = SchiffRichtung.UO
        End If
        If OstenRB.Checked Then
            Richtung = SchiffRichtung.LR
        End If
        If SudenRB.Checked Then
            Richtung = SchiffRichtung.OU
        End If
        If WestenRB.Checked Then
            Richtung = SchiffRichtung.RL
        End If
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub AbortBT_Click(sender As Object, e As EventArgs) Handles AbortBT.Click
        Me.DialogResult = DialogResult.Abort
        Me.Close()
    End Sub

    Public Sub setMoeglichkeiten(S2 As Integer, S3 As Integer, S4 As Integer, S5 As Integer, norden As Integer, osten As Integer, suden As Integer, westen As Integer)
        If S2 = 0 Then
            Schiff2RB.Enabled = False
        End If
        If S3 = 0 Then
            Schiff3RB.Enabled = False
        End If
        If S4 = 0 Then
            Schiff4RB.Enabled = False
        End If
        If S5 = 0 Then
            Schiff5RB.Enabled = False
        End If
        Me.norden = norden
        Me.osten = osten
        Me.westen = westen
        Me.suden = suden
    End Sub
End Class