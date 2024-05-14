using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void OKbtn_Click(object sender, EventArgs e)
    {

        clsOrder AnOrder = new clsOrder();
        String OrderID = OrderIDtxt.Text;
        String CustomerID = CustomerIDtxt.Text;
        String BookID = BookIDtxt.Text;
        String OrderDatee = OrderDatetxt.Text;
        String OrderPricee = orderpricetxt.Text;
        String OrderStatuss = OrderStatustxt.Text;
        String Error = "";
        Error = AnOrder.Valid(OrderPricee, OrderStatuss, OrderDatee);
        if (Error == "")
        {
            AnOrder.OrderPrice = Convert.ToInt32(OrderPricee);
            AnOrder.OrderStatus = OrderStatuss;
            AnOrder.OrderDate = Convert.ToDateTime(OrderDatee);
            Session["AnOrder"] = AnOrder;
            Response.Redirect("1Viewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void Findbtn_Click1(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderId;
        Boolean Found = false;
        OrderId = Convert.ToInt32(OrderIDtxt.Text);
        Found = AnOrder.Find(OrderId);
        if (Found == true)
        {
            CustomerIDtxt.Text = AnOrder.CustomerId.ToString();
            BookIDtxt.Text = AnOrder.BookId.ToString();
            OrderDatetxt.Text = AnOrder.OrderDate.ToString();
            orderpricetxt.Text = AnOrder.OrderPrice.ToString();
            OrderStatustxt.Text = AnOrder.OrderStatus;

        }
    }
}