Public Class HeaderData

    Private vRefNum As String = ""

    'Private vAppliedPosCode As String = ""
    Private vAppliedPositionDesc As String = ""
    Private vAppliedPosCode As String = ""
    Private vSalutation As String = ""
    Private vAlias As String = ""

    Private vEng_Surname As String = ""
    Private vEng_Othername As String = ""
    Private vChi_Name As String = ""

    Private vDList_IDCard_V As String = ""
    Private vDList_IDCard_T As String = ""



    Private vIDCard As String = ""
    Private vIDCard_2 As String = ""

    Private vEmail As String = ""
    Private vPhone As String = ""
    Private vMobile As String = ""

    'Private vAddr_Room As String = ""
    'Private vAddr_Floor As String = ""
    'Private vAddr_House As String = ""
    'Private vAddr_Building As String = ""
    'Private vAddr_Street As String = ""

    Private vAddr_1 As String = ""
    Private vAddr_2 As String = ""
    Private vAddr_3 As String = ""

    Private vAddr_Subdistrict As String = ""
    Private vAddr_Subdistrict_T As String = ""
    Private vAddr_District As String = ""
    Private vAddr_dsCode As String = ""

    Private vSalary As String = ""
    Private vADate_T As String = ""
    Private vADate_V As String = ""
    Private vADateOther As String = ""

    Private vMaritalStatus_V As String = ""
    Private vMaritalStatus_T As String = ""

    Private vWVISA_T As String = ""
    Private vWVISA_V As String = ""
    Private vKnowVacancy_T As String = ""
    Private vKnowVacancy_V As String = ""
    Private vKnowVacancyOth As String = ""

    Private vFiles As String

    Private vDateOfBirth As String
    Private vNationality As String
    Private vSpouseName As String

    Private vMaritalStatus As String
    Private vSpouseHKID As String
    Private vEmergencyContactPerson As String
    Private vEmergencyContactRelationship As String
    Private vEmergencyContactPhone As String
    Private vEmergencyContactAddr As String

    Private vctrl_txt_REF1 As String
    Private vctrl_txt_REF2 As String
    Private vctrl_txt_REF3 As String
    Private vWorkPerson_1 As String
    Private vWorkPerson_2 As String
    Private vWorkPerson_3 As String
    Private vEnglishTypeWPM As String
    Private vChineseTypeWPM As String

    Private vOtherSkills As String
    Private vreference_employeeBefore_V As String
    Private vreference_guility_V As String
    Private vreference_enquiryfromPrevEmployer_V As String
    Private vreference_injuiryleave_V As String
    Private vreference_employeeBefore_T As String
    Private vreference_guility_T As String
    Private vreference_enquiryfromPrevEmployer_T As String
    Private vreference_injuiryleave_T As String

    Private vreference_TxtInputRef_2 As String
    Private vreference_TxtInputRef_3 As String
    Private vreference_TxtInputRef_4 As String

    Private vdlist_gencompany_T As String
    Private vdlist_gencompany_V As String

    Private vdlist_perunit_V As String
    Private vdlist_perunit_T As String
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


    Public Property AppliedPositionDesc() As String
        Get
            Return vAppliedPositionDesc
        End Get
        Set(ByVal v As String)
            vAppliedPositionDesc = v
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

    Public Property PersonAlias() As String
        Get
            Return vAlias
        End Get
        Set(ByVal v As String)
            vAlias = v
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

    Public Property Mobile() As String
        Get
            Return vMobile
        End Get
        Set(ByVal v As String)
            vMobile = v
        End Set
    End Property




    Public Property IDCard() As String
        Get
            Return vIDCard
        End Get
        Set(ByVal v As String)
            vIDCard = v
        End Set
    End Property

    Public Property IDCard_2() As String
        Get
            Return vIDCard_2
        End Get
        Set(ByVal v As String)
            vIDCard_2 = v
        End Set
    End Property


    'Public Property Addr_Room() As String
    '    Get
    '        Return vAddr_Room
    '    End Get
    '    Set(ByVal v As String)
    '        vAddr_Room = v
    '    End Set
    'End Property

    'Public Property Addr_Floor() As String
    '    Get
    '        Return vAddr_Floor
    '    End Get
    '    Set(ByVal v As String)
    '        vAddr_Floor = v
    '    End Set
    'End Property

    'Public Property Addr_House() As String
    '    Get
    '        Return vAddr_House
    '    End Get
    '    Set(ByVal v As String)
    '        vAddr_House = v
    '    End Set
    'End Property

    'Public Property Addr_Building() As String
    '    Get
    '        Return vAddr_Building
    '    End Get
    '    Set(ByVal v As String)
    '        vAddr_Building = v
    '    End Set
    'End Property

    'Public Property Addr_Street() As String
    '    Get
    '        Return vAddr_Street
    '    End Get
    '    Set(ByVal v As String)
    '        vAddr_Street = v
    '    End Set
    'End Property

    Public Property Addr_1() As String
        Get
            Return vAddr_1
        End Get
        Set(ByVal v As String)
            vAddr_1 = v
        End Set
    End Property

    Public Property Addr_2() As String
        Get
            Return vAddr_2
        End Get
        Set(ByVal v As String)
            vAddr_2 = v
        End Set
    End Property

    Public Property Addr_3() As String
        Get
            Return vAddr_3
        End Get
        Set(ByVal v As String)
            vAddr_3 = v
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

    Public Property dlist_perunit_V() As String
        Get
            Return vdlist_perunit_V
        End Get
        Set(ByVal v As String)
            vdlist_perunit_V = v
        End Set
    End Property

    Public Property dlist_perunit_T() As String
        Get
            Return vdlist_perunit_T
        End Get
        Set(ByVal v As String)
            vdlist_perunit_T = v
        End Set
    End Property

    Public Property DList_IDCard_V() As String
        Get
            Return vDList_IDCard_V
        End Get
        Set(ByVal v As String)
            vDList_IDCard_V = v
        End Set
    End Property

    Public Property DList_IDCard_T() As String
        Get
            Return vDList_IDCard_T
        End Get
        Set(ByVal v As String)
            vDList_IDCard_T = v
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

    Public Property addr_dsCode() As String
        Get
            Return vAddr_dsCode
        End Get
        Set(ByVal v As String)
            vAddr_dsCode = v
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

    Public Property dlist_gencompany_T() As String
        Get
            Return vdlist_gencompany_T
        End Get
        Set(ByVal v As String)
            vdlist_gencompany_T = v
        End Set
    End Property

    Public Property dlist_gencompany_V() As String
        Get
            Return vdlist_gencompany_V
        End Get
        Set(ByVal v As String)
            vdlist_gencompany_V = v
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

    Public Property Addr_Subdistrict_T() As String
        Get
            Return vAddr_Subdistrict_T
        End Get
        Set(ByVal v As String)
            vAddr_Subdistrict_T = v
        End Set
    End Property


    Public Function GetFormatAdderss() As String
        Dim taddr As String

        'Return "<u>室 Room: </u>" & vAddr_Room & "<br /><u>樓層 Floor: </u>" & vAddr_Floor & "<br /><u>樓/座 House/Block: </u>" & vAddr_House & "<br /><u>大廈/屋苑 Building/Estate: </u>" & vAddr_Building & "<br /><u>街道 Street: </u>" & vAddr_Street & "<br /><u>地區 District: </u>" & vAddr_District

        taddr = ""
        If vAddr_1 <> "" Then
            taddr = vAddr_1
        End If
        If vAddr_2 <> "" Then
            If taddr = "" Then
                taddr = vAddr_2
            Else
                taddr = taddr + "<br />" + Trim(vAddr_2)
            End If
        End If
        If vAddr_3 <> "" Then
            If taddr = "" Then
                taddr = vAddr_3
            Else
                taddr = taddr + "<br />" + Trim(vAddr_3)
            End If
        End If

        If vAddr_Subdistrict_T <> "" Then
            If taddr = "" Then
                taddr = vAddr_Subdistrict_T
            Else
                taddr = taddr + "<br />" + Trim(vAddr_Subdistrict_T)
            End If
        End If

        If vAddr_District <> "" Then
            If taddr = "" Then
                taddr = vAddr_District
            Else
                taddr = taddr + "<br />" + Trim(vAddr_District)
            End If
        End If

        'Return "<u>地址 1 Address 1: </u>" & vAddr_1 & "<br /><u>地址 2 Address 2: </u>" & vAddr_2 & "<br /><u>地址 3 Address 3: </u>" & vAddr_3 & "<br /><u>小區 Sub-district: </u>" & vAddr_Subdistrict_T & "<br /><u>地區 District: </u>" & vAddr_District
        Return taddr

    End Function



    Public Property DateOfBirth() As String
        Get
            Return vDateOfBirth
        End Get
        Set(ByVal v As String)
            vDateOfBirth = v
        End Set
    End Property

    Public Property Nationality() As String
        Get
            Return vNationality
        End Get
        Set(ByVal v As String)
            vNationality = v
        End Set
    End Property

    Public Property MaritalStatus_V() As String
        Get
            Return vMaritalStatus_V
        End Get
        Set(ByVal v As String)
            vMaritalStatus_V = v
        End Set
    End Property

    Public Property MaritalStatus_T() As String
        Get
            Return vMaritalStatus_T
        End Get
        Set(ByVal v As String)
            vMaritalStatus_T = v
        End Set
    End Property
    Public Property SpouseName() As String
        Get
            Return vSpouseName
        End Get
        Set(ByVal v As String)
            vSpouseName = v
        End Set
    End Property

    Public Property SpouseHKID() As String
        Get
            Return vSpouseHKID
        End Get
        Set(ByVal v As String)
            vSpouseHKID = v
        End Set
    End Property

    Public Property EmergencyContactPerson() As String
        Get
            Return vEmergencyContactPerson
        End Get
        Set(ByVal v As String)
            vEmergencyContactPerson = v
        End Set
    End Property

    Public Property EmergencyContactRelationship() As String
        Get
            Return vEmergencyContactRelationship
        End Get
        Set(ByVal v As String)
            vEmergencyContactRelationship = v
        End Set
    End Property
    Public Property EmergencyContactPhone() As String
        Get
            Return vEmergencyContactPhone
        End Get
        Set(ByVal v As String)
            vEmergencyContactPhone = v
        End Set
    End Property


    Public Property EmergencyContactAddr() As String
        Get
            Return vEmergencyContactAddr
        End Get
        Set(ByVal v As String)
            vEmergencyContactAddr = v
        End Set
    End Property

    Public Property ctrl_txt_REF1() As String
        Get
            Return vctrl_txt_REF1
        End Get
        Set(ByVal v As String)
            vctrl_txt_REF1 = v
        End Set
    End Property

    Public Property ctrl_txt_REF2() As String
        Get
            Return vctrl_txt_REF2
        End Get
        Set(ByVal v As String)
            vctrl_txt_REF2 = v
        End Set
    End Property

    Public Property ctrl_txt_REF3() As String
        Get
            Return vctrl_txt_REF3
        End Get
        Set(ByVal v As String)
            vctrl_txt_REF3 = v
        End Set
    End Property
    Public Property WorkPerson_1() As String
        Get
            Return vWorkPerson_1
        End Get
        Set(ByVal v As String)
            vWorkPerson_1 = v
        End Set
    End Property

    Public Property WorkPerson_2() As String
        Get
            Return vWorkPerson_2
        End Get
        Set(ByVal v As String)
            vWorkPerson_2 = v
        End Set
    End Property

    Public Property WorkPerson_3() As String
        Get
            Return vWorkPerson_3
        End Get
        Set(ByVal v As String)
            vWorkPerson_3 = v
        End Set
    End Property

    Public Property EnglishTypeWPM() As String
        Get
            Return vEnglishTypeWPM
        End Get
        Set(ByVal v As String)
            vEnglishTypeWPM = v
        End Set
    End Property

    Public Property ChineseTypeWPM() As String
        Get
            Return vChineseTypeWPM
        End Get
        Set(ByVal v As String)
            vChineseTypeWPM = v
        End Set
    End Property

    Public Property OtherSkills() As String
        Get
            Return vOtherSkills
        End Get
        Set(ByVal v As String)
            vOtherSkills = v
        End Set
    End Property

    Public Property reference_employeeBefore_V() As String
        Get
            Return vreference_employeeBefore_V
        End Get
        Set(ByVal v As String)
            vreference_employeeBefore_V = v
        End Set
    End Property

    Public Property reference_employeeBefore_T() As String
        Get
            Return vreference_employeeBefore_T
        End Get
        Set(ByVal v As String)
            vreference_employeeBefore_T = v
        End Set
    End Property


    Public Property reference_guility_V() As String
        Get
            Return vreference_guility_V
        End Get
        Set(ByVal v As String)
            vreference_guility_V = v
        End Set
    End Property

    Public Property reference_guility_T() As String
        Get
            Return vreference_guility_T
        End Get
        Set(ByVal v As String)
            vreference_guility_T = v
        End Set
    End Property

    Public Property reference_enquiryfromPrevEmployer_V() As String
        Get
            Return vreference_enquiryfromPrevEmployer_V
        End Get
        Set(ByVal v As String)
            vreference_enquiryfromPrevEmployer_V = v
        End Set
    End Property

    Public Property reference_enquiryfromPrevEmployer_T() As String
        Get
            Return vreference_enquiryfromPrevEmployer_T
        End Get
        Set(ByVal v As String)
            vreference_enquiryfromPrevEmployer_T = v
        End Set
    End Property

    Public Property reference_injuiryleave_V() As String
        Get
            Return vreference_injuiryleave_V
        End Get
        Set(ByVal v As String)
            vreference_injuiryleave_V = v
        End Set
    End Property
    Public Property reference_injuiryleave_T() As String
        Get
            Return vreference_injuiryleave_T
        End Get
        Set(ByVal v As String)
            vreference_injuiryleave_T = v
        End Set
    End Property

    Public Property reference_TxtInputRef_2() As String
        Get
            Return vreference_TxtInputRef_2
        End Get
        Set(ByVal v As String)
            vreference_TxtInputRef_2 = v
        End Set
    End Property

    Public Property reference_TxtInputRef_3() As String
        Get
            Return vreference_TxtInputRef_3
        End Get
        Set(ByVal v As String)
            vreference_TxtInputRef_3 = v
        End Set
    End Property

    Public Property reference_TxtInputRef_4() As String
        Get
            Return vreference_TxtInputRef_4
        End Get
        Set(ByVal v As String)
            vreference_TxtInputRef_4 = v
        End Set
    End Property



End Class
