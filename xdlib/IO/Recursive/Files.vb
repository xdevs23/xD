Imports System.IO

Namespace IO
    Namespace Recursive

        Public Structure Files

            Public Shared Function Rename(path As String, filename As String, newFilename As String) As Boolean

                Try
                    Dim fullpath As String _
                              = String.Empty

                    For Each d As String In System.IO.Directory.GetDirectories(path)

                        fullpath = System.IO.Path.GetFullPath(d) & "\" & filename

                        If File.Exists(fullpath) Then _
                        FileUtils.RenameFile(fullpath, newFilename)

                    Next


                    Return True
                Catch ex As Exception
                    Return False
                End Try

            End Function

        End Structure

    End Namespace
End Namespace