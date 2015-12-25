Imports System.Drawing

Namespace Geometry

    Public Class Triangle

        Private Shared Points As Point() = New Point() {}
        Private Shared Col    As Color   = New Color()

        Public Sub New(base1 As Point, base2 As Point, top As Point, clor As Color)
            Me.Points = New Point() { base1, top, base2 }
            Me.Col = clor
        End Sub

        Public Sub Draw(g As Graphics)
            Using br As New SolidBrush(Me.Col), p As New Pen(Me.Col)
                g.FillPolygon(br, Me.Points)
                g.DrawPolygon(p,  Me.Points)
            End Using
        End Sub

    End Class

End Namespace
