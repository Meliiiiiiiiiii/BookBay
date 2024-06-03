﻿using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Loginbtn_Click(object sender, EventArgs e)
    {
        //create an instance of the staff user class
        clsStaffUser aUser = new clsStaffUser();
        //create the variables to store the username and password
        string UserName = Usernametxt.Text;
        string Password = Passwordtxt.Text;
        //create a variable to store the result of the find user operation
        Boolean Found = false;
        //get the username entered by the user 
        UserName = Convert.ToString(Usernametxt.Text);
        //get the password entered by the user
        Password = Convert.ToString(Passwordtxt.Text);
        //find the record
        Found = aUser.FindUser(UserName, Password);
        //if username and or password is empty
        if (Usernametxt.Text == "")
        {
            //record the error 
            errorlbl.Text = "Enter a username";
        }
        else if (Passwordtxt.Text == "")
        {
            //record an error 
            errorlbl.Text = "Enter a password";

        }
        //if found
        else if (Found == true)
        {
            //redirect to the List Page
            Response.Redirect("StaffManagementSystemList.aspx");
        }
        else if (Found == false)
        {
            //record the error
            errorlbl.Text = "Login details are incorrect. Please try again";
        }

    }
}