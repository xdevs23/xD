Imports xdlib.Geometry

Namespace UIShapes

    Public Structure Utils

        Public Shared  DrawerPen As Pen = New Pen(New SolidBrush(  Color.FromArgb(255, 255, 255, 255)))
        Public Shared PaddingPen As Pen = New Pen(                 Color.FromArgb(  0,   0,   0,   0) )

        Public Shared Sub DrawControl(rect As Rectangle)

            Dim DrawerPen  As Pen = New Pen(Color.FromArgb(255, 255, 255, 255))
            Dim PaddingPen As Pen = New Pen(Color.FromArgb(  0,   0,   0,   0))
            Dim DrawerGraphics As Graphics = MainV.CreateGraphics()

            DrawerGraphics.DrawRectangle(DrawerPen, rect)

            DrawerGraphics.Dispose()

        End Sub

    End Structure

    Public Structure MainDef

        Public Shared ReadOnly Pad As Int32 = 1,
                            Margin As Int32 = 7

        Public Shared ReadOnly Color As Color = Color.FromArgb(255, 255, 255, 255)

    End Structure

    ' Pause control
    Public Structure Pause

        Private Shared ReadOnly Width As Int32 =  5,
                               Height As Int32 = 18,
                                  Pad As Int32 = MainDef.Pad,
                               Margin As Int32 = MainDef.Margin


        ' Left piece
        Public Shared Left As Rectangle _
                        = New Rectangle(
                            New Point(Margin, Margin),
                            New Size (Width,  Height)
                          )

        ' Middle Padding
        Public Shared Padding As Rectangle _
                           = New Rectangle(
                               New Point(Margin, Margin),
                               New Size (   Pad, Height)
                             )

        ' Right piece
        Public Shared Right As Rectangle _
                         = New Rectangle(
                             New Point(Width + 8 + Margin, Margin),
                             New Size (Width,              Height)
                           )

        Public Shared Sub Draw(g As Graphics)
         g.FillRectangle(Utils. DrawerPen.Brush, Left   )
         g.FillRectangle(Utils.PaddingPen.Brush, Padding)
         g.FillRectangle(Utils. DrawerPen.Brush, Right  )
        End Sub

    End Structure

    ' Stop control
    Public Structure StopPlayback

        Private Shared Width As Int32 = 18,
                      Height As Int32 = Width
        
        Public Shared Control As Rectangle _
                           = New Rectangle(
                               New Point(MainDef.Margin, MainDef.Margin),
                               New Size(Width, Height)
                             )

    End Structure

    ' Play control
    Public Structure Play

        Private Shared Width As Int32 =    24,
                      Height As Int32 = Width,
                      bPoint As Int32 =     6,
                       wbPnt As Int32 = bPoint + 4,        
               defaultOffset As Int32 = 0, ' Remember to use negative values for bottom paddings and negative paddings
                   topOffset As Int32 = 1,
                bottomOffset As Int32 = defaultOffset,
                 rightOffset As Int32 = defaultOffset,
                  leftOffset As Int32 = defaultOffset

        Public Shared Control As Triangle = New Triangle(New Point(wbPnt, bPoint +    topOffset), ' Top    left edge
                                                         New Point(wbPnt, Height + bottomOffset), ' Bottom left edge
                                                         New Point(Width, CInt( Height / 2 ) + CInt( Math.Round(bPoint / 3) + topOffset)), ' right middle edge
                                                            MainDef.Color)


    End Structure


End Namespace