using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StaffId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of staff to be processed
        StaffId = Convert.ToInt32(Session["StaffId"]);
        //if the first time the page is displyaed
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StaffId != -1)
            {
                //display the current data of the record
                DisplayStaff();
            }
        }
    }

    protected void OKbtn_Click(object sender, EventArgs e)
    {
       //create anew instance of clsStaff
       clsStaff aStaff = new clsStaff();
       
        //capture the name
        String Name = NameIDtxt.Text;
        //capture the email
        String Email = Emailtxt.Text;
        //capture the phone
        String Phone = Phonetxt.Text;
        //capture the hire date
        String HireDate = hiredatetxt.Text;
        //capture the salary
        int Salary = Convert.ToInt32(salarytxt.Text);
        //capture the is admin
        Boolean IsAdmin = Convert.ToBoolean(IsAdmintxt.Text);
        //variable to store any error messages
        String Error = "";
        //validate data
        Error = aStaff.Valid(Name, Email, Phone, HireDate, IsAdmin, Salary);
        if(Error=="")
        {
            //capture the staff Id
            aStaff.StaffID = StaffId;
            //capture the staff name
            aStaff.StaffName = Name;
            //capture the staff email
            aStaff.StaffEmail = Email;
            //capture the staff phone
            aStaff.StaffPhone = Phone;
            //capture the staff HireDate
            aStaff.StaffHireDate =Convert.ToDateTime(HireDate);
            //capture the staff Salary
            aStaff.StaffSalary = Salary;
            //capture the staff Is Admin
            aStaff.StaffIsAdmin = IsAdmin;
            //create a new instance of the staff collection
            clsStaffCollection StaffList = new clsStaffCollection();
            //if this is a new record
            if(StaffId==-1)
            {
                //set thisStaff property
                StaffList.ThisStaff=aStaff;
                //add the new record
                StaffList.Add();
            }
            else
            {
                StaffList.ThisStaff.Find(StaffId);
                StaffList.ThisStaff=aStaff;
                StaffList.Update();
            }
            
            //navigate to the view page
            Response.Redirect("StaffManagementSystemList.aspx");
        }
        else
        {
            //display an error message
            lblError.Text = Error;
        }
        
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
    void DisplayStaff()
    {
        //create an instance of the staff collection
        clsStaffCollection Staffinfo = new clsStaffCollection();
        //find the record to update 
        Staffinfo.ThisStaff.Find(StaffId);
        //display the data for the record
        StaffIDtxt.Text = Staffinfo.ThisStaff.StaffID.ToString();
        NameIDtxt.Text = Staffinfo.ThisStaff.StaffName;
        Emailtxt.Text = Staffinfo.ThisStaff.StaffEmail;
        Phonetxt.Text = Staffinfo.ThisStaff.StaffPhone;
        hiredatetxt.Text = Staffinfo.ThisStaff.StaffHireDate.ToString();
        IsAdmintxt.Text = Staffinfo.ThisStaff.StaffIsAdmin.ToString();
        salarytxt.Text = Staffinfo.ThisStaff.StaffSalary.ToString();

    }

    protected void Cancelbtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffManagementSystemList.aspx");
    }
}