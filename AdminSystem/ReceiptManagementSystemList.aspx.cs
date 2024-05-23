using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class _1_List : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DisplayReceipts();
        }
    }

    void DisplayReceipts()
    {
        clsReceiptCollection Receipts = new clsReceiptCollection();
        lstReceiptList.DataSource = Receipts.ReceiptList;
        lstReceiptList.DataValueField = "ID";
        lstReceiptList.DataTextField = "Transation";
        lstReceiptList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record

        Session["ReceiptId"] = -1;

        //redirect to the Receipt data Entry
        Response.Redirect("ReceiptManagementSystemDataEntry.aspx");
    }


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        int receiptID;
        if(lstReceiptList.SelectedIndex != -1)
        {
            receiptID = Convert.ToInt32(lstReceiptList.SelectedValue);
            Session["ReceiptId"] = receiptID;
            Response.Redirect("ReceiptManagementSystemDataEntry.aspx");
        }
        else
        {

            lblError.Text = "Please Select a record from List to Edit";
            lblError.Visible = true;
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        int ReceiptId;

        if (lstReceiptList.SelectedIndex != -1)
        {
            ReceiptId = Convert.ToInt32(lstReceiptList.SelectedValue);
            Session["ReceiptId"] = ReceiptId;
            Response.Redirect("ReceiptManagementSystemConfirmDelete.aspx");
        }
        else
        {

            lblError.Text = "Please Select a record from List to Delete";
            lblError.Visible = true;
        }
    }
}