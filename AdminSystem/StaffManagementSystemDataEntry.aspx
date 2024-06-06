<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffManagementSystemDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 450px;
        }
        #form {
            height: 617px;
        }
        #form2 {
            height: 553px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
        </div>
        <p>
   
</p>
<p>
    <asp:Label ID="StaffIDlbl" runat="server" height="32px" style="z-index: 1; left: 26px; top: 62px; position: absolute" Text="StaffID" width="143px"></asp:Label>
    <asp:Label ID="Namelbl" runat="server" height="32px" style="z-index: 1; left: 26px; top: 123px; position: absolute" Text="Name" width="143px"></asp:Label>
    <asp:TextBox ID="NameIDtxt" runat="server" height="38px" style="z-index: 1; left: 282px; top: 119px; position: absolute" width="248px"></asp:TextBox>
    <asp:Label ID="Email" runat="server" height="32px" style="z-index: 1; left: 26px; top: 186px; position: absolute" Text="Email" width="143px"></asp:Label>
    <asp:TextBox ID="StaffIDtxt" runat="server" style="z-index: 1; left: 328px; top: 64px; position: absolute"></asp:TextBox>
</p>
<asp:TextBox ID="Emailtxt" runat="server" height="38px" style="z-index: 1; left: 282px; top: 180px; position: absolute" width="248px"></asp:TextBox>
<p>
    &nbsp;</p>
<p>
    <asp:Button ID="Findbtn" runat="server" style="z-index: 1; left: 632px; top: 58px; position: absolute" Text="Find" OnClick="Findbtn_Click1" />
</p>
<p>
    &nbsp;</p>
<p>
    <asp:TextBox ID="Phonetxt" runat="server" height="38px" style="z-index: 1; left: 282px; top: 249px; position: absolute" width="248px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Phone" runat="server" style="z-index: 1; left: 26px; top: 256px; position: absolute; height: 32px; margin-bottom: 0px" Text="Phone"></asp:Label>
    <asp:TextBox ID="hiredatetxt" runat="server" height="38px" style="z-index: 1; left: 282px; top: 318px; position: absolute" width="248px" OnTextChanged="hiredatetxt_TextChanged"></asp:TextBox>
    <asp:Label ID="hiredate" runat="server" height="32px" style="z-index: 1; left: 26px; top: 327px; position: absolute; width: 247px; right: 1245px;" Text="Hire Date"></asp:Label>
</p>
<p>
    <asp:TextBox ID="salarytxt" runat="server" height="38px" style="z-index: 1; left: 282px; top: 395px; position: absolute" width="248px" ></asp:TextBox>
    <asp:TextBox ID="IsAdmintxt" runat="server" height="38px" style="z-index: 1; left: 282px; top: 470px; position: absolute" width="248px"></asp:TextBox>
</p>

<p>
    &nbsp;</p>
<p>
    <asp:Label ID="salary" runat="server" height="32px" style="z-index: 1; left: 26px; top: 400px; position: absolute; bottom: 194px; width: 199px" Text="Salary"></asp:Label>
    <asp:Button ID="Cancelbtn" runat="server" style="z-index: 1; top: 570px; position: absolute; left: 394px" Text="Cancel" OnClick="Cancelbtn_Click" />
        </p>
    <asp:Label ID="IsAdmin" runat="server" style="z-index: 1; left: 14px; top: 482px; position: absolute; width: 247px; height: 18px;" Text="Is Admin"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1;left: 679px; top: 253px; position: absolute; width: 202px; height: 18px;" Text="Label"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
<asp:Button ID="OKbtn" runat="server" OnClick="OKbtn_Click" style="z-index: 1; left: 233px; top: 569px; position: absolute; right: 870px;" Text="OK" height="35px" width="90px" />
            <asp:Button ID="Btnmenu" runat="server" height="35px" OnClick="Btnmenu_Click" style="z-index: 1; left: 578px; top: 570px; position: absolute" Text="Return to main menu" />
        </p>
    </form>
</body>
</html>