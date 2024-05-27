<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SellerManagementSystemList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 853px;
        }
    </style>
</head>
<body style="height: 854px">
    <form id="form1" runat="server">
        <asp:TextBox ID="txtFirstnameFilter" runat="server" style="z-index: 1; left: 267px; top: 668px; position: absolute; width: 404px"></asp:TextBox>
        <asp:ListBox ID="lstSellerList" runat="server" style="z-index: 1; left: 36px; top: 42px; position: absolute; height: 486px; width: 813px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 45px; top: 568px; position: absolute; right: 832px" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 202px; top: 567px; position: absolute" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 363px; top: 568px; position: absolute" Text="Delete" />
        <asp:Button ID="btnFilter" runat="server" style="z-index: 1; left: 40px; top: 757px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClear" runat="server" style="z-index: 1; left: 203px; top: 758px; position: absolute" Text="Clear Filter" />
        <asp:Button ID="btnReturn" runat="server" style="z-index: 1; left: 371px; top: 756px; position: absolute" Text="Return to Menu" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 48px; top: 668px; position: absolute; right: 728px" Text="Enter a FirstName"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 48px; top: 823px; position: absolute" Text="[lblError]"></asp:Label>
    </form>
</body>
</html>
