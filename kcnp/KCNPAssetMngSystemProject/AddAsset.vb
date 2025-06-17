Imports System.Data.OleDb

Public Class AddAsset

    ' Set default date when form loads
    Private Sub AddAsset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PurchaseDate.Value = DateTime.Now
    End Sub

    ' Back link to Admin Dashboard
    Private Sub BackAdminDashboard_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles BackAdminDashboard.LinkClicked
        Dim home As New AdminDashboard()
        home.Show()
        Me.Close()
    End Sub

    ' Add asset to the database
    Private Sub AddAssetBtn_Click(sender As Object, e As EventArgs) Handles AddAssetBtn.Click
        ' Role check
        If Session.LoggedInRole <> "Admin" Then
            MessageBox.Show("Unauthorized access. Only Admins can add assets.")
            Exit Sub
        End If

        ' Input validation
        If AssetNameInput.Text.Trim() = "" Or DescriptionInput.Text.Trim() = "" Or LocationInput.Text.Trim() = "" Then
            MessageBox.Show("Please fill in all required fields.")
            Exit Sub
        End If

        ' Database connection
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=B:\KCNPAssetMngSystem\kcnp\KCNP_Assets.accdb"
        Dim conn As New OleDbConnection(connString)

        Try
            conn.Open()

            ' SQL insert statement with parameters
            Dim query As String = "INSERT INTO Assets (AssetName, Description, PurchaseDate, Location) VALUES (?, ?, ?, ?)"
            Dim cmd As New OleDbCommand(query, conn)

            ' Explicit parameters (order matters)
            cmd.Parameters.AddWithValue("AssetName", AssetNameInput.Text.Trim())
            cmd.Parameters.AddWithValue("Description", DescriptionInput.Text.Trim())
            cmd.Parameters.AddWithValue("PurchaseDate", PurchaseDate.Value)
            cmd.Parameters.AddWithValue("Location", LocationInput.Text.Trim())

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

    ' Optional field event handlers (can add validation feedback if needed)
    Private Sub AssetNameInput_TextChanged(sender As Object, e As EventArgs) Handles AssetNameInput.TextChanged
    End Sub

    Private Sub LocationInput_TextChanged(sender As Object, e As EventArgs) Handles LocationInput.TextChanged
    End Sub

    Private Sub DescriptionInput_TextChanged(sender As Object, e As EventArgs) Handles DescriptionInput.TextChanged
    End Sub

    Private Sub PurchaseDate_ValueChanged(sender As Object, e As EventArgs) Handles PurchaseDate.ValueChanged
    End Sub
End Class
