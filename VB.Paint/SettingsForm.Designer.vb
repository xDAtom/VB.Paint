<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsForm))
        Me.OKButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.ApplyButton = New System.Windows.Forms.Button
        Me.OSSelection = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SizeSelection = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.Location = New System.Drawing.Point(12, 95)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(67, 23)
        Me.OKButton.TabIndex = 2
        Me.OKButton.Text = "OK"
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(85, 95)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(67, 23)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Cancel"
        '
        'ApplyButton
        '
        Me.ApplyButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApplyButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ApplyButton.Location = New System.Drawing.Point(158, 95)
        Me.ApplyButton.Name = "ApplyButton"
        Me.ApplyButton.Size = New System.Drawing.Size(67, 23)
        Me.ApplyButton.TabIndex = 4
        Me.ApplyButton.Text = "Apply"
        '
        'OSSelection
        '
        Me.OSSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OSSelection.FormattingEnabled = True
        Me.OSSelection.Items.AddRange(New Object() {"Windows XP", "Windows Vista", "Windows 7", "Windows 8/8.1"})
        Me.OSSelection.Location = New System.Drawing.Point(85, 21)
        Me.OSSelection.Name = "OSSelection"
        Me.OSSelection.Size = New System.Drawing.Size(109, 21)
        Me.OSSelection.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "OS:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Size:"
        Me.Label2.Visible = False
        '
        'SizeSelection
        '
        Me.SizeSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SizeSelection.FormattingEnabled = True
        Me.SizeSelection.Items.AddRange(New Object() {"100%", "125%", "150%"})
        Me.SizeSelection.Location = New System.Drawing.Point(85, 51)
        Me.SizeSelection.Name = "SizeSelection"
        Me.SizeSelection.Size = New System.Drawing.Size(109, 21)
        Me.SizeSelection.TabIndex = 8
        Me.SizeSelection.Visible = False
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 130)
        Me.Controls.Add(Me.SizeSelection)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OSSelection)
        Me.Controls.Add(Me.ApplyButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.ExitButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents ApplyButton As System.Windows.Forms.Button
    Friend WithEvents OSSelection As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SizeSelection As System.Windows.Forms.ComboBox

End Class
