<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="GenApply.aspx.vb" Inherits="Career.GenApply" %>
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
    <script>
        hidecald();
        function hidecald() {
            var x = document.getElementById("myDIV");
            if (!!x)
            {
                x.style.display = "none";
            }
        }
        function showcald() {
            var x = document.getElementById("myDIV");
            if (x.style.display === "none") {
                x.style.display = "block";
            } else {
                x.style.display = "none";
            }
        }
    </script>
    
    <style type="text/css">
        .auto-style1 {
            width: 15%;
        }
    </style>
    
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
	    <span class="H4">Position Applied<br />&nbsp;&nbsp;申請職位 &nbsp;&nbsp; </span><asp:TextBox ID="txtPosi" runat="server" Enabled="False" style="width:80%" />    
       </div> 	
        <hr />
      <asp:UpdatePanel ID="UPanel1" runat="server">
       <ContentTemplate>
        <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory ">*</span>&nbsp;Know Vacancy Through<br />&nbsp;&nbsp; 從何得悉空缺
            </div>
            <div class="col-sm-62">
		            <asp:DropDownList ID="referral_ds" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="btnSelectreferrel" style="width:35%"/>              
            </div>
         </div>
     
            <asp:Panel ID="staffref1" runat="server" Visible="false">
                <div class="form-group row">
                    <div class="col-sm-61">
                        <span class="compulsory">* </span>Staff Name<br />&nbsp;&nbsp; 同事姓名&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </div>
                    <div class="col-sm-62">
                        <asp:TextBox ID="staffname" runat="server" CssClass="input-boxM" MaxLength="50" style="width:80%"/>
                    </div>
                </div>
                <div class="form-group row">         
                     <div class="col-sm-61">
                        <span class="compulsory">&nbsp; </span>Staff Position<br />&nbsp;&nbsp; 同事職位
                     </div>
                     <div class="col-sm-62">
                        <asp:TextBox ID="staffPosi" runat="server" CssClass="input-boxM" MaxLength="50" style="width:80%"/>
                     </div>
                </div>    
            </asp:Panel>
            <asp:Panel ID="staffref2" runat="server" Visible="false">
                <div class="form-group row">
                    <div class="col-sm-61">
                        <span class="compulsory">* </span>Channel 得悉渠道&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </div>
                    <div class="col-sm-62">
                        <asp:TextBox ID="knowchannel" runat="server" CssClass="input-boxM" MaxLength="50" style="width:80%"/>
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
		            <asp:DropDownList ID="drpSalutation" runat="server" CssClass="form-control" AutoPostBack="true" style="Width:20%"/>
                    
            </div>
         </div>
         </ContentTemplate>
        </asp:UpdatePanel>
       <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory">* </span>Family Name (printed on ID)<br />&nbsp;&nbsp; 英文姓氏 (與身份證上相同)
            </div>
            <div class="col-sm-62">
		           <asp:TextBox ID="EngSurName" runat="server" CssClass="input-boxM" MaxLength="50" style="width:50%" />
                   <asp:RegularExpressionValidator ID="Vald1" runat="server" ControlToValidate="EngSurName" ValidationExpression="^[A-Za-z\s]*$"
    ErrorMessage="Please enter English Characters Only 只可輸入英文字元" />
            </div>
       </div>
         <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory">* </span>Other Name (printed on ID)<br />&nbsp;&nbsp; 英文名字 (與身份證上相同)
            </div>
            <div class="col-sm-62">
		           <asp:TextBox ID="EngName" runat="server" CssClass="input-boxM" MaxLength="50" style="width:50%" />
                   <asp:RegularExpressionValidator ID="Vald2" runat="server" ControlToValidate="EngName" ValidationExpression="^[A-Za-z\s]*$"
    ErrorMessage="Please enter English Characters Only 只可輸入英文字元" />
            </div>
       </div>
        <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory"></span>&nbsp;&nbsp;Alias<br />&nbsp;&nbsp;別名
                
            </div>
            <div class="col-sm-62">
		            <asp:TextBox ID="Alias" runat="server" CssClass="input-boxM" MaxLength="50" style="width:50%"/>
                    <asp:RegularExpressionValidator ID="Vald3" runat="server" ControlToValidate="Alias" ValidationExpression="^[\u4e00-\u9fa5_a-zA-Z\s]*$"
    ErrorMessage="Only english and chinese here. 此處只可輸入英文和中文字" />
            </div>
       </div>
       <div class="form-group row">
            <div class="col-sm-61">
                &nbsp;&nbsp;Chinese Name (printed on ID) <br />&nbsp;&nbsp;中文姓名 (與身份證上相同)
            </div>
            <div class="col-sm-62">
		            <asp:TextBox ID="ChnName" runat="server" CssClass="input-boxM" MaxLength="50" style="width:50%"/>
                    <asp:RegularExpressionValidator ID="Vald4" runat="server" ControlToValidate="ChnName" ValidationExpression="^[\u4e00-\u9fa5\s]*$"
    ErrorMessage="Please enter Chinese Characters Only只可輸入中文字元" />
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
                        <td style="width:35%">
                            <asp:RadioButton ID="rdIDcard1" runat="server" Text="&nbsp;HKID 香港身份證" Checked="true" AutoPostBack="true" OnCheckedChanged="btnIDcard_click" GroupName="idcard"/>&nbsp;<asp:RadioButton ID="rdIDcard2" runat="server" Text="&nbsp;Passport 護照" AutoPostBack="true" OnCheckedChanged="btnIDcard_click" GroupName="idcard"/> 
                        </td>
                        <td style="width:65%">
                            <asp:Panel ID="IDcard1" runat="server" Visible="true">Number 號碼 <asp:TextBox ID="hkid" runat="server" MaxLength="7" Width="100px"/>(<asp:TextBox ID="lastDig" runat="server" MaxLength="1" Width="20px"/>)
                                <asp:RegularExpressionValidator ID="vald7" runat="server" ControlToValidate="hkid" ErrorMessage="Please enter a valid HKID No. 請輸入正確的香港身份證號碼" ValidationExpression="^[A-Z0-9]{7,}$" />
                                <asp:RegularExpressionValidator ID="vald71" runat="server" ControlToValidate="lastDig" ErrorMessage="Please enter a valid HKID No. 請輸入正確的香港身份證號碼" ValidationExpression="^[A-Z0-9]*$" />
                            </asp:Panel>
                            <asp:Panel ID="IDcard2" runat="server" Visible="false">Number 號碼 <asp:TextBox ID="passport" runat="server" MaxLength="25" Width="250px"/>
                                <asp:RegularExpressionValidator ID="Vald9" runat="server" ControlToValidate="passport" ErrorMessage="Please enter Uppercase Characters and Numbers Only 只可輸入大寫英文字元及數字" ValidationExpression="^[A-Z0-9]*$" />
                            </asp:Panel>
                        </td>
                    </tr>
                </table>
            </div>
       </div>  
       <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory ">*</span>&nbsp;Required Visa to work in HK ? <br />&nbsp;&nbsp;需要簽證才能在香港工作？
            </div>
            <div class="col-sm-62">
                <asp:RadioButton ID="radY" runat="server" Text="&nbsp;Yes&nbsp;需要" GroupName="workvisa"/>  <asp:RadioButton ID="radN" runat="server" Text="&nbsp;No&nbsp;不需要" Checked="true" GroupName="workvisa"/>
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
                    <%--<asp:RegularExpressionValidator ID="Vald8" runat="server" ControlToValidate="Email" ValidationExpression="[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$"
    ErrorMessage="Please enter a valid Email Address 請填寫正確的電郵地址" />--%>
            </div>
       </div>
       <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory">*</span>&nbsp;Contact No.<br />&nbsp;&nbsp; 電話號碼
            </div>
            <div class="col-sm-62">
		            <asp:TextBox ID="txtArea" runat="server" CssClass="input-boxM" Placeholder="+852" MaxLength="8" style="width:50px" />-<asp:TextBox ID="phone" runat="server" CssClass="input-boxM" MaxLength="20" style="width:150px" />
                <asp:RegularExpressionValidator ID="Phonevald1" runat="server" ControlToValidate="txtArea" ValidationExpression="[0-9+]*$"
    ErrorMessage="Please enter a valid contact number 請輸入正確的電話號碼" />    
                <asp:RegularExpressionValidator ID="phonevald2" runat="server" ControlToValidate="phone" ValidationExpression="[0-9]*$"
    ErrorMessage="Please enter a valid contact number 請輸入正確的電話號碼" />
            </div>
       </div>
       <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory"> </span>&nbsp;&nbsp;&nbsp;Living District<br />&nbsp;&nbsp; 居住地區</div>
           
            <div class="col-sm-62">
		        <asp:DropDownList ID="addr_ds" runat="server" CssClass="form-control" />
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
         <asp:UpdatePanel ID="UpdatePanel5" runat="server">
        <ContentTemplate>
       <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory">* </span>Name of Institute<br />&nbsp;&nbsp; 院校名稱
            </div>
            <div class="col-sm-62">
                   <asp:DropDownList ID="ctrl_dlist_SCH" runat="server" CssClass="form-control schclass formdl"  AutoPostBack="true" OnSelectedIndexChanged="btnShowSchool"  /> 
            </div>
       </div>
        <asp:Panel ID="pnlSchool" runat="server" Visible="false">
                <div class="form-group row">
                    <div class="col-sm-61">
                        <span class="compulsory">* </span>Name of Institute 學校名稱&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </div>
                    <div class="col-sm-62">
                        <asp:TextBox ID="Txt_dlist_SCH" runat="server" CssClass="input-boxM" MaxLength="250"   />
                        <asp:RegularExpressionValidator ID="valid9" runat="server" ControlToValidate="Txt_dlist_SCH" ValidationExpression="^[\u4e00-\u9fa5_a-zA-Z\s]*$"
    ErrorMessage="Please enter English and Chinese Characters Only 只可輸入中文及英文字元" />
                    </div>
                </div>
            </asp:Panel>
        </ContentTemplate>
      </asp:UpdatePanel>
       <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory">* </span>Programme Name / Subject<br />&nbsp;&nbsp; 課程名稱 / 科目
            </div>
            <div class="col-sm-62">
		           <asp:TextBox ID="txt_subject" runat="server" CssClass="input-boxM" MaxLength="250"   />
                   <asp:RegularExpressionValidator ID="valid10" runat="server" ControlToValidate="txt_subject" ValidationExpression="^[\u4e00-\u9fa5_a-zA-Z\s]*$"
    ErrorMessage="Please enter English and Chinese Characters Only 只可輸入中文及英文字元" />
            </div>
       </div>
        <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory ">* </span>Year Attained (MM/YYYY)<br />&nbsp;&nbsp; 考獲年份
            </div>
            <div class="col-sm-62">
                    <asp:TextBox ID="ctrl_txt_GRM" runat="server" cssclass="form-controlsx formtxm" width="30px" maxlength="2"  /> 
			        <asp:Label ID="ctrl_lbl_SLH1" runat="server" > / </asp:Label>			        
			        <asp:TextBox ID="ctrl_txt_GRY" runat="server" cssclass="form-controlsx formtxy"  width="40px"  maxlength="4"  />
                    <asp:RegularExpressionValidator ID="valid11" runat="server" ControlToValidate="ctrl_txt_GRM" ValidationExpression="^[0-9]*$"
    ErrorMessage="Please enter in format (MM/YYYY) 請按格式(MM/YYYY)輸入" />
                    <asp:RegularExpressionValidator ID="valid12" runat="server" ControlToValidate="ctrl_txt_GRY" ValidationExpression="^[0-9]*$"
    ErrorMessage="Please enter in format (MM/YYYY) 請按格式(MM/YYYY)輸入" />
            </div>          
       </div>
    
       <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory">* </span>Relevant Working Experience (Year)<br />&nbsp;&nbsp; 相關工作經驗(年)
            </div>
            <div class="col-sm-62">
		           <asp:TextBox ID="WorkExp" runat="server" placeholder="0.0" MaxLength="4" style="width:50px"  />
                   <asp:RegularExpressionValidator ID="validWorkExp" runat="server" ControlToValidate="WorkExp" ValidationExpression="^((\d{5})*|([1-9]\d{0,5}))(\.\d{0,2})?$"
    ErrorMessage="Please enter Number Only 只可輸入數字" />
            </div>
       </div>
       <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory">* </span>Expected Salary (Monthly)<br />&nbsp;&nbsp; 要求薪金 (月薪)
            </div>
            <div class="col-sm-62">
		           <asp:TextBox ID="ExpSal" runat="server" type="number" CssClass="input-boxM" MaxLength="7" style="width:100px"  />
                   <asp:RegularExpressionValidator ID="valid13" runat="server" ControlToValidate="ExpSal" ValidationExpression="^[0-9]*$"
    ErrorMessage="Please enter Number Only 只可輸入數字" />
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
                        <td style="width:40%">
                             <div class="col-sm-62">
		                          <asp:DropDownList ID="DrAvaDate" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="btnShowDate" />              
                              </div>
                        </td>
                        <td  style="width:60%"> 
                              <asp:Panel ID="pnlAvadate" runat="server" Visible="false">Date Available 可到職日期：
                                  <asp:TextBox ID="dtAvadate" runat="server" style="width:100px"></asp:TextBox>
                                  <button onclick="showcald();return false;" style="background-color:transparent;border:none"><img src="Images\calender.png"/></button>
                                  <div id="myDIV">
		                            <asp:Calendar ID="cald1" runat="server" OnSelectionChanged="DateChange">
                                    </asp:Calendar>
                                   </div>
                               </asp:Panel>
                                  <asp:RegularExpressionValidator runat="server" ControlToValidate="dtAvadate" ValidationExpression="^(((0[1-9]|[12]\d|3[01])/(0[13578]|1[02])/((19|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)/(0[13456789]|1[012])/((19|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])/02/((19|[2-9]\d)\d{2}))|(29/02/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$"
    ErrorMessage="Please enter in format (DD/MM/YYYY) 請按格式(DD/MM/YYYY)輸入" ValidationGroup="Group1" />
                            
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
               <span class="compulsory"> </span>&nbsp;&nbsp;Current / Latest Company<br />&nbsp;&nbsp; 現職 / 最近公司
            </div>
            <div class="col-sm-62">
		           <asp:TextBox ID="CurCompany" runat="server" CssClass="input-boxM" MaxLength="250"   />
            </div>
       </div>
       <div class="form-group row">
            <div class="col-sm-61">
               <span class="compulsory"> </span>&nbsp;&nbsp;Current / Latest Position<br />&nbsp;&nbsp; 現職 / 最近職位
            </div>
            <div class="col-sm-62">
		           <asp:TextBox ID="CurPosition" runat="server" CssClass="input-boxM" MaxLength="250"   />
            </div>
       </div>
        <div class="form-group row">
            <div class="col-sm-61">
                <span class="compulsory"> </span>&nbsp;&nbsp;Current / Latest Salary (Monthly)<br />&nbsp;&nbsp; 現職 / 最近薪金 (月薪)
            </div>
            <div class="col-sm-62">
		           <asp:TextBox ID="CurSAL" runat="server" type="number" CssClass="input-boxM" MaxLength="7" style="width:100px"   />
                <asp:RegularExpressionValidator ID="ValdCurSAL" runat="server" ControlToValidate="CurSAL" ValidationExpression="^[0-9]*$"
    ErrorMessage="Please enter Number Only 只可輸入數字" />
            </div>
       </div> 
        <hr />
        <div class="form-group row">
            <div class="col-sm-6" style="text-align:left">
              <div class="form-group row">
                    <div class="col-sm-6">
                        <span class="compulsory">*</span>&nbsp;Upload CV&nbsp;&nbsp;<br /> 上載履歷表 (PDF / Word File) </div>
                    <div class="col-sm-6">
		                    <asp:FileUpload  ID="fUpload1" runat="server" CssClass="" MaxLength="50" /> <br /> <br />
                    </div>
                    <hr />
                    <div class="col-sm-6">
                            <span class="compulsory"></span>&nbsp;Upload Reference & Supporting Documents <br />上載工作及學歷證明文件<br /> (PDF / Word File) </div>
                        <div class="col-sm-6">
		                       
		                        <asp:FileUpload  ID="fUpload2" runat="server" CssClass="" MaxLength="50"  /> <br />
		                        <asp:FileUpload  ID="fUpload3" runat="server" CssClass="" MaxLength="50" /> <br />
		                        <asp:FileUpload  ID="fUpload4" runat="server" CssClass="" MaxLength="50" /> <br />
		                        <asp:FileUpload  ID="fUpload5" runat="server" CssClass="" MaxLength="50" /> 
                     </div>
               </div>   
                <div class="form-group row">
                    <div class="col-sm-12">
                        <u>每個上載檔案不得超過10MB Each file size must not exceed 10MB</u> </div></div>
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
                <asp:CheckBox ID="chkCaT1" runat="server" CssClass="" /><b><span class="compulsory"></span>&nbsp;I fully understand and agree to the Company’s <asp:HyperLink ID="HyperLink4" href="#"
  onclick="window.open('PGDeclare.aspx'); return false;"
  ForeColor="#1226db" runat="server">Personal Information Collection Statement pertaining to Recruitment</asp:HyperLink> and I hereby give my consent to the Company for the lawful use of the data I provided herein.
<br />    &nbsp;&nbsp;&nbsp;&nbsp;本人完全明白及同意貴公司在<asp:HyperLink ID="HyperLink1" href="#"
  onclick="window.open('PGDeclare.aspx'); return false;"
  ForeColor="#1226db" runat="server">招聘方面的收集個人資料聲明</asp:HyperLink>，並在此授權貴公司可以合法地使用本人現在提供之個人資料</b>&nbsp;&nbsp; </div>
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
