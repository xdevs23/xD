Namespace Crypto

    Namespace HashAlgo

        Public Structure DefaultValues

            Public Shared ReadOnly Property ExceptionReturn As String
                Get
                    Return "<!ERR>"
                End Get
            End Property

        End Structure

        Public Structure ReadByteUtils

            Public Shared Function FileReadBytes(filename As String) As Byte()
                Return System.IO.File.ReadAllBytes(filename)
            End Function

        End Structure

    End Namespace

End Namespace