Imports System.Collections.Generic
Imports System.Text.RegularExpressions

Imports xdlib.Converting.TypeConversion.ListConverter

Namespace Managing

    Namespace Configuration

        Namespace Filesystem

            Public Class ConfigEntry : Implements IDisposable
                Public Property Key As String
                Public Property Value As String

                Public Sub Dispose() Implements IDisposable.Dispose
                    GC.SuppressFinalize(Me)
                End Sub
            End Class

            Public NotInheritable Class ConfigFile : Implements IDisposable

                Public Property FileName As String = ""

                Public Entries As New List(Of ConfigEntry)

                Public Comments As New List(Of String)

                Public Sub New(Optional fname       As          String          = "config.cfg",     _
                               Optional entr        As List(Of  ConfigEntry)    = Nothing,          _
                               Optional cmts        As          String()        = Nothing,          _
                               Optional cloneObj    As          ConfigFile      = Nothing)

                    If Not IsNothing(cloneObj)  Then Clone(cloneObj, Me)

                    If Not IsNothing(entr)      Then Clone(entr, Me)

                    If Not IsNothing(cmts)      Then Clone(StringListConverter.ToList(cmts), Me)

                    If Not IsNothing(fname)     Then Clone(fname, Me)

                End Sub

                Public Shared Sub Clone(from As ConfigFile, toC As ConfigFile)
                    toC.FileName        = from.FileName
                    toC.Entries         = from.Entries
                    toC.Comments        = from.Comments
                End Sub

                Public Shared Sub Clone(from As List(Of ConfigEntry), toC As ConfigFile)
                    toC.Entries = from
                End Sub

                Public Shared Sub Clone(commentsList As List(Of String), toC As ConfigFile)
                    toC.Comments = commentsList
                End Sub
                
                Public Shared Sub Clone(flName As String, toC As ConfigFile)
                    toC.FileName = flName
                End Sub

                Public Sub AddEntry(key As String, val As String)

                    Using ce As New ConfigEntry
                        ce.Key = key
                        ce.Value = val
                        Entries.Add(ce)
                    End Using

                End Sub

                Public Sub AddEntry(entry As ConfigEntry)
                    Entries.Add(entry)
                End Sub

                Public Sub AddEntries(keys() As String, vals() As String)
                    For i As Int32 = 0 To keys.Length - 1
                        AddEntry(keys(i), vals(i))
                    Next
                End Sub

                Public Sub AddEntries(entries() As ConfigEntry)
                    For Each e As ConfigEntry In entries
                        AddEntry(e)
                    Next
                End Sub

                Public Sub RemoveEntry(key As String)

                    For Each e As ConfigEntry In Entries
                        If e.Key = key Then
                            Entries.Remove(e)
                            Exit For
                        End If
                    Next

                End Sub

                Public Sub ChangeEntry(key As String, newValue As String)

                    For Each e As ConfigEntry In Entries
                        If e.Key = key Then
                            RemoveEntry(key)
                            AddEntry(key, newValue)
                            Exit For
                        End If
                    Next

                End Sub

                Public Function isEmpty() As Boolean
                    Try
                        If Entries.Count > 0 Then Return False _
                                             Else Return True
                    Catch ex As Exception
                        Return True
                    End Try
                End Function

                Public Function GetAllKeys() As String()
                    Dim ak(Entries.Count - 1) As String

                    For i As Int32 = 0 To Entries.Count - 1 Step 1
                        ak(i) = Entries(i).Key
                    Next

                    Return ak
                End Function

                Public Function GetKeys(p As String) As String()
                    Dim z   As New List(Of String)
                    Dim rex As New Regex(p)

                    For Each k As String In GetAllKeys()
                        If rex.IsMatch(k) Then z.Add(k)
                    Next

                    Return z.ToArray()
                End Function


                Public Function GetAllValues() As String()
                    Dim av(Entries.Count - 1) As String

                    For i As Int32 = 0 To Entries.Count - 1
                        av(i) = Entries(i).Value
                    Next

                    Return av

                End Function

                Public Function GetValue(index As Integer) As String
                    Return GetAllValues(index)
                End Function

                Public Function GetValue(key As String) As String
                    Dim r As String = String.Empty
                    Dim ak As String() = GetAllKeys()

                    For i As Int32 = 0 To Entries.Count - 1
                        If Not ak(i) = Nothing AndAlso ak(i).Equals(key) Then r = GetValue(i)
                    Next

                    Return r
                End Function
                
                Public Sub AddComment(comment As String)
                    Comments.Add(comment)
                End Sub

                Public Function GetAllComments() As String()
                    Return Comments.ToArray()
                End Function

                Public Function GetComment(param As String, Optional trimFirstSharp As Boolean = True) As String
                    Dim r As String = String.Empty
                    Dim rex As New Regex(param)
                    For Each s As String In GetAllComments()
                        If rex.IsMatch(s) Then r = CStr( IIf(trimFirstSharp, s.Remove(0, 1), s) )
                        Exit For
                    Next

                    Return r
                End Function

                Public Function GetComments(param As String, Optional trimFirstSharp As Boolean = True) As String()
                    Dim r As String()
                    Dim z As New List(Of String)

                    Dim rex As New Regex(param)

                    For Each s As String In GetAllComments()
                        If rex.IsMatch(s) Then z.Add(CStr( IIf(trimFirstSharp, s.Remove(0, 1), s) ))
                        Exit For
                    Next

                    r = z.ToArray()

                    Return r
                End Function

                Public Sub ClearAll()
                    Entries  = New List(Of ConfigEntry)
                    Comments = New List(Of String)
                End Sub

                Public Sub Dispose() Implements IDisposable.Dispose
                    FileName = String.Empty
                    Entries = Nothing
                    GC.SuppressFinalize(Me)
                End Sub

            End Class

        End Namespace

    End Namespace

End Namespace