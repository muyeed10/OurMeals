<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FridgeForm
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
        Me.FridgeInventory = New System.Windows.Forms.DataGridView()
        Me.itemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemoveItem = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.EditItem = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.AddItemFrom = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.AddItem = New System.Windows.Forms.Button()
        Me.Backkk = New System.Windows.Forms.Button()
        Me.title = New System.Windows.Forms.Label()
        Me.Supplies = New System.Windows.Forms.DataGridView()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantitySupplies = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemoveSupply = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.EditSupply = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.AddSupFrom = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Supply = New System.Windows.Forms.Label()
        Me.AddSupply = New System.Windows.Forms.Button()
        Me.CreateListBtn = New System.Windows.Forms.Button()
        Me.FindSales = New System.Windows.Forms.Button()
        CType(Me.FridgeInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Supplies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FridgeInventory
        '
        Me.FridgeInventory.AllowUserToAddRows = False
        Me.FridgeInventory.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.FridgeInventory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FridgeInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FridgeInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.itemName, Me.Quantity, Me.RemoveItem, Me.EditItem, Me.AddItemFrom})
        Me.FridgeInventory.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.FridgeInventory.Location = New System.Drawing.Point(42, 162)
        Me.FridgeInventory.Margin = New System.Windows.Forms.Padding(2)
        Me.FridgeInventory.Name = "FridgeInventory"
        Me.FridgeInventory.RowHeadersWidth = 62
        Me.FridgeInventory.RowTemplate.Height = 33
        Me.FridgeInventory.Size = New System.Drawing.Size(852, 332)
        Me.FridgeInventory.TabIndex = 0
        '
        'itemName
        '
        Me.itemName.HeaderText = "Item Name"
        Me.itemName.MinimumWidth = 8
        Me.itemName.Name = "itemName"
        Me.itemName.Width = 200
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.MinimumWidth = 8
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Width = 200
        '
        'RemoveItem
        '
        Me.RemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RemoveItem.HeaderText = "Remove"
        Me.RemoveItem.MinimumWidth = 8
        Me.RemoveItem.Name = "RemoveItem"
        Me.RemoveItem.ReadOnly = True
        Me.RemoveItem.Text = "Remove Item"
        Me.RemoveItem.UseColumnTextForButtonValue = True
        Me.RemoveItem.Width = 200
        '
        'EditItem
        '
        Me.EditItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EditItem.HeaderText = "Edit"
        Me.EditItem.MinimumWidth = 8
        Me.EditItem.Name = "EditItem"
        Me.EditItem.ReadOnly = True
        Me.EditItem.Text = "Click Here To Edit"
        Me.EditItem.UseColumnTextForButtonValue = True
        Me.EditItem.Width = 200
        '
        'AddItemFrom
        '
        Me.AddItemFrom.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddItemFrom.HeaderText = "Add Item To An Exisiting List"
        Me.AddItemFrom.MinimumWidth = 8
        Me.AddItemFrom.Name = "AddItemFrom"
        Me.AddItemFrom.ReadOnly = True
        Me.AddItemFrom.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AddItemFrom.Text = "Click to Add"
        Me.AddItemFrom.UseColumnTextForButtonValue = True
        Me.AddItemFrom.Width = 200
        '
        'AddItem
        '
        Me.AddItem.Location = New System.Drawing.Point(42, 498)
        Me.AddItem.Margin = New System.Windows.Forms.Padding(2)
        Me.AddItem.Name = "AddItem"
        Me.AddItem.Size = New System.Drawing.Size(131, 46)
        Me.AddItem.TabIndex = 1
        Me.AddItem.Text = "Add Item "
        Me.AddItem.UseVisualStyleBackColor = True
        '
        'Backkk
        '
        Me.Backkk.Location = New System.Drawing.Point(42, 24)
        Me.Backkk.Margin = New System.Windows.Forms.Padding(2)
        Me.Backkk.Name = "Backkk"
        Me.Backkk.Size = New System.Drawing.Size(90, 27)
        Me.Backkk.TabIndex = 2
        Me.Backkk.Text = " << Back"
        Me.Backkk.UseVisualStyleBackColor = True
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Malgun Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.title.Location = New System.Drawing.Point(318, 113)
        Me.title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(305, 41)
        Me.title.TabIndex = 3
        Me.title.Text = "FRIDGE INVENTORY"
        '
        'Supplies
        '
        Me.Supplies.AllowUserToAddRows = False
        Me.Supplies.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.Supplies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Supplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Supplies.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.QuantitySupplies, Me.RemoveSupply, Me.EditSupply, Me.AddSupFrom})
        Me.Supplies.Location = New System.Drawing.Point(42, 601)
        Me.Supplies.Margin = New System.Windows.Forms.Padding(2)
        Me.Supplies.Name = "Supplies"
        Me.Supplies.RowHeadersWidth = 62
        Me.Supplies.RowTemplate.Height = 33
        Me.Supplies.Size = New System.Drawing.Size(852, 248)
        Me.Supplies.TabIndex = 4
        '
        'Item
        '
        Me.Item.HeaderText = "Item Name"
        Me.Item.MinimumWidth = 8
        Me.Item.Name = "Item"
        Me.Item.Width = 200
        '
        'QuantitySupplies
        '
        Me.QuantitySupplies.HeaderText = "Quantity"
        Me.QuantitySupplies.MinimumWidth = 8
        Me.QuantitySupplies.Name = "QuantitySupplies"
        Me.QuantitySupplies.Width = 200
        '
        'RemoveSupply
        '
        Me.RemoveSupply.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RemoveSupply.HeaderText = "Remove"
        Me.RemoveSupply.MinimumWidth = 8
        Me.RemoveSupply.Name = "RemoveSupply"
        Me.RemoveSupply.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RemoveSupply.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.RemoveSupply.Text = "Remove Item"
        Me.RemoveSupply.UseColumnTextForButtonValue = True
        Me.RemoveSupply.Width = 200
        '
        'EditSupply
        '
        Me.EditSupply.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EditSupply.HeaderText = "Edit"
        Me.EditSupply.MinimumWidth = 8
        Me.EditSupply.Name = "EditSupply"
        Me.EditSupply.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EditSupply.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.EditSupply.Text = "Click Here to Edit"
        Me.EditSupply.UseColumnTextForButtonValue = True
        Me.EditSupply.Width = 200
        '
        'AddSupFrom
        '
        Me.AddSupFrom.HeaderText = "Add Item To An Existing List"
        Me.AddSupFrom.MinimumWidth = 8
        Me.AddSupFrom.Name = "AddSupFrom"
        Me.AddSupFrom.ReadOnly = True
        Me.AddSupFrom.Text = "Click to Add"
        Me.AddSupFrom.UseColumnTextForButtonValue = True
        Me.AddSupFrom.Width = 200
        '
        'Supply
        '
        Me.Supply.AutoSize = True
        Me.Supply.Font = New System.Drawing.Font("Malgun Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Supply.Location = New System.Drawing.Point(318, 552)
        Me.Supply.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Supply.Name = "Supply"
        Me.Supply.Size = New System.Drawing.Size(308, 41)
        Me.Supply.TabIndex = 5
        Me.Supply.Text = "SUPPLY INVENTORY"
        '
        'AddSupply
        '
        Me.AddSupply.Location = New System.Drawing.Point(42, 853)
        Me.AddSupply.Margin = New System.Windows.Forms.Padding(2)
        Me.AddSupply.Name = "AddSupply"
        Me.AddSupply.Size = New System.Drawing.Size(131, 46)
        Me.AddSupply.TabIndex = 6
        Me.AddSupply.Text = "Add Item"
        Me.AddSupply.UseVisualStyleBackColor = True
        '
        'CreateListBtn
        '
        Me.CreateListBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CreateListBtn.Location = New System.Drawing.Point(533, 24)
        Me.CreateListBtn.Name = "CreateListBtn"
        Me.CreateListBtn.Size = New System.Drawing.Size(361, 64)
        Me.CreateListBtn.TabIndex = 7
        Me.CreateListBtn.Text = "Create List Based Off Of Missing Supplies"
        Me.CreateListBtn.UseVisualStyleBackColor = True
        '
        'FindSales
        '
        Me.FindSales.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FindSales.Location = New System.Drawing.Point(400, 24)
        Me.FindSales.Name = "FindSales"
        Me.FindSales.Size = New System.Drawing.Size(127, 64)
        Me.FindSales.TabIndex = 8
        Me.FindSales.Text = "Find Sales"
        Me.FindSales.UseVisualStyleBackColor = True
        '
        'FridgeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 935)
        Me.Controls.Add(Me.FindSales)
        Me.Controls.Add(Me.CreateListBtn)
        Me.Controls.Add(Me.AddSupply)
        Me.Controls.Add(Me.Supply)
        Me.Controls.Add(Me.Supplies)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.Backkk)
        Me.Controls.Add(Me.AddItem)
        Me.Controls.Add(Me.FridgeInventory)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FridgeForm"
        Me.Text = "Inventory"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.FridgeInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Supplies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FridgeInventory As DataGridView
    Friend WithEvents AddItem As Button
    Friend WithEvents Backkk As Button
    Friend WithEvents title As Label
    Friend WithEvents Supplies As DataGridView
    Friend WithEvents Supply As Label
    Friend WithEvents AddSupply As Button
    Friend WithEvents itemName As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents RemoveItem As DataGridViewButtonColumn
    Friend WithEvents EditItem As DataGridViewButtonColumn
    Friend WithEvents AddItemFrom As DataGridViewButtonColumn
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents QuantitySupplies As DataGridViewTextBoxColumn
    Friend WithEvents RemoveSupply As DataGridViewButtonColumn
    Friend WithEvents EditSupply As DataGridViewButtonColumn
    Friend WithEvents AddSupFrom As DataGridViewButtonColumn
    Friend WithEvents CreateListBtn As Button
    Friend WithEvents FindSales As Button
End Class
