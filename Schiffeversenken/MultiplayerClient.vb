Imports System.IO
Imports System.Net
Imports System.Net.Sockets

Public Class MultiplayerClient
    Private stream As NetworkStream
    Private streamw As StreamWriter
    Private streamr As StreamReader
    Private client As New TcpClient
    Private IPEndPunkt As IPEndPoint
    Private listener As Threading.Thread
    Private id As Integer = 0
    Public Event NeueNachricht(msg As String)
    Public Event ConnectionLost()
    Public Const NOTCONNECTED As Integer = 0

    Public Property ServerIP As IPEndPoint
        Get
            Return IPEndPunkt
        End Get
        Set(value As IPEndPoint)
            IPEndPunkt = value
        End Set
    End Property

    Public Function Send(msg As String) As Boolean
        If client.Connected And id <> NOTCONNECTED Then
            Try
                streamw.WriteLine(msg)
                streamw.Flush()
                Return True
            Catch
                Console.WriteLine("Error on sending Message")
            End Try
        End If
        Return False
    End Function

    Private Sub receive()
        While client.Connected And id <> NOTCONNECTED
            Try
                Dim msg As String
                msg = streamr.ReadLine()
                If msg = "ServerStop" Then
                    RaiseEvent ConnectionLost()
                Else
                    RaiseEvent NeueNachricht(msg)
                End If
            Catch ex As Threading.ThreadAbortException
                Exit Sub
            Catch ex As Exception
                Console.WriteLine("Error on receive Message")
                client.Close()
                RaiseEvent ConnectionLost()
            End Try
        End While
    End Sub

    Public Function connect() As Integer
        Try
            If IPEndPunkt Is Nothing Then
                Exit Try
            End If
            client = New TcpClient
            client.Connect(IPEndPunkt)
            If client.Connected Then
                stream = client.GetStream
                streamw = New StreamWriter(stream)
                streamr = New StreamReader(stream)
                streamw.WriteLine("")
                streamw.Flush()
                id = streamr.ReadLine()
                listener = New Threading.Thread(AddressOf receive)
                listener.Start()
                Return id
            End If
        Catch ex As Exception
            Console.WriteLine("Error on connect Server")
            'MsgBox(ex.ToString)
            disconnect()
        End Try
        id = NOTCONNECTED
        Return id
    End Function

    Public Function disconnect() As Boolean
        Try
            id = NOTCONNECTED
            If client.Connected Then
                streamr.Close()
                streamw.Close()
                stream.Close()
                client.Close()
                listener.Abort()
            End If
            Return True
        Catch ex As Threading.ThreadAbortException
            Return True
        Catch ex As Exception
            Console.WriteLine("Error on disconnect to Server")
        End Try
        Return False
    End Function

    Public Function connected() As Boolean
        Try
            Return client.Connected
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
