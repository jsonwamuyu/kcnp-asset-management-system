Public Class MaintenanceDashboard
    Private Sub MaintenanceDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Session.LoggedInRole <> "Maintenance" Then
            MessageBox.Show("Unauthorized access!")
            Me.Close()
            Dim loginForm As New LoginForm()
            loginForm.Show()
        End If
    End Sub
End Class