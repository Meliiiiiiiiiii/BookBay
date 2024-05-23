using ClassLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IdentityModel.Protocols.WSTrust;
using System.Web.UI.HtmlControls;

public partial class _1Viewer : System.Web.UI.Page
{
  
    protected void Page_Load(object sender, EventArgs e)
    {
        clsReceipt receipt = new clsReceipt();

        receipt = (clsReceipt)Session["AnReceipt"];

        Response.Write(receipt.ID+"\n");
        Response.Write(receipt.OrderID + "\n");
        Response.Write(receipt.Transation + "\n");
        Response.Write(receipt.PaymentMethod + "\n");
        Response.Write(receipt.Tax + "\n");
        Response.Write(receipt.TotalPrice + "\n");
        Response.Write(receipt.CreatedAt + "\n");
    }

}