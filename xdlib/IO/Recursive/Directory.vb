Imports System.IO

Namespace IO
    Namespace Recursive

        Public Structure Directory

            ' Delete all directories and files recursively
            Public Shared Function Delete(dirname As String) As Boolean

                Try
                    For Each f As String In System.IO.Directory.GetFiles(dirname)
                        File.Delete(f)
                    Next

                    For Each d As String In System.IO.Directory.GetDirectories(dirname)
                        System.IO.Directory.Delete(d)
                    Next

                    System.IO.Directory.Delete(dirname)

                    Return True
                Catch ex As Exception
                    Return False
                End Try

            End Function

        End Structure




    End Namespace
End Namespace
