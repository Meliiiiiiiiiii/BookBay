<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 638px;
        }
    </style>
</head>
<body style="height: 637px">
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 508px; top: 201px; position: absolute" Text="Menu Page"></asp:Label>
        <asp:Button ID="btnReceipt" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 236px; top: 300px; position: absolute" Text="Receipt" />
        <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 372px; top: 302px; position: absolute" Text="Staff" />
        <asp:Button ID="Button3" runat="server" style="z-index: 1; left: 515px; top: 304px; position: absolute" Text="Book" />
        <asp:Button ID="Button4" runat="server" style="z-index: 1; left: 670px; top: 303px; position: absolute" Text="Customer" />
        <asp:Button ID="Button5" runat="server" style="z-index: 1; left: 846px; top: 306px; position: absolute" Text="Order" />
        <asp:Button ID="btnSeller" runat="server" OnClick="btnSeller_Click" style="z-index: 1; left: 975px; top: 308px; position: absolute" Text="Seller" />
    </form>
</body>
</html>
