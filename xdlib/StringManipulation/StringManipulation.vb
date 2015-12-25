Namespace StringManipulation

    Public Class ArrayManipulation

        Public Shared Function Implode(array As String(), Optional glue As String = vbLf, Optional appendLast As Boolean = False) As String
            Dim Imploded As String = String.Empty
            Dim sb As New Text.StringBuilder

            For Each s As String In array
                sb.Append(s).Append(glue)
            Next

            Imploded = sb.ToString()

            Return Imploded
        End Function

        Public Shared Function Explode(Imploded As String, Optional explosive As String = vbLf) As String()
            Return Imploded.Split(CChar(explosive))
        End Function

    End Class


End Namespace