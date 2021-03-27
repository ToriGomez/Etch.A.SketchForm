<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EtchASketchForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EtchASketchForm))
        Me.DisplayPictureBox = New System.Windows.Forms.PictureBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorButton = New System.Windows.Forms.Button()
        Me.DrawWaveformsButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PenSizeToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PenSizeToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DisplayPictureBox
        '
        Me.DisplayPictureBox.Location = New System.Drawing.Point(0, 71)
        Me.DisplayPictureBox.Name = "DisplayPictureBox"
        Me.DisplayPictureBox.Size = New System.Drawing.Size(1814, 791)
        Me.DisplayPictureBox.TabIndex = 0
        Me.DisplayPictureBox.TabStop = False
        '
        'MenuStrip
        '
        Me.MenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1813, 52)
        Me.MenuStrip.TabIndex = 1
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(87, 48)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(448, 54)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        Me.ExitToolStripMenuItem.ToolTipText = "Enter to Close Program"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorToolStripMenuItem, Me.DrawWaveformsToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(92, 48)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'SelectColorToolStripMenuItem
        '
        Me.SelectColorToolStripMenuItem.Name = "SelectColorToolStripMenuItem"
        Me.SelectColorToolStripMenuItem.Size = New System.Drawing.Size(448, 54)
        Me.SelectColorToolStripMenuItem.Text = "&Select Color"
        Me.SelectColorToolStripMenuItem.ToolTipText = "Enter to Customize Color"
        '
        'DrawWaveformsToolStripMenuItem
        '
        Me.DrawWaveformsToolStripMenuItem.Name = "DrawWaveformsToolStripMenuItem"
        Me.DrawWaveformsToolStripMenuItem.Size = New System.Drawing.Size(448, 54)
        Me.DrawWaveformsToolStripMenuItem.Text = "&Draw Waveforms"
        Me.DrawWaveformsToolStripMenuItem.ToolTipText = "Enter to Display Cosine(Green), Sine(Red), and Tangent(Blue) Functions"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(448, 54)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        Me.ClearToolStripMenuItem.ToolTipText = "Enter to Shake and Clear Display"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(104, 48)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(448, 54)
        Me.AboutToolStripMenuItem.Text = "&About"
        Me.AboutToolStripMenuItem.ToolTipText = "Enter to View about "
        '
        'SelectColorButton
        '
        Me.SelectColorButton.Font = New System.Drawing.Font("Stencil", 8.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectColorButton.Location = New System.Drawing.Point(210, 868)
        Me.SelectColorButton.Name = "SelectColorButton"
        Me.SelectColorButton.Size = New System.Drawing.Size(356, 79)
        Me.SelectColorButton.TabIndex = 2
        Me.SelectColorButton.Text = "&Select Color"
        Me.ToolTip.SetToolTip(Me.SelectColorButton, "Enter to Customize Color")
        Me.SelectColorButton.UseVisualStyleBackColor = True
        '
        'DrawWaveformsButton
        '
        Me.DrawWaveformsButton.Font = New System.Drawing.Font("Stencil", 8.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DrawWaveformsButton.Location = New System.Drawing.Point(601, 868)
        Me.DrawWaveformsButton.Name = "DrawWaveformsButton"
        Me.DrawWaveformsButton.Size = New System.Drawing.Size(356, 79)
        Me.DrawWaveformsButton.TabIndex = 3
        Me.DrawWaveformsButton.Text = "&Draw Waveforms"
        Me.ToolTip.SetToolTip(Me.DrawWaveformsButton, "Enter to Display Cosine(Green), Sine(Red), and Tangent(Blue) Functions")
        Me.DrawWaveformsButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Stencil", 8.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(986, 868)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(356, 79)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "&Clear"
        Me.ToolTip.SetToolTip(Me.ClearButton, "Enter to Shake and Clear Display")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Font = New System.Drawing.Font("Stencil", 8.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(1375, 868)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(356, 79)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip.SetToolTip(Me.ExitButton, "Enter to Close Program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ToolStrip
        '
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenSizeToolStripButton, Me.PenSizeToolStripTextBox})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 52)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(1813, 51)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'PenSizeToolStripButton
        '
        Me.PenSizeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PenSizeToolStripButton.Image = CType(resources.GetObject("PenSizeToolStripButton.Image"), System.Drawing.Image)
        Me.PenSizeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PenSizeToolStripButton.Name = "PenSizeToolStripButton"
        Me.PenSizeToolStripButton.Size = New System.Drawing.Size(58, 44)
        Me.PenSizeToolStripButton.Text = "Pen Size"
        '
        'PenSizeToolStripTextBox
        '
        Me.PenSizeToolStripTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PenSizeToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PenSizeToolStripTextBox.Name = "PenSizeToolStripTextBox"
        Me.PenSizeToolStripTextBox.Size = New System.Drawing.Size(100, 51)
        '
        'EtchASketchForm
        '
        Me.AcceptButton = Me.DrawWaveformsButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(1813, 959)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DrawWaveformsButton)
        Me.Controls.Add(Me.SelectColorButton)
        Me.Controls.Add(Me.DisplayPictureBox)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "EtchASketchForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Etch A Sketch"
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DisplayPictureBox As PictureBox
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawWaveformsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectColorButton As Button
    Friend WithEvents DrawWaveformsButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents PenSizeToolStripTextBox As ToolStripTextBox
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents PenSizeToolStripButton As ToolStripButton
End Class
