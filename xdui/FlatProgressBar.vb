Public Class FlatProgressBar

    Inherits Panel

    Private Shared ReadOnly _
        NormalSpeed As Integer = CInt(Math.Round(1000 / 136)),
        InOutSpeed  As Integer = CInt(Math.Round(1000 / 96))

    Private InnerProgressBar, BorderPanel As Panel
    Private WithEvents ProgressBarAdvanceTimer As Timer
    Private AutoAdvanceLabel As Label

    Private ProgressToReach As Integer = 0, ProgressReached As Integer = 0, Progress As Integer

    Public Sub New()
        BackColor = Color.Transparent
        
        BorderPanel = New Panel()
        BorderPanel.Padding = New Padding(1)
        BorderPanel.BackColor = Color.FromArgb(92, Color.Black)
        Controls.Add(BorderPanel)
        BorderPanel.Dock = DockStyle.Fill
        
        InnerProgressBar = New Panel()
        BorderPanel.Controls.Add(InnerProgressBar)
        InnerProgressBar.Location = New Point(BorderPanel.Padding.Left, BorderPanel.Padding.Top)
        InnerProgressBar.Height = BorderPanel.Height - BorderPanel.Padding.Top * 2
        InnerProgressBar.Anchor = CType(
            AnchorStyles.Left  + AnchorStyles.Top + 
            AnchorStyles.Right + AnchorStyles.Bottom,
            AnchorStyles
        )
        InnerProgressBar.BackColor = Color.FromArgb(30, 139, 229)
    End Sub

    Private Sub SetProgressInternal(Progress As Integer)
        InnerProgressBar.Width = CInt(Math.Round(BorderPanel.Width * (Progress / 100), 0, MidpointRounding.AwayFromZero))
    End Sub

    Public Sub SetProgress(Progress As Integer)
        SetProgressInternal(Progress)
        Me.Progress = Progress
        If Not IsNothing(AutoAdvanceLabel) Then AutoAdvanceLabel.Text = Progress.ToString() & " %"
    End Sub

    Public Sub AdvanceProgress(Progress As Integer)
        ProgressBarAdvanceTimer = New Timer()
        ProgressReached = Me.Progress
        ProgressToReach = Progress
        Me.Progress = Progress
        If Not IsNothing(AutoAdvanceLabel) Then AutoAdvanceLabel.Text = Progress.ToString() & " %"
        ProgressBarAdvanceTimer.Interval = NormalSpeed
        ProgressBarAdvanceTimer.Start()
    End Sub

    Private Sub ProgressBarAdvanceTimer_Tick(sender As Object, e As EventArgs) Handles ProgressBarAdvanceTimer.Tick
        If ProgressReached < ProgressToReach Then
            SetProgressInternal(ProgressReached)
            ProgressReached += 1
        Else : ProgressBarAdvanceTimer.Stop()
        End If
        If ProgressReached < ProgressToReach / 4 Or ProgressReached > ProgressToReach * 0.75 Then
            ProgressBarAdvanceTimer.Interval = InOutSpeed
        Else
            ProgressBarAdvanceTimer.Interval = NormalSpeed
        End If
    End Sub

    Public Sub SetAutoAdvanceLabel(Lbl As Label)
        AutoAdvanceLabel = Lbl
    End Sub

End Class
