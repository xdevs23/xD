<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainV))
        Me.RePlayButton = New System.Windows.Forms.CheckBox()
        Me.MediaPositionLb = New System.Windows.Forms.Label()
        Me.MediaLengthLb = New System.Windows.Forms.Label()
        Me.SingleMediaDialog = New System.Windows.Forms.OpenFileDialog()
        Me.MediaPositionTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MediaDirListBox = New System.Windows.Forms.ListBox()
        Me.MultiMediaDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.MediaPositionProgress = New System.Windows.Forms.Panel()
        Me.MediaPosip = New System.Windows.Forms.Panel()
        Me.byLabel = New System.Windows.Forms.Label()
        Me.OpenMediaStreamBtn = New xdui.FlatButton()
        Me.GoBackButton = New xdui.FlatButton()
        Me.GoFwdButton = New xdui.FlatButton()
        Me.OpenDirButton = New xdui.FlatButton()
        Me.StopButton = New xdui.FlatButtonRound()
        Me.PausePlayButton = New xdui.FlatButtonRound()
        Me.OpenMediaButton = New xdui.FlatButton()
        Me.MediaPositionProgress.SuspendLayout()
        Me.SuspendLayout()
        '
        'RePlayButton
        '
        Me.RePlayButton.AutoSize = True
        Me.RePlayButton.Location = New System.Drawing.Point(230, 193)
        Me.RePlayButton.Name = "RePlayButton"
        Me.RePlayButton.Size = New System.Drawing.Size(86, 17)
        Me.RePlayButton.TabIndex = 3
        Me.RePlayButton.Text = "Wiederholen"
        Me.RePlayButton.UseVisualStyleBackColor = True
        '
        'MediaPositionLb
        '
        Me.MediaPositionLb.AutoSize = True
        Me.MediaPositionLb.Location = New System.Drawing.Point(12, 151)
        Me.MediaPositionLb.Name = "MediaPositionLb"
        Me.MediaPositionLb.Size = New System.Drawing.Size(28, 13)
        Me.MediaPositionLb.TabIndex = 6
        Me.MediaPositionLb.Text = "--:--  "
        '
        'MediaLengthLb
        '
        Me.MediaLengthLb.AutoSize = True
        Me.MediaLengthLb.Location = New System.Drawing.Point(684, 151)
        Me.MediaLengthLb.Name = "MediaLengthLb"
        Me.MediaLengthLb.Size = New System.Drawing.Size(28, 13)
        Me.MediaLengthLb.TabIndex = 7
        Me.MediaLengthLb.Text = "--:--  "
        '
        'SingleMediaDialog
        '
        Me.SingleMediaDialog.Filter = "Audio-Dateien|*.mp3; *.aac; *.ogg; *.flac; *.ac3; *.cda; *.wav.|Alle Dateien|*.*"
        Me.SingleMediaDialog.InitialDirectory = "\Users\%USERNAME%\Music"
        Me.SingleMediaDialog.SupportMultiDottedExtensions = True
        Me.SingleMediaDialog.Title = "Audio-Datei auswählen"
        '
        'MediaPositionTimer
        '
        Me.MediaPositionTimer.Interval = 500
        '
        'MediaDirListBox
        '
        Me.MediaDirListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MediaDirListBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MediaDirListBox.ItemHeight = 15
        Me.MediaDirListBox.Location = New System.Drawing.Point(12, 47)
        Me.MediaDirListBox.Name = "MediaDirListBox"
        Me.MediaDirListBox.ScrollAlwaysVisible = True
        Me.MediaDirListBox.Size = New System.Drawing.Size(700, 90)
        Me.MediaDirListBox.TabIndex = 8
        '
        'MediaPositionProgress
        '
        Me.MediaPositionProgress.Controls.Add(Me.MediaPosip)
        Me.MediaPositionProgress.Location = New System.Drawing.Point(12, 169)
        Me.MediaPositionProgress.Name = "MediaPositionProgress"
        Me.MediaPositionProgress.Size = New System.Drawing.Size(700, 10)
        Me.MediaPositionProgress.TabIndex = 12
        '
        'MediaPosip
        '
        Me.MediaPosip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MediaPosip.BackColor = System.Drawing.SystemColors.Highlight
        Me.MediaPosip.Location = New System.Drawing.Point(0, 0)
        Me.MediaPosip.Margin = New System.Windows.Forms.Padding(0)
        Me.MediaPosip.Name = "MediaPosip"
        Me.MediaPosip.Size = New System.Drawing.Size(115, 10)
        Me.MediaPosip.TabIndex = 13
        '
        'byLabel
        '
        Me.byLabel.AutoSize = True
        Me.byLabel.ForeColor = System.Drawing.Color.Silver
        Me.byLabel.Location = New System.Drawing.Point(651, 9)
        Me.byLabel.Name = "byLabel"
        Me.byLabel.Size = New System.Drawing.Size(61, 13)
        Me.byLabel.TabIndex = 13
        Me.byLabel.Text = "by xdevs23"
        '
        'OpenMediaStreamBtn
        '
        Me.OpenMediaStreamBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.OpenMediaStreamBtn.FlatAppearance.BorderSize = 0
        Me.OpenMediaStreamBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.OpenMediaStreamBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.OpenMediaStreamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OpenMediaStreamBtn.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.OpenMediaStreamBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OpenMediaStreamBtn.Location = New System.Drawing.Point(322, 12)
        Me.OpenMediaStreamBtn.Name = "OpenMediaStreamBtn"
        Me.OpenMediaStreamBtn.Size = New System.Drawing.Size(120, 29)
        Me.OpenMediaStreamBtn.TabIndex = 14
        Me.OpenMediaStreamBtn.Text = "Online öffnen"
        Me.OpenMediaStreamBtn.UseVisualStyleBackColor = False
        '
        'GoBackButton
        '
        Me.GoBackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GoBackButton.FlatAppearance.BorderSize = 0
        Me.GoBackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GoBackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GoBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GoBackButton.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.GoBackButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GoBackButton.Location = New System.Drawing.Point(467, 185)
        Me.GoBackButton.Name = "GoBackButton"
        Me.GoBackButton.Size = New System.Drawing.Size(49, 29)
        Me.GoBackButton.TabIndex = 11
        Me.GoBackButton.Text = "<<"
        Me.GoBackButton.UseVisualStyleBackColor = False
        '
        'GoFwdButton
        '
        Me.GoFwdButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GoFwdButton.FlatAppearance.BorderSize = 0
        Me.GoFwdButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GoFwdButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GoFwdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GoFwdButton.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.GoFwdButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GoFwdButton.Location = New System.Drawing.Point(522, 185)
        Me.GoFwdButton.Name = "GoFwdButton"
        Me.GoFwdButton.Size = New System.Drawing.Size(49, 29)
        Me.GoFwdButton.TabIndex = 10
        Me.GoFwdButton.Text = ">>"
        Me.GoFwdButton.UseVisualStyleBackColor = False
        '
        'OpenDirButton
        '
        Me.OpenDirButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.OpenDirButton.FlatAppearance.BorderSize = 0
        Me.OpenDirButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.OpenDirButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.OpenDirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OpenDirButton.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.OpenDirButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OpenDirButton.Location = New System.Drawing.Point(133, 12)
        Me.OpenDirButton.Name = "OpenDirButton"
        Me.OpenDirButton.Size = New System.Drawing.Size(183, 29)
        Me.OpenDirButton.TabIndex = 9
        Me.OpenDirButton.Text = "Ordnerinhalt abspielen"
        Me.OpenDirButton.UseVisualStyleBackColor = False
        '
        'StopButton
        '
        Me.StopButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.StopButton.FlatAppearance.BorderSize = 0
        Me.StopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.StopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StopButton.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.StopButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StopButton.Location = New System.Drawing.Point(50, 183)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(32, 32)
        Me.StopButton.TabIndex = 5
        Me.StopButton.UseVisualStyleBackColor = False
        '
        'PausePlayButton
        '
        Me.PausePlayButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.PausePlayButton.FlatAppearance.BorderSize = 0
        Me.PausePlayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.PausePlayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.PausePlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PausePlayButton.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.PausePlayButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PausePlayButton.Location = New System.Drawing.Point(12, 183)
        Me.PausePlayButton.Name = "PausePlayButton"
        Me.PausePlayButton.Size = New System.Drawing.Size(32, 32)
        Me.PausePlayButton.TabIndex = 4
        Me.PausePlayButton.UseVisualStyleBackColor = False
        '
        'OpenMediaButton
        '
        Me.OpenMediaButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.OpenMediaButton.FlatAppearance.BorderSize = 0
        Me.OpenMediaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.OpenMediaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.OpenMediaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OpenMediaButton.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.OpenMediaButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OpenMediaButton.Location = New System.Drawing.Point(12, 12)
        Me.OpenMediaButton.Name = "OpenMediaButton"
        Me.OpenMediaButton.Size = New System.Drawing.Size(115, 29)
        Me.OpenMediaButton.TabIndex = 0
        Me.OpenMediaButton.Text = "Datei öffnen"
        Me.OpenMediaButton.UseVisualStyleBackColor = False
        '
        'MainV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(724, 224)
        Me.Controls.Add(Me.OpenMediaStreamBtn)
        Me.Controls.Add(Me.byLabel)
        Me.Controls.Add(Me.MediaPositionProgress)
        Me.Controls.Add(Me.GoBackButton)
        Me.Controls.Add(Me.GoFwdButton)
        Me.Controls.Add(Me.OpenDirButton)
        Me.Controls.Add(Me.MediaDirListBox)
        Me.Controls.Add(Me.MediaLengthLb)
        Me.Controls.Add(Me.MediaPositionLb)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.PausePlayButton)
        Me.Controls.Add(Me.RePlayButton)
        Me.Controls.Add(Me.OpenMediaButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainV"
        Me.ShowIcon = False
        Me.Text = "xDPlayer"
        Me.MediaPositionProgress.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenMediaButton As xdui.FlatButton
    Friend WithEvents RePlayButton As System.Windows.Forms.CheckBox
    Friend WithEvents PausePlayButton As xdui.FlatButtonRound
    Friend WithEvents StopButton As xdui.FlatButtonRound
    Friend WithEvents MediaPositionLb As System.Windows.Forms.Label
    Friend WithEvents MediaLengthLb As System.Windows.Forms.Label
    Friend WithEvents SingleMediaDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MediaPositionTimer As System.Windows.Forms.Timer
    Friend WithEvents MediaDirListBox As System.Windows.Forms.ListBox
    Friend WithEvents OpenDirButton As xdui.FlatButton
    Friend WithEvents MultiMediaDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents GoFwdButton As xdui.FlatButton
    Friend WithEvents GoBackButton As xdui.FlatButton
    Friend WithEvents MediaPositionProgress As System.Windows.Forms.Panel
    Friend WithEvents MediaPosip As System.Windows.Forms.Panel
    Friend WithEvents byLabel As System.Windows.Forms.Label
    Friend WithEvents OpenMediaStreamBtn As xdui.FlatButton

End Class
