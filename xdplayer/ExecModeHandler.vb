Imports System.IO
Imports System.Console
Imports xdplay.Player

Namespace ExecModeHandler



    Public Structure ConsoleHandler

        Friend Shared HelpString() As String = New String() { _
            "xDPlayer Console Interface",
            "Usage: xdpcon <action> [<filename> [<options>]]",
            "",
            "Actions:",
            "    -p        |  Plays the specified file",
            "",
            "Options:",
            "    --loop    |  Loops the playback",
 _
            ""
 _
        }



        Public Shared Sub PrintHelp()

            For Each l As String In HelpString

                Out.WriteLine(l)

            Next

        End Sub

        Public Shared Sub Handle(args As String())
            Console.Title = "xDPlayer"
            If ArgParser.IsArrayAvailable(args) Then
                Select Case ArgParser.GetArgumentResult(args, 0)

                    Case ArgParser.ArgumentResult.None Or
                         ArgParser.ArgumentResult.Other

                        PrintHelp()

                End Select
            Else
                PrintHelp()
            End If
        End Sub

    End Structure



End Namespace
