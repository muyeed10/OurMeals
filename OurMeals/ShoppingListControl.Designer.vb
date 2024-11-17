<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShoppingListControl
    Inherits System.Windows.Forms.GroupBox

    Private shoppingList As ShoppingList
    Private viewEditButton As Button
    Private makeRoutineButton As Button
    Private removeButton As Button
    Private listLabel As Label
    Private parentForm As Form1
    Private routinePictureBox As PictureBox
    Private descriptionLabel As Label

    Public Sub New(parent As Form1, shoppingList As ShoppingList)
        Me.parentForm = parent
        Me.shoppingList = shoppingList

        InitializeControl()
    End Sub

    ' Initialize the controls within the GroupBox
    Private Sub InitializeControl()
        ' Set the size and other properties of the GroupBox
        Me.Size = New Size(995, 127)
        Me.Margin = New Padding(4)

        ' Create the PictureBox for the routine indicator
        routinePictureBox = New PictureBox()
        routinePictureBox.Size = New Size(32, 32) ' Adjust the size of the image as needed
        routinePictureBox.Location = New Point(8, 48) ' Position it to the very left
        routinePictureBox.SizeMode = PictureBoxSizeMode.Zoom

        ' Create and configure the List Label
        listLabel = New Label()
        listLabel.Text = shoppingList.GetListName()
        listLabel.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular)
        listLabel.Location = New Point(routinePictureBox.Location.X + routinePictureBox.Width + 10, routinePictureBox.Location.Y)
        listLabel.Size = New Size(243, 32)

        ' Create the View/Edit button
        viewEditButton = New Button()
        viewEditButton.Text = "View/Edit"
        viewEditButton.Size = New Size(126, 55)
        viewEditButton.Location = New Point(625, 48)
        AddHandler viewEditButton.Click, AddressOf ViewEditButton_Click

        ' Create the Make Routine button
        makeRoutineButton = New Button()
        makeRoutineButton.Text = "Make/Unmake Routine"
        makeRoutineButton.Size = New Size(158, 54)
        makeRoutineButton.Location = New Point(758, 48)
        AddHandler makeRoutineButton.Click, AddressOf ToggleRoutineStatus

        ' Create the trash can button
        removeButton = New Button()
        removeButton.BackgroundImage = My.Resources.trashcan
        removeButton.BackgroundImageLayout = ImageLayout.Zoom
        removeButton.Size = New Size(57, 54)
        removeButton.Location = New Point(925, 48)
        AddHandler removeButton.Click, AddressOf RemoveButton_Click

        descriptionLabel = New Label()
        descriptionLabel.Text = shoppingList.getDescription()
        descriptionLabel.Font = New Font("Segoe UI", 8.0F, FontStyle.Italic)
        descriptionLabel.ForeColor = Color.Gray
        descriptionLabel.Location = New Point(listLabel.Location.X, listLabel.Location.Y + listLabel.Height + 5)
        descriptionLabel.Size = New Size(500, 20) ' Adjust width as needed for longer descriptions

        ' Add controls to the GroupBox
        Me.Controls.Add(routinePictureBox)
        Me.Controls.Add(listLabel)
        Me.Controls.Add(viewEditButton)
        Me.Controls.Add(makeRoutineButton)
        Me.Controls.Add(removeButton)
        Me.Controls.Add(descriptionLabel)

        ' Set the routine indicator based on the current routine status
        UpdateRoutineIndicator()
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this shopping list?", "Confirm Delete", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            parentForm.RemoveShoppingListControl(Me)
        End If
    End Sub

    Private Sub ViewEditButton_Click(sender As Object, e As EventArgs)
        parentForm.ViewList(Me)
    End Sub


    Public Sub SetLocation(loc As Point)
        Me.Location = loc
    End Sub

    Public Function GetShoppingList() As ShoppingList
        Return Me.shoppingList
    End Function

    Public Sub UpdateRoutineIndicator()
        ' Check if the list is a routine and set the image accordingly
        If shoppingList.getRoutine() Then
            routinePictureBox.Image = My.Resources.routine ' Make sure the resource name is correct
        Else
            routinePictureBox.Image = Nothing ' Clear the image if it's not a routine
        End If
    End Sub

    Private Sub ToggleRoutineStatus(sender As Object, e As EventArgs)
        shoppingList.changeRoutine() ' Toggle the routine status
        UpdateRoutineIndicator() ' Refresh the image

        If shoppingList.getRoutine() Then
            MessageBox.Show($"{shoppingList.GetListName()} is now a routine shopping list.", "Routine Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show($"{shoppingList.GetListName()} is no longer a routine shopping list.", "Routine Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Public Sub UpdateDescription(newDescription As String)
        descriptionLabel.Text = newDescription
    End Sub


    'Control overrides dispose to clean up the component list.
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

    'Required by the Control Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Component Designer
    ' It can be modified using the Component Designer.  Do not modify it
    ' using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

End Class

