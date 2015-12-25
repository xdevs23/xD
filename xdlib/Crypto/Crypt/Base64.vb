Imports System.Text

Namespace Crypto

    Namespace Crypt

        Public Structure Base64

            Public Shared Function Encode(node As Byte()) As String
                Return Convert.ToBase64String(node, Base64FormattingOptions.None)
            End Function

            Public Shared Function Decode(bstr As String) As Byte()
                Return Convert.FromBase64String(bstr)
            End Function

            Public Shared Function GetDecodedString(bbyte As Byte()) As String
                Dim e As Encoding = New UTF8Encoding

                Return e.GetString(bbyte)
            End Function

            Public Shared Function DecodeToString(node As String) As String
                Return GetDecodedString(Decode(node))
            End Function

        End Structure

    End Namespace

End Namespace