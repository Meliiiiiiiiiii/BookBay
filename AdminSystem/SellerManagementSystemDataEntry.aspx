<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SellerManagementSystemDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 835px">
    <form id="form1" runat="server">
        <div style="height: 836px">
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 157px; top: 492px; position: absolute" Text="Error" Visible="False"></asp:Label>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 160px; top: 540px; position: absolute" Text="Ok" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 294px; top: 540px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
            <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 489px; top: 543px; position: absolute" Text="Find" OnClick="btnFind_Click" />
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 214px; top: 59px; position: absolute" Text="SellerID"></asp:Label>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 213px; top: 115px; position: absolute" Text="FirstName"></asp:Label>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 211px; top: 169px; position: absolute" Text="LastName"></asp:Label>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 212px; top: 220px; position: absolute" Text="Commission"></asp:Label>
            <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 211px; top: 280px; position: absolute" Text="Sales"></asp:Label>
            <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 211px; top: 342px; position: absolute" Text="CreatedAt"></asp:Label>
            <asp:CheckBox ID="boxIsActive" runat="server" style="z-index: 1; left: 219px; top: 407px; position: absolute" Text="IsActive" />
            <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 331px; top: 113px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtSales" runat="server" style="z-index: 1; left: 334px; top: 281px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 332px; top: 169px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtCommission" runat="server" style="z-index: 1; left: 330px; top: 220px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtCreatedAt" runat="server" style="z-index: 1; left: 330px; top: 346px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtSellerID" runat="server" style="z-index: 1; left: 332px; top: 60px; position: absolute"></asp:TextBox>
        </div>
    </form>
</body>
</html>
