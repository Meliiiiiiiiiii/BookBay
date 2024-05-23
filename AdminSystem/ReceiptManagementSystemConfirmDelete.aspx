<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceiptManagementSystemConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 631px">
    <form id="form1" runat="server">
        <div style="height: 633px">
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 166px; top: 241px; position: absolute" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 312px; top: 242px; position: absolute" Text="No" />
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 166px; top: 168px; position: absolute" Text="Are  you Sure you Want to delete this record?"></asp:Label>
    </form>
</body>
</html>
