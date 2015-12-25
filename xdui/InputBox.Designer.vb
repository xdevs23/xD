<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputBox
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
        Me.BoxText = New System.Windows.Forms.Label()
        Me.InText = New System.Windows.Forms.TextBox()
        Me.OKBtn = New xdui.FlatButton()
        Me.SuspendLayout()
        '
        'BoxText
        '
        Me.BoxText.AutoSize = True
        Me.BoxText.Location = New System.Drawing.Point(13, 13)
        Me.BoxText.Name = "BoxText"
        Me.BoxText.Size = New System.Drawing.Size(70, 13)
        Me.BoxText.TabIndex = 0
        Me.BoxText.Text = "InputBoxText"
        '
        'InText
        '
        Me.InText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InText.Location = New System.Drawing.Point(16, 29)
        Me.InText.Name = "InText"
        Me.InText.Size = New System.Drawing.Size(386, 20)
        Me.InText.TabIndex = 1
        '
        'OKBtn
        '
        Me.OKBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.OKBtn.FlatAppearance.BorderSize = 0
        Me.OKBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.OKBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.OKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKBtn.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.OKBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OKBtn.Location = New System.Drawing.Point(338, 107)
        Me.OKBtn.Name = "OKBtn"
        Me.OKBtn.Size = New System.Drawing.Size(64, 32)
        Me.OKBtn.TabIndex = 2
        Me.OKBtn.Text = "OK"
        Me.OKBtn.UseVisualStyleBackColor = False
        '
        'InputBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(414, 151)
        Me.Controls.Add(Me.OKBtn)
        Me.Controls.Add(Me.InText)
        Me.Controls.Add(Me.BoxText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InputBox"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InputBoxTitle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents BoxText As System.Windows.Forms.Label
    Public WithEvents InText As System.Windows.Forms.TextBox
    Public WithEvents OKBtn As xdui.FlatButton
End Class
