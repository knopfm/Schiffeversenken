Public Class SpielerSucheDialog
    Private id As Integer = 0
    Private HauptmenüForm As HauptmenüDialog
    Private WithEvents mpc As New MultiplayerClient
    Private WithEvents bottomForm, topForm As FeldDialog10
    Private WithEvents SpielC As SpielController
    Private Status As SpielerSucheStatus = SpielerSucheStatus.Offline
    Public Event Schließen()

    Private Sub GameChoose_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        clear_windows()
        mpc.disconnect()
        RaiseEvent Schließen()
    End Sub

    Private Sub clear_windows()
        Try
            topForm.Dispose()
        Catch ex As Exception
        End Try
        Try
            bottomForm.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AbortBT_Click(sender As Object, e As EventArgs) Handles AbortBT.Click
        Me.Status = SpielerSucheStatus.Offline
        Me.DialogResult = DialogResult.Abort
        Me.Close()
    End Sub

    Private Sub SpielerSucheDialog_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ListBox1.Size = New Point(Me.Size.Width - 109, ListBox1.Size.Height)
    End Sub

    Private Sub SpielerSucheDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mpc.ServerIP = New Net.IPEndPoint(New Net.IPAddress({127, 0, 0, 1}), 8130)
        id = mpc.connect()
        Me.Text = Me.Text & " - " & Me.id
        If id = MultiplayerClient.NOTCONNECTED Then
            ListBox1.Enabled = False
            MessageBox.Show("No valid IP Addres or Server not avaible.", "Server IP Address", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Status = SpielerSucheStatus.Offline
        Else
            mpc.send("getClients")
            ListBox1.Enabled = True
            Me.Status = SpielerSucheStatus.Online
        End If
        ListBox1.SelectedIndex = -1
    End Sub

    Private Sub ServerBT_Click(sender As Object, e As EventArgs) Handles ServerBT.Click
        If mpc.connected Then
            mpc.disconnect()
        End If
        Dim input As String = InputBox("Write down Server IP-Address." & vbCrLf & "like: 127.0.0.1", "Server IP Address", "127.0.0.1")
        Try
            Dim bArray() As Byte = {input.Split(".")(0), input.Split(".")(1), input.Split(".")(2), input.Split(".")(3)}
            mpc.ServerIP = New Net.IPEndPoint(New Net.IPAddress(bArray), 8130)
            id = mpc.connect()
            Me.Text = Me.Text & " - " & Me.id
            If id = MultiplayerClient.NOTCONNECTED Then
                ListBox1.Enabled = False
                MessageBox.Show("No valid IP Address or Server not avaible." & vbCrLf & "Try it again.", "Server IP Address", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Status = SpielerSucheStatus.Offline
            Else
                mpc.send("getClients")
                ListBox1.Enabled = True
                Me.Status = SpielerSucheStatus.Online
            End If
        Catch ex As Exception
            MessageBox.Show("No valid IP Address" & vbCrLf & "Try it again.", "Server IP Address", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ListBox1.SelectedIndex = -1
    End Sub

    Private Sub ConnectBT_Click(sender As Object, e As EventArgs) Handles ConnectBT.Click
        If ListBox1.SelectedIndex <> -1 Then
            If ListBox1.SelectedItem.ToString = Me.id And False Then
                MessageBox.Show("Du kannst dich nicht mit dir selbst verbinden!", "Spieler auffordern", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If MessageBox.Show("Möchten sie sich mt " & ListBox1.SelectedItem.ToString & " verbinden?", "Spieler auffordern", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    mpc.send("TryConnect:" & ListBox1.SelectedItem.ToString & ";" & id)
                    Me.Status = SpielerSucheStatus.Verbinden
                End If
            End If
        Else
            MessageBox.Show("Wählen sie einen Spieler aus!", "Spieler asuwählen", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        ListBox1.SelectedIndex = -1
        Me.Status = SpielerSucheStatus.Online
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
            Me.Status = SpielerSucheStatus.Spielen
            SpielC = New SpielController(Me.id, CInt(msg.Substring(msg.IndexOf(";") + 1)))
            Invoke(New dCreatGame(AddressOf createGame), SpielC)
        ElseIf msg.StartsWith("AbortConnect:") Then
            MessageBox.Show(msg.Substring(msg.IndexOf(";") + 1) & " möchte nicht mit dir Spielen!", "Spieler auffordern", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Status = SpielerSucheStatus.Online
        ElseIf msg.StartsWith("TryConnect:") Then
            If MessageBox.Show("Möcheten Sie sich mit " & msg.Substring(msg.IndexOf(";") + 1) & " verbinden um zu spielen?", "Spieler auffordern", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Status = SpielerSucheStatus.Spielen
                mpc.send("ConnectWith:" & msg.Substring(msg.IndexOf(";") + 1) & ";" & Me.id)
                SpielC = New SpielController(Me.id, CInt(msg.Substring(msg.IndexOf(";") + 1)))
                Invoke(New dCreatGame(AddressOf createGame), SpielC)
            Else
                mpc.send("AbortConnect:" & msg.Substring(msg.IndexOf(";") + 1) & ";" & Me.id)
                Me.Status = SpielerSucheStatus.Online
                SpielC = Nothing
            End If

        Else
            If Me.Status = SpielerSucheStatus.Spielen Then
                SpielC.NetzwerkReceive(msg)
            End If
        End If
    End Sub

    Private Delegate Sub dCreatGame(spc As SpielController)
    Private Sub createGame(spc As SpielController)
        clear_windows()
        topForm = New FeldDialog10(spc.duID)
        bottomForm = New FeldDialog10(spc.ichID)
        bottomForm.Show()
        Me.Hide()
        bottomForm.Location = New Point(My.Computer.Screen.WorkingArea.Size.Width / 2 - bottomForm.Size.Width / 2, My.Computer.Screen.WorkingArea.Size.Height / 2 - bottomForm.Size.Height / 2)
        spc.startGame()
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

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex <> -1 Then
            ConnectBT.Enabled = True
        Else
            ConnectBT.Enabled = False
        End If
    End Sub

    Private Sub mpc_ConnectionLost() Handles mpc.ConnectionLost
        Try
            Invoke(New dClearClients(AddressOf ClearClients))
            Invoke(New dEnableClients(AddressOf EnableClients), False)
            'MsgBox("Connection Lost")
            If Me.Status = SpielerSucheStatus.Spielen Then
                SpielC.NetzwerkLost()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SpielC_NetzwerkSend(msg As String) Handles SpielC.NetzwerkSend
        mpc.send(msg)
    End Sub

    Private Sub SpielC_Time(pT As String) Handles SpielC.Time
        Invoke(New dSetTime(AddressOf SetTime), pT)
    End Sub

    Private Delegate Sub dSetTime(pT As String)
    Private Sub SetTime(pT As String)
        bottomForm.setTime(pT)
        topForm.setTime(pT)
    End Sub

    Private Sub bottomForm_FeldKlick(ft As FeldTeil) Handles bottomForm.FeldKlick
        SpielC.EigenesFeldKlick(ft)
    End Sub

    Private Sub bottomForm_Beenden() Handles bottomForm.Beenden
        SpielC.stopGame()
        topForm.Close()
        bottomForm.Close()
        Me.Show()
    End Sub

    Private Sub SpielC_Beenden() Handles SpielC.Beenden
        topForm.Close()
        bottomForm.Close()
        Me.Show()
    End Sub

    Private Sub SpielC_ChangeLayout() Handles SpielC.changeLayout
        Invoke(New dChangeLyout(AddressOf ChangeLayout))
    End Sub

    Private Delegate Sub dChangeLyout()
    Private Sub ChangeLayout()
        topForm.Show()
        topForm.diasableStop()
        topForm.Location = New Point(My.Computer.Screen.WorkingArea.Size.Width / 2 - topForm.Size.Width / 2, My.Computer.Screen.WorkingArea.Size.Height / 2 - topForm.Size.Height - 20)
        bottomForm.Location = New Point(My.Computer.Screen.WorkingArea.Size.Width / 2 - bottomForm.Size.Width / 2, My.Computer.Screen.WorkingArea.Size.Height / 2 + 20)
    End Sub

    Private Sub SpielC_placeShip(ship As Schiff) Handles SpielC.placeSchip
        bottomForm.platziereSchiff(ship)
    End Sub

    Private Sub bottomForm_Start() Handles bottomForm.Start
        SpielC.startKlick()
    End Sub

    Private Sub SpielC_Start(e As Boolean) Handles SpielC.Start
        bottomForm.enableStart(e)
    End Sub
End Class

Public Enum SpielerSucheStatus
    Offline
    Online
    Verbinden
    Spielen
End Enum