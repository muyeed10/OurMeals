<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newShoppingListForm
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
        CancelBut = New Button()
        CreateBut = New Button()
        listNameTextbox = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(53, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(252, 25)
        Label1.TabIndex = 10
        Label1.Text = "Enter new Shopping List name"
        ' 
        ' CancelBut
        ' 
        CancelBut.Location = New Point(193, 151)
        CancelBut.Name = "CancelBut"
        CancelBut.Size = New Size(142, 49)
        CancelBut.TabIndex = 9
        CancelBut.Text = "Cancel"
        CancelBut.UseVisualStyleBackColor = True
        ' 
        ' CreateBut
        ' 
        CreateBut.Location = New Point(24, 151)
        CreateBut.Name = "CreateBut"
        CreateBut.Size = New Size(142, 49)
        CreateBut.TabIndex = 8
        CreateBut.Text = "Create New"
        CreateBut.UseVisualStyleBackColor = True
        ' 
        ' listNameTextbox
        ' 
        listNameTextbox.Location = New Point(24, 86)
        listNameTextbox.Name = "listNameTextbox"
        listNameTextbox.Size = New Size(311, 31)
        listNameTextbox.TabIndex = 6
        ' 
        ' newShoppingListForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(370, 241)
        Controls.Add(Label1)
        Controls.Add(CancelBut)
        Controls.Add(CreateBut)
        Controls.Add(listNameTextbox)
        Name = "newShoppingListForm"
        Text = "Create New Shopping List"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CancelBut As Button
    Friend WithEvents CreateBut As Button
    Friend WithEvents listNameTextbox As TextBox
End Class
