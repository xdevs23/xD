Imports xdplay
Imports System.IO
Imports System.Text.RegularExpressions

Public Class MainV

    Public Class PlaybackStateType
         
    End Class

    Public Class PlaybackState
        
        Public        Event PlaybackStateChanged (ByVal sender As Object, ByVal e As PlaybackStateChangedEventArgs)

        Public Const _
        None As Int32 = 0,               ' Usually not used
        Playing As Int32 = 1,
        Paused As Int32 = 2,
        Stopped As Int32 = 4,
        Buffering As Int32 = 8,          ' Usually not used
        Initializing As Int32 = 16,      ' Usually not used
        Err As Int32 = 32,               ' Usually not used
        Resuming As Int32 = 48,          ' Usually not used
        Reinitializing As Int32 = 64,    ' Usually not used
        Restarting As Int32 = 72,        ' Usually not used
        Rebuffering As Int32 = 96,       ' Usually not used
        Downloading As Int32 = 128,
        Unknown As Int32 = 255,          ' Usually not used
        Other As Int32 = 256             ' Usually not used

        Public State As Int32

        Public Sub New(Optional ByVal state As Int32 = None)
            State = None
        End Sub

        Public Sub ChangeState(s As Int32)
            State = s
            RaiseEvent PlaybackStateChanged(Me, New PlaybackStateChangedEventArgs(New PlaybackState(s)))
        End Sub
    End Class

    Public Class PlaybackStateChangedEventArgs
        Inherits EventArgs

        Public State As PlaybackState

        Public Sub New(st As PlaybackState)
            State = st
        End Sub
    End Class


    Private WithEvents PublicPlaybackState  As PlaybackState = New PlaybackState()

    Public Sub ChangePlaybackState(state As Int32)
        PublicPlaybackState.ChangeState(state)
    End Sub

    Private Sub MainV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MediaPosip.Width = 0
        MediaPosip.Refresh()
        byLabel.Location = New Point((Me.Width - byLabel.Width) - 16, 8)
        byLabel.Refresh()
    End Sub

    Private Shared DrawerPen  As Pen = UIShapes.Utils.DrawerPen
    Private Shared PaddingPen As Pen = UIShapes.Utils.PaddingPen

    Private Sub DecideDrawPausePlayButton(sender As Object, e As PlaybackStateChangedEventArgs) Handles PublicPlaybackState.PlaybackStateChanged
        PausePlayButton.Refresh()
    End Sub

    Private Sub PausePlayButton_Paint(sender As Object, e As PaintEventArgs) Handles PausePlayButton.Paint
        If Not PublicPlaybackState.State = PlaybackState.Playing Then UIShapes. Play.Control.Draw(e.Graphics) _
            Else                                                      UIShapes.Pause        .Draw(e.Graphics)
    End Sub

    Private Sub StopButton_Paint(sender As Object, e As PaintEventArgs) Handles StopButton.Paint
        e.Graphics.FillRectangle(DrawerPen.Brush, UIShapes.StopPlayback.Control)
    End Sub

    Private Sub ClearMediaDirList()
        MediaDirList.Clear()

        For Each i As ListViewItem In MediaDirListBox.Items
            MediaDirListBox.Items.Remove(MediaDirListBox.Items.Item(i.Index))
        Next

    End Sub

    Private PlayStreamTime As libZPlay.TStreamTime

    Private FullMediaLength As String

    Private Sub PlayListTrack(Optional track As String = "")
        ActualPositionString = "--:--"
        FullMediaLength = ""

        MediaPositionTimer.Stop()

        If PublicPlaybackState.State = PlaybackState.Downloading Then

        Else
            If MediaDirList.Count > 0 Then Player.LaunchLib(New String() {"-p", MediaDirList(ActualPlayingDirList)}, Player.ExecutionMode.GUI) _
            Else Player.LaunchLib(New String() {"-p", track}, Player.ExecutionMode.GUI)
        End If


        Player.Play.xplayer.SetPlayerVolume(100, 100)

        MediaPositionTimer.Start()

        If Not PublicPlaybackState.State = PlaybackState.Downloading Then
            If Player.Play.PlayStreamInfo.Length.hms.hour > 0 And Player.Play.PlayStreamInfo.Length.hms.hour < 10 Then _
                FullMediaLength &= "0" & Player.Play.PlayStreamInfo.Length.hms.hour.ToString & ":" _
            _
            Else If Player.Play.PlayStreamInfo.Length.hms.hour >= 10 Then FullMediaLength &= Player.Play.PlayStreamInfo.Length.hms.hour.ToString & ":"

            If Player.Play.PlayStreamInfo.Length.hms.minute >= 0 And Player.Play.PlayStreamInfo.Length.hms.minute < 10 Then _
                FullMediaLength &= "0" & Player.Play.PlayStreamInfo.Length.hms.minute.ToString & ":" _
            _
            Else If Player.Play.PlayStreamInfo.Length.hms.minute >= 10 Then FullMediaLength &= Player.Play.PlayStreamInfo.Length.hms.minute.ToString & ":"

            If Player.Play.PlayStreamInfo.Length.hms.second >= 0 And Player.Play.PlayStreamInfo.Length.hms.second < 10 Then _
                FullMediaLength &= "0" & Player.Play.PlayStreamInfo.Length.hms.second.ToString _
            _
            Else If Player.Play.PlayStreamInfo.Length.hms.second >= 10 Then FullMediaLength &= Player.Play.PlayStreamInfo.Length.hms.second.ToString

            If MediaDirList.Count > 0 Then MediaDirListBox.SelectedIndex = ActualPlayingDirList

            MediaLengthLb.Text = FullMediaLength
            MediaLengthLb.Refresh()

            ChangePlaybackState(PlaybackState.Playing)
        End If
    End Sub
    Private Sub OpenMediaButton_Click(sender As Object, e As EventArgs) Handles OpenMediaButton.Click
        If SingleMediaDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            ClearMediaDirList()

            PlayListTrack(SingleMediaDialog.FileName)

        End If
    End Sub


    Private ActualPositionString As String = ""
    Private Shared isGettingNewTrack As Boolean = False

    Private DownloadMaybeCompleteValue As Int64 = 0
    Private Sub MediaPositionTimer_Tick(sender As Object, e As EventArgs) Handles MediaPositionTimer.Tick
        ' On Error Resume Next
        If PublicPlaybackState.State = PlaybackState.Playing Then


            Player.Play.xplayer.GetPosition(PlayStreamTime)


            ActualPositionString = ""


            If PlayStreamTime.hms.hour > 0 And PlayStreamTime.hms.hour < 10 Then ActualPositionString &= "0" & PlayStreamTime.hms.hour.ToString & ":" _
            Else If PlayStreamTime.hms.hour >= 10 Then ActualPositionString &= PlayStreamTime.hms.hour.ToString & ":"

            If PlayStreamTime.hms.minute >= 0 And PlayStreamTime.hms.minute < 10 Then ActualPositionString &= "0" & PlayStreamTime.hms.minute.ToString & ":" _
            Else If PlayStreamTime.hms.minute >= 10 Then ActualPositionString &= PlayStreamTime.hms.minute.ToString & ":"

            If PlayStreamTime.hms.second >= 0 And PlayStreamTime.hms.second < 10 Then ActualPositionString &= "0" & PlayStreamTime.hms.second.ToString _
            Else If PlayStreamTime.hms.second >= 10 Then ActualPositionString &= PlayStreamTime.hms.second.ToString

            If ActualPositionString = "" Then ActualPositionString = "--:--"

            If isGettingNewTrack = False Then
                If PlayStreamTime.samples >= Player.Play.PlayStreamInfo.Length.samples Or
                    PlayStreamTime.samples <= 1 Then

                    If MediaDirList.Count > 0 Then
                        isGettingNewTrack = True
                        If Not MediaDirList.Count <= ActualPlayingDirList + 1 Then ActualPlayingDirList += 1 _
                        Else ActualPlayingDirList = 0
                        PlayListTrack()
                    End If

                End If
            Else
                isGettingNewTrack = False
            End If

            MediaPositionLb.Text = ActualPositionString
            MediaPositionLb.Refresh()

            If Not PlayStreamTime.samples <= 100 Or
               Not Player.Play.PlayStreamInfo.Length.samples <= 8 Then
                MediaPosip.Width = Int32.Parse(
                                    Math.Round(MediaPositionProgress.Width *
                                        PlayStreamTime.samples / Player.Play.PlayStreamInfo.Length.samples
                                    ).ToString()
                                   )
            Else
                If isGettingNewTrack = False Then
                    ChangePlaybackState(PlaybackState.Stopped)
                    ActualPositionString = "--:--"
                    FullMediaLength = "--:--"
                End If
            End If
            MediaPosip.Refresh()

        ElseIf PublicPlaybackState.State = PlaybackState.Downloading Then


            If xdlib.Net.DownloadUtils.PublicDownElements.IsFinished = True Then
                ActualPositionString = "Heruntergeladene Datei wird geladen..."
                ChangePlaybackState(PlaybackState.Stopped)
                PlayListTrack(xdlib.Net.DownloadUtils.PublicDownElements.DestinationFile)
            Else
                MediaPosip.Width = CInt(Math.Round((xdlib.Net.DownloadUtils.PublicDownElements.DownloadedPercentage / 100) * MediaPositionProgress.Width))
            End If
            ActualPositionString = "Herunterladen..."
            MediaPositionLb.Text = ActualPositionString
            MediaPositionLb.Refresh()

        End If
    End Sub

    Private Shared ActualPlayingSingle As String = ""

    Private Sub PausePlayButton_Click(sender As Object, e As EventArgs) Handles PausePlayButton.Click
        If PublicPlaybackState.State = PlaybackState.Paused Or
           PublicPlaybackState.State = PlaybackState.None Then

            Player.Play.xplayer.ResumePlayback()
            ChangePlaybackState(PlaybackState.Playing)

        ElseIf PublicPlaybackState.State = PlaybackState.Playing Then
            Player.Play.xplayer.PausePlayback()
            ChangePlaybackState(PlaybackState.Paused)

        ElseIf PublicPlaybackState.State = PlaybackState.Stopped Then
            If Not ActualPlayingSingle = "" Then Player.LaunchLib(New String() {"-p", ActualPlayingSingle}, Player.ExecutionMode.GUI)
            ChangePlaybackState(PlaybackState.Playing)
        End If
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        ChangePlaybackState(PlaybackState.Stopped)
        Player.Play.xplayer.StopPlayback()
    End Sub

    Private Sub RePlayButton_CheckedChanged(sender As Object, e As EventArgs) Handles RePlayButton.CheckedChanged
        If RePlayButton.Checked = True Then
            Player.IsLoopingPlay = True
        Else
            Player.IsLoopingPlay = False
        End If
    End Sub




    Public Shared SupportedFormats As New Regex(
        ".aac|.mp3|.flac|.ogg|.ac3|.cda|.wav|.pcm"
        )

    Public Shared MediaDirList As List(Of String) = New List(Of String)
    Public Shared ActualPlayingDirList As Int32 = 0



    Private Sub OpenDirButton_Click(sender As Object, e As EventArgs) Handles OpenDirButton.Click
        If MultiMediaDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            ClearMediaDirList()

            For Each f As String In Directory.GetFiles(Path.GetFullPath(MultiMediaDialog.SelectedPath))
                If SupportedFormats.IsMatch(f.Substring(f.LastIndexOf("."), f.Length - f.LastIndexOf("."))) Then
                    Dim mf As New FileInfo(f)
                    If Not mf.Length < 1 Then _
                        If mf.Length < UInt64.MaxValue Then _
                    MediaDirList.Add(f)
                End If
            Next

            For Each m As String In MediaDirList
                MediaDirListBox.Items.Add(m.Substring(m.LastIndexOf("\") + 1, m.Length - (m.LastIndexOf("\") + 1)).Replace(m.Substring(m.LastIndexOf("."), m.Length - m.LastIndexOf(".")), ""))
            Next

            PlayListTrack()

        End If
    End Sub

    Private Sub MediaDirListBox_DoubleClick(sender As Object, e As EventArgs) Handles MediaDirListBox.DoubleClick
        If Not MediaDirListBox.SelectedIndex = ActualPlayingDirList Then
            ActualPlayingDirList = MediaDirListBox.SelectedIndex
            PlayListTrack()
        End If
    End Sub

    Private Sub GoBackButton_Click(sender As Object, e As EventArgs) Handles GoBackButton.Click
        If Not ActualPlayingDirList - 1 < 0 Then ActualPlayingDirList -= 1 _
        Else ActualPlayingDirList = MediaDirList.Count - 1
        PlayListTrack()
    End Sub

    Private Sub GoFwdButton_Click(sender As Object, e As EventArgs) Handles GoFwdButton.Click
        If Not MediaDirList.Count <= ActualPlayingDirList + 1 Then ActualPlayingDirList += 1 _
        Else ActualPlayingDirList = 0
        PlayListTrack()
    End Sub

    Dim alreadyHandledMediaPosipSeek As Boolean = False

    Private Sub MediaPosip_MouseDown(sender As Object, e As MouseEventArgs) Handles MediaPosip.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If PublicPlaybackState.State = PlaybackState.Playing Then
                MediaPosip.Width = Me.Width - (Me.Width - e.X)
            End If
        End If
    End Sub
    Private Sub MediaPosip_MouseRelease(sender As Object, e As MouseEventArgs) Handles MediaPosip.MouseUp, MediaPositionProgress.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If PublicPlaybackState.State = PlaybackState.Playing Then
                MediaPosip.Width = Me.Width - (Me.Width - e.X)
                Dim newTime As New libZPlay.TStreamTime
                newTime.samples = UInt32.Parse(
                                    Math.Round(
                                        MediaPosip.Width / MediaPositionProgress.Width _
                                        * _
                                        Player.Play.PlayStreamInfo.Length.samples
                                    ).ToString()
                                  )
                Player.Play.xplayer.Seek(libZPlay.TTimeFormat.tfSamples, newTime, libZPlay.TSeekMethod.smFromBeginning)
            End If
        End If
    End Sub


    Private Sub MediaPosip_MouseMove(sender As Object, e As MouseEventArgs) Handles MediaPosip.MouseMove, MediaPositionProgress.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If PublicPlaybackState.State = PlaybackState.Playing Then
                MediaPosip.Width = Me.Width - (Me.Width - e.X)
            End If
            MediaPosip.Refresh()
        End If
    End Sub

    Private Sub OpenMediaStreamBtn_Click(sender As Object, e As EventArgs) Handles OpenMediaStreamBtn.Click

        Dim url As String = InputBox("Bitte URL eingeben", "Audio-Stream starten")
        Dim dst As String = "stream_" & url.Substring(url.LastIndexOf(".") - 6, 6 + url.Substring(url.LastIndexOf(".")).Length)

        xdlib.Net.DownloadUtils.DownloadFile(url, dst)

        ChangePlaybackState(PlaybackState.Downloading)

        PlayListTrack()

    End Sub


End Class
