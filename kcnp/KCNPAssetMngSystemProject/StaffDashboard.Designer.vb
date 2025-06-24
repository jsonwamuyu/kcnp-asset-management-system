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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StaffDashboardLabel = New System.Windows.Forms.Label()
        Me.RequestAssetBtn = New System.Windows.Forms.Button()
        Me.AvailableAssetsGrid = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.AvailableAssetsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcomeStaff
        '
        Me.lblWelcomeStaff.AutoSize = True
        Me.lblWelcomeStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeStaff.ForeColor = System.Drawing.Color.Green
        Me.lblWelcomeStaff.Location = New System.Drawing.Point(55, 81)
        Me.lblWelcomeStaff.Name = "lblWelcomeStaff"
        Me.lblWelcomeStaff.Size = New System.Drawing.Size(161, 16)
        Me.lblWelcomeStaff.TabIndex = 0
        Me.lblWelcomeStaff.Text = "Welcome, [Username]"
        '
        'btnLogoutStaff
        '
        Me.btnLogoutStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogoutStaff.ForeColor = System.Drawing.Color.BlueViolet
        Me.btnLogoutStaff.Location = New System.Drawing.Point(753, 10)
        Me.btnLogoutStaff.Name = "btnLogoutStaff"
        Me.btnLogoutStaff.Size = New System.Drawing.Size(87, 30)
        Me.btnLogoutStaff.TabIndex = 1
        Me.btnLogoutStaff.Text = "LOGOUT"
        Me.btnLogoutStaff.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.StaffDashboardLabel)
        Me.Panel1.Controls.Add(Me.RequestAssetBtn)
        Me.Panel1.Controls.Add(Me.AvailableAssetsGrid)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnLogoutStaff)
        Me.Panel1.Controls.Add(Me.lblWelcomeStaff)
        Me.Panel1.Location = New System.Drawing.Point(52, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(917, 477)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "You can select an asset and send a request to be assigned  to it."
        '
        'StaffDashboardLabel
        '
        Me.StaffDashboardLabel.AutoSize = True
        Me.StaffDashboardLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffDashboardLabel.Location = New System.Drawing.Point(54, 27)
        Me.StaffDashboardLabel.Name = "StaffDashboardLabel"
        Me.StaffDashboardLabel.Size = New System.Drawing.Size(182, 25)
        Me.StaffDashboardLabel.TabIndex = 5
        Me.StaffDashboardLabel.Text = "Staff Dashboard"
        '
        'RequestAssetBtn
        '
        Me.RequestAssetBtn.BackColor = System.Drawing.Color.BlueViolet
        Me.RequestAssetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RequestAssetBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequestAssetBtn.ForeColor = System.Drawing.Color.White
        Me.RequestAssetBtn.Location = New System.Drawing.Point(57, 397)
        Me.RequestAssetBtn.Name = "RequestAssetBtn"
        Me.RequestAssetBtn.Size = New System.Drawing.Size(194, 45)
        Me.RequestAssetBtn.TabIndex = 4
        Me.RequestAssetBtn.Text = "Request selected asset"
        Me.RequestAssetBtn.UseVisualStyleBackColor = False
        '
        'AvailableAssetsGrid
        '
        Me.AvailableAssetsGrid.AllowUserToAddRows = False
        Me.AvailableAssetsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AvailableAssetsGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AvailableAssetsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AvailableAssetsGrid.Location = New System.Drawing.Point(57, 171)
        Me.AvailableAssetsGrid.Name = "AvailableAssetsGrid"
        Me.AvailableAssetsGrid.ReadOnly = True
        Me.AvailableAssetsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AvailableAssetsGrid.Size = New System.Drawing.Size(783, 190)
        Me.AvailableAssetsGrid.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(322, 3)
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
        Me.ClientSize = New System.Drawing.Size(1012, 496)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "StaffDashboard"
        Me.Text = "StaffDashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AvailableAssetsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblWelcomeStaff As Label
    Friend WithEvents btnLogoutStaff As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AvailableAssetsGrid As DataGridView
    Friend WithEvents StaffDashboardLabel As Label
    Friend WithEvents RequestAssetBtn As Button
    Friend WithEvents Label1 As Label
End Class
