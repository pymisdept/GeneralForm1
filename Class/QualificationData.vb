Public Class QualificationData

    Private vOrgName As String = ""
    Private vTitleName As String = ""
    Private vObtainYear As Int32 = 0
    Private vObtainMonth As Int32 = 0
    Private vLevel As String = ""

    Public Property OrgName() As String
        Get
            Return vOrgName
        End Get
        Set(ByVal v As String)
            vOrgName = v
        End Set
    End Property

    Public Property TitleName() As String
        Get
            Return vTitleName
        End Get
        Set(ByVal v As String)
            vTitleName = v
        End Set
    End Property

    Public Property ObtainYear() As Int32
        Get
            Return vObtainYear
        End Get
        Set(ByVal v As Int32)
            vObtainYear = v
        End Set
    End Property
    Public Property Level() As String
        Get
            Return vLevel
        End Get
        Set(ByVal v As String)
            vLevel = v
        End Set
    End Property

    Public Property ObtainMonth() As Int32
        Get
            Return vObtainMonth
        End Get
        Set(ByVal v As Int32)
            vObtainMonth = v
        End Set
    End Property
End Class
