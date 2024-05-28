<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SellerManagementSystemLogin.aspx.cs" Inherits="ReceiptManagementSystemLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 471px;
        }
    </style>
</head>
<body style="height: 473px">
    <form id="form1" runat="server">

        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 450px; top: 49px; position: absolute" Text="Seller Management System"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 549px; top: 120px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 435px; top: 120px; position: absolute" Text="UserName"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 435px; top: 182px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 549px; top: 183px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 440px; top: 265px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 592px; top: 265px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 748px; top: 148px; position: absolute" Text="[lblError]" Visible="False"></asp:Label>

    </form>
</body>
</html>
