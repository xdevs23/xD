Imports System.Drawing.Drawing2D

Public Class FlatButtonRound

    Inherits FlatButton

    Private RoundConstr As New GraphicsPath
    Private Rect        As     RectangleF = Nothing


    Sub New()
        Rect = New RectangleF(0, 0, Me.Width, Me.Height)
        RoundConstr.AddEllipse(Rect)
        Me.Region = New Region(RoundConstr)
    End Sub

    Private Sub FlatButtonRound_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Rect = New RectangleF(0, 0, Me.Width, Me.Height)
        RoundConstr.Reset()
        RoundConstr.AddEllipse(Rect)
        Me.Region = New Region(RoundConstr)
    End Sub
End Class
