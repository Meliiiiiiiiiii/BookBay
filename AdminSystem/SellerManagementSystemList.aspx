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
<asp:Button ID="btnFilter" runat="server" style="z-index: 1; left: 40px; top: 757px; position: absolute" Text="Apply Filter" OnClick="btnFilter_Click1" />
<asp:Button ID="btnClear" runat="server" style="z-index: 1; left: 203px; top: 758px; position: absolute" Text="Clear Filter" OnClick="btnClear_Click1" />
<asp:Button ID="btnReturn" runat="server" style="z-index: 1; left: 371px; top: 756px; position: absolute" Text="Return to Menu" OnClick="btnReturn_Click1" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 48px; top: 668px; position: absolute; right: 1305px" Text="Enter a FirstName"></asp:Label>
        <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" style="z-index: 1; left: 42px; top: 567px; position: absolute" Text="Add" />
        <asp:Button ID="BtnEdit" OnClick="btnEdit_Click1" runat="server" style="z-index: 1; left: 178px; top: 568px; position: absolute" Text="Edit" />
        <asp:Button ID="BtnDelete" OnClick="btnDelete_Click1" runat="server" style="z-index: 1; left: 324px; top: 568px; position: absolute" Text="Delete" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 42px; top: 815px; position: absolute" Text="[lblError]" Visible="False"></asp:Label>
    </form>
</body>
</html>
