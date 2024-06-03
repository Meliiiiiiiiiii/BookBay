<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffManagementSystemLogin.aspx.cs" Inherits="StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 7px">
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 101px; top: 239px; position: absolute; height: 25px; width: 76px" Text="Password"></asp:Label>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 169px; top: 65px; position: absolute" Text="Staff Management System Login Page"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 99px; top: 174px; position: absolute; height: 21px" Text="UserName"></asp:Label>
        <p>
            <asp:TextBox ID="Usernametxt" runat="server" style="z-index: 1; left: 221px; top: 171px; position: absolute; width: 175px; height: 24px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="Passwordtxt" runat="server" style="z-index: 1; left: 219px; top: 233px; position: absolute; height: 22px; width: 175px; margin-top: 0px" TextMode="Password"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Button ID="Loginbtn" runat="server" OnClick="Loginbtn_Click" style="z-index: 1; left: 162px; top: 297px; position: absolute" Text="Login" />
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="cancelbtn" runat="server" style="z-index: 1; left: 269px; top: 296px; position: absolute" Text="Cancel" />
        </p>
        <p>
            <asp:Label ID="errorlbl" runat="server" ForeColor="Red" style="z-index: 1; left: 469px; top: 202px; position: absolute" Text="lblError"></asp:Label>
        </p>
    </form>
</body>
</html>
