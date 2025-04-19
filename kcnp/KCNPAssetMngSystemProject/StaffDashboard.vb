Public Class StaffDashboard
    Private Sub StaffDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Session.LoggedInRole <> "Staff" Then
            MessageBox.Show("Unauthorized access!")
            Me.Close()
            Dim loginForm As New LoginForm()
            loginForm.Show()
        End If
    End Sub
End Class