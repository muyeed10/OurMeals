<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditItemForm
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
        Label2 = New Label()
        Label1 = New Label()
        CancelBut = New Button()
        ConfirmBut = New Button()
        quantityBox = New NumericUpDown()
        itemNameTextbox = New TextBox()
        CheckBox = New CheckBox()
        Label3 = New Label()
        CType(quantityBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(61, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 25)
        Label2.TabIndex = 11
        Label2.Text = "Quantity:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(41, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 25)
        Label1.TabIndex = 10
        Label1.Text = "Item Name:"
        ' 
        ' CancelBut
        ' 
        CancelBut.Location = New Point(218, 196)
        CancelBut.Name = "CancelBut"
        CancelBut.Size = New Size(176, 49)
        CancelBut.TabIndex = 9
        CancelBut.Text = "Cancel"
        CancelBut.UseVisualStyleBackColor = True
        ' 
        ' ConfirmBut
        ' 
        ConfirmBut.Location = New Point(41, 196)
        ConfirmBut.Name = "ConfirmBut"
        ConfirmBut.Size = New Size(171, 49)
        ConfirmBut.TabIndex = 8
        ConfirmBut.Text = "Confirm Changes"
        ConfirmBut.UseVisualStyleBackColor = True
        ' 
        ' quantityBox
        ' 
        quantityBox.Location = New Point(151, 98)
        quantityBox.Name = "quantityBox"
        quantityBox.Size = New Size(240, 31)
        quantityBox.TabIndex = 7
        quantityBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' itemNameTextbox
        ' 
        itemNameTextbox.Location = New Point(151, 47)
        itemNameTextbox.Name = "itemNameTextbox"
        itemNameTextbox.Size = New Size(240, 31)
        itemNameTextbox.TabIndex = 6
        ' 
        ' CheckBox
        ' 
        CheckBox.AutoSize = True
        CheckBox.Location = New Point(151, 155)
        CheckBox.Name = "CheckBox"
        CheckBox.Size = New Size(22, 21)
        CheckBox.TabIndex = 12
        CheckBox.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(44, 151)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 25)
        Label3.TabIndex = 13
        Label3.Text = "Purchased?"
        ' 
        ' EditItemForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(447, 274)
        Controls.Add(Label3)
        Controls.Add(CheckBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(CancelBut)
        Controls.Add(ConfirmBut)
        Controls.Add(quantityBox)
        Controls.Add(itemNameTextbox)
        Name = "EditItemForm"
        Text = "Edit Item Form"
        CType(quantityBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CancelBut As Button
    Friend WithEvents ConfirmBut As Button
    Friend WithEvents quantityBox As NumericUpDown
    Friend WithEvents itemNameTextbox As TextBox
    Friend WithEvents CheckBox As CheckBox
    Friend WithEvents Label3 As Label
End Class
