Public Class HauptmenüDialog
    Private ShopForm As New EinstellungenDialog
    Private StatistikForm As New StatistikDialog
    Private WithEvents SpielerSucheForm As SpielerSucheDialog
    Public Shared Color As Color = Color.LightSeaGreen
    Public Shared GrafikIndex As Integer = 5
    Private t As New Threading.Thread(AddressOf bilder)
    Private innerBilderIndex As Integer = 0

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

    Private Sub ConfigBT_Click(sender As Object, e As EventArgs) Handles ConfigBT.Click
        ShopForm.ShowDialog()
    End Sub

    Private Sub CloseBT_Click(sender As Object, e As EventArgs) Handles CloseBT.Click
        Me.Close()
    End Sub

    Private Sub HauptmenüDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sprachpackete.Datei = "../../DE.lang"
        PlayBT.Text = Sprachpackete.GetUbersetzung("playBT")
        StatistikBT.Text = Sprachpackete.GetUbersetzung("statisticsBT")
        ConfigBT.Text = Sprachpackete.GetUbersetzung("configBT")
        CloseBT.Text = Sprachpackete.GetUbersetzung("endBT")
        Me.Text = Sprachpackete.GetUbersetzung("mainmenu")
        t.Start()
    End Sub

    Private Sub bilder()
        Do
            Try
                Select Case innerBilderIndex
                    Case 0
                        'LogoPB.Image = 
                End Select

                innerBilderIndex += 1
                If innerBilderIndex = 1 Then
                    innerBilderIndex = 0
                End If
            Catch ex As Threading.ThreadAbortException
                Exit Do
            Catch ex As Exception
                Throw ex
            End Try
        Loop
    End Sub

    Private Sub HauptmenüDialog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        t.Abort()
    End Sub
End Class

'TODO: Bilder für LogoPB -> mit Timer mehrere?
