<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditAssetForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditAssetForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelAssetName = New System.Windows.Forms.Label()
        Me.EditAssetHeader = New System.Windows.Forms.Label()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.DescriptionInput = New System.Windows.Forms.TextBox()
        Me.LocationLabel = New System.Windows.Forms.Label()
        Me.PurchaseDateLabel = New System.Windows.Forms.Label()
        Me.PurchaseDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SaveChangesBtn = New System.Windows.Forms.Button()
        Me.EditAssetCancelBtn = New System.Windows.Forms.Button()
        Me.AssetNameInput = New System.Windows.Forms.TextBox()
        Me.LocationInput = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(361, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(304, 79)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'LabelAssetName
        '
        Me.LabelAssetName.AutoSize = True
        Me.LabelAssetName.Location = New System.Drawing.Point(175, 176)
        Me.LabelAssetName.Name = "LabelAssetName"
        Me.LabelAssetName.Size = New System.Drawing.Size(64, 13)
        Me.LabelAssetName.TabIndex = 18
        Me.LabelAssetName.Text = "Asset Name"
        '
        'EditAssetHeader
        '
        Me.EditAssetHeader.AutoSize = True
        Me.EditAssetHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditAssetHeader.Location = New System.Drawing.Point(173, 118)
        Me.EditAssetHeader.Name = "EditAssetHeader"
        Me.EditAssetHeader.Size = New System.Drawing.Size(245, 25)
        Me.EditAssetHeader.TabIndex = 20
        Me.EditAssetHeader.Text = "EDIT ASSET DETAILS"
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Location = New System.Drawing.Point(179, 260)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(60, 13)
        Me.DescriptionLabel.TabIndex = 21
        Me.DescriptionLabel.Text = "Description"
        '
        'DescriptionInput
        '
        Me.DescriptionInput.Location = New System.Drawing.Point(176, 284)
        Me.DescriptionInput.Multiline = True
        Me.DescriptionInput.Name = "DescriptionInput"
        Me.DescriptionInput.Size = New System.Drawing.Size(302, 55)
        Me.DescriptionInput.TabIndex = 22
        '
        'LocationLabel
        '
        Me.LocationLabel.AutoSize = True
        Me.LocationLabel.Location = New System.Drawing.Point(576, 176)
        Me.LocationLabel.Name = "LocationLabel"
        Me.LocationLabel.Size = New System.Drawing.Size(48, 13)
        Me.LocationLabel.TabIndex = 24
        Me.LocationLabel.Text = "Location"
        '
        'PurchaseDateLabel
        '
        Me.PurchaseDateLabel.AutoSize = True
        Me.PurchaseDateLabel.Location = New System.Drawing.Point(576, 260)
        Me.PurchaseDateLabel.Name = "PurchaseDateLabel"
        Me.PurchaseDateLabel.Size = New System.Drawing.Size(78, 13)
        Me.PurchaseDateLabel.TabIndex = 25
        Me.PurchaseDateLabel.Text = "Purchase Date"
        '
        'PurchaseDateTimePicker
        '
        Me.PurchaseDateTimePicker.Location = New System.Drawing.Point(579, 284)
        Me.PurchaseDateTimePicker.Name = "PurchaseDateTimePicker"
        Me.PurchaseDateTimePicker.Size = New System.Drawing.Size(300, 20)
        Me.PurchaseDateTimePicker.TabIndex = 26
        '
        'SaveChangesBtn
        '
        Me.SaveChangesBtn.BackColor = System.Drawing.Color.BlueViolet
        Me.SaveChangesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveChangesBtn.ForeColor = System.Drawing.Color.White
        Me.SaveChangesBtn.Location = New System.Drawing.Point(178, 386)
        Me.SaveChangesBtn.Name = "SaveChangesBtn"
        Me.SaveChangesBtn.Size = New System.Drawing.Size(300, 35)
        Me.SaveChangesBtn.TabIndex = 27
        Me.SaveChangesBtn.Text = "SAVE CHANGES"
        Me.SaveChangesBtn.UseVisualStyleBackColor = False
        '
        'EditAssetCancelBtn
        '
        Me.EditAssetCancelBtn.BackColor = System.Drawing.Color.BlueViolet
        Me.EditAssetCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditAssetCancelBtn.ForeColor = System.Drawing.Color.White
        Me.EditAssetCancelBtn.Location = New System.Drawing.Point(579, 386)
        Me.EditAssetCancelBtn.Name = "EditAssetCancelBtn"
        Me.EditAssetCancelBtn.Size = New System.Drawing.Size(300, 35)
        Me.EditAssetCancelBtn.TabIndex = 28
        Me.EditAssetCancelBtn.Text = "CANCEL"
        Me.EditAssetCancelBtn.UseVisualStyleBackColor = False
        '
        'AssetNameInput
        '
        Me.AssetNameInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AssetNameInput.Location = New System.Drawing.Point(178, 197)
        Me.AssetNameInput.MaximumSize = New System.Drawing.Size(300, 32)
        Me.AssetNameInput.MinimumSize = New System.Drawing.Size(300, 32)
        Me.AssetNameInput.Name = "AssetNameInput"
        Me.AssetNameInput.Size = New System.Drawing.Size(300, 32)
        Me.AssetNameInput.TabIndex = 29
        '
        'LocationInput
        '
        Me.LocationInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationInput.Location = New System.Drawing.Point(579, 197)
        Me.LocationInput.MaximumSize = New System.Drawing.Size(300, 32)
        Me.LocationInput.MinimumSize = New System.Drawing.Size(300, 32)
        Me.LocationInput.Name = "LocationInput"
        Me.LocationInput.Size = New System.Drawing.Size(300, 32)
        Me.LocationInput.TabIndex = 30
        '
        'EditAssetForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 503)
        Me.Controls.Add(Me.LocationInput)
        Me.Controls.Add(Me.AssetNameInput)
        Me.Controls.Add(Me.EditAssetCancelBtn)
        Me.Controls.Add(Me.SaveChangesBtn)
        Me.Controls.Add(Me.PurchaseDateTimePicker)
        Me.Controls.Add(Me.PurchaseDateLabel)
        Me.Controls.Add(Me.LocationLabel)
        Me.Controls.Add(Me.DescriptionInput)
        Me.Controls.Add(Me.DescriptionLabel)
        Me.Controls.Add(Me.EditAssetHeader)
        Me.Controls.Add(Me.LabelAssetName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "EditAssetForm"
        Me.Text = "EditAssetForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelAssetName As Label
    Friend WithEvents EditAssetHeader As Label
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents DescriptionInput As TextBox
    Friend WithEvents LocationLabel As Label
    Friend WithEvents PurchaseDateLabel As Label
    Friend WithEvents PurchaseDateTimePicker As DateTimePicker
    Friend WithEvents SaveChangesBtn As Button
    Friend WithEvents EditAssetCancelBtn As Button
    Friend WithEvents AssetNameInput As TextBox
    Friend WithEvents LocationInput As TextBox
End Class
