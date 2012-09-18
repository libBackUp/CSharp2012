<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UseThePhoneNumber.aspx.cs" Inherits="WebControls.UseThePhoneNumber" %>

<%@ Register src="PhoneNumber.ascx" tagname="PhoneNumber" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:PhoneNumber ID="PhoneNumber1" runat="server" />
    
    </div>
    </form>
</body>
</html>
