<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ShoppingListName = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ItemsCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchasedCheckbox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DeleteBut = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.EditBut = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.ChangeTitleBtn = New System.Windows.Forms.Button()
        Me.ChangeDescriptionBtn = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.SettingButton = New System.Windows.Forms.Button()
        Me.RecipesButton = New System.Windows.Forms.Button()
        Me.SuppliesButton = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.NotificationsButton = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FridgeButton = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ShoppingListName
        '
        Me.ShoppingListName.AutoSize = True
        Me.ShoppingListName.Font = New System.Drawing.Font("Segoe UI Semibold", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ShoppingListName.Location = New System.Drawing.Point(122, 20)
        Me.ShoppingListName.Name = "ShoppingListName"
        Me.ShoppingListName.Size = New System.Drawing.Size(289, 37)
        Me.ShoppingListName.TabIndex = 2
        Me.ShoppingListName.Text = "Placeholder List Name"
        Me.ShoppingListName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(14, 28)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "<< Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemsCol, Me.QuantityCol, Me.PurchasedCheckbox, Me.DeleteBut, Me.EditBut})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 74)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(790, 547)
        Me.DataGridView1.TabIndex = 21
        '
        'ItemsCol
        '
        Me.ItemsCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ItemsCol.HeaderText = "Items"
        Me.ItemsCol.MinimumWidth = 8
        Me.ItemsCol.Name = "ItemsCol"
        Me.ItemsCol.ReadOnly = True
        '
        'QuantityCol
        '
        Me.QuantityCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.QuantityCol.HeaderText = "Quantity"
        Me.QuantityCol.MinimumWidth = 8
        Me.QuantityCol.Name = "QuantityCol"
        Me.QuantityCol.ReadOnly = True
        '
        'PurchasedCheckbox
        '
        Me.PurchasedCheckbox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PurchasedCheckbox.HeaderText = "Purchased"
        Me.PurchasedCheckbox.MinimumWidth = 8
        Me.PurchasedCheckbox.Name = "PurchasedCheckbox"
        Me.PurchasedCheckbox.ReadOnly = True
        '
        'DeleteBut
        '
        Me.DeleteBut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DeleteBut.DefaultCellStyle = DataGridViewCellStyle1
        Me.DeleteBut.HeaderText = "Remove"
        Me.DeleteBut.MinimumWidth = 8
        Me.DeleteBut.Name = "DeleteBut"
        Me.DeleteBut.ReadOnly = True
        Me.DeleteBut.Text = "Remove Item"
        '
        'EditBut
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.EditBut.DefaultCellStyle = DataGridViewCellStyle2
        Me.EditBut.HeaderText = "Edit"
        Me.EditBut.MinimumWidth = 8
        Me.EditBut.Name = "EditBut"
        Me.EditBut.ReadOnly = True
        Me.EditBut.Text = "Edit Item"
        Me.EditBut.Width = 150
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(14, 626)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(131, 46)
        Me.AddButton.TabIndex = 22
        Me.AddButton.Text = "Add Item"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'ChangeTitleBtn
        '
        Me.ChangeTitleBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ChangeTitleBtn.Location = New System.Drawing.Point(531, 28)
        Me.ChangeTitleBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.ChangeTitleBtn.Name = "ChangeTitleBtn"
        Me.ChangeTitleBtn.Size = New System.Drawing.Size(112, 29)
        Me.ChangeTitleBtn.TabIndex = 23
        Me.ChangeTitleBtn.Text = "Change Title"
        Me.ChangeTitleBtn.UseVisualStyleBackColor = True
        '
        'ChangeDescriptionBtn
        '
        Me.ChangeDescriptionBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ChangeDescriptionBtn.Location = New System.Drawing.Point(647, 28)
        Me.ChangeDescriptionBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.ChangeDescriptionBtn.Name = "ChangeDescriptionBtn"
        Me.ChangeDescriptionBtn.Size = New System.Drawing.Size(155, 29)
        Me.ChangeDescriptionBtn.TabIndex = 24
        Me.ChangeDescriptionBtn.Text = "Change Description"
        Me.ChangeDescriptionBtn.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.SettingButton)
        Me.GroupBox4.Controls.Add(Me.RecipesButton)
        Me.GroupBox4.Controls.Add(Me.SuppliesButton)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.NotificationsButton)
        Me.GroupBox4.Controls.Add(Me.HomeButton)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.FridgeButton)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(88, 677)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(614, 138)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        '
        'SettingButton
        '
        Me.SettingButton.BackgroundImage = Global.OurMeals.My.Resources.Resources.settings
        Me.SettingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SettingButton.Location = New System.Drawing.Point(529, 31)
        Me.SettingButton.Name = "SettingButton"
        Me.SettingButton.Size = New System.Drawing.Size(63, 66)
        Me.SettingButton.TabIndex = 18
        Me.SettingButton.UseVisualStyleBackColor = True
        '
        'RecipesButton
        '
        Me.RecipesButton.BackgroundImage = Global.OurMeals.My.Resources.Resources.recipe
        Me.RecipesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RecipesButton.Location = New System.Drawing.Point(428, 31)
        Me.RecipesButton.Name = "RecipesButton"
        Me.RecipesButton.Size = New System.Drawing.Size(63, 66)
        Me.RecipesButton.TabIndex = 15
        Me.RecipesButton.UseVisualStyleBackColor = True
        '
        'SuppliesButton
        '
        Me.SuppliesButton.BackgroundImage = Global.OurMeals.My.Resources.Resources.supplies
        Me.SuppliesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SuppliesButton.Location = New System.Drawing.Point(322, 31)
        Me.SuppliesButton.Name = "SuppliesButton"
        Me.SuppliesButton.Size = New System.Drawing.Size(63, 66)
        Me.SuppliesButton.TabIndex = 14
        Me.SuppliesButton.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.OurMeals.My.Resources.Resources.fridge
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(221, 31)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(63, 66)
        Me.Button3.TabIndex = 13
        Me.Button3.UseVisualStyleBackColor = True
        '
        'NotificationsButton
        '
        Me.NotificationsButton.BackgroundImage = Global.OurMeals.My.Resources.Resources.notificationbell
        Me.NotificationsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NotificationsButton.Location = New System.Drawing.Point(120, 31)
        Me.NotificationsButton.Name = "NotificationsButton"
        Me.NotificationsButton.Size = New System.Drawing.Size(63, 66)
        Me.NotificationsButton.TabIndex = 12
        Me.NotificationsButton.UseVisualStyleBackColor = True
        '
        'HomeButton
        '
        Me.HomeButton.BackgroundImage = Global.OurMeals.My.Resources.Resources.home
        Me.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HomeButton.Location = New System.Drawing.Point(19, 31)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(63, 66)
        Me.HomeButton.TabIndex = 11
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(517, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 28)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Settings"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(403, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 28)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Recipes"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(303, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 28)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Supplies"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FridgeButton
        '
        Me.FridgeButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FridgeButton.Location = New System.Drawing.Point(202, 100)
        Me.FridgeButton.Name = "FridgeButton"
        Me.FridgeButton.Size = New System.Drawing.Size(95, 28)
        Me.FridgeButton.TabIndex = 14
        Me.FridgeButton.Text = "Fridge"
        Me.FridgeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(108, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 28)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Notifications"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(0, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 28)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Home"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 817)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ChangeDescriptionBtn)
        Me.Controls.Add(Me.ChangeTitleBtn)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ShoppingListName)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ShoppingListName As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AddButton As Button
    Friend WithEvents ItemsCol As DataGridViewTextBoxColumn
    Friend WithEvents QuantityCol As DataGridViewTextBoxColumn
    Friend WithEvents PurchasedCheckbox As DataGridViewCheckBoxColumn
    Friend WithEvents DeleteBut As DataGridViewButtonColumn
    Friend WithEvents EditBut As DataGridViewButtonColumn
    Friend WithEvents ChangeTitleBtn As Button
    Friend WithEvents ChangeDescriptionBtn As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents SettingButton As Button
    Friend WithEvents RecipesButton As Button
    Friend WithEvents SuppliesButton As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents NotificationsButton As Button
    Friend WithEvents HomeButton As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents FridgeButton As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
