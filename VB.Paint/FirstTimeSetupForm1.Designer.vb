<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FirstTimeSetupForm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FirstTimeSetupForm1))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Choice7 = New System.Windows.Forms.RadioButton
        Me.ChoiceXP = New System.Windows.Forms.RadioButton
        Me.ConfirmButton = New System.Windows.Forms.Button
        Me.DoneButton = New System.Windows.Forms.Button
        Me.ChoiceSize150 = New System.Windows.Forms.RadioButton
        Me.ChoiceSize100 = New System.Windows.Forms.RadioButton
        Me.ChoiceSize125 = New System.Windows.Forms.RadioButton
        Me.SizeInstructButton = New System.Windows.Forms.Button
        Me.BackButton = New System.Windows.Forms.Button
        Me.ChoiceVista = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thank you for downloading VB.Paint!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(253, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Before starting to use VB.Paint, we need to set it up."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "What OS are you using?"
        '
        'Choice7
        '
        Me.Choice7.AutoSize = True
        Me.Choice7.Location = New System.Drawing.Point(13, 154)
        Me.Choice7.Name = "Choice7"
        Me.Choice7.Size = New System.Drawing.Size(109, 17)
        Me.Choice7.TabIndex = 3
        Me.Choice7.TabStop = True
        Me.Choice7.Text = "Windows 7/8/8.1"
        Me.Choice7.UseVisualStyleBackColor = True
        '
        'ChoiceXP
        '
        Me.ChoiceXP.AutoSize = True
        Me.ChoiceXP.Location = New System.Drawing.Point(13, 114)
        Me.ChoiceXP.Name = "ChoiceXP"
        Me.ChoiceXP.Size = New System.Drawing.Size(86, 17)
        Me.ChoiceXP.TabIndex = 4
        Me.ChoiceXP.TabStop = True
        Me.ChoiceXP.Text = "Windows XP"
        Me.ChoiceXP.UseVisualStyleBackColor = True
        '
        'ConfirmButton
        '
        Me.ConfirmButton.Location = New System.Drawing.Point(179, 130)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(93, 29)
        Me.ConfirmButton.TabIndex = 5
        Me.ConfirmButton.Text = "Confirm Choice"
        Me.ConfirmButton.UseVisualStyleBackColor = True
        '
        'DoneButton
        '
        Me.DoneButton.Enabled = False
        Me.DoneButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoneButton.Location = New System.Drawing.Point(94, 124)
        Me.DoneButton.Name = "DoneButton"
        Me.DoneButton.Size = New System.Drawing.Size(101, 40)
        Me.DoneButton.TabIndex = 6
        Me.DoneButton.Text = "Start using VB.Paint!"
        Me.DoneButton.UseVisualStyleBackColor = True
        Me.DoneButton.Visible = False
        '
        'ChoiceSize150
        '
        Me.ChoiceSize150.AutoSize = True
        Me.ChoiceSize150.Enabled = False
        Me.ChoiceSize150.Location = New System.Drawing.Point(13, 154)
        Me.ChoiceSize150.Name = "ChoiceSize150"
        Me.ChoiceSize150.Size = New System.Drawing.Size(51, 17)
        Me.ChoiceSize150.TabIndex = 7
        Me.ChoiceSize150.TabStop = True
        Me.ChoiceSize150.Text = "150%"
        Me.ChoiceSize150.UseVisualStyleBackColor = True
        Me.ChoiceSize150.Visible = False
        '
        'ChoiceSize100
        '
        Me.ChoiceSize100.AutoSize = True
        Me.ChoiceSize100.Enabled = False
        Me.ChoiceSize100.Location = New System.Drawing.Point(13, 114)
        Me.ChoiceSize100.Name = "ChoiceSize100"
        Me.ChoiceSize100.Size = New System.Drawing.Size(51, 17)
        Me.ChoiceSize100.TabIndex = 8
        Me.ChoiceSize100.TabStop = True
        Me.ChoiceSize100.Text = "100%"
        Me.ChoiceSize100.UseVisualStyleBackColor = True
        Me.ChoiceSize100.Visible = False
        '
        'ChoiceSize125
        '
        Me.ChoiceSize125.AutoSize = True
        Me.ChoiceSize125.Enabled = False
        Me.ChoiceSize125.Location = New System.Drawing.Point(13, 134)
        Me.ChoiceSize125.Name = "ChoiceSize125"
        Me.ChoiceSize125.Size = New System.Drawing.Size(51, 17)
        Me.ChoiceSize125.TabIndex = 9
        Me.ChoiceSize125.TabStop = True
        Me.ChoiceSize125.Text = "125%"
        Me.ChoiceSize125.UseVisualStyleBackColor = True
        Me.ChoiceSize125.Visible = False
        '
        'SizeInstructButton
        '
        Me.SizeInstructButton.Enabled = False
        Me.SizeInstructButton.Location = New System.Drawing.Point(81, 37)
        Me.SizeInstructButton.Name = "SizeInstructButton"
        Me.SizeInstructButton.Size = New System.Drawing.Size(126, 27)
        Me.SizeInstructButton.TabIndex = 10
        Me.SizeInstructButton.Text = "How do I check that?"
        Me.SizeInstructButton.UseVisualStyleBackColor = True
        Me.SizeInstructButton.Visible = False
        '
        'BackButton
        '
        Me.BackButton.Enabled = False
        Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(94, 124)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(101, 40)
        Me.BackButton.TabIndex = 11
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        Me.BackButton.Visible = False
        '
        'ChoiceVista
        '
        Me.ChoiceVista.AutoSize = True
        Me.ChoiceVista.Location = New System.Drawing.Point(13, 134)
        Me.ChoiceVista.Name = "ChoiceVista"
        Me.ChoiceVista.Size = New System.Drawing.Size(95, 17)
        Me.ChoiceVista.TabIndex = 12
        Me.ChoiceVista.TabStop = True
        Me.ChoiceVista.Text = "Windows Vista"
        Me.ChoiceVista.UseVisualStyleBackColor = True
        '
        'FirstTimeSetupForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 184)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SizeInstructButton)
        Me.Controls.Add(Me.ChoiceSize125)
        Me.Controls.Add(Me.ChoiceSize100)
        Me.Controls.Add(Me.ChoiceSize150)
        Me.Controls.Add(Me.DoneButton)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.ChoiceXP)
        Me.Controls.Add(Me.Choice7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChoiceVista)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FirstTimeSetupForm1"
        Me.Text = "VB.Paint Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Choice7 As System.Windows.Forms.RadioButton
    Friend WithEvents ChoiceXP As System.Windows.Forms.RadioButton
    Friend WithEvents ConfirmButton As System.Windows.Forms.Button
    Friend WithEvents DoneButton As System.Windows.Forms.Button
    Friend WithEvents ChoiceSize150 As System.Windows.Forms.RadioButton
    Friend WithEvents ChoiceSize100 As System.Windows.Forms.RadioButton
    Friend WithEvents ChoiceSize125 As System.Windows.Forms.RadioButton
    Friend WithEvents SizeInstructButton As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents ChoiceVista As System.Windows.Forms.RadioButton
End Class
