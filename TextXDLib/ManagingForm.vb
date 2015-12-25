Imports xdlib
Imports xdlib.Managing.Configuration.Filesystem
Imports xdlib.Managing.Configuration.TypeStorage
Public Class ManagingForm

    Private Sub ResetAllTextBoxes()
        For Each c As Control In GroupBox2.Controls
            If c.GetType.ToString = "System.Windows.Forms.TextBox" Then
                c.Text = String.Empty
                c.Refresh()
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ResetAllTextBoxes()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cf As New ConfigFile

        cf.AddEntry(OT.Text, ST.Text)
        cf.AddEntry(TT.Text, FT.Text)

        Dim cw As New Utils.ConfigFileWriter

        If cw.Write("test.cfg", cf) = False Then
            MsgBox("Error")
        Else
            MsgBox("Success")
        End If

        ResetAllTextBoxes()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ResetAllTextBoxes()

        Dim cf As ConfigFile

        Dim cr As New Utils.ConfigFileReader

        cf = cr.Read("test.cfg")

        OT.Text = cf.GetAllKeys()(0)
        TT.Text = cf.GetAllKeys()(1)
        ST.Text = cf.GetAllValues()(0)
        FT.Text = cf.GetAllValues()(1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cf As ConfigFile

        Dim cr As New Utils.ConfigFileReader

        cf = cr.Read("test.cfg")

        MessageBox.Show(StringManipulation.ArrayManipulation.Implode(cf.GetAllComments(), vbCrLf, False))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim c As New TColorConfig("colortest.cfg", Nothing, Color.FromArgb(CInt(TextBox1.Text), CInt(TextBox3.Text), CInt(TextBox2.Text)))
        c.SaveFile()
        Panel1.BackColor = c.GetOwnColor()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim c As ConfigFile = TColorConfig.FromFile("colortest.cfg")
        TextBox1.Text = c.GetValue("Red")
        TextBox2.Text = c.GetValue("Blue")
        TextBox3.Text = c.GetValue("Green")

        Panel1.BackColor = TColorConfig.GetColor(c)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim cf As ConfigFile = Utils.ReadConfigFile(OpenFileDialog1.FileName)
            MessageBox.Show(StringManipulation.ArrayManipulation.Implode(cf.GetAllKeys, vbCrLf) & vbCrLf & vbCrLf & _
                            StringManipulation.ArrayManipulation.Implode(cf.GetAllValues, vbCrLf))
        End If
    End Sub
End Class