Public Class MainWindow
    Dim draw = False
    Dim brush = Brushes.Black
    Dim blackbrush = Brushes.Black
    Dim whitebrush = Brushes.White
    Dim controlbrush = Brushes.Silver
    Dim bgbrush = Brushes.CornflowerBlue
    Dim shape As String = "o"
    Dim fontsize As Single = 20
    Dim stringfont As New Font("Arial", fontsize)
    Dim drawstring As String = "text"

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
        fontsize = BrushSize.Text
        stringfont = New Font("Arial", fontsize)
        BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, 222, 222)
        If shape = "o" Then
            coord = 111 - (pensize / 2)
            BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
        End If
        If shape = "[]" Then
            coord = 111 - (pensize / 2)
            BrushPreview.CreateGraphics.FillRectangle(brush, coord, coord, pensize, pensize)
        End If
        If shape = "ß" Then
            coord = 0
            BrushPreview.CreateGraphics.DrawString(drawstring, stringfont, brush, coord, coord)
        End If
        StatusLabel.Text = "Ready"
        Exit Sub
brushsizehandler:
        MsgBox("Crashed - String not accepted in Brush Size TextBox!", MsgBoxStyle.Critical, "Error")
        End
    End Sub

    Private Sub Image_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Image.MouseDown
        draw = True
        On Error GoTo pixeldrawhandler
        StatusLabel.Text = "Drawing..."
        Dim pensize As Single
        pensize = BrushSize.Text
        If draw = True Then
            If shape = "o" Then
                Image.CreateGraphics.FillEllipse(brush, e.X - (pensize / 2), e.Y - (pensize / 2), pensize, pensize)
            End If
            If shape = "[]" Then
                Image.CreateGraphics.FillRectangle(brush, e.X - (pensize / 2), e.Y - (pensize / 2), pensize, pensize)
            End If
            If shape = "ß" Then
                Image.CreateGraphics.DrawString(drawstring, stringfont, brush, e.X, e.Y)
            End If
        End If
        StatusLabel.Text = "Ready"
        Exit Sub
pixeldrawhandler:
        MsgBox("Crashed - String not accepted in Brush Size TextBox!", MsgBoxStyle.Critical, "Error")
        End
    End Sub

    Private Sub Image_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Image.MouseMove
        On Error GoTo brushdrawhandler
        StatusLabel.Text = "Drawing..."
        Dim pensize As Single
        pensize = BrushSize.Text
        If draw = True Then
            If shape = "o" Then
                Image.CreateGraphics.FillEllipse(brush, e.X - (pensize / 2), e.Y - (pensize / 2), pensize, pensize)
            End If
            If shape = "[]" Then
                Image.CreateGraphics.FillRectangle(brush, e.X - (pensize / 2), e.Y - (pensize / 2), pensize, pensize)
            End If
            If shape = "ß" Then
                Image.CreateGraphics.DrawString(drawstring, stringfont, brush, e.X, e.Y)
            End If
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
        Dim coord, pensize As Single
        pensize = 1
        BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, 222, 222)
        coord = 111 - (pensize / 2)
        If shape = "o" Then
            BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
        End If
        If shape = "[]" Then
            BrushPreview.CreateGraphics.FillRectangle(brush, coord, coord, pensize, pensize)
        End If
        If shape = "ß" Then
            BrushPreview.CreateGraphics.DrawString(drawstring, stringfont, brush, 0, 0)
        End If
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

    Private Sub ViewReadmeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewReadmeButton.Click
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
        If shape = "o" Then
            BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
        End If
        If shape = "[]" Then
            BrushPreview.CreateGraphics.FillRectangle(brush, coord, coord, pensize, pensize)
        End If
        If shape = "ß" Then
            BrushPreview.CreateGraphics.DrawString(drawstring, stringfont, brush, 0, 0)
        End If
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
        If shape = "o" Then
            BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
        End If
        If shape = "[]" Then
            BrushPreview.CreateGraphics.FillRectangle(brush, coord, coord, pensize, pensize)
        End If
        If shape = "ß" Then
            BrushPreview.CreateGraphics.DrawString(drawstring, stringfont, brush, 0, 0)
        End If
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
        If shape = "o" Then
            BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
        End If
        If shape = "[]" Then
            BrushPreview.CreateGraphics.FillRectangle(brush, coord, coord, pensize, pensize)
        End If
        If shape = "ß" Then
            BrushPreview.CreateGraphics.DrawString(drawstring, stringfont, brush, 0, 0)
        End If
        StatusLabel.Text = "Ready"
    End Sub

    Private Sub RGBColorChartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RGBColorChartButton.Click
        On Error GoTo rgbnotfound
        StatusLabel.Text = "Starting RGB Color Chart..."
        System.Diagnostics.Process.Start("RGB.rtf")
        StatusLabel.Text = "Ready"
        Exit Sub
rgbnotfound:
        MsgBox("Cannot find RGB.rtf", MsgBoxStyle.SystemModal, "Error")
    End Sub

    Private Sub BrushShapeToCircleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrushShapeToCircleButton.Click
        StatusLabel.Text = "Changing Brush Shape..."
        shape = "o"
        Label2.Text = "Brush Size:"
        Label3.Text = "Brush Color:"
        Label4.Visible = False
        TextToDrawBox.Visible = False
        TextToDrawBox.Enabled = False
        Label5.Text = "Preview Brush:"
        Dim pensize, coord As Single
        pensize = BrushSize.Text
        BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, 222, 222)
        coord = 111 - (pensize / 2)
        BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
        StatusLabel.Text = "Ready"
        BrushShapeToSquareButton.Enabled = True
        BrushShapeToTextButton.Enabled = True
        BrushShapeToCircleButton.Enabled = False
    End Sub

    Private Sub BrushShapeToSquareButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrushShapeToSquareButton.Click
        StatusLabel.Text = "Changing Brush Shape..."
        shape = "[]"
        Label2.Text = "Brush Size:"
        Label3.Text = "Brush Color:"
        Label4.Visible = False
        TextToDrawBox.Visible = False
        TextToDrawBox.Enabled = False
        Label5.Text = "Preview Brush:"
        Dim pensize, coord As Single
        pensize = BrushSize.Text
        BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, 222, 222)
        coord = 111 - (pensize / 2)
        BrushPreview.CreateGraphics.FillRectangle(brush, coord, coord, pensize, pensize)
        StatusLabel.Text = "Ready"
        BrushShapeToCircleButton.Enabled = True
        BrushShapeToTextButton.Enabled = True
        BrushShapeToSquareButton.Enabled = False
    End Sub

    Private Sub BrushShapeToTextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrushShapeToTextButton.Click
        StatusLabel.Text = "Changing Brush Shape..."
        shape = "ß"
        Label2.Text = "  Font Size:"
        Label3.Text = "  Text Color:"
        Label4.Visible = True
        TextToDrawBox.Enabled = True
        TextToDrawBox.Visible = True
        Label5.Text = "  Preview Text:"
        Dim pensize, coord As Single
        pensize = BrushSize.Text
        BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, 222, 222)
        coord = 0
        BrushPreview.CreateGraphics.DrawString(drawstring, stringfont, brush, coord, coord)
        StatusLabel.Text = "Ready"
        BrushShapeToCircleButton.Enabled = True
        BrushShapeToSquareButton.Enabled = True
        BrushShapeToTextButton.Enabled = False
    End Sub

    Private Sub TextToDrawBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextToDrawBox.TextChanged
        StatusLabel.Text = "Changing Text to Draw..."
        drawstring = TextToDrawBox.Text
        If shape = "ß" Then
            Dim pensize, coord As Single
            pensize = BrushSize.Text
            BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, 222, 222)
            coord = 0
            BrushPreview.CreateGraphics.DrawString(drawstring, stringfont, brush, coord, coord)
        End If
        StatusLabel.Text = "Ready"
    End Sub
End Class
