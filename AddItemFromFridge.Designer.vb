﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddItemFromFridge
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
        Label1 = New Label()
        ItemNameLabel = New Label()
        Label2 = New Label()
        quantityBox = New NumericUpDown()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        AddSupButton = New Button()
        Canceller = New Button()
        CType(quantityBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 25)
        Label1.TabIndex = 0
        Label1.Text = "Item Name: "
        ' 
        ' ItemNameLabel
        ' 
        ItemNameLabel.AutoSize = True
        ItemNameLabel.Location = New Point(134, 33)
        ItemNameLabel.Name = "ItemNameLabel"
        ItemNameLabel.Size = New Size(63, 25)
        ItemNameLabel.TabIndex = 1
        ItemNameLabel.Text = "Label2"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(51, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 25)
        Label2.TabIndex = 2
        Label2.Text = "Quantity: "
        ' 
        ' quantityBox
        ' 
        quantityBox.Location = New Point(134, 80)
        quantityBox.Name = "quantityBox"
        quantityBox.Size = New Size(180, 31)
        quantityBox.TabIndex = 3
        quantityBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(84, 138)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 25)
        Label3.TabIndex = 4
        Label3.Text = "List: "
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(134, 135)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 33)
        ComboBox1.TabIndex = 5
        ' 
        ' AddSupButton
        ' 
        AddSupButton.Location = New Point(51, 209)
        AddSupButton.Name = "AddSupButton"
        AddSupButton.Size = New Size(142, 49)
        AddSupButton.TabIndex = 6
        AddSupButton.Text = "Add Item"
        AddSupButton.UseVisualStyleBackColor = True
        ' 
        ' Canceller
        ' 
        Canceller.Location = New Point(251, 209)
        Canceller.Name = "Canceller"
        Canceller.Size = New Size(142, 49)
        Canceller.TabIndex = 7
        Canceller.Text = "Cancel"
        Canceller.UseVisualStyleBackColor = True
        ' 
        ' AddItemFromFridge
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(439, 306)
        Controls.Add(Canceller)
        Controls.Add(AddSupButton)
        Controls.Add(ComboBox1)
        Controls.Add(Label3)
        Controls.Add(quantityBox)
        Controls.Add(Label2)
        Controls.Add(ItemNameLabel)
        Controls.Add(Label1)
        Name = "AddItemFromFridge"
        Text = "Add Item To An Existing List"
        CType(quantityBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ItemNameLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents quantityBox As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents AddSupButton As Button
    Friend WithEvents Canceller As Button
End Class
