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
    Public x, y As Single
    Public FullOSName, os As String
    Dim resizewarning As Boolean = True
    Dim resizewarningresult As MsgBoxResult
    Dim resscreenshot As Bitmap
    Dim resgraph As Graphics
    Dim brushmode As String = "brush"
    Dim toolstate As String
    Dim startpoint, endpoint As Point

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StatusLabel.Text = "Initializing..."
        Me.Image.Image = New Bitmap(Image.Width, Image.Height)
        BrushPreview.Height = BrushPreview.Width
        GetOS()
        saveCoordUpdate()
        StatusLabel.Text = "Ready"
    End Sub

    Private Sub NewShortcut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewShortcut.Click
        StatusLabel.Text = "Creating New Drawing..."
        Image.CreateGraphics.FillRectangle(whitebrush, 0, 0, Image.Width, Image.Height)
        Image.Enabled = True
        Image.BackColor = Color.White
        OpenButton.Enabled = True
        OpenShortcut.Enabled = True
        SaveButton.Enabled = True
        SaveShortcut.Enabled = True
        BrushModeToBrush.Enabled = True
        BrushModeToTool.Enabled = True
        If brushmode = "tool" Then
            BrushShapeToCircleButton.Enabled = True
            BrushShapeToSquareButton.Enabled = True
        End If
        StatusLabel.Text = "Ready"
    End Sub

    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click
        StatusLabel.Text = "Creating New Drawing..."
        Image.CreateGraphics.FillRectangle(whitebrush, 0, 0, Image.Width, Image.Height)
        Image.Enabled = True
        Image.BackColor = Color.White
        OpenButton.Enabled = True
        OpenShortcut.Enabled = True
        SaveButton.Enabled = True
        SaveShortcut.Enabled = True
        BrushModeToBrush.Enabled = True
        BrushModeToTool.Enabled = True
        If brushmode = "tool" Then
            BrushShapeToCircleButton.Enabled = True
            BrushShapeToSquareButton.Enabled = True
        End If
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
        BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, BrushPreview.Width, BrushPreview.Height)
        coord = (BrushPreview.Size.Width - pensize) / 2
        If shape = "o" Then
            BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
        End If
        If shape = "[]" Then
            BrushPreview.CreateGraphics.FillRectangle(brush, coord, coord, pensize, pensize)
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
            If brushmode = "brush" Then
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
        End If
        If brushmode = "tool" Then
            If toolstate = "waitForStart" Then
                startpoint = New Point(e.X, e.Y)
                Label4.Text = "Click ending point on drawing"
                toolstate = "waitForEnd"
                StatusLabel.Text = "Ready"
                Exit Sub
            End If
            If toolstate = "waitForEnd" Then
                endpoint = New Point(e.X, e.Y)
                Label4.Text = "Text:"
                Label4.Visible = False
                If shape = "o" Then
                    Image.CreateGraphics.FillEllipse(brush, startpoint.X, startpoint.Y, endpoint.X - startpoint.X, endpoint.Y - startpoint.Y)
                End If
                If shape = "[]" Then
                    If startpoint.X < endpoint.X And startpoint.Y < endpoint.Y Then
                        Image.CreateGraphics.FillRectangle(brush, startpoint.X, startpoint.Y, endpoint.X - startpoint.X, endpoint.Y - startpoint.Y)
                    End If
                    If startpoint.X > endpoint.X And startpoint.Y > endpoint.Y Then
                        Image.CreateGraphics.FillRectangle(brush, endpoint.X, endpoint.Y, startpoint.X - endpoint.X, startpoint.Y - endpoint.Y)
                    End If
                    If startpoint.X < endpoint.X And startpoint.Y > endpoint.Y Then
                        Image.CreateGraphics.FillRectangle(brush, startpoint.X, endpoint.Y, endpoint.X - startpoint.X, startpoint.Y - endpoint.Y)
                    End If
                    If startpoint.X > endpoint.X And startpoint.Y < endpoint.Y Then
                        Image.CreateGraphics.FillRectangle(brush, endpoint.X, startpoint.Y, startpoint.X - endpoint.X, endpoint.Y - startpoint.Y)
                    End If
                End If
                BrushModeToBrush.Enabled = True
                BrushModeToTool.Enabled = True
                BrushShapeToCircleButton.Enabled = True
                BrushShapeToSquareButton.Enabled = True
                Red.Enabled = True
                Green.Enabled = True
                Blue.Enabled = True
                NewButton.Enabled = True
                NewShortcut.Enabled = True
                OpenButton.Enabled = True
                OpenShortcut.Enabled = True
                SaveButton.Enabled = True
                SaveShortcut.Enabled = True
                CloseButton.Enabled = True
                CloseShortcut.Enabled = True
                AboutButton.Enabled = True
                HelpMenu.Enabled = True
                toolstate = ""
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
            If brushmode = "brush" Then
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
        End If
        StatusLabel.Text = "Ready"
        Exit Sub
brushdrawhandler:
        MsgBox("Crashed - String not accepted in Brush Size TextBox!", MsgBoxStyle.Critical, "Error")
        End
    End Sub

    Private Sub Image_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Image.MouseUp
        draw = False
        resscreenshot = New System.Drawing.Bitmap(Image.Width, Image.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        resgraph = Graphics.FromImage(resscreenshot)
        resgraph.CopyFromScreen(Me.Location.X + x, Me.Location.Y + y, 0, 0, Image.Size, CopyPixelOperation.SourceCopy)
        Image.BackgroundImage = resscreenshot
        Image.Image = New Bitmap(Image.Width, Image.Height)
    End Sub

    Private Sub BrushPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrushPreview.LoadCompleted
        StatusLabel.Text = "Initializing Brush..."
        brush = Brushes.Black
        Dim coord, pensize As Single
        pensize = 1
        BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, BrushPreview.Width, BrushPreview.Height)
        coord = (BrushPreview.Size.Width - pensize) / 2
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
        BrushModeToBrush.Enabled = False
        BrushModeToTool.Enabled = False
        If brushmode = "tool" Then
            BrushShapeToCircleButton.Enabled = False
            BrushShapeToSquareButton.Enabled = False
        End If
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
        BrushModeToBrush.Enabled = False
        BrushModeToTool.Enabled = False
        If brushmode = "tool" Then
            BrushShapeToCircleButton.Enabled = False
            BrushShapeToSquareButton.Enabled = False
        End If
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
        AboutBox1.Show()
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
        Dim screenshot As System.Drawing.Bitmap
        Dim graph As Graphics
        screenshot = New System.Drawing.Bitmap(Image.Width, Image.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(Me.Location.X + x, Me.Location.Y + y, 0, 0, Image.Size, CopyPixelOperation.SourceCopy)
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
        Dim screenshot As System.Drawing.Bitmap
        Dim graph As Graphics
        screenshot = New System.Drawing.Bitmap(Image.Width, Image.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(Me.Location.X + x, Me.Location.Y + y, 0, 0, Image.Size, CopyPixelOperation.SourceCopy)
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
        BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, BrushPreview.Width, BrushPreview.Height)
        coord = (BrushPreview.Size.Width - pensize) / 2
        If brushmode = "brush" Then
            If shape = "o" Then
                BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
            End If
            If shape = "[]" Then
                BrushPreview.CreateGraphics.FillRectangle(brush, coord, coord, pensize, pensize)
            End If
            If shape = "ß" Then
                BrushPreview.CreateGraphics.DrawString(drawstring, stringfont, brush, 0, 0)
            End If
        End If
        If brushmode = "tool" Then
            BrushPreview.CreateGraphics.FillRectangle(brush, 0, 0, BrushPreview.Width, BrushPreview.Height)
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
        BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, BrushPreview.Width, BrushPreview.Height)
        coord = (BrushPreview.Size.Width - pensize) / 2
        If brushmode = "brush" Then
            If shape = "o" Then
                BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
            End If
            If shape = "[]" Then
                BrushPreview.CreateGraphics.FillRectangle(brush, coord, coord, pensize, pensize)
            End If
            If shape = "ß" Then
                BrushPreview.CreateGraphics.DrawString(drawstring, stringfont, brush, 0, 0)
            End If
        End If
        If brushmode = "tool" Then
            BrushPreview.CreateGraphics.FillRectangle(brush, 0, 0, BrushPreview.Width, BrushPreview.Height)
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
        BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, BrushPreview.Width, BrushPreview.Height)
        coord = (BrushPreview.Size.Width - pensize) / 2
        If brushmode = "brush" Then
            If shape = "o" Then
                BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
            End If
            If shape = "[]" Then
                BrushPreview.CreateGraphics.FillRectangle(brush, coord, coord, pensize, pensize)
            End If
            If shape = "ß" Then
                BrushPreview.CreateGraphics.DrawString(drawstring, stringfont, brush, 0, 0)
            End If
        End If
        If brushmode = "tool" Then
            BrushPreview.CreateGraphics.FillRectangle(brush, 0, 0, BrushPreview.Width, BrushPreview.Height)
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
        If brushmode = "brush" Then
            Label2.Visible = True
            BrushSize.Visible = True
            FontButton.Visible = False
            Label3.Text = "Brush Color:"
            Label4.Visible = False
            TextToDrawBox.Visible = False
            TextToDrawBox.Enabled = False
            Label5.Text = "Preview Brush:"
            Dim pensize, coord As Single
            pensize = BrushSize.Text
            BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, BrushPreview.Width, BrushPreview.Height)
            coord = (BrushPreview.Size.Width - pensize) / 2
            BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
            StatusLabel.Text = "Ready"
            BrushShapeToSquareButton.Enabled = True
            BrushShapeToTextButton.Enabled = True
            BrushShapeToCircleButton.Enabled = False
        End If
        If brushmode = "tool" Then
            Label4.Visible = True
            Label4.Text = "Click starting point on drawing"
            BrushModeToBrush.Enabled = False
            BrushModeToTool.Enabled = False
            BrushShapeToCircleButton.Enabled = False
            BrushShapeToSquareButton.Enabled = False
            Red.Enabled = False
            Green.Enabled = False
            Blue.Enabled = False
            NewButton.Enabled = False
            NewShortcut.Enabled = False
            OpenButton.Enabled = False
            OpenShortcut.Enabled = False
            SaveButton.Enabled = False
            SaveShortcut.Enabled = False
            CloseButton.Enabled = False
            CloseShortcut.Enabled = False
            AboutButton.Enabled = False
            HelpMenu.Enabled = False
            toolstate = "waitForStart"
            StatusLabel.Text = "Ready"
        End If
    End Sub

    Private Sub BrushShapeToSquareButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrushShapeToSquareButton.Click
        StatusLabel.Text = "Changing Brush Shape..."
        shape = "[]"
        If brushmode = "brush" Then
            Label2.Visible = True
            BrushSize.Visible = True
            FontButton.Visible = False
            Label3.Text = "Brush Color:"
            Label4.Visible = False
            TextToDrawBox.Visible = False
            TextToDrawBox.Enabled = False
            Label5.Text = "Preview Brush:"
            Dim pensize, coord As Single
            pensize = BrushSize.Text
            BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, BrushPreview.Width, BrushPreview.Height)
            coord = (BrushPreview.Size.Width - pensize) / 2
            BrushPreview.CreateGraphics.FillRectangle(brush, coord, coord, pensize, pensize)
            StatusLabel.Text = "Ready"
            BrushShapeToCircleButton.Enabled = True
            BrushShapeToTextButton.Enabled = True
            BrushShapeToSquareButton.Enabled = False
        End If
        If brushmode = "tool" Then
            Label4.Visible = True
            Label4.Text = "Click starting point on drawing"
            BrushModeToBrush.Enabled = False
            BrushModeToTool.Enabled = False
            BrushShapeToCircleButton.Enabled = False
            BrushShapeToSquareButton.Enabled = False
            Red.Enabled = False
            Green.Enabled = False
            Blue.Enabled = False
            NewButton.Enabled = False
            NewShortcut.Enabled = False
            OpenButton.Enabled = False
            OpenShortcut.Enabled = False
            SaveButton.Enabled = False
            SaveShortcut.Enabled = False
            CloseButton.Enabled = False
            CloseShortcut.Enabled = False
            AboutButton.Enabled = False
            HelpMenu.Enabled = False
            toolstate = "waitForStart"
            StatusLabel.Text = "Ready"
        End If
    End Sub

    Private Sub BrushShapeToTextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrushShapeToTextButton.Click
        StatusLabel.Text = "Changing Brush Shape..."
        shape = "ß"
        If brushmode = "brush" Then
            Label2.Visible = False
            BrushSize.Visible = False
            FontButton.Visible = True
            Label3.Text = "  Text Color:"
            Label4.Visible = True
            TextToDrawBox.Enabled = True
            TextToDrawBox.Visible = True
            Label5.Text = "  Preview Text:"
            Dim pensize As Single
            pensize = BrushSize.Text
            BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, BrushPreview.Width, BrushPreview.Height)
            BrushPreview.CreateGraphics.DrawString(drawstring, stringfont, brush, 0, 0)
            StatusLabel.Text = "Ready"
            BrushShapeToCircleButton.Enabled = True
            BrushShapeToSquareButton.Enabled = True
            BrushShapeToTextButton.Enabled = False
        End If
        If brushmode = "tool" Then
            Label4.Visible = False
            TextToDrawBox.Visible = False
            TextToDrawBox.Enabled = False
            FontButton.Visible = False
            shape = "o"
        End If
    End Sub

    Private Sub TextToDrawBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextToDrawBox.TextChanged
        StatusLabel.Text = "Changing Text to Draw..."
        drawstring = TextToDrawBox.Text
        If shape = "ß" Then
            Dim pensize As Single
            pensize = BrushSize.Text
            BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, BrushPreview.Width, BrushPreview.Height)
            BrushPreview.CreateGraphics.DrawString(drawstring, stringfont, brush, 0, 0)
        End If
        StatusLabel.Text = "Ready"
    End Sub

    Private Sub FontButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontButton.Click
        StatusLabel.Text = "Changing Font..."
        If FontDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            stringfont = FontDialog.Font
        End If
        If shape = "ß" Then
            Dim pensize As Single
            pensize = BrushSize.Text
            BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, BrushPreview.Width, BrushPreview.Height)
            BrushPreview.CreateGraphics.DrawString(drawstring, stringfont, brush, 0, 0)
        End If
        StatusLabel.Text = "Ready"
    End Sub

    Private Sub MainWindow_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If resizewarningresult = MsgBoxResult.Yes Then
            StatusLabel.Text = "Resizing..."
            PaintToolsPanel.Location = New Point(Me.Size.Width - 202, -3)
            PaintToolsPanel.Height = Me.Height + 10
            CloseShortcut.Location = New Point(PaintToolsPanel.Location.X - 24, 0)
            SaveShortcut.Location = New Point(CloseShortcut.Location.X - 23, 0)
            OpenShortcut.Location = New Point(SaveShortcut.Location.X - 23, 0)
            NewShortcut.Location = New Point(OpenShortcut.Location.X - 23, 0)
            PictureBoxBackground.Width = Me.Width - 183
            PictureBoxBackground.Height = Me.Height - 68
            Image.Width = Me.Width - 217
            Image.Height = Me.Height - 91
            Image.Image = New System.Drawing.Bitmap(Image.Width, Image.Height)
            Image.BackgroundImage = resscreenshot
            Dim pensize, coord As Single
            pensize = BrushSize.Text
            BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, BrushPreview.Width, BrushPreview.Height)
            coord = (BrushPreview.Size.Width - pensize) / 2
            If shape = "o" Then
                BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
            End If
            If shape = "[]" Then
                BrushPreview.CreateGraphics.FillRectangle(brush, coord, coord, pensize, pensize)
            End If
            StatusLabel.Text = "Ready"
        End If
    End Sub

    Private Sub MainWindow_ResizeBegin(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeBegin
        StatusLabel.Text = "Preparing for Resize..."
        resscreenshot = New System.Drawing.Bitmap(Image.Width, Image.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        resgraph = Graphics.FromImage(resscreenshot)
        resgraph.CopyFromScreen(Me.Location.X + x, Me.Location.Y + y, 0, 0, Image.Size, CopyPixelOperation.SourceCopy)
        Image.BackgroundImage = resscreenshot
        If resizewarning = True Then
            StatusLabel.Text = "Waiting for Message Box..."
            resizewarningresult = MsgBox("You are about to resize the window. When the window is resized or maximized, the image gets stretched. Are you sure you want to continue?" & vbCrLf & vbCrLf & "(Your image won't be lost if you're only moving the window.)", MsgBoxStyle.YesNo, "Warning")
            StatusLabel.Text = "Applying Resize preparations..."
            If resizewarningresult = MsgBoxResult.Yes Then
                resizewarning = False
                Me.MaximizeBox = True
            Else
                LeftClick()
            End If
        End If
        StatusLabel.Text = "Ready"
    End Sub

    Private Sub MainWindow_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        StatusLabel.Text = "Finishing Resize..."
        If resizewarningresult = MsgBoxResult.No Then
            Image.Image = resscreenshot
        End If
        Dim pensize, coord As Single
        pensize = BrushSize.Text
        BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, BrushPreview.Width, BrushPreview.Height)
        coord = (BrushPreview.Size.Width - pensize) / 2
        If shape = "o" Then
            BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
        End If
        If shape = "[]" Then
            BrushPreview.CreateGraphics.FillRectangle(brush, coord, coord, pensize, pensize)
        End If
        StatusLabel.Text = "Ready"
    End Sub

    Private Sub BrushModeToBrush_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrushModeToBrush.CheckedChanged
        StatusLabel.Text = "Changing Brush Mode..."
        If BrushModeToBrush.Checked = True Then
            brushmode = "brush"
            BrushShapeToCircleButton.Enabled = True
            BrushShapeToSquareButton.Enabled = True
            BrushShapeToTextButton.Visible = True
            BrushShapeToTextButton.Enabled = True
            If shape = "o" Then BrushShapeToCircleButton.Enabled = False
            If shape = "[]" Then BrushShapeToSquareButton.Enabled = False
            If shape = "ß" Then BrushShapeToTextButton.Enabled = False
            Label1.Text = "Brush Shape:"
            Label2.Visible = True
            BrushSize.Visible = True
            Label3.Text = "Brush Color:"
            Label5.Text = "Preview Brush:"
            Dim pensize, coord As Single
            coord = (BrushPreview.Size.Width - pensize) / 2
            If shape = "o" Then
                BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
            End If
            If shape = "[]" Then
                BrushPreview.CreateGraphics.FillRectangle(brush, coord, coord, pensize, pensize)
            End If
            StatusLabel.Text = "Ready"
        Else
            brushmode = "tool"
            BrushShapeToCircleButton.Enabled = True
            BrushShapeToSquareButton.Enabled = True
            BrushShapeToTextButton.Enabled = True
            BrushShapeToTextButton.Visible = False
            If shape = "ß" Then
                Label4.Visible = False
                TextToDrawBox.Visible = False
                TextToDrawBox.Enabled = False
                FontButton.Visible = False
                shape = "o"
            End If
            Label1.Text = "             Tool:"
            Label2.Visible = False
            BrushSize.Visible = False
            Label3.Text = "  Tool Color:"
            Label5.Text = "Preview Tool Color:"
            BrushPreview.CreateGraphics.FillRectangle(brush, 0, 0, BrushPreview.Width, BrushPreview.Height)
            StatusLabel.Text = "Ready"
        End If
    End Sub

    Private Sub BrushModeToTool_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrushModeToTool.CheckedChanged
        StatusLabel.Text = "Changing Brush Mode..."
        If BrushModeToTool.Checked = True Then
            brushmode = "tool"
            BrushShapeToCircleButton.Enabled = True
            BrushShapeToSquareButton.Enabled = True
            BrushShapeToTextButton.Enabled = True
            BrushShapeToTextButton.Visible = False
            If shape = "ß" Then
                Label4.Visible = False
                TextToDrawBox.Visible = False
                TextToDrawBox.Enabled = False
                FontButton.Visible = False
                shape = "o"
            End If
            Label1.Text = "             Tool:"
            Label2.Visible = False
            BrushSize.Visible = False
            Label3.Text = "  Tool Color:"
            Label5.Text = "Preview Tool Color:"
            BrushPreview.CreateGraphics.FillRectangle(brush, 0, 0, BrushPreview.Width, BrushPreview.Height)
            StatusLabel.Text = "Ready"
        Else
            brushmode = "brush"
            BrushShapeToCircleButton.Enabled = True
            BrushShapeToSquareButton.Enabled = True
            BrushShapeToTextButton.Visible = True
            BrushShapeToTextButton.Enabled = True
            If shape = "o" Then BrushShapeToCircleButton.Enabled = False
            If shape = "[]" Then BrushShapeToSquareButton.Enabled = False
            If shape = "ß" Then BrushShapeToTextButton.Enabled = False
            Label1.Text = "Brush Shape:"
            Label2.Visible = True
            BrushSize.Visible = True
            Label3.Text = "Brush Color:"
            Label5.Text = "Preview Brush:"
            Dim pensize, coord As Single
            coord = (BrushPreview.Size.Width - pensize) / 2
            If shape = "o" Then
                BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
            End If
            If shape = "[]" Then
                BrushPreview.CreateGraphics.FillRectangle(brush, coord, coord, pensize, pensize)
            End If
            StatusLabel.Text = "Ready"
        End If
    End Sub
End Class