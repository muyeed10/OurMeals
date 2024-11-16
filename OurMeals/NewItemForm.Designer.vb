<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewItemForm
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
        itemNameTextbox = New TextBox()
        quantityBox = New NumericUpDown()
        AddBut = New Button()
        CancelBut = New Button()
        Label1 = New Label()
        Label2 = New Label()
        CType(quantityBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' itemNameTextbox
        ' 
        itemNameTextbox.Location = New Point(146, 61)
        itemNameTextbox.Name = "itemNameTextbox"
        itemNameTextbox.Size = New Size(240, 31)
        itemNameTextbox.TabIndex = 0
        ' 
        ' quantityBox
        ' 
        quantityBox.Location = New Point(146, 112)
        quantityBox.Name = "quantityBox"
        quantityBox.Size = New Size(240, 31)
        quantityBox.TabIndex = 1
        quantityBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' AddBut
        ' 
        AddBut.Location = New Point(56, 182)
        AddBut.Name = "AddBut"
        AddBut.Size = New Size(142, 49)
        AddBut.TabIndex = 2
        AddBut.Text = "Add Item"
        AddBut.UseVisualStyleBackColor = True
        ' 
        ' CancelBut
        ' 
        CancelBut.Location = New Point(220, 182)
        CancelBut.Name = "CancelBut"
        CancelBut.Size = New Size(142, 49)
        CancelBut.TabIndex = 3
        CancelBut.Text = "Cancel"
        CancelBut.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(36, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 25)
        Label1.TabIndex = 4
        Label1.Text = "Item Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(56, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 25)
        Label2.TabIndex = 5
        Label2.Text = "Quantity:"
        ' 
        ' NewItemForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(421, 267)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(CancelBut)
        Controls.Add(AddBut)
        Controls.Add(quantityBox)
        Controls.Add(itemNameTextbox)
        Name = "NewItemForm"
        Text = "Add New Item"
        CType(quantityBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents itemNameTextbox As TextBox
    Friend WithEvents quantityBox As NumericUpDown
    Friend WithEvents AddBut As Button
    Friend WithEvents CancelBut As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
