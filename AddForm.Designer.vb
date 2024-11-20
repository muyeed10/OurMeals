<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddForm
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
        option3 = New Label()
        itemnameinput = New TextBox()
        option4 = New Label()
        quantityinput = New NumericUpDown()
        AddConfirm = New Button()
        CancelConfirm = New Button()
        CType(quantityinput, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' option3
        ' 
        option3.AutoSize = True
        option3.Location = New Point(63, 58)
        option3.Name = "option3"
        option3.Size = New Size(104, 25)
        option3.TabIndex = 0
        option3.Text = "Item Name:"
        ' 
        ' itemnameinput
        ' 
        itemnameinput.Location = New Point(173, 58)
        itemnameinput.Name = "itemnameinput"
        itemnameinput.Size = New Size(215, 31)
        itemnameinput.TabIndex = 1
        ' 
        ' option4
        ' 
        option4.AutoSize = True
        option4.Location = New Point(83, 101)
        option4.Name = "option4"
        option4.Size = New Size(84, 25)
        option4.TabIndex = 2
        option4.Text = "Quantity:"
        ' 
        ' quantityinput
        ' 
        quantityinput.Location = New Point(174, 104)
        quantityinput.Name = "quantityinput"
        quantityinput.Size = New Size(214, 31)
        quantityinput.TabIndex = 3
        ' 
        ' AddConfirm
        ' 
        AddConfirm.Location = New Point(83, 163)
        AddConfirm.Name = "AddConfirm"
        AddConfirm.Size = New Size(126, 44)
        AddConfirm.TabIndex = 4
        AddConfirm.Text = "Add Item"
        AddConfirm.UseVisualStyleBackColor = True
        ' 
        ' CancelConfirm
        ' 
        CancelConfirm.Location = New Point(262, 163)
        CancelConfirm.Name = "CancelConfirm"
        CancelConfirm.Size = New Size(126, 44)
        CancelConfirm.TabIndex = 5
        CancelConfirm.Text = "Cancel"
        CancelConfirm.UseVisualStyleBackColor = True
        ' 
        ' AddForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(455, 232)
        Controls.Add(CancelConfirm)
        Controls.Add(AddConfirm)
        Controls.Add(quantityinput)
        Controls.Add(option4)
        Controls.Add(itemnameinput)
        Controls.Add(option3)
        Name = "AddForm"
        Text = "Add New Item"
        CType(quantityinput, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents option3 As Label
    Friend WithEvents itemnameinput As TextBox
    Friend WithEvents option4 As Label
    Friend WithEvents quantityinput As NumericUpDown
    Friend WithEvents AddConfirm As Button
    Friend WithEvents CancelConfirm As Button
End Class
