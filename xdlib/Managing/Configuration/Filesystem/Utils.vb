Imports System.IO
Imports System.Windows.Forms

Namespace Managing

    Namespace Configuration

        Namespace Filesystem

            Public Structure Utils

                ''' <summary>
                ''' Get a specific value in a ConfigFile (Not recommended)
                ''' <para> </para>
                ''' Use <see cref="ConfigFile.GetValue(String)"/> instead
                ''' <para> </para>
                ''' See also <seealso cref="ConfigFile.GetValue(Integer)"/>
                ''' </summary>
                ''' <param name="key">Key name</param>
                ''' <param name="cf">ConfigFile</param>
                ''' <returns></returns>
                Public Shared Function GetValue(key As String, cf As ConfigFile) As String
                    Dim ak As String() = cf.GetAllKeys()
                    Dim av As String() = cf.GetAllValues()

                    Dim rv As String = String.Empty

                    For i As Int32 = 0 To ak.Length - 1 Step 1
                        If ak(i) = key Then
                            rv = av(i)
                            Exit For
                        End If
                    Next

                    Return rv
                End Function

                Public Class ConfigFileReader : Implements IDisposable

                    ''' <summary>
                    ''' Read a config file
                    ''' </summary>
                    ''' <param name="filename">File to read</param>
                    ''' <returns>ConfigFile objects</returns>
                    Public Function Read(filename As String) As ConfigFile
                        Dim cfc As String = String.Empty
                        Dim err As Boolean = False

                        Dim r As ConfigFile = New ConfigFile

                        cfc = File.ReadAllText(filename)

                        cfc = cfc.Replace(vbCrLf, vbLf)

                        Dim kc As Int32 = cfc.Split(Convert.ToChar(vbLf)).Length ' Line count

                        Dim keys(kc - 1) As String,         ' Keys   (left )
                            vals(kc - 1) As String,         ' Values (right) 
                            cftm((kc * 2) - 1) As String,   ' Left + right (=) (unfiltered)
                            cfcl(kc - 1) As String,         ' Lines
                            _
                            cmts As New Collections.Generic.List(Of String)         ' Comments

                        cfcl = cfc.Split(Convert.ToChar(vbLf)) ' Seperate all lines into an array

                        Dim cmtsc As Int32 = -1

                        For i As Int32 = 0 To cftm.Length - 1 Step 2 ' Split all lines by '=', so you get a key and a value
                            Dim index As Int32 = Convert.ToInt32(i / 2)
                            If (Not cfcl(index).StartsWith("#")) And (Not (cfcl(index).StartsWith("[") And cfcl(index).Contains("]"))) Then ' Filter comments
                                Try
                                    cftm(i)     = cfcl(index).Split(Convert.ToChar("="))(0)
                                    cftm(i + 1) = cfcl(index).Split(Convert.ToChar("="))(1)
                                Catch ex As Exception
                                    err = True
                                    MessageBox.Show("An Exception occured while processing the file." & vbNewLine & _
                                                    "The results may be truncated or incomplete.")
                                End Try
                            End If
                        Next

                        Dim cfcc As New Collections.Generic.List(Of String)

                        For i As Int32 = 0 To cftm.Length - 1
                            If Not IsNothing(cftm(i)) Then cfcc.Add(cftm(i))
                        Next
                        
                        Dim cfct As String() = cfcc.ToArray()

                        For Each s As String In cfcl
                            If s.StartsWith("#") Then
                                cmts.Add(s)
                                cmtsc += 1
                            End If
                        Next

                        For i As Int32 = 0 To cfct.Length - 1 Step 2 ' Get all key out of the mixed array
                            keys(Convert.ToInt32(i / 2)) = cfct(i).Replace(Constants.vbCr, "=")
                        Next

                        For i As Int32 = 1 To cfct.Length - 1 Step 2 ' Get all values out of the mixed array
                            vals(Convert.ToInt32(i / 2 - 0.5)) = cfct(i).Replace(Constants.vbCr, "=")
                        Next

                        Dim cmtsa As String() = cmts.ToArray()

                        For i As Int32 = 0 To cmtsc Step 1
                            r.AddComment(cmtsa(i))
                        Next

                        For i As Int32 = 0 To keys.Length - 1 Step 1 ' Add all values associated with their keys to the ConfigFile
                            r.AddEntry(keys(i), vals(i))
                        Next

                        Return r

                    End Function


                    Public Overridable Sub Dispose() Implements IDisposable.Dispose
                        GC.SuppressFinalize(Me)
                    End Sub

                End Class

                Public Class ConfigFileWriter : Implements IDisposable

                    ''' <summary>
                    ''' Write ConfigFile to file
                    ''' </summary>
                    ''' <param name="filename">Filename of file to write to</param>
                    ''' <param name="cf">ConfigFile</param>
                    ''' <returns>True if successful, false if an exception occured</returns>
                    Public Function Write(filename As String, cf As ConfigFile) As Boolean
                        Try
                            Dim cfs As String = String.Empty

                            Dim keys() As String = cf.GetAllKeys(),
                                vals() As String = cf.GetAllValues(),
                                cmts() As String = cf.GetAllComments()

                            Dim nlv As String = vbLf

                            ' Process all comments.
                            ' All comments will be added to the beginning of the file
                            For Each s As String In cmts
                                cfs &= s & nlv
                            Next

                            For i As Int32 = 0 To keys.Length - 1
                                If i = keys.Length - 1 Then nlv = String.Empty
                                cfs &= keys(i).Replace("=", Constants.vbCr) & "=" & vals(i).Replace("=", Constants.vbCr) & nlv
                            Next

                            File.WriteAllText(filename, cfs)

                            Return True
                        Catch ex As Exception
                            Return False
                        End Try

                    End Function

                    Public Function Write(cf As ConfigFile) As Boolean
                        Return Write(cf.FileName, cf)
                    End Function

                    Public Overridable Sub Dispose() Implements IDisposable.Dispose
                        GC.SuppressFinalize(Me)
                    End Sub

                End Class

                Public Shared Function ReadConfigFile(filename As String) As ConfigFile
                    Dim cr As New ConfigFileReader()
                    
                    Return cr.Read(filename)
                End Function

                Public Shared Function SaveConfigFile(cf As ConfigFile) As Boolean
                    Try
                        Dim cw As New ConfigFileWriter()

                        cw.Write(cf)

                        Return True
                    Catch ex As Exception
                        Return False
                    End Try
                End Function

            End Structure

        End Namespace

    End Namespace

End Namespace