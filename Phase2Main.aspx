<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Phase2Main.aspx.vb" Inherits="Career.Phase2Main" %>
<%@ Import Namespace="System.Web.Security" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Graduate Page</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    
    <link href="lib/boostrap/bootstrap.css?timestamp=201809201509" rel="stylesheet" type="text/css" /> 
    <link rel="stylesheet" href="include/style.css?timestamp=201809201509" type="text/css" />
    <link rel="shortcut icon" href="favicon.ico" type="image/x-icon">
    
    <script src="lib/jquery/jquery-3.3.1.js" type="text/javascript"></script>
    <script src="lib/boostrap/bootstrap.js" type="text/javascript"></script>

    <script src="lib/jquery.validate/jquery.validate.min.js" type="text/javascript"></script>
    <script src="include/main.js?timestamp=201809201509" type="text/javascript"></script>

    <script src="include/p2.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="pos_container">
    
        <!-- #include file="include/header.inc" -->
        <br />
 	    <div id="pos_front_left"></div>
	    <br />
	 
	     <div class="row">
            <div class="col-sm-12 custmaincol">
		        <span class="text-bold">		        
		            本公司之招聘及甄選程序均符合下列法例要求: <br />
		            The recruitment and selection processes in the Company are in compliance with the relevant Ordinances and Regulations as follows:		        
		        </span>
            </div>
         </div>
	    <br />
	     <div class="row privacy">
            <%--<div class="col-sm-6 custmaincol">
		        <span class="text-xs-h">Equal Opportunities Ordinances</span><br />
			    <div style="">As an equal opportunities employer, all applications are judged on the applicant’s competence and evaluated by consistent selection criteria and in full compliance with relevant ordinances.</div>
			    <br />
            </div>
            <div class="col-sm-6 custmaincol">
			    <span class="text-xs-h">平等機會條例</span><br />
			    <div>作為一個平等機會僱主，所有應徵者之申請將會經劃一甄選準則評核，因才招聘。</div>
			    <br />
            </div>--%>
         </div>
         
         <div class="row privacy">
            <div class="col-sm-6 custmaincol">
		        <span class="text-xs-h">Personal Information Collection Statement pertaining to Recruitment</span><br />
			    <div style="">The personal data collected in this application form will be used by the Company to assess your suitability to assume the job duties of the position for which you have applied and to determine preliminary remuneration and benefits package to be discussed with you subject to selection for the position. All personal data provided herewith will be kept in strict confidence.</div>
			    <br />		
			    <div style="">It is our policy to retain the personal data of unsuccessful applicants for future recruitment purposes for a period of twelve (12) months. When there are vacancies of similar nature in our subsidiaries or associated companies during that period, we may transfer your application to them for consideration of employment. If you wish to request access to, and to request correction of, your personal data in relation to your application, please contact our Data Protection Officer in Human Resources Department for the details.</div>
			    <br />		
            </div>
            <div class="col-sm-6 custmaincol">
			     <span class="text-xs-h">招聘方面的收集個人資料聲明</span><br />
			    <div style="">本公司會將申請表所收集的個人資料，使用於評估 閣下是否適合擔任所申請的職位，以及在 閣下獲挑選出任該職位時，用作決定 閣下的薪酬及福利。而本公司對 閣下所提供的個人資料會作保密處理。</div>
			    <br />
			    <div style="">本公司的政策是為日後的招聘活動保留 閣下的個人資料十二個月。如本公司的附屬或聯營機構在此期間出現類似的職位空缺，本公司或會將 閣下的申請轉交有關機構考慮。閣下如欲要求查閱及改正職位申請表上所填報的個人資料，請向本公司人事部的資料保障主任查詢。</div>
			    <br />
            </div>
         </div>
            
	    <hr />
	    <p>    
	 <%--   <div class="row">
	     <div class="col-sm-6 mobilealign" >
	        請輸入你的申請編號 Please enter your Refenrece Number: 
	     </div>
	     <div class="col-sm-6">
	       <asp:TextBox ID="txtRef" runat="server" value="" />
	     </div>   
	    </div>
	    <br />   
	    <div class="row">
	     <div class="col-sm-6 mobilealign">
	        請輸入電話號碼最後4位數字 Please enter the last 4 digits of your phone number: 
	     </div>
	     <div class="col-sm-6">
	        <asp:TextBox TextMode="Password" ID="txtPwd" runat="server" value="" maxlength="4" />
	     </div>   
	    </div>--%>
	    <br />   
	    <div class="row">	    
	        <div class="col-sm-12" align="center">
	        <asp:Button ID="btnSubmit" runat="server" Text="提交 Submit" CssClass="btn btn-primary" OnClick="SubmitForm"  />
	        </div>
	    </div>
	    </p>
	    <br /> 
    </div>
    </form>
</body>
</html>
