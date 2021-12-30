Public Class FileData

    Private vTFilename1 As String = ""
    Private vTFilename2 As String = ""
    Private vTFilename3 As String = ""
    Private vTFilename4 As String = ""
    Private vTFilename5 As String = ""

    Private vFilename1 As String = ""
    Private vFilename2 As String = ""
    Private vFilename3 As String = ""
    Private vFilename4 As String = ""
    Private vFilename5 As String = ""

    Private vFilesize1 As String = ""
    Private vFilesize2 As String = ""
    Private vFilesize3 As String = ""
    Private vFilesize4 As String = ""
    Private vFilesize5 As String = ""

    Public Property TFilename1() As String
        Get
            Return vTFilename1
        End Get
        Set(ByVal v As String)
            vTFilename1 = v
        End Set
    End Property

    Public Property TFilename2() As String
        Get
            Return vTFilename2
        End Get
        Set(ByVal v As String)
            vTFilename2 = v
        End Set
    End Property

    Public Property TFilename3() As String
        Get
            Return vTFilename3
        End Get
        Set(ByVal v As String)
            vTFilename3 = v
        End Set
    End Property

    Public Property TFilename4() As String
        Get
            Return vTFilename4
        End Get
        Set(ByVal v As String)
            vTFilename4 = v
        End Set
    End Property

    Public Property TFilename5() As String
        Get
            Return vTFilename5
        End Get
        Set(ByVal v As String)
            vTFilename5 = v
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

    Public Property Filename2() As String
        Get
            Return vFilename2
        End Get
        Set(ByVal v As String)
            vFilename2 = v
        End Set
    End Property

    Public Property Filename3() As String
        Get
            Return vFilename3
        End Get
        Set(ByVal v As String)
            vFilename3 = v
        End Set
    End Property

    Public Property Filename4() As String
        Get
            Return vFilename4
        End Get
        Set(ByVal v As String)
            vFilename4 = v
        End Set
    End Property

    Public Property Filename5() As String
        Get
            Return vFilename5
        End Get
        Set(ByVal v As String)
            vFilename5 = v
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

    Public Property Filesize2() As String
        Get
            Return vFilesize2
        End Get
        Set(ByVal v As String)
            vFilesize2 = v
        End Set
    End Property

    Public Property Filesize3() As String
        Get
            Return vFilesize3
        End Get
        Set(ByVal v As String)
            vFilesize3 = v
        End Set
    End Property

    Public Property Filesize4() As String
        Get
            Return vFilesize4
        End Get
        Set(ByVal v As String)
            vFilesize4 = v
        End Set
    End Property

    Public Property Filesize5() As String
        Get
            Return vFilesize5
        End Get
        Set(ByVal v As String)
            vFilesize5 = v
        End Set
    End Property

    Public Function getTFilenameByID(ByVal n As Integer)
        Select Case n
            Case 1
                Return TFilename1()
            Case 2
                Return TFilename2()
            Case 3
                Return TFilename3()
            Case 4
                Return TFilename4()
            Case 5
                Return TFilename5()
        End Select
        Return ""
    End Function

    Public Function getFilenameByID(ByVal n As Integer)
        Select Case n
            Case 1
                Return Filename1()
            Case 2
                Return Filename2()
            Case 3
                Return Filename3()
            Case 4
                Return Filename4()
            Case 5
                Return Filename5()
        End Select
        Return ""
    End Function

    Public Function getFilesizeByID(ByVal n As Integer)
        Select Case n
            Case 1
                Return Filesize1()
            Case 2
                Return Filesize2()
            Case 3
                Return Filesize3()
            Case 4
                Return Filesize4()
            Case 5
                Return Filesize5()
        End Select
        Return ""
    End Function

    Public Sub setTFilenameByID(ByVal n As Integer, ByVal v As String)
        Select Case n
            Case 1
                TFilename1() = v
            Case 2
                TFilename2() = v
            Case 3
                TFilename3() = v
            Case 4
                TFilename4() = v
            Case 5
                TFilename5() = v
        End Select
    End Sub

    Public Sub setFilenameByID(ByVal n As Integer, ByVal v As String)
        Select Case n
            Case 1
                Filename1() = v
            Case 2
                Filename2() = v
            Case 3
                Filename3() = v
            Case 4
                Filename4() = v
            Case 5
                Filename5() = v
        End Select
    End Sub

    Public Sub setFilesizeByID(ByVal n As Integer, ByVal v As String)
        Select Case n
            Case 1
                Filesize1() = v
            Case 2
                Filesize2() = v
            Case 3
                Filesize3() = v
            Case 4
                Filesize4() = v
            Case 5
                Filesize5() = v
        End Select
    End Sub


End Class
