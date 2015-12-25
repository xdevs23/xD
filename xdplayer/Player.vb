Imports System.Windows.Forms
Imports xdplay.libZPlay

Public Class Player

    Public Enum ExecutionMode
        Hidden = 1
        Console = 2
        GUI = 4
        Other = 256
    End Enum

    Public Class Play
        Public Shared xplayer As New ZPlay

        Public Shared WithEvents xPlayListener As New Timer

        Public  Shared PlayStreamInfo     As New TStreamInfo
        Private Shared PlayStreamPosition As New TStreamTime

        Private Shared SecuredIntialPlay As Boolean = True

        Private Shared Sub xPlayListen() Handles xPlayListener.Tick
            If SecuredIntialPlay = False Then
                xplayer.GetStreamInfo(PlayStreamInfo)
                xplayer.GetPosition  (PlayStreamPosition)

                If PlayStreamPosition.samples >= PlayStreamInfo.Length.samples Or
                   PlayStreamPosition.samples <= 1 Then
                    If IsLoopingPlay = True Then
                        xplayer.StartPlayback()
                        SecuredIntialPlay = True
                    Else
                        xplayer.Close()
                        If PublicExecMode = ExecutionMode.Console Or
                           PublicExecMode = ExecutionMode.Hidden Then Application.Exit()
                    End If
                End If
            Else
                SecuredIntialPlay = False
            End If
        End Sub
    End Class

    Public Structure ArgParser

        Public Enum ArgumentResult
            None      =   0
            Play      =   1
            LoopTrack =   2
            Other     = 256
        End Enum

        Public Shared Function IsArgumentAvailable(arg As Object) As Boolean
            If TypeOf arg Is String Then
                If Not CStr(arg) = "" Then Return True _
                Else Return False
            Else
                If Not arg Is Nothing Then Return True _
                Else Return False
            End If
        End Function

        Public Shared Function IsArrayAvailable(array As Object()) As Boolean

            Return (array.Length > 0)

        End Function

        Public Shared Function IsArrayIndexAvailable(array As Object(), i As Integer) As Boolean

            Return (array.Length >= i + 1)

        End Function

        Public Shared Function GetArgumentResult(args As String(), i As Integer) As ArgumentResult

            If IsArrayIndexAvailable(args, i) Then
                Select Case args(i).ToLower.Replace("-", "")

                    Case "p" : Return ArgumentResult.Play
                    Case "loop" : Return ArgumentResult.LoopTrack
                    Case Else : Return ArgumentResult.Other

                End Select
            Else : Return ArgumentResult.None
            End If

        End Function

    End Structure

    Private Shared xplayer As ZPlay = Play.xplayer

    Public Shared IsDo As Boolean = False

    Public Shared IsLoopingPlay As Boolean = False

    Public Shared PublicExecMode As ExecutionMode

    Public Shared Sub LaunchLib(args As String(), execMode As ExecutionMode)

        PublicExecMode = execMode

        If execMode = ExecutionMode.Console Then

            ExecModeHandler.ConsoleHandler.Handle(args)

        End If

        If ArgParser.IsArrayAvailable(args) Then


            Select Case ArgParser.GetArgumentResult(args, 0)
                Case ArgParser.ArgumentResult.Play
                    IsDo = True
                    If xplayer.OpenFile(args(1), TStreamFormat.sfAutodetect) = False Then
                        MessageBox.Show("Could not playback file """ & args(1) & """." & vbNewLine &
                                        "Additional information: " & xplayer.GetError())
                        IsDo = False
                    Else
                        Dim playMsgAddition As String = ""
                        xplayer.GetStreamInfo(Play.PlayStreamInfo)
                        If ArgParser.GetArgumentResult(args, 2) = ArgParser.ArgumentResult.LoopTrack Then
                            IsLoopingPlay = True
                            playMsgAddition = " (looping)"
                        Else
                        End If
                        xplayer.StartPlayback()
                        If execMode = ExecutionMode.Console Then Console.Out.WriteLine( _
                                            "Playing """ & args(1) & """" & playMsgAddition)
                        Play.xPlayListener.Interval = 1000
                        Play.xPlayListener.Start()

                    End If
                Case ArgParser.ArgumentResult.None : IsDo = False
                Case ArgParser.ArgumentResult.Other : IsDo = False
            End Select
        End If


        If IsDo = True And Not PublicExecMode = ExecutionMode.GUI Then Application.Run()
    End Sub

End Class
