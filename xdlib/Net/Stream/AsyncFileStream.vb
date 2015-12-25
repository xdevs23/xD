Imports System
Imports System.Net
Imports System.Web
Imports System.Text
Imports System.Threading
Imports System.Management
Imports System.Environment
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.IO

Namespace Net

    Namespace Stream

        Public Class AsyncFileStream

            Public Shared WithEvents Streamer As WebClient _
                                           = New WebClient

            Private Shared WithEvents AsyncWorker As BackgroundWorker _
                                               = New BackgroundWorker()

            Private Shared StreamPreBundle As New List(Of Object)

            Private Shared PublicStreamType As StreamType = StreamType.None

            Public Shared WorkedMemoryStream As MemoryStream = _
                                            New MemoryStream

            Public Shared WorkedByteStream As Byte()

            Public Enum StreamType
                None = 0
                StreamedMemory = 1
                StreamedByte = 2
                StreamedFile = 4
            End Enum

            Public Shared Sub StartAsyncStream(url As String, buffer As Int32, st As StreamType)

                StreamPreBundle.Clear()

                StreamPreBundle.Add(url)
                StreamPreBundle.Add(buffer)
                StreamPreBundle.Add(st)

                PublicStreamType = st

                AsyncWorker.RunWorkerAsync()

            End Sub



            Public Shared Sub StreamWork(sender As Object, e As DoWorkEventArgs) _
                                         Handles AsyncWorker.DoWork

                Dim url As String = _
                    StreamPreBundle(0).ToString()
                Dim bui As Int32 = CInt(
                    StreamPreBundle(1)
                )
                Dim stp As StreamType = PublicStreamType

                If stp = StreamType.StreamedFile Then

                    Streamer.DownloadFileAsync(New Uri(url), "stream.tmp")

                End If




            End Sub


        End Class



    End Namespace

End Namespace