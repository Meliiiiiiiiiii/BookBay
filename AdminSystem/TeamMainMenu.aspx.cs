﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReceiptManagementSystemLogin.aspx");
    }

    protected void btnSeller_Click(object sender, EventArgs e)
    {
        Response.Redirect("SellerManagementSystemLogin.aspx");
    }

    protected void Button5_Click(object sender, EventArgs e)
    {

    }

    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffManagementSystemLogin.aspx");
    }

    protected void Unnamed4_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderLogin.aspx");
        
    }

    protected void Unnamed5_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReceiptManagementSystemLogin.aspx");
    }

    protected void Unnamed2_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerManagementSystemLogin.aspx");
    }
}