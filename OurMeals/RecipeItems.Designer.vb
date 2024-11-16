<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecipeItems
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
        Me.BackButton = New System.Windows.Forms.Button()
        Me.RecipeNameLabel = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddItem = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BackButton.Location = New System.Drawing.Point(11, 11)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(92, 37)
        Me.BackButton.TabIndex = 8
        Me.BackButton.Text = "<< Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'RecipeNameLabel
        '
        Me.RecipeNameLabel.AutoSize = True
        Me.RecipeNameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RecipeNameLabel.Location = New System.Drawing.Point(166, 11)
        Me.RecipeNameLabel.Name = "RecipeNameLabel"
        Me.RecipeNameLabel.Size = New System.Drawing.Size(289, 37)
        Me.RecipeNameLabel.TabIndex = 7
        Me.RecipeNameLabel.Text = "Placeholder List Name"
        Me.RecipeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.Quantity, Me.AddItem})
        Me.DataGridView1.Location = New System.Drawing.Point(11, 64)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(507, 374)
        Me.DataGridView1.TabIndex = 9
        '
        'Item
        '
        Me.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Item.HeaderText = "Item"
        Me.Item.MinimumWidth = 6
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.MinimumWidth = 6
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'AddItem
        '
        Me.AddItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AddItem.HeaderText = "Add Item To An Existing List"
        Me.AddItem.MinimumWidth = 6
        Me.AddItem.Name = "AddItem"
        Me.AddItem.ReadOnly = True
        '
        'RecipeItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.RecipeNameLabel)
        Me.Name = "RecipeItems"
        Me.Text = "RecipeItems"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents RecipeNameLabel As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents AddItem As DataGridViewButtonColumn
End Class
