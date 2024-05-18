using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void OKbtn_Click(object sender, EventArgs e)
    {
       //create anew instance of clsStaff
       clsStaff aStaff = new clsStaff();
        //capture the name
        aStaff.StaffName = NameIDtxt.Text;
        //capture the email
        aStaff.StaffEmail = Emailtxt.Text;
        //capture the phone
        aStaff.StaffPhone = Phonetxt.Text;
        //capture the hire date
        aStaff.StaffHireDate = Convert.ToDateTime(DateTime.Now);
        //capture the salary
        aStaff.StaffSalary = Convert.ToInt32(salarytxt.Text);
        //capture the is admin
        aStaff.StaffIsAdmin = Convert.ToBoolean(IsAdmintxt.Text);
        //store staff in the session object
        Session["aStaff"]=aStaff;
        //navigate to the view page
        Response.Redirect("StaffManagementSystemViewer.aspx");
    }





    protected void Findbtn_Click1(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsStaff aStaff = new clsStaff();
        //create a variable to store the primary key
        Int32 StaffId;
        //create a variable to store the result of the find operation
        Boolean Found = false;  
        //get the primary key entered by the user
        StaffId=Convert.ToInt32(StaffIDtxt.Text);
        //find the record 
        Found = aStaff.Find(StaffId);
        //if found
        if(Found == true)
        {
            //display the values of the properties in the form
            StaffIDtxt.Text = aStaff.StaffID.ToString();
            NameIDtxt.Text = aStaff.StaffName;
            Emailtxt.Text = aStaff.StaffEmail;
            Phonetxt.Text = aStaff.StaffPhone;
            hiredatetxt.Text = aStaff.StaffHireDate.ToString();
            IsAdmintxt.Text = aStaff.StaffIsAdmin.ToString();
            salarytxt.Text = aStaff.StaffSalary.ToString();


        }
    }
}