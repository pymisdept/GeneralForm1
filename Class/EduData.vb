Public Class EduData

    Private vType As String = ""
    Private vEduName_V As String = ""
    Private vEduName_T As String = ""
    Private vEduOthers As String = ""
    Private vSchName_V As String = ""
    Private vSchName_T As String = ""
    Private vSchOthers As String = ""
    Private vProgrammeName As String = ""
    Private vMajor As String = ""
    Private vGradMonth As String = ""
    Private vGradYear As String = ""
    Private vResult_V As String = ""
    Private vResult_T As String = ""
    Private vResult_GPA As String = ""
    Private vResult_CGPA As String = ""
    Private vResult_Grade As String = ""
    Private vFromMonth As String = ""
    Private vFromYear As String = ""

    Public Property Type() As String
        Get
            Return vType
        End Get
        Set(ByVal v As String)
            vType = v
        End Set
    End Property

    Public Property EduName_V() As String
        Get
            Return vEduName_V
        End Get
        Set(ByVal v As String)
            vEduName_V = v
        End Set
    End Property

    Public Property EduName_T() As String
        Get
            Return vEduName_T
        End Get
        Set(ByVal v As String)
            vEduName_T = v
        End Set
    End Property

    Public Property EduOthers() As String
        Get
            Return vEduOthers
        End Get
        Set(ByVal v As String)
            vEduOthers = v
        End Set
    End Property

    Public Property SchName_V() As String
        Get
            Return vSchName_V
        End Get
        Set(ByVal v As String)
            vSchName_V = v
        End Set
    End Property

    Public Property SchName_T() As String
        Get
            Return vSchName_T
        End Get
        Set(ByVal v As String)
            vSchName_T = v
        End Set
    End Property

    Public Property FromMonth() As String
        Get
            Return vFromMonth
        End Get
        Set(ByVal v As String)
            vFromMonth = v
        End Set
    End Property

    Public Property FromYear() As String
        Get
            Return vFromYear
        End Get
        Set(ByVal v As String)
            vFromYear = v
        End Set
    End Property
    Public Property SchOthers() As String
        Get
            Return vSchOthers
        End Get
        Set(ByVal v As String)
            vSchOthers = v
        End Set
    End Property

    Public Property ProgrammeName() As String
        Get
            Return vProgrammeName
        End Get
        Set(ByVal v As String)
            vProgrammeName = v
        End Set
    End Property

    Public Property Major() As String
        Get
            Return vMajor
        End Get
        Set(ByVal v As String)
            vMajor = v
        End Set
    End Property

    Public Property GradMonth() As String
        Get
            Return vGradMonth
        End Get
        Set(ByVal v As String)
            vGradMonth = v
        End Set
    End Property

    Public Property GradYear() As String
        Get
            Return vGradYear
        End Get
        Set(ByVal v As String)
            vGradYear = v
        End Set
    End Property

    Public Property Result_V() As String
        Get
            Return vResult_V
        End Get
        Set(ByVal v As String)
            vResult_V = v
        End Set
    End Property

    Public Property Result_T() As String
        Get
            Return vResult_T
        End Get
        Set(ByVal v As String)
            vResult_T = v
        End Set
    End Property

    Public Property Result_GPA() As String
        Get
            Return vResult_GPA
        End Get
        Set(ByVal v As String)
            vResult_GPA = v
        End Set
    End Property

    Public Property Result_CGPA() As String
        Get
            Return vResult_CGPA
        End Get
        Set(ByVal v As String)
            vResult_CGPA = v
        End Set
    End Property

    Public Property Result_Grade() As String
        Get
            Return vResult_Grade
        End Get
        Set(ByVal v As String)
            vResult_Grade = v
        End Set
    End Property

End Class
