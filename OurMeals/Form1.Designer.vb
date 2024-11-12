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
        Label1 = New Label()
        Label2 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        Button3 = New Button()
        PictureBox1 = New PictureBox()
        Button2 = New Button()
        Button1 = New Button()
        GroupBox2 = New GroupBox()
        Button4 = New Button()
        PictureBox2 = New PictureBox()
        Button5 = New Button()
        Label4 = New Label()
        GroupBox3 = New GroupBox()
        Button6 = New Button()
        PictureBox3 = New PictureBox()
        Button7 = New Button()
        Label5 = New Label()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 36.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(3, 14)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(502, 144)
        Label1.TabIndex = 0
        Label1.Text = "OurMeals"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(20, 192)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(310, 60)
        Label2.TabIndex = 1
        Label2.Text = "Shopping Lists"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(10, 67)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(325, 45)
        Label3.TabIndex = 2
        Label3.Text = "Weekly Shopping List"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(20, 285)
        GroupBox1.Margin = New Padding(5)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(5)
        GroupBox1.Size = New Size(1294, 162)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(986, 61)
        Button3.Margin = New Padding(5)
        Button3.Name = "Button3"
        Button3.Size = New Size(206, 69)
        Button3.TabIndex = 5
        Button3.Text = "Make Routine"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.trashcan
        PictureBox1.Location = New Point(1202, 61)
        PictureBox1.Margin = New Padding(5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(73, 69)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(812, 61)
        Button2.Margin = New Padding(5)
        Button2.Name = "Button2"
        Button2.Size = New Size(164, 70)
        Button2.TabIndex = 4
        Button2.Text = "View/Edit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1084, 229)
        Button1.Margin = New Padding(5)
        Button1.Name = "Button1"
        Button1.Size = New Size(229, 46)
        Button1.TabIndex = 3
        Button1.Text = "Create a New List"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button4)
        GroupBox2.Controls.Add(PictureBox2)
        GroupBox2.Controls.Add(Button5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Location = New Point(20, 470)
        GroupBox2.Margin = New Padding(5)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(5)
        GroupBox2.Size = New Size(1294, 162)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(986, 59)
        Button4.Margin = New Padding(5)
        Button4.Name = "Button4"
        Button4.Size = New Size(206, 69)
        Button4.TabIndex = 5
        Button4.Text = "Make Routine"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.trashcan
        PictureBox2.Location = New Point(1202, 59)
        PictureBox2.Margin = New Padding(5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(73, 69)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(812, 59)
        Button5.Margin = New Padding(5)
        Button5.Name = "Button5"
        Button5.Size = New Size(164, 70)
        Button5.TabIndex = 4
        Button5.Text = "View/Edit"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(10, 67)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(243, 45)
        Label4.TabIndex = 2
        Label4.Text = "Meat Purchases"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Button6)
        GroupBox3.Controls.Add(PictureBox3)
        GroupBox3.Controls.Add(Button7)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Location = New Point(20, 656)
        GroupBox3.Margin = New Padding(5)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(5)
        GroupBox3.Size = New Size(1294, 162)
        GroupBox3.TabIndex = 5
        GroupBox3.TabStop = False
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(986, 42)
        Button6.Margin = New Padding(5)
        Button6.Name = "Button6"
        Button6.Size = New Size(206, 69)
        Button6.TabIndex = 5
        Button6.Text = "Make Routine"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.trashcan
        PictureBox3.Location = New Point(1202, 42)
        PictureBox3.Margin = New Padding(5)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(73, 69)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 4
        PictureBox3.TabStop = False
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(812, 42)
        Button7.Margin = New Padding(5)
        Button7.Name = "Button7"
        Button7.Size = New Size(164, 70)
        Button7.TabIndex = 4
        Button7.Text = "View/Edit"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(10, 67)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(341, 45)
        Label5.TabIndex = 2
        Label5.Text = "Monthly Shopping List"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.home
        PictureBox4.Location = New Point(20, 886)
        PictureBox4.Margin = New Padding(5)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(141, 141)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 6
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.notificationbell
        PictureBox5.Location = New Point(197, 886)
        PictureBox5.Margin = New Padding(5)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(141, 141)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 7
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.settings
        PictureBox6.Location = New Point(380, 886)
        PictureBox6.Margin = New Padding(5)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(141, 141)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 8
        PictureBox6.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13.0F, 32.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1321, 1053)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(Button1)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(5)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
End Class
