﻿Public Class HauptmenüDialog
    Private ShopForm As New ShopDialog
    Private StatistikForm As New StatistikDialog
    Private WithEvents SpielerSucheForm As SpielerSucheDialog

    Private Sub PlayBT_Click(sender As Object, e As EventArgs) Handles PlayBT.Click
        Me.Hide()
        SpielerSucheForm = New SpielerSucheDialog
        SpielerSucheForm.Show()
    End Sub

    Private Sub SpilerSuchenForm_Schließen() Handles SpielerSucheForm.Schließen
        Me.Show()
    End Sub

    Private Sub StatistikBT_Click(sender As Object, e As EventArgs) Handles StatistikBT.Click
        StatistikForm.ShowDialog()
    End Sub

    Private Sub ShopBT_Click(sender As Object, e As EventArgs) Handles ShopBT.Click
        ShopForm.ShowDialog()
    End Sub

    Private Sub CloseBT_Click(sender As Object, e As EventArgs) Handles CloseBT.Click
        Me.Close()
    End Sub

    Private Sub HauptmenüDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sprachpackete.Datei = "../../DE.lang"
        PlayBT.Text = Sprachpackete.GetUbersetzung("playBT")
        StatistikBT.Text = Sprachpackete.GetUbersetzung("statisticsBT")
        ShopBT.Text = Sprachpackete.GetUbersetzung("shopBT")
        CloseBT.Text = Sprachpackete.GetUbersetzung("endBT")
        Me.Text = Sprachpackete.GetUbersetzung("mainmenu")
    End Sub
End Class
