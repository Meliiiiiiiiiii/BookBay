<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffManagementSystemList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <style type="text/css">
        #form1 {
            height: 698px;
        }
    </style>
    
</head>
<body>
    
    <form id="form1" runat="server">
        <asp:ListBox ID="lstStaffList" runat="server" Height="331px" Width="356px"></asp:ListBox>
        <p>
            <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" style="margin-left: 36px" Text="Add " />
            <asp:Button ID="BtnEdit" runat="server" OnClick="BtnEdit_Click" style="margin-left: 76px" Text="Edit" Width="49px" />
            <asp:Button ID="BtnDelete" runat="server" OnClick="BtnDelete_Click" style="margin-left: 57px" Text="Delete" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 87px; top: 449px; position: absolute; width: 155px" Text="Enter a salary (£)"></asp:Label>
             <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 44px; top: 578px; position: absolute; width: 155px; margin-bottom: 21px;" Text="lblError"></asp:Label>
            <asp:TextBox ID="Salarytext" runat="server" style="z-index: 1; left: 230px; top: 449px; position: absolute"></asp:TextBox>
            <asp:Button ID="Btnfilter" runat="server" OnClick="Btnfilter_Click" style="z-index: 1; left: 178px; top: 490px; position: absolute; right: 303px" Text="Apply Filter" width="100px" />
            <asp:Button ID="BtnClear" runat="server" height="26px" OnClick="BtnClear_Click" style="z-index: 1; left: 177px; top: 540px; position: absolute" Text="Clear Filter" width="100px" />
        </p>
       
    </form>
    
</body>
</html>