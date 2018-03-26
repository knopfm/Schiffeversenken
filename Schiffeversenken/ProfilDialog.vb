Public Class ProfilDialog
    Private Sub ProfilDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As New Profil(10, "MeinName", "Nickii", New FeldSetting(5, 9))
        x.addSchiff(New Schiff(3, 3, 30, 3))
        x.addSchiff(New Schiff(4, 4, 40, 4))
        x.addSchiff(New Schiff(5, 5, 50, 5))
        Dim y As String = x.serialize()
        Dim z As New Profil
        z.unserialize(y)
        MsgBox(z.serialize)
    End Sub
End Class