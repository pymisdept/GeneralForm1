Public Class SoftwareData
    Private vSoftwareName As String = ""
    Private vProf_V As String = ""
    Private vProf_T As String = ""

    Public Property SoftwareName() As String
        Get
            Return vSoftwareName
        End Get
        Set(ByVal v As String)
            vSoftwareName = v
        End Set
    End Property

    Public Property Prof_V() As String
        Get
            Return vProf_V
        End Get
        Set(ByVal v As String)
            vProf_V = v
        End Set
    End Property


    Public Property Prof_T() As String
        Get
            Return vProf_T
        End Get
        Set(ByVal v As String)
            vProf_T = v
        End Set
    End Property



End Class
