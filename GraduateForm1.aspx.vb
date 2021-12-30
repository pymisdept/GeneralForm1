Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.IO
Imports System.Globalization
Imports System.Text.RegularExpressions

Partial Public Class GraduateForm1
    Inherits System.Web.UI.Page

    Private cnStr As String = ConfigurationManager.ConnectionStrings("cnCareergform1").ConnectionString
    Private cn As SqlConnection = New SqlConnection(cnStr)
    Private eduCnt As Integer
    Private Const ctrlCount As Integer = 15
    Private T_Key As String
    Private T2_Key As String
    Private curRefNum As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        T_Key = Request.QueryString("Key")
        'T2_Key = Request.QueryString("Position")
        'curRefNum = Request.QueryString("RefCode")
        curRefNum = Session("P1AREF")
        'If curRefNum = "" Then
        '    Response.Redirect("Phase2Main.aspx")
        'End If
        If curRefNum Is Nothing Then
            curRefNum = ""
            Response.Redirect("Main.aspx")
        Else
        End If

        If Not IsPostBack Then
            BindPreferredFunction()
            BindDistrict()
            BindTitle()
            BindEducation(ctrl_dlist_EDU)
            btnShowGPA()
            'BindSchool(ctrl_dlist_SCH)
            'BindGrade(ctrl_dlist_RES)

            'remarks.Attributes.Add("maxlength", "300")
            'remarks.Attributes.Add("onkeyup", "return ismaxlength(this)")
            eduCnt = 1
        Else
            RecreateControls()
        End If

        SetDListVisibility()
    End Sub

    Private Sub btnShowGPA()
        If (drpGPA.SelectedItem.Value = "G1") Then
            plGPA1.Visible = True
            plGPA2.Visible = False
        ElseIf (drpGPA.SelectedItem.Value = "G2") Then
            plGPA2.Visible = True
            plGPA1.Visible = False
        Else
            plGPA1.Visible = False
            plGPA2.Visible = False
        End If
    End Sub

    Protected Sub BindPreferredFunction()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cm As New SqlCommand

        Try

            cn.Open()

            cm = New SqlCommand("select * from preferfunc order by id", cn)
            da = New SqlDataAdapter(cm)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                pos_ds.DataSource = dt
                pos_ds.DataTextField = "description"
                pos_ds.DataValueField = "func"
                pos_ds.DataBind()
            End If

            pos_ds.Items.Insert(0, New ListItem("-- please select --", ""))
            pos_ds.SelectedIndex = 0

        Catch
            'MsgBox("Fetch Performance Functions error")
        Finally
            cn.Close()
        End Try
    End Sub

    Protected Sub BindTitle()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cm As New SqlCommand

        Try

            cn.Open()

            cm = New SqlCommand("select * from title order by id", cn)
            da = New SqlDataAdapter(cm)
            da.Fill(dt)

            'If dt.Rows.Count > 0 Then
            '    ptitle.DataSource = dt
            '    ptitle.DataTextField = "title"
            '    ptitle.DataValueField = "title"
            '    ptitle.DataBind()
            'End If

            'ptitle.Items.Insert(0, New ListItem("-- Please Select --", ""))
            'ptitle.SelectedIndex = 0

        Catch
            'MsgBox("Fetch Title error")
        Finally
            cn.Close()
        End Try
    End Sub

    Protected Sub BindDistrict()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cm As New SqlCommand

        Try

            cn.Open()

            cm = New SqlCommand("select * from district order by id", cn)
            da = New SqlDataAdapter(cm)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                addr_ds.DataSource = dt
                addr_ds.DataTextField = "description"
                addr_ds.DataValueField = "district"
                addr_ds.DataBind()
            End If

            addr_ds.Items.Insert(0, New ListItem("-- Please Select District --", ""))
            addr_ds.SelectedIndex = 0

        Catch
            'MsgBox("Fetch District error")
        Finally
            cn.Close()
        End Try
    End Sub

    Protected Sub BindEducation(ByVal edu As DropDownList)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cm As New SqlCommand

        Try

            cn.Open()

            cm = New SqlCommand("select * from education order by id", cn)
            da = New SqlDataAdapter(cm)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                edu.DataSource = dt
                edu.DataTextField = "description"
                edu.DataValueField = "education"
                edu.DataBind()
            End If

            edu.Items.Insert(0, New ListItem("-- Please Select --", ""))
            edu.SelectedIndex = 0

        Catch
            'MsgBox("Fetch Education1 error")
        Finally
            cn.Close()
        End Try
    End Sub

    Protected Sub BindSchool(ByVal school As DropDownList)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cm As New SqlCommand

        Try

            cn.Open()

            cm = New SqlCommand("select * from school order by id", cn)
            da = New SqlDataAdapter(cm)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                school.DataSource = dt
                school.DataTextField = "description"
                school.DataValueField = "school"
                school.DataBind()
            End If

            school.Items.Insert(0, New ListItem("-- Please Select --", ""))
            school.SelectedIndex = 0

        Catch
            'MsgBox("Fetch School1 error")
        Finally
            cn.Close()
        End Try
    End Sub

    Protected Sub BindGrade(ByVal grade As DropDownList)

        grade.Items.Insert(0, New ListItem("-- Please Select --", ""))
        grade.Items.Add(New ListItem("Cumulative GPA", "GPA"))
        grade.Items.Add(New ListItem("Grade", "GRA"))

        grade.DataBind()
        grade.SelectedIndex = 0

    End Sub

    Protected Sub SaveData()

        Dim cm As SqlCommand

        Dim cm2 As SqlCommand

        Dim m_swstr As String = ""
        Dim m_langStr As String = ""
        Dim dr As SqlDataReader

        Dim oTrans As SqlTransaction

        Dim seqNo As String = ""
        Dim refNum As String = ""
        If (Not chkCaT1.Checked Or Not chkCaT2.Checked) Then
            MessageBox("Please tick declare option 請勾選個人資料收集及聲明條件選項！")

            Return
        End If
        cn.Open()
        oTrans = cn.BeginTransaction()

        cm = New SqlCommand()
        cm2 = New SqlCommand()

        cm.Connection = cn
        cm2.Connection = cn

        cm.Transaction = oTrans
        cm2.Transaction = oTrans

        ''''' (1) Get and Update Seq No. - Begin

        Try
            cm.CommandText = "SELECT * FROM sequence where PosCode = @pos AND [year] = YEAR(getdate())"
            cm.CommandType = CommandType.Text
            cm.Parameters.Add("@pos", SqlDbType.NVarChar).Value = Request.Form("PosApplied")

            dr = cm.ExecuteReader
            If dr.Read() Then
                seqNo = dr("seqNum").ToString().PadLeft(3, "0")
            Else
                seqNo = "001"
            End If
            dr.Close()
            cm = Nothing

            cm2.CommandText = "sp_updateSeq"
            cm2.CommandType = CommandType.StoredProcedure
            cm2.Parameters.AddWithValue("@pos", Request.Form("PosApplied"))
            cm2.ExecuteNonQuery()
            refNum = Request.Form("PosApplied") & DateTime.Now.ToString("yy") & seqNo

            ''''' (1) Get and Update Seq No. - End

            ''''' (2) Upload File - Begin
            Dim filepath As String = ConfigurationManager.AppSettings("UploadToPathgform12")

            Dim f1 As String = refNum & "_" & DateTime.Now.ToString("MMddHHmmss") & "_P1001" & fUpload1.FileName.Substring(fUpload1.FileName.LastIndexOf("."))
            fUpload1.SaveAs(filepath & f1)

            Dim f2, f3, f4, f5 As String

            If fUpload2.FileName <> "" Then
                f2 = refNum & "_" & DateTime.Now.ToString("MMddHHmmss") & "_P1002" & fUpload2.FileName.Substring(fUpload2.FileName.LastIndexOf("."))
                fUpload2.SaveAs(filepath & f2)
            Else
                f2 = ""
            End If

            If fUpload3.FileName <> "" Then
                f3 = refNum & "_" & DateTime.Now.ToString("MMddHHmmss") & "_P1003" & fUpload3.FileName.Substring(fUpload3.FileName.LastIndexOf("."))
                fUpload3.SaveAs(filepath & f3)
            Else
                f3 = ""
            End If

            If fUpload4.FileName <> "" Then
                f4 = refNum & "_" & DateTime.Now.ToString("MMddHHmmss") & "_P1004" & fUpload4.FileName.Substring(fUpload4.FileName.LastIndexOf("."))
                fUpload4.SaveAs(filepath & f4)
            Else
                f4 = ""
            End If

            If fUpload5.FileName <> "" Then
                f5 = refNum & "_" & DateTime.Now.ToString("MMddHHmmss") & "_P1005" & fUpload5.FileName.Substring(fUpload5.FileName.LastIndexOf("."))
                fUpload5.SaveAs(filepath & f5)
            Else
                f5 = ""
            End If

            ''''' (2) Upload File - End

            ''''' (3) Insert header data - Begin
            cm2.CommandText = "INSERT INTO Application_P1_Hdr(RefNum,AppliedPosCode,AppliedDate,Salutation,Eng_Surname,Eng_Othername,Chi_Name,Email,Phone,Addr_1,Addr_2,Addr_3,Addr_Subdistrict,Addr_District,Remarks,FilePath,FileName1,FileName2,FileName3,FileName4,FileName5,Status) values (@RefNum, @AppPos, @AppDate, @Salutation, @ESurname, @EOthname, @CName, @Email, @Phone, @addr_1, @addr_2, @addr_3, @Addr_Subdistrict,@Addr_District, @Remarks, @FilePath, @FileName1, @FileName2, @FileName3, @FileName4, @FileName5, @Status)"
            cm2.CommandType = CommandType.Text
            cm2.Parameters.Clear()

            cm2.Parameters.Add("@RefNum", SqlDbType.NVarChar).Value = refNum
            cm2.Parameters.Add("@AppPos", SqlDbType.NVarChar).Value = Request.Form("PosApplied")
            cm2.Parameters.Add("@AppDate", SqlDbType.DateTime).Value = DateTime.Now
            cm2.Parameters.Add("@Salutation", SqlDbType.NVarChar).Value = Request.Form("ptitle")
            cm2.Parameters.Add("@ESurname", SqlDbType.NVarChar).Value = Request.Form("EngSurName")
            cm2.Parameters.Add("@EOthname", SqlDbType.NVarChar).Value = Request.Form("EngOtherName")
            cm2.Parameters.Add("@CName", SqlDbType.NVarChar).Value = Request.Form("ChnName")
            cm2.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Request.Form("email")
            cm2.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Request.Form("phone")

            'cm2.Parameters.Add("@Addr_Room", SqlDbType.NVarChar).Value = Request.Form("addr_rm")
            'cm2.Parameters.Add("@Addr_Floor", SqlDbType.NVarChar).Value = Request.Form("addr_fl")
            cm2.Parameters.Add("@addr_1", SqlDbType.NVarChar).Value = Request.Form("addr_1")
            cm2.Parameters.Add("@addr_2", SqlDbType.NVarChar).Value = Request.Form("addr_2")
            cm2.Parameters.Add("@addr_3", SqlDbType.NVarChar).Value = Request.Form("addr_3")
            cm2.Parameters.Add("@Addr_Subdistrict", SqlDbType.NVarChar).Value = Request.Form("addr_subd")
            cm2.Parameters.Add("@Addr_District", SqlDbType.NVarChar).Value = Request.Form("addr_ds")

            cm2.Parameters.Add("@Remarks", SqlDbType.NVarChar).Value = Request.Form("remarks")
            cm2.Parameters.Add("@FilePath", SqlDbType.NVarChar).Value = filepath
            cm2.Parameters.Add("@FileName1", SqlDbType.NVarChar).Value = f1
            cm2.Parameters.Add("@FileName2", SqlDbType.NVarChar).Value = f2
            cm2.Parameters.Add("@FileName3", SqlDbType.NVarChar).Value = f3
            cm2.Parameters.Add("@FileName4", SqlDbType.NVarChar).Value = f4
            cm2.Parameters.Add("@FileName5", SqlDbType.NVarChar).Value = f5
            cm2.Parameters.Add("@Status", SqlDbType.NVarChar).Value = "P"
            'cm2.Parameters.Add("@PWD", SqlDbType.NVarChar).Value = RandomString(10)
            cm2.ExecuteNonQuery()
            ''''' (3) Insert header data - End

            ''''' (4) Insert education data - Begin
            cm2.CommandText = "INSERT INTO Application_P1_Education(RefNum,LineNum,Edu_Level,Edu_Others,Sch_Name,Sch_Others,ProgrammeName,Major,GradMonth,GradYear,ResultType,Grade,TotalScore) values (@RefNum, @Line, @EduLevel, @EduOthers, @SchName, @SchOthers, @ProgrammeName, @Major, @GradMonth, @GradYear, @ResultType, @Grade, @TotalScore)"
            cm2.CommandType = CommandType.Text
            cm2.Parameters.Clear()

            cm2.Parameters.Add("@RefNum", SqlDbType.NVarChar).Value = refNum
            cm2.Parameters.Add("@Line", SqlDbType.Int).Value = 1
            cm2.Parameters.Add("@EduLevel", SqlDbType.NVarChar).Value = Request.Form("ctrl_dlist_EDU")
            cm2.Parameters.Add("@EduOthers", SqlDbType.NVarChar).Value = Request.Form("ctrl_txt_EDO")
            cm2.Parameters.Add("@SchName", SqlDbType.NVarChar).Value = Request.Form("ctrl_dlist_SCH")
            cm2.Parameters.Add("@SchOthers", SqlDbType.NVarChar).Value = Request.Form("ctrl_txt_SCO")
            cm2.Parameters.Add("@ProgrammeName", SqlDbType.NVarChar).Value = Request.Form("ctrl_txt_PRG")
            cm2.Parameters.Add("@Major", SqlDbType.NVarChar).Value = Request.Form("ctrl_txt_MAJ")

            cm2.Parameters.Add("@GradMonth", SqlDbType.Int).Value = Request.Form("ctrl_txt_GRM")
            cm2.Parameters.Add("@GradYear", SqlDbType.Int).Value = Request.Form("ctrl_txt_GRY")
            cm2.Parameters.Add("@ResultType", SqlDbType.NVarChar).Value = Request.Form("ctrl_dlist_RES")

            If Request.Form("ctrl_dlist_RES") = "GRA" Then
                cm2.Parameters.Add("@Grade", SqlDbType.NVarChar).Value = Request.Form("ctrl_txt_GRD")
                cm2.Parameters.Add("@TotalScore", SqlDbType.NVarChar).Value = ""
            Else
                cm2.Parameters.Add("@Grade", SqlDbType.NVarChar).Value = Request.Form("ctrl_txt_GRP")
                cm2.Parameters.Add("@TotalScore", SqlDbType.NVarChar).Value = Request.Form("ctrl_txt_GRC")
            End If
            cm2.ExecuteNonQuery()

            'Dim cnt As Integer = eduTable.Rows.Count - 1
            'If cnt > 1 Then
            '    For i As Integer = 1 To cnt - 1
            '        cm2.CommandText = "INSERT INTO Application_P1_Education(RefNum,LineNum,Edu_Level,Edu_Others,Sch_Name,Sch_Others,ProgrammeName,Major,GradMonth,GradYear,ResultType,Grade,TotalScore) values (@RefNum, @Line, @EduLevel, @EduOthers, @SchName, @SchOthers, @ProgrammeName, @Major, @GradMonth, @GradYear, @ResultType, @Grade, @TotalScore)"
            '        cm2.CommandType = CommandType.Text
            '        cm2.Parameters.Clear()

            '        cm2.Parameters.Add("@RefNum", SqlDbType.NVarChar).Value = refNum
            '        cm2.Parameters.Add("@Line", SqlDbType.Int).Value = i + 1

            '        cm2.Parameters.Add("@EduLevel", SqlDbType.NVarChar).Value = Request.Form(("ctrlDynamic_dlist_EDU_1_" & i).ToString())
            '        cm2.Parameters.Add("@EduOthers", SqlDbType.NVarChar).Value = Request.Form(("ctrlDynamic_txt_EDO_1_" & i).ToString())
            '        cm2.Parameters.Add("@SchName", SqlDbType.NVarChar).Value = Request.Form(("ctrlDynamic_dlist_SCH_2_" & i).ToString())
            '        cm2.Parameters.Add("@SchOthers", SqlDbType.NVarChar).Value = Request.Form(("ctrlDynamic_txt_SCO_2_" & i).ToString())
            '        cm2.Parameters.Add("@ProgrammeName", SqlDbType.NVarChar).Value = Request.Form(("ctrlDynamic_txt_PRG_3_" & i).ToString())
            '        cm2.Parameters.Add("@Major", SqlDbType.NVarChar).Value = Request.Form(("ctrlDynamic_txt_MAJ_4_" & i).ToString())

            '        cm2.Parameters.Add("@GradMonth", SqlDbType.Int).Value = Request.Form(("ctrlDynamic_txt_GRM_5_" & i).ToString())
            '        cm2.Parameters.Add("@GradYear", SqlDbType.Int).Value = Request.Form(("ctrlDynamic_txt_GRY_5_" & i).ToString())
            '        cm2.Parameters.Add("@ResultType", SqlDbType.NVarChar).Value = Request.Form(("ctrlDynamic_dlist_RES_6_" & i).ToString())

            '        If Request.Form(("ctrlDynamic_dlist_RES_6_" & i).ToString()) = "GRA" Then
            '            cm2.Parameters.Add("@Grade", SqlDbType.NVarChar).Value = Request.Form(("ctrlDynamic_txt_GRD_6_" & i).ToString())
            '            cm2.Parameters.Add("@TotalScore", SqlDbType.NVarChar).Value = ""
            '        Else
            '            cm2.Parameters.Add("@Grade", SqlDbType.NVarChar).Value = Request.Form(("ctrlDynamic_txt_GRP_6_" & i).ToString())
            '            cm2.Parameters.Add("@TotalScore", SqlDbType.NVarChar).Value = Request.Form(("ctrlDynamic_txt_GRC_6_" & i).ToString())
            '        End If

            '        cm2.ExecuteNonQuery()
            '    Next
            'End If

            cm2 = Nothing
            ''''' (4) Insert education data - End

            oTrans.Commit()

            ''''' (5) Send Mail & Redirect to acknowledge page - Begin
            SendEmail(refNum, Request.Form("EngSurName"), Request.Form("ptitle"))
            Session("REFNO") = refNum
            Response.Redirect("acknowledge.aspx")
            ''''' (5) Send Mail & Redirect to acknowledge page - End
            Exit Sub

        Catch ex As Exception
            'MessageBox(ex.Message)
            'Dim fs As FileStream = New FileStream(Server.MapPath("myLog" & Date.Now().Ticks & ".txt"), FileMode.Append, FileAccess.Write)
            'Dim swr As StreamWriter = New StreamWriter(fs)
            'swr.Write(ex.Message)
            'swr.Close()

            MessageBox("Your application could not be submitted, please try again later.")
            oTrans.Rollback()
        Finally
            cn.Close()
            oTrans.Dispose()
        End Try

    End Sub

    'Protected Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btninsert.Click

    '    Dim cnt As Integer = FindOccurence("ctrlDynamic") / ctrlCount

    '    '''' #1 _ Education Level
    '    Dim dlist As New DropDownList()
    '    dlist.ID = "ctrlDynamic_dlist_EDU_1_" & Convert.ToString(cnt + 1)
    '    BindEducation(dlist)
    '    FormatHTML("EDU", dlist)

    '    Dim txt1 As New TextBox()
    '    txt1.ID = "ctrlDynamic_txt_EDO_1_" & Convert.ToString(cnt + 1)
    '    FormatHTML("EDO", txt1)

    '    '''' #2 _ School
    '    Dim dlist2 As New DropDownList()
    '    dlist2.ID = "ctrlDynamic_dlist_SCH_2_" & Convert.ToString(cnt + 1)
    '    BindSchool(dlist2)
    '    FormatHTML("SCH", dlist2)

    '    Dim txt2 As New TextBox()
    '    txt2.ID = "ctrlDynamic_txt_SCO_2_" & Convert.ToString(cnt + 1)
    '    FormatHTML("SCO", txt2)

    '    '''' #3 _ Programme
    '    Dim txt3 As New TextBox()
    '    txt3.ID = "ctrlDynamic_txt_PRG_3_" & Convert.ToString(cnt + 1)
    '    FormatHTML("PRG", txt3)

    '    '''' #4 _ Major
    '    Dim txt4 As New TextBox()
    '    txt4.ID = "ctrlDynamic_txt_MAJ_4_" & Convert.ToString(cnt + 1)
    '    FormatHTML("MAJ", txt4)

    '    '''' #5,6 _ Grad Year
    '    Dim txt5 As New TextBox()
    '    txt5.ID = "ctrlDynamic_txt_GRM_5_" & Convert.ToString(cnt + 1)
    '    FormatHTML("GRM", txt5)

    '    Dim label As Label = New Label()
    '    label.ID = "ctrlDynamic_lbl_SLH_5_" & Convert.ToString(cnt + 1)
    '    label.Text = " / "

    '    Dim hidden As New HiddenField()
    '    hidden.ID = "ctrlDynamic_hidden_SLH_5_" & Convert.ToString(cnt + 1)

    '    Dim txt6 As New TextBox()
    '    txt6.ID = "ctrlDynamic_txt_GRY_5_" & Convert.ToString(cnt + 1)
    '    FormatHTML("GRY", txt6)

    '    '''' #7,8,9 _ Result
    '    Dim dlist3 As New DropDownList()
    '    dlist3.ID = "ctrlDynamic_dlist_RES_6_" & Convert.ToString(cnt + 1)
    '    dlist3.AutoPostBack = False
    '    BindGrade(dlist3)
    '    FormatHTML("RES", dlist3)
    '    'AddHandler dlist3.SelectedIndexChanged, AddressOf resChanged

    '    Dim txt7 As New TextBox()
    '    txt7.ID = "ctrlDynamic_txt_GRP_6_" & Convert.ToString(cnt + 1)
    '    FormatHTML("GRP", txt7)

    '    Dim label2 As Label = New Label()
    '    label2.ID = "ctrlDynamic_lbl_SLH_6_" & Convert.ToString(cnt + 1)
    '    label2.Text = " / "
    '    label2.Style.Item("display") = "none"

    '    Dim hidden2 As New HiddenField()
    '    hidden2.ID = "ctrlDynamic_hidden_SLH_6_" & Convert.ToString(cnt + 1)

    '    Dim txt8 As New TextBox()
    '    txt8.ID = "ctrlDynamic_txt_GRC_6_" & Convert.ToString(cnt + 1)
    '    FormatHTML("GRC", txt8)

    '    Dim txt9 As New TextBox()
    '    txt9.ID = "ctrlDynamic_txt_GRD_6_" & Convert.ToString(cnt + 1)
    '    FormatHTML("GRD", txt9)

    '    Dim hidden3 As New HiddenField()
    '    hidden3.ID = "ctrlDynamic_hidden_END_6_" & Convert.ToString(cnt + 1)

    '    Dim tr As New TableRow()
    '    Dim td1 As New TableCell()
    '    Dim td2 As New TableCell()
    '    Dim td3 As New TableCell()
    '    Dim td4 As New TableCell()
    '    Dim td5 As New TableCell()
    '    Dim td6 As New TableCell()

    '    td1.Controls.Add(dlist)
    '    td1.Controls.Add(txt1)
    '    td1.ID = "ctrlDynamic_td_1_" & Convert.ToString(cnt + 1)

    '    td2.Controls.Add(dlist2)
    '    td2.Controls.Add(txt2)
    '    td2.ID = "ctrlDynamic_td_2_" & Convert.ToString(cnt + 1)

    '    td3.Controls.Add(txt3)
    '    td3.ID = "ctrlDynamic_td_3_" & Convert.ToString(cnt + 1)

    '    td4.Controls.Add(txt4)
    '    td4.ID = "ctrlDynamic_td_4_" & Convert.ToString(cnt + 1)

    '    td5.Controls.Add(txt5)
    '    td5.Controls.Add(label)
    '    td5.Controls.Add(hidden)
    '    td5.Controls.Add(txt6)
    '    td5.ID = "ctrlDynamic_td_5_" & Convert.ToString(cnt + 1)

    '    td6.Controls.Add(dlist3)
    '    td6.Controls.Add(txt7)
    '    td6.Controls.Add(label2)
    '    td6.Controls.Add(hidden2)
    '    td6.Controls.Add(txt8)
    '    td6.Controls.Add(txt9)
    '    td6.Controls.Add(hidden3)
    '    td6.ID = "ctrlDynamic_td_6_" & Convert.ToString(cnt + 1)

    '    tr.Cells.Add(td1)
    '    tr.Cells.Add(td2)
    '    tr.Cells.Add(td3)
    '    tr.Cells.Add(td4)
    '    tr.Cells.Add(td5)
    '    tr.Cells.Add(td6)

    '    tr.ID = "ctrlDynamic_tr_" & Convert.ToString(cnt + 1)

    '    eduTable.Rows.Add(tr)

    'End Sub

    'Protected Sub btnRemove_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnremove.Click
    '    Dim cnt As Integer = eduTable.Rows.Count - 1

    '    If cnt > 1 Then
    '        eduTable.Rows.RemoveAt(cnt)
    '    Else
    '        MessageBox("請保留第一行資料 \n1st row should not be removed.")
    '    End If

    'End Sub

    Private Function FindOccurence(ByVal substr As String) As Integer
        Dim reqstr As String = Request.Form.ToString()
        Return ((reqstr.Length - reqstr.Replace(substr, "").Length) / substr.Length)
    End Function

    Private Sub RecreateControls()
        Dim ctrls As String() = Request.Form.ToString().Split("&"c)
        Dim cnt As Integer = FindOccurence("ctrlDynamic")
        Dim tr As New TableRow()
        Dim td As New TableCell()

        Dim prevCol As Integer = 1
        Dim isRowEnd As Boolean = False
        Dim hasTmp As Boolean = False
        Dim hdrValue As String = ""

        If cnt > 0 Then
            For i As Integer = 0 To ctrls.Length - 1
                If ctrls(i).StartsWith("ctrlDynamic") Then

                    Dim ctrlName As String = ctrls(i).Split("="c)(0)
                    Dim ctrlValue As String = ctrls(i).Split("="c)(1)

                    Dim ctrlParam As String() = ctrlName.Split("_")

                    Dim ctrlType As String = ctrlParam(1)
                    Dim ctrlPAR As String = ctrlParam(2)
                    Dim ctrlCol As Integer = ctrlParam(3)
                    Dim ctrlRow As String = ctrlParam(4)

                    Dim ctrl As New Control
                    Dim tmpCtrl As New Control

                    ctrlValue = Server.UrlDecode(ctrlValue)

                    If ctrlType = "txt" Then
                        Dim textbox As New TextBox()

                        textbox.ID = ctrlName
                        textbox.Text = ctrlValue

                        ctrl = textbox
                    ElseIf ctrlType = "dlist" Then
                        Dim dlist As New DropDownList()
                        dlist.ID = ctrlName

                        If ctrlPAR = "EDU" Then
                            dlist.AutoPostBack = False
                            BindEducation(dlist)
                            dlist.SelectedValue = ctrlValue
                        ElseIf ctrlPAR = "SCH" Then
                            dlist.AutoPostBack = False
                            BindSchool(dlist)
                            dlist.SelectedValue = ctrlValue
                        ElseIf ctrlPAR = "RES" Then
                            dlist.AutoPostBack = False
                            BindGrade(dlist)
                            'dlist.Items.FindByValue(ctrlValue).Selected = True
                            dlist.SelectedValue = ctrlValue
                            'AddHandler dlist.SelectedIndexChanged, AddressOf resChanged
                        End If

                        ctrl = dlist
                    ElseIf ctrlType = "hidden" Then
                        Dim hidden As New HiddenField()
                        hidden.ID = ctrlName
                        ctrl = hidden

                        If ctrlPAR = "END" Then
                            isRowEnd = True
                        ElseIf ctrlPAR = "SLH" Then
                            Dim label As New Label()
                            label.ID = "ctrlDynamic_lbl_" & ctrlPAR & "_" & ctrlCol & "_" & ctrlRow
                            label.Text = " / "

                            tmpCtrl = label
                            hasTmp = True
                        End If
                    End If

                    ctrl = FormatHTML(ctrlPAR, ctrl)

                    If prevCol <> ctrlCol Then
                        td.ID = "ctrlDynamic_td_" & ctrlCol - 1 & "_" & ctrlRow
                        tr.Cells.Add(td)
                        td = New TableCell()
                    End If

                    If hasTmp Then
                        td.Controls.Add(tmpCtrl)
                    End If


                    If isRowEnd Then
                        td.Controls.Add(ctrl)
                        td.ID = "ctrlDynamic_td_" & ctrlCol & "_" & ctrlRow & "_"
                        tr.Cells.Add(td)

                        tr.ID = "ctrlDynamic_tr_" & ctrlRow
                        'eduTable.Rows.Add(tr)

                        tr = New TableRow()
                        td = New TableCell()
                        prevCol = 1

                        isRowEnd = False
                    Else
                        prevCol = ctrlCol
                        td.Controls.Add(ctrl)
                    End If

                End If
                'Next
            Next
        End If
    End Sub

    Protected Function FormatHTML(ByVal PARAM As String, ByVal curControl As Control) As Control

        Select Case PARAM
            Case "EDU"
                Dim cc As DropDownList
                cc = curControl
                cc.CssClass = "form-control educlass formdl"
                Return cc
            Case "EDO"
                Dim cc As TextBox
                cc = curControl
                cc.CssClass = "form-control formtx"
                cc.Style.Item("display") = "none"
                Return cc
            Case "SCH"
                Dim cc As DropDownList
                cc = curControl
                cc.CssClass = "form-control schclass formdl"
                Return cc
            Case "SCO"
                Dim cc As TextBox
                cc = curControl
                cc.CssClass = "form-control formtx"
                cc.Style.Item("display") = "none"
                Return cc
            Case "PRG"
                Dim cc As TextBox
                cc = curControl
                cc.CssClass = "form-control formtx"
                Return cc
            Case "MAJ"
                Dim cc As TextBox
                cc = curControl
                cc.CssClass = "form-control formtx"
                Return cc
            Case "GRM"
                Dim cc As TextBox
                cc = curControl
                cc.Width = 30
                cc.CssClass = "form-controlsx formtxm"
                Return cc
            Case "GRY"
                Dim cc As TextBox
                cc = curControl
                cc.Width = 40
                cc.CssClass = "form-controlsx formtxy"
                Return cc
            Case "GRD"
                Dim cc As TextBox
                cc = curControl
                cc.Width = Unit.Percentage(95)
                cc.CssClass = "form-controlsx formtx"
                cc.Style.Item("display") = "none"
                Return cc
            Case "GRP"
                Dim cc As TextBox
                cc = curControl
                cc.Width = 60
                cc.CssClass = "form-controlsx formtxn"
                cc.Style.Item("display") = "none"
                Return cc
            Case "GRC"
                Dim cc As TextBox
                cc = curControl
                cc.Width = 60
                cc.CssClass = "form-controlsx formtxn formG"
                cc.Style.Item("display") = "none"
                Return cc
            Case "RES"
                Dim cc As DropDownList
                cc = curControl
                cc.Width = Unit.Percentage(95)
                cc.CssClass = "form-controlsx resdclass formdl"
                Return cc
        End Select

        Return curControl
    End Function

    Protected Sub CheckRes(ByVal val As String, ByVal tb1 As TextBox, ByVal tb2 As TextBox, ByVal tb3 As TextBox, ByVal lb1 As Label)

        If val = "GPA" Then
            tb1.Style.Item("display") = "inline"
            tb2.Style.Item("display") = "inline"
            tb3.Style.Item("display") = "none"
            lb1.Style.Item("display") = "inline"
        ElseIf val = "GRA" Then
            tb1.Style.Item("display") = "none"
            tb2.Style.Item("display") = "none"
            tb3.Style.Item("display") = "inline"
            lb1.Style.Item("display") = "none"
        Else
            tb1.Style.Item("display") = "none"
            tb2.Style.Item("display") = "none"
            tb3.Style.Item("display") = "none"
            lb1.Style.Item("display") = "none"
        End If

    End Sub

    Protected Sub CheckEDUSCH(ByVal val As String, ByVal tb1 As TextBox)

        If val = "SEC" Then
            tb1.Style.Item("display") = "inline"
        Else
            tb1.Style.Item("display") = "none"
        End If

    End Sub

    Protected Sub SetDListVisibility()

        'Dim cnt As Integer = eduTable.Rows.Count - 1

        Dim hdrC As New DropDownList()

        Dim subC1 As New TextBox()
        Dim subC2 As New TextBox()
        Dim subC3 As New TextBox()
        Dim subL1 As New Label()

        'hdrC = ctrl_dlist_RES
        'subC1 = ctrl_txt_GRP
        'subC2 = ctrl_txt_GRC
        'subC3 = ctrl_txt_GRD
        'subL1 = ctrl_lbl_SLH2
        'CheckRes(hdrC.Text, subC1, subC2, subC3, subL1)

        'hdrC = ctrl_dlist_EDU
        'subC1 = ctrl_txt_EDO
        'CheckEDUSCH(hdrC.Text, subC1)

        'hdrC = ctrl_dlist_SCH
        'subC1 = ctrl_txt_SCO
        'CheckEDUSCH(hdrC.Text, subC1)

        'If cnt > 1 Then
        '    For i As Integer = 1 To cnt - 1
        '        hdrC = FindControl("ctrlDynamic_dlist_RES_6_" & i)
        '        subC1 = FindControl("ctrlDynamic_txt_GRP_6_" & i)
        '        subC2 = FindControl("ctrlDynamic_txt_GRC_6_" & i)
        '        subC3 = FindControl("ctrlDynamic_txt_GRD_6_" & i)
        '        subL1 = FindControl("ctrlDynamic_lbl_SLH_6_" & i)

        '        CheckRes(hdrC.Text, subC1, subC2, subC3, subL1)

        '        hdrC = FindControl("ctrlDynamic_dlist_EDU_1_" & i)
        '        subC1 = FindControl("ctrlDynamic_txt_EDO_1_" & i)
        '        CheckEDUSCH(hdrC.Text, subC1)

        '        hdrC = FindControl("ctrlDynamic_dlist_SCH_2_" & i)
        '        subC1 = FindControl("ctrlDynamic_txt_SCO_2_" & i)
        '        CheckEDUSCH(hdrC.Text, subC1)
        '    Next
        'End If

    End Sub

    Protected Sub SendEmail(ByVal refNo As String, ByVal surName As String, ByVal title As String)
        Dim MailBody As String
        Dim Mail As New MailMessage

        ' Old Template
        'MailBody = "<p style='font-family: Arial, Helvetica, sans-serif;'>Dear " & EngOtherName.Text & ",<br /><br />Thank you for your registration. We will contact you soon.<br /><br />Best Regards,<br />Paul Y. Engineering Group Limited.</p>"

        ' New Template (2018-09-20)
        MailBody = "<p style='font-family: Arial, Helvetica, sans-serif; font-size: 10pt;'><u>Reference Number: [ref]</u> <br /><br />Dear [title] [surname],<br/></br /> Thank you for your application. Your application is well-received and being processed.<br /><br />Shortlisted candidates will be notified by email.<br /><br />Please check your mailbox accordingly.<br /><br /><br />Best regards,<br /><br />Human Resources Department<br /><br /><img src='[img]' width='47px' height='47px' alt='logo' /><br /><span style='font-size: 8pt;'><br />Paul Y. Engineering Group<br />11/F Paul Y Centre, 51 Hung To Road, Kwun Tong, Kowloon, Hong Kong<br />E-mail: <a href='mailto:hr@pyengineering.com'>hr@pyengineering.com</a><br />Website: <a href='http://www.pyengineering.com'>www.pyengineering.com</a></span><br /></p>"
        MailBody = Replace(MailBody, "[ref]", refNo)
        MailBody = Replace(MailBody, "[title]", title)
        MailBody = Replace(MailBody, "[surname]", surName)
        MailBody = Replace(MailBody, "[img]", "cid:pyelogo")


        Mail.Subject = "Job Application - Ref: " & refNo
        Mail.From = New MailAddress(ConfigurationManager.AppSettings("MailFrom2"))
        Mail.To.Add(New MailAddress(email.Text))

        Mail.IsBodyHtml = True
        Mail.BodyEncoding = Encoding.GetEncoding("utf-8")
        Mail.Body = MailBody

        Dim smtpClient As New SmtpClient()
        smtpClient = New SmtpClient(ConfigurationManager.AppSettings("smtpServergform12"))

        Dim altView As AlternateView = AlternateView.CreateAlternateViewFromString(MailBody, Nothing, "text/html")
        Dim pyeLogo As LinkedResource = New LinkedResource(AppDomain.CurrentDomain.BaseDirectory & "Images\pye_logo3.jpg", "image/jpeg")
        pyeLogo.ContentId = "pyelogo"
        altView.LinkedResources.Add(pyeLogo)
        Mail.AlternateViews.Add(altView)

        Try
            smtpClient.Send(Mail)
        Catch ex As Exception
            MessageBox(ex.Message)
        End Try

    End Sub

    Private Sub MessageBox(ByVal strMsg As String)
        Dim lbl As New Label
        lbl.Text = "<script language='javascript'>" & Environment.NewLine _
                   & "window.alert(" & "'" & strMsg & "'" & ")</script>"
        Page.Controls.Add(lbl)
    End Sub

    Protected Function RandomString(ByVal length As Integer) As String
        Dim random As Random = New Random()
        Dim chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Return New String(Enumerable.Repeat(chars, length).[Select](Function(s) s(random.[Next](s.Length))).ToArray())
    End Function

    Protected Sub btnSelectreferrel(sender As Object, e As EventArgs) Handles DropDownList2.SelectedIndexChanged
        If (DropDownList2.SelectedItem.Value = "ref5") Then
            staffref1.Visible = True
            staffref2.Visible = False
        ElseIf (DropDownList2.SelectedItem.Value = "ref6") Then
            staffref2.Visible = True
            staffref1.Visible = False
        Else
            staffref1.Visible = False
            staffref2.Visible = False
        End If
    End Sub

    Protected Sub btnIDcard_click(sender As Object, e As EventArgs) Handles rdIDcard1.CheckedChanged, rdIDcard2.CheckedChanged
        If (rdIDcard1.Checked) Then
            IDcard1.Visible = True
            IDcard2.Visible = False
        Else
            IDcard1.Visible = False
            IDcard2.Visible = True
        End If
    End Sub

    Protected Sub btnShowDate(sender As Object, e As EventArgs) Handles DrAvaDate.SelectedIndexChanged
        If (DrAvaDate.SelectedItem.Value = "D5") Then
            pnlAvadate.Visible = True
        Else
            pnlAvadate.Visible = False
        End If
    End Sub

    Protected Sub btnShowEDU(sender As Object, e As EventArgs) Handles ctrl_dlist_EDU.SelectedIndexChanged
        If (ctrl_dlist_EDU.SelectedItem.Value = "OTH") Then
            plEdu.Visible = True
        Else
            plEdu.Visible = False
        End If
    End Sub
    Protected Sub btnShowGPA(sender As Object, e As EventArgs) Handles drpGPA.SelectedIndexChanged
        btnShowGPA()
    End Sub
End Class