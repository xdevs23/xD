<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CryptoForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SSHAX1Lb = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SPEALb = New System.Windows.Forms.Label()
        Me.speaentestf = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.speadetestf = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.SuspendLayout
        '
        'SSHAX1Lb
        '
        Me.SSHAX1Lb.AutoSize = true
        Me.SSHAX1Lb.Location = New System.Drawing.Point(6, 16)
        Me.SSHAX1Lb.Name = "SSHAX1Lb"
        Me.SSHAX1Lb.Size = New System.Drawing.Size(55, 13)
        Me.SSHAX1Lb.TabIndex = 0
        Me.SSHAX1Lb.Text = "SSHAX1: "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SSHAX1Lb)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 224)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "HashAlgo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.speadetestf)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.speaentestf)
        Me.GroupBox2.Controls.Add(Me.SPEALb)
        Me.GroupBox2.Location = New System.Drawing.Point(350, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(332, 224)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Encryption"
        '
        'SPEALb
        '
        Me.SPEALb.AutoSize = true
        Me.SPEALb.Location = New System.Drawing.Point(6, 16)
        Me.SPEALb.Name = "SPEALb"
        Me.SPEALb.Size = New System.Drawing.Size(35, 13)
        Me.SPEALb.TabIndex = 0
        Me.SPEALb.Text = "SPEA"
        '
        'speaentestf
        '
        Me.speaentestf.Location = New System.Drawing.Point(9, 58)
        Me.speaentestf.Name = "speaentestf"
        Me.speaentestf.Size = New System.Drawing.Size(317, 23)
        Me.speaentestf.TabIndex = 1
        Me.speaentestf.Text = "Encrypt test file"
        Me.speaentestf.UseVisualStyleBackColor = true
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(317, 20)
        Me.TextBox1.TabIndex = 2
        '
        'speadetestf
        '
        Me.speadetestf.Location = New System.Drawing.Point(9, 87)
        Me.speadetestf.Name = "speadetestf"
        Me.speadetestf.Size = New System.Drawing.Size(317, 23)
        Me.speadetestf.TabIndex = 3
        Me.speadetestf.Text = "Decrypt crypted test file"
        Me.speadetestf.UseVisualStyleBackColor = true
        '
        'CryptoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(932, 372)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CryptoForm"
        Me.Text = "Crypto"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents SSHAX1Lb As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents speaentestf As Button
    Friend WithEvents SPEALb As Label
    Friend WithEvents speadetestf As Button
End Class
