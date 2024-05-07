<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderManagementSystemViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
       
      
        .container{
            display:flex;
            position:relative;

        }
        .container #vertical{
            position:fixed;
            width:200px;
            height:100%;
            background-color:black;
            padding:30px 0;

            
        }
        .content{
            width:100%;
            margin-left:200px;

        }
        .header{
            text-align:center;
            box-shadow:2px;
            border:solid;
            border-block-color:black;
            font-family:sans-serif;

        }
        ul{
            list-style-type:none;

        }


        
    </style>
</head>
<body>
    <div class ="container">
        <div id="vertical">
            <img style="margin-left: 40px; height:120px; width:120px; margin-bottom:30px;" src="photo/bookbay-high-resolution-logo-white-transparent.png"  />
            <ul id="list">
                <li style=" padding:15px; color:white; margin: 15px;"> <a> <label>Order</label></a></li>
                <li style=" padding:15px; color:white; margin: 15px;"> <a> <label>Books</label></a></li>
                <li style=" padding:15px; color:white; margin: 15px;"> <a> <label>Staff</label></a></li>
                <li style=" padding:15px; color:white; margin: 15px;"> <a> <label>Customer</label></a></li>
                <li style=" padding:15px; color:white; margin: 15px;"> <a> <label>Bills</label></a></li>
            </ul>
        </div>
        <div class=" content">
           <div class="header"><h1>Order Managment System</h1></div>
            <div class="info">
                <asp:GridView ID="OrderList" runat="server"></asp:GridView>
            </div>
        </div>

    </div>
</body>s
</html>
