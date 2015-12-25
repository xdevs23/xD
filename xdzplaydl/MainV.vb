Imports System.Windows.Forms

Module MainV

    Sub Main()

        If MessageBox.Show("Do you want to download the library ""libZPlay""?",
                           "Download of library",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            MessageBox.Show("Not implemented!")
        Else
            MessageBox.Show("Not downloading." & vbNewLine & "The Application will exit now.")
        End If

    End Sub

End Module
