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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        ShoppingListName = New Label()
        Button1 = New Button()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        DataGridView1 = New DataGridView()
        AddButton = New Button()
        ItemsCol = New DataGridViewTextBoxColumn()
        QuantityCol = New DataGridViewTextBoxColumn()
        PurchasedCheckbox = New DataGridViewCheckBoxColumn()
        DeleteBut = New DataGridViewButtonColumn()
        EditBut = New DataGridViewButtonColumn()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ShoppingListName
        ' 
        ShoppingListName.AutoSize = True
        ShoppingListName.Font = New Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point)
        ShoppingListName.Location = New Point(345, 25)
        ShoppingListName.Margin = New Padding(4, 0, 4, 0)
        ShoppingListName.Name = "ShoppingListName"
        ShoppingListName.Size = New Size(355, 45)
        ShoppingListName.TabIndex = 2
        ShoppingListName.Text = "Placeholder List Name"
        ShoppingListName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(17, 25)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 36)
        Button1.TabIndex = 6
        Button1.Text = "<< Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.settings
        PictureBox6.Location = New Point(621, 857)
        PictureBox6.Margin = New Padding(4)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(79, 74)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 19
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.notificationbell
        PictureBox5.Location = New Point(480, 857)
        PictureBox5.Margin = New Padding(4)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(79, 74)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 18
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.home
        PictureBox4.Location = New Point(344, 857)
        PictureBox4.Margin = New Padding(4)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(79, 74)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 17
        PictureBox4.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ItemsCol, QuantityCol, PurchasedCheckbox, DeleteBut, EditBut})
        DataGridView1.Location = New Point(17, 93)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(987, 684)
        DataGridView1.TabIndex = 21
        ' 
        ' AddButton
        ' 
        AddButton.Location = New Point(17, 783)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(164, 57)
        AddButton.TabIndex = 22
        AddButton.Text = "Add Item"
        AddButton.UseVisualStyleBackColor = True
        ' 
        ' ItemsCol
        ' 
        ItemsCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ItemsCol.HeaderText = "Items"
        ItemsCol.MinimumWidth = 8
        ItemsCol.Name = "ItemsCol"
        ItemsCol.ReadOnly = True
        ' 
        ' QuantityCol
        ' 
        QuantityCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        QuantityCol.HeaderText = "Quantity"
        QuantityCol.MinimumWidth = 8
        QuantityCol.Name = "QuantityCol"
        QuantityCol.ReadOnly = True
        ' 
        ' PurchasedCheckbox
        ' 
        PurchasedCheckbox.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        PurchasedCheckbox.HeaderText = "Purchased"
        PurchasedCheckbox.MinimumWidth = 8
        PurchasedCheckbox.Name = "PurchasedCheckbox"
        PurchasedCheckbox.ReadOnly = True
        ' 
        ' DeleteBut
        ' 
        DeleteBut.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.Black
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.White
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DeleteBut.DefaultCellStyle = DataGridViewCellStyle1
        DeleteBut.HeaderText = "Remove"
        DeleteBut.MinimumWidth = 8
        DeleteBut.Name = "DeleteBut"
        DeleteBut.ReadOnly = True
        DeleteBut.Text = "Remove Item"
        ' 
        ' EditBut
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.Black
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.Black
        EditBut.DefaultCellStyle = DataGridViewCellStyle2
        EditBut.HeaderText = "Edit"
        EditBut.MinimumWidth = 8
        EditBut.Name = "EditBut"
        EditBut.ReadOnly = True
        EditBut.Text = "Edit Item"
        EditBut.Width = 150
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1016, 944)
        Controls.Add(AddButton)
        Controls.Add(DataGridView1)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(Button1)
        Controls.Add(ShoppingListName)
        Margin = New Padding(2)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ShoppingListName As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AddButton As Button
    Friend WithEvents ItemsCol As DataGridViewTextBoxColumn
    Friend WithEvents QuantityCol As DataGridViewTextBoxColumn
    Friend WithEvents PurchasedCheckbox As DataGridViewCheckBoxColumn
    Friend WithEvents DeleteBut As DataGridViewButtonColumn
    Friend WithEvents EditBut As DataGridViewButtonColumn
End Class
