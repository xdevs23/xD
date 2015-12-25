#Region "Intro"

''''''''''''''''''''''''''''''''''''''''''''''''''''''
' xDLib                                              '
' xdevs23's .NET Libraries                           '
' Internal assembly name: libxd                      '
'                                                    '
' Copyright (C) 2015 by xdevs23 (Simao Gomes Viana)  '
''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Recommended: Microsoft Visual Studio 2015 Community'
''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Requirement: Microsoft Visual Studio 2015 RC       '
''''''''''''''''''''''''''''''''''''''''''''''''''''''

#End Region

#Region "About"

'''''''''''''''''''''''''''''''''''''''''
' This library gives access to multiple '
' useful self-made utils and great      '
' easy-to-use modules which would help  '
' you in your daily work.               '
'''''''''''''''''''''''''''''''''''''''''
' Here you can see the main class which '
' tells you a bit about the library.    '
'''''''''''''''''''''''''''''''''''''''''

#End Region


Namespace libxd

    '''' Give information
    Public Structure Info

        '' Official library name
        Public Shared ReadOnly Property Name As String
            Get
                Return "xDLib"
            End Get
        End Property

        '' Internal assembly name
        Public Shared ReadOnly Property AssemblyName As String
            Get
                Return "libxd"
            End Get
        End Property

    End Structure

End Namespace