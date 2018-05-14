Public Class EinstellungenDialog
    Public Event TransUpdate()

    Private Sub CloseBT_Click(sender As Object, e As EventArgs) Handles CloseBT.Click
        Me.Close()
    End Sub

    Private Sub OtherBT_Click(sender As Object, e As EventArgs) Handles OtherBT.Click
        OtherRB.Checked = True
        FarbenDialog.Color = HauptmenüDialog.config.Color
        If FarbenDialog.ShowDialog() = DialogResult.OK Then
            HauptmenüDialog.config.Color = FarbenDialog.Color
        End If
        OtherRB.BackColor = HauptmenüDialog.config.Color
    End Sub

    Private Sub EinstellungenDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InnerTranslation()
    End Sub

    Private Sub EinstellungenDialog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If LightSeaGreenRB.Checked Then
            HauptmenüDialog.config.Color = LightSeaGreenRB.BackColor
        End If
        If LightGreenRB.Checked Then
            HauptmenüDialog.config.Color = LightGreenRB.BackColor
        End If
        If DeepSkyBlueRB.Checked Then
            HauptmenüDialog.config.Color = DeepSkyBlueRB.BackColor
        End If
        If CornflowerBlueRB.Checked Then
            HauptmenüDialog.config.Color = CornflowerBlueRB.BackColor
        End If
        If OtherRB.Checked Then
            HauptmenüDialog.config.Color = OtherRB.BackColor
        End If
        HauptmenüDialog.config.GrafikIndex = GrafikTB.Value
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub SpracheBT_Click(sender As Object, e As EventArgs) Handles SpracheBT.Click
        LanguageOFD.InitialDirectory = HauptmenüDialog.config.Lang
        LanguageOFD.Filter = Sprachpakete.GetUbersetzung("fileLang") & "|*lang|" & Sprachpakete.GetUbersetzung("fileAll") & "|*.*"
        If LanguageOFD.ShowDialog() = DialogResult.OK Then
            HauptmenüDialog.config.Lang = LanguageOFD.FileName
            Sprachpakete.Datei = HauptmenüDialog.config.Lang
            InnerTranslation()
        End If
    End Sub

    Private Sub InnerTranslation()
        Me.Text = Sprachpakete.GetUbersetzung("configBT")
        FarbenGB.Text = Sprachpakete.GetUbersetzung("colorGB")
        OtherBT.Text = Sprachpakete.GetUbersetzung("otherBT")
        CloseBT.Text = Sprachpakete.GetUbersetzung("useBT")
        OtherRB.BackColor = HauptmenüDialog.config.Color
        Select Case HauptmenüDialog.config.Color.ToArgb
            Case LightSeaGreenRB.BackColor.ToArgb
                LightSeaGreenRB.Checked = True
            Case LightGreenRB.BackColor.ToArgb
                LightGreenRB.Checked = True
            Case DeepSkyBlueRB.BackColor.ToArgb
                DeepSkyBlueRB.Checked = True
            Case CornflowerBlueRB.BackColor.ToArgb
                CornflowerBlueRB.Checked = True
            Case Else
                OtherRB.Checked = True
        End Select

        GrafikGB.Text = Sprachpakete.GetUbersetzung("graphicGB")
        HighL.Text = Sprachpakete.GetUbersetzung("highL")
        LowL.Text = Sprachpakete.GetUbersetzung("lowL")
        GrafikTB.Value = HauptmenüDialog.config.GrafikIndex

        SpracheGB.Text = Sprachpakete.GetUbersetzung("langGB")
        SpracheL.Text = HauptmenüDialog.config.Lang.Substring(HauptmenüDialog.config.Lang.LastIndexOf("\") + 1)
        SpracheBT.Text = Sprachpakete.GetUbersetzung("langGB")

        ServerBT.Text = Sprachpakete.GetUbersetzung("serverBT")
        ServerGB.Text = Sprachpakete.GetUbersetzung("serverBT")
        ServerL.Text = HauptmenüDialog.config.Ip
        RaiseEvent TransUpdate()
    End Sub

    Private Sub ServerBT_Click(sender As Object, e As EventArgs) Handles ServerBT.Click
        Dim input As String = InputBox(Sprachpakete.GetUbersetzung("msg_WriteIP") & vbCrLf & Sprachpakete.GetUbersetzung("msg_WriteIP2") & " 127.0.0.1", Sprachpakete.GetUbersetzung("msg_SIP"), "127.0.0.1")
        If input <> "" Then
            HauptmenüDialog.config.Ip = input
            ServerL.Text = HauptmenüDialog.config.Ip
        End If
    End Sub
End Class