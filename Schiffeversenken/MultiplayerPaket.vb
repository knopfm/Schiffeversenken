Public MustInherit Class MultiplayerPaket

    Public MustOverride Function serialize() As String
    Public MustOverride Function serialize(pClass As MultiplayerPaket) As String
    Public MustOverride Sub unserialize(pValue As String)
    Public MustOverride Sub unserialize(pValue As String, pClass As MultiplayerPaket)

    Public Function unserializeBlock(pValue As String) As List(Of String)
        Dim ret As New List(Of String)
        Dim work As String = ""
        Dim restIndex As Integer = 0
        Dim anfangIndex As Integer = 0

        If pValue.Substring(0, 1) = "{" Then
            Return unserializeBlock(pValue.Substring(1, pValue.Length - 2))
        End If

        While restIndex < pValue.Length
            anfangIndex = restIndex
            restIndex = pValue.IndexOf("=") + 1
            Dim j As Integer = restIndex
            Dim klammer As Integer = 0
            While j < pValue.Length
                If pValue.Substring(j, 1) = ";" And klammer = 0 Then
                    ret.Add(pValue.Substring(anfangIndex, (j - anfangIndex)))
                    anfangIndex = j + 1
                End If
                If pValue.Substring(j, 1) = "}" And klammer = 0 Then
                    ret.Add(pValue.Substring(anfangIndex, (j - anfangIndex)))
                End If
                If pValue.Substring(j, 1) = "{" Then
                    klammer += 1
                End If
                If pValue.Substring(j, 1) = "}" Then
                    klammer -= 1
                End If
                If j = pValue.Length - 1 Then
                    ret.Add(pValue.Substring(anfangIndex, (j - anfangIndex) + 1))
                End If
                j += 1
            End While
            restIndex = j
            restIndex += 1
        End While

        'input =    "Name=MeinName;Nickname=Nickii;GID=10;Feld={...};Schiffe={...}"
        '            012345678901234567890123456789012345678901234567890123456789012
        '            0         1         2         3         4         5         6
        'ziel : ret={"Name=MeinName";"Nickname=Nickii";"GID=10";"Feld={...}";"Schiffe={...}"}
        Return ret
    End Function

End Class
