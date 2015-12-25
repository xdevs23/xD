Imports xdlib.Managing.Configuration.Filesystem
Imports System.Drawing

Namespace Managing

    Namespace Configuration

        Namespace TypeStorage

            Public Class TColorConfig

                Public Config As ConfigFile = Nothing

                Public Sub New(Optional filename As String   = "color.cfg",
                               Optional cmts     As String() = Nothing,
                               Optional col      As Color    = Nothing )
                    Dim cf As New ConfigFile(filename, Nothing, cmts, Nothing)
                    
                    cf.AddEntries(GetEntriesFromColor(col))

                    Me.Config = cf

                End Sub

                Public Function GetEntriesFromColor(col As Color) As ConfigEntry()
                    Dim _
                        A,R,G,B _
                        _
                        As New ConfigEntry

                    Dim mcol As Color = Color.FromArgb(0, 0, 0, 0)

                    A.Key = "Alpha"
                    R.Key = "Red"
                    G.Key = "Green"
                    B.Key = "Blue"

                    
                    If Not IsNothing(col) Then mcol = col

                    A.Value = CStr(mcol.A)
                    R.Value = CStr(mcol.R)
                    G.Value = CStr(mcol.G)
                    B.Value = CStr(mcol.B)

                    Return New ConfigEntry() {A, R, G, B}
                End Function

                Public Sub SetColor(col As Color)
                    Me.Config.ClearAll()
                    Me.Config.AddEntries(GetEntriesFromColor(col))
                End Sub

                Public Sub SetColor(R As Int32, G As Int32, B As Int32, Optional A As Int32 = 255)
                    SetColor(Color.FromArgb(A, R, G, B))
                End Sub

                Public Sub SetColor(base As Int32, Optional alpha As Int32 = 255)
                    SetColor(base, base, base, alpha)
                End Sub

                Public Sub SetColor(ColorBundle() As Int32)
                    Dim cb(3) As Int32
                    cb(0) = ColorBundle(0)
                    cb(1) = ColorBundle(1)
                    cb(2) = ColorBundle(2)
                    cb(3) = CInt(IIf(ColorBundle.Length >= 4, ColorBundle(3), 255))

                    SetColor(cb(0), cb(1), cb(2), cb(3))
                End Sub

                Public Sub SetColor(R As String, G As String, B As String, Optional A As String = "255")
                    Dim Ai,Ri,Gi,Bi As Int32

                    Ai = CInt(A)
                    Ri = CInt(R)
                    Gi = CInt(G)
                    Bi = CInt(B)

                    SetColor(Ai, Ri, Bi, Ai)

                End Sub

                Public Sub SetColor(ColorBundle() As String)
                    Dim cb(ColorBundle.Length - 1) As Int32

                    For i As Int32 = 0 To cb.Length - 1 Step 1
                        cb(i) = CInt(ColorBundle(i))
                    Next

                    SetColor(cb)
                End Sub

                Public Shared Function GetColor(cf As ConfigFile) As Color
                    Dim col As Color

                    Dim Al, Re, Gr, Bl As Integer

                    Al = Integer.Parse(cf.GetValue("Alpha"))
                    Re = Integer.Parse(cf.GetValue("Red"  ))
                    Gr = Integer.Parse(cf.GetValue("Green"))
                    Bl = Integer.Parse(cf.GetValue("Blue" ))

                    col = Color.FromArgb(Al, Re, Gr, Bl)

                    Return col
                End Function

                Public Function GetOwnColor() As Color
                    Return GetColor(Me.Config)
                End Function

                Public Function SaveFile() As Boolean
                    Return Utils.SaveConfigFile(Me.Config)
                End Function

                Public Shared Function FromFile(filename As String) As ConfigFile
                    Return Utils.ReadConfigFile(filename)
                End Function
            End Class
        End Namespace

    End Namespace

End Namespace
