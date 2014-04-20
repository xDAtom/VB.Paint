Public Class MainWindow
    Dim draw = False
    Dim brush = Brushes.Black
    Dim blackbrush = Brushes.Black
    Dim whitebrush = Brushes.White
    Dim controlbrush = Brushes.Silver
    Dim bgbrush = Brushes.CornflowerBlue

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StatusLabel.Text = "Initializing..."
        Me.Image.Image = New Bitmap(Me.Image.Width, Me.Image.Height)
        StatusLabel.Text = "Ready"
    End Sub

    Private Sub NewShortcut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewShortcut.Click
        StatusLabel.Text = "Creating New Drawing..."
        Image.CreateGraphics.FillRectangle(whitebrush, 0, 0, 673, 473)
        Image.Enabled = True
        Image.BackColor = Color.White
        OpenButton.Enabled = True
        OpenShortcut.Enabled = True
        SaveButton.Enabled = True
        SaveShortcut.Enabled = True
        StatusLabel.Text = "Ready"
    End Sub

    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click
        StatusLabel.Text = "Creating New Drawing..."
        Image.CreateGraphics.FillRectangle(whitebrush, 0, 0, 673, 473)
        Image.Enabled = True
        Image.BackColor = Color.White
        OpenButton.Enabled = True
        OpenShortcut.Enabled = True
        SaveButton.Enabled = True
        SaveShortcut.Enabled = True
        StatusLabel.Text = "Ready"
    End Sub

    Private Sub BrushSize_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrushSize.SelectedItemChanged
        StatusLabel.Text = "Changing Brush Size..."
        On Error GoTo brushsizehandler
        Dim pensize, coord As Single
        If BrushSize.Text = "" Then
            BrushSize.Text = "1"
        End If
        pensize = BrushSize.Text
        BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, 222, 222)
        coord = 111 - (pensize / 2)
        BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
        StatusLabel.Text = "Ready"
        Exit Sub
brushsizehandler:
        MsgBox("Crashed - String not accepted in Brush Size TextBox!", MsgBoxStyle.Critical, "Error")
        End
    End Sub

    Private Sub Image_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Image.MouseDown
        draw = True
    End Sub

    Private Sub Image_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Image.MouseMove
        On Error GoTo brushdrawhandler
        StatusLabel.Text = "Drawing..."
        Dim pensize As Single
        pensize = BrushSize.Text
        If draw = True Then
            Image.CreateGraphics.FillEllipse(brush, e.X - (pensize / 2), e.Y - (pensize / 2), pensize, pensize)
        End If
        StatusLabel.Text = "Ready"
        Exit Sub
brushdrawhandler:
        MsgBox("Crashed - String not accepted in Brush Size TextBox!", MsgBoxStyle.Critical, "Error")
        End
    End Sub

    Private Sub Image_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Image.MouseUp
        draw = False
    End Sub

    Private Sub BrushPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrushPreview.LoadCompleted
        StatusLabel.Text = "Initializing Brush..."
        brush = Brushes.Black
        BrushPreview.CreateGraphics.FillEllipse(brush, 110, 110, 1, 1)
        StatusLabel.Text = "Ready"
    End Sub

    Private Sub CloseShortcut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseShortcut.Click
        StatusLabel.Text = "Closing Drawing..."
        Image.CreateGraphics.FillRectangle(controlbrush, 0, 0, 673, 473)
        Image.BackgroundImage = Nothing
        Image.Image = Nothing
        Image.BackColor = Color.Silver
        Image.Enabled = False
        OpenButton.Enabled = False
        OpenShortcut.Enabled = False
        SaveButton.Enabled = False
        SaveShortcut.Enabled = False
        StatusLabel.Text = "Ready"
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        StatusLabel.Text = "Closing Drawing..."
        Image.CreateGraphics.FillRectangle(controlbrush, 0, 0, 673, 473)
        Image.BackgroundImage = Nothing
        Image.Image = Nothing
        Image.BackColor = Color.Silver
        Image.Enabled = False
        OpenButton.Enabled = False
        OpenShortcut.Enabled = False
        SaveButton.Enabled = False
        SaveShortcut.Enabled = False
        StatusLabel.Text = "Ready"
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        StatusLabel.Text = "Exiting..."
        End
    End Sub

    Private Sub HelpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpBtn.Click
        On Error GoTo 404
        StatusLabel.Text = "Starting readme..."
        System.Diagnostics.Process.Start("readme.txt")
        StatusLabel.Text = "Ready"
        Exit Sub
404:
        MsgBox("Cannot find readme.txt", MsgBoxStyle.SystemModal, "Error")
    End Sub

    Private Sub AboutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutButton.Click
        StatusLabel.Text = "Showing About Window..."
        Dim SecondForm As AboutBox1 = AboutBox1
        SecondForm.Show()
        StatusLabel.Text = "Ready"
    End Sub

    Private Sub OpenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenButton.Click
        On Error GoTo nonimage1
        If Image.Enabled = False Then
            OpenShortcut.Enabled = False
            OpenButton.Enabled = False
            Exit Sub
        End If
        StatusLabel.Text = "Opening Image..."
        OpenFileDialog.Filter = "All Files|*.*"
        OpenFileDialog.FileName = ""
        If OpenFileDialog.ShowDialog(Me) = DialogResult.OK Then
            Dim img As String = OpenFileDialog.FileName
            Image.BackgroundImage = System.Drawing.Bitmap.FromFile(img)
            Image.BackgroundImageLayout = ImageLayout.Stretch
        End If
        StatusLabel.Text = "Ready"
        Exit Sub
nonimage1:
        MsgBox("Please open an Image File.", MsgBoxStyle.Critical, "Error")
    End Sub

    Private Sub OpenShortcut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenShortcut.Click
        On Error GoTo nonimage2
        If Image.Enabled = False Then
            OpenButton.Enabled = False
            OpenShortcut.Enabled = False
            Exit Sub
        End If
        StatusLabel.Text = "Opening Image..."
        OpenFileDialog.Filter = "All Files|*.*"
        OpenFileDialog.FileName = ""
        If OpenFileDialog.ShowDialog(Me) = DialogResult.OK Then
            Dim img As String = OpenFileDialog.FileName
            Image.BackgroundImage = System.Drawing.Bitmap.FromFile(img)
            Image.BackgroundImageLayout = ImageLayout.Stretch
        End If
        StatusLabel.Text = "Ready"
        Exit Sub
nonimage2:
        MsgBox("Please open an Image File.", MsgBoxStyle.Critical, "Error")
    End Sub

    Private Sub SaveShortcut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveShortcut.Click
        StatusLabel.Text = "Saving Drawing..."
        Dim bounds As Rectangle
        Dim screenshot As System.Drawing.Bitmap
        Dim graph As Graphics
        bounds = Screen.PrimaryScreen.Bounds
        screenshot = New System.Drawing.Bitmap(673, 473, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(Me.Location.X + 13, Me.Location.Y + 61, 0, 0, Me.Size, CopyPixelOperation.SourceCopy)
        Image.Image = screenshot
        SaveFileDialog.Title = "Save File"
        SaveFileDialog.FileName = "*.bmp"
        SaveFileDialog.Filter = "Bitmap |*.bmp"
        If SaveFileDialog.ShowDialog() = DialogResult.OK Then
            Image.Image.Save(SaveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
        End If
        StatusLabel.Text = "Ready"
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        StatusLabel.Text = "Saving Drawing..."
        Dim bounds As Rectangle
        Dim screenshot As System.Drawing.Bitmap
        Dim graph As Graphics
        bounds = Screen.PrimaryScreen.Bounds
        screenshot = New System.Drawing.Bitmap(673, 473, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(Me.Location.X + 13, Me.Location.Y + 61, 0, 0, Me.Size, CopyPixelOperation.SourceCopy)
        Image.Image = screenshot
        SaveFileDialog.Title = "Save File"
        SaveFileDialog.FileName = "*.bmp"
        SaveFileDialog.Filter = "Bitmap |*.bmp"
        If SaveFileDialog.ShowDialog() = DialogResult.OK Then
            Image.Image.Save(SaveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
        End If
        StatusLabel.Text = "Ready"
    End Sub

    Private Sub Red_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Red.ValueChanged
        StatusLabel.Text = "Changing Color..."
        Dim dec_r, perc_r, dec_g, perc_g, dec_b, perc_b As Double
        perc_r = Red.Value
        dec_r = (perc_r / 100) * 255
        perc_g = Green.Value
        dec_g = (perc_g / 100) * 255
        perc_b = Blue.Value
        dec_b = (perc_b / 100) * 255
        Dim r, g, b As Integer
        r = dec_r
        g = dec_g
        b = dec_b
        brush = New SolidBrush(Color.FromArgb(r, g, b))
        Dim pensize, coord As Single
        pensize = BrushSize.Text
        BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, 222, 222)
        coord = 111 - (pensize / 2)
        BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
        StatusLabel.Text = "Ready"
    End Sub

    Private Sub Green_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Green.ValueChanged
        StatusLabel.Text = "Changing Color..."
        Dim dec_r, perc_r, dec_g, perc_g, dec_b, perc_b As Double
        perc_r = Red.Value
        dec_r = (perc_r / 100) * 255
        perc_g = Green.Value
        dec_g = (perc_g / 100) * 255
        perc_b = Blue.Value
        dec_b = (perc_b / 100) * 255
        Dim r, g, b As Integer
        r = dec_r
        g = dec_g
        b = dec_b
        brush = New SolidBrush(Color.FromArgb(r, g, b))
        Dim pensize, coord As Single
        pensize = BrushSize.Text
        BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, 222, 222)
        coord = 111 - (pensize / 2)
        BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
        StatusLabel.Text = "Ready"
    End Sub

    Private Sub Blue_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blue.ValueChanged
        StatusLabel.Text = "Changing Color..."
        Dim dec_r, perc_r, dec_g, perc_g, dec_b, perc_b As Double
        perc_r = Red.Value
        dec_r = (perc_r / 100) * 255
        perc_g = Green.Value
        dec_g = (perc_g / 100) * 255
        perc_b = Blue.Value
        dec_b = (perc_b / 100) * 255
        Dim r, g, b As Integer
        r = dec_r
        g = dec_g
        b = dec_b
        brush = New SolidBrush(Color.FromArgb(r, g, b))
        Dim pensize, coord As Single
        pensize = BrushSize.Text
        BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, 222, 222)
        coord = 111 - (pensize / 2)
        BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
        StatusLabel.Text = "Ready"
    End Sub
End Class
