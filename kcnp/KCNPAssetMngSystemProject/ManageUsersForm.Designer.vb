<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageUsersForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageUsersForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UsersGrid = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(388, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(304, 79)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 25)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Manage Users"
        '
        'UsersGrid
        '
        Me.UsersGrid.BackgroundColor = System.Drawing.Color.White
        Me.UsersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsersGrid.Location = New System.Drawing.Point(73, 148)
        Me.UsersGrid.Name = "UsersGrid"
        Me.UsersGrid.Size = New System.Drawing.Size(824, 250)
        Me.UsersGrid.TabIndex = 21
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.BlueViolet
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(73, 450)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(188, 36)
        Me.btnRefresh.TabIndex = 22
        Me.btnRefresh.Text = "RELOAD USERS"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.BackColor = System.Drawing.Color.BlueViolet
        Me.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveChanges.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveChanges.ForeColor = System.Drawing.Color.White
        Me.btnSaveChanges.Location = New System.Drawing.Point(709, 450)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(188, 36)
        Me.btnSaveChanges.TabIndex = 23
        Me.btnSaveChanges.Text = "SAVE ROLE CHANGES"
        Me.btnSaveChanges.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnClose.Location = New System.Drawing.Point(786, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(111, 38)
        Me.btnClose.TabIndex = 24
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'ManageUsersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 498)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.UsersGrid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ManageUsersForm"
        Me.Text = "ManageUsersForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents UsersGrid As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents btnClose As Button
End Class
