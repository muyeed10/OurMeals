<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditForm
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
        option1 = New Label()
        itemnameinput = New TextBox()
        option2 = New Label()
        quantityinput = New NumericUpDown()
        ConfirmButton = New Button()
        CancelButton = New Button()
        CType(quantityinput, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' option1
        ' 
        option1.AutoSize = True
        option1.Location = New Point(62, 45)
        option1.Name = "option1"
        option1.Size = New Size(109, 25)
        option1.TabIndex = 0
        option1.Text = "Item Name: "
        ' 
        ' itemnameinput
        ' 
        itemnameinput.Location = New Point(177, 45)
        itemnameinput.Name = "itemnameinput"
        itemnameinput.Size = New Size(179, 31)
        itemnameinput.TabIndex = 1
        ' 
        ' option2
        ' 
        option2.AutoSize = True
        option2.Location = New Point(82, 85)
        option2.Name = "option2"
        option2.Size = New Size(89, 25)
        option2.TabIndex = 2
        option2.Text = "Quantity: "
        ' 
        ' quantityinput
        ' 
        quantityinput.Location = New Point(177, 85)
        quantityinput.Name = "quantityinput"
        quantityinput.Size = New Size(179, 31)
        quantityinput.TabIndex = 3
        ' 
        ' ConfirmButton
        ' 
        ConfirmButton.Location = New Point(62, 156)
        ConfirmButton.Name = "ConfirmButton"
        ConfirmButton.Size = New Size(112, 34)
        ConfirmButton.TabIndex = 4
        ConfirmButton.Text = "Confirm"
        ConfirmButton.UseVisualStyleBackColor = True
        ' 
        ' CancelButton
        ' 
        CancelButton.Location = New Point(244, 156)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(112, 34)
        CancelButton.TabIndex = 5
        CancelButton.Text = "Cancel"
        CancelButton.UseVisualStyleBackColor = True
        ' 
        ' EditForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(420, 213)
        Controls.Add(CancelButton)
        Controls.Add(ConfirmButton)
        Controls.Add(quantityinput)
        Controls.Add(option2)
        Controls.Add(itemnameinput)
        Controls.Add(option1)
        MdiChildrenMinimizedAnchorBottom = False
        Name = "EditForm"
        Text = "EditForm"
        CType(quantityinput, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents option1 As Label
    Friend WithEvents itemnameinput As TextBox
    Friend WithEvents option2 As Label
    Friend WithEvents quantityinput As NumericUpDown
    Friend WithEvents ConfirmButton As Button
    Friend WithEvents CancelButton As Button
End Class
