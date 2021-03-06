﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.PaintToolsPanel = New System.Windows.Forms.Panel
        Me.BrushShapeToLineButton = New System.Windows.Forms.Button
        Me.BrushModeToTool = New System.Windows.Forms.RadioButton
        Me.BrushModeToBrush = New System.Windows.Forms.RadioButton
        Me.FontButton = New System.Windows.Forms.Button
        Me.TextToDrawBox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.BrushShapeToTextButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.BrushShapeToSquareButton = New System.Windows.Forms.Button
        Me.BrushShapeToCircleButton = New System.Windows.Forms.Button
        Me.Blue = New System.Windows.Forms.NumericUpDown
        Me.Green = New System.Windows.Forms.NumericUpDown
        Me.Red = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.BrushPreview = New System.Windows.Forms.PictureBox
        Me.BrushSize = New System.Windows.Forms.DomainUpDown
        Me.Label2 = New System.Windows.Forms.Label
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
        Me.RGBColorChartButton = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseShortcut = New System.Windows.Forms.Button
        Me.OpenShortcut = New System.Windows.Forms.Button
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.SaveShortcut = New System.Windows.Forms.Button
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.FontDialog = New System.Windows.Forms.FontDialog
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
        Me.NewShortcut.Location = New System.Drawing.Point(427, 0)
        Me.NewShortcut.Margin = New System.Windows.Forms.Padding(2)
        Me.NewShortcut.Name = "NewShortcut"
        Me.NewShortcut.Size = New System.Drawing.Size(24, 24)
        Me.NewShortcut.TabIndex = 17
        Me.NewShortcut.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 237)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Preview Brush:"
        '
        'PaintToolsPanel
        '
        Me.PaintToolsPanel.BackColor = System.Drawing.Color.White
        Me.PaintToolsPanel.Controls.Add(Me.BrushShapeToLineButton)
        Me.PaintToolsPanel.Controls.Add(Me.BrushModeToTool)
        Me.PaintToolsPanel.Controls.Add(Me.BrushModeToBrush)
        Me.PaintToolsPanel.Controls.Add(Me.FontButton)
        Me.PaintToolsPanel.Controls.Add(Me.TextToDrawBox)
        Me.PaintToolsPanel.Controls.Add(Me.Label4)
        Me.PaintToolsPanel.Controls.Add(Me.BrushShapeToTextButton)
        Me.PaintToolsPanel.Controls.Add(Me.Label1)
        Me.PaintToolsPanel.Controls.Add(Me.BrushShapeToSquareButton)
        Me.PaintToolsPanel.Controls.Add(Me.BrushShapeToCircleButton)
        Me.PaintToolsPanel.Controls.Add(Me.Blue)
        Me.PaintToolsPanel.Controls.Add(Me.Green)
        Me.PaintToolsPanel.Controls.Add(Me.Red)
        Me.PaintToolsPanel.Controls.Add(Me.Label5)
        Me.PaintToolsPanel.Controls.Add(Me.Label3)
        Me.PaintToolsPanel.Controls.Add(Me.BrushPreview)
        Me.PaintToolsPanel.Controls.Add(Me.BrushSize)
        Me.PaintToolsPanel.Controls.Add(Me.Label2)
        Me.PaintToolsPanel.Location = New System.Drawing.Point(520, -3)
        Me.PaintToolsPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.PaintToolsPanel.Name = "PaintToolsPanel"
        Me.PaintToolsPanel.Size = New System.Drawing.Size(193, 450)
        Me.PaintToolsPanel.TabIndex = 14
        '
        'BrushShapeToLineButton
        '
        Me.BrushShapeToLineButton.BackgroundImage = CType(resources.GetObject("BrushShapeToLineButton.BackgroundImage"), System.Drawing.Image)
        Me.BrushShapeToLineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BrushShapeToLineButton.Location = New System.Drawing.Point(134, 46)
        Me.BrushShapeToLineButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BrushShapeToLineButton.Name = "BrushShapeToLineButton"
        Me.BrushShapeToLineButton.Size = New System.Drawing.Size(25, 25)
        Me.BrushShapeToLineButton.TabIndex = 26
        Me.BrushShapeToLineButton.UseVisualStyleBackColor = True
        Me.BrushShapeToLineButton.Visible = False
        '
        'BrushModeToTool
        '
        Me.BrushModeToTool.AutoSize = True
        Me.BrushModeToTool.Enabled = False
        Me.BrushModeToTool.Location = New System.Drawing.Point(101, 15)
        Me.BrushModeToTool.Name = "BrushModeToTool"
        Me.BrushModeToTool.Size = New System.Drawing.Size(46, 17)
        Me.BrushModeToTool.TabIndex = 25
        Me.BrushModeToTool.Text = "Tool"
        Me.BrushModeToTool.UseVisualStyleBackColor = True
        '
        'BrushModeToBrush
        '
        Me.BrushModeToBrush.AutoSize = True
        Me.BrushModeToBrush.Checked = True
        Me.BrushModeToBrush.Enabled = False
        Me.BrushModeToBrush.Location = New System.Drawing.Point(43, 15)
        Me.BrushModeToBrush.Name = "BrushModeToBrush"
        Me.BrushModeToBrush.Size = New System.Drawing.Size(52, 17)
        Me.BrushModeToBrush.TabIndex = 24
        Me.BrushModeToBrush.TabStop = True
        Me.BrushModeToBrush.Text = "Brush"
        Me.BrushModeToBrush.UseVisualStyleBackColor = True
        '
        'FontButton
        '
        Me.FontButton.Location = New System.Drawing.Point(61, 90)
        Me.FontButton.Name = "FontButton"
        Me.FontButton.Size = New System.Drawing.Size(63, 25)
        Me.FontButton.TabIndex = 23
        Me.FontButton.Text = "Text Font"
        Me.FontButton.UseVisualStyleBackColor = True
        Me.FontButton.Visible = False
        '
        'TextToDrawBox
        '
        Me.TextToDrawBox.Enabled = False
        Me.TextToDrawBox.Location = New System.Drawing.Point(39, 198)
        Me.TextToDrawBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TextToDrawBox.Name = "TextToDrawBox"
        Me.TextToDrawBox.Size = New System.Drawing.Size(136, 20)
        Me.TextToDrawBox.TabIndex = 22
        Me.TextToDrawBox.Text = "text"
        Me.TextToDrawBox.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 201)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Text:"
        Me.Label4.Visible = False
        '
        'BrushShapeToTextButton
        '
        Me.BrushShapeToTextButton.BackgroundImage = CType(resources.GetObject("BrushShapeToTextButton.BackgroundImage"), System.Drawing.Image)
        Me.BrushShapeToTextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BrushShapeToTextButton.Location = New System.Drawing.Point(134, 46)
        Me.BrushShapeToTextButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BrushShapeToTextButton.Name = "BrushShapeToTextButton"
        Me.BrushShapeToTextButton.Size = New System.Drawing.Size(25, 25)
        Me.BrushShapeToTextButton.TabIndex = 20
        Me.BrushShapeToTextButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Brush Shape:"
        '
        'BrushShapeToSquareButton
        '
        Me.BrushShapeToSquareButton.BackgroundImage = CType(resources.GetObject("BrushShapeToSquareButton.BackgroundImage"), System.Drawing.Image)
        Me.BrushShapeToSquareButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BrushShapeToSquareButton.Location = New System.Drawing.Point(110, 46)
        Me.BrushShapeToSquareButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BrushShapeToSquareButton.Name = "BrushShapeToSquareButton"
        Me.BrushShapeToSquareButton.Size = New System.Drawing.Size(25, 25)
        Me.BrushShapeToSquareButton.TabIndex = 18
        Me.BrushShapeToSquareButton.UseVisualStyleBackColor = True
        '
        'BrushShapeToCircleButton
        '
        Me.BrushShapeToCircleButton.BackgroundImage = CType(resources.GetObject("BrushShapeToCircleButton.BackgroundImage"), System.Drawing.Image)
        Me.BrushShapeToCircleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BrushShapeToCircleButton.Enabled = False
        Me.BrushShapeToCircleButton.Location = New System.Drawing.Point(86, 46)
        Me.BrushShapeToCircleButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BrushShapeToCircleButton.Name = "BrushShapeToCircleButton"
        Me.BrushShapeToCircleButton.Size = New System.Drawing.Size(25, 25)
        Me.BrushShapeToCircleButton.TabIndex = 17
        Me.BrushShapeToCircleButton.UseVisualStyleBackColor = True
        '
        'Blue
        '
        Me.Blue.BackColor = System.Drawing.Color.Blue
        Me.Blue.ForeColor = System.Drawing.Color.Yellow
        Me.Blue.Location = New System.Drawing.Point(100, 161)
        Me.Blue.Margin = New System.Windows.Forms.Padding(2)
        Me.Blue.Name = "Blue"
        Me.Blue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Blue.Size = New System.Drawing.Size(41, 20)
        Me.Blue.TabIndex = 16
        Me.Blue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Green
        '
        Me.Green.BackColor = System.Drawing.Color.Lime
        Me.Green.ForeColor = System.Drawing.Color.Magenta
        Me.Green.Location = New System.Drawing.Point(100, 144)
        Me.Green.Margin = New System.Windows.Forms.Padding(2)
        Me.Green.Name = "Green"
        Me.Green.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Green.Size = New System.Drawing.Size(41, 20)
        Me.Green.TabIndex = 15
        Me.Green.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Red
        '
        Me.Red.BackColor = System.Drawing.Color.Red
        Me.Red.ForeColor = System.Drawing.Color.Cyan
        Me.Red.Location = New System.Drawing.Point(100, 127)
        Me.Red.Margin = New System.Windows.Forms.Padding(2)
        Me.Red.Name = "Red"
        Me.Red.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Red.Size = New System.Drawing.Size(41, 20)
        Me.Red.TabIndex = 14
        Me.Red.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 146)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Brush Color:"
        '
        'BrushPreview
        '
        Me.BrushPreview.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BrushPreview.Location = New System.Drawing.Point(11, 256)
        Me.BrushPreview.Margin = New System.Windows.Forms.Padding(2)
        Me.BrushPreview.Name = "BrushPreview"
        Me.BrushPreview.Size = New System.Drawing.Size(166, 166)
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
        Me.BrushSize.Location = New System.Drawing.Point(100, 94)
        Me.BrushSize.Margin = New System.Windows.Forms.Padding(2)
        Me.BrushSize.Name = "BrushSize"
        Me.BrushSize.Size = New System.Drawing.Size(41, 20)
        Me.BrushSize.TabIndex = 1
        Me.BrushSize.Text = "1"
        Me.BrushSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Brush Size:"
        '
        'Image
        '
        Me.Image.BackColor = System.Drawing.Color.Silver
        Me.Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Image.Enabled = False
        Me.Image.Location = New System.Drawing.Point(7, 28)
        Me.Image.Margin = New System.Windows.Forms.Padding(2)
        Me.Image.Name = "Image"
        Me.Image.Size = New System.Drawing.Size(505, 384)
        Me.Image.TabIndex = 11
        Me.Image.TabStop = False
        '
        'PictureBoxBackground
        '
        Me.PictureBoxBackground.BackColor = System.Drawing.Color.DimGray
        Me.PictureBoxBackground.Location = New System.Drawing.Point(-13, 19)
        Me.PictureBoxBackground.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBoxBackground.Name = "PictureBoxBackground"
        Me.PictureBoxBackground.Size = New System.Drawing.Size(539, 407)
        Me.PictureBoxBackground.TabIndex = 16
        '
        'AboutButton
        '
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AboutButton.Size = New System.Drawing.Size(52, 20)
        Me.AboutButton.Text = "About"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewButton, Me.OpenButton, Me.SaveButton, Me.CloseButton, Me.ExitButton})
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(37, 20)
        Me.FileMenu.Text = "File"
        '
        'NewButton
        '
        Me.NewButton.Name = "NewButton"
        Me.NewButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewButton.Size = New System.Drawing.Size(149, 22)
        Me.NewButton.Text = "New"
        '
        'OpenButton
        '
        Me.OpenButton.Enabled = False
        Me.OpenButton.Name = "OpenButton"
        Me.OpenButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenButton.Size = New System.Drawing.Size(149, 22)
        Me.OpenButton.Text = "Open"
        '
        'SaveButton
        '
        Me.SaveButton.Enabled = False
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveButton.Size = New System.Drawing.Size(149, 22)
        Me.SaveButton.Text = "Save"
        '
        'CloseButton
        '
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseButton.Size = New System.Drawing.Size(149, 22)
        Me.CloseButton.Text = "Close"
        '
        'ExitButton
        '
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitButton.Size = New System.Drawing.Size(149, 22)
        Me.ExitButton.Text = "Exit"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 415)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(706, 22)
        Me.StatusStrip.TabIndex = 12
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.StatusLabel.Text = "Ready"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.HelpMenu, Me.AboutButton})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(706, 24)
        Me.MenuStrip.TabIndex = 13
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewReadmeButton, Me.RGBColorChartButton})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.HelpMenu.Text = "Help"
        '
        'ViewReadmeButton
        '
        Me.ViewReadmeButton.Name = "ViewReadmeButton"
        Me.ViewReadmeButton.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.ViewReadmeButton.Size = New System.Drawing.Size(211, 22)
        Me.ViewReadmeButton.Text = "Readme"
        '
        'RGBColorChartButton
        '
        Me.RGBColorChartButton.Name = "RGBColorChartButton"
        Me.RGBColorChartButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.RGBColorChartButton.Size = New System.Drawing.Size(211, 22)
        Me.RGBColorChartButton.Text = "RGB Color Chart"
        '
        'CloseShortcut
        '
        Me.CloseShortcut.BackgroundImage = CType(resources.GetObject("CloseShortcut.BackgroundImage"), System.Drawing.Image)
        Me.CloseShortcut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CloseShortcut.Location = New System.Drawing.Point(496, 0)
        Me.CloseShortcut.Margin = New System.Windows.Forms.Padding(2)
        Me.CloseShortcut.Name = "CloseShortcut"
        Me.CloseShortcut.Size = New System.Drawing.Size(24, 24)
        Me.CloseShortcut.TabIndex = 18
        Me.CloseShortcut.UseVisualStyleBackColor = True
        '
        'OpenShortcut
        '
        Me.OpenShortcut.BackgroundImage = CType(resources.GetObject("OpenShortcut.BackgroundImage"), System.Drawing.Image)
        Me.OpenShortcut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.OpenShortcut.Enabled = False
        Me.OpenShortcut.Location = New System.Drawing.Point(450, 0)
        Me.OpenShortcut.Margin = New System.Windows.Forms.Padding(2)
        Me.OpenShortcut.Name = "OpenShortcut"
        Me.OpenShortcut.Size = New System.Drawing.Size(24, 24)
        Me.OpenShortcut.TabIndex = 19
        Me.OpenShortcut.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        Me.OpenFileDialog.Title = "Open Image"
        '
        'SaveShortcut
        '
        Me.SaveShortcut.BackgroundImage = CType(resources.GetObject("SaveShortcut.BackgroundImage"), System.Drawing.Image)
        Me.SaveShortcut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SaveShortcut.Enabled = False
        Me.SaveShortcut.Location = New System.Drawing.Point(473, 0)
        Me.SaveShortcut.Margin = New System.Windows.Forms.Padding(2)
        Me.SaveShortcut.Name = "SaveShortcut"
        Me.SaveShortcut.Size = New System.Drawing.Size(24, 24)
        Me.SaveShortcut.TabIndex = 20
        Me.SaveShortcut.UseVisualStyleBackColor = True
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.Title = "Save Drawing"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 437)
        Me.Controls.Add(Me.SaveShortcut)
        Me.Controls.Add(Me.OpenShortcut)
        Me.Controls.Add(Me.NewShortcut)
        Me.Controls.Add(Me.CloseShortcut)
        Me.Controls.Add(Me.PaintToolsPanel)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.Image)
        Me.Controls.Add(Me.PictureBoxBackground)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(722, 475)
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PaintToolsPanel As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BrushPreview As System.Windows.Forms.PictureBox
    Friend WithEvents BrushSize As System.Windows.Forms.DomainUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
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
    Friend WithEvents BrushShapeToSquareButton As System.Windows.Forms.Button
    Friend WithEvents BrushShapeToCircleButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BrushShapeToTextButton As System.Windows.Forms.Button
    Friend WithEvents TextToDrawBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FontButton As System.Windows.Forms.Button
    Friend WithEvents FontDialog As System.Windows.Forms.FontDialog
    Friend WithEvents BrushModeToTool As System.Windows.Forms.RadioButton
    Friend WithEvents BrushModeToBrush As System.Windows.Forms.RadioButton
    Friend WithEvents BrushShapeToLineButton As System.Windows.Forms.Button
End Class
