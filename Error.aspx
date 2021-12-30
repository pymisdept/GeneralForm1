<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Error.aspx.vb" Inherits="Career._Error" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Error Page</title>
    <link href="lib/boostrap/bootstrap.css?timestamp=201809201509" rel="stylesheet" type="text/css" /> 
    <link rel="stylesheet" href="include/style.css?timestamp=201809201509" type="text/css" />
    <link rel="shortcut icon" href="favicon.ico" type="image/x-icon">
    <script src="lib/jquery/jquery-3.3.1.js" type="text/javascript"></script>
    <script src="lib/boostrap/bootstrap.js" type="text/javascript"></script>
    
    <script src="include/main.js?timestamp=201809201509" type="text/javascript"></script>    
</head>
<body>
    <form id="form1" runat="server">
    <div id="pos_container">
	    <!-- #include file="include/header.inc" -->
	    <br /><br />	    
	     <div class="row">
            <div class="col-sm-12">
                <h4>The Page has expired.</h4>   
            </div>
         </div>
         	     
	    <p align="center" /><br />
	    <asp:Button ID="btnClose" runat="server" Text="離開 Exit" CssClass="" OnClientClick="javascript:window.close();" />
	    <p align="center" /><br />
    </div>
    </form>
</body>
</html>
