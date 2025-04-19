Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text

Public Class SignupForm
    ' ✅ Database connection
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HomePC\Desktop\KCNPAssetManagementSystem\FinalYearKCNPASSETSMNGSYSTEM\KCNP_Assets.accdb")

    ' ✅ Form Load: Center window
    Private Sub SignupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    ' 🔙 Back to Home
    Private Sub backHomeSignup_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles backHomeSignup.LinkClicked
        Dim home As New Form1()
        home.Show()
        Me.Close()
    End Sub

    ' 🔁 Already have account? Go to Login
    Private Sub haveAnAccountLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles haveAnAccountLink.LinkClicked
        Dim login As New LoginForm()
        login.Show()
        Me.Hide()
    End Sub

    ' 🔐 Encrypt password using SHA256
    Private Function HashPassword(password As String) As String
        Using sha As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    ' 🚀 Signup Button Click
    Private Sub SignupButton_Click(sender As Object, e As EventArgs) Handles btnSignupSubmit.Click
        ' ✅ Validate input
        If fullnameInputSignup.Text = "" Or usernameInputSignup.Text = "" Or passwordInputSignup.Text = "" Or confirmPasswordInputSignup.Text = "" Then
            MessageBox.Show("All fields are required.")
            Exit Sub
        End If

        If passwordInputSignup.Text <> confirmPasswordInputSignup.Text Then
            MessageBox.Show("Passwords do not match.")
            Exit Sub
        End If

        Try
            conn.Open()

            ' 🔍 Check if username exists
            Using checkCmd As New OleDbCommand("SELECT COUNT(*) FROM Users WHERE Username = ?", conn)
                checkCmd.Parameters.AddWithValue("?", usernameInputSignup.Text)
                If CInt(checkCmd.ExecuteScalar()) > 0 Then
                    MessageBox.Show("Username already exists.")
                    Exit Sub
                End If
            End Using

            ' 🔐 Hash password
            Dim hashedPassword As String = HashPassword(passwordInputSignup.Text)

            ' 📝 Insert new user with role = Staff
            Using insertCmd As New OleDbCommand("INSERT INTO Users (FullName, Username, UserPassword, Role) VALUES (?, ?, ?, ?)", conn)
                insertCmd.Parameters.AddWithValue("?", fullnameInputSignup.Text)
                insertCmd.Parameters.AddWithValue("?", usernameInputSignup.Text)
                insertCmd.Parameters.AddWithValue("?", hashedPassword)
                insertCmd.Parameters.AddWithValue("?", "Staff") ' Role is fixed here
                insertCmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Account created successfully!")
            Me.Close()
            Dim loginForm As New LoginForm()
            loginForm.Show()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
