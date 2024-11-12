<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        GroupBox1 = New GroupBox()
        ComboBox1 = New ComboBox()
        NumericUpDown1 = New NumericUpDown()
        remove1 = New Button()
        checkbox1 = New CheckBox()
        item1 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        GroupBox2 = New GroupBox()
        ComboBox2 = New ComboBox()
        NumericUpDown2 = New NumericUpDown()
        Button2 = New Button()
        CheckBox2 = New CheckBox()
        item2 = New Label()
        GroupBox3 = New GroupBox()
        ComboBox3 = New ComboBox()
        NumericUpDown3 = New NumericUpDown()
        Button3 = New Button()
        CheckBox3 = New CheckBox()
        item3 = New Label()
        GroupBox4 = New GroupBox()
        NumericUpDown4 = New NumericUpDown()
        Button4 = New Button()
        CheckBox4 = New CheckBox()
        ComboBox4 = New ComboBox()
        item4 = New Label()
        GroupBox5 = New GroupBox()
        ComboBox5 = New ComboBox()
        NumericUpDown6 = New NumericUpDown()
        Button6 = New Button()
        CheckBox6 = New CheckBox()
        item5 = New Label()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        CheckBox5 = New CheckBox()
        Button5 = New Button()
        NumericUpDown5 = New NumericUpDown()
        TextBox1 = New TextBox()
        GroupBox6 = New GroupBox()
        ComboBox6 = New ComboBox()
        GroupBox1.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        CType(NumericUpDown3, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        CType(NumericUpDown4, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox5.SuspendLayout()
        CType(NumericUpDown6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown5, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(420, 32)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(447, 59)
        Label2.TabIndex = 2
        Label2.Text = "Weekly Shopping List"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(NumericUpDown1)
        GroupBox1.Controls.Add(remove1)
        GroupBox1.Controls.Add(checkbox1)
        GroupBox1.Controls.Add(item1)
        GroupBox1.Location = New Point(10, 204)
        GroupBox1.Margin = New Padding(5)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(5)
        GroupBox1.Size = New Size(1294, 104)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = SystemColors.ButtonHighlight
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.DropDownWidth = 255
        ComboBox1.ForeColor = SystemColors.WindowText
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Weekly_Shopping_List", "Meat_Purchases", "Baking_Supplies", "Monthly_Shopping_List"})
        ComboBox1.Location = New Point(1253, 22)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(32, 40)
        ComboBox1.TabIndex = 21
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(700, 41)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(78, 39)
        NumericUpDown1.TabIndex = 12
        NumericUpDown1.Value = New Decimal(New Integer() {2, 0, 0, 0})
        ' 
        ' remove1
        ' 
        remove1.BackColor = Color.Transparent
        remove1.BackgroundImage = My.Resources.Resources.trashcan
        remove1.BackgroundImageLayout = ImageLayout.Zoom
        remove1.Location = New Point(1111, 22)
        remove1.Name = "remove1"
        remove1.Size = New Size(74, 74)
        remove1.TabIndex = 10
        remove1.UseVisualStyleBackColor = False
        ' 
        ' checkbox1
        ' 
        checkbox1.AutoSize = True
        checkbox1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        checkbox1.Location = New Point(932, 47)
        checkbox1.Name = "checkbox1"
        checkbox1.Size = New Size(28, 27)
        checkbox1.TabIndex = 10
        checkbox1.UseVisualStyleBackColor = True
        ' 
        ' item1
        ' 
        item1.AutoSize = True
        item1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        item1.Location = New Point(11, 33)
        item1.Margin = New Padding(5, 0, 5, 0)
        item1.Name = "item1"
        item1.Size = New Size(93, 45)
        item1.TabIndex = 2
        item1.Text = "Soup"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(21, 138)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 45)
        Label1.TabIndex = 5
        Label1.Text = "Items"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(0, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 46)
        Button1.TabIndex = 6
        Button1.Text = "<< Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(672, 138)
        Label4.Name = "Label4"
        Label4.Size = New Size(147, 45)
        Label4.TabIndex = 7
        Label4.Text = "Quantity"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(1087, 138)
        Label5.Name = "Label5"
        Label5.Size = New Size(136, 45)
        Label5.TabIndex = 8
        Label5.Text = "Remove"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(868, 138)
        Label6.Name = "Label6"
        Label6.Size = New Size(171, 45)
        Label6.TabIndex = 9
        Label6.Text = "Purchased"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(ComboBox2)
        GroupBox2.Controls.Add(NumericUpDown2)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(CheckBox2)
        GroupBox2.Controls.Add(item2)
        GroupBox2.Location = New Point(9, 308)
        GroupBox2.Margin = New Padding(5)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(5)
        GroupBox2.Size = New Size(1294, 104)
        GroupBox2.TabIndex = 10
        GroupBox2.TabStop = False
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = SystemColors.ButtonHighlight
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.DropDownWidth = 255
        ComboBox2.ForeColor = SystemColors.WindowText
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Weekly_Shopping_List", "Meat_Purchases", "Baking_Supplies", "Monthly_Shopping_List"})
        ComboBox2.Location = New Point(1254, 22)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(32, 40)
        ComboBox2.TabIndex = 21
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.Location = New Point(701, 41)
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(78, 39)
        NumericUpDown2.TabIndex = 12
        NumericUpDown2.Value = New Decimal(New Integer() {2, 0, 0, 0})
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImage = My.Resources.Resources.trashcan
        Button2.BackgroundImageLayout = ImageLayout.Zoom
        Button2.Location = New Point(1112, 22)
        Button2.Name = "Button2"
        Button2.Size = New Size(74, 74)
        Button2.TabIndex = 10
        Button2.UseVisualStyleBackColor = False
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox2.Location = New Point(933, 47)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(28, 27)
        CheckBox2.TabIndex = 10
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' item2
        ' 
        item2.AutoSize = True
        item2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        item2.Location = New Point(13, 35)
        item2.Margin = New Padding(5, 0, 5, 0)
        item2.Name = "item2"
        item2.Size = New Size(109, 45)
        item2.TabIndex = 2
        item2.Text = "Cereal"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(ComboBox3)
        GroupBox3.Controls.Add(NumericUpDown3)
        GroupBox3.Controls.Add(Button3)
        GroupBox3.Controls.Add(CheckBox3)
        GroupBox3.Controls.Add(item3)
        GroupBox3.Location = New Point(9, 412)
        GroupBox3.Margin = New Padding(5)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(5)
        GroupBox3.Size = New Size(1294, 104)
        GroupBox3.TabIndex = 11
        GroupBox3.TabStop = False
        ' 
        ' ComboBox3
        ' 
        ComboBox3.BackColor = SystemColors.ButtonHighlight
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.DropDownWidth = 255
        ComboBox3.ForeColor = SystemColors.WindowText
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"Weekly_Shopping_List", "Meat_Purchases", "Baking_Supplies", "Monthly_Shopping_List"})
        ComboBox3.Location = New Point(1254, 22)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(32, 40)
        ComboBox3.TabIndex = 21
        ' 
        ' NumericUpDown3
        ' 
        NumericUpDown3.Location = New Point(701, 41)
        NumericUpDown3.Name = "NumericUpDown3"
        NumericUpDown3.Size = New Size(78, 39)
        NumericUpDown3.TabIndex = 12
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.BackgroundImage = My.Resources.Resources.trashcan
        Button3.BackgroundImageLayout = ImageLayout.Zoom
        Button3.Location = New Point(1112, 22)
        Button3.Name = "Button3"
        Button3.Size = New Size(74, 74)
        Button3.TabIndex = 10
        Button3.UseVisualStyleBackColor = False
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox3.Location = New Point(933, 49)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(28, 27)
        CheckBox3.TabIndex = 10
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' item3
        ' 
        item3.AutoSize = True
        item3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        item3.Location = New Point(13, 35)
        item3.Margin = New Padding(5, 0, 5, 0)
        item3.Name = "item3"
        item3.Size = New Size(81, 45)
        item3.TabIndex = 2
        item3.Text = "Milk"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(NumericUpDown4)
        GroupBox4.Controls.Add(Button4)
        GroupBox4.Controls.Add(CheckBox4)
        GroupBox4.Controls.Add(ComboBox4)
        GroupBox4.Controls.Add(item4)
        GroupBox4.Location = New Point(9, 516)
        GroupBox4.Margin = New Padding(5)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(5)
        GroupBox4.Size = New Size(1294, 104)
        GroupBox4.TabIndex = 13
        GroupBox4.TabStop = False
        ' 
        ' NumericUpDown4
        ' 
        NumericUpDown4.Location = New Point(701, 41)
        NumericUpDown4.Name = "NumericUpDown4"
        NumericUpDown4.Size = New Size(78, 39)
        NumericUpDown4.TabIndex = 12
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.BackgroundImage = My.Resources.Resources.trashcan
        Button4.BackgroundImageLayout = ImageLayout.Zoom
        Button4.Location = New Point(1112, 24)
        Button4.Name = "Button4"
        Button4.Size = New Size(74, 74)
        Button4.TabIndex = 10
        Button4.UseVisualStyleBackColor = False
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox4.Location = New Point(933, 53)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(28, 27)
        CheckBox4.TabIndex = 10
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' ComboBox4
        ' 
        ComboBox4.BackColor = SystemColors.ButtonHighlight
        ComboBox4.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox4.DropDownWidth = 255
        ComboBox4.ForeColor = SystemColors.WindowText
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"Weekly_Shopping_List", "Meat_Purchases", "Baking_Supplies", "Monthly_Shopping_List"})
        ComboBox4.Location = New Point(1254, 22)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(32, 40)
        ComboBox4.TabIndex = 13
        ' 
        ' item4
        ' 
        item4.AutoSize = True
        item4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        item4.Location = New Point(13, 35)
        item4.Margin = New Padding(5, 0, 5, 0)
        item4.Name = "item4"
        item4.Size = New Size(298, 45)
        item4.TabIndex = 2
        item4.Text = "Brown Sugar           "
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(ComboBox5)
        GroupBox5.Controls.Add(NumericUpDown6)
        GroupBox5.Controls.Add(Button6)
        GroupBox5.Controls.Add(CheckBox6)
        GroupBox5.Controls.Add(item5)
        GroupBox5.Location = New Point(9, 620)
        GroupBox5.Margin = New Padding(5)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Padding = New Padding(5)
        GroupBox5.Size = New Size(1294, 104)
        GroupBox5.TabIndex = 15
        GroupBox5.TabStop = False
        ' 
        ' ComboBox5
        ' 
        ComboBox5.BackColor = SystemColors.ButtonHighlight
        ComboBox5.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox5.DropDownWidth = 255
        ComboBox5.ForeColor = SystemColors.WindowText
        ComboBox5.FormattingEnabled = True
        ComboBox5.Items.AddRange(New Object() {"Weekly_Shopping_List", "Meat_Purchases", "Baking_Supplies", "Monthly_Shopping_List"})
        ComboBox5.Location = New Point(1254, 22)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(32, 40)
        ComboBox5.TabIndex = 21
        ' 
        ' NumericUpDown6
        ' 
        NumericUpDown6.Location = New Point(701, 41)
        NumericUpDown6.Name = "NumericUpDown6"
        NumericUpDown6.Size = New Size(78, 39)
        NumericUpDown6.TabIndex = 12
        NumericUpDown6.Value = New Decimal(New Integer() {3, 0, 0, 0})
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Transparent
        Button6.BackgroundImage = My.Resources.Resources.trashcan
        Button6.BackgroundImageLayout = ImageLayout.Zoom
        Button6.Location = New Point(1112, 22)
        Button6.Name = "Button6"
        Button6.Size = New Size(74, 74)
        Button6.TabIndex = 10
        Button6.UseVisualStyleBackColor = False
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox6.Location = New Point(933, 51)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(28, 27)
        CheckBox6.TabIndex = 10
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' item5
        ' 
        item5.AutoSize = True
        item5.BackColor = SystemColors.Control
        item5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        item5.Location = New Point(9, 37)
        item5.Margin = New Padding(5, 0, 5, 0)
        item5.Name = "item5"
        item5.Size = New Size(139, 45)
        item5.TabIndex = 2
        item5.Text = "Oranges"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.settings
        PictureBox6.Location = New Point(808, 954)
        PictureBox6.Margin = New Padding(5)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(103, 95)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 19
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.notificationbell
        PictureBox5.Location = New Point(625, 954)
        PictureBox5.Margin = New Padding(5)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(103, 95)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 18
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.home
        PictureBox4.Location = New Point(448, 954)
        PictureBox4.Margin = New Padding(5)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(103, 95)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 17
        PictureBox4.TabStop = False
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox5.Location = New Point(933, 47)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(28, 27)
        CheckBox5.TabIndex = 10
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Transparent
        Button5.BackgroundImage = My.Resources.Resources.trashcan
        Button5.BackgroundImageLayout = ImageLayout.Zoom
        Button5.Location = New Point(1112, 22)
        Button5.Name = "Button5"
        Button5.Size = New Size(74, 74)
        Button5.TabIndex = 10
        Button5.UseVisualStyleBackColor = False
        ' 
        ' NumericUpDown5
        ' 
        NumericUpDown5.Location = New Point(701, 41)
        NumericUpDown5.Name = "NumericUpDown5"
        NumericUpDown5.Size = New Size(78, 39)
        NumericUpDown5.TabIndex = 12
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.MenuBar
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.ForeColor = SystemColors.ControlText
        TextBox1.Location = New Point(12, 40)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(316, 43)
        TextBox1.TabIndex = 13
        TextBox1.Text = "Add New Item Here"
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(ComboBox6)
        GroupBox6.Controls.Add(TextBox1)
        GroupBox6.Controls.Add(NumericUpDown5)
        GroupBox6.Controls.Add(Button5)
        GroupBox6.Controls.Add(CheckBox5)
        GroupBox6.Location = New Point(9, 724)
        GroupBox6.Margin = New Padding(5)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Padding = New Padding(5)
        GroupBox6.Size = New Size(1294, 104)
        GroupBox6.TabIndex = 20
        GroupBox6.TabStop = False
        ' 
        ' ComboBox6
        ' 
        ComboBox6.BackColor = SystemColors.ButtonHighlight
        ComboBox6.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox6.DropDownWidth = 255
        ComboBox6.ForeColor = SystemColors.WindowText
        ComboBox6.FormattingEnabled = True
        ComboBox6.Items.AddRange(New Object() {"Weekly_Shopping_List", "Meat_Purchases", "Baking_Supplies", "Monthly_Shopping_List"})
        ComboBox6.Location = New Point(1254, 22)
        ComboBox6.Name = "ComboBox6"
        ComboBox6.Size = New Size(32, 40)
        ComboBox6.TabIndex = 21
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1321, 1053)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Controls.Add(GroupBox6)
        Name = "Form2"
        Text = "Form2"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(NumericUpDown3, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(NumericUpDown4, ComponentModel.ISupportInitialize).EndInit()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        CType(NumericUpDown6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown5, ComponentModel.ISupportInitialize).EndInit()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents item1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents checkbox1 As CheckBox
    Friend WithEvents remove1 As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents item2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents Button3 As Button
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents item3 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents NumericUpDown4 As NumericUpDown
    Friend WithEvents Button4 As Button
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents item4 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents NumericUpDown6 As NumericUpDown
    Friend WithEvents Button6 As Button
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents item5 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents Button5 As Button
    Friend WithEvents NumericUpDown5 As NumericUpDown
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
End Class
