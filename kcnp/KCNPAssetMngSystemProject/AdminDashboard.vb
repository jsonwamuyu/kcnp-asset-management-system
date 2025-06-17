Imports System.Data.OleDb

Public Class AdminDashboard
    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Session.LoggedInRole <> "Admin" Then
            MessageBox.Show("Unauthorized access!")
            Me.Close()
            Dim loginForm As New LoginForm()
            loginForm.Show()
        Else
            LoadAssets()
        End If
    End Sub


    ' Load and display assets in the DataGridView
    Private Sub LoadAssets()
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=B:\KCNPAssetMngSystem\kcnp\KCNP_Assets.accdb"
        Dim conn As New OleDbConnection(connString)

        Try
            conn.Open()
            Dim query As String = "SELECT AssetID, AssetName, Description, PurchaseDate, Location FROM Assets"
            Dim cmd As New OleDbCommand(query, conn)
            Dim adapter As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ' Bind to DataGridView
            AssetsGrid.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Failed to load assets: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
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