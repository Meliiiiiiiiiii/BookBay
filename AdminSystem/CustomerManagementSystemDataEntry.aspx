<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerManagementSystemDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 578px">
            <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 677px; top: 147px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 678px; top: 195px; position: absolute; bottom: 459px;" height="22px" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtPhone" runat="server" style="z-index: 1; left: 680px; top: 250px; position: absolute" height="22px" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 678px; top: 309px; position: absolute" height="22px" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtCity" runat="server" style="z-index: 1; left: 678px; top: 369px; position: absolute" height="22px" width="128px"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 499px; top: 146px; position: absolute" Text="CustomerID"></asp:Label>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 509px; top: 197px; position: absolute" Text="Name"></asp:Label>
            <asp:Label ID="lblTax" runat="server" style="z-index: 1; left: 508px; top: 250px; position: absolute" Text="Phone"></asp:Label>
            <asp:Label runat="server" style="z-index: 1; left: 508px; top: 313px; position: absolute; right: 1225px" Text="Address"></asp:Label>
            <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 509px; top: 369px; position: absolute" Text="City"></asp:Label>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 505px; top: 525px; position: absolute" Text="Ok" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 652px; top: 524px; position: absolute" Text="Cancel" OnClick="btnCancel_Click"  />
            <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 814px; top: 526px; position: absolute" Text="Find" OnClick="btnFind_Click" />
            <asp:TextBox ID="txtRegisterDate" runat="server" style="z-index: 1; left: 677px; top: 422px; position: absolute" height="22px" width="128px"></asp:TextBox>
            <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 511px; top: 424px; position: absolute; right: 1257px" Text="RegisterDate"></asp:Label>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 509px; top: 468px; position: absolute" Text="Error" Visible="False"></asp:Label>
           
            <asp:CheckBox ID="boxIsActive" runat="server" style="z-index: 1; left: 676px; top: 486px; position: absolute" Text="IsActive" />
        </div>
    </form>
</body>
</html>
