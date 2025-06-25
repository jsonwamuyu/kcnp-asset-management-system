Imports System.Data.OleDb

Public Class ManageAssetRequestsForm
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=B:\KCNPAssetMngSystem\kcnp\KCNP_Assets.accdb")

    Private Sub ManageRequestsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        LoadRequests()
    End Sub

    Private Sub LoadRequests()
        Try
            conn.Open()

            Dim query As String = "
                SELECT 
                    A.ID,
                    U.Fullname,
                    ASSET.AssetName,
                    A.RequestDate,
                    A.Status
                FROM 
                    (Assignments A 
                    INNER JOIN Users U ON A.UserID = U.UserID)
                    INNER JOIN Assets ASSET ON A.AssetID = ASSET.AssetID
                ORDER BY A.RequestDate DESC
            "

            Dim adapter As New OleDbDataAdapter(query, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            RequestsGrid.Columns.Clear()
            RequestsGrid.DataSource = dt

            ' Add Approve button
            Dim approveBtn As New DataGridViewButtonColumn()
            approveBtn.Name = "Approve"
            approveBtn.HeaderText = "Approve"
            approveBtn.Text = "Approve"
            approveBtn.UseColumnTextForButtonValue = True
            RequestsGrid.Columns.Add(approveBtn)

            ' Add Reject button
            Dim rejectBtn As New DataGridViewButtonColumn()
            rejectBtn.Name = "Reject"
            rejectBtn.HeaderText = "Reject"
            rejectBtn.Text = "Reject"
            rejectBtn.UseColumnTextForButtonValue = True
            RequestsGrid.Columns.Add(rejectBtn)

        Catch ex As Exception
            MessageBox.Show("Failed to load requests: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub RequestsGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles RequestsGrid.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        Dim requestID As Integer = CInt(RequestsGrid.Rows(e.RowIndex).Cells("ID").Value)
        Dim assetName As String = RequestsGrid.Rows(e.RowIndex).Cells("AssetName").Value.ToString()

        Dim action As String = RequestsGrid.Columns(e.ColumnIndex).Name

        Try
            conn.Open()

            If action = "Approve" Then
                ' Update status to Approved
                Dim updateAssignment As New OleDbCommand("UPDATE Assignments SET Status = 'Approved' WHERE ID = ?", conn)
                updateAssignment.Parameters.AddWithValue("?", requestID)
                updateAssignment.ExecuteNonQuery()

                ' Set the related asset's Assigned to True
                Dim getAssetIDCmd As New OleDbCommand("SELECT AssetID FROM Assignments WHERE ID = ?", conn)
                getAssetIDCmd.Parameters.AddWithValue("?", requestID)
                Dim assetID As Integer = CInt(getAssetIDCmd.ExecuteScalar())

                Dim updateAsset As New OleDbCommand("UPDATE Assets SET Assigned = True WHERE AssetID = ?", conn)
                updateAsset.Parameters.AddWithValue("?", assetID)
                updateAsset.ExecuteNonQuery()

                MessageBox.Show("Asset request approved.")
            ElseIf action = "Reject" Then
                Dim rejectCmd As New OleDbCommand("UPDATE Assignments SET Status = 'Rejected' WHERE ID = ?", conn)
                rejectCmd.Parameters.AddWithValue("?", requestID)
                rejectCmd.ExecuteNonQuery()
                MessageBox.Show("Asset request rejected.")
            End If

            LoadRequests()

        Catch ex As Exception
            MessageBox.Show("Error processing request: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
