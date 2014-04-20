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
        Me.NewShortcut = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.VerticalDivider = New System.Windows.Forms.Panel
        Me.HorizontalDivider = New System.Windows.Forms.Panel
        Me.PaintToolsPanel = New System.Windows.Forms.Panel
        Me.Blue = New System.Windows.Forms.NumericUpDown
        Me.Green = New System.Windows.Forms.NumericUpDown
        Me.Red = New System.Windows.Forms.NumericUpDown
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
        Me.SaveButton = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseButton = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitButton = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewReadmeButton = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseShortcut = New System.Windows.Forms.Button
        Me.OpenShortcut = New System.Windows.Forms.Button
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.SaveShortcut = New System.Windows.Forms.Button
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.RGBColorChartButton = New System.Windows.Forms.ToolStripMenuItem
        Me.PaintToolsPanel.SuspendLayout()
        CType(Me.Blue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Green, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Red, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrushPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'NewShortcut
        '
        Me.NewShortcut.BackgroundImage = CType(resources.GetObject("NewShortcut.BackgroundImage"), System.Drawing.Image)
        Me.NewShortcut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.NewShortcut.Location = New System.Drawing.Point(584, 0)
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
        'HorizontalDivider
        '
        Me.HorizontalDivider.BackColor = System.Drawing.Color.Black
        Me.HorizontalDivider.Location = New System.Drawing.Point(-4, 23)
        Me.HorizontalDivider.Name = "HorizontalDivider"
        Me.HorizontalDivider.Size = New System.Drawing.Size(697, 1)
        Me.HorizontalDivider.TabIndex = 15
        '
        'PaintToolsPanel
        '
        Me.PaintToolsPanel.BackColor = System.Drawing.Color.White
        Me.PaintToolsPanel.Controls.Add(Me.Blue)
        Me.PaintToolsPanel.Controls.Add(Me.Green)
        Me.PaintToolsPanel.Controls.Add(Me.Red)
        Me.PaintToolsPanel.Controls.Add(Me.Label3)
        Me.PaintToolsPanel.Controls.Add(Me.Label2)
        Me.PaintToolsPanel.Controls.Add(Me.BrushPreview)
        Me.PaintToolsPanel.Controls.Add(Me.BrushSize)
        Me.PaintToolsPanel.Controls.Add(Me.Label1)
        Me.PaintToolsPanel.Location = New System.Drawing.Point(693, -4)
        Me.PaintToolsPanel.Name = "PaintToolsPanel"
        Me.PaintToolsPanel.Size = New System.Drawing.Size(244, 536)
        Me.PaintToolsPanel.TabIndex = 14
        '
        'Blue
        '
        Me.Blue.BackColor = System.Drawing.Color.Blue
        Me.Blue.ForeColor = System.Drawing.Color.Yellow
        Me.Blue.Location = New System.Drawing.Point(133, 122)
        Me.Blue.Name = "Blue"
        Me.Blue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Blue.Size = New System.Drawing.Size(49, 22)
        Me.Blue.TabIndex = 16
        Me.Blue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Green
        '
        Me.Green.BackColor = System.Drawing.Color.Lime
        Me.Green.ForeColor = System.Drawing.Color.Magenta
        Me.Green.Location = New System.Drawing.Point(133, 101)
        Me.Green.Name = "Green"
        Me.Green.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Green.Size = New System.Drawing.Size(49, 22)
        Me.Green.TabIndex = 15
        Me.Green.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Red
        '
        Me.Red.BackColor = System.Drawing.Color.Red
        Me.Red.ForeColor = System.Drawing.Color.Cyan
        Me.Red.Location = New System.Drawing.Point(133, 80)
        Me.Red.Name = "Red"
        Me.Red.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Red.Size = New System.Drawing.Size(49, 22)
        Me.Red.TabIndex = 14
        Me.Red.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 103)
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
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewButton, Me.OpenButton, Me.SaveButton, Me.CloseButton, Me.ExitButton})
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
        'SaveButton
        '
        Me.SaveButton.Enabled = False
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveButton.Size = New System.Drawing.Size(171, 24)
        Me.SaveButton.Text = "Save"
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
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.HelpMenu, Me.AboutButton})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(933, 28)
        Me.MenuStrip.TabIndex = 13
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewReadmeButton, Me.RGBColorChartButton})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(53, 24)
        Me.HelpMenu.Text = "Help"
        '
        'ViewReadmeButton
        '
        Me.ViewReadmeButton.Name = "ViewReadmeButton"
        Me.ViewReadmeButton.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.ViewReadmeButton.Size = New System.Drawing.Size(249, 24)
        Me.ViewReadmeButton.Text = "Readme"
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
        Me.OpenShortcut.Location = New System.Drawing.Point(611, 0)
        Me.OpenShortcut.Name = "OpenShortcut"
        Me.OpenShortcut.Size = New System.Drawing.Size(28, 28)
        Me.OpenShortcut.TabIndex = 19
        Me.OpenShortcut.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'SaveShortcut
        '
        Me.SaveShortcut.BackgroundImage = CType(resources.GetObject("SaveShortcut.BackgroundImage"), System.Drawing.Image)
        Me.SaveShortcut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SaveShortcut.Enabled = False
        Me.SaveShortcut.Location = New System.Drawing.Point(638, 0)
        Me.SaveShortcut.Name = "SaveShortcut"
        Me.SaveShortcut.Size = New System.Drawing.Size(28, 28)
        Me.SaveShortcut.TabIndex = 20
        Me.SaveShortcut.UseVisualStyleBackColor = True
        '
        'RGBColorChartButton
        '
        Me.RGBColorChartButton.Name = "RGBColorChartButton"
        Me.RGBColorChartButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.RGBColorChartButton.Size = New System.Drawing.Size(249, 24)
        Me.RGBColorChartButton.Text = "RGB Color Chart"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 528)
        Me.Controls.Add(Me.SaveShortcut)
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
        CType(Me.Blue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Green, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Red, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrushPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NewShortcut As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents VerticalDivider As System.Windows.Forms.Panel
    Friend WithEvents HorizontalDivider As System.Windows.Forms.Panel
    Friend WithEvents PaintToolsPanel As System.Windows.Forms.Panel
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
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenShortcut As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveShortcut As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Red As System.Windows.Forms.NumericUpDown
    Friend WithEvents Blue As System.Windows.Forms.NumericUpDown
    Friend WithEvents Green As System.Windows.Forms.NumericUpDown
    Friend WithEvents ViewReadmeButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RGBColorChartButton As System.Windows.Forms.ToolStripMenuItem
End Class
