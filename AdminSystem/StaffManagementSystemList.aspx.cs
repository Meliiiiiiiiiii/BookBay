using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if the first time the page is displyaed
        if(IsPostBack==false)
        {
            DisplayStaff();
        }
    }
    void DisplayStaff()
    {
        //create an instance of staff collection
        clsStaffCollection staffCollection = new clsStaffCollection();  
        //set the data source to list of staff in the collection
        lstStaffList.DataSource=staffCollection.StaffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "StaffName";
        lstStaffList.DataBind();
    }
}