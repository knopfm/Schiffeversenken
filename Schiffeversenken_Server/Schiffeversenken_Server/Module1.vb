Imports System.IO
Imports System.Net
Imports System.Net.Sockets

Module Module1

    Private ipEndPunkt As New IPEndPoint(IPAddress.Any, 8130)
    Private Server As TcpListener
    Private ServerLauft As Boolean = False
    Private Structure Connection
        Dim stream As NetworkStream
        Dim streamw As StreamWriter
        Dim streamr As StreamReader
        Dim thread As Threading.Thread
        Dim id As Integer
    End Structure
    Private ConnectionList As New List(Of Connection)
    Private newID As Integer = 1

    Sub Main()
        Try
            Logging("Server Start")
            Server = New TcpListener(ipEndPunkt)
            Server.Start()
            Server.BeginAcceptTcpClient(New AsyncCallback(AddressOf ClientConnect), Server)
            ServerLauft = True
        Catch ex As Exception
            Logging("Error on start")
            Exit Sub
        End Try

        Logging("Wait for Clients       Press c for abort")
        Do While ServerLauft
            Dim input As ConsoleKeyInfo = Console.ReadKey()
            If input.Key = ConsoleKey.C Then
                SendToAllClients("ServerStop")
                ServerLauft = False
            End If
        Loop
        Console.SetCursorPosition(0, Console.CursorTop)
        For Each c As Connection In ConnectionList
            c.streamw.Flush()
            c.streamw.Close()
            c.streamr.Close()
            c.stream.Flush()
            c.stream.Close()
            c.thread.Abort()
        Next
        Server.Stop()
        Logging("Server stop")
        Threading.Thread.Sleep(1000)
        Logging("Press Enter to Contiue", True)
        ' Console.ReadLine()
    End Sub

    Private Sub ClientConnect(ar As IAsyncResult)
        Try
            Dim _server As TcpListener = CType(ar.AsyncState, TcpListener)
            Dim _client As TcpClient = _server.EndAcceptTcpClient(ar)
            Dim c As New Connection
            c.stream = _client.GetStream()
            c.streamr = New StreamReader(c.stream)
            c.streamw = New StreamWriter(c.stream)
            c.streamr.ReadLine()
            c.streamw.WriteLine(newID)
            c.id = newID
            c.streamw.Flush()
            newID += 1
            Dim t As New Threading.Thread(AddressOf ListenToConnection)
            t.Start(c)
            c.thread = t
            ConnectionList.Add(c)
            Logging("Client " & c.id & " joined")
            If ServerLauft Then
                Server.BeginAcceptTcpClient(New AsyncCallback(AddressOf ClientConnect), Server)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ListenToConnection(c As Connection)
        Do
            Try
                Dim msg As String = c.streamr.ReadLine()
                Logging("Client " & c.id & " writes: " & msg)
                If msg = "getClients" Then
                    Dim ret As String = "Clients:"
                    For Each _c As Connection In ConnectionList
                        ret += _c.id & ";"
                    Next
                    ret = ret.Substring(0, ret.Length - 1)
                    SendToAllClients(ret)
                ElseIf msg.StartsWith("TryConnect:") Then
                    send(msg.Substring(msg.IndexOf(":") + 1, (msg.IndexOf(";") - msg.IndexOf(":")) - 1), msg)
                ElseIf msg.StartsWith("ConnectWith:") Then
                    send(msg.Substring(msg.IndexOf(":") + 1, (msg.IndexOf(";") - msg.IndexOf(":")) - 1), msg)
                ElseIf msg.StartsWith("AbortConnect:") Then
                    send(msg.Substring(msg.IndexOf(":") + 1, (msg.IndexOf(";") - msg.IndexOf(":")) - 1), msg)
                ElseIf msg.StartsWith("ReadyStart:") Then
                    send(msg.Substring(msg.IndexOf(":") + 1, (msg.IndexOf(";") - msg.IndexOf(":")) - 1), msg)
                Else
                    SendToAllClients(msg)
                End If
            Catch ex As Exception
                Dim ret As Connection = c
                For Each _c In ConnectionList
                    If _c.id = c.id Then
                        ret = _c
                    End If
                Next
                ConnectionList.Remove(ret)
                Logging("Client " & c.id & " left")
                Dim ret1 As String = "Clients:"
                For Each _c As Connection In ConnectionList
                    ret1 += _c.id & ";"
                Next
                ret1 = ret1.Substring(0, ret1.Length - 1)
                SendToAllClients(ret1)
                Exit Do
            End Try
        Loop While ServerLauft
    End Sub

    Private Sub SendToAllClients(ByVal msg As String)
        For Each c As Connection In ConnectionList
            Try
                Logging("ToAll: " & msg)
                c.streamw.WriteLine(msg)
                c.streamw.Flush()
            Catch
            End Try
        Next
    End Sub

    Private Sub send(id As Integer, msg As String)
        For Each c As Connection In ConnectionList
            If c.id = id Then
                Try
                    Logging("To " & id & ": " & msg)
                    c.streamw.WriteLine(msg)
                    c.streamw.Flush()
                Catch
                End Try
            End If
        Next
    End Sub

    Private Sub Logging(s As String)
        Console.WriteLine(Format(Now, "[dd.MM.yyyy-HH:mm:ss:ffff]  ") & s)
    End Sub

    Private Sub Logging(s As String, noTime As Boolean)
        If noTime Then
            Console.Write(s)
        Else
            Console.WriteLine(Format(Now, "[dd.MM.yyyy-HH:mm:ss:ffff]  ") & s)
        End If
    End Sub
End Module
