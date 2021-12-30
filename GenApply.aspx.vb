Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.IO
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports log4net

Partial Public Class GenApply
    Inherits System.Web.UI.Page

    Private cnStr As String = ConfigurationManager.ConnectionStrings("cnCareergform1").ConnectionString
    Private cn As SqlConnection = New SqlConnection(cnStr)
    Private cn1 As SqlConnection = New SqlConnection(cnStr)
    Private eduCnt As Integer
    Private Const ctrlCount As Integer = 15
    Private T_Key As String
    Private T2_Key As String
    Private RecruitID As String
    Private curRefNum As String
    Private RefCode As String


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        T_Key = Request.QueryString("Key")
        RecruitID = Request.QueryString("ID")
        T2_Key = Request.QueryString("Position")
        RefCode = Request.QueryString("RefCode")
        curRefNum = Session("P1AREF")
        Dim today As DateTime = DateTime.Today
        dtAvadate.Text = today.ToString("dd/MM/yyyy")

        If curRefNum Is Nothing Then
            curRefNum = ""
            Response.Redirect("GenMain.aspx")
        Else
        End If
        If T2_Key Is Nothing Then
            txtPosi.Text = ""
        Else
            txtPosi.Text = T2_Key
        End If
        If Not IsPostBack Then
            Bindreferral()
            Bindsalutation()
            BindPreferredFunction()
            BindDistrict()
            BindTitle()
            BindEducation(ctrl_dlist_EDU)
            'btnShowGPA()
            BindSchool(ctrl_dlist_SCH)
            'BindGrade(ctrl_dlist_RES)
            BindAvadt()
            'remarks.Attributes.Add("maxlength", "300")
            'remarks.Attributes.Add("onkeyup", "return ismaxlength(this)")
            eduCnt = 1
        Else
            RecreateControls()
        End If

        SetDListVisibility()
    End Sub

    Private Sub BindAvadt()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cm As New SqlCommand

        Try

            cn.Open()

            cm = New SqlCommand("select * from tblAvaDate order by id", cn)
            da = New SqlDataAdapter(cm)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                DrAvaDate.DataSource = dt
                DrAvaDate.DataTextField = "Description"
                DrAvaDate.DataValueField = "code"
                DrAvaDate.DataBind()
            End If

            DrAvaDate.Items.Insert(0, New ListItem("-- Please Select --", ""))
            DrAvaDate.SelectedIndex = 0

        Catch
            'MsgBox("Fetch Performance Functions error")
        Finally
            cn.Close()
        End Try
    End Sub

    'Private Sub btnShowGPA()
    '    If (drpGPA.SelectedItem.Value = "G1") Then
    '        plGPA1.Visible = True
    '        plGPA2.Visible = False
    '    ElseIf (drpGPA.SelectedItem.Value = "G2") Then
    '        plGPA2.Visible = True
    '        plGPA1.Visible = False
    '    Else
    '        plGPA1.Visible = False
    '        plGPA2.Visible = False
    '    End If
    'End Sub
    Protected Sub Bindreferral()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cm As New SqlCommand

        Try

            cn.Open()

            cm = New SqlCommand("select * from tblReferral order by id", cn)
            da = New SqlDataAdapter(cm)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                referral_ds.DataSource = dt
                referral_ds.DataTextField = "Description"
                referral_ds.DataValueField = "code"
                referral_ds.DataBind()
            End If

            referral_ds.Items.Insert(0, New ListItem("-- Please Select --", ""))
            referral_ds.SelectedIndex = 0

        Catch
            'MsgBox("Fetch Performance Functions error")
        Finally
            cn.Close()
        End Try
    End Sub
    Protected Sub Bindsalutation()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim cm As New SqlCommand

        Try

            cn.Open()

            cm = New SqlCommand("select id,code,Description+' '+chi_Description as Description from tblSalutation order by id", cn)
            da = New SqlDataAdapter(cm)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                drpSalutation.DataSource = dt
                drpSalutation.DataTextField = "Description"
                drpSalutation.DataValueField = "code"
                drpSalutation.DataBind()
            End If

            drpSalutation.Items.Insert(0, New ListItem("-- Please Select --", ""))
            drpSalutation.SelectedIndex = 0

        Catch
            'MsgBox("Fetch Performance Functions error")
        Finally
            cn.Close()
        End Try
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

            'If dt.Rows.Count > 0 Then
            '    PosApplied.DataSource = dt
            '    PosApplied.DataTextField = "Description"
            '    PosApplied.DataValueField = "func"
            '    PosApplied.DataBind()
            'End If

            'PosApplied.Items.Insert(0, New ListItem("-- Please Select --", ""))
            'PosApplied.SelectedIndex = 0

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

            cm = New SqlCommand("select * from school where school<>'OTH' order by description", cn)
            da = New SqlDataAdapter(cm)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                school.DataSource = dt
                school.DataTextField = "description"
                school.DataValueField = "school"
                school.DataBind()
            End If

            school.Items.Insert(0, New ListItem("-- Please Select --", ""))
            school.Items.Insert(dt.Rows.Count + 1, New ListItem("Other 其他 (Please Specify 請註明)", "OTH"))
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
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim oTrans As SqlTransaction
        Dim title As String
        Dim seqNo As String = ""
        Dim refNum As String = ""
        cn.Open()
        oTrans = cn.BeginTransaction()

        cm = New SqlCommand()
        cm2 = New SqlCommand()

        cm.Connection = cn
        cm2.Connection = cn

        cm.Transaction = oTrans
        cm2.Transaction = oTrans

        Dim logger As ILog = Nothing
        logger = LogManager.GetLogger("General Apply Form1")
        ''''' (1) Get and Update Seq No. - Begin
        logger.Info("Start Save......")
        Try
            cm.CommandText = "SELECT * FROM tblSequence where PosCode = @pos AND ApplyDate = convert(char(8),getdate(),112)"
            cm.CommandType = CommandType.Text
            cm.Parameters.Add("@pos", SqlDbType.NVarChar).Value = T2_Key

            dr = cm.ExecuteReader
            If dr.Read() Then
                seqNo = dr("seqNum").ToString().PadLeft(3, "0")
            Else
                seqNo = "001"
            End If
            dr.Close()
            cm = Nothing

            cm2.CommandText = "sp_updateSeqByDate"
            cm2.CommandType = CommandType.StoredProcedure
            cm2.Parameters.AddWithValue("@pos", T2_Key)
            cm2.ExecuteNonQuery()
            refNum = RefCode & "-" & DateTime.Now.ToString("yyyyMMdd") & "-" & seqNo

            ''''' (1) Get and Update Seq No. - End
            logger.Info("Start Save file to path......")
            ''''' (2) Upload File - Begin
            Dim filepath As String = ConfigurationManager.AppSettings("UploadToPathgform1")
            logger.Info("The path is " + filepath)
            Dim f1 As String = refNum & "_" & DateTime.Now.ToString("MMddHHmmss") & "_P1001" & fUpload1.FileName.Substring(fUpload1.FileName.LastIndexOf("."))
            logger.Info("The file name is " + f1)
            fUpload1.SaveAs(filepath & f1)
            logger.Info("successful save file“)
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

            cn1.Open()
            cm = New SqlCommand("select id from tblReferral where code='" + referral_ds.SelectedItem.Value + "'", cn1)
            dr = cm.ExecuteReader()
            Dim refid As Integer
            If dr.HasRows Then
                While (dr.Read)
                    refid = dr.GetInt32(0)
                End While
            End If
            dr.Close()
            cn1.Close()
            cn1.Open()
            cm = New SqlCommand("select id,description from tblSalutation where code='" + drpSalutation.SelectedItem.Value + "'", cn1)
            dr = cm.ExecuteReader()
            Dim saluID As Integer
            title = ""
            If dr.HasRows Then
                While (dr.Read)
                    saluID = dr.GetInt32(0)
                    title = dr.GetString(1)
                End While
            End If
            dr.Close()
            cn1.Close()
            Dim adddistID As Integer
            cn1.Open()
            cm = New SqlCommand("select id from district where district='" + addr_ds.SelectedItem.Value + "'", cn1)
            dr = cm.ExecuteReader()
            If dr.HasRows Then
                While (dr.Read)
                    adddistID = dr.GetInt32(0)
                End While
            End If
            dr.Close()
            cn1.Close()
            Dim edulvlID As Integer
            cn1.Open()
            cm = New SqlCommand("select id from education where education='" + ctrl_dlist_EDU.SelectedItem.Value + "'", cn1)
            dr = cm.ExecuteReader()
            If dr.HasRows Then
                While (dr.Read)
                    edulvlID = dr.GetInt32(0)
                End While
            End If
            dr.Close()
            cn1.Close()
            Dim schoolID As Integer
            cn1.Open()
            cm = New SqlCommand("select id from school where school='" + ctrl_dlist_SCH.SelectedItem.Value + "'", cn1)
            dr = cm.ExecuteReader()
            If dr.HasRows Then
                While (dr.Read)
                    schoolID = dr.GetInt32(0)
                End While
            End If
            dr.Close()
            cn1.Close()
            logger.Info("generate SQL")
            ''''' (3) Insert header data - Begin
            cm2.CommandText = "Insert into Application_Form1(PositionID,RefNum,ApplyPosition,AppliedDate,ModifiedDate,ReferralID,StaffName,
	StaffPosition,KnowChannel,SalutationID,Eng_Surname,Eng_Othername,AliasName,Chi_Name,IDDOCOPT,IDDocNo,
	RequiredWKVISA,Email,Phone,Addr_District,EduLvl,EduLvlName,SchoolID,SchoolName,ProgramName,YearAttained,WorkEXP,
	ExpectedSalry,AvailableDateOpt,AvailableDateOth,LatestEmployer,LatestPosition,LatestSalary,FilePath,
	FileName1,FileName2,FileName3,FileName4,FileName5,[Status],PosCompany_Code,
	isActive,Token,ApplicantType) values(@ID,@Refno,@Pos,@appdate,@mod,@refid,@staffname,@staffpos,@knowchanel,
	@saluID,@engname,@engother,@alianame,@chiname,@iddocopt,@iddocno,@reqwkvisa,@email,@phone,@adddist,@edulvl,@edulvlname,
	@schoolid,@schoolname,@programname,@yearatt,@Workexp,@expectsal,@avaopt,@avadt,@latestemp,@lastPos,@lastSal,
	@filpath,@filename1,@filename2,@filename3,@filename4,@filename5,@status,@compcode,1,@token,'G')"
            cm2.CommandType = CommandType.Text
            cm2.Parameters.Clear()
            logger.Info("@ID")
            cm2.Parameters.Add("@ID", SqlDbType.Int).Value = Convert.ToInt32(RecruitID)
            logger.Info("@Refno" & refNum)
            cm2.Parameters.Add("@Refno", SqlDbType.NVarChar).Value = refNum
            logger.Info("@Pos" & T2_Key)
            cm2.Parameters.Add("@Pos", SqlDbType.NVarChar).Value = T2_Key
            logger.Info("@appdate" & DateTime.Now.ToString())
            cm2.Parameters.Add("@appdate", SqlDbType.DateTime).Value = DateTime.Now
            logger.Info("@mod" & DateTime.Now.ToString())
            cm2.Parameters.Add("@mod", SqlDbType.DateTime).Value = DateTime.Now
            logger.Info("@refid" & refNum)
            cm2.Parameters.Add("@refid", SqlDbType.Int).Value = refid
            If (referral_ds.SelectedItem.Value = "ref5") Then
                logger.Info("@staffname" & Request.Form("staffname"))
                cm2.Parameters.Add("@staffname", SqlDbType.NVarChar).Value = Request.Form("staffname")
                logger.Info("@staffpos" & IIf(Request.Form("staffPosi") Is Nothing, "", Request.Form("staffPosi")))
                cm2.Parameters.Add("@staffpos", SqlDbType.NVarChar).Value = IIf(Request.Form("staffPosi") Is Nothing, "", Request.Form("staffPosi"))
                logger.Info("@knowchanel" & "")
                cm2.Parameters.Add("@knowchanel", SqlDbType.NVarChar).Value = ""
            ElseIf (referral_ds.SelectedItem.Value = "ref6") Then
                logger.Info("@knowchanel" & "")
                cm2.Parameters.Add("@staffname", SqlDbType.NVarChar).Value = ""
                logger.Info("@knowchanel" & "")
                cm2.Parameters.Add("@staffpos", SqlDbType.NVarChar).Value = ""
                logger.Info("@knowchanel" & "")
                cm2.Parameters.Add("@knowchanel", SqlDbType.NVarChar).Value = Request.Form("knowchannel")
            Else
                logger.Info("@knowchanel" & "")
                cm2.Parameters.Add("@staffname", SqlDbType.NVarChar).Value = ""
                logger.Info("@knowchanel" & "")
                cm2.Parameters.Add("@staffpos", SqlDbType.NVarChar).Value = ""
                logger.Info("@knowchanel" & "")
                cm2.Parameters.Add("@knowchanel", SqlDbType.NVarChar).Value = ""
            End If
            logger.Info("@saluID" & "")
            cm2.Parameters.Add("@saluID", SqlDbType.Int).Value = saluID
            logger.Info("@engname" & Request.Form("EngSurName"))
            cm2.Parameters.Add("@engname", SqlDbType.NVarChar).Value = Request.Form("EngSurName")
            logger.Info("@engother" & Request.Form("EngName"))
            cm2.Parameters.Add("@engother", SqlDbType.NVarChar).Value = Request.Form("EngName")
            logger.Info("@alianame" & Request.Form("Alias"))
            cm2.Parameters.Add("@alianame", SqlDbType.NVarChar).Value = Request.Form("Alias")
            logger.Info("@chiname" & Request.Form("ChnName"))
            cm2.Parameters.Add("@chiname", SqlDbType.NVarChar).Value = Request.Form("ChnName")
            If (rdIDcard1.Checked) Then
                logger.Info("@iddocopt" & "D1")
                cm2.Parameters.Add("@iddocopt", SqlDbType.NVarChar).Value = "D1"
                logger.Info("@iddocno" & Request.Form("hkid") + "(" + Request.Form("lastDig") + ")")
                cm2.Parameters.Add("@iddocno", SqlDbType.NVarChar).Value = Request.Form("hkid") + "(" + Request.Form("lastDig") + ")"
            ElseIf (rdIDcard2.Checked) Then
                logger.Info("@iddocopt" & "D2")
                cm2.Parameters.Add("@iddocopt", SqlDbType.NVarChar).Value = "D2"
                logger.Info("@iddocno" & Request.Form("passport"))
                cm2.Parameters.Add("@iddocno", SqlDbType.NVarChar).Value = Request.Form("passport")
            End If
            If (radY.Checked) Then
                logger.Info("@reqwkvisa" & "Y")
                cm2.Parameters.Add("@reqwkvisa", SqlDbType.NVarChar).Value = "Y"
            ElseIf (radN.Checked) Then
                logger.Info("@reqwkvisa" & "N")
                cm2.Parameters.Add("@reqwkvisa", SqlDbType.NVarChar).Value = "N"
            End If
            logger.Info("@email" & Request.Form("email"))
            cm2.Parameters.Add("@email", SqlDbType.NVarChar).Value = Request.Form("email")
            logger.Info("@phone" & Request.Form("txtArea") & Request.Form("phone"))
            cm2.Parameters.Add("@phone", SqlDbType.NVarChar).Value = IIf(Request.Form("txtArea") Is Nothing, "+852" & Request.Form("phone"), Request.Form("txtArea") & Request.Form("phone"))
            logger.Info("@adddist" & "")
            cm2.Parameters.Add("@adddist", SqlDbType.Int).Value = adddistID
            logger.Info("@edulvl" & "")
            cm2.Parameters.Add("@edulvl", SqlDbType.Int).Value = edulvlID

            If (ctrl_dlist_EDU.SelectedItem.Value = "OTH") Then
                logger.Info("@edulvlname" & Request.Form("txtEDU"))
                cm2.Parameters.Add("@edulvlname", SqlDbType.NVarChar).Value = Request.Form("txtEDU")
            Else
                logger.Info("@edulvlname" & "")
                cm2.Parameters.Add("@edulvlname", SqlDbType.NVarChar).Value = ""
            End If
            logger.Info("@schoolid" & "")
            cm2.Parameters.Add("@schoolid", SqlDbType.Int).Value = schoolID
            If (ctrl_dlist_SCH.SelectedItem.Value = "OTH") Then
                logger.Info("@schoolname" & Request.Form("Txt_dlist_SCH"))
                cm2.Parameters.Add("@schoolname", SqlDbType.NVarChar).Value = Request.Form("Txt_dlist_SCH")
            Else
                logger.Info("@schoolname" & "")
                cm2.Parameters.Add("@schoolname", SqlDbType.NVarChar).Value = ""
            End If
            logger.Info("@programname" & Request.Form("txt_subject"))
            cm2.Parameters.Add("@programname", SqlDbType.NVarChar).Value = Request.Form("txt_subject")
            logger.Info("@yearatt" & Request.Form("ctrl_txt_GRM") + "/" + Request.Form("ctrl_txt_GRY"))
            cm2.Parameters.Add("@yearatt", SqlDbType.NVarChar).Value = Request.Form("ctrl_txt_GRM") + "/" + Request.Form("ctrl_txt_GRY")
            logger.Info("@knowchanel" & Request.Form("ExpSal"))
            cm2.Parameters.Add("@Workexp", SqlDbType.Decimal).Value = CDec(Val(Request.Form("WorkExp")))
            logger.Info("@expectsal" & "")
            cm2.Parameters.Add("@expectsal", SqlDbType.Int).Value = CInt(Request.Form("ExpSal"))
            logger.Info("@knowchanel" & "")
            cm2.Parameters.Add("@avaopt", SqlDbType.NVarChar).Value = DrAvaDate.SelectedItem.Value
            logger.Info("@avadt" & Request.Form("dtAvadate"))
            cm2.Parameters.Add("@avadt", SqlDbType.NVarChar).Value = IIf(Request.Form("dtAvadate") Is Nothing, "", Request.Form("dtAvadate"))
            logger.Info("@latestemp" & Request.Form("CurCompany"))
            cm2.Parameters.Add("@latestemp", SqlDbType.NVarChar).Value = Request.Form("CurCompany")
            logger.Info("@lastPos" & Request.Form("CurPosition"))
            cm2.Parameters.Add("@lastPos", SqlDbType.NVarChar).Value = Request.Form("CurPosition")
            logger.Info("@lastSal" & Request.Form("CurSAL"))
            cm2.Parameters.Add("@lastSal", SqlDbType.Int).Value = CInt(IIf(Request.Form("CurSAL") Is Nothing Or Request.Form("CurSAL") = "", "0", Request.Form("CurSAL")))
            logger.Info("@filpath" & filepath)
            cm2.Parameters.Add("@filpath", SqlDbType.NVarChar).Value = filepath
            logger.Info("@filename1" & f1)
            cm2.Parameters.Add("@filename1", SqlDbType.NVarChar).Value = f1
            logger.Info("@filename2" & f2)
            cm2.Parameters.Add("@filename2", SqlDbType.NVarChar).Value = f2
            logger.Info("@filename3" & f3)
            cm2.Parameters.Add("@filename3", SqlDbType.NVarChar).Value = f3
            logger.Info("@filename4" & f4)
            cm2.Parameters.Add("@filename4", SqlDbType.NVarChar).Value = f4
            logger.Info("@filename5" & f5)
            cm2.Parameters.Add("@filename5", SqlDbType.NVarChar).Value = f5
            logger.Info("@status" & "A")
            cm2.Parameters.Add("@status", SqlDbType.NVarChar).Value = "A"
            logger.Info("@compcode" & "PYM")
            cm2.Parameters.Add("@compcode", SqlDbType.NVarChar).Value = "PYM"
            logger.Info("@token" & T_Key)
            cm2.Parameters.Add("@token", SqlDbType.NVarChar).Value = T_Key
            cm2.ExecuteNonQuery()
            cm2 = Nothing
            ''''' (4) Insert education data - End
            oTrans.Commit()


            ''''' (5) Send Mail & Redirect to acknowledge page - Begin
            SendEmail(refNum, Request.Form("EngSurName"), T2_Key, title)
            Session("REFNO") = refNum
            Response.Redirect("acknowledge.aspx", False)
            ''''' (5) Send Mail & Redirect to acknowledge page - End
            Exit Sub

        Catch ex As Exception
            logger.Error(ex.Message)
            MessageBox("Your application could not be submitted. Please try again later.")
            oTrans.Rollback()
        Finally
            logger.Info("End Save......")
            cn.Close()
            oTrans.Dispose()
        End Try

    End Sub

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

    Protected Sub SendEmail(ByVal refNo As String, ByVal surName As String, ByVal pos As String, ByVal title As String)
        Dim MailBody As String
        Dim Mail As New MailMessage
        Dim logger As ILog = Nothing
        logger = LogManager.GetLogger("General Apply Form1")
        ''''' (1) Get and Update Seq No. - Begin
        logger.Info("Start Generate Mail......")
        ' Old Template
        'MailBody = "<p style='font-family: Arial, Helvetica, sans-serif;'>Dear " & EngOtherName.Text & ",<br /><br />Thank you for your registration. We will contact you soon.<br /><br />Best Regards,<br />Paul Y. Engineering Group Limited.</p>"

        ' New Template (2018-09-20)
        MailBody = "<p style='font-family: Arial; font-size: 11pt;'>Dear [title] [surname],</p>" &
            "<p style='font-family: Arial; font-size: 11pt;'> Thank you for your application. The reference number of your application is <b>[ref]</b>." &
            "<br />多謝閣下的申請。閣下的申請編號為 <b>[ref]</b>.</p>" &
            "<p style='font-family: Arial; font-size: 11pt;'>We are now processing your application. We may contact you by phone or email later.<br/>" &
            "我們現在正處理閣下的申請，稍後可能會以電話或電郵方式聯絡閣下。</p>" &
            "<p style='font-family: Arial; font-size: 11pt;'>Best regards,<br/>Human Resources Department" &
            "<table><td><br /><img src='[img]' width='40px' height='40px'/></td>" &
            "<td><span style='font-family: Arial; font-size: 8pt;color:#808080'><br /><b>Paul Y. Engineering Group</b></span>" &
            "<br /><span style='font-family: Arial; font-size: 8pt;color:#808080'>11/F, Paul Y. Centre, 51 Hung To Road, Kwun Tong, Kowloon, Hong Kong<br />" &
            "<span style='font-family:Arial;font-size:8.0pt;color:#00acea;align-items:center;'><a href='http://www.pyengineering.com' style='color:#00acea'><span style='font-family: Arial;font-size:8.0pt;color:#00acea'><b>www.pyengineering.com</b></span></a> | <a href='https://www.linkedin.com/authwall?trk=bf&trkInfo=AQEC7JeuYYjR2QAAAX3g91-Auyu_hVMuSbMf-V_edxn8KAsFbs2kdabzV9MJAcOMsnKrXkDYgVEhMusrdTG-ZryH__DPj3FZPd9TUh-2PSCZAPGXQeMwdLeroNl93pcTymjZCXo=&originalReferer=&sessionRedirect=https%3A%2F%2Fwww.linkedin.com%2Fcompany%2Fpaul-y-engineering-group'>" &
            "<img src='[in_icon]' style='width:8px;height:8px'/></a></p></td></table>" &
            "<br /><br /><div style='font-family: Arial, sans-serif;font-size:6.5pt;color:#A9A9A9'><b><u>Disclaimer</u></b></div>" &
        "<div style='text-justify: inter-character;text-align-last: justify;font-family:Arial, sans-serif;font-size:5.5pt;color:#A9A9A9;width:500px'>" &
        "<i>This email (and any attachments) is confidential and subject to copyright. It may be subject to legal or other professional privilege. It is intended for use<br />" &
        "by the addressee(s) only and if you have received it in error, you must not use, copy, forward, disseminate or take any action in reliance on it or the<br />" &
        "information in it but should notify the sender immediately by return email and delete it from your system. Any personal data in this email must be handled<br /></div>" &
        "<div style='font-family: Arial, sans - serif;font-size: 5.5pt;color:#A9A9A9'>in accordance with applicable privacy laws.</i></div>" &
        "<p ><span style='font-size:6.5pt;color:#008000'>Please consider the environment before printing this e-mail</span></p>"
        MailBody = Replace(MailBody, "[ref]", refNo)
        MailBody = Replace(MailBody, "[title]", title)
        MailBody = Replace(MailBody, "[surname]", surName.ToUpper())
        MailBody = Replace(MailBody, "[img]", "cid:pyelogo")
        MailBody = Replace(MailBody, "[in_icon]", "cid:linkedIcon")


        Mail.Subject = "Job Application - " & pos & " (Ref No. " & refNo & ")"
        Mail.From = New MailAddress(ConfigurationManager.AppSettings("MailFromggform1"))
        Mail.To.Add(New MailAddress(email.Text))

        Mail.IsBodyHtml = True
        Mail.BodyEncoding = Encoding.GetEncoding("utf-8")
        Mail.Body = MailBody

        Dim smtpClient As New SmtpClient()
        smtpClient.Host = ConfigurationManager.AppSettings("smtpServergform1")
        smtpClient.Port = ConfigurationManager.AppSettings("smtpPortgform1")
        Dim altView As AlternateView = AlternateView.CreateAlternateViewFromString(MailBody, Nothing, "text/html")
        Dim pyeLogo As LinkedResource = New LinkedResource(AppDomain.CurrentDomain.BaseDirectory & "Images\pye_logo2.jpg", "image/jpeg")
        pyeLogo.ContentId = "pyelogo"
        altView.LinkedResources.Add(pyeLogo)
        Mail.AlternateViews.Add(altView)

        Dim linkedIcon As LinkedResource = New LinkedResource(AppDomain.CurrentDomain.BaseDirectory & "Images\in.png", "image/png")
        linkedIcon.ContentId = "linkedIcon"
        altView.LinkedResources.Add(linkedIcon)
        Mail.AlternateViews.Add(altView)

        Try
            logger.Info("Start Send Mail......")
            smtpClient.Send(Mail)
        Catch ex As Exception
            logger.Error(ex.Message)
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

    Protected Sub btnSelectreferrel(sender As Object, e As EventArgs) Handles referral_ds.SelectedIndexChanged
        If (referral_ds.SelectedItem.Value = "ref5") Then
            staffref1.Visible = True
            staffref2.Visible = False
        ElseIf (referral_ds.SelectedItem.Value = "ref6") Then
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
        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "", "hidecald()", True)
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

    Protected Sub DateChange(sender As Object, e As EventArgs) Handles cald1.SelectionChanged
        Dim seldate = cald1.SelectedDate
        dtAvadate.Text = seldate.ToString("dd/MM/yyyy")

        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "", "showcald()", True)
    End Sub

    Protected Sub btnShowSchool(sender As Object, e As EventArgs) Handles ctrl_dlist_SCH.SelectedIndexChanged
        If (ctrl_dlist_SCH.SelectedItem.Value = "OTH") Then
            pnlSchool.Visible = True
        Else
            pnlSchool.Visible = False
        End If
    End Sub

    'Protected Sub hkid_TextChanged(sender As Object, e As EventArgs) Handles hkid.TextChanged
    '    hkidbk.Text = hkid.Text & "(" & lastDig.Text & ")"
    'End Sub

    'Protected Sub lastDig_TextChanged(sender As Object, e As EventArgs) Handles lastDig.TextChanged
    '    hkidbk.Text = hkid.Text & "(" & lastDig.Text & ")"
    'End Sub

    'Protected Sub btnShowCald(sender As Object, e As EventArgs) Handles btnCalender.Click
    '    If (cald1.Visible) Then
    '        cald1.Visible = False
    '    Else
    '        cald1.Visible = True
    '    End If
    'End Sub
End Class