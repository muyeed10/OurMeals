<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RecipeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecipeView = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Items = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.CreateList = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(491, 71)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Manage Recipes"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RecipeName, Me.RecipeView, Me.Items, Me.CreateList})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 94)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(839, 414)
        Me.DataGridView1.TabIndex = 2
        '
        'RecipeName
        '
        Me.RecipeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RecipeName.DefaultCellStyle = DataGridViewCellStyle1
        Me.RecipeName.HeaderText = "Recipe"
        Me.RecipeName.MinimumWidth = 6
        Me.RecipeName.Name = "RecipeName"
        Me.RecipeName.ReadOnly = True
        '
        'RecipeView
        '
        Me.RecipeView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RecipeView.DefaultCellStyle = DataGridViewCellStyle2
        Me.RecipeView.HeaderText = "View Recipe"
        Me.RecipeView.MinimumWidth = 6
        Me.RecipeView.Name = "RecipeView"
        Me.RecipeView.ReadOnly = True
        Me.RecipeView.Text = "Click to View Recipe"
        '
        'Items
        '
        Me.Items.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Items.DefaultCellStyle = DataGridViewCellStyle3
        Me.Items.HeaderText = "View Items Required"
        Me.Items.MinimumWidth = 6
        Me.Items.Name = "Items"
        Me.Items.ReadOnly = True
        Me.Items.Text = "->"
        '
        'CreateList
        '
        Me.CreateList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CreateList.DefaultCellStyle = DataGridViewCellStyle4
        Me.CreateList.HeaderText = "Create New Shopping List From Recipe"
        Me.CreateList.MinimumWidth = 6
        Me.CreateList.Name = "CreateList"
        Me.CreateList.ReadOnly = True
        '
        'Recipes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 520)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Recipes"
        Me.Text = "Recipes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RecipeName As DataGridViewTextBoxColumn
    Friend WithEvents RecipeView As DataGridViewButtonColumn
    Friend WithEvents Items As DataGridViewButtonColumn
    Friend WithEvents CreateList As DataGridViewButtonColumn
End Class
