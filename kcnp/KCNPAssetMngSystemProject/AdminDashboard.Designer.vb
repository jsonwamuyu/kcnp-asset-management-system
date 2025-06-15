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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.labelCreateAsset = New System.Windows.Forms.Label()
        Me.lblWelcomeStaff = New System.Windows.Forms.Label()
        Me.btnLogoutStaff = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.BlueViolet
        Me.Button3.Location = New System.Drawing.Point(555, 239)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 35)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Manage Assets Requests"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(574, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Click to manage requests"
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.BlueViolet
        Me.Button2.Location = New System.Drawing.Point(322, 239)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 35)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Manage Users"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(341, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Click to manage users"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.BlueViolet
        Me.Button1.Location = New System.Drawing.Point(83, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 35)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Add an Asset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'labelCreateAsset
        '
        Me.labelCreateAsset.AutoSize = True
        Me.labelCreateAsset.Location = New System.Drawing.Point(102, 223)
        Me.labelCreateAsset.Name = "labelCreateAsset"
        Me.labelCreateAsset.Size = New System.Drawing.Size(106, 13)
        Me.labelCreateAsset.TabIndex = 8
        Me.labelCreateAsset.Text = "Click to add an asset"
        '
        'lblWelcomeStaff
        '
        Me.lblWelcomeStaff.AutoSize = True
        Me.lblWelcomeStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeStaff.ForeColor = System.Drawing.Color.Green
        Me.lblWelcomeStaff.Location = New System.Drawing.Point(80, 38)
        Me.lblWelcomeStaff.Name = "lblWelcomeStaff"
        Me.lblWelcomeStaff.Size = New System.Drawing.Size(148, 15)
        Me.lblWelcomeStaff.TabIndex = 14
        Me.lblWelcomeStaff.Text = "Welcome, [Username]"
        '
        'btnLogoutStaff
        '
        Me.btnLogoutStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogoutStaff.ForeColor = System.Drawing.Color.BlueViolet
        Me.btnLogoutStaff.Location = New System.Drawing.Point(613, 31)
        Me.btnLogoutStaff.Name = "btnLogoutStaff"
        Me.btnLogoutStaff.Size = New System.Drawing.Size(87, 30)
        Me.btnLogoutStaff.TabIndex = 15
        Me.btnLogoutStaff.Text = "LOGOUT"
        Me.btnLogoutStaff.UseVisualStyleBackColor = True
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLogoutStaff)
        Me.Controls.Add(Me.lblWelcomeStaff)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.labelCreateAsset)
        Me.Name = "AdminDashboard"
        Me.Text = "AdminDashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents labelCreateAsset As Label
    Friend WithEvents lblWelcomeStaff As Label
    Friend WithEvents btnLogoutStaff As Button
End Class
