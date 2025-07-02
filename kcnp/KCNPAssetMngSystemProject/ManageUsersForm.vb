Imports System.Data.OleDb

Public Class ManageUsersForm
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=B:\KCNPAssetMngSystem\kcnp\KCNP_Assets.accdb")

    Private Sub ManageUsersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        LoadUsers()
    End Sub

    Private Sub LoadUsers()
        Try
            conn.Open()

            Dim query As String = "SELECT UserID, Fullname, Username, Role FROM Users WHERE Username <> ?"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("?", Session.LoggedInUsername)

            Dim adapter As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            UsersGrid.Columns.Clear()
            UsersGrid.DataSource = dt

            ' Hide original Role column for internal binding use
            If UsersGrid.Columns.Contains("Role") Then
                UsersGrid.Columns("Role").Visible = False
            End If

            ' Add Role ComboBox column if not already added
            If Not UsersGrid.Columns.Contains("RoleCombo") Then
                Dim roleColumn As New DataGridViewComboBoxColumn()
                roleColumn.HeaderText = "Change Role"
                roleColumn.Name = "RoleCombo"
                roleColumn.DataPropertyName = "Role"
                roleColumn.Items.AddRange("Admin", "Staff")
                roleColumn.FlatStyle = FlatStyle.Flat
                UsersGrid.Columns.Add(roleColumn)
            End If

            ' Add Delete Button column if not already added
            If Not UsersGrid.Columns.Contains("Delete") Then
                Dim deleteBtn As New DataGridViewButtonColumn()
                deleteBtn.Name = "Delete"
                deleteBtn.Text = "Delete"
                deleteBtn.UseColumnTextForButtonValue = True
                deleteBtn.HeaderText = "Action"
                UsersGrid.Columns.Add(deleteBtn)
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to load users: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Delete or handle other button clicks in DataGridView
    Private Sub UsersGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsersGrid.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = UsersGrid.Columns("Delete").Index Then
            Dim userID As Integer = CInt(UsersGrid.Rows(e.RowIndex).Cells("UserID").Value)
            Dim username As String = UsersGrid.Rows(e.RowIndex).Cells("Username").Value.ToString()

            If MessageBox.Show($"Are you sure you want to delete user '{username}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Try
                    conn.Open()
                    Dim deleteCmd As New OleDbCommand("DELETE FROM Users WHERE UserID = ?", conn)
                    deleteCmd.Parameters.AddWithValue("?", userID)
                    deleteCmd.ExecuteNonQuery()
                    MessageBox.Show("User deleted successfully.")
                    LoadUsers()
                Catch ex As Exception
                    MessageBox.Show("Error deleting user: " & ex.Message)
                Finally
                    conn.Close()
                End Try
            End If
        End If
    End Sub

    ' Save role changes
    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        Try
            conn.Open()
            For Each row As DataGridViewRow In UsersGrid.Rows
                If row.IsNewRow Then Continue For

                Dim userID As Integer = CInt(row.Cells("UserID").Value)
                Dim newRole As String = row.Cells("RoleCombo").Value.ToString()

                Dim updateCmd As New OleDbCommand("UPDATE Users SET Role = ? WHERE UserID = ?", conn)
                updateCmd.Parameters.AddWithValue("?", newRole)
                updateCmd.Parameters.AddWithValue("?", userID)
                updateCmd.ExecuteNonQuery()
            Next

            MessageBox.Show("Roles updated successfully.")
        Catch ex As Exception
            MessageBox.Show("Error saving roles: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
            LoadUsers() '
        End Try
    End Sub

    ' Reload the grid manually
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadUsers()
    End Sub

    ' Close the form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
