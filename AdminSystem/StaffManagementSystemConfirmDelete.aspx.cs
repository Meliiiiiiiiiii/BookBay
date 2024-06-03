using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffId = Convert.ToInt32(Session["StaffId"]);

    }

    protected void YesBtn_Click(object sender, EventArgs e)
    {
        //create a new instance of the staff collection class
        clsStaffCollection Staffinfo = new clsStaffCollection();
        //find the record to delete 
        Staffinfo.ThisStaff.Find(StaffId);
        //delete the record
        Staffinfo.Delete();
        //redirect back to the main page
        Response.Redirect("StaffManagementSystemList.aspx");

    }

    protected void NoBtn_Click(object sender, EventArgs e)
    {
        //redirect back to the main page 
        Response.Redirect("StaffManagementSystemList.aspx");
    }
}