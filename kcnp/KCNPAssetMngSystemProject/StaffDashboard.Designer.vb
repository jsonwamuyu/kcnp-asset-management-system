<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffDashboard))
        Me.lblWelcomeStaff = New System.Windows.Forms.Label()
        Me.btnLogoutStaff = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcomeStaff
        '
        Me.lblWelcomeStaff.AutoSize = True
        Me.lblWelcomeStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeStaff.ForeColor = System.Drawing.Color.Green
        Me.lblWelcomeStaff.Location = New System.Drawing.Point(65, 92)
        Me.lblWelcomeStaff.Name = "lblWelcomeStaff"
        Me.lblWelcomeStaff.Size = New System.Drawing.Size(148, 15)
        Me.lblWelcomeStaff.TabIndex = 0
        Me.lblWelcomeStaff.Text = "Welcome, [Username]"
        '
        'btnLogoutStaff
        '
        Me.btnLogoutStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogoutStaff.ForeColor = System.Drawing.Color.BlueViolet
        Me.btnLogoutStaff.Location = New System.Drawing.Point(599, 77)
        Me.btnLogoutStaff.Name = "btnLogoutStaff"
        Me.btnLogoutStaff.Size = New System.Drawing.Size(87, 30)
        Me.btnLogoutStaff.TabIndex = 1
        Me.btnLogoutStaff.Text = "LOGOUT"
        Me.btnLogoutStaff.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnLogoutStaff)
        Me.Panel1.Controls.Add(Me.lblWelcomeStaff)
        Me.Panel1.Location = New System.Drawing.Point(148, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(768, 392)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(233, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(304, 79)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'StaffDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(971, 496)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "StaffDashboard"
        Me.Text = "StaffDashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblWelcomeStaff As Label
    Friend WithEvents btnLogoutStaff As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
