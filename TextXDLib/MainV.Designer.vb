﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainV
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
        Me.CryptoFormbtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'CryptoFormbtn
        '
        Me.CryptoFormbtn.Location = New System.Drawing.Point(12, 12)
        Me.CryptoFormbtn.Name = "CryptoFormbtn"
        Me.CryptoFormbtn.Size = New System.Drawing.Size(75, 23)
        Me.CryptoFormbtn.TabIndex = 0
        Me.CryptoFormbtn.Text = "Crypto"
        Me.CryptoFormbtn.UseVisualStyleBackColor = true
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Managing"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'MainV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 269)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CryptoFormbtn)
        Me.Name = "MainV"
        Me.Text = "Test"
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents CryptoFormbtn As Button
    Friend WithEvents Button1 As Button
End Class
