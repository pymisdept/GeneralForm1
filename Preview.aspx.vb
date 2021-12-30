Partial Public Class Preview
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            InitHeaderData()
            InitEduData()
            InitAwardData()
            InitActvData()
            InitQualiData()
            InitJobData()
            InitLangData()
            InitSWData()
            InitFilesData()

            ' Clear Session Data everytime
            ClearSessionData()
        Else
            ' Response.Redirect("Error.aspx")
        End If
    End Sub

    Private Sub ClearSessionData()
        Session.Remove("P1HDR")
        Session.Remove("P1EDU")
        Session.Remove("P2AWD")
        Session.Remove("P2ACT")
        Session.Remove("P2QUL")
        Session.Remove("P2JOB")
        Session.Remove("P2LAG")
        Session.Remove("P2SWR")
        Session.Remove("P2FIS")
    End Sub

    Private Sub InitHeaderData()
        If Session("P1HDR") IsNot Nothing Then
            Dim hdr As New HeaderData()

            hdr = Session("P1HDR")

            lbl_refno.Text = hdr.RefNum()
            lbl_appjob.Text = hdr.AppliedPosCode()

            lbl_title.Text = hdr.Salutation()
            lbl_surname.Text = hdr.Eng_Surname()
            lbl_othername.Text = hdr.Eng_Othername()
            lbl_chnname.Text = hdr.Chi_Name()
            lbl_email.Text = hdr.Email()
            lbl_phone.Text = hdr.Phone()
            lbl_address.Text = hdr.GetFormatAdderss()

            lbl_sal.Text = hdr.Salary()

            If hdr.ADate_V = "OTH" Then
                lbl_ead.Text = hdr.ADateOther()
            Else
                lbl_ead.Text = hdr.ADate_T()
            End If

            lbl_workingvisa.Text() = hdr.WVISA_T()

            If hdr.KnowVacancy_V() = "OTH" Then
                lbl_knowfrom.Text = hdr.KnowVacancyOth()
            Else
                lbl_knowfrom.Text = hdr.KnowVacancy_T()
            End If

        Else
            Response.Redirect("Error.aspx")
        End If
    End Sub

    Private Sub InitEduData()
        If Session("P1EDU") IsNot Nothing Then
            Dim edulist As New List(Of EduData)

            edulist = Session("P1EDU")

            For i As Int32 = 0 To edulist.Count - 1
                Dim cur As EduData = edulist(i)

                Dim tr As New TableRow()
                Dim td1 As New TableCell()
                Dim td2 As New TableCell()
                Dim td3 As New TableCell()
                Dim td4 As New TableCell()
                Dim td5 As New TableCell()
                Dim td6 As New TableCell()

                Dim lbl1 As New Label()
                Dim lbl2 As New Label()
                Dim lbl3 As New Label()
                Dim lbl4 As New Label()
                Dim lbl5 As New Label()
                Dim lbl6 As New Label()

                If cur.Type() = "O" Then
                    lbl1.Text = cur.EduName_T()
                    lbl2.Text = cur.SchName_T()
                    lbl3.Text = cur.ProgrammeName()
                    lbl4.Text = cur.Major()
                    lbl5.Text = cur.GradYear()
                    lbl6.Text = cur.Result_T()
                Else
                    If cur.EduName_V <> "OTH" Then
                        lbl1.Text = cur.EduName_T()
                    Else
                        lbl1.Text = cur.EduOthers
                    End If

                    If cur.SchName_V <> "OTH" Then
                        lbl2.Text = cur.SchName_T()
                    Else
                        lbl2.Text = cur.SchOthers
                    End If

                    lbl3.Text = cur.ProgrammeName()
                    lbl4.Text = cur.Major()
                    lbl5.Text = cur.GradMonth().PadLeft(2, "0") & " / " & cur.GradYear().PadLeft(4, "0")

                    If cur.Result_V = "GPA" Then
                        lbl6.Text = "GPA" & ": " & cur.Result_GPA & " / " & cur.Result_CGPA
                    Else
                        lbl6.Text = "Grade" & ": " & cur.Result_Grade
                    End If
                End If

                td1.Controls.Add(lbl1)
                td2.Controls.Add(lbl2)
                td3.Controls.Add(lbl3)
                td4.Controls.Add(lbl4)
                td5.Controls.Add(lbl5)
                td6.Controls.Add(lbl6)

                tr.Cells.Add(td1)
                tr.Cells.Add(td2)
                tr.Cells.Add(td3)
                tr.Cells.Add(td4)
                tr.Cells.Add(td5)
                tr.Cells.Add(td6)

                eduTable.Rows.Add(tr)
            Next
        Else
            '  Response.Redirect("Error.aspx")
        End If
    End Sub

    Private Sub InitAwardData()

        If Session("P2AWD") IsNot Nothing Then
            Dim awdlist As New List(Of AwardData)

            awdlist = Session("P2AWD")

            For i As Int32 = 0 To awdlist.Count - 1
                Dim cur As AwardData = awdlist(i)

                Dim tr As New TableRow()
                Dim td1 As New TableCell()
                Dim td2 As New TableCell()
                Dim td3 As New TableCell()

                Dim lbl1 As New Label()
                Dim lbl2 As New Label()
                Dim lbl3 As New Label()

                lbl1.Text = cur.OrgName()
                lbl2.Text = cur.AwardDesc()
                lbl3.Text = cur.ObtainYear()

                td1.Controls.Add(lbl1)
                td2.Controls.Add(lbl2)
                td3.Controls.Add(lbl3)

                tr.Cells.Add(td1)
                tr.Cells.Add(td2)
                tr.Cells.Add(td3)

                awardTable.Rows.Add(tr)
            Next

        Else
            '  Response.Redirect("Error.aspx")
        End If
    End Sub

    Private Sub InitActvData()

        If Session("P2ACT") IsNot Nothing Then
            Dim actlist As New List(Of ActivityData)

            actlist = Session("P2ACT")

            For i As Int32 = 0 To actlist.Count - 1
                Dim cur As ActivityData = actlist(i)

                Dim tr As New TableRow()
                Dim td1 As New TableCell()
                Dim td2 As New TableCell()
                Dim td3 As New TableCell()
                Dim td4 As New TableCell()

                Dim lbl1 As New Label()
                Dim lbl2 As New Label()
                Dim lbl3 As New Label()
                Dim lbl4 As New Label()

                lbl1.Text = cur.OrgName()
                lbl2.Text = cur.TitleName()
                lbl3.Text = cur.FromMonth().ToString().PadLeft(2, "0") & " / " & cur.FromYear()
                lbl4.Text = cur.ToMonth().ToString().PadLeft(2, "0") & " / " & cur.ToYear()

                td1.Controls.Add(lbl1)
                td2.Controls.Add(lbl2)
                td3.Controls.Add(lbl3)
                td4.Controls.Add(lbl4)

                tr.Cells.Add(td1)
                tr.Cells.Add(td2)
                tr.Cells.Add(td3)
                tr.Cells.Add(td4)

                actvTable.Rows.Add(tr)
            Next

        Else
            '  Response.Redirect("Error.aspx")
        End If
    End Sub

    Private Sub InitQualiData()

        If Session("P2QUL") IsNot Nothing Then
            Dim qullist As New List(Of QualificationData)

            qullist = Session("P2QUL")

            For i As Int32 = 0 To qullist.Count - 1
                Dim cur As QualificationData = qullist(i)

                Dim tr As New TableRow()
                Dim td1 As New TableCell()
                Dim td2 As New TableCell()
                Dim td3 As New TableCell()

                Dim lbl1 As New Label()
                Dim lbl2 As New Label()
                Dim lbl3 As New Label()

                lbl1.Text = cur.OrgName()
                lbl2.Text = cur.TitleName()
                lbl3.Text = cur.ObtainYear()

                td1.Controls.Add(lbl1)
                td2.Controls.Add(lbl2)
                td3.Controls.Add(lbl3)

                tr.Cells.Add(td1)
                tr.Cells.Add(td2)
                tr.Cells.Add(td3)

                qualiTable.Rows.Add(tr)
            Next

        Else
            '  Response.Redirect("Error.aspx")
        End If
    End Sub

    Private Sub InitJobData()

        If Session("P2JOB") IsNot Nothing Then
            Dim joblist As New List(Of JobData)

            joblist = Session("P2JOB")

            For i As Int32 = 0 To joblist.Count - 1
                Dim cur As JobData = joblist(i)

                Dim tr As New TableRow()
                Dim td1 As New TableCell()
                Dim td2 As New TableCell()
                Dim td3 As New TableCell()
                Dim td4 As New TableCell()
                Dim td5 As New TableCell()

                Dim lbl1 As New Label()
                Dim lbl2 As New Label()
                Dim lbl3 As New Label()
                Dim lbl4 As New Label()
                Dim lbl5 As New Label()

                lbl1.Text = cur.CompName()
                lbl2.Text = cur.PosName()
                lbl3.Text = cur.FromMonth().ToString().PadLeft(2, "0") & " / " & cur.FromYear()
                lbl4.Text = cur.ToMonth().ToString().PadLeft(2, "0") & " / " & cur.ToYear()
                If cur.LastSalaryType_V() = "N" Then
                    lbl5.Text = cur.LastSalaryType_T()
                Else
                    lbl5.Text = cur.LastSalaryType_T() & " " & cur.LastSalary()
                End If

                td1.Controls.Add(lbl1)
                td2.Controls.Add(lbl2)
                td3.Controls.Add(lbl3)
                td4.Controls.Add(lbl4)
                td5.Controls.Add(lbl5)

                tr.Cells.Add(td1)
                tr.Cells.Add(td2)
                tr.Cells.Add(td3)
                tr.Cells.Add(td4)
                tr.Cells.Add(td5)

                jobTable.Rows.Add(tr)
            Next

        Else
            ' Response.Redirect("Error.aspx")
        End If
    End Sub

    Private Sub InitLangData()

        If Session("P2LAG") IsNot Nothing Then
            Dim laglist As New List(Of LanguageData)

            laglist = Session("P2LAG")

            For i As Int32 = 0 To laglist.Count - 1
                Dim cur As LanguageData = laglist(i)

                Dim lbl1 As New Label()
                Dim lbl2 As New Label()

                lbl1.CssClass = "col-4"
                lbl1.Text = "- " & cur.Lang()
                lbl2.CssClass = "col-8"
                lbl2.Text = String.Format("說話能力 Speaking ({0}), 閱讀能力 Reading ({1}), 寫作能力 Writing ({2}) ", cur.Speaking_T(), cur.Reading_T(), cur.Writing_T())

                div_Lang.Controls.Add(lbl1)
                div_Lang.Controls.Add(lbl2)
            Next

        Else
            ' Response.Redirect("Error.aspx")
        End If
    End Sub

    Private Sub InitSWData()

        If Session("P2SWR") IsNot Nothing Then
            Dim swrlist As New List(Of SoftwareData)

            swrlist = Session("P2SWR")

            For i As Int32 = 0 To swrlist.Count - 1
                Dim cur As SoftwareData = swrlist(i)

                Dim lbl1 As New Label()
                Dim lbl2 As New Label()

                lbl1.CssClass = "col-4"
                lbl1.Text = "- " & cur.SoftwareName()
                lbl2.CssClass = "col-8"
                lbl2.Text = cur.Prof_T()

                div_Sw.Controls.Add(lbl1)
                div_Sw.Controls.Add(lbl2)
            Next

        Else
            '   Response.Redirect("Error.aspx")
        End If
    End Sub

    Private Sub InitFilesData()
        If Session("P2FIS") IsNot Nothing Then
            Dim cur As New FileData()

            cur = Session("P2FIS")

            For k As Integer = 1 To 5
                If cur.getFilenameByID(k) <> "" Then
                    Dim myDivs As New Literal()
                    myDivs.Text = "<div class='col-12 row subrow'><div class='col-4'> - " & cur.getFilenameByID(k) & "</div><div class='col-8'>" & cur.getFilesizeByID(k) & "</div></div>"
                    div_Files.Controls.Add(myDivs)
                End If
            Next
        Else
            '  Response.Redirect("Error.aspx")
        End If
    End Sub

End Class