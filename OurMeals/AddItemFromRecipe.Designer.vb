<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddItemFromRecipe
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CancelBut = New System.Windows.Forms.Button()
        Me.AddBut = New System.Windows.Forms.Button()
        Me.quantityBox = New System.Windows.Forms.NumericUpDown()
        Me.ItemNameLabel = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.quantityBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Quantity:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Item Name:"
        '
        'CancelBut
        '
        Me.CancelBut.Location = New System.Drawing.Point(156, 144)
        Me.CancelBut.Margin = New System.Windows.Forms.Padding(2)
        Me.CancelBut.Name = "CancelBut"
        Me.CancelBut.Size = New System.Drawing.Size(114, 39)
        Me.CancelBut.TabIndex = 9
        Me.CancelBut.Text = "Cancel"
        Me.CancelBut.UseVisualStyleBackColor = True
        '
        'AddBut
        '
        Me.AddBut.Location = New System.Drawing.Point(27, 144)
        Me.AddBut.Margin = New System.Windows.Forms.Padding(2)
        Me.AddBut.Name = "AddBut"
        Me.AddBut.Size = New System.Drawing.Size(114, 39)
        Me.AddBut.TabIndex = 8
        Me.AddBut.Text = "Add Item"
        Me.AddBut.UseVisualStyleBackColor = True
        '
        'quantityBox
        '
        Me.quantityBox.Location = New System.Drawing.Point(99, 50)
        Me.quantityBox.Margin = New System.Windows.Forms.Padding(2)
        Me.quantityBox.Name = "quantityBox"
        Me.quantityBox.Size = New System.Drawing.Size(192, 27)
        Me.quantityBox.TabIndex = 7
        Me.quantityBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ItemNameLabel
        '
        Me.ItemNameLabel.AutoSize = True
        Me.ItemNameLabel.Location = New System.Drawing.Point(102, 9)
        Me.ItemNameLabel.Name = "ItemNameLabel"
        Me.ItemNameLabel.Size = New System.Drawing.Size(53, 20)
        Me.ItemNameLabel.TabIndex = 12
        Me.ItemNameLabel.Text = "Label3"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(99, 96)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(151, 28)
        Me.ComboBox1.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 99)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "List:"
        '
        'AddItemFromRecipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 245)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ItemNameLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CancelBut)
        Me.Controls.Add(Me.AddBut)
        Me.Controls.Add(Me.quantityBox)
        Me.Name = "AddItemFromRecipe"
        Me.Text = "AddItemFromRecipe"
        CType(Me.quantityBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CancelBut As Button
    Friend WithEvents AddBut As Button
    Friend WithEvents quantityBox As NumericUpDown
    Friend WithEvents ItemNameLabel As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
End Class
