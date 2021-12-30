Public Class HeaderData

    Private vRefNum As String = ""
    Private vAppliedPosCode As String = ""
    Private vSalutation As String = ""
    Private vEng_Surname As String = ""
    Private vEng_Othername As String = ""
    Private vChi_Name As String = ""
    Private vEmail As String = ""
    Private vPhone As String = ""
    Private vAddr_Room As String = ""
    Private vAddr_Floor As String = ""
    Private vAddr_House As String = ""
    Private vAddr_Building As String = ""
    Private vAddr_Street As String = ""
    Private vAddr_Subdistrict As String = ""
    Private vAddr_District As String = ""

    Private vSalary As String = ""
    Private vADate_T As String = ""
    Private vADate_V As String = ""
    Private vADateOther As String = ""
    Private vWVISA_T As String = ""
    Private vWVISA_V As String = ""
    Private vKnowVacancy_T As String = ""
    Private vKnowVacancy_V As String = ""
    Private vKnowVacancyOth As String = ""

    Private vFiles As String

    Public Property RefNum() As String
        Get
            Return vRefNum
        End Get
        Set(ByVal v As String)
            vRefNum = v
        End Set
    End Property

    Public Property AppliedPosCode() As String
        Get
            Return vAppliedPosCode
        End Get
        Set(ByVal v As String)
            vAppliedPosCode = v
        End Set
    End Property

    Public Property Salutation() As String
        Get
            Return vSalutation
        End Get
        Set(ByVal v As String)
            vSalutation = v
        End Set
    End Property

    Public Property Eng_Surname() As String
        Get
            Return vEng_Surname
        End Get
        Set(ByVal v As String)
            vEng_Surname = v
        End Set
    End Property

    Public Property Eng_Othername() As String
        Get
            Return vEng_Othername
        End Get
        Set(ByVal v As String)
            vEng_Othername = v
        End Set
    End Property

    Public Property Chi_Name() As String
        Get
            Return vChi_Name
        End Get
        Set(ByVal v As String)
            vChi_Name = v
        End Set
    End Property

    Public Property Email() As String
        Get
            Return vEmail
        End Get
        Set(ByVal v As String)
            vEmail = v
        End Set
    End Property

    Public Property Phone() As String
        Get
            Return vPhone
        End Get
        Set(ByVal v As String)
            vPhone = v
        End Set
    End Property

    Public Property Addr_Room() As String
        Get
            Return vAddr_Room
        End Get
        Set(ByVal v As String)
            vAddr_Room = v
        End Set
    End Property

    Public Property Addr_Floor() As String
        Get
            Return vAddr_Floor
        End Get
        Set(ByVal v As String)
            vAddr_Floor = v
        End Set
    End Property

    Public Property Addr_House() As String
        Get
            Return vAddr_House
        End Get
        Set(ByVal v As String)
            vAddr_House = v
        End Set
    End Property

    Public Property Addr_Building() As String
        Get
            Return vAddr_Building
        End Get
        Set(ByVal v As String)
            vAddr_Building = v
        End Set
    End Property

    Public Property Addr_Street() As String
        Get
            Return vAddr_Street
        End Get
        Set(ByVal v As String)
            vAddr_Street = v
        End Set
    End Property

    Public Property Addr_Subdistrict() As String
        Get
            Return vAddr_Subdistrict
        End Get
        Set(ByVal v As String)
            vAddr_Subdistrict = v
        End Set
    End Property

    Public Property Addr_District() As String
        Get
            Return vAddr_District
        End Get
        Set(ByVal v As String)
            vAddr_District = v
        End Set
    End Property

    Public Property Salary() As String
        Get
            Return vSalary
        End Get
        Set(ByVal v As String)
            vSalary = v
        End Set
    End Property

    Public Property ADate_T() As String
        Get
            Return vADate_T
        End Get
        Set(ByVal v As String)
            vADate_T = v
        End Set
    End Property

    Public Property ADate_V() As String
        Get
            Return vADate_V
        End Get
        Set(ByVal v As String)
            vADate_V = v
        End Set
    End Property

    Public Property ADateOther() As String
        Get
            Return vADateOther
        End Get
        Set(ByVal v As String)
            vADateOther = v
        End Set
    End Property

    Public Property WVISA_T() As String
        Get
            Return vWVISA_T
        End Get
        Set(ByVal v As String)
            vWVISA_T = v
        End Set
    End Property

    Public Property WVISA_V() As String
        Get
            Return vWVISA_V
        End Get
        Set(ByVal v As String)
            vWVISA_V = v
        End Set
    End Property

    Public Property KnowVacancy_T() As String
        Get
            Return vKnowVacancy_T
        End Get
        Set(ByVal v As String)
            vKnowVacancy_T = v
        End Set
    End Property

    Public Property KnowVacancy_V() As String
        Get
            Return vKnowVacancy_V
        End Get
        Set(ByVal v As String)
            vKnowVacancy_V = v
        End Set
    End Property

    Public Property KnowVacancyOth() As String
        Get
            Return vKnowVacancyOth
        End Get
        Set(ByVal v As String)
            vKnowVacancyOth = v
        End Set
    End Property

    Public Function GetFormatAdderss() As String

        Return "<u>室 Room: </u>" & vAddr_Room & "<br /><u>樓層 Floor: </u>" & vAddr_Floor & "<br /><u>樓/座 House/Block: </u>" & vAddr_House & "<br /><u>大廈/屋苑 Building/Estate: </u>" & vAddr_Building & "<br /><u>街道 Street: </u>" & vAddr_Street & "<br /><u>地區 District: </u>" & vAddr_District

    End Function
End Class
