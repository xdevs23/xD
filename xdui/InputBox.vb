Public Class InputBox

    Private Sub InputBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = tl
        BoxText.Text = it
    End Sub

    Private Shared tl As String = ""
    Private Shared it As String = ""

    Public Shared Sub SetUp(title As String, innertext As String)
        tl = title
        it = innertext
    End Sub

    Private Sub OKBtn_Click(sender As Object, e As EventArgs) Handles OKBtn.Click

    End Sub
End Class