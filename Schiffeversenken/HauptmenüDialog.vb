﻿Public Class HauptmenüDialog
    Private EinstellunForm As New EinstellungenDialog
    Private StatistikForm As New StatistikDialog
    Private WithEvents SpielerSucheForm As SpielerSucheDialog
    Private t As New Threading.Thread(AddressOf bilder)
    Private innerBilderIndex As Integer = 0
    Public Shared config As New SettingsObject

    Private Sub PlayBT_Click(sender As Object, e As EventArgs) Handles PlayBT.Click
        Me.Hide()
        SpielerSucheForm = New SpielerSucheDialog
        SpielerSucheForm.Show()
    End Sub

    Private Sub SpielerSuchenForm_Schließen() Handles SpielerSucheForm.Schließen
        Me.Show()
    End Sub

    Private Sub StatistikBT_Click(sender As Object, e As EventArgs) Handles StatistikBT.Click
        StatistikForm.ShowDialog()
    End Sub

    Private Sub ConfigBT_Click(sender As Object, e As EventArgs) Handles ConfigBT.Click
        EinstellunForm.ShowDialog()
    End Sub

    Private Sub CloseBT_Click(sender As Object, e As EventArgs) Handles CloseBT.Click
        Me.Close()
    End Sub

    Private Sub HauptmenüDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("config.xml") Then
            Dim file As New IO.StreamReader("config.xml")
            Dim reader As New Xml.Serialization.XmlSerializer(GetType(SettingsObject))
            config = CType(reader.Deserialize(file), SettingsObject)
            file.Close()
        End If
        Sprachpakete.Datei = config.Lang
        PlayBT.Text = Sprachpakete.GetUbersetzung("playBT")
        StatistikBT.Text = Sprachpakete.GetUbersetzung("statisticsBT")
        ConfigBT.Text = Sprachpakete.GetUbersetzung("configBT")
        CloseBT.Text = Sprachpakete.GetUbersetzung("endBT")
        Me.Text = Sprachpakete.GetUbersetzung("mainmenu")
        t.Start()
    End Sub

    Private Sub bilder()
        Do
            Try
                Select Case innerBilderIndex
                    Case 0
                        'LogoPB.Image = 
                        'TODO: Bilder
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
        Dim file As New IO.StreamWriter("config.xml")
        Dim writer As New Xml.Serialization.XmlSerializer(GetType(SettingsObject))
        writer.Serialize(file, config)
        file.Close()
    End Sub
End Class

Public Class SettingsObject
    Public Ip As String = "127.0.0.1"
    Public Lang As String = "..\..\DE.lang"
    Public c As String = (-14634326).ToString
    Public points As Double = 1
    Public GrafikIndex As Integer = 5

    <System.Xml.Serialization.XmlIgnoreAttribute>
    Public Property Color As Color
        Get
            Return Color.FromArgb(c)
        End Get
        Set(value As Color)
            c = value.ToArgb
        End Set
    End Property
End Class