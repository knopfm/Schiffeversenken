﻿Public Class FeldPlatzierenDialog
    Public Richtung As SchiffRichtung
    Public Type As SchiffType
    Private norden, osten, suden, westen As Integer

    Private Sub Schiff3RB_CheckedChanged(sender As Object, e As EventArgs) Handles Schiff3RB.CheckedChanged, Schiff4RB.CheckedChanged, Schiff5RB.CheckedChanged
        RichtungGB.Enabled = True
        NordenRB.Enabled = False
        OstenRB.Enabled = False
        SudenRB.Enabled = False
        WestenRB.Enabled = False

        If Schiff3RB.Checked Then
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

    Private Sub OkBT_Click(sender As Object, e As EventArgs) Handles OkBT.Click
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

    Public Sub setMoeglichkeiten(S3 As Integer, S4 As Integer, S5 As Integer, norden As Integer, osten As Integer, suden As Integer, westen As Integer)
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