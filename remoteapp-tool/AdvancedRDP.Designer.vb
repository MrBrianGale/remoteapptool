<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdvancedRDP
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdvancedRDP))
        Me.Save = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.MicrophoneSettings = New System.Windows.Forms.ComboBox()
        Me.SpeakerSettings = New System.Windows.Forms.ComboBox()
        Me.MicLabel = New System.Windows.Forms.Label()
        Me.SpeakerLabel = New System.Windows.Forms.Label()
        Me.WarningRTB = New System.Windows.Forms.RichTextBox()
        Me.AudioGroupbox = New System.Windows.Forms.GroupBox()
        Me.InstructionsLabel = New System.Windows.Forms.Label()
        Me.SmallerIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.AudioGroupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Save.ImageKey = "16.ico"
        Me.Save.ImageList = Me.SmallerIcons
        Me.Save.Location = New System.Drawing.Point(634, 407)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(69, 31)
        Me.Save.TabIndex = 0
        Me.Save.Text = "Save"
        Me.Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Save.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Cancel.ImageKey = "cross.ico"
        Me.Cancel.ImageList = Me.SmallerIcons
        Me.Cancel.Location = New System.Drawing.Point(721, 407)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(67, 31)
        Me.Cancel.TabIndex = 1
        Me.Cancel.Text = "Cancel"
        Me.Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'MicrophoneSettings
        '
        Me.MicrophoneSettings.FormattingEnabled = True
        Me.MicrophoneSettings.Location = New System.Drawing.Point(127, 25)
        Me.MicrophoneSettings.Name = "MicrophoneSettings"
        Me.MicrophoneSettings.Size = New System.Drawing.Size(121, 21)
        Me.MicrophoneSettings.TabIndex = 2
        '
        'SpeakerSettings
        '
        Me.SpeakerSettings.FormattingEnabled = True
        Me.SpeakerSettings.Location = New System.Drawing.Point(127, 71)
        Me.SpeakerSettings.Name = "SpeakerSettings"
        Me.SpeakerSettings.Size = New System.Drawing.Size(121, 21)
        Me.SpeakerSettings.TabIndex = 3
        '
        'MicLabel
        '
        Me.MicLabel.AutoSize = True
        Me.MicLabel.Location = New System.Drawing.Point(17, 28)
        Me.MicLabel.Name = "MicLabel"
        Me.MicLabel.Size = New System.Drawing.Size(104, 13)
        Me.MicLabel.TabIndex = 4
        Me.MicLabel.Text = "Microphone Settings"
        '
        'SpeakerLabel
        '
        Me.SpeakerLabel.AutoSize = True
        Me.SpeakerLabel.Location = New System.Drawing.Point(17, 74)
        Me.SpeakerLabel.Name = "SpeakerLabel"
        Me.SpeakerLabel.Size = New System.Drawing.Size(91, 13)
        Me.SpeakerLabel.TabIndex = 5
        Me.SpeakerLabel.Text = "Speaker Settings:"
        '
        'WarningRTB
        '
        Me.WarningRTB.BackColor = System.Drawing.SystemColors.Control
        Me.WarningRTB.Enabled = False
        Me.WarningRTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WarningRTB.ForeColor = System.Drawing.Color.Red
        Me.WarningRTB.Location = New System.Drawing.Point(12, 12)
        Me.WarningRTB.Name = "WarningRTB"
        Me.WarningRTB.Size = New System.Drawing.Size(776, 108)
        Me.WarningRTB.TabIndex = 6
        Me.WarningRTB.Text = resources.GetString("WarningRTB.Text")
        '
        'AudioGroupbox
        '
        Me.AudioGroupbox.Controls.Add(Me.MicLabel)
        Me.AudioGroupbox.Controls.Add(Me.MicrophoneSettings)
        Me.AudioGroupbox.Controls.Add(Me.SpeakerLabel)
        Me.AudioGroupbox.Controls.Add(Me.SpeakerSettings)
        Me.AudioGroupbox.Location = New System.Drawing.Point(12, 159)
        Me.AudioGroupbox.Name = "AudioGroupbox"
        Me.AudioGroupbox.Size = New System.Drawing.Size(318, 100)
        Me.AudioGroupbox.TabIndex = 7
        Me.AudioGroupbox.TabStop = False
        Me.AudioGroupbox.Text = "Audio Settings"
        '
        'InstructionsLabel
        '
        Me.InstructionsLabel.AutoSize = True
        Me.InstructionsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructionsLabel.Location = New System.Drawing.Point(12, 123)
        Me.InstructionsLabel.Name = "InstructionsLabel"
        Me.InstructionsLabel.Size = New System.Drawing.Size(318, 20)
        Me.InstructionsLabel.TabIndex = 8
        Me.InstructionsLabel.Text = "Hover over a setting to see description"
        '
        'SmallerIcons
        '
        Me.SmallerIcons.ImageStream = CType(resources.GetObject("SmallerIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.SmallerIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.SmallerIcons.Images.SetKeyName(0, "save-as_16x16.png")
        Me.SmallerIcons.Images.SetKeyName(1, "msi small.ico")
        Me.SmallerIcons.Images.SetKeyName(2, "doc_file_document_manager_paper_phone.ico")
        Me.SmallerIcons.Images.SetKeyName(3, "16.ico")
        Me.SmallerIcons.Images.SetKeyName(4, "cross.ico")
        Me.SmallerIcons.Images.SetKeyName(5, "pictures (1).ico")
        Me.SmallerIcons.Images.SetKeyName(6, "Remote Desktop Connection.ico")
        '
        'AdvancedRDP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.InstructionsLabel)
        Me.Controls.Add(Me.AudioGroupbox)
        Me.Controls.Add(Me.WarningRTB)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Save)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdvancedRDP"
        Me.Text = "AdvancedRDP"
        Me.AudioGroupbox.ResumeLayout(False)
        Me.AudioGroupbox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Save As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents MicrophoneSettings As ComboBox
    Friend WithEvents SpeakerSettings As ComboBox
    Friend WithEvents MicLabel As Label
    Friend WithEvents SpeakerLabel As Label
    Friend WithEvents WarningRTB As RichTextBox
    Friend WithEvents AudioGroupbox As GroupBox
    Friend WithEvents InstructionsLabel As Label
    Friend WithEvents SmallerIcons As ImageList
End Class
