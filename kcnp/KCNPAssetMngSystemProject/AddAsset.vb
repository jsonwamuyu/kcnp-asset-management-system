Imports System.Data.OleDb

Public Class AddAsset

    Private Sub AddAsset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PurchaseDate.Value = DateTime.Now
    End Sub

    Private Sub BackAdminDashboard_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles BackAdminDashboard.LinkClicked
        Dim home As New AdminDashboard()
        home.Show()
        Me.Close()
    End Sub

    Private Sub AddAssetBtn_Click(sender As Object, e As EventArgs) Handles AddAssetBtn.Click
        If Session.LoggedInRole <> "Admin" Then
            MessageBox.Show("Unauthorized access. Only Admins can add assets.")
            Exit Sub
        End If

        If AssetNameInput.Text.Trim() = "" Or DescriptionInput.Text.Trim() = "" Or LocationInput.Text.Trim() = "" Then
            MessageBox.Show("Please fill in all required fields.")
            Exit Sub
        End If

        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=B:\KCNPAssetMngSystem\kcnp\KCNP_Assets.accdb"
        Dim conn As New OleDbConnection(connString)

        Try
            conn.Open()

            ' ✅ Include Assigned field (default to "No")
            Dim query As String = "INSERT INTO Assets (AssetName, Description, PurchaseDate, Location, Assigned) VALUES (?, ?, ?, ?, ?)"
            Dim cmd As New OleDbCommand(query, conn)

            cmd.Parameters.AddWithValue("AssetName", AssetNameInput.Text.Trim())
            cmd.Parameters.AddWithValue("Description", DescriptionInput.Text.Trim())
            cmd.Parameters.AddWithValue("PurchaseDate", PurchaseDate.Value)
            cmd.Parameters.AddWithValue("Location", LocationInput.Text.Trim())
            cmd.Parameters.AddWithValue("Assigned", False) ' New field added

            cmd.ExecuteNonQuery()
            MessageBox.Show("Asset added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear form
            AssetNameInput.Clear()
            DescriptionInput.Clear()
            LocationInput.Clear()
            PurchaseDate.Value = DateTime.Now

        Catch ex As Exception
            MessageBox.Show("Failed to add asset: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Optional
    Private Sub AssetNameInput_TextChanged(sender As Object, e As EventArgs) Handles AssetNameInput.TextChanged
    End Sub

    Private Sub LocationInput_TextChanged(sender As Object, e As EventArgs) Handles LocationInput.TextChanged
    End Sub

    Private Sub DescriptionInput_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub PurchaseDate_ValueChanged(sender As Object, e As EventArgs) Handles PurchaseDate.ValueChanged
    End Sub
End Class
