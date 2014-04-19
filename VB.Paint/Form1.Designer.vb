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
        Me.BrushColorOrange = New System.Windows.Forms.Button
        Me.NewShortcut = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.VerticalDivider = New System.Windows.Forms.Panel
        Me.BrushColorWhite = New System.Windows.Forms.Button
        Me.HorizontalDivider = New System.Windows.Forms.Panel
        Me.BrushColorBlack = New System.Windows.Forms.Button
        Me.PaintToolsPanel = New System.Windows.Forms.Panel
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
        Me.Image = New System.Windows.Forms.PictureBox
        Me.PictureBoxBackground = New System.Windows.Forms.Panel
        Me.AboutButton = New System.Windows.Forms.ToolStripMenuItem
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.NewButton = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenButton = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseButton = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitButton = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.HelpBtn = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseShortcut = New System.Windows.Forms.Button
        Me.OpenShortcut = New System.Windows.Forms.Button
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.PaintToolsPanel.SuspendLayout()
        CType(Me.BrushPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'BrushColorOrange
        '
        Me.BrushColorOrange.BackColor = System.Drawing.Color.Orange
        Me.BrushColorOrange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrushColorOrange.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BrushColorOrange.Location = New System.Drawing.Point(172, 112)
        Me.BrushColorOrange.Name = "BrushColorOrange"
        Me.BrushColorOrange.Size = New System.Drawing.Size(23, 18)
        Me.BrushColorOrange.TabIndex = 12
        Me.BrushColorOrange.UseVisualStyleBackColor = False
        '
        'NewShortcut
        '
        Me.NewShortcut.BackgroundImage = CType(resources.GetObject("NewShortcut.BackgroundImage"), System.Drawing.Image)
        Me.NewShortcut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.NewShortcut.Location = New System.Drawing.Point(611, 0)
        Me.NewShortcut.Name = "NewShortcut"
        Me.NewShortcut.Size = New System.Drawing.Size(28, 28)
        Me.NewShortcut.TabIndex = 17
        Me.NewShortcut.UseVisualStyleBackColor = True
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
        'VerticalDivider
        '
        Me.VerticalDivider.BackColor = System.Drawing.Color.Black
        Me.VerticalDivider.Location = New System.Drawing.Point(692, -4)
        Me.VerticalDivider.Name = "VerticalDivider"
        Me.VerticalDivider.Size = New System.Drawing.Size(1, 536)
        Me.VerticalDivider.TabIndex = 10
        '
        'BrushColorWhite
        '
        Me.BrushColorWhite.BackColor = System.Drawing.Color.White
        Me.BrushColorWhite.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrushColorWhite.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BrushColorWhite.Location = New System.Drawing.Point(172, 95)
        Me.BrushColorWhite.Name = "BrushColorWhite"
        Me.BrushColorWhite.Size = New System.Drawing.Size(23, 18)
        Me.BrushColorWhite.TabIndex = 11
        Me.BrushColorWhite.UseVisualStyleBackColor = False
        '
        'HorizontalDivider
        '
        Me.HorizontalDivider.BackColor = System.Drawing.Color.Black
        Me.HorizontalDivider.Location = New System.Drawing.Point(-4, 23)
        Me.HorizontalDivider.Name = "HorizontalDivider"
        Me.HorizontalDivider.Size = New System.Drawing.Size(697, 1)
        Me.HorizontalDivider.TabIndex = 15
        '
        'BrushColorBlack
        '
        Me.BrushColorBlack.BackColor = System.Drawing.Color.Black
        Me.BrushColorBlack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrushColorBlack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BrushColorBlack.Location = New System.Drawing.Point(172, 78)
        Me.BrushColorBlack.Name = "BrushColorBlack"
        Me.BrushColorBlack.Size = New System.Drawing.Size(23, 18)
        Me.BrushColorBlack.TabIndex = 10
        Me.BrushColorBlack.UseVisualStyleBackColor = False
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
        Me.PaintToolsPanel.Location = New System.Drawing.Point(693, -4)
        Me.PaintToolsPanel.Name = "PaintToolsPanel"
        Me.PaintToolsPanel.Size = New System.Drawing.Size(244, 536)
        Me.PaintToolsPanel.TabIndex = 14
        '
        'BrushColorCyan
        '
        Me.BrushColorCyan.BackColor = System.Drawing.Color.Cyan
        Me.BrushColorCyan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrushColorCyan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BrushColorCyan.Location = New System.Drawing.Point(150, 112)
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
        Me.BrushColorMagenta.Location = New System.Drawing.Point(150, 95)
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
        Me.BrushColorYellow.Location = New System.Drawing.Point(150, 78)
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
        Me.BrushColorBlue.Location = New System.Drawing.Point(128, 112)
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
        Me.BrushColorGreen.Location = New System.Drawing.Point(128, 95)
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
        Me.BrushColorRed.Location = New System.Drawing.Point(128, 78)
        Me.BrushColorRed.Name = "BrushColorRed"
        Me.BrushColorRed.Size = New System.Drawing.Size(23, 18)
        Me.BrushColorRed.TabIndex = 4
        Me.BrushColorRed.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 98)
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
        Me.BrushSize.Location = New System.Drawing.Point(133, 39)
        Me.BrushSize.Name = "BrushSize"
        Me.BrushSize.Size = New System.Drawing.Size(49, 22)
        Me.BrushSize.TabIndex = 1
        Me.BrushSize.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Brush Size:"
        '
        'Image
        '
        Me.Image.BackColor = System.Drawing.Color.Silver
        Me.Image.Enabled = False
        Me.Image.Location = New System.Drawing.Point(8, 29)
        Me.Image.Name = "Image"
        Me.Image.Size = New System.Drawing.Size(673, 473)
        Me.Image.TabIndex = 11
        Me.Image.TabStop = False
        '
        'PictureBoxBackground
        '
        Me.PictureBoxBackground.BackColor = System.Drawing.Color.DimGray
        Me.PictureBoxBackground.Location = New System.Drawing.Point(-4, 23)
        Me.PictureBoxBackground.Name = "PictureBoxBackground"
        Me.PictureBoxBackground.Size = New System.Drawing.Size(697, 485)
        Me.PictureBoxBackground.TabIndex = 16
        '
        'AboutButton
        '
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AboutButton.Size = New System.Drawing.Size(62, 24)
        Me.AboutButton.Text = "About"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewButton, Me.OpenButton, Me.CloseButton, Me.ExitButton})
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
        'OpenButton
        '
        Me.OpenButton.Enabled = False
        Me.OpenButton.Name = "OpenButton"
        Me.OpenButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenButton.Size = New System.Drawing.Size(171, 24)
        Me.OpenButton.Text = "Open"
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
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 503)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(933, 25)
        Me.StatusStrip.TabIndex = 12
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
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.HelpBtn, Me.AboutButton})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(933, 28)
        Me.MenuStrip.TabIndex = 13
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'HelpBtn
        '
        Me.HelpBtn.Name = "HelpBtn"
        Me.HelpBtn.Size = New System.Drawing.Size(53, 24)
        Me.HelpBtn.Text = "Help"
        '
        'CloseShortcut
        '
        Me.CloseShortcut.BackgroundImage = CType(resources.GetObject("CloseShortcut.BackgroundImage"), System.Drawing.Image)
        Me.CloseShortcut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CloseShortcut.Location = New System.Drawing.Point(665, 0)
        Me.CloseShortcut.Name = "CloseShortcut"
        Me.CloseShortcut.Size = New System.Drawing.Size(28, 28)
        Me.CloseShortcut.TabIndex = 18
        Me.CloseShortcut.UseVisualStyleBackColor = True
        '
        'OpenShortcut
        '
        Me.OpenShortcut.BackgroundImage = CType(resources.GetObject("OpenShortcut.BackgroundImage"), System.Drawing.Image)
        Me.OpenShortcut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.OpenShortcut.Enabled = False
        Me.OpenShortcut.Location = New System.Drawing.Point(638, 0)
        Me.OpenShortcut.Name = "OpenShortcut"
        Me.OpenShortcut.Size = New System.Drawing.Size(28, 28)
        Me.OpenShortcut.TabIndex = 19
        Me.OpenShortcut.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 528)
        Me.Controls.Add(Me.OpenShortcut)
        Me.Controls.Add(Me.NewShortcut)
        Me.Controls.Add(Me.CloseShortcut)
        Me.Controls.Add(Me.PaintToolsPanel)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.VerticalDivider)
        Me.Controls.Add(Me.HorizontalDivider)
        Me.Controls.Add(Me.Image)
        Me.Controls.Add(Me.PictureBoxBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainWindow"
        Me.Text = "VB.Paint"
        Me.PaintToolsPanel.ResumeLayout(False)
        Me.PaintToolsPanel.PerformLayout()
        CType(Me.BrushPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BrushColorOrange As System.Windows.Forms.Button
    Friend WithEvents NewShortcut As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents VerticalDivider As System.Windows.Forms.Panel
    Friend WithEvents BrushColorWhite As System.Windows.Forms.Button
    Friend WithEvents HorizontalDivider As System.Windows.Forms.Panel
    Friend WithEvents BrushColorBlack As System.Windows.Forms.Button
    Friend WithEvents PaintToolsPanel As System.Windows.Forms.Panel
    Friend WithEvents BrushColorCyan As System.Windows.Forms.Button
    Friend WithEvents BrushColorMagenta As System.Windows.Forms.Button
    Friend WithEvents BrushColorYellow As System.Windows.Forms.Button
    Friend WithEvents BrushColorBlue As System.Windows.Forms.Button
    Friend WithEvents BrushColorGreen As System.Windows.Forms.Button
    Friend WithEvents BrushColorRed As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BrushPreview As System.Windows.Forms.PictureBox
    Friend WithEvents BrushSize As System.Windows.Forms.DomainUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Image As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxBackground As System.Windows.Forms.Panel
    Friend WithEvents AboutButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents CloseShortcut As System.Windows.Forms.Button
    Friend WithEvents HelpBtn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenShortcut As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
End Class
