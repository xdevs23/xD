Namespace Crypto

    Namespace Encryption

        ' SimPle Encryption Algorithm
        Public Structure SPEA

            Private Structure Props

                Public Shared ReadOnly Property    EncryptKeyNum As Int32 = 16
                Public Shared ReadOnly Property RevEncryptKeyNum As Int32 =  4

            End Structure

            Public Shared Function Encrypt(node As Byte()) As Byte()

                Dim en As Int32 = Props.   EncryptKeyNum
                Dim rn As Int32 = Props.RevEncryptKeyNum
                Dim mn As Int32 = 255

                Dim ns64 As String = Crypt.Base64.Encode(node)

                Dim nb64(ns64.Length - 1) As Byte

                nb64 = System.Text.Encoding.UTF8.GetBytes(ns64)

                Dim fecb(nb64.Length - 1) As Byte

                For i As Int32 = 0 To nb64.Length - 1 Step 1
                    If CInt(nb64(i)) + en <= mn Then fecb(i) = Convert.ToByte(nb64(i) + en) _
                    Else fecb(i) = nb64(i)
                Next

                Dim r(fecb.Length - 1) As Byte

                r = fecb

                Return r
            End Function

            Public Shared Function Decrypt(node As Byte()) As Byte()

                Dim en As Int32 = Props.EncryptKeyNum
                Dim rn As Int32 = Props.RevEncryptKeyNum
                Dim mn As Int32 = 255

                Dim fedb(node.Length - 1) As Byte

                For i As Int32 = 0 To node.Length - 1 Step 1
                    Select Case mn
                        Case Is < CInt(node(i)) + en
                            fedb(i) = node(i)
                        Case Else
                            fedb(i) = CByte(node(i) - en)
                    End Select
                Next

                Dim n64 As String = System.Text.Encoding.UTF8.GetString(fedb)

                Dim r As Byte() = Crypt.Base64.Decode(n64)

                Return r

            End Function

        End Structure


    End Namespace

End Namespace