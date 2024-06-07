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

        if (IsPostBack == false)
        {
            DisplayCustomer();
        }

        clsCustomerUser aUser = new clsCustomerUser();
        aUser = (clsCustomerUser)Session["aUser"];
        Response.Write("Logged in as : " + aUser.UserName);
    }

    void DisplayCustomer()
    {
        //create a instance of the customer collection
        clsCustomerCollection AllCustomer = new clsCustomerCollection();

        //set the data source to list of customer in the collection
        lstCustomerList.DataSource = AllCustomer.CustomerList;
        // set the name of the primary key
        lstCustomerList.DataValueField = "CustomerId";
        //set the data field to display
        lstCustomerList.DataTextField = "Name";
        //bind data to the list 
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record

        Session["CustomerId"] = -1;

        //redirect to the customer data Entry
        Response.Redirect("CustomerManagementSystemDataEntry.aspx");
    }


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 CustomerID;
        if (lstCustomerList.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerId"] = CustomerID;
            Response.Redirect("CustomerManagementSystemDataEntry.aspx");
        }
        else
        {

            lblError.Text = "Please Select a record from List to Edit";
            lblError.Visible = true;
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 CustomerId;

        if (lstCustomerList.SelectedIndex != -1)
        {
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerId"] = CustomerId;
            Response.Redirect("CustomerManagementSystemConfirmDelete.aspx");
        }
        else
        {

            lblError.Text = "Please Select a record from List to Delete";
            lblError.Visible = true;
        }
    }

    protected void BtnApplyFilter_Click(object sender, EventArgs e)
    {
        clsCustomerCollection AllCustomer = new clsCustomerCollection();

        AllCustomer.Filter(txtDateFilter.Text);
        lstCustomerList.DataSource = AllCustomer.CustomerList;
        //set the name for primary key
        lstCustomerList.DataValueField = "CustomerId";
        lstCustomerList.DataTextField = "RegisterDate";
        lstCustomerList.DataBind();
    }

    protected void BtnClrFilter_Click(object sender, EventArgs e)
    {
        clsCustomerCollection AllCustomer = new clsCustomerCollection();

        AllCustomer.Filter("");
        //clear existing filter
        txtDateFilter.Text = "";
        lstCustomerList.DataSource = AllCustomer.CustomerList;
        //set the name for primary key
        lstCustomerList.DataValueField = "CustomerId";
        lstCustomerList.DataTextField = "RegisterDate";
        lstCustomerList.DataBind();
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}