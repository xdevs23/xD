<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagingForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.FT = New System.Windows.Forms.TextBox()
        Me.ST = New System.Windows.Forms.TextBox()
        Me.TT = New System.Windows.Forms.TextBox()
        Me.OT = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout
        Me.GroupBox3.SuspendLayout
        Me.GroupBox4.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.SuspendLayout
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(759, 326)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Configuration"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Location = New System.Drawing.Point(534, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(225, 301)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = false
        Me.GroupBox3.Text = "TypeStorage"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Panel1)
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.TextBox3)
        Me.GroupBox4.Controls.Add(Me.TextBox2)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = false
        Me.GroupBox4.Text = "TColor"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(178, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(16, 43)
        Me.Panel1.TabIndex = 5
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(7, 71)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(165, 23)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "Read"
        Me.Button6.UseVisualStyleBackColor = true
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(7, 47)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(165, 23)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Save"
        Me.Button5.UseVisualStyleBackColor = true
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(64, 20)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(51, 20)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = "G"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(121, 20)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(51, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "B"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(51, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "R"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.FT)
        Me.GroupBox2.Controls.Add(Me.ST)
        Me.GroupBox2.Controls.Add(Me.TT)
        Me.GroupBox2.Controls.Add(Me.OT)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(522, 301)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Filesystem"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(7, 217)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(509, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Show Comments"
        Me.Button4.UseVisualStyleBackColor = true
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(7, 166)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Reset"
        Me.Button3.UseVisualStyleBackColor = true
        '
        'FT
        '
        Me.FT.Location = New System.Drawing.Point(254, 116)
        Me.FT.Name = "FT"
        Me.FT.Size = New System.Drawing.Size(241, 20)
        Me.FT.TabIndex = 5
        '
        'ST
        '
        Me.ST.Location = New System.Drawing.Point(254, 89)
        Me.ST.Name = "ST"
        Me.ST.Size = New System.Drawing.Size(241, 20)
        Me.ST.TabIndex = 4
        '
        'TT
        '
        Me.TT.Location = New System.Drawing.Point(7, 116)
        Me.TT.Name = "TT"
        Me.TT.Size = New System.Drawing.Size(241, 20)
        Me.TT.TabIndex = 3
        '
        'OT
        '
        Me.OT.Location = New System.Drawing.Point(7, 89)
        Me.OT.Name = "OT"
        Me.OT.Size = New System.Drawing.Size(241, 20)
        Me.OT.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(7, 49)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(509, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Read test config"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(509, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Save test config"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(296, 166)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(199, 23)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Read from custom file"
        Me.Button7.UseVisualStyleBackColor = true
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ManagingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(783, 396)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ManagingForm"
        Me.Text = "Managing"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox4.ResumeLayout(false)
        Me.GroupBox4.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents OT As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents FT As TextBox
    Friend WithEvents ST As TextBox
    Friend WithEvents TT As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
