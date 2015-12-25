Imports System.Collections.Generic

Namespace Converting

    Namespace TypeConversion

        Namespace ListConverter

            Public Class StringListConverter

                Public Shared Function ToList(str As String()) As List(Of String)
                    Dim lst As New List(Of String)

                    For Each s As String In str
                        lst.Add(s)
                    Next

                    Return lst
                End Function

                Public Shadows Shared Function ToString(lst As List(Of String)) As String()
                    Return lst.ToArray()
                End Function

            End Class

        End Namespace

    End Namespace

End Namespace