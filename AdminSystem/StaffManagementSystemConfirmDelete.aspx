<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffManagementSystemConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 281px">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 150px; top: 136px; position: absolute; width: 321px" Text="Are you sure you want to delete this record?"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="NoBtn" runat="server" OnClick="NoBtn_Click" style="z-index: 1; left: 324px; top: 198px; position: absolute; width: 35px;" Text="No" />
       <asp:Button ID="YesBtn" runat="server" OnClick="YesBtn_Click" style="z-index: 1; left: 239px; top: 199px; position: absolute" Text="Yes" />
    </form>
</body>
</html>
