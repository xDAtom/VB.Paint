<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.Image = New System.Windows.Forms.PictureBox
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.NewButton = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseButton = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitButton = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpButton = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutButton = New System.Windows.Forms.ToolStripMenuItem
        Me.PaintToolsPanel = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.BrushColorOrange = New System.Windows.Forms.Button
        Me.BrushColorWhite = New System.Windows.Forms.Button
        Me.BrushColorBlack = New System.Windows.Forms.Button
        Me.BrushColorCyan = New System.Windows.Forms.Button
        Me.BrushColorMagenta = New System.Windows.Forms.Button
        Me.BrushColorYellow = New System.Windows.Forms.Button
        Me.BrushColorBlue = New System.Windows.Forms.Button
        Me.BrushColorGreen = New System.Windows.Forms.Button
        Me.BrushColorRed = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.BrushPreview = New System.Windows.Forms.PictureBox
        Me.BrushSize = New System.Windows.Forms.DomainUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.HorizontalDivider = New System.Windows.Forms.Panel
        Me.PictureBoxBackground = New System.Windows.Forms.Panel
        Me.VerticalDivider = New System.Windows.Forms.Panel
        Me.NewShortcut = New System.Windows.Forms.Button
        Me.CloseShortcut = New System.Windows.Forms.Button
        CType(Me.Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.PaintToolsPanel.SuspendLayout()
        CType(Me.BrushPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Image
        '
        Me.Image.BackColor = System.Drawing.Color.Silver
        Me.Image.Enabled = False
        Me.Image.Location = New System.Drawing.Point(12, 33)
        Me.Image.Name = "Image"
        Me.Image.Size = New System.Drawing.Size(673, 473)
        Me.Image.TabIndex = 0
        Me.Image.TabStop = False
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 511)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(941, 25)
        Me.StatusStrip.TabIndex = 1
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(50, 20)
        Me.StatusLabel.Text = "Ready"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.HelpButton, Me.AboutButton})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(941, 28)
        Me.MenuStrip.TabIndex = 2
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewButton, Me.CloseButton, Me.ExitButton})
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(44, 24)
        Me.FileMenu.Text = "File"
        '
        'NewButton
        '
        Me.NewButton.Name = "NewButton"
        Me.NewButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewButton.Size = New System.Drawing.Size(171, 24)
        Me.NewButton.Text = "New"
        '
        'CloseButton
        '
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseButton.Size = New System.Drawing.Size(171, 24)
        Me.CloseButton.Text = "Close"
        '
        'ExitButton
        '
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitButton.Size = New System.Drawing.Size(171, 24)
        Me.ExitButton.Text = "Exit"
        '
        'HelpButton
        '
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HelpButton.Size = New System.Drawing.Size(53, 24)
        Me.HelpButton.Text = "Help"
        '
        'AboutButton
        '
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AboutButton.Size = New System.Drawing.Size(62, 24)
        Me.AboutButton.Text = "About"
        '
        'PaintToolsPanel
        '
        Me.PaintToolsPanel.BackColor = System.Drawing.Color.White
        Me.PaintToolsPanel.Controls.Add(Me.Label3)
        Me.PaintToolsPanel.Controls.Add(Me.BrushColorOrange)
        Me.PaintToolsPanel.Controls.Add(Me.BrushColorWhite)
        Me.PaintToolsPanel.Controls.Add(Me.BrushColorBlack)
        Me.PaintToolsPanel.Controls.Add(Me.BrushColorCyan)
        Me.PaintToolsPanel.Controls.Add(Me.BrushColorMagenta)
        Me.PaintToolsPanel.Controls.Add(Me.BrushColorYellow)
        Me.PaintToolsPanel.Controls.Add(Me.BrushColorBlue)
        Me.PaintToolsPanel.Controls.Add(Me.BrushColorGreen)
        Me.PaintToolsPanel.Controls.Add(Me.BrushColorRed)
        Me.PaintToolsPanel.Controls.Add(Me.Label2)
        Me.PaintToolsPanel.Controls.Add(Me.BrushPreview)
        Me.PaintToolsPanel.Controls.Add(Me.BrushSize)
        Me.PaintToolsPanel.Controls.Add(Me.Label1)
        Me.PaintToolsPanel.Location = New System.Drawing.Point(697, 0)
        Me.PaintToolsPanel.Name = "PaintToolsPanel"
        Me.PaintToolsPanel.Size = New System.Drawing.Size(244, 536)
        Me.PaintToolsPanel.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Preview Brush:"
        '
        'BrushColorOrange
        '
        Me.BrushColorOrange.BackColor = System.Drawing.Color.Orange
        Me.BrushColorOrange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrushColorOrange.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BrushColorOrange.Location = New System.Drawing.Point(172, 102)
        Me.BrushColorOrange.Name = "BrushColorOrange"
        Me.BrushColorOrange.Size = New System.Drawing.Size(23, 18)
        Me.BrushColorOrange.TabIndex = 12
        Me.BrushColorOrange.UseVisualStyleBackColor = False
        '
        'BrushColorWhite
        '
        Me.BrushColorWhite.BackColor = System.Drawing.Color.White
        Me.BrushColorWhite.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrushColorWhite.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BrushColorWhite.Location = New System.Drawing.Point(172, 85)
        Me.BrushColorWhite.Name = "BrushColorWhite"
        Me.BrushColorWhite.Size = New System.Drawing.Size(23, 18)
        Me.BrushColorWhite.TabIndex = 11
        Me.BrushColorWhite.UseVisualStyleBackColor = False
        '
        'BrushColorBlack
        '
        Me.BrushColorBlack.BackColor = System.Drawing.Color.Black
        Me.BrushColorBlack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrushColorBlack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BrushColorBlack.Location = New System.Drawing.Point(172, 68)
        Me.BrushColorBlack.Name = "BrushColorBlack"
        Me.BrushColorBlack.Size = New System.Drawing.Size(23, 18)
        Me.BrushColorBlack.TabIndex = 10
        Me.BrushColorBlack.UseVisualStyleBackColor = False
        '
        'BrushColorCyan
        '
        Me.BrushColorCyan.BackColor = System.Drawing.Color.Cyan
        Me.BrushColorCyan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrushColorCyan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BrushColorCyan.Location = New System.Drawing.Point(150, 102)
        Me.BrushColorCyan.Name = "BrushColorCyan"
        Me.BrushColorCyan.Size = New System.Drawing.Size(23, 18)
        Me.BrushColorCyan.TabIndex = 9
        Me.BrushColorCyan.UseVisualStyleBackColor = False
        '
        'BrushColorMagenta
        '
        Me.BrushColorMagenta.BackColor = System.Drawing.Color.Magenta
        Me.BrushColorMagenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrushColorMagenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BrushColorMagenta.Location = New System.Drawing.Point(150, 85)
        Me.BrushColorMagenta.Name = "BrushColorMagenta"
        Me.BrushColorMagenta.Size = New System.Drawing.Size(23, 18)
        Me.BrushColorMagenta.TabIndex = 8
        Me.BrushColorMagenta.UseVisualStyleBackColor = False
        '
        'BrushColorYellow
        '
        Me.BrushColorYellow.BackColor = System.Drawing.Color.Yellow
        Me.BrushColorYellow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrushColorYellow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BrushColorYellow.Location = New System.Drawing.Point(150, 68)
        Me.BrushColorYellow.Name = "BrushColorYellow"
        Me.BrushColorYellow.Size = New System.Drawing.Size(23, 18)
        Me.BrushColorYellow.TabIndex = 7
        Me.BrushColorYellow.UseVisualStyleBackColor = False
        '
        'BrushColorBlue
        '
        Me.BrushColorBlue.BackColor = System.Drawing.Color.Blue
        Me.BrushColorBlue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrushColorBlue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BrushColorBlue.Location = New System.Drawing.Point(128, 102)
        Me.BrushColorBlue.Name = "BrushColorBlue"
        Me.BrushColorBlue.Size = New System.Drawing.Size(23, 18)
        Me.BrushColorBlue.TabIndex = 6
        Me.BrushColorBlue.UseVisualStyleBackColor = False
        '
        'BrushColorGreen
        '
        Me.BrushColorGreen.BackColor = System.Drawing.Color.Lime
        Me.BrushColorGreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrushColorGreen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BrushColorGreen.Location = New System.Drawing.Point(128, 85)
        Me.BrushColorGreen.Name = "BrushColorGreen"
        Me.BrushColorGreen.Size = New System.Drawing.Size(23, 18)
        Me.BrushColorGreen.TabIndex = 5
        Me.BrushColorGreen.UseVisualStyleBackColor = False
        '
        'BrushColorRed
        '
        Me.BrushColorRed.BackColor = System.Drawing.Color.Red
        Me.BrushColorRed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrushColorRed.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BrushColorRed.Location = New System.Drawing.Point(128, 68)
        Me.BrushColorRed.Name = "BrushColorRed"
        Me.BrushColorRed.Size = New System.Drawing.Size(23, 18)
        Me.BrushColorRed.TabIndex = 4
        Me.BrushColorRed.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Brush Color:"
        '
        'BrushPreview
        '
        Me.BrushPreview.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BrushPreview.Location = New System.Drawing.Point(10, 226)
        Me.BrushPreview.Name = "BrushPreview"
        Me.BrushPreview.Size = New System.Drawing.Size(222, 222)
        Me.BrushPreview.TabIndex = 2
        Me.BrushPreview.TabStop = False
        '
        'BrushSize
        '
        Me.BrushSize.Items.Add("1")
        Me.BrushSize.Items.Add("2")
        Me.BrushSize.Items.Add("3")
        Me.BrushSize.Items.Add("4")
        Me.BrushSize.Items.Add("5")
        Me.BrushSize.Items.Add("6")
        Me.BrushSize.Items.Add("7")
        Me.BrushSize.Items.Add("8")
        Me.BrushSize.Items.Add("9")
        Me.BrushSize.Items.Add("10")
        Me.BrushSize.Items.Add("11")
        Me.BrushSize.Items.Add("12")
        Me.BrushSize.Items.Add("13")
        Me.BrushSize.Items.Add("14")
        Me.BrushSize.Items.Add("15")
        Me.BrushSize.Items.Add("16")
        Me.BrushSize.Items.Add("17")
        Me.BrushSize.Items.Add("18")
        Me.BrushSize.Items.Add("19")
        Me.BrushSize.Items.Add("20")
        Me.BrushSize.Items.Add("21")
        Me.BrushSize.Items.Add("22")
        Me.BrushSize.Items.Add("23")
        Me.BrushSize.Items.Add("24")
        Me.BrushSize.Items.Add("25")
        Me.BrushSize.Items.Add("26")
        Me.BrushSize.Items.Add("27")
        Me.BrushSize.Items.Add("28")
        Me.BrushSize.Items.Add("29")
        Me.BrushSize.Items.Add("30")
        Me.BrushSize.Items.Add("32")
        Me.BrushSize.Items.Add("34")
        Me.BrushSize.Items.Add("36")
        Me.BrushSize.Items.Add("38")
        Me.BrushSize.Items.Add("40")
        Me.BrushSize.Items.Add("43")
        Me.BrushSize.Items.Add("46")
        Me.BrushSize.Items.Add("49")
        Me.BrushSize.Items.Add("53")
        Me.BrushSize.Items.Add("57")
        Me.BrushSize.Items.Add("61")
        Me.BrushSize.Items.Add("65")
        Me.BrushSize.Items.Add("70")
        Me.BrushSize.Items.Add("75")
        Me.BrushSize.Items.Add("80")
        Me.BrushSize.Items.Add("85")
        Me.BrushSize.Items.Add("90")
        Me.BrushSize.Items.Add("100")
        Me.BrushSize.Items.Add("110")
        Me.BrushSize.Items.Add("120")
        Me.BrushSize.Items.Add("130")
        Me.BrushSize.Items.Add("140")
        Me.BrushSize.Items.Add("150")
        Me.BrushSize.Items.Add("160")
        Me.BrushSize.Items.Add("170")
        Me.BrushSize.Items.Add("180")
        Me.BrushSize.Items.Add("190")
        Me.BrushSize.Items.Add("200")
        Me.BrushSize.Location = New System.Drawing.Point(133, 29)
        Me.BrushSize.Name = "BrushSize"
        Me.BrushSize.Size = New System.Drawing.Size(49, 22)
        Me.BrushSize.TabIndex = 1
        Me.BrushSize.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Brush Size:"
        '
        'HorizontalDivider
        '
        Me.HorizontalDivider.BackColor = System.Drawing.Color.Black
        Me.HorizontalDivider.Location = New System.Drawing.Point(0, 27)
        Me.HorizontalDivider.Name = "HorizontalDivider"
        Me.HorizontalDivider.Size = New System.Drawing.Size(697, 1)
        Me.HorizontalDivider.TabIndex = 4
        '
        'PictureBoxBackground
        '
        Me.PictureBoxBackground.BackColor = System.Drawing.Color.DimGray
        Me.PictureBoxBackground.Location = New System.Drawing.Point(0, 27)
        Me.PictureBoxBackground.Name = "PictureBoxBackground"
        Me.PictureBoxBackground.Size = New System.Drawing.Size(697, 485)
        Me.PictureBoxBackground.TabIndex = 5
        '
        'VerticalDivider
        '
        Me.VerticalDivider.BackColor = System.Drawing.Color.Black
        Me.VerticalDivider.Location = New System.Drawing.Point(696, 0)
        Me.VerticalDivider.Name = "VerticalDivider"
        Me.VerticalDivider.Size = New System.Drawing.Size(1, 536)
        Me.VerticalDivider.TabIndex = 0
        '
        'NewShortcut
        '
        Me.NewShortcut.BackgroundImage = CType(resources.GetObject("NewShortcut.BackgroundImage"), System.Drawing.Image)
        Me.NewShortcut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.NewShortcut.Location = New System.Drawing.Point(643, 0)
        Me.NewShortcut.Name = "NewShortcut"
        Me.NewShortcut.Size = New System.Drawing.Size(27, 27)
        Me.NewShortcut.TabIndex = 6
        Me.NewShortcut.UseVisualStyleBackColor = True
        '
        'CloseShortcut
        '
        Me.CloseShortcut.BackgroundImage = CType(resources.GetObject("CloseShortcut.BackgroundImage"), System.Drawing.Image)
        Me.CloseShortcut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CloseShortcut.Location = New System.Drawing.Point(669, 0)
        Me.CloseShortcut.Name = "CloseShortcut"
        Me.CloseShortcut.Size = New System.Drawing.Size(27, 27)
        Me.CloseShortcut.TabIndex = 9
        Me.CloseShortcut.UseVisualStyleBackColor = True
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 536)
        Me.Controls.Add(Me.CloseShortcut)
        Me.Controls.Add(Me.NewShortcut)
        Me.Controls.Add(Me.VerticalDivider)
        Me.Controls.Add(Me.HorizontalDivider)
        Me.Controls.Add(Me.PaintToolsPanel)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.Image)
        Me.Controls.Add(Me.PictureBoxBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "MainWindow"
        Me.Text = "VB.Paint"
        CType(Me.Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.PaintToolsPanel.ResumeLayout(False)
        Me.PaintToolsPanel.PerformLayout()
        CType(Me.BrushPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Image As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaintToolsPanel As System.Windows.Forms.Panel
    Friend WithEvents HorizontalDivider As System.Windows.Forms.Panel
    Friend WithEvents VerticalDivider As System.Windows.Forms.Panel
    Friend WithEvents PictureBoxBackground As System.Windows.Forms.Panel
    Friend WithEvents NewShortcut As System.Windows.Forms.Button
    Friend WithEvents CloseShortcut As System.Windows.Forms.Button
    Friend WithEvents BrushSize As System.Windows.Forms.DomainUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BrushPreview As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BrushColorOrange As System.Windows.Forms.Button
    Friend WithEvents BrushColorWhite As System.Windows.Forms.Button
    Friend WithEvents BrushColorBlack As System.Windows.Forms.Button
    Friend WithEvents BrushColorCyan As System.Windows.Forms.Button
    Friend WithEvents BrushColorMagenta As System.Windows.Forms.Button
    Friend WithEvents BrushColorYellow As System.Windows.Forms.Button
    Friend WithEvents BrushColorBlue As System.Windows.Forms.Button
    Friend WithEvents BrushColorGreen As System.Windows.Forms.Button
    Friend WithEvents BrushColorRed As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents HelpButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutButton As System.Windows.Forms.ToolStripMenuItem

End Class
