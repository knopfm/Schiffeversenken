Public Class Login_Dialog
    Private HauptmenüForm As HauptmenüDialog
    Private MPC As MultiplayerClient
    Private players() As Profil

    ' TODO: Code zum Durchführen der benutzerdefinierten Authentifizierung mithilfe des angegebenen Benutzernamens und des Kennworts hinzufügen 
    ' (Siehe http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' Der benutzerdefinierte Prinzipal kann anschließend wie folgt an den Prinzipal des aktuellen Threads angefügt werden: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' wobei CustomPrincipal die IPrincipal-Implementierung ist, die für die Durchführung der Authentifizierung verwendet wird. 
    ' Anschließend gibt My.User Identitätsinformationen zurück, die in das CustomPrincipal-Objekt gekapselt sind,
    ' z. B. den Benutzernamen, den Anzeigenamen usw.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If PasswordTextBox.Text = players(NameComboBox.SelectedIndex).getNickname() Then
            HauptmenüForm.setPlayer(players(NameComboBox.SelectedIndex))
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Passwort falsch", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.DialogResult = DialogResult.Abort
        Me.Close()
    End Sub

    Public Sub New(HauptmenüForm As HauptmenüDialog, pMPCleint As MultiplayerClient, pPlayers() As String)
        Me.HauptmenüForm = HauptmenüForm
        InitializeComponent()
        MPC = pMPCleint
        Dim X(pPlayers.Length - 1) As Profil
        For i As Integer = 0 To pPlayers.Length - 1
            X(i) = New Profil
            X(i).unserialize(pPlayers(i))
            NameComboBox.Items.Add(X(i).getName())
        Next
        players = X
        NameComboBox.Items.Add("Neuer Spieler")
        NameComboBox.SelectedIndex = 0
    End Sub

    Private Sub Login_Dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MPC.connect()
    End Sub

    Private Sub NameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NameComboBox.SelectedIndexChanged
        If NameComboBox.SelectedIndex = NameComboBox.Items.Count - 1 Then
            Dim neuerSpielerForm As New Login_Neu_Dialog(MPC)
            Me.Hide()
            Me.DialogResult = neuerSpielerForm.ShowDialog()
            HauptmenüForm.setPlayer(New Profil(2, neuerSpielerForm.UsernameTextBox.Text, neuerSpielerForm.PasswordTextBox.Text, New FeldSetting(10, 10)))
            Me.Close()
        Else
            PasswordTextBox.Focus()
        End If
    End Sub
End Class

'TODO: Spieler hier eintrage