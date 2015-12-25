Imports System
Imports System.Net
Imports System.Web
Imports System.Text

Namespace Net

    Public Structure DownloadUtils

        ' Specify class DownElements to use
        ' elements with events
        Partial Private Class DownElements

            Public Shared WithEvents MWebClient As WebClient _
                                             = New WebClient

            Private Shared Sub MWebClient_DownloadFileCompleted(sender As Object, e As ComponentModel.AsyncCompletedEventArgs) Handles MWebClient.DownloadFileCompleted
                PublicDownElements.IsFinished = True
            End Sub



            Private Shared Sub MWebClient_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles MWebClient.DownloadProgressChanged
                PublicDownElements.DownloadedLength     = e.BytesReceived
                PublicDownElements.DownloadedPercentage = e.ProgressPercentage
                PublicDownElements.ToDownloadLength     = e.TotalBytesToReceive - e.BytesReceived
                PublicDownElements.IsFinished = False
            End Sub
        End Class

        Public Class PublicDownElements

            Public Shared WithEvents MWebClient As WebClient = DownElements.MWebClient
            Public Shared DownloadedLength      As Int64 =  0
            Public Shared DownloadedPercentage  As Int32 =  0
            Public Shared ToDownloadLength      As Int64 = -1
            Public Shared DestinationFile As  String = ""
            Public Shared IsFinished      As Boolean = True

        End Class

        ' Download a string from any web server with charset UTF-8
        Public Shared Function GetOnlineString(url As String) As String

            Dim r As String = ""

            With DownElements.MWebClient

                .Encoding = Encoding.UTF8

                r = .DownloadString(url)

            End With

            Return r

        End Function

        ' Download File asynchronously
        Public Shared Sub DownloadFile(url As String, filename As String)

            PublicDownElements.DestinationFile = filename
            DownElements.MWebClient.DownloadFileAsync(New Uri(url), filename)

        End Sub

    End Structure

End Namespace