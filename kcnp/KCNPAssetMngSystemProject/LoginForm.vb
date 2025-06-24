Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text

Public Class LoginForm
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=B:\KCNPAssetMngSystem\kcnp\KCNP_Assets.accdb")

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub backHomeLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles backHomeLogin.LinkClicked
        Dim home As New Form1()
        home.Show()
        Me.Hide()
    End Sub

    Private Sub signupLinkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles signupLinkLogin.LinkClicked
        Dim signup As New SignupForm()
        signup.Show()
        Me.Hide()
    End Sub

    ' 🔐 Hash password for secure comparison
    Private Function HashPassword(password As String) As String
        Dim sha As SHA256 = SHA256.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
        Dim hash As Byte() = sha.ComputeHash(bytes)
        Return BitConverter.ToString(hash).Replace("-", "").ToLower()
    End Function

    ' 🔑 Login button logic
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLoginSubmit.Click
        If usernameInputLogin.Text = "" Or passwordInputLogin.Text = "" Then
            MessageBox.Show("Please enter both username and password.")
            Exit Sub
        End If

        Dim hashedPassword As String = HashPassword(passwordInputLogin.Text)

        Try
            conn.Open()

            ' 🔍 Query for UserID and Role
            Dim cmd As New OleDbCommand("SELECT UserID, Role FROM Users WHERE Username = ? AND UserPassword = ?", conn)
            cmd.Parameters.Add(New OleDbParameter With {
    .OleDbType = OleDbType.VarWChar,
    .Value = usernameInputLogin.Text.Trim()
})
            cmd.Parameters.Add(New OleDbParameter With {
    .OleDbType = OleDbType.VarWChar,
    .Value = hashedPassword
})


            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' ✅ Store session info
                Session.LoggedInUsername = usernameInputLogin.Text
                Session.LoggedInRole = reader("Role").ToString()
                Session.LoggedInUserID = CInt(reader("UserID"))

                ' ✅ Redirect to appropriate dashboard
                Select Case Session.LoggedInRole
                    Case "Admin"
                        Dim adminDash As New AdminDashboard()
                        adminDash.Show()
                    Case "Staff"
                        Dim staffDash As New StaffDashboard()
                        staffDash.Show()
                    Case "Maintenance"
                        Dim maintDash As New MaintenanceDashboard()
                        maintDash.Show()
                    Case Else
                        MessageBox.Show("Unknown role. Please contact administrator.")
                        Exit Sub
                End Select

                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
