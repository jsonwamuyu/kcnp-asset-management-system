Imports System.Data.OleDb

Public Class StaffDashboard
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=B:\KCNPAssetMngSystem\kcnp\KCNP_Assets.accdb")

    Private Sub StaffDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen


        ' Prevent unauthorized access
        If Session.LoggedInRole <> "Staff" Then
            MessageBox.Show("Unauthorized access!")
            Me.Close()
            LoginForm.Show()
            Exit Sub
        End If

        lblWelcomeStaff.Text = "Welcome, " & Session.LoggedInUsername

        'LoadAvailableAssets()
        'LoadMyRequests()
    End Sub

    'Logout user and redirect to Login Page
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogoutStaff.Click
        Session.LoggedInUsername = ""
        Session.LoggedInRole = ""
        Me.Close()
        Dim login As New LoginForm()
        login.Show()
    End Sub
End Class
