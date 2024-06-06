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
        
        //display the staff info
        StaffIDtxt.Text = aStaff.StaffID.ToString();
        NameIDtxt.Text = aStaff.StaffName;
        Emailtxt.Text = aStaff.StaffEmail;
        Phonetxt.Text = aStaff.StaffPhone;
        hiredatetxt.Text = aStaff.StaffHireDate.ToString();
        salarytxt.Text = aStaff.StaffSalary.ToString();

    }

    protected void Cancelbtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffManagementSystemList.aspx");
    }

    protected void salarytxt_TextChanged(object sender, EventArgs e)
    {

    }
}