Public Class GameChoose
    Private player As Profil
    Private HauptmenüForm As HauptmenüDialog
    Private topLeft, topRight, bottomLeft, bottomRight As FeldDialog10


    Private Sub GameChoose_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        clear_windows()
    End Sub

    Private Sub clear_windows()
        Try
            topLeft.Dispose()
        Catch ex As Exception
        End Try
        Try
            topRight.Dispose()
        Catch ex As Exception
        End Try
        Try
            bottomLeft.Dispose()
        Catch ex As Exception
        End Try
        Try
            bottomRight.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AbortBT_Click(sender As Object, e As EventArgs) Handles AbortBT.Click
        Me.Close()
    End Sub

    Private Sub GameChoose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setText(NameTB, player.getNickname)
        If player.getFeld.getHoehe() = 10 Then
            Feld10RB.Checked = True
        Else
            Feld10RB.Checked = False
        End If
        If player.getFeld.getHoehe() = 20 Then
            Feld20RB.Checked = True
        Else
            Feld20RB.Checked = False
        End If
    End Sub

    Public Sub New(HauptmenüForm As HauptmenüDialog, pPlayer As Profil)
        Me.player = pPlayer
        Me.HauptmenüForm = HauptmenüForm
        InitializeComponent()
    End Sub

    Private Sub setText(pTB As TextBox, pText As String)
        pTB.Text = pText
    End Sub

    Private Sub Player_Click(sender As Object, e As EventArgs) Handles One.Click, Two.Click, Three.Click
        clear_windows()
        Dim pref_w As Integer = My.Computer.Screen.WorkingArea.Size.Width * 0.45
        Dim pref_h As Integer = My.Computer.Screen.WorkingArea.Size.Height * 0.45
        Dim bt As Button = CType(sender, Button)
        If bt.Name = "One" Then
            topLeft = New FeldDialog10("PC")
            bottomLeft = New FeldDialog10(player.getName)
            topLeft.Show()
            bottomLeft.Show()
            topLeft.fillPanel()
            bottomLeft.fillPanel()
            'Me.Hide()
            topLeft.Size = New Point(pref_w, pref_h)
            bottomLeft.Size = New Point(pref_w, pref_h)
            topLeft.Location = New Point(My.Computer.Screen.WorkingArea.Size.Width / 2 - topLeft.Size.Width / 2, My.Computer.Screen.WorkingArea.Size.Height / 2 - topLeft.Size.Height - 20)
            bottomLeft.Location = New Point(My.Computer.Screen.WorkingArea.Size.Width / 2 - bottomLeft.Size.Width / 2, My.Computer.Screen.WorkingArea.Size.Height / 2 + 20)
        ElseIf bt.Name = "Two" Then
            topLeft = New FeldDialog10(player.getName)
            bottomLeft = New FeldDialog10(player.getName)
            topRight = New FeldDialog10(player.getName)
            bottomRight = New FeldDialog10(player.getName)
            topLeft.Show()
            topRight.Show()
            bottomLeft.Show()
            bottomRight.Show()
            topLeft.fillPanel()
            topRight.fillPanel()
            bottomLeft.fillPanel()
            bottomRight.fillPanel()
            'Me.Hide()
            topLeft.Size = New Point(pref_w, pref_h)
            topRight.Size = New Point(pref_w, pref_h)
            bottomLeft.Size = New Point(pref_w, pref_h)
            bottomRight.Size = New Point(pref_w, pref_h)
            topLeft.Location = New Point(My.Computer.Screen.WorkingArea.Size.Width * 0.49 - topLeft.Size.Width, My.Computer.Screen.WorkingArea.Size.Height * 0.49 - topLeft.Size.Height)
            bottomLeft.Location = New Point(My.Computer.Screen.WorkingArea.Size.Width * 0.49 - bottomLeft.Size.Width, My.Computer.Screen.WorkingArea.Size.Height * 0.51)
            topRight.Location = New Point(My.Computer.Screen.WorkingArea.Size.Width * 0.51, My.Computer.Screen.WorkingArea.Size.Height * 0.49 - topRight.Size.Height)
            bottomRight.Location = New Point(My.Computer.Screen.WorkingArea.Size.Width * 0.51, My.Computer.Screen.WorkingArea.Size.Height * 0.51)
        End If
    End Sub

    Protected Sub unHide()
        Me.Show()
    End Sub
End Class