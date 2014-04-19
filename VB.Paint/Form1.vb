Public Class MainWindow
    Dim draw = False
    Dim brush = Brushes.Black
    Dim blackbrush = Brushes.Black
    Dim whitebrush = Brushes.White
    Dim controlbrush = Brushes.Silver
    Dim bgbrush = Brushes.CornflowerBlue

    Private Sub NewShortcut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewShortcut.Click
        Image.CreateGraphics.FillRectangle(whitebrush, 0, 0, 673, 473)
        Image.Enabled = True
        Image.BackColor = Color.White
        OpenButton.Enabled = True
        OpenShortcut.Enabled = True
    End Sub

    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click
        Image.CreateGraphics.FillRectangle(whitebrush, 0, 0, 673, 473)
        Image.Enabled = True
        Image.BackColor = Color.White
        OpenButton.Enabled = True
        OpenShortcut.Enabled = True
    End Sub

    Private Sub BrushSize_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrushSize.SelectedItemChanged
        On Error GoTo brushsizehandler
        Dim pensize, coord As Single
        If BrushSize.Text = "" Then
            BrushSize.Text = "1"
        End If
        pensize = BrushSize.Text
        BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, 222, 222)
        coord = 111 - (pensize / 2)
        BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
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
        Dim pensize As Single
        pensize = BrushSize.Text
        If draw = True Then
            Image.CreateGraphics.FillEllipse(brush, e.X - (pensize / 2), e.Y - (pensize / 2), pensize, pensize)
        End If
        Exit Sub
brushdrawhandler:
        MsgBox("Crashed - String not accepted in Brush Size TextBox!", MsgBoxStyle.Critical, "Error")
        End
    End Sub

    Private Sub Image_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Image.MouseUp
        draw = False
    End Sub

    Private Sub BrushColorRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrushColorRed.Click
        brush = Brushes.Red
        Dim pensize, coord As Single
        pensize = BrushSize.Text
        BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, 222, 222)
        coord = 111 - (pensize / 2)
        BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
    End Sub

    Private Sub BrushColorGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrushColorGreen.Click
        brush = Brushes.Lime
        Dim pensize, coord As Single
        pensize = BrushSize.Text
        BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, 222, 222)
        coord = 111 - (pensize / 2)
        BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
    End Sub

    Private Sub BrushColorBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrushColorBlue.Click
        brush = Brushes.Blue
        Dim pensize, coord As Single
        pensize = BrushSize.Text
        BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, 222, 222)
        coord = 111 - (pensize / 2)
        BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
    End Sub

    Private Sub BrushColorYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrushColorYellow.Click
        brush = Brushes.Yellow
        Dim pensize, coord As Single
        pensize = BrushSize.Text
        BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, 222, 222)
        coord = 111 - (pensize / 2)
        BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
    End Sub

    Private Sub BrushColorMagenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrushColorMagenta.Click
        brush = Brushes.Magenta
        Dim pensize, coord As Single
        pensize = BrushSize.Text
        BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, 222, 222)
        coord = 111 - (pensize / 2)
        BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
    End Sub

    Private Sub BrushColorCyan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrushColorCyan.Click
        brush = Brushes.Cyan
        Dim pensize, coord As Single
        pensize = BrushSize.Text
        BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, 222, 222)
        coord = 111 - (pensize / 2)
        BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
    End Sub

    Private Sub BrushColorBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrushColorBlack.Click
        brush = Brushes.Black
        Dim pensize, coord As Single
        pensize = BrushSize.Text
        BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, 222, 222)
        coord = 111 - (pensize / 2)
        BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
    End Sub

    Private Sub BrushColorWhite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrushColorWhite.Click
        brush = Brushes.White
        Dim pensize, coord As Single
        pensize = BrushSize.Text
        BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, 222, 222)
        coord = 111 - (pensize / 2)
        BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
    End Sub

    Private Sub BrushColorOrange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrushColorOrange.Click
        brush = Brushes.Orange
        Dim pensize, coord As Single
        pensize = BrushSize.Text
        BrushPreview.CreateGraphics.FillRectangle(bgbrush, 0, 0, 222, 222)
        coord = 111 - (pensize / 2)
        BrushPreview.CreateGraphics.FillEllipse(brush, coord, coord, pensize, pensize)
    End Sub

    Private Sub BrushPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrushPreview.LoadCompleted
        brush = Brushes.Black
        BrushPreview.CreateGraphics.FillEllipse(brush, 110, 110, 1, 1)
    End Sub

    Private Sub CloseShortcut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseShortcut.Click
        Image.CreateGraphics.FillRectangle(controlbrush, 0, 0, 673, 473)
        Image.BackgroundImage = Nothing
        Image.BackColor = Color.Silver
        Image.Enabled = False
        OpenButton.Enabled = False
        OpenShortcut.Enabled = False
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Image.CreateGraphics.FillRectangle(controlbrush, 0, 0, 673, 473)
        Image.BackgroundImage = Nothing
        Image.BackColor = Color.Silver
        Image.Enabled = False
        OpenButton.Enabled = False
        OpenShortcut.Enabled = False
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        End
    End Sub

    Private Sub HelpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpBtn.Click
        On Error GoTo 404
        System.Diagnostics.Process.Start("readme.txt")
        Exit Sub
404:
        MsgBox("Cannot find readme.txt", MsgBoxStyle.SystemModal, "Error")
    End Sub

    Private Sub AboutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutButton.Click
        Dim SecondForm As AboutBox1 = AboutBox1
        SecondForm.Show()
    End Sub

    Private Sub OpenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenButton.Click
        If Image.Enabled = False Then
            OpenShortcut.Enabled = False
            OpenButton.Enabled = False
            Exit Sub
        End If
        OpenFileDialog.Filter = "All Files|*.*"
        OpenFileDialog.FileName = ""
        If OpenFileDialog.ShowDialog(Me) = DialogResult.OK Then
            Dim img As String = OpenFileDialog.FileName
            Image.BackgroundImage = System.Drawing.Bitmap.FromFile(img)
            Image.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub

    Private Sub OpenShortcut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenShortcut.Click
        If Image.Enabled = False Then
            OpenButton.Enabled = False
            OpenShortcut.Enabled = False
            Exit Sub
        End If
        OpenFileDialog.Filter = "All Files|*.*"
        OpenFileDialog.FileName = ""
        If OpenFileDialog.ShowDialog(Me) = DialogResult.OK Then
            Dim img As String = OpenFileDialog.FileName
            Image.BackgroundImage = System.Drawing.Bitmap.FromFile(img)
            Image.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub
End Class
