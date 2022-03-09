Public Class FilePhotoData
    Private vTPhotograph As String = ""

    Private vTFilename1 As String = ""
    Private vFilename1 As String = ""

    Private vFilesize1 As String = ""

    Public Property TPhotograph() As String
        Get
            Return vTPhotograph
        End Get
        Set(ByVal v As String)
            vTPhotograph = v
        End Set
    End Property


    Public Property TFilename1() As String
        Get
            Return vTFilename1
        End Get
        Set(ByVal v As String)
            vTFilename1 = v
        End Set
    End Property

    Public Property Filename1() As String
        Get
            Return vFilename1
        End Get
        Set(ByVal v As String)
            vFilename1 = v
        End Set
    End Property


    Public Property Filesize1() As String
        Get
            Return vFilesize1
        End Get
        Set(ByVal v As String)
            vFilesize1 = v
        End Set
    End Property


    Public Function getTFilenameByID(ByVal n As Integer)
        Select Case n
            Case 1
                Return TFilename1()
        End Select
        Return ""
    End Function

    Public Function getFilenameByID(ByVal n As Integer)
        Select Case n
            Case 1
                Return Filename1()
        End Select
        Return ""
    End Function

    Public Function getFilesizeByID(ByVal n As Integer)
        Select Case n
            Case 1
                Return Filesize1()
        End Select
        Return ""
    End Function

    Public Sub setTFilenameByID(ByVal n As Integer, ByVal v As String)
        Select Case n
            Case 1
                TFilename1() = v
        End Select
    End Sub

    Public Sub setFilenameByID(ByVal n As Integer, ByVal v As String)
        Select Case n
            Case 1
                Filename1() = v
        End Select
    End Sub

    Public Sub setFilesizeByID(ByVal n As Integer, ByVal v As String)
        Select Case n
            Case 1
                Filesize1() = v
        End Select
    End Sub
End Class
