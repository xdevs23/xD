Imports xdlib
Imports xdlib.Crypto

Public Class CryptoForm

    Private Sub CryptoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SSHAX1Lb.Text = "SSHAX1: " & Crypto.HashAlgo.SSHAX1.HashString(My.Computer.Info.OSFullName & My.Computer.Clock.LocalTime.ToLongTimeString())
    End Sub

    Private Sub speaentestf_Click(sender As Object, e As EventArgs) Handles speaentestf.Click
        System.IO.File.WriteAllBytes("test.speacrypt", Encryption.SPEA.Encrypt(System.IO.File.ReadAllBytes("test.raw")))
    End Sub

    Private Sub speadetestf_Click(sender As Object, e As EventArgs) Handles speadetestf.Click
        System.IO.File.WriteAllBytes("test.speadecrypt", Encryption.SPEA.Decrypt(System.IO.File.ReadAllBytes("test.speacrypt")))
    End Sub
End Class