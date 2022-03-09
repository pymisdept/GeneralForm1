Public Class JobData

    Private vRefNum As String = ""
    Private vCompName As String = ""
    Private vPosName As String = ""
    Private vFromMonth As Int32 = 0
    Private vFromYear As Int32 = 0
    Private vToMonth As Int32 = 0
    Private vToYear As Int32 = 0
    Private vLastSalaryType_V As String = ""
    Private vLastSalaryType_T As String = ""
    Private vLastSalary As String = ""
    Private vBusinessNature As String = ""
    Private vLeaveReason_V As String = ""
    Private vLeaveReason_T As String = ""
    Private vLeaveROthers As String = ""

    Public Property CompName() As String
        Get
            Return vCompName
        End Get
        Set(ByVal v As String)
            vCompName = v
        End Set
    End Property

    Public Property BusinessNature() As String
        Get
            Return vBusinessNature
        End Get
        Set(ByVal v As String)
            vBusinessNature = v
        End Set
    End Property

    Public Property LeaveReason_V() As String
        Get
            Return vLeaveReason_V
        End Get
        Set(ByVal v As String)
            vLeaveReason_V = v
        End Set
    End Property

    Public Property LeaveReason_T() As String
        Get
            Return vLeaveReason_T
        End Get
        Set(ByVal v As String)
            vLeaveReason_T = v
        End Set
    End Property

    Public Property LeaveROthers() As String
        Get
            Return vLeaveROthers
        End Get
        Set(ByVal v As String)
            vLeaveROthers = v
        End Set
    End Property
    Public Property PosName() As String
        Get
            Return vPosName
        End Get
        Set(ByVal v As String)
            vPosName = v
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

    Public Property LastSalaryType_V() As String
        Get
            Return vLastSalaryType_V
        End Get
        Set(ByVal v As String)
            vLastSalaryType_V = v
        End Set
    End Property

    Public Property LastSalaryType_T() As String
        Get
            Return vLastSalaryType_T
        End Get
        Set(ByVal v As String)
            vLastSalaryType_T = v
        End Set
    End Property

    Public Property LastSalary() As String
        Get
            Return vLastSalary
        End Get
        Set(ByVal v As String)
            vLastSalary = v
        End Set
    End Property

End Class
