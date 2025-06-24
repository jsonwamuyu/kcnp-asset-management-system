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
        LoadAvailableAssets()
    End Sub

    ' Load all available assets (Assigned = False)
    Private Sub LoadAvailableAssets()
        Try
            Dim query As String = "SELECT AssetID, AssetName, Description, Location FROM Assets WHERE Assigned = False"
            Dim adapter As New OleDbDataAdapter(query, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            AvailableAssetsGrid.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Failed to load available assets: " & ex.Message)
        End Try
    End Sub

    ' Logout user and redirect to Login Page
    Private Sub btnLogoutStaff_Click(sender As Object, e As EventArgs) Handles btnLogoutStaff.Click
        Session.LoggedInUsername = ""
        Session.LoggedInRole = ""
        Session.LoggedInUserID = 0 ' Clear user ID session as well
        Me.Close()
        Dim login As New LoginForm()
        login.Show()
    End Sub

    ' Handle request asset button click
    Private Sub RequestAssetBtn_Click(sender As Object, e As EventArgs) Handles RequestAssetBtn.Click
        If AvailableAssetsGrid.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an asset to request.")
            Return
        End If

        ' Ensure valid user ID
        If Not IsNumeric(Session.LoggedInUserID) Then
            MessageBox.Show("Logged in user ID is missing or invalid.")
            Exit Sub
        End If

        Dim selectedAssetID As Integer = CInt(AvailableAssetsGrid.SelectedRows(0).Cells("AssetID").Value)

        Try
            conn.Open()

            ' Check if user has already requested this asset and it's still pending
            Dim checkCmd As New OleDbCommand("SELECT COUNT(*) FROM Assignments WHERE AssetID = ? AND UserID = ? AND Status = 'Pending'", conn)
            checkCmd.Parameters.AddWithValue("?", CInt(selectedAssetID))
            checkCmd.Parameters.AddWithValue("?", CInt(Session.LoggedInUserID))

            Dim count As Integer = CInt(checkCmd.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("You have already requested this asset and it is still pending.")
                Exit Sub
            End If

            ' Insert asset request into Assignments table
            Dim insertCmd As New OleDbCommand("INSERT INTO Assignments (UserID, AssetID, RequestDate, Status) VALUES (?, ?, ?, ?)", conn)
            insertCmd.Parameters.AddWithValue("?", CInt(Session.LoggedInUserID))
            insertCmd.Parameters.AddWithValue("?", CInt(selectedAssetID))
            insertCmd.Parameters.AddWithValue("?", CDate(DateTime.Now))
            insertCmd.Parameters.AddWithValue("?", "Pending")

            insertCmd.ExecuteNonQuery()
            MessageBox.Show("Asset request submitted successfully.")

        Catch ex As Exception
            MessageBox.Show("Error submitting request: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub
End Class
