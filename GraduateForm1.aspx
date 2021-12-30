<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="GraduateForm1.aspx.vb" Inherits="Career.GraduateForm1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >

<head runat="server">
    <title>Personal Info</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <meta http-equiv="X-UA-Compatible" content="IE=11"/> 
    
    
    
    <link href="lib/boostrap/bootstrap.css?timestamp=201809201509" rel="stylesheet" type="text/css" /> 
    <link rel="stylesheet" href="include/style.css?timestamp=201910251043" type="text/css" />
    <link rel="shortcut icon" href="favicon.ico" type="image/x-icon"/>
    
    <script src="lib/jquery/jquery-3.3.1.js" type="text/javascript"></script>
    <script src="lib/boostrap/bootstrap.js" type="text/javascript"></script>
    
    <script src="lib/jquery.validate/jquery.validate.min.js" type="text/javascript"></script>
    <script src="lib/jquery.validate/additional-methods.min.js" type="text/javascript"></script>

    <script src="include/main.js?timestamp=201809201509" type="text/javascript"></script>
    <script src="include/app.min.js?timestamp=201809261529" type="text/javascript"></script>
<!--Testing-->

</head>

<body>
    <noscript>Sorry, your browser does not support JavaScript!</noscript>
    <form id="myform" runat="server" novalidate="novalidate">
    <asp:ScriptManager ID="scrptManager" runat="server">
    </asp:ScriptManager>
    <div id="pos_container">
        <!-- #include file="include/header.inc" -->
        <br />
        <div id="pos_front_left" />
        <br />
        <div class="form-group row">
            <div class="col-sm-6">
	         <span class="H4">Position Applied<br />申請職位</span>
             
            </div>
            <div class="col-sm-6">
              <asp:DropDownList ID="pos_ds" runat="server" CssClass="form-control" AutoPostBack="true" style="width:90%"/>
            </div>
	    </div>
        
       </div> 

        <hr />

      <asp:UpdatePanel ID="UPanel1" runat="server">
       <ContentTemplate>
        <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory ">*</span>&nbsp;Know Vacancy Through<br />&nbsp;&nbsp; 從何得悉空缺
            </div>
            <div class="col-sm-62">
		            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="btnSelectreferrel">
                        <asp:ListItem Text="---Select---" Value="ref0" />
                         <asp:ListItem Text="JobsDB" Value="ref1" />
                        <asp:ListItem Text="CTgoodjobs" Value="ref2" />
                        <asp:ListItem Text="Paul Y. Website保華網站" Value="ref3" />
                        <asp:ListItem Text="Labour Department勞工處" Value="ref4" />
                        <asp:ListItem Text="Paul Y. Staff Referral保華同事介紹" Value="ref5" />
                        <asp:ListItem Text="Other 其他(Please Specify請註明)" Value="ref6" />
                     </asp:DropDownList>
            </div>
         </div>
     
            <asp:Panel ID="staffref1" runat="server" Visible="false">
                <div class="form-group row">
                    <div class="col-sm-61">
                        <span class="compulsory">* </span>staff Name<br />&nbsp;&nbsp; 同事姓名&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </div>
                    <div class="col-sm-62">
                        <asp:TextBox ID="txtstaffname" runat="server" CssClass="input-boxM" MaxLength="50" style="width:80%"/>
                    </div>
                </div>
                <div class="form-group row">         
                     <div class="col-sm-61">
                        <span class="compulsory">&nbsp; </span>staff Position<br />&nbsp;&nbsp; 同事職位
                     </div>
                     <div class="col-sm-62">
                        <asp:TextBox ID="txtStaffPosi" runat="server" CssClass="input-boxM" MaxLength="50" style="width:80%"/>
                     </div>
                </div>    
            </asp:Panel>
            <asp:Panel ID="staffref2" runat="server" Visible="false">
                <div class="form-group row">
                    <div class="col-sm-61">
                        <span class="compulsory">* </span>Channel 得悉渠道&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </div>
                    <div class="col-sm-62">
                        <asp:TextBox ID="TextBox4" runat="server" CssClass="input-boxM" MaxLength="50" style="width:80%"/>
                    </div>
                </div>
            </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
         <ContentTemplate>
         <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory "></span>&nbsp;&nbsp;Salutation<br />&nbsp;&nbsp; 稱謂
            </div>
            <div class="col-sm-62">
		            <asp:DropDownList ID="drpSalutation" runat="server" CssClass="form-control" AutoPostBack="true">
                        <asp:ListItem Text="---Select---" Value="ref0" />
                        <asp:ListItem Text="Mr." Value="S1" />
                        <asp:ListItem Text="Ms." Value="S2" />
                        <asp:ListItem Text="Mrs." Value="S3" />
                        <asp:ListItem Text="Dr." Value="S4" />
                        <asp:ListItem Text="Prof." Value="S5" />
                        <asp:ListItem Text="Ir." Value="S6" />
                     </asp:DropDownList>
            </div>
         </div>
         </ContentTemplate>
        </asp:UpdatePanel>
       <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory">* </span>Family Name (printed on ID)<br />&nbsp;&nbsp; 英文姓氏
            </div>
            <div class="col-sm-62">
		           <asp:TextBox ID="EngName" runat="server" CssClass="input-boxM" MaxLength="50" style="width:50%" />
            </div>
       </div>
         <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory">* </span>Other Name (printed on ID)<br />&nbsp;&nbsp; 英文名字
            </div>
            <div class="col-sm-62">
		           <asp:TextBox ID="OtherName" runat="server" CssClass="input-boxM" MaxLength="50" style="width:80%" />
            </div>
       </div>
        <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory"></span>&nbsp;&nbsp;Alias<br />&nbsp;&nbsp;別名
            </div>
            <div class="col-sm-62">
		            <asp:TextBox ID="EngOtherName" runat="server" CssClass="input-boxM" MaxLength="50" style="width:80%"/>
            </div>
       </div>
       <div class="form-group row">
            <div class="col-sm-61">
                &nbsp;&nbsp;Chinese Name (printed on ID) <br />&nbsp;&nbsp;中文姓名 (與身份證上相同)
            </div>
            <div class="col-sm-62">
		            <asp:TextBox ID="ChnName" runat="server" CssClass="input-boxM" MaxLength="50" style="width:80%"/>
            </div>
       </div>    
      <asp:UpdatePanel ID="UpdatePanel2" runat="server">
       <ContentTemplate>
       <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory ">*</span>&nbsp;Identification Document<br />&nbsp;&nbsp; 身份證明文件
            </div>
            <div class="col-sm-62">
                <table>
                    <tr>
                        <td style="width:50%">
                            <asp:RadioButton ID="rdIDcard1" runat="server" Text="HKID 香港身份證" Checked="true" AutoPostBack="true" OnCheckedChanged="btnIDcard_click" GroupName="idcard"/>&nbsp;<asp:RadioButton ID="rdIDcard2" runat="server" Text="Passport護照" AutoPostBack="true" OnCheckedChanged="btnIDcard_click" GroupName="idcard"/> 
                        </td>
                        <td style="width:50%">
                            <asp:Panel ID="IDcard1" runat="server" Visible="true">Number 號碼 <asp:TextBox ID="hkid" runat="server" MaxLength="7" Width="100px"/>(<asp:TextBox ID="TextBox2" runat="server" MaxLength="2" Width="20px"/>)</asp:Panel>
                        
                            <asp:Panel ID="IDcard2" runat="server" Visible="false">Number 號碼 <asp:TextBox ID="passport" runat="server" MaxLength="25"/></asp:Panel>
                        </td>
                    </tr>
                </table>
            </div>
       </div>  
       <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory ">*</span>&nbsp;Required Visa to work in HK <br />&nbsp;&nbsp;需要簽證才能在香港工作？
            </div>
            <div class="col-sm-62">
                <asp:RadioButton ID="radY" runat="server" Text="Yes需要" GroupName="workvisa"/>  <asp:RadioButton ID="radN" runat="server" Text="No不需要" Checked="true" GroupName="workvisa"/>
            </div>
       </div>
      </ContentTemplate>
     </asp:UpdatePanel>
       <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory">*</span>&nbsp;Email<br />&nbsp;&nbsp; 電郵 
            </div>
            <div class="col-sm-62">
		            <asp:TextBox ID="email" runat="server" CssClass="input-boxM" MaxLength="50" Type="Email" style="width:250px" />
            </div>
       </div>
       <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory">*</span>&nbsp;Contact No.<br />&nbsp;&nbsp; 電話號碼
            </div>
            <div class="col-sm-62">
		            <asp:TextBox ID="phone" runat="server" CssClass="input-boxM" MaxLength="20" style="width:150px" />
            </div>
       </div>
       <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory">* </span>Living District<br />&nbsp;&nbsp; 居住地區</div>
           <div class="col-sm-62">
		        <asp:DropDownList ID="addr_ds" runat="server" CssClass="form-control" />
           </div>
       </div>
       <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory"> </span></div>
             <div class="col-sm-62">
		         <asp:TextBox ID="addr_subd" runat="server" CssClass="input-boxM" MaxLength="50" placeholder="*Other Country 其他國家" />
           </div>
       </div>
       <hr />

      <asp:UpdatePanel ID="UpdatePanel3" runat="server">
       <ContentTemplate>
       <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory ">* </span>Education Level<br />&nbsp;&nbsp; 教育程度
            </div>
            <div class="col-sm-62">
                <table style="width:100%; height: 22px;">
                    <tr >
                        <td style="width:45%">
                            <asp:DropDownList ID="ctrl_dlist_EDU" runat="server" CssClass="form-control educlass formdl" AutoPostBack="true" OnSelectedIndexChanged="btnShowEDU" width="100%"/>
                        </td>
                        <td  style="width:55%">
                              <asp:Panel ID="plEdu" runat="server" Visible="false">Education Level 教育程度：
		                               <asp:TextBox ID="txtEDU" runat="server" MaxLength="150" width="200px" />
                            </asp:Panel>
                        </td>
                     </tr>
                    </table>
            </div>          
       </div>
       </ContentTemplate>
      </asp:UpdatePanel>
       <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory">* </span>Name of Institute<br />&nbsp;&nbsp; 學校名稱
            </div>
            <div class="col-sm-62">
		           <asp:TextBox ID="Txt_dlist_SCH" runat="server" CssClass="input-boxM" MaxLength="250"   />
            </div>
       </div>
       <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory">* </span>Programme Name / Subject<br />&nbsp;&nbsp; 課程名稱 / 科目
            </div>
            <div class="col-sm-62">
		           <asp:TextBox ID="txt_subject" runat="server" CssClass="input-boxM" MaxLength="250"   />
            </div>
       </div>
        <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory ">* </span>(Expected) Year of Graduation<br />&nbsp;&nbsp; (預計)畢業年份
            </div>
            <div class="col-sm-62">
               <asp:TextBox ID="ctrl_txt_GRM" runat="server" cssclass="form-controlsx formtxm" width="30px" maxlength="2"  /> 
			        <asp:Label ID="ctrl_lbl_SLH1" runat="server" > / </asp:Label>			        
			        <asp:TextBox ID="ctrl_txt_GRY" runat="server" cssclass="form-controlsx formtxy"  width="40px"  maxlength="4"  />
            </div>          
       </div>
     <asp:UpdatePanel ID="uPanel2" runat="server">
       <ContentTemplate>
       <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory ">* </span>Result<br />&nbsp;&nbsp; 考獲成績
            </div>
            <div class="col-sm-62">
                <table style="width:100%; height: 22px;">
                    <tr >
                        <td style="width:45%">
                            <asp:DropDownList ID="drpGPA" runat="server" CssClass="form-control educlass formdl" AutopostBack="true" OnSelectedIndexChanged="btnShowGPA" width="100%">
                             <asp:ListItem Text="---Select---" Value="G0" />
                             <asp:ListItem Text="Cumulative GPA" Value="G1" />
                             <asp:ListItem Text="Grade" Value="G2" />
                             <asp:ListItem Text="DSE Graduate 中學畢業" Value="G3" />
                            </asp:DropDownList>
                        </td>
                        <td  style="width:55%">
                            
                              <asp:Panel ID="plGPA1" runat="server" Visible="false">CGPA: 
                                        <asp:TextBox ID="ctrl_txt_GRP" runat="server" cssclass="form-controlsx formtxn" width="60px" maxlength="50" />
		                                <asp:Label ID="ctrl_lbl_SLH2" runat="server" > / </asp:Label>			        
			                            <asp:TextBox ID="ctrl_txt_GRC" runat="server" cssclass="form-controlsx formtxn formG"  width="60px"  maxlength="50"   /> 
                              </asp:Panel>
                              <asp:Panel ID="plGPA2" runat="server" Visible="false">Grade: 
                                        <asp:TextBox ID="txtGRADE" runat="server" cssclass="form-controlsx formtx" width="45%" maxlength="50" /> 
                              </asp:Panel>
                             
                        </td>
                     </tr>
                    </table>
            </div>          
       </div>
       </ContentTemplate>
      </asp:UpdatePanel>
       <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory">* </span>Relevant Working Experience (year)<br />&nbsp;&nbsp; 相關工作經驗(年)
            </div>
            <div class="col-sm-62">
		           <asp:TextBox ID="WorkExp" runat="server" type="number" CssClass="input-boxM" MaxLength="2" style="width:50px"  />
            </div>
       </div>
       <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory">* </span>Expected Salary(Monthly)<br />&nbsp;&nbsp; 要求薪金(月薪)
            </div>
            <div class="col-sm-62">
		           <asp:TextBox ID="ExpSal" runat="server" type="number" CssClass="input-boxM" MaxLength="7" style="width:100px"  />
            </div>
       </div>
      <asp:UpdatePanel ID="UpdatePanel4" runat="server">
       <ContentTemplate>
        <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory ">* </span>Date Available<br />&nbsp;&nbsp; 可到職日期
            </div>
            <div class="col-sm-62">
                <table style="width:100%; height: 22px;">
                    <tr >
                        <td style="width:55%">
                            <asp:DropDownList ID="DrAvaDate" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="btnShowDate" width="100%">
                                <asp:ListItem Text="--Please Select--" Value="D0" />
                                <asp:ListItem Text="Immediate 立即" Value="D1" />
                                <asp:ListItem Text="1-week notice 一星期通知" Value="D2" />
                                <asp:ListItem Text="1-month notice 一個月通知" Value="D3" />
                                 <asp:ListItem Text="2-month notice 兩個月通知" Value="D4" />
                                <asp:ListItem Text="Other 其他(Please Specify 請註明)" Value="D5" />
                            </asp:DropDownList>
                        </td>
                        <td  style="width:45%">
                              <asp:Panel ID="pnlAvadate" runat="server" Visible="false">Date Available 可到職日期：
		                               <asp:TextBox ID="txtavadate" runat="server" placeholder="dd/MM/yyyy" MaxLength="10" type="date" width="100px" />
                                  <asp:RegularExpressionValidator runat="server" ControlToValidate="txtavadate" ValidationExpression="^(((0[1-9]|[12]\d|3[01])/(0[13578]|1[02])/((19|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)/(0[13456789]|1[012])/((19|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])/02/((19|[2-9]\d)\d{2}))|(29/02/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$"
    ErrorMessage="Invalid date format." ValidationGroup="Group1" />
                            </asp:Panel>
                        </td>
                        <td style="width:10%"></td>
                     </tr>
                    </table>
            </div>
            
       </div>
       </ContentTemplate>
     </asp:UpdatePanel>
       <div class="form-group row">
            <div class="col-sm-61">
               <span class="compulsory"> </span>&nbsp;&nbsp;Current/Latest Employer Company<br />&nbsp;&nbsp; 現職/最近僱主公司
            </div>
            <div class="col-sm-62">
		           <asp:TextBox ID="CurCompany" runat="server" CssClass="input-boxM" MaxLength="250"   />
            </div>
       </div>
       <div class="form-group row">
            <div class="col-sm-61">
               <span class="compulsory"> </span>&nbsp;&nbsp;Current/Latest Position<br />&nbsp;&nbsp; 現職/最近職位
            </div>
            <div class="col-sm-62">
		           <asp:TextBox ID="CurPosition" runat="server" CssClass="input-boxM" MaxLength="250"   />
            </div>
       </div>
        <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory"> </span>&nbsp;&nbsp;Current/Latest Salary (Monthly)<br />&nbsp;&nbsp; 現職/最近薪金(月薪)
            </div>
            <div class="col-sm-62">
		           <asp:TextBox ID="TextBox3" runat="server" type="number" CssClass="input-boxM" MaxLength="7" style="width:100px"   />
            </div>
       </div> 
        <hr />
        <div class="form-group row">
            <div class="col-sm-62" style="text-align:left">
              <div class="form-group row">
                    <div class="col-sm-61">
                        <span class="compulsory">*</span>&nbsp;CV<br />&nbsp;&nbsp; 履歷表 <br /> (PDF / Word File) </div>
                    <div class="col-sm-62">
		                    <asp:FileUpload  ID="fUpload1" runat="server" CssClass="" MaxLength="50" /> <br /> <br />
                    </div>
                    <hr />
                    <div class="col-sm-61">
                            <span class="compulsory"></span>&nbsp;Reference & Supporting Documents <br />工作及學歷證明文件<br /> (PDF / Word File) </div>
                        <div class="col-sm-62">
		                       
		                        <asp:FileUpload  ID="fUpload2" runat="server" CssClass="" MaxLength="50"  /> <br />
		                        <asp:FileUpload  ID="fUpload3" runat="server" CssClass="" MaxLength="50" /> <br />
		                        <asp:FileUpload  ID="fUpload4" runat="server" CssClass="" MaxLength="50" /> <br />
		                        <asp:FileUpload  ID="fUpload5" runat="server" CssClass="" MaxLength="50" /> 
                     </div>
               </div>   
                <div class="form-group row">
                    <div class="col-sm-12">
                        <u>每個上載檔案不得超過10MB Each file size must not exceed 10MB</u> </div></div><br />
                
                <br />
                </div>
       </div>
        <hr />
        <div class="form-group row" align="center">
            <table>
                <tr>
                    <td style="width:10%">

                    </td>
                    <td style="width:80%">
                        <div class="col-sm-12"  >
                <asp:CheckBox ID="chkCaT1" runat="server" CssClass="" /><b><span class="compulsory"></span>&nbsp;I fully understand and agree to the <asp:HyperLink ID="HyperLink4" href="#"
  onclick="window.open('PGDeclare.aspx'); return false;"
  ForeColor="#1226db" runat="server">Company’s Personal Information Collection Statement pertaining to Recruitment</asp:HyperLink> and I hereby give my consent to the Company for the lawful use of the data I provided herein.
<br />    &nbsp;&nbsp;&nbsp;&nbsp;本人完全明白及同意貴公司在招聘方面的收集個人資料聲明，並在此授權貴公司可以合法地使用本人現在提供之個人資料</b>&nbsp;&nbsp; </div>
            <div class="col-sm-12">
                <asp:CheckBox ID="chkCaT2" runat="server" CssClass="" /><b><span class="compulsory"></span>&nbsp;I declare the information provided is accurate and up-to-date.
<br />    &nbsp;&nbsp;&nbsp;&nbsp;本人特此聲明以上所有資料全屬真確。</b>&nbsp;&nbsp; </div>

                    </td>
                    <td style="width:10%">

                    </td>
                </tr>
            </table>
            
        </div>
            <br />
            <br />
       <div class="form-group row">
            <div class="col-sm-12" align="center">
               <asp:Button ID="btnSubmit" runat="server" Text="遞交 Submit" CssClass="" OnClientClick="" OnClick="SaveData" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="btnCancel" runat="server" Text="取消 Cancel" CssClass="" OnClientClick="javascript:window.close();" UseSubmitBehavior="false"  />                                     
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Panel ID="Panel1" RUNAT="server" style="height: 16px"></asp:Panel>
            </div>
        </div>	    
     <!--Testing Code-->
       
    </form>
    
</body>
</html>
