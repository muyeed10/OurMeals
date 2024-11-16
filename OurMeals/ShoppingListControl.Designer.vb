<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShoppingListControl
    Inherits System.Windows.Forms.GroupBox

    Private shoppingList As ShoppingList
    Private viewEditButton As Button
    Private makeRoutineButton As Button
    Private removeButton As Button
    Private listLabel As Label
    Private parentForm As Form1

    Public Sub New(parent As Form1, shoppingList As ShoppingList)
        Me.parentForm = parent
        Me.shoppingList = shoppingList

        InitializeControl()
    End Sub

    ' Initialize the controls within the GroupBox
    Private Sub InitializeControl()
        'Set the size and other properties of the GroupBox
        Me.Size = New Size(995, 127)
        Me.Margin = New Padding(4)

        'Created and configured the List Label
        listLabel = New Label()
        listLabel.Text = shoppingList.GetListName()
        listLabel.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular)
        listLabel.Location = New Point(8, 52)
        listLabel.Size = New Size(243, 32)

        'Created the View/Edit button
        viewEditButton = New Button()
        viewEditButton.Text = "View/Edit"
        viewEditButton.Size = New Size(126, 55)
        viewEditButton.Location = New Point(625, 48)

        'Created the Make Routine button
        makeRoutineButton = New Button()
        makeRoutineButton.Text = "Make Routine"
        makeRoutineButton.Size = New Size(158, 54)
        makeRoutineButton.Location = New Point(758, 48)

        'Created the trash can button
        removeButton = New Button()
        removeButton.BackgroundImage = My.Resources.trashcan
        removeButton.BackgroundImageLayout = ImageLayout.Zoom
        removeButton.Size = New Size(57, 58)
        removeButton.Location = New Point(925, 48)

        'Added event handler for the remove button
        AddHandler removeButton.Click, AddressOf RemoveButton_Click

        'Added event handler for the view/edit button
        AddHandler viewEditButton.Click, AddressOf ViewEditButton_Click

        Me.Controls.Add(listLabel)
        Me.Controls.Add(viewEditButton)
        Me.Controls.Add(makeRoutineButton)
        Me.Controls.Add(removeButton)
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

