Public Class FlatButton

    Inherits System.Windows.Forms.Button


    Private LeftTop     As Rectangle = New Rectangle(           0,             0, 1, 1)
    Private LeftBottom  As Rectangle = New Rectangle(           0, Me.Height - 1, 1, 1)
    Private TopRight    As Rectangle = New Rectangle(Me.Width - 1,             0, 1, 1)
    Private BottomRight As Rectangle = New Rectangle(Me.Width - 1, Me.Height - 1, 1, 1)


    Private BorderDrawerPen As Pen = New Pen(New SolidBrush(Color.FromArgb(255, 255, 255, 255)))

    Sub New()

        Me.ForeColor = Color.FromArgb(255, 255, 255, 255)
        Me.BackColor = Color.FromArgb(255, 30, 139, 229)
        Me.FlatStyle = FlatStyle.Flat
        Me.FlatAppearance.BorderSize = 0
        Me.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 30, 139, 229)
        Me.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 30, 139, 229)
        Me.Font = New Font("Segoe UI", 10.25)

    End Sub

    Private Sub FlatButton_Move(sender As Object, e As EventArgs) Handles Me.Move
        Me.Refresh()
    End Sub

    Private Sub FlatButton_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        LeftTop     = New Rectangle(           0,             0, 1, 1)
        LeftBottom  = New Rectangle(           0, Me.Height - 1, 1, 1)
        TopRight    = New Rectangle(Me.Width - 1,             0, 1, 1)
        BottomRight = New Rectangle(Me.Width - 1, Me.Height - 1, 1, 1)
        e.Graphics.FillRectangle(BorderDrawerPen.Brush, LeftTop)
        e.Graphics.FillRectangle(BorderDrawerPen.Brush, LeftBottom)
        e.Graphics.FillRectangle(BorderDrawerPen.Brush, TopRight)
        e.Graphics.FillRectangle(BorderDrawerPen.Brush, BottomRight)

    End Sub

    Private Sub FlatButton_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Refresh()
    End Sub

    Private Sub FlatButton_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Me.Refresh()
    End Sub

    Private Sub FlatButton_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.Refresh()
    End Sub
End Class
