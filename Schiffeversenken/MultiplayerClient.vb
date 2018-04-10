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
    Private mID As Integer
    Private inited As Boolean
    Public Event NeueNachricht(msg As String)

    Public Sub New(pIPEndPunkt As IPEndPoint)
        IPEndPunkt = pIPEndPunkt
    End Sub

    Public Function send(msg As String) As Boolean
        If client.Connected And inited Then
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
        While client.Connected And inited
            Try
                Dim msg As String
                msg = streamr.ReadLine()
                RaiseEvent NeueNachricht(msg)
            Catch ex As Exception
                'MsgBox(ex.ToString)
            End Try
        End While
    End Sub

    Public Function connect() As Boolean
        Try
            client = New TcpClient
            client.Connect(IPEndPunkt)
            If client.Connected Then
                stream = client.GetStream
                streamw = New StreamWriter(stream)
                streamr = New StreamReader(stream)
                streamw.WriteLine("")
                streamw.Flush()
                listener = New Threading.Thread(AddressOf receive)
                listener.Start()
                inited = True
                Return inited
            End If
        Catch ex As Exception
            Console.WriteLine("Error on connect to Server")
            'MsgBox(ex.ToString)
            disconnect()
        End Try
        inited = False
        Return inited
    End Function

    Public Function disconnect() As Boolean
        Try
            If client.Connected Then
                inited = False
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
