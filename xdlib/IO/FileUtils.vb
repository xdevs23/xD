Imports System.IO

Namespace IO

    Public Structure FileUtils

        Public Shared Sub RenameFile(path As String, newFilename As String)
            File.Move(path, newFilename)
        End Sub

    End Structure


End Namespace