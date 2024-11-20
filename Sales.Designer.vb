<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Iten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalePrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegularPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StoreName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StoreAdress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleEndDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentHouseholdQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Iten, Me.SalePrice, Me.RegularPrice, Me.StoreName, Me.StoreAdress, Me.SaleEndDate, Me.CurrentHouseholdQuantity})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 65)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(936, 395)
        Me.DataGridView1.TabIndex = 0
        '
        'Iten
        '
        Me.Iten.HeaderText = "Item"
        Me.Iten.MinimumWidth = 6
        Me.Iten.Name = "Iten"
        Me.Iten.ReadOnly = True
        Me.Iten.Width = 125
        '
        'SalePrice
        '
        Me.SalePrice.HeaderText = "Sale Price"
        Me.SalePrice.MinimumWidth = 6
        Me.SalePrice.Name = "SalePrice"
        Me.SalePrice.ReadOnly = True
        Me.SalePrice.Width = 125
        '
        'RegularPrice
        '
        Me.RegularPrice.HeaderText = "Regular Price"
        Me.RegularPrice.MinimumWidth = 6
        Me.RegularPrice.Name = "RegularPrice"
        Me.RegularPrice.ReadOnly = True
        Me.RegularPrice.Width = 125
        '
        'StoreName
        '
        Me.StoreName.HeaderText = "Store Name"
        Me.StoreName.MinimumWidth = 6
        Me.StoreName.Name = "StoreName"
        Me.StoreName.ReadOnly = True
        Me.StoreName.Width = 125
        '
        'StoreAdress
        '
        Me.StoreAdress.HeaderText = "Store Adress"
        Me.StoreAdress.MinimumWidth = 6
        Me.StoreAdress.Name = "StoreAdress"
        Me.StoreAdress.ReadOnly = True
        Me.StoreAdress.Width = 125
        '
        'SaleEndDate
        '
        Me.SaleEndDate.HeaderText = "Sale End Date"
        Me.SaleEndDate.MinimumWidth = 6
        Me.SaleEndDate.Name = "SaleEndDate"
        Me.SaleEndDate.ReadOnly = True
        Me.SaleEndDate.Width = 125
        '
        'CurrentHouseholdQuantity
        '
        Me.CurrentHouseholdQuantity.HeaderText = "Current Household Quantity"
        Me.CurrentHouseholdQuantity.MinimumWidth = 6
        Me.CurrentHouseholdQuantity.Name = "CurrentHouseholdQuantity"
        Me.CurrentHouseholdQuantity.ReadOnly = True
        Me.CurrentHouseholdQuantity.Width = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sales At Nearby Stores"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(741, 25)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(207, 24)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Only Include Missing Items"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 472)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Sales"
        Me.Text = "Sales"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Iten As DataGridViewTextBoxColumn
    Friend WithEvents SalePrice As DataGridViewTextBoxColumn
    Friend WithEvents RegularPrice As DataGridViewTextBoxColumn
    Friend WithEvents StoreName As DataGridViewTextBoxColumn
    Friend WithEvents StoreAdress As DataGridViewTextBoxColumn
    Friend WithEvents SaleEndDate As DataGridViewTextBoxColumn
    Friend WithEvents CurrentHouseholdQuantity As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
