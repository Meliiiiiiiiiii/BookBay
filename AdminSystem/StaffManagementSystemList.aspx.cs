using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


//variable to store the primary key with page level scope

public partial class _1_List : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            DisplayStaffs();
        }
    }
    void DisplayStaffs()
    {
        //create an instance of staff collection
        clsStaffCollection staffCollection = new clsStaffCollection();  
        //set the data source to list of staff in the collection
        lstStaffList.DataSource=staffCollection.StaffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "StaffName";
        lstStaffList.DataBind();
    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        Session["StaffId"] = -1;
        Response.Redirect("StaffManagementSystemDataEntry.aspx");
    }

    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        //variable to dtore the primary key value of the record to be edited
        int StaffId;
        //if a record has been selected from the list
        if(lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record edit
            StaffId=Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffId"]=StaffId;
            //redirect to the edit page 
            Response.Redirect("StaffManagementSystemDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }
}