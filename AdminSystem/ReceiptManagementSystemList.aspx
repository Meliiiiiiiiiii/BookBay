<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceiptManagementSystemList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">
        #form1 {
            height: 648px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        
        <div style="height: 646px">
            <asp:Button ID="btnEdit" runat="server" Text="Edit" style="z-index: 1; left: 115px; top: 539px; position: absolute" OnClick="btnEdit_Click"/>
            <asp:Label ID="lblError" runat="server" Text="[lblError]" style="z-index: 1; left: 32px; top: 593px; position: absolute" Visible="False"></asp:Label>
            <asp:Button ID="btnDelete" runat="server" Text="Delete" style="z-index: 1; left: 189px; top: 540px; position: absolute" OnClick="btnDelete_Click" />
            <asp:ListBox ID="lstReceiptList" runat="server" style="z-index: 1; left: 30px; top: 32px; position: absolute; height: 477px; width: 784px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 30px; top: 540px; position: absolute" Text="Add" />
        </div>
        
    </form>
</body>
</html>
