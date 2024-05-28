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
            DisplaySellers();
        }
        clsSellerUser AnUser = new clsSellerUser();
        AnUser = (clsSellerUser)Session["AnUser"];
        Response.Write("Logged in As : " + AnUser.UserName);
    }
    void DisplaySellers()
    {
        clsSellerCollection sellers = new clsSellerCollection();
        lstSellerList.DataSource = sellers.SellerList;
        lstSellerList.DataValueField = "SellerID";
        lstSellerList.DataTextField = "FirstName";
        lstSellerList.DataBind();
    }

    protected void btnEdit_Click1(object sender, EventArgs e)
    {
        int SellerID;
        if (lstSellerList.SelectedIndex != -1)
        {
            SellerID = Convert.ToInt32(lstSellerList.SelectedValue);
            Session["SellerId"] = SellerID;
            Response.Redirect("SellerManagementSystemDataEntry.aspx");
        }
        else
        {

            lblError.Text = "Please Select a record from List to Edit";
            lblError.Visible = true;
        }
    }

    protected void btnDelete_Click1(object sender, EventArgs e)
    {
        int SellerId;

        if (lstSellerList.SelectedIndex != -1)
        {
            SellerId = Convert.ToInt32(lstSellerList.SelectedValue);
            Session["SellerId"] = SellerId;
            Response.Redirect("SellerManagementSystemConfirmDelete.aspx");
        }
        else
        {

            lblError.Text = "Please Select a record from List to Delete";
            lblError.Visible = true;
        }
    }

    protected void btnFilter_Click1(object sender, EventArgs e)
    {
        clsSellerCollection sellers = new clsSellerCollection();
        sellers.ReportByFirstName(txtFirstnameFilter.Text);
        lstSellerList.DataSource = sellers.SellerList;
        lstSellerList.DataValueField = "SellerID";
        lstSellerList.DataTextField = "FirstName";
        lstSellerList.DataBind();
    }

    protected void btnClear_Click1(object sender, EventArgs e)
    {
        clsSellerCollection sellers = new clsSellerCollection();
        sellers.ReportByFirstName("");
        txtFirstnameFilter.Text = "";
        lstSellerList.DataSource = sellers.SellerList;
        lstSellerList.DataValueField = "SellerID";
        lstSellerList.DataTextField = "FirstName";
        lstSellerList.DataBind();
    }

    protected void btnReturn_Click1(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        Session["SellerId"] = -1;

        //redirect to the Receipt data Entry
        Response.Redirect("SellerManagementSystemDataEntry.aspx");
    }
}