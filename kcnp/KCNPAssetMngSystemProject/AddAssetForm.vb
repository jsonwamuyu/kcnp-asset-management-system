'Imports System.Data.OleDb

'Public Class AddAssetForm
'    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=B:\KCNPAssetMngSystem\kcnp\KCNP_ASSETS.accdb")

'    Private Sub AddAssetForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        ' Pre-fill dropdowns
'        cmbCondition.Items.AddRange(New String() {"New", "Good", "Needs Repair"})
'        cmbStatus.Items.AddRange(New String() {"Available", "Assigned", "Maintenance"})

'        ' Load user IDs to assign (optional)
'        Try
'            conn.Open()
'            Dim cmd As New OleDbCommand("SELECT UserID FROM tblUsers", conn)
'            Dim reader As OleDbDataReader = cmd.ExecuteReader()
'            While reader.Read()
'                cmbUserID.Items.Add(reader("UserID").ToString())
'            End While
'            conn.Close()
'        Catch ex As Exception
'            MessageBox.Show("Error loading users: " & ex.Message)
'        End Try
'    End Sub

'    Private Sub btnAddAsset_Click(sender As Object, e As EventArgs) Handles btnAddAsset.Click
'        ' Validate inputs (basic example)
'        If txtAssetName.Text = "" Or txtCategory.Text = "" Or txtPrice.Text = "" Then
'            MessageBox.Show("Please fill in all required fields.")
'            Exit Sub
'        End If

'        Try
'            conn.Open()
'            Dim cmd As New OleDbCommand("INSERT INTO Assets (AssetName, Description, UserID, Category, PurchaseDate, Price, Condition, Location, Status) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)", conn)
'            cmd.Parameters.AddWithValue("@AssetName", txtAssetName.Text)
'            cmd.Parameters.AddWithValue("@Description", txtDescription.Text)
'            If cmbUserID.Text <> "" Then
'                cmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(cmbUserID.Text))
'            Else
'                cmd.Parameters.AddWithValue("@UserID", DBNull.Value) ' Optional field
'            End If
'            cmd.Parameters.AddWithValue("@Category", txtCategory.Text)
'            cmd.Parameters.AddWithValue("@PurchaseDate", dtpPurchaseDate.Value)
'            cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text))
'            cmd.Parameters.AddWithValue("@Condition", cmbCondition.Text)
'            cmd.Parameters.AddWithValue("@Location", txtLocation.Text)
'            cmd.Parameters.AddWithValue("@Status", cmbStatus.Text)

'            cmd.ExecuteNonQuery()
'            conn.Close()

'            MessageBox.Show("Asset added successfully.")
'            Me.Close()
'        Catch ex As Exception
'            MessageBox.Show("Failed to add asset: " & ex.Message)
'        Finally
'            If conn.State = ConnectionState.Open Then conn.Close()
'        End Try
'    End Sub
'End Class
