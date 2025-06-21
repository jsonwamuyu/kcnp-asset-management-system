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

            AssetsGrid.DataSource = dt

            ' Add buttons only once
            If Not AssetsGrid.Columns.Contains("Edit") Then
                Dim editBtn As New DataGridViewButtonColumn()
                editBtn.Name = "Edit"
                editBtn.HeaderText = "Edit"
                editBtn.Text = "Edit"
                editBtn.UseColumnTextForButtonValue = True
                AssetsGrid.Columns.Add(editBtn)
            End If

            If Not AssetsGrid.Columns.Contains("Delete") Then
                Dim deleteBtn As New DataGridViewButtonColumn()
                deleteBtn.Name = "Delete"
                deleteBtn.HeaderText = "Delete"
                deleteBtn.Text = "Delete"
                deleteBtn.UseColumnTextForButtonValue = True
                AssetsGrid.Columns.Add(deleteBtn)
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to load assets: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Handle Edit and Delete Button Clicks
    Private Sub AssetsGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AssetsGrid.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        Dim assetID As Integer = CInt(AssetsGrid.Rows(e.RowIndex).Cells("AssetID").Value)
        Dim clickedColumn As String = AssetsGrid.Columns(e.ColumnIndex).Name

        If clickedColumn = "Edit" Then
            Dim editForm As New EditAssetForm(assetID)
            editForm.ShowDialog()
            LoadAssets()

        ElseIf clickedColumn = "Delete" Then
            Dim confirm = MessageBox.Show("Are you sure you want to delete this asset?", "Confirm Delete", MessageBoxButtons.YesNo)
            If confirm = DialogResult.Yes Then
                DeleteAsset(assetID)
                LoadAssets()
            End If
        End If
    End Sub

    ' Delete Asset from Database
    Private Sub DeleteAsset(assetID As Integer)
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=B:\KCNPAssetMngSystem\kcnp\KCNP_Assets.accdb"
        Using conn As New OleDbConnection(connString)
            Try
                conn.Open()
                Dim cmd As New OleDbCommand("DELETE FROM Assets WHERE AssetID = ?", conn)
                cmd.Parameters.AddWithValue("@AssetID", assetID)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Failed to delete asset: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Button1 - Add Asset
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim addAssetForm As New AddAsset()
        addAssetForm.ShowDialog()
        LoadAssets() ' Refresh after adding
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

    Private Sub btnLogoutStaff_Click(sender As Object, e As EventArgs) Handles btnLogoutStaff.Click
        Session.LoggedInUsername = ""
        Session.LoggedInRole = ""
        Me.Close()
        Dim login As New LoginForm()
        login.Show()
    End Sub
End Class
