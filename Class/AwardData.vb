Public Class AwardData

    Private vOrgName As String = ""
    Private vAwardDesc As String = ""
    Private vObtainYear As Int32 = 0

    Public Property OrgName() As String
        Get
            Return vOrgName
        End Get
        Set(ByVal v As String)
            vOrgName = v
        End Set
    End Property

    Public Property AwardDesc() As String
        Get
            Return vAwardDesc
        End Get
        Set(ByVal v As String)
            vAwardDesc = v
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

End Class
