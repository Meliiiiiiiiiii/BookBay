using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    int ReceiptId;
    protected void Page_Load(object sender, EventArgs e)
    {
        ReceiptId = Convert.ToInt32(Session["ReceiptId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsReceiptCollection receipts = new clsReceiptCollection();
        receipts.ThisReceipt.Find(ReceiptId);
        receipts.Delete();
        Response.Redirect("ReceiptManagementSystemList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReceiptManagementSystemList.aspx");
    }
}