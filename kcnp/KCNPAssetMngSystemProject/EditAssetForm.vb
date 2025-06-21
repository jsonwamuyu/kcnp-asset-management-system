Imports System.Data.OleDb

Public Class EditAssetForm
    Private assetID As Integer

    Public Sub New(id As Integer)
        InitializeComponent()
        assetID = id
    End Sub

    Private Sub EditAssetForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=B:\KCNPAssetMngSystem\kcnp\KCNP_Assets.accdb"
        Using conn As New OleDbConnection(connString)
            Try
                conn.Open()
                Dim cmd As New OleDbCommand("SELECT * FROM Assets WHERE AssetID = ?", conn)
                cmd.Parameters.AddWithValue("@AssetID", assetID)

                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    AssetNameInput.Text = reader("AssetName").ToString()
                    DescriptionInput.Text = reader("Description").ToString()
                    PurchaseDateTimePicker.Value = Convert.ToDateTime(reader("PurchaseDate"))
                    LocationInput.Text = reader("Location").ToString()
                End If
            Catch ex As Exception
                MessageBox.Show("Error loading asset data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles SaveChangesBtn.Click
        If AssetNameInput.Text.Trim() = "" Or DescriptionInput.Text.Trim() = "" Or LocationInput.Text.Trim() = "" Then
            MessageBox.Show("All fields are required.")
            Return
        End If

        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=B:\KCNPAssetMngSystem\kcnp\KCNP_Assets.accdb"
        Using conn As New OleDbConnection(connString)
            Try
                conn.Open()
                Dim cmd As New OleDbCommand("UPDATE Assets SET AssetName = ?, Description = ?, PurchaseDate = ?, Location = ? WHERE AssetID = ?", conn)

                cmd.Parameters.AddWithValue("@AssetName", AssetNameInput.Text.Trim())
                cmd.Parameters.AddWithValue("@Description", DescriptionInput.Text.Trim())
                cmd.Parameters.AddWithValue("@PurchaseDate", PurchaseDateTimePicker.Value)
                cmd.Parameters.AddWithValue("@Location", LocationInput.Text.Trim())
                cmd.Parameters.AddWithValue("@AssetID", assetID)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Asset updated successfully.")
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Error updating asset: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles EditAssetCancelBtn.Click
        Me.Close()
    End Sub
End Class
