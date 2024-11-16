<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.CreateNewBut = New System.Windows.Forms.Button()
        Me.ListPanel = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.SettingButton = New System.Windows.Forms.Button()
        Me.RecipesButton = New System.Windows.Forms.Button()
        Me.SuppliesButton = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.NotificationsButton = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FridgeButton = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(2, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(525, 90)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "OurMeals"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(11, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Shopping Lists"
        '
        'CreateNewBut
        '
        Me.CreateNewBut.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CreateNewBut.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CreateNewBut.Location = New System.Drawing.Point(873, 99)
        Me.CreateNewBut.Name = "CreateNewBut"
        Me.CreateNewBut.Size = New System.Drawing.Size(143, 54)
        Me.CreateNewBut.TabIndex = 3
        Me.CreateNewBut.Text = "Create a New List"
        Me.CreateNewBut.UseVisualStyleBackColor = False
        '
        'ListPanel
        '
        Me.ListPanel.AutoScroll = True
        Me.ListPanel.Location = New System.Drawing.Point(11, 160)
        Me.ListPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.ListPanel.Name = "ListPanel"
        Me.ListPanel.Size = New System.Drawing.Size(1020, 516)
        Me.ListPanel.TabIndex = 9
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.SettingButton)
        Me.GroupBox4.Controls.Add(Me.RecipesButton)
        Me.GroupBox4.Controls.Add(Me.SuppliesButton)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.NotificationsButton)
        Me.GroupBox4.Controls.Add(Me.HomeButton)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.FridgeButton)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 693)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1024, 160)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        '
        'SettingButton
        '
        Me.SettingButton.BackgroundImage = Global.OurMeals.My.Resources.Resources.settings
        Me.SettingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SettingButton.Location = New System.Drawing.Point(910, 31)
        Me.SettingButton.Name = "SettingButton"
        Me.SettingButton.Size = New System.Drawing.Size(95, 88)
        Me.SettingButton.TabIndex = 18
        Me.SettingButton.UseVisualStyleBackColor = True
        '
        'RecipesButton
        '
        Me.RecipesButton.BackgroundImage = Global.OurMeals.My.Resources.Resources.recipe
        Me.RecipesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RecipesButton.Location = New System.Drawing.Point(739, 31)
        Me.RecipesButton.Name = "RecipesButton"
        Me.RecipesButton.Size = New System.Drawing.Size(95, 88)
        Me.RecipesButton.TabIndex = 15
        Me.RecipesButton.UseVisualStyleBackColor = True
        '
        'SuppliesButton
        '
        Me.SuppliesButton.BackgroundImage = Global.OurMeals.My.Resources.Resources.supplies
        Me.SuppliesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SuppliesButton.Location = New System.Drawing.Point(563, 31)
        Me.SuppliesButton.Name = "SuppliesButton"
        Me.SuppliesButton.Size = New System.Drawing.Size(95, 88)
        Me.SuppliesButton.TabIndex = 14
        Me.SuppliesButton.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.OurMeals.My.Resources.Resources.fridge
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(378, 31)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 88)
        Me.Button3.TabIndex = 13
        Me.Button3.UseVisualStyleBackColor = True
        '
        'NotificationsButton
        '
        Me.NotificationsButton.BackgroundImage = Global.OurMeals.My.Resources.Resources.notificationbell
        Me.NotificationsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NotificationsButton.Location = New System.Drawing.Point(194, 31)
        Me.NotificationsButton.Name = "NotificationsButton"
        Me.NotificationsButton.Size = New System.Drawing.Size(95, 88)
        Me.NotificationsButton.TabIndex = 12
        Me.NotificationsButton.UseVisualStyleBackColor = True
        '
        'HomeButton
        '
        Me.HomeButton.BackgroundImage = Global.OurMeals.My.Resources.Resources.home
        Me.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HomeButton.Location = New System.Drawing.Point(19, 31)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(95, 88)
        Me.HomeButton.TabIndex = 11
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(910, 131)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 28)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Settings"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(739, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 28)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Recipes"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(563, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 28)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Supplies"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FridgeButton
        '
        Me.FridgeButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FridgeButton.Location = New System.Drawing.Point(378, 132)
        Me.FridgeButton.Name = "FridgeButton"
        Me.FridgeButton.Size = New System.Drawing.Size(95, 28)
        Me.FridgeButton.TabIndex = 14
        Me.FridgeButton.Text = "Fridge"
        Me.FridgeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(194, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 28)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Notifications"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(19, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 28)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Home"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 861)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ListPanel)
        Me.Controls.Add(Me.CreateNewBut)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CreateNewBut As Button
    Friend WithEvents ListPanel As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents FridgeButton As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SettingButton As Button
    Friend WithEvents RecipesButton As Button
    Friend WithEvents SuppliesButton As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents NotificationsButton As Button
    Friend WithEvents HomeButton As Button
End Class
