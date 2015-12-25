Imports System.Text

Namespace Crypto

    Namespace HashAlgo

        Public Structure SSHAX1

            Public Shared ReadOnly GeneratedBytes() As Byte = {128, 192}

            Public Shared ReadOnly HashLength As Int32 = 6

            Public Shared Function Hash(node() As Byte) As String
                Dim h As String = String.Empty

                If Not node.Length <= 4 Then

                    Dim r(HashLength) As Byte
                    Dim s As String = String.Empty

                    Dim fsb As Byte = Byte.MinValue
                    Dim ssb As Byte = Byte.MinValue
                    Dim lsb As Byte = Byte.MinValue
                    Dim nrb As Byte = Byte.MinValue

                    fsb = node(0)
                    ssb = node(1)
                    lsb = node(node.Length - 1)
                    nrb = 0

                    r(0) = ssb
                    r(1) = lsb
                    r(2) = nrb
                    r(3) = GeneratedBytes(1)
                    r(4) = lsb
                    r(5) = GeneratedBytes(0)

                    s = BitConverter.ToString(r, 0, HashLength).Replace("-", String.Empty) _
                                                               .Replace("0", "Y") _
                                                               .Replace("B", "0") _
                                                               .Replace("Y", "B")


                    For i = 1 To s.Length - 1 Step 2
                        h &= s(i)
                    Next

                Else
                    h = DefaultValues.ExceptionReturn
                End If

                Return h
            End Function

            Public Shared Function HashBinary(filename As String) As String
                Dim h As String = String.Empty
                h = Hash(ReadByteUtils.FileReadBytes(filename))
                Return h
            End Function

            Public Shared Function HashString(node As String) As String
                Dim e As Encoding = Encoding.UTF8

                Return Hash(e.GetBytes(node))
            End Function

        End Structure

    End Namespace

End Namespace