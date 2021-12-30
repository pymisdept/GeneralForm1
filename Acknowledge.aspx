<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Acknowledge.aspx.vb" Inherits="Career.Acknowledge" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Acknowledge Page</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    
    <link href="lib/boostrap/bootstrap.css?timestamp=201809201509" rel="stylesheet" type="text/css" /> 
    <link rel="stylesheet" href="include/style.css?timestamp=201809201509" type="text/css" />
    <link rel="shortcut icon" href="favicon.ico" type="image/x-icon">
    <script src="lib/jquery/jquery-3.3.1.js" type="text/javascript"></script>
    <script src="lib/boostrap/bootstrap.js" type="text/javascript"></script>
    <script src="include/main.js?timestamp=201809201509" type="text/javascript"></script>
    
</head>
<body>
    <form runat="server" id="form1">
    <div id="pos_container">
	    <!-- #include file="include/header.inc" -->
	    <br /><br />	    
	     <div class="row">
            <div class="col-sm-12">
                Thank you for your application. The reference number of your application is&nbsp; <asp:Label ID ="refNo" runat="server" Font-Bold="True"></asp:Label>  
                .<br />
                多謝閣下的申請。閣下的申請編號為 <asp:Label ID ="refNo2" runat="server" Font-Bold="True"></asp:Label>
                。<br />
                <br />
                An acknowledgement will be sent to you.
                <br />
                閣下將會收到一封確認電郵。
            </div>
         </div>
         	     
	    <p align="center" /><br />
	    <%--<asp:Button ID="btnClose" runat="server" Text="離開 Exit" onclick="goRegister"/><br />--%>
    </div>
    </form>
</body>
</html>
