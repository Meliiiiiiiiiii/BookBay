<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffManagementSystemList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    
    <form id="form1" runat="server">
        <asp:ListBox ID="lstStaffList" runat="server" Height="331px" Width="356px"></asp:ListBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" style="margin-left: 36px" Text="Add " />
        </p>
    </form>
    
</body>
</html>