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
        //create a new instance of clsuser 
        clsStaffUser aUser = new clsStaffUser();
        //get the data from the session object
        aUser = (clsStaffUser)Session["aUser"];
        //display the user name
        Response.Write("Logged in as: " + aUser.UserName);
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

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted 
        Int32 StaffId;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            StaffId= Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffId"] = StaffId;
            //redirect to the delete page 
            Response.Redirect("StaffManagementSystemConfirmDelete.aspx");
        }
        else//if no record has been selected 
        {
            //display an error message 
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void Btnfilter_Click(object sender, EventArgs e)
    {
        //create an instance of the staff collection object
        clsStaffCollection aStaff =new clsStaffCollection();
        //retrieve the value of the satary from the presentation layer 
        Int32 salary =Convert.ToInt32(Salarytext.Text);
        aStaff.ReportBySalary(salary);
        //set the data source to the list of staff in the collection
        lstStaffList.DataSource=aStaff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        //set the name of the field to display
        lstStaffList.DataTextField = "StaffName";
        lstStaffList.DataBind();
    }

    protected void BtnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the staff object 
        clsStaffCollection aStaff=new clsStaffCollection();
        //set an empty string
       
        //clear any existing filter totidy up the interface
        Salarytext.Text = "";
        //set the data source to the list of staff in the collection
        lstStaffList.DataSource = aStaff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        //set the name of the field to display
        lstStaffList.DataTextField = "StaffName";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void Btnmenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void Btnview_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffManagementSystemViewer.aspx");
    }
}