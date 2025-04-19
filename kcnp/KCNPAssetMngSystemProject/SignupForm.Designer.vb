<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignupForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignupForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.usernameInputSignup = New System.Windows.Forms.TextBox()
        Me.usernameLabelSignup = New System.Windows.Forms.Label()
        Me.passwordInputSignup = New System.Windows.Forms.TextBox()
        Me.passwordLabelSignup = New System.Windows.Forms.Label()
        Me.backHomeSignup = New System.Windows.Forms.LinkLabel()
        Me.fullnameInputSignup = New System.Windows.Forms.TextBox()
        Me.haveNoAccountLabel = New System.Windows.Forms.Label()
        Me.haveAnAccountLink = New System.Windows.Forms.LinkLabel()
        Me.btnSignupSubmit = New System.Windows.Forms.Button()
        Me.confirmPasswordInputSignup = New System.Windows.Forms.TextBox()
        Me.confirmPasswordLabelSignup = New System.Windows.Forms.Label()
        Me.fullnameLabelSignup = New System.Windows.Forms.Label()
        Me.signupHeader = New System.Windows.Forms.Label()
        Me.signupLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.signupLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.usernameInputSignup)
        Me.Panel1.Controls.Add(Me.usernameLabelSignup)
        Me.Panel1.Controls.Add(Me.passwordInputSignup)
        Me.Panel1.Controls.Add(Me.passwordLabelSignup)
        Me.Panel1.Controls.Add(Me.backHomeSignup)
        Me.Panel1.Controls.Add(Me.fullnameInputSignup)
        Me.Panel1.Controls.Add(Me.haveNoAccountLabel)
        Me.Panel1.Controls.Add(Me.haveAnAccountLink)
        Me.Panel1.Controls.Add(Me.btnSignupSubmit)
        Me.Panel1.Controls.Add(Me.confirmPasswordInputSignup)
        Me.Panel1.Controls.Add(Me.confirmPasswordLabelSignup)
        Me.Panel1.Controls.Add(Me.fullnameLabelSignup)
        Me.Panel1.Controls.Add(Me.signupHeader)
        Me.Panel1.Controls.Add(Me.signupLogo)
        Me.Panel1.Location = New System.Drawing.Point(72, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(657, 540)
        Me.Panel1.TabIndex = 1
        '
        'usernameInputSignup
        '
        Me.usernameInputSignup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameInputSignup.Location = New System.Drawing.Point(170, 261)
        Me.usernameInputSignup.MaximumSize = New System.Drawing.Size(300, 32)
        Me.usernameInputSignup.MinimumSize = New System.Drawing.Size(300, 32)
        Me.usernameInputSignup.Name = "usernameInputSignup"
        Me.usernameInputSignup.Size = New System.Drawing.Size(300, 26)
        Me.usernameInputSignup.TabIndex = 18
        '
        'usernameLabelSignup
        '
        Me.usernameLabelSignup.AutoSize = True
        Me.usernameLabelSignup.Location = New System.Drawing.Point(167, 245)
        Me.usernameLabelSignup.Name = "usernameLabelSignup"
        Me.usernameLabelSignup.Size = New System.Drawing.Size(58, 13)
        Me.usernameLabelSignup.TabIndex = 17
        Me.usernameLabelSignup.Text = "Username:"
        '
        'passwordInputSignup
        '
        Me.passwordInputSignup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordInputSignup.Location = New System.Drawing.Point(170, 322)
        Me.passwordInputSignup.MaximumSize = New System.Drawing.Size(300, 32)
        Me.passwordInputSignup.MinimumSize = New System.Drawing.Size(300, 32)
        Me.passwordInputSignup.Name = "passwordInputSignup"
        Me.passwordInputSignup.Size = New System.Drawing.Size(300, 26)
        Me.passwordInputSignup.TabIndex = 16
        Me.passwordInputSignup.UseSystemPasswordChar = True
        '
        'passwordLabelSignup
        '
        Me.passwordLabelSignup.AutoSize = True
        Me.passwordLabelSignup.Location = New System.Drawing.Point(167, 306)
        Me.passwordLabelSignup.Name = "passwordLabelSignup"
        Me.passwordLabelSignup.Size = New System.Drawing.Size(56, 13)
        Me.passwordLabelSignup.TabIndex = 15
        Me.passwordLabelSignup.Text = "Password:"
        '
        'backHomeSignup
        '
        Me.backHomeSignup.AutoSize = True
        Me.backHomeSignup.LinkColor = System.Drawing.Color.Gray
        Me.backHomeSignup.Location = New System.Drawing.Point(169, 99)
        Me.backHomeSignup.Name = "backHomeSignup"
        Me.backHomeSignup.Size = New System.Drawing.Size(63, 13)
        Me.backHomeSignup.TabIndex = 14
        Me.backHomeSignup.TabStop = True
        Me.backHomeSignup.Text = "Back Home"
        '
        'fullnameInputSignup
        '
        Me.fullnameInputSignup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullnameInputSignup.Location = New System.Drawing.Point(172, 206)
        Me.fullnameInputSignup.MaximumSize = New System.Drawing.Size(300, 32)
        Me.fullnameInputSignup.MinimumSize = New System.Drawing.Size(300, 32)
        Me.fullnameInputSignup.Name = "fullnameInputSignup"
        Me.fullnameInputSignup.Size = New System.Drawing.Size(300, 26)
        Me.fullnameInputSignup.TabIndex = 13
        '
        'haveNoAccountLabel
        '
        Me.haveNoAccountLabel.AutoSize = True
        Me.haveNoAccountLabel.Location = New System.Drawing.Point(227, 503)
        Me.haveNoAccountLabel.Name = "haveNoAccountLabel"
        Me.haveNoAccountLabel.Size = New System.Drawing.Size(132, 13)
        Me.haveNoAccountLabel.TabIndex = 12
        Me.haveNoAccountLabel.Text = "Already have an account?"
        '
        'haveAnAccountLink
        '
        Me.haveAnAccountLink.AutoSize = True
        Me.haveAnAccountLink.ForeColor = System.Drawing.Color.Green
        Me.haveAnAccountLink.LinkColor = System.Drawing.Color.Green
        Me.haveAnAccountLink.Location = New System.Drawing.Point(361, 503)
        Me.haveAnAccountLink.Name = "haveAnAccountLink"
        Me.haveAnAccountLink.Size = New System.Drawing.Size(33, 13)
        Me.haveAnAccountLink.TabIndex = 11
        Me.haveAnAccountLink.TabStop = True
        Me.haveAnAccountLink.Text = "Login"
        '
        'btnSignupSubmit
        '
        Me.btnSignupSubmit.BackColor = System.Drawing.Color.BlueViolet
        Me.btnSignupSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignupSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignupSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSignupSubmit.Location = New System.Drawing.Point(170, 437)
        Me.btnSignupSubmit.Name = "btnSignupSubmit"
        Me.btnSignupSubmit.Size = New System.Drawing.Size(302, 30)
        Me.btnSignupSubmit.TabIndex = 10
        Me.btnSignupSubmit.Text = "SIGNUP"
        Me.btnSignupSubmit.UseVisualStyleBackColor = False
        '
        'confirmPasswordInputSignup
        '
        Me.confirmPasswordInputSignup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmPasswordInputSignup.Location = New System.Drawing.Point(170, 383)
        Me.confirmPasswordInputSignup.MaximumSize = New System.Drawing.Size(300, 32)
        Me.confirmPasswordInputSignup.MinimumSize = New System.Drawing.Size(300, 32)
        Me.confirmPasswordInputSignup.Name = "confirmPasswordInputSignup"
        Me.confirmPasswordInputSignup.Size = New System.Drawing.Size(300, 26)
        Me.confirmPasswordInputSignup.TabIndex = 8
        Me.confirmPasswordInputSignup.UseSystemPasswordChar = True
        '
        'confirmPasswordLabelSignup
        '
        Me.confirmPasswordLabelSignup.AutoSize = True
        Me.confirmPasswordLabelSignup.Location = New System.Drawing.Point(167, 367)
        Me.confirmPasswordLabelSignup.Name = "confirmPasswordLabelSignup"
        Me.confirmPasswordLabelSignup.Size = New System.Drawing.Size(94, 13)
        Me.confirmPasswordLabelSignup.TabIndex = 7
        Me.confirmPasswordLabelSignup.Text = "Confirm Password:"
        '
        'fullnameLabelSignup
        '
        Me.fullnameLabelSignup.AutoSize = True
        Me.fullnameLabelSignup.Location = New System.Drawing.Point(169, 190)
        Me.fullnameLabelSignup.Name = "fullnameLabelSignup"
        Me.fullnameLabelSignup.Size = New System.Drawing.Size(52, 13)
        Me.fullnameLabelSignup.TabIndex = 4
        Me.fullnameLabelSignup.Text = "Fullname:"
        '
        'signupHeader
        '
        Me.signupHeader.AutoSize = True
        Me.signupHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signupHeader.Location = New System.Drawing.Point(168, 143)
        Me.signupHeader.Name = "signupHeader"
        Me.signupHeader.Size = New System.Drawing.Size(85, 24)
        Me.signupHeader.TabIndex = 3
        Me.signupHeader.Text = "SIGNUP"
        '
        'signupLogo
        '
        Me.signupLogo.BackgroundImage = CType(resources.GetObject("signupLogo.BackgroundImage"), System.Drawing.Image)
        Me.signupLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.signupLogo.Location = New System.Drawing.Point(172, 0)
        Me.signupLogo.Name = "signupLogo"
        Me.signupLogo.Size = New System.Drawing.Size(300, 79)
        Me.signupLogo.TabIndex = 2
        Me.signupLogo.TabStop = False
        '
        'SignupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(912, 555)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SignupForm"
        Me.Text = "SignupForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.signupLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents backHomeSignup As LinkLabel
    Friend WithEvents fullnameInputSignup As TextBox
    Friend WithEvents haveNoAccountLabel As Label
    Friend WithEvents haveAnAccountLink As LinkLabel
    Friend WithEvents btnSignupSubmit As Button
    Friend WithEvents confirmPasswordInputSignup As TextBox
    Friend WithEvents confirmPasswordLabelSignup As Label
    Friend WithEvents fullnameLabelSignup As Label
    Friend WithEvents signupHeader As Label
    Friend WithEvents signupLogo As PictureBox
    Friend WithEvents passwordInputSignup As TextBox
    Friend WithEvents passwordLabelSignup As Label
    Friend WithEvents usernameInputSignup As TextBox
    Friend WithEvents usernameLabelSignup As Label
End Class
