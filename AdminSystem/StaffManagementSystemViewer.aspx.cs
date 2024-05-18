using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff aStaff = new clsStaff();
        //get the data from the session object
        aStaff = (clsStaff)Session["astaff"];
        //display the staff info
        Response.Write(aStaff.StaffName);
        Response.Write(aStaff.StaffEmail);
        Response.Write(aStaff.StaffPhone);
        Response.Write(aStaff.StaffHireDate);
        Response.Write(aStaff.StaffSalary);
        Response.Write(aStaff.StaffIsAdmin);

    }
}