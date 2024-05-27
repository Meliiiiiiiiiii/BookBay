<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SellerManagementSystemConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 792px">
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 213px; top: 165px; position: absolute" Text="Are  you Sure you Want to delete this record?"></asp:Label>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 231px; top: 238px; position: absolute" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 488px; top: 245px; position: absolute" Text="No" />
        </div>
    </form>
</body>
</html>
