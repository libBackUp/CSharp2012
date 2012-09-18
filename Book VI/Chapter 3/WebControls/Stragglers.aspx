<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Stragglers.aspx.cs" Inherits="WebControls.Stragglers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 300px;
            height: 326px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        1- File Upload<br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <br />
        2- Image map<br />
        <img alt="Map" class="auto-style1" src="Images/300px-Ohio_Counties_Labeled_White.svg.png" /><br />
        <br />
        3- Calendar<br />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    
    </div>
    </form>
</body>
</html>
