<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffManagementSystemList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        /* General styles */
        body, html {
            margin: 0;
            padding: 0;
            font-family: Arial, sans-serif;
            box-sizing: border-box;
            height:100%;
        }

        /* Container styles */
        .container {
            display: flex;
            flex-direction: column;
            align-items: center;
            padding: 20px;
            height:100%;
        }

        /* Vertical container styles */
        #vertical {
            width: 100%;
            max-width: 100px; /* Adjust the maximum width as needed */
            background-color: black;
            padding: 20px;
            border-radius: 10px;
            text-align: center;
            color: white; /* Text color */
            height:100%;
        }

        /* Logo styles */
        img.logo {
            max-width: 100%;
            height: auto;
            margin-top:10%;
            margin-bottom: 25%;
        }

        /* Navigation styles */
        #list {
            
            list-style-type: none;
            padding: 0;
            text-align: center;
        }

        #list li {
            padding: 10px;
            margin: 25px;
            background-color: #333;
            border-radius: 5px;
        }

        #list li a {
            color: white;
            text-decoration: none;
        }

        /* Header styles */
        .header {
            text-align: center;
            margin-bottom: 20px;
        }

        /* Responsive styles */
        @media screen and (min-width: 768px) {
            .container {
                flex-direction: row;
                align-items: flex-start;
            }

            #vertical {
                max-width: 30%; /* Adjust the maximum width as needed */
                margin-right: 20px;
            }

            .content {
                flex: 1;
                margin-left: 20px;
            }

            img.logo {
                max-width: 120px;
            }
        }
    </style>
</head>
<body>
    <div class="container">
        <div id="vertical">
            <img class="logo" src="Photo/bookbay-high-resolution-logo-white-transparent.png" alt="Logo">
            <ul id="list">
                <li><a href="StaffManagementSystemViewer.aspx"><label>My Personal Information</label></a></li>
                <li><a href="StaffManagementSystemList.aspx"><label>Staff List</label></a></li>
            </ul>
        </div>
        <div class="content">
            <div class="header">
                <h1>Staff List</h1>
            </div>
            <div class="info">
                <!-- Add your personal information content here -->
            </div>
        </div>
    </div>
</body>
</html>