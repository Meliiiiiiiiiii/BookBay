<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .Header{
            text-align:center;
        }
        .menu{
            margin-top:50px;
            height: 303px;
        }
    </style>
</head>
   
<body>
    <form id="form1" runat="server">
        <div>
            <div class="Header">
                <asp:Label ID="Label1" runat="server" Text="BookBay "></asp:Label><br /><br /> 
                 <asp:Label ID="Label2" runat="server" Text="Book online commerce system "></asp:Label>
            </div>
            
        </div>
        
        <div class="menu">
            <br />
            <asp:Button ID="Button5" runat="server" style="margin-left: 517px; margin-top: 5px;" Text="Staff Management System " Width="256px" /> 
            <asp:Button ID="Button6" runat="server" style="z-index: 1; left: 528px; top: 188px; position: absolute; width: 256px" Text="Customer Management System" /> <br />
            <asp:Button ID="Button7" runat="server" style="z-index: 1; left: 528px; top: 232px; position: absolute; width: 256px" Text="Book Management System" />
            <br />
            <asp:Button ID="Button8" runat="server" style="z-index: 1; left: 528px; top: 276px; position: absolute; width: 256px" Text="Order Management System" /><br />
             <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 528px; top: 276px; position: absolute; width: 256px" Text="Receipt Management System" /><br />
             <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 528px; top: 276px; position: absolute; width: 256px" Text=" Seller Management System" /><br />
            
        </div>
       
          
    </form>
</body>
</html>
