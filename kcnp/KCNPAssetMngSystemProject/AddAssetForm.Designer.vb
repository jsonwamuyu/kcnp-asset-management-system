<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAssetForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddAssetForm))
        Me.addAssetLogo = New System.Windows.Forms.PictureBox()
        Me.addAssetHeader = New System.Windows.Forms.Label()
        Me.addAssetInputAddAsset = New System.Windows.Forms.TextBox()
        Me.assetNameLabelAddAsset = New System.Windows.Forms.Label()
        Me.descriptionInputAddAsset = New System.Windows.Forms.TextBox()
        Me.descriptionLabelAddAsset = New System.Windows.Forms.Label()
        Me.assignedLabelAddAsset = New System.Windows.Forms.Label()
        Me.assigneeComboAddAsset = New System.Windows.Forms.ComboBox()
        Me.KCNPAssetsDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KCNP_AssetsDataSet = New KCNPAssetMngSystemProject.KCNP_AssetsDataSet()
        Me.catogoryLabelAddAsset = New System.Windows.Forms.Label()
        Me.categoryInputAddAsset = New System.Windows.Forms.TextBox()
        Me.purchasedLabelAddAsset = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.conditionLabelAddAsset = New System.Windows.Forms.Label()
        Me.conditionComboAddAsset = New System.Windows.Forms.ComboBox()
        Me.locationLabelAddAsset = New System.Windows.Forms.Label()
        Me.locationInputAddAsset = New System.Windows.Forms.TextBox()
        Me.addAssetButton = New System.Windows.Forms.Button()
        Me.statusLabelAddAsset = New System.Windows.Forms.Label()
        Me.statusComboAddAsset = New System.Windows.Forms.ComboBox()
        CType(Me.addAssetLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KCNPAssetsDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KCNP_AssetsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'addAssetLogo
        '
        Me.addAssetLogo.BackgroundImage = CType(resources.GetObject("addAssetLogo.BackgroundImage"), System.Drawing.Image)
        Me.addAssetLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.addAssetLogo.Location = New System.Drawing.Point(266, 2)
        Me.addAssetLogo.Name = "addAssetLogo"
        Me.addAssetLogo.Size = New System.Drawing.Size(300, 79)
        Me.addAssetLogo.TabIndex = 3
        Me.addAssetLogo.TabStop = False
        '
        'addAssetHeader
        '
        Me.addAssetHeader.AutoSize = True
        Me.addAssetHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addAssetHeader.Location = New System.Drawing.Point(85, 121)
        Me.addAssetHeader.Name = "addAssetHeader"
        Me.addAssetHeader.Size = New System.Drawing.Size(160, 24)
        Me.addAssetHeader.TabIndex = 4
        Me.addAssetHeader.Text = "ADD AN ASSET"
        '
        'addAssetInputAddAsset
        '
        Me.addAssetInputAddAsset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addAssetInputAddAsset.Location = New System.Drawing.Point(88, 185)
        Me.addAssetInputAddAsset.MaximumSize = New System.Drawing.Size(300, 32)
        Me.addAssetInputAddAsset.MinimumSize = New System.Drawing.Size(300, 32)
        Me.addAssetInputAddAsset.Multiline = True
        Me.addAssetInputAddAsset.Name = "addAssetInputAddAsset"
        Me.addAssetInputAddAsset.Size = New System.Drawing.Size(300, 32)
        Me.addAssetInputAddAsset.TabIndex = 15
        '
        'assetNameLabelAddAsset
        '
        Me.assetNameLabelAddAsset.AutoSize = True
        Me.assetNameLabelAddAsset.Location = New System.Drawing.Point(86, 169)
        Me.assetNameLabelAddAsset.Name = "assetNameLabelAddAsset"
        Me.assetNameLabelAddAsset.Size = New System.Drawing.Size(67, 13)
        Me.assetNameLabelAddAsset.TabIndex = 14
        Me.assetNameLabelAddAsset.Text = "Asset Name:"
        '
        'descriptionInputAddAsset
        '
        Me.descriptionInputAddAsset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptionInputAddAsset.Location = New System.Drawing.Point(89, 252)
        Me.descriptionInputAddAsset.MaximumSize = New System.Drawing.Size(300, 32)
        Me.descriptionInputAddAsset.MinimumSize = New System.Drawing.Size(300, 32)
        Me.descriptionInputAddAsset.Multiline = True
        Me.descriptionInputAddAsset.Name = "descriptionInputAddAsset"
        Me.descriptionInputAddAsset.Size = New System.Drawing.Size(300, 32)
        Me.descriptionInputAddAsset.TabIndex = 17
        '
        'descriptionLabelAddAsset
        '
        Me.descriptionLabelAddAsset.AutoSize = True
        Me.descriptionLabelAddAsset.Location = New System.Drawing.Point(87, 235)
        Me.descriptionLabelAddAsset.Name = "descriptionLabelAddAsset"
        Me.descriptionLabelAddAsset.Size = New System.Drawing.Size(63, 13)
        Me.descriptionLabelAddAsset.TabIndex = 16
        Me.descriptionLabelAddAsset.Text = "Description:"
        '
        'assignedLabelAddAsset
        '
        Me.assignedLabelAddAsset.AutoSize = True
        Me.assignedLabelAddAsset.Location = New System.Drawing.Point(448, 318)
        Me.assignedLabelAddAsset.Name = "assignedLabelAddAsset"
        Me.assignedLabelAddAsset.Size = New System.Drawing.Size(65, 13)
        Me.assignedLabelAddAsset.TabIndex = 18
        Me.assignedLabelAddAsset.Text = "Assigned to:"
        '
        'assigneeComboAddAsset
        '
        Me.assigneeComboAddAsset.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.assigneeComboAddAsset.DataSource = Me.KCNPAssetsDataSetBindingSource
        Me.assigneeComboAddAsset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.assigneeComboAddAsset.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.assigneeComboAddAsset.FormattingEnabled = True
        Me.assigneeComboAddAsset.ItemHeight = 13
        Me.assigneeComboAddAsset.Location = New System.Drawing.Point(448, 333)
        Me.assigneeComboAddAsset.MaximumSize = New System.Drawing.Size(300, 0)
        Me.assigneeComboAddAsset.MinimumSize = New System.Drawing.Size(300, 0)
        Me.assigneeComboAddAsset.Name = "assigneeComboAddAsset"
        Me.assigneeComboAddAsset.Size = New System.Drawing.Size(300, 21)
        Me.assigneeComboAddAsset.TabIndex = 19
        '
        'KCNPAssetsDataSetBindingSource
        '
        Me.KCNPAssetsDataSetBindingSource.DataSource = Me.KCNP_AssetsDataSet
        Me.KCNPAssetsDataSetBindingSource.Position = 0
        '
        'KCNP_AssetsDataSet
        '
        Me.KCNP_AssetsDataSet.DataSetName = "KCNP_AssetsDataSet"
        Me.KCNP_AssetsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'catogoryLabelAddAsset
        '
        Me.catogoryLabelAddAsset.AutoSize = True
        Me.catogoryLabelAddAsset.Location = New System.Drawing.Point(90, 370)
        Me.catogoryLabelAddAsset.Name = "catogoryLabelAddAsset"
        Me.catogoryLabelAddAsset.Size = New System.Drawing.Size(52, 13)
        Me.catogoryLabelAddAsset.TabIndex = 20
        Me.catogoryLabelAddAsset.Text = "Catogory:"
        '
        'categoryInputAddAsset
        '
        Me.categoryInputAddAsset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoryInputAddAsset.Location = New System.Drawing.Point(89, 385)
        Me.categoryInputAddAsset.MaximumSize = New System.Drawing.Size(300, 32)
        Me.categoryInputAddAsset.MinimumSize = New System.Drawing.Size(300, 32)
        Me.categoryInputAddAsset.Multiline = True
        Me.categoryInputAddAsset.Name = "categoryInputAddAsset"
        Me.categoryInputAddAsset.Size = New System.Drawing.Size(300, 32)
        Me.categoryInputAddAsset.TabIndex = 21
        '
        'purchasedLabelAddAsset
        '
        Me.purchasedLabelAddAsset.AutoSize = True
        Me.purchasedLabelAddAsset.Location = New System.Drawing.Point(445, 169)
        Me.purchasedLabelAddAsset.Name = "purchasedLabelAddAsset"
        Me.purchasedLabelAddAsset.Size = New System.Drawing.Size(85, 13)
        Me.purchasedLabelAddAsset.TabIndex = 22
        Me.purchasedLabelAddAsset.Text = "Purchased date:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(448, 187)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(300, 20)
        Me.DateTimePicker2.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Price:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(89, 316)
        Me.TextBox1.MaximumSize = New System.Drawing.Size(300, 32)
        Me.TextBox1.MinimumSize = New System.Drawing.Size(300, 32)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(300, 32)
        Me.TextBox1.TabIndex = 26
        '
        'conditionLabelAddAsset
        '
        Me.conditionLabelAddAsset.AutoSize = True
        Me.conditionLabelAddAsset.Location = New System.Drawing.Point(445, 272)
        Me.conditionLabelAddAsset.Name = "conditionLabelAddAsset"
        Me.conditionLabelAddAsset.Size = New System.Drawing.Size(54, 13)
        Me.conditionLabelAddAsset.TabIndex = 27
        Me.conditionLabelAddAsset.Text = "Condition:"
        '
        'conditionComboAddAsset
        '
        Me.conditionComboAddAsset.FormattingEnabled = True
        Me.conditionComboAddAsset.Items.AddRange(New Object() {"New", "Good", "Repair"})
        Me.conditionComboAddAsset.Location = New System.Drawing.Point(448, 287)
        Me.conditionComboAddAsset.Name = "conditionComboAddAsset"
        Me.conditionComboAddAsset.Size = New System.Drawing.Size(300, 21)
        Me.conditionComboAddAsset.TabIndex = 28
        '
        'locationLabelAddAsset
        '
        Me.locationLabelAddAsset.AutoSize = True
        Me.locationLabelAddAsset.Location = New System.Drawing.Point(445, 369)
        Me.locationLabelAddAsset.Name = "locationLabelAddAsset"
        Me.locationLabelAddAsset.Size = New System.Drawing.Size(51, 13)
        Me.locationLabelAddAsset.TabIndex = 29
        Me.locationLabelAddAsset.Text = "Location:"
        '
        'locationInputAddAsset
        '
        Me.locationInputAddAsset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.locationInputAddAsset.Location = New System.Drawing.Point(448, 385)
        Me.locationInputAddAsset.MaximumSize = New System.Drawing.Size(300, 32)
        Me.locationInputAddAsset.MinimumSize = New System.Drawing.Size(300, 32)
        Me.locationInputAddAsset.Name = "locationInputAddAsset"
        Me.locationInputAddAsset.Size = New System.Drawing.Size(300, 32)
        Me.locationInputAddAsset.TabIndex = 30
        '
        'addAssetButton
        '
        Me.addAssetButton.BackColor = System.Drawing.Color.BlueViolet
        Me.addAssetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addAssetButton.ForeColor = System.Drawing.Color.White
        Me.addAssetButton.Location = New System.Drawing.Point(88, 452)
        Me.addAssetButton.Name = "addAssetButton"
        Me.addAssetButton.Size = New System.Drawing.Size(300, 36)
        Me.addAssetButton.TabIndex = 32
        Me.addAssetButton.Text = "Add Asset"
        Me.addAssetButton.UseVisualStyleBackColor = False
        '
        'statusLabelAddAsset
        '
        Me.statusLabelAddAsset.AutoSize = True
        Me.statusLabelAddAsset.Location = New System.Drawing.Point(447, 221)
        Me.statusLabelAddAsset.Name = "statusLabelAddAsset"
        Me.statusLabelAddAsset.Size = New System.Drawing.Size(40, 13)
        Me.statusLabelAddAsset.TabIndex = 33
        Me.statusLabelAddAsset.Text = "Status:"
        '
        'statusComboAddAsset
        '
        Me.statusComboAddAsset.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.statusComboAddAsset.FormattingEnabled = True
        Me.statusComboAddAsset.Items.AddRange(New Object() {"Available", "Assigned", "Maintenance"})
        Me.statusComboAddAsset.Location = New System.Drawing.Point(448, 236)
        Me.statusComboAddAsset.Name = "statusComboAddAsset"
        Me.statusComboAddAsset.Size = New System.Drawing.Size(300, 21)
        Me.statusComboAddAsset.TabIndex = 34
        '
        'AddAssetForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 515)
        Me.Controls.Add(Me.statusComboAddAsset)
        Me.Controls.Add(Me.statusLabelAddAsset)
        Me.Controls.Add(Me.addAssetButton)
        Me.Controls.Add(Me.locationInputAddAsset)
        Me.Controls.Add(Me.locationLabelAddAsset)
        Me.Controls.Add(Me.conditionComboAddAsset)
        Me.Controls.Add(Me.conditionLabelAddAsset)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.purchasedLabelAddAsset)
        Me.Controls.Add(Me.categoryInputAddAsset)
        Me.Controls.Add(Me.catogoryLabelAddAsset)
        Me.Controls.Add(Me.assigneeComboAddAsset)
        Me.Controls.Add(Me.assignedLabelAddAsset)
        Me.Controls.Add(Me.descriptionInputAddAsset)
        Me.Controls.Add(Me.descriptionLabelAddAsset)
        Me.Controls.Add(Me.addAssetInputAddAsset)
        Me.Controls.Add(Me.assetNameLabelAddAsset)
        Me.Controls.Add(Me.addAssetHeader)
        Me.Controls.Add(Me.addAssetLogo)
        Me.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Name = "AddAssetForm"
        Me.Text = "AddAssetForm"
        CType(Me.addAssetLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KCNPAssetsDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KCNP_AssetsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents addAssetLogo As PictureBox
    Friend WithEvents addAssetHeader As Label
    Friend WithEvents addAssetInputAddAsset As TextBox
    Friend WithEvents assetNameLabelAddAsset As Label
    Friend WithEvents descriptionInputAddAsset As TextBox
    Friend WithEvents descriptionLabelAddAsset As Label
    Friend WithEvents assignedLabelAddAsset As Label
    Friend WithEvents assigneeComboAddAsset As ComboBox
    Friend WithEvents catogoryLabelAddAsset As Label
    Friend WithEvents categoryInputAddAsset As TextBox
    Friend WithEvents purchasedLabelAddAsset As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents KCNPAssetsDataSetBindingSource As BindingSource
    Friend WithEvents KCNP_AssetsDataSet As KCNP_AssetsDataSet
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents conditionLabelAddAsset As Label
    Friend WithEvents conditionComboAddAsset As ComboBox
    Friend WithEvents locationLabelAddAsset As Label
    Friend WithEvents locationInputAddAsset As TextBox
    Friend WithEvents addAssetButton As Button
    Friend WithEvents statusLabelAddAsset As Label
    Friend WithEvents statusComboAddAsset As ComboBox
End Class
