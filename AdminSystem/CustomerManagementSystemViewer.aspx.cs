using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer customer = new clsCustomer();

        customer = (clsCustomer)Session["AnCustomer"];

        Response.Write(customer.CustomerId + "\n");
        Response.Write(customer.Name + "\n");
        Response.Write(customer.Active + "\n");
        Response.Write(customer.Phone + "\n");
        Response.Write(customer.Address + "\n");
        Response.Write(customer.City + "\n");
        Response.Write(customer.RegisterDate + "\n");
    }
}