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

    Private Sub RequestAssetBtn_Click(sender As Object, e As EventArgs) Handles RequestAssetBtn.Click
        If AvailableAssetsGrid.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an asset to request.")
            Return
        End If

        ' Validate logged in user ID
        If Not IsNumeric(Session.LoggedInUserID) OrElse Session.LoggedInUserID <= 0 Then
            MessageBox.Show("Invalid user session.")
            Return
        End If

        Dim selectedAssetID As Integer = CInt(AvailableAssetsGrid.SelectedRows(0).Cells("AssetID").Value)

        Try
            conn.Open()

            ' Ensure the parameter order matches the query EXACTLY
            Dim checkQuery As String = "SELECT COUNT(*) FROM Assignments WHERE AssetID = ? AND UserID = ? AND Status = ?"
            Dim checkCmd As New OleDbCommand(checkQuery, conn)
            checkCmd.Parameters.Add(New OleDbParameter With {.OleDbType = OleDbType.Integer, .Value = selectedAssetID})
            checkCmd.Parameters.Add(New OleDbParameter With {.OleDbType = OleDbType.Integer, .Value = Session.LoggedInUserID})
            checkCmd.Parameters.Add(New OleDbParameter With {.OleDbType = OleDbType.VarChar, .Value = "Pending"})

            Dim count As Integer = CInt(checkCmd.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("You have already requested this asset and it is still pending.")
                Return
            End If

            ' Insert asset request
            Dim insertQuery As String = "INSERT INTO Assignments (UserID, AssetID, RequestDate, Status) VALUES (?, ?, ?, ?)"
            Dim insertCmd As New OleDbCommand(insertQuery, conn)
            insertCmd.Parameters.Add(New OleDbParameter With {.OleDbType = OleDbType.Integer, .Value = Session.LoggedInUserID})
            insertCmd.Parameters.Add(New OleDbParameter With {.OleDbType = OleDbType.Integer, .Value = selectedAssetID})
            insertCmd.Parameters.Add(New OleDbParameter With {.OleDbType = OleDbType.Date, .Value = DateTime.Now})
            insertCmd.Parameters.Add(New OleDbParameter With {.OleDbType = OleDbType.VarChar, .Value = "Pending"})

            insertCmd.ExecuteNonQuery()
            MessageBox.Show("Asset request submitted successfully.")
        Catch ex As Exception
            MessageBox.Show("Error submitting request: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub


End Class
