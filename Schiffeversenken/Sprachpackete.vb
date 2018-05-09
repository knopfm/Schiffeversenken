Imports System.IO
Imports System.Xml

Module Sprachpackete

    Private _datei As String
    Private _xmlDoc As New XmlDocument

    Public Property Datei As String
        Get
            Return _datei
        End Get
        Set(value As String)
            _datei = value
            _xmlDoc.Load(_datei)
        End Set
    End Property

    Public Function GetUbersetzung(pSeach As String) As String
        Try
            Return _xmlDoc.GetElementsByTagName(pSeach).Item(0).InnerText
        Catch ex As Exception
            Return pSeach
        End Try
    End Function
End Module
