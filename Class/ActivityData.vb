Public Class ActivityData

    Private vOrgName As String = ""
    Private vTitleName As String = ""
    Private vFromMonth As Int32 = 0
    Private vFromYear As Int32 = 0
    Private vToYear As Int32 = 0
    Private vToMonth As Int32 = 0

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

    Public Property FromMonth() As Int32
        Get
            Return vFromMonth
        End Get
        Set(ByVal v As Int32)
            vFromMonth = v
        End Set
    End Property

    Public Property FromYear() As Int32
        Get
            Return vFromYear
        End Get
        Set(ByVal v As Int32)
            vFromYear = v
        End Set
    End Property

    Public Property ToMonth() As Int32
        Get
            Return vToMonth
        End Get
        Set(ByVal v As Int32)
            vToMonth = v
        End Set
    End Property

    Public Property ToYear() As Int32
        Get
            Return vToYear
        End Get
        Set(ByVal v As Int32)
            vToYear = v
        End Set
    End Property

End Class
