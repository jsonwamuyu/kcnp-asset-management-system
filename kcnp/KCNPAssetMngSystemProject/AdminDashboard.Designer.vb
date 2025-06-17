<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.labelCreateAsset = New System.Windows.Forms.Label()
        Me.lblWelcomeStaff = New System.Windows.Forms.Label()
        Me.btnLogoutStaff = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.BlueViolet
        Me.Button3.Location = New System.Drawing.Point(411, 104)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(145, 25)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Manage Assets Requests"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.BlueViolet
        Me.Button2.Location = New System.Drawing.Point(220, 105)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 24)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Manage Users"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.BlueViolet
        Me.Button1.Location = New System.Drawing.Point(24, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 24)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Add an Asset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'labelCreateAsset
        '
        Me.labelCreateAsset.AutoSize = True
        Me.labelCreateAsset.Location = New System.Drawing.Point(29, 105)
        Me.labelCreateAsset.Name = "labelCreateAsset"
        Me.labelCreateAsset.Size = New System.Drawing.Size(0, 13)
        Me.labelCreateAsset.TabIndex = 8
        '
        'lblWelcomeStaff
        '
        Me.lblWelcomeStaff.AutoSize = True
        Me.lblWelcomeStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeStaff.ForeColor = System.Drawing.Color.Green
        Me.lblWelcomeStaff.Location = New System.Drawing.Point(23, 66)
        Me.lblWelcomeStaff.Name = "lblWelcomeStaff"
        Me.lblWelcomeStaff.Size = New System.Drawing.Size(148, 15)
        Me.lblWelcomeStaff.TabIndex = 14
        Me.lblWelcomeStaff.Text = "Welcome, [Username]"
        '
        'btnLogoutStaff
        '
        Me.btnLogoutStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogoutStaff.ForeColor = System.Drawing.Color.BlueViolet
        Me.btnLogoutStaff.Location = New System.Drawing.Point(637, 105)
        Me.btnLogoutStaff.Name = "btnLogoutStaff"
        Me.btnLogoutStaff.Size = New System.Drawing.Size(99, 24)
        Me.btnLogoutStaff.TabIndex = 15
        Me.btnLogoutStaff.Text = "LOGOUT"
        Me.btnLogoutStaff.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(265, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(304, 79)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 25)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "LIST OF ASSETS"
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLogoutStaff)
        Me.Controls.Add(Me.lblWelcomeStaff)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.labelCreateAsset)
        Me.Name = "AdminDashboard"
        Me.Text = "AdminDashboard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents labelCreateAsset As Label
    Friend WithEvents lblWelcomeStaff As Label
    Friend WithEvents btnLogoutStaff As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
