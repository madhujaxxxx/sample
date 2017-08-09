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
        Me.components = New System.ComponentModel.Container()
        Me.btnClickMe = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ctxGreen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxBlue = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxRed = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btnList = New System.Windows.Forms.Button()
        Me.btnHashTable = New System.Windows.Forms.Button()
        Me.btnStack = New System.Windows.Forms.Button()
        Me.btnQueue = New System.Windows.Forms.Button()
        Me.btnArrays = New System.Windows.Forms.Button()
        Me.btnDynamicArrays = New System.Windows.Forms.Button()
        Me.btnNameValueCollection = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClickMe
        '
        Me.btnClickMe.Location = New System.Drawing.Point(12, 27)
        Me.btnClickMe.Name = "btnClickMe"
        Me.btnClickMe.Size = New System.Drawing.Size(75, 23)
        Me.btnClickMe.TabIndex = 0
        Me.btnClickMe.Text = "Click me!"
        Me.btnClickMe.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(399, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileOpen, Me.ToolStripSeparator1, Me.mnuFileExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuFileOpen.Size = New System.Drawing.Size(146, 22)
        Me.mnuFileOpen.Text = "&Open"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(143, 6)
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(146, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctxGreen, Me.ctxBlue, Me.ctxRed})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(106, 70)
        '
        'ctxGreen
        '
        Me.ctxGreen.Name = "ctxGreen"
        Me.ctxGreen.Size = New System.Drawing.Size(105, 22)
        Me.ctxGreen.Text = "Green"
        '
        'ctxBlue
        '
        Me.ctxBlue.Name = "ctxBlue"
        Me.ctxBlue.Size = New System.Drawing.Size(105, 22)
        Me.ctxBlue.Text = "Blue"
        '
        'ctxRed
        '
        Me.ctxRed.Name = "ctxRed"
        Me.ctxRed.Size = New System.Drawing.Size(105, 22)
        Me.ctxRed.Text = "Red"
        '
        'txtResult
        '
        Me.txtResult.ContextMenuStrip = Me.ContextMenuStrip1
        Me.txtResult.Location = New System.Drawing.Point(12, 56)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(100, 20)
        Me.txtResult.TabIndex = 3
        '
        'btnList
        '
        Me.btnList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnList.Location = New System.Drawing.Point(157, 27)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(230, 23)
        Me.btnList.TabIndex = 4
        Me.btnList.Text = "ArrayList"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'btnHashTable
        '
        Me.btnHashTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHashTable.Location = New System.Drawing.Point(157, 56)
        Me.btnHashTable.Name = "btnHashTable"
        Me.btnHashTable.Size = New System.Drawing.Size(230, 23)
        Me.btnHashTable.TabIndex = 5
        Me.btnHashTable.Text = "HashTable"
        Me.btnHashTable.UseVisualStyleBackColor = True
        '
        'btnStack
        '
        Me.btnStack.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStack.Location = New System.Drawing.Point(157, 85)
        Me.btnStack.Name = "btnStack"
        Me.btnStack.Size = New System.Drawing.Size(230, 23)
        Me.btnStack.TabIndex = 6
        Me.btnStack.Text = "Stack"
        Me.btnStack.UseVisualStyleBackColor = True
        '
        'btnQueue
        '
        Me.btnQueue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQueue.Location = New System.Drawing.Point(157, 114)
        Me.btnQueue.Name = "btnQueue"
        Me.btnQueue.Size = New System.Drawing.Size(230, 23)
        Me.btnQueue.TabIndex = 7
        Me.btnQueue.Text = "Queue"
        Me.btnQueue.UseVisualStyleBackColor = True
        '
        'btnArrays
        '
        Me.btnArrays.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArrays.Location = New System.Drawing.Point(157, 143)
        Me.btnArrays.Name = "btnArrays"
        Me.btnArrays.Size = New System.Drawing.Size(230, 23)
        Me.btnArrays.TabIndex = 8
        Me.btnArrays.Text = "Arrays"
        Me.btnArrays.UseVisualStyleBackColor = True
        '
        'btnDynamicArrays
        '
        Me.btnDynamicArrays.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDynamicArrays.Location = New System.Drawing.Point(158, 172)
        Me.btnDynamicArrays.Name = "btnDynamicArrays"
        Me.btnDynamicArrays.Size = New System.Drawing.Size(229, 23)
        Me.btnDynamicArrays.TabIndex = 9
        Me.btnDynamicArrays.Text = "Dynamic Arrays"
        Me.btnDynamicArrays.UseVisualStyleBackColor = True
        '
        'btnNameValueCollection
        '
        Me.btnNameValueCollection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNameValueCollection.Location = New System.Drawing.Point(158, 201)
        Me.btnNameValueCollection.Name = "btnNameValueCollection"
        Me.btnNameValueCollection.Size = New System.Drawing.Size(229, 23)
        Me.btnNameValueCollection.TabIndex = 10
        Me.btnNameValueCollection.Text = "NameValueCollection"
        Me.btnNameValueCollection.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnClickMe
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 280)
        Me.Controls.Add(Me.btnNameValueCollection)
        Me.Controls.Add(Me.btnDynamicArrays)
        Me.Controls.Add(Me.btnArrays)
        Me.Controls.Add(Me.btnQueue)
        Me.Controls.Add(Me.btnStack)
        Me.Controls.Add(Me.btnHashTable)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.btnClickMe)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Demo App"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClickMe As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuFileOpen As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ctxGreen As ToolStripMenuItem
    Friend WithEvents ctxBlue As ToolStripMenuItem
    Friend WithEvents ctxRed As ToolStripMenuItem
    Friend WithEvents txtResult As TextBox
    Friend WithEvents btnList As Button
    Friend WithEvents btnHashTable As Button
    Friend WithEvents btnStack As Button
    Friend WithEvents btnQueue As Button
    Friend WithEvents btnArrays As Button
    Friend WithEvents btnDynamicArrays As Button
    Friend WithEvents btnNameValueCollection As Button
End Class
