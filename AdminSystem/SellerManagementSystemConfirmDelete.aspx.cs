using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    int SellerId;

    protected void Page_Load(object sender, EventArgs e)
    {
        SellerId = Convert.ToInt32(Session["SellerId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsSellerCollection sellers = new clsSellerCollection();
        sellers.ThisSeller.Find(SellerId);
        sellers.Delete();
        Response.Redirect("SellerManagementSystemList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("SellerManagementSystemList.aspx");
    }
}