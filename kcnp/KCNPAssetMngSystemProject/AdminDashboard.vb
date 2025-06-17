Public Class AdminDashboard
    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Session.LoggedInRole <> "Admin" Then
            MessageBox.Show("Unauthorized access!")
            Me.Close()
            Dim loginForm As New LoginForm()
            loginForm.Show()
        End If
    End Sub

    ' Button1 - Add Asset
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim addAssetForm As New AddAsset()
        addAssetForm.ShowDialog()
    End Sub

    ' Button2 - Manage Users
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim manageUsersForm As New ManageUsersForm()
        manageUsersForm.ShowDialog()
    End Sub

    ' Button3 - Manage Asset Requests
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim manageRequestsForm As New ManageAssetRequestsForm()
        manageRequestsForm.ShowDialog()
    End Sub
End Class