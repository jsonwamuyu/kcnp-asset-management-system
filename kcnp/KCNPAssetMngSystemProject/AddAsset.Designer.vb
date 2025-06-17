<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAsset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddAsset))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DescriptionInput = New System.Windows.Forms.TextBox()
        Me.AddAssetHeader = New System.Windows.Forms.Label()
        Me.AssetNameLabel = New System.Windows.Forms.Label()
        Me.LocationLabel = New System.Windows.Forms.Label()
        Me.LocationInput = New System.Windows.Forms.TextBox()
        Me.AddAssetBtn = New System.Windows.Forms.Button()
        Me.AssetNameInput = New System.Windows.Forms.TextBox()
        Me.BackAdminDashboard = New System.Windows.Forms.LinkLabel()
        Me.PurchaseDateLabel = New System.Windows.Forms.Label()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.PurchaseDate = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(233, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(304, 79)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'DescriptionInput
        '
        Me.DescriptionInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionInput.Location = New System.Drawing.Point(60, 256)
        Me.DescriptionInput.MaximumSize = New System.Drawing.Size(300, 32)
        Me.DescriptionInput.MinimumSize = New System.Drawing.Size(300, 32)
        Me.DescriptionInput.Multiline = True
        Me.DescriptionInput.Name = "DescriptionInput"
        Me.DescriptionInput.Size = New System.Drawing.Size(300, 32)
        Me.DescriptionInput.TabIndex = 30
        '
        'AddAssetHeader
        '
        Me.AddAssetHeader.AutoSize = True
        Me.AddAssetHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddAssetHeader.Location = New System.Drawing.Point(55, 117)
        Me.AddAssetHeader.Name = "AddAssetHeader"
        Me.AddAssetHeader.Size = New System.Drawing.Size(160, 24)
        Me.AddAssetHeader.TabIndex = 20
        Me.AddAssetHeader.Text = "ADD AN ASSET"
        '
        'AssetNameLabel
        '
        Me.AssetNameLabel.AutoSize = True
        Me.AssetNameLabel.Location = New System.Drawing.Point(56, 170)
        Me.AssetNameLabel.Name = "AssetNameLabel"
        Me.AssetNameLabel.Size = New System.Drawing.Size(67, 13)
        Me.AssetNameLabel.TabIndex = 21
        Me.AssetNameLabel.Text = "Asset Name:"
        '
        'LocationLabel
        '
        Me.LocationLabel.AutoSize = True
        Me.LocationLabel.Location = New System.Drawing.Point(434, 242)
        Me.LocationLabel.Name = "LocationLabel"
        Me.LocationLabel.Size = New System.Drawing.Size(51, 13)
        Me.LocationLabel.TabIndex = 22
        Me.LocationLabel.Text = "Location:"
        '
        'LocationInput
        '
        Me.LocationInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationInput.Location = New System.Drawing.Point(437, 256)
        Me.LocationInput.MaximumSize = New System.Drawing.Size(300, 32)
        Me.LocationInput.MinimumSize = New System.Drawing.Size(300, 32)
        Me.LocationInput.Name = "LocationInput"
        Me.LocationInput.Size = New System.Drawing.Size(300, 26)
        Me.LocationInput.TabIndex = 23
        '
        'AddAssetBtn
        '
        Me.AddAssetBtn.BackColor = System.Drawing.Color.BlueViolet
        Me.AddAssetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddAssetBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddAssetBtn.ForeColor = System.Drawing.Color.White
        Me.AddAssetBtn.Location = New System.Drawing.Point(247, 365)
        Me.AddAssetBtn.Name = "AddAssetBtn"
        Me.AddAssetBtn.Size = New System.Drawing.Size(302, 30)
        Me.AddAssetBtn.TabIndex = 24
        Me.AddAssetBtn.Text = "ADD ASSET"
        Me.AddAssetBtn.UseVisualStyleBackColor = False
        '
        'AssetNameInput
        '
        Me.AssetNameInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AssetNameInput.Location = New System.Drawing.Point(59, 186)
        Me.AssetNameInput.MaximumSize = New System.Drawing.Size(300, 32)
        Me.AssetNameInput.MinimumSize = New System.Drawing.Size(300, 32)
        Me.AssetNameInput.Name = "AssetNameInput"
        Me.AssetNameInput.Size = New System.Drawing.Size(300, 26)
        Me.AssetNameInput.TabIndex = 25
        '
        'BackAdminDashboard
        '
        Me.BackAdminDashboard.AutoSize = True
        Me.BackAdminDashboard.LinkColor = System.Drawing.Color.Gray
        Me.BackAdminDashboard.Location = New System.Drawing.Point(56, 57)
        Me.BackAdminDashboard.Name = "BackAdminDashboard"
        Me.BackAdminDashboard.Size = New System.Drawing.Size(99, 13)
        Me.BackAdminDashboard.TabIndex = 26
        Me.BackAdminDashboard.TabStop = True
        Me.BackAdminDashboard.Text = "Back to Dashboard"
        '
        'PurchaseDateLabel
        '
        Me.PurchaseDateLabel.AutoSize = True
        Me.PurchaseDateLabel.Location = New System.Drawing.Point(434, 170)
        Me.PurchaseDateLabel.Name = "PurchaseDateLabel"
        Me.PurchaseDateLabel.Size = New System.Drawing.Size(81, 13)
        Me.PurchaseDateLabel.TabIndex = 27
        Me.PurchaseDateLabel.Text = "Purchase Date:"
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Location = New System.Drawing.Point(56, 242)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        Me.DescriptionLabel.TabIndex = 29
        Me.DescriptionLabel.Text = "Description:"
        '
        'PurchaseDate
        '
        Me.PurchaseDate.Location = New System.Drawing.Point(437, 190)
        Me.PurchaseDate.Name = "PurchaseDate"
        Me.PurchaseDate.Size = New System.Drawing.Size(300, 20)
        Me.PurchaseDate.TabIndex = 31
        '
        'AddAsset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PurchaseDate)
        Me.Controls.Add(Me.DescriptionInput)
        Me.Controls.Add(Me.DescriptionLabel)
        Me.Controls.Add(Me.PurchaseDateLabel)
        Me.Controls.Add(Me.BackAdminDashboard)
        Me.Controls.Add(Me.AssetNameInput)
        Me.Controls.Add(Me.AddAssetBtn)
        Me.Controls.Add(Me.LocationInput)
        Me.Controls.Add(Me.LocationLabel)
        Me.Controls.Add(Me.AssetNameLabel)
        Me.Controls.Add(Me.AddAssetHeader)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "AddAsset"
        Me.Text = "AddAsset"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DescriptionInput As TextBox
    Friend WithEvents AddAssetHeader As Label
    Friend WithEvents AssetNameLabel As Label
    Friend WithEvents LocationLabel As Label
    Friend WithEvents LocationInput As TextBox
    Friend WithEvents AddAssetBtn As Button
    Friend WithEvents AssetNameInput As TextBox
    Friend WithEvents BackAdminDashboard As LinkLabel
    Friend WithEvents PurchaseDateLabel As Label
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents PurchaseDate As DateTimePicker
End Class
