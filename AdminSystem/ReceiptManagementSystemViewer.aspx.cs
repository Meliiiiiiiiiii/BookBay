using ClassLibrary;
using System;

using System.Collections.Generic;
using System.Data.SqlClient;
using System.IdentityModel.Protocols.WSTrust;
using System.Web.UI.HtmlControls;
using System.Collections;


public partial class _1Viewer : System.Web.UI.Page
{
  
    protected void Page_Load(object sender, EventArgs e)
    {

        clsOrder Anorder = new clsOrder();
        Anorder = (clsOrder)Session["Anorder"];
        Response.Write(Anorder.OrderId);
        Response.Write(Anorder.CustomerId);
        Response.Write(Anorder.BookId);
        Response.Write(Anorder.OrderDate);
        Response.Write(Anorder.OrderPrice);
        Response.Write(Anorder.OrderStatus);


    }

}