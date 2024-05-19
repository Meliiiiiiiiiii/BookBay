<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceiptManagementSystemDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 578px">
            <asp:TextBox ID="txtReceiptID" runat="server" style="z-index: 1; left: 683px; top: 77px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 682px; top: 134px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtTransaction" runat="server" style="z-index: 1; left: 681px; top: 191px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtTax" runat="server" style="z-index: 1; left: 680px; top: 250px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtPaymentMethod" runat="server" style="z-index: 1; left: 678px; top: 309px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtTotalPrice" runat="server" style="z-index: 1; left: 678px; top: 369px; position: absolute"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 507px; top: 78px; position: absolute" Text="ReceiptID"></asp:Label>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 507px; top: 135px; position: absolute" Text="OrderID"></asp:Label>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 508px; top: 192px; position: absolute; right: 559px" Text="Transaction"></asp:Label>
            <asp:Label ID="lblTax" runat="server" style="z-index: 1; left: 508px; top: 250px; position: absolute" Text="Tax"></asp:Label>
            <asp:Label runat="server" style="z-index: 1; left: 508px; top: 313px; position: absolute; right: 529px" Text="PaymentMethod"></asp:Label>
            <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 509px; top: 369px; position: absolute" Text="TotalPrice"></asp:Label>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 500px; top: 480px; position: absolute" Text="Ok" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 650px; top: 480px; position: absolute" Text="Cancel" />
            <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 813px; top: 480px; position: absolute" Text="Find" />
        </div>
    </form>
</body>
</html>
