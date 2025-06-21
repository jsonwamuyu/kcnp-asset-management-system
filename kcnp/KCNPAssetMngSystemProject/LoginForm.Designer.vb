<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.backHomeLogin = New System.Windows.Forms.LinkLabel()
        Me.usernameInputLogin = New System.Windows.Forms.TextBox()
        Me.haveNoAccountLabelLogin = New System.Windows.Forms.Label()
        Me.signupLinkLogin = New System.Windows.Forms.LinkLabel()
        Me.btnLoginSubmit = New System.Windows.Forms.Button()
        Me.forgotPasswordLink = New System.Windows.Forms.LinkLabel()
        Me.passwordInputLogin = New System.Windows.Forms.TextBox()
        Me.passwordLabelLogin = New System.Windows.Forms.Label()
        Me.usernameLabelLogin = New System.Windows.Forms.Label()
        Me.loginHeader = New System.Windows.Forms.Label()
        Me.loginLogo = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.loginLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.backHomeLogin)
        Me.Panel1.Controls.Add(Me.usernameInputLogin)
        Me.Panel1.Controls.Add(Me.haveNoAccountLabelLogin)
        Me.Panel1.Controls.Add(Me.signupLinkLogin)
        Me.Panel1.Controls.Add(Me.btnLoginSubmit)
        Me.Panel1.Controls.Add(Me.forgotPasswordLink)
        Me.Panel1.Controls.Add(Me.passwordInputLogin)
        Me.Panel1.Controls.Add(Me.passwordLabelLogin)
        Me.Panel1.Controls.Add(Me.usernameLabelLogin)
        Me.Panel1.Controls.Add(Me.loginHeader)
        Me.Panel1.Controls.Add(Me.loginLogo)
        Me.Panel1.Location = New System.Drawing.Point(74, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(819, 445)
        Me.Panel1.TabIndex = 0
        '
        'backHomeLogin
        '
        Me.backHomeLogin.AutoSize = True
        Me.backHomeLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backHomeLogin.ForeColor = System.Drawing.Color.Green
        Me.backHomeLogin.LinkColor = System.Drawing.Color.Gray
        Me.backHomeLogin.Location = New System.Drawing.Point(60, 20)
        Me.backHomeLogin.Name = "backHomeLogin"
        Me.backHomeLogin.Size = New System.Drawing.Size(101, 20)
        Me.backHomeLogin.TabIndex = 14
        Me.backHomeLogin.TabStop = True
        Me.backHomeLogin.Text = "Back Home"
        '
        'usernameInputLogin
        '
        Me.usernameInputLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameInputLogin.Location = New System.Drawing.Point(63, 234)
        Me.usernameInputLogin.MaximumSize = New System.Drawing.Size(300, 32)
        Me.usernameInputLogin.MinimumSize = New System.Drawing.Size(300, 32)
        Me.usernameInputLogin.Name = "usernameInputLogin"
        Me.usernameInputLogin.Size = New System.Drawing.Size(300, 32)
        Me.usernameInputLogin.TabIndex = 13
        '
        'haveNoAccountLabelLogin
        '
        Me.haveNoAccountLabelLogin.AutoSize = True
        Me.haveNoAccountLabelLogin.Location = New System.Drawing.Point(615, 331)
        Me.haveNoAccountLabelLogin.Name = "haveNoAccountLabelLogin"
        Me.haveNoAccountLabelLogin.Size = New System.Drawing.Size(96, 13)
        Me.haveNoAccountLabelLogin.TabIndex = 12
        Me.haveNoAccountLabelLogin.Text = "Have no account?"
        '
        'signupLinkLogin
        '
        Me.signupLinkLogin.AutoSize = True
        Me.signupLinkLogin.ForeColor = System.Drawing.Color.Green
        Me.signupLinkLogin.LinkColor = System.Drawing.Color.Green
        Me.signupLinkLogin.Location = New System.Drawing.Point(711, 331)
        Me.signupLinkLogin.Name = "signupLinkLogin"
        Me.signupLinkLogin.Size = New System.Drawing.Size(40, 13)
        Me.signupLinkLogin.TabIndex = 11
        Me.signupLinkLogin.TabStop = True
        Me.signupLinkLogin.Text = "Signup"
        '
        'btnLoginSubmit
        '
        Me.btnLoginSubmit.BackColor = System.Drawing.Color.BlueViolet
        Me.btnLoginSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoginSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginSubmit.ForeColor = System.Drawing.Color.White
        Me.btnLoginSubmit.Location = New System.Drawing.Point(63, 322)
        Me.btnLoginSubmit.Name = "btnLoginSubmit"
        Me.btnLoginSubmit.Size = New System.Drawing.Size(302, 30)
        Me.btnLoginSubmit.TabIndex = 10
        Me.btnLoginSubmit.Text = "LOGIN"
        Me.btnLoginSubmit.UseVisualStyleBackColor = False
        '
        'forgotPasswordLink
        '
        Me.forgotPasswordLink.AutoSize = True
        Me.forgotPasswordLink.ForeColor = System.Drawing.Color.Green
        Me.forgotPasswordLink.LinkColor = System.Drawing.Color.Green
        Me.forgotPasswordLink.Location = New System.Drawing.Point(454, 331)
        Me.forgotPasswordLink.Name = "forgotPasswordLink"
        Me.forgotPasswordLink.Size = New System.Drawing.Size(92, 13)
        Me.forgotPasswordLink.TabIndex = 9
        Me.forgotPasswordLink.TabStop = True
        Me.forgotPasswordLink.Text = "Forgot Password?"
        '
        'passwordInputLogin
        '
        Me.passwordInputLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordInputLogin.Location = New System.Drawing.Point(457, 234)
        Me.passwordInputLogin.MaximumSize = New System.Drawing.Size(300, 32)
        Me.passwordInputLogin.MinimumSize = New System.Drawing.Size(300, 32)
        Me.passwordInputLogin.Name = "passwordInputLogin"
        Me.passwordInputLogin.Size = New System.Drawing.Size(300, 32)
        Me.passwordInputLogin.TabIndex = 8
        Me.passwordInputLogin.UseSystemPasswordChar = True
        '
        'passwordLabelLogin
        '
        Me.passwordLabelLogin.AutoSize = True
        Me.passwordLabelLogin.Location = New System.Drawing.Point(454, 203)
        Me.passwordLabelLogin.Name = "passwordLabelLogin"
        Me.passwordLabelLogin.Size = New System.Drawing.Size(56, 13)
        Me.passwordLabelLogin.TabIndex = 7
        Me.passwordLabelLogin.Text = "Password:"
        '
        'usernameLabelLogin
        '
        Me.usernameLabelLogin.AutoSize = True
        Me.usernameLabelLogin.Location = New System.Drawing.Point(60, 203)
        Me.usernameLabelLogin.Name = "usernameLabelLogin"
        Me.usernameLabelLogin.Size = New System.Drawing.Size(58, 13)
        Me.usernameLabelLogin.TabIndex = 4
        Me.usernameLabelLogin.Text = "Username:"
        '
        'loginHeader
        '
        Me.loginHeader.AutoSize = True
        Me.loginHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginHeader.Location = New System.Drawing.Point(59, 126)
        Me.loginHeader.Name = "loginHeader"
        Me.loginHeader.Size = New System.Drawing.Size(81, 25)
        Me.loginHeader.TabIndex = 3
        Me.loginHeader.Text = "LOGIN"
        '
        'loginLogo
        '
        Me.loginLogo.BackgroundImage = CType(resources.GetObject("loginLogo.BackgroundImage"), System.Drawing.Image)
        Me.loginLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.loginLogo.Location = New System.Drawing.Point(457, 6)
        Me.loginLogo.Name = "loginLogo"
        Me.loginLogo.Size = New System.Drawing.Size(300, 79)
        Me.loginLogo.TabIndex = 2
        Me.loginLogo.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(970, 485)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "LoginForm"
        Me.Text = "LoginForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.loginLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents loginLogo As PictureBox
    Friend WithEvents loginHeader As Label
    Friend WithEvents usernameLabelLogin As Label
    Friend WithEvents forgotPasswordLink As LinkLabel
    Friend WithEvents passwordInputLogin As TextBox
    Friend WithEvents passwordLabelLogin As Label
    Friend WithEvents signupLinkLogin As LinkLabel
    Friend WithEvents btnLoginSubmit As Button
    Friend WithEvents haveNoAccountLabelLogin As Label
    Friend WithEvents backHomeLogin As LinkLabel
    Friend WithEvents usernameInputLogin As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
