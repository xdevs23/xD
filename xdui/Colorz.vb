Namespace Colorz

    Namespace ColorEffects

        Public Structure Rainbow

            Private Enum cr
                R = 0
                G = 1
                B = 2
            End Enum

            Public Shared Function GetNextColor(actualColor As Color) As Color
                Dim newColor As Color = New Color()
                Dim c As List(Of Int32) = New List(Of Int32)

                Select Case actualColor.R
                    Case Is >= 254
                        c.Add(0)
                    Case Else
                        c.Add(actualColor.R + 2)
                End Select

                Select Case actualColor.G
                    Case Is >= 254
                        c.Add(0)
                    Case Else
                        c.Add(actualColor.G + 2)
                End Select

                Select Case actualColor.B
                    Case Is >= 254
                        c.Add(0)
                    Case Else
                        c.Add(actualColor.B + 2)
                End Select

                newColor = Color.FromArgb(255, c(cr.R), c(cr.G), c(cr.B))

                Return newColor
            End Function

        End Structure

    End Namespace

End Namespace
