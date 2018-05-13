Public Class SpielerSucheDialog
    Private id As Integer = 0
    Private HauptmenüForm As HauptmenüDialog
    Private WithEvents mpc As New MultiplayerClient
    Private WithEvents SpielC As SpielController
    Private Status As SpielerSucheStatus = SpielerSucheStatus.Offline
    Public Event Schließen()
    Private Delegate Sub dNR(MsgBox As String)
    Private Delegate Sub dNL()

    Private Sub SpielerSucheDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Sprachpakete.GetUbersetzung("playerSearch")
        ServerBT.Text = Sprachpakete.GetUbersetzung("serverBT")
        ConnectBT.Text = Sprachpakete.GetUbersetzung("connectBT")
        AbortBT.Text = Sprachpakete.GetUbersetzung("backBT")
        Try
            mpc.ServerIP = New Net.IPEndPoint(Net.IPAddress.Parse(HauptmenüDialog.config.Ip), 8130)
            id = mpc.connect()
            Me.Text = Sprachpakete.GetUbersetzung("playerSearch") & " - " & Me.id
        Catch ex As Exception
        End Try
        If id = MultiplayerClient.NOTCONNECTED Then
            ListBox1.Enabled = False
            'MessageBox.Show(Sprachpackete.GetUbersetzung("msg_NoValidIP"), Sprachpackete.GetUbersetzung("msg_SIP"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Status = SpielerSucheStatus.Offline
        Else
            mpc.Send("getClients")
            ListBox1.Enabled = True
            Me.Status = SpielerSucheStatus.Online
        End If
        ListBox1.SelectedIndex = -1
        ListBox1.BackColor = HauptmenüDialog.config.Color
    End Sub

    Private Sub ServerBT_Click(sender As Object, e As EventArgs) Handles ServerBT.Click
        If mpc.connected Then
            mpc.disconnect()
        End If
        Dim input As String = InputBox(Sprachpakete.GetUbersetzung("msg_WriteIP") & vbCrLf & Sprachpakete.GetUbersetzung("msg_WriteIP2") & " 127.0.0.1", Sprachpakete.GetUbersetzung("msg_SIP"), "127.0.0.1")
        If input <> "" Then
            Try
                Dim bArray() As Byte = {input.Split(".")(0), input.Split(".")(1), input.Split(".")(2), input.Split(".")(3)}
                mpc.ServerIP = New Net.IPEndPoint(New Net.IPAddress(bArray), 8130)
                id = mpc.connect()
                Me.Text = Sprachpakete.GetUbersetzung("playerSearch") & " - " & Me.id
                If id = MultiplayerClient.NOTCONNECTED Then
                    ListBox1.Enabled = False
                    MessageBox.Show(Sprachpakete.GetUbersetzung("msg_NoValidIP") & vbCrLf & Sprachpakete.GetUbersetzung("msg_TryAgain"), Sprachpakete.GetUbersetzung("msg_SIP"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Status = SpielerSucheStatus.Offline
                Else
                    mpc.Send("getClients")
                    ListBox1.Enabled = True
                    Me.Status = SpielerSucheStatus.Online
                End If
            Catch ex As Exception
                ListBox1.Enabled = False
                ListBox1.Items.Clear()
                MessageBox.Show(Sprachpakete.GetUbersetzung("msg_NoValidIP") & vbCrLf & Sprachpakete.GetUbersetzung("msg_TryAgain"), Sprachpakete.GetUbersetzung("msg_SIP"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ListBox1.Enabled = False
            ListBox1.Items.Clear()
        End If
        ListBox1.SelectedIndex = -1
    End Sub

    Private Sub ConnectBT_Click(sender As Object, e As EventArgs) Handles ConnectBT.Click
        If ListBox1.SelectedIndex <> -1 Then
            If ListBox1.SelectedItem.ToString = Me.id And False Then
                MessageBox.Show(Sprachpakete.GetUbersetzung("msg_ConnectYourself"), Sprachpakete.GetUbersetzung("msg_PlayerAnim"), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.Status = SpielerSucheStatus.Online
            Else
                If Me.Status = SpielerSucheStatus.Online Then
                    If MessageBox.Show(Sprachpakete.GetUbersetzung("msg_PlayWith") & " " & ListBox1.SelectedItem.ToString & " " & Sprachpakete.GetUbersetzung("msg_PlayWith2"), Sprachpakete.GetUbersetzung("msg_PlayerAnim"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        mpc.Send("TryConnect:" & ListBox1.SelectedItem.ToString & ";" & id)
                        Me.Status = SpielerSucheStatus.Verbinden
                    End If
                Else
                    MessageBox.Show(Sprachpakete.GetUbersetzung("msg_gameQuestion"), Sprachpakete.GetUbersetzung("msg_PlayerAnim"), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Me.Status = SpielerSucheStatus.Verbinden
                End If
            End If
        Else
            MessageBox.Show(Sprachpakete.GetUbersetzung("msg_ChoosPlayer"), Sprachpakete.GetUbersetzung("msg_PlayerAnim"), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Status = SpielerSucheStatus.Online
        End If
        ListBox1.SelectedIndex = -1
    End Sub

    Private Sub mpc_NeueNachricht(msg As String) Handles mpc.NeueNachricht
        If msg.StartsWith("Clients:") Then
            Dim x As String() = msg.Substring(msg.IndexOf(":") + 1).Split(";")
            Invoke(New dClearClients(AddressOf ClearClients))
            For Each v In x
                Invoke(New dAddClient(AddressOf AddClient), v)
            Next
            Invoke(New dSelectIndex(AddressOf SelectIndex), -1)
        ElseIf msg.StartsWith("ConnectWith:") Then
            If CInt(msg.Substring(msg.IndexOf(":") + 1, (msg.IndexOf(";") - msg.IndexOf(":")) - 1)) = id Then
                Me.Status = SpielerSucheStatus.Spielen
                If SpielC Is Nothing Then
                    SpielC = New SpielController(Me.id, CInt(msg.Substring(msg.IndexOf(";") + 1)))
                    Invoke(New dCreatGame(AddressOf createGame), SpielC)
                End If
            End If
        ElseIf msg.StartsWith("AbortConnect:") Then
            If CInt(msg.Substring(msg.IndexOf(":") + 1, (msg.IndexOf(";") - msg.IndexOf(":")) - 1)) = id Then
                MessageBox.Show(msg.Substring(msg.IndexOf(";") + 1) & " " & Sprachpakete.GetUbersetzung("msg_WouldNotPlay"), Sprachpakete.GetUbersetzung("msg_PlayerAnim"), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.Status = SpielerSucheStatus.Online
            End If
        ElseIf msg.StartsWith("TryConnect:") Then
            If CInt(msg.Substring(msg.IndexOf(":") + 1, (msg.IndexOf(";") - msg.IndexOf(":")) - 1)) = id Then
                If MessageBox.Show(msg.Substring(msg.IndexOf(";") + 1) & " " & Sprachpakete.GetUbersetzung("msg_WouldPlay"), "Spieler auffordern", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Me.Status = SpielerSucheStatus.Spielen
                    mpc.Send("ConnectWith:" & msg.Substring(msg.IndexOf(";") + 1) & ";" & Me.id)
                    SpielC = New SpielController(Me.id, CInt(msg.Substring(msg.IndexOf(";") + 1)))
                    Invoke(New dCreatGame(AddressOf createGame), SpielC)
                Else
                    mpc.Send("AbortConnect:" & msg.Substring(msg.IndexOf(";") + 1) & ";" & Me.id)
                    Me.Status = SpielerSucheStatus.Online
                    SpielC = Nothing
                End If

            End If
        Else
            If Me.Status = SpielerSucheStatus.Spielen Then
                Invoke(New dNR(AddressOf SpielC.NetzwerkReceive), msg)
            End If
        End If
    End Sub

    Private Sub mpc_ConnectionLost() Handles mpc.ConnectionLost
        Try
            Invoke(New dClearClients(AddressOf ClearClients))
            Invoke(New dEnableClients(AddressOf EnableClients), False)
            'MsgBox("Connection Lost")
            If Me.Status = SpielerSucheStatus.Spielen Then
                Invoke(New dNL(AddressOf SpielC.NetzwerkLost))
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AbortBT_Click(sender As Object, e As EventArgs) Handles AbortBT.Click
        Me.Status = SpielerSucheStatus.Offline
        Me.DialogResult = DialogResult.Abort
        Me.Close()
    End Sub

    Private Sub GameChoose_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            HauptmenüDialog.config.Ip = mpc.ServerIP.Address.ToString()
        Catch ex As Exception
        End Try
        If SpielC IsNot Nothing Then
            SpielC.Dispose()
        End If
        mpc.disconnect()
        RaiseEvent Schließen()
    End Sub



    Private Sub SpielerSucheDialog_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ListBox1.Size = New Point(Me.Size.Width - 109, ListBox1.Size.Height)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex <> -1 Then
            ConnectBT.Enabled = True
        Else
            ConnectBT.Enabled = False
        End If
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        ConnectBT.PerformClick()
    End Sub

    Private Sub SpielC_NetzwerkSend(msg As String) Handles SpielC.NetzwerkSend
        mpc.Send(msg)
    End Sub




    Private Sub SpielC_UnHide() Handles SpielC.UnHide
        Me.Show()
    End Sub

    Private Delegate Sub dCreatGame(spc As SpielController)
    Private Sub createGame(spc As SpielController)
        spc.PlanenPhaseBeginen()
        Me.Hide()
    End Sub

    Private Delegate Sub dAddClient(s As String)
    Private Sub AddClient(s As String)
        ListBox1.Items.Add(s)
    End Sub

    Private Delegate Sub dSelectIndex(i As Integer)
    Private Sub SelectIndex(i As Integer)
        ListBox1.SelectedIndex = i
    End Sub

    Private Delegate Sub dClearClients()
    Private Sub ClearClients()
        ListBox1.Items.Clear()
    End Sub

    Private Delegate Sub dEnableClients(e As Boolean)
    Private Sub EnableClients(e As Boolean)
        ListBox1.Enabled = e
    End Sub
End Class

Public Enum SpielerSucheStatus
    Offline
    Online
    Verbinden
    Spielen
End Enum