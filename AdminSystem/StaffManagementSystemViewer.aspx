<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffManagementSystemViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 463px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
   
</p>
<p>
    <asp:Label ID="StaffIDlbl" runat="server" height="32px" style="z-index: 1; left: 26px; top: 62px; position: absolute" Text="StaffID" width="143px"></asp:Label>
    <asp:Label ID="Namelbl" runat="server" height="32px" style="z-index: 1; left: 26px; top: 123px; position: absolute" Text="Name" width="143px"></asp:Label>
    <asp:TextBox ID="NameIDtxt" runat="server" height="38px" style="z-index: 1; left: 282px; top: 109px; position: absolute" width="248px"></asp:TextBox>
    <asp:Label ID="Email" runat="server" height="32px" style="z-index: 1; left: 26px; top: 186px; position: absolute" Text="Email" width="143px"></asp:Label>
    <asp:TextBox ID="StaffIDtxt" runat="server" style="z-index: 1; left: 328px; top: 64px; position: absolute"></asp:TextBox>
</p>
<asp:TextBox ID="Emailtxt" runat="server" height="38px" style="z-index: 1; left: 282px; top: 177px; position: absolute" width="248px"></asp:TextBox>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    <asp:TextBox ID="Phonetxt" runat="server" height="38px" style="z-index: 1; left: 282px; top: 243px; position: absolute" width="248px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Phone" runat="server" style="z-index: 1; left: 26px; top: 256px; position: absolute; height: 32px; margin-bottom: 0px" Text="Phone"></asp:Label>
    <asp:TextBox ID="hiredatetxt" runat="server" height="38px" style="z-index: 1; left: 282px; top: 313px; position: absolute" width="248px"></asp:TextBox>
    <asp:Label ID="hiredate" runat="server" height="32px" style="z-index: 1; left: 23px; top: 317px; position: absolute; width: 247px" Text="Hire Date"></asp:Label>
</p>
<p>
    <asp:TextBox ID="salarytxt" runat="server" height="38px" style="z-index: 1; left: 283px; top: 372px; position: absolute" width="248px"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Cancelbtn" runat="server" style="z-index: 1; top: 487px; position: absolute; left: 312px" Text="Cancel" />
</p>

<p>
    <asp:Label ID="salary" runat="server" height="32px" style="z-index: 1; left: 23px; top: 377px; position: absolute; bottom: 465px; width: 199px" Text="Salary"></asp:Label>
        </p>
    </form>
</body>
</html>