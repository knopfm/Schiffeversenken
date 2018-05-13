Public Class SiegerDialog
    Private innerState As SpielControllerStatus
    Private innerStatistik As String
    Private t As New Threading.Thread(AddressOf blink)
    Private innerBreak As Integer = 11
    Private base As FeldDialog10

    Public Sub New(pSC As FeldDialog10)
        InitializeComponent()
        base = pSC
    End Sub

    Private Sub SiegerDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CloseBT.Text = Sprachpakete.GetUbersetzung("closeBT")
        NeuesSpielBT.Text = Sprachpakete.GetUbersetzung("newGameBT")
        SpielStatistikL.Text = innerStatistik
        GewonnenL.Text = SpielController.translateState(innerState)
        Me.BackColor = HauptmenüDialog.config.Color
        t.Start()
        Me.Location = New Point(base.Location.X + (base.Width / 2 - Width / 2), base.Location.Y + (base.Height / 2 - Height / 2))
    End Sub

    Public Sub setState(s As SpielControllerStatus)
        innerState = s
    End Sub

    Public Sub setStatistik(s As String)
        innerStatistik = s
    End Sub

    Private Sub blink()
        Do
            Try
                Threading.Thread.Sleep(500)
                If Me.BackColor = HauptmenüDialog.config.Color Then
                    If Me.innerState = SpielControllerStatus.Gewonnen Then
                        Me.BackColor = Color.GreenYellow
                    ElseIf Me.innerState = SpielControllerStatus.Verloren Then
                        Me.BackColor = Color.Red
                    End If
                Else
                    Me.BackColor = HauptmenüDialog.config.Color
                End If
                innerBreak -= 1
            Catch ex As Threading.ThreadAbortException
                Exit Do
            Catch ex As Exception
                'MsgBox(ex.ToString())
                Throw ex
            End Try
        Loop While innerBreak > 0
    End Sub

    Private Sub CloseBT_Click(sender As Object, e As EventArgs) Handles CloseBT.Click
        Me.DialogResult = DialogResult.No
        Me.Close()
    End Sub

    Private Sub SiegerDialog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        t.Abort()
    End Sub

    Private Sub NeuesSpielBT_Click(sender As Object, e As EventArgs) Handles NeuesSpielBT.Click
        Me.DialogResult = DialogResult.Yes
        Me.Close()
    End Sub
End Class