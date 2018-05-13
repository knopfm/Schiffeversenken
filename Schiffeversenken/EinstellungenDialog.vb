Public Class EinstellungenDialog
    Private Sub CloseBT_Click(sender As Object, e As EventArgs) Handles CloseBT.Click
        HauptmenüDialog.GrafikIndex = GrafikTB.Value
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub OtherBT_Click(sender As Object, e As EventArgs) Handles OtherBT.Click
        OtherRB.Checked = True
        FarbenDialog.Color = HauptmenüDialog.Color
        If FarbenDialog.ShowDialog() = DialogResult.OK Then
            HauptmenüDialog.Color = FarbenDialog.Color
        End If
        OtherRB.BackColor = HauptmenüDialog.Color
    End Sub

    Private Sub EinstellungenDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Sprachpackete.GetUbersetzung("configBT")
        FarbenGB.Text = Sprachpackete.GetUbersetzung("colorGB")
        OtherBT.Text = Sprachpackete.GetUbersetzung("otherBT")
        CloseBT.Text = Sprachpackete.GetUbersetzung("useBT")
        Select Case HauptmenüDialog.Color
            Case LightSeaGreenRB.BackColor
                LightSeaGreenRB.Checked = True
            Case LightGreenRB.BackColor
                LightGreenRB.Checked = True
            Case DeepSkyBlueRB.BackColor
                DeepSkyBlueRB.Checked = True
            Case CornflowerBlueRB.BackColor
                CornflowerBlueRB.Checked = True
            Case Else
                OtherRB.Checked = True
                OtherRB.BackColor = HauptmenüDialog.Color
        End Select
        GrafikL.Text = Sprachpackete.GetUbersetzung("graphicL") & ":"
        GrafikTB.Value = HauptmenüDialog.GrafikIndex
    End Sub

    Private Sub RB_CheckedChanged(sender As Object, e As EventArgs) Handles LightSeaGreenRB.CheckedChanged, LightGreenRB.CheckedChanged, DeepSkyBlueRB.CheckedChanged, CornflowerBlueRB.CheckedChanged
        sender = CType(sender, RadioButton)
        HauptmenüDialog.Color = sender.BackColor
    End Sub
End Class