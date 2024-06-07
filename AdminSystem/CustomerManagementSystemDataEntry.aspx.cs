using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    int CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed 
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            //if this is the not a new recod
            if (CustomerId != -1)
            {
                //display the current data
                DisplayCustomer();
            }
        }
    }

    void DisplayCustomer()
    {
        clsCustomerCollection Customer = new clsCustomerCollection();
        Customer.ThisCustomer.Find(CustomerId);
        txtCustomerId.Text = Customer.ThisCustomer.CustomerId.ToString();
        txtName.Text = Customer.ThisCustomer.Name.ToString();
        boxIsActive.Checked = Customer.ThisCustomer.Active;
        txtPhone.Text = Customer.ThisCustomer.Phone.ToString();
        txtAddress.Text = Customer.ThisCustomer.Address.ToString();
        txtCity.Text = Customer.ThisCustomer.City.ToString();
        txtRegisterDate.Text = Customer.ThisCustomer.RegisterDate.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer customer = new clsCustomer();

        int CustomerId = Convert.ToInt32(txtCustomerId.Text);
        string Name = txtName.Text;
        Boolean Active = Convert.ToBoolean(boxIsActive.Checked);
        string Phone = txtPhone.Text;
        string Address = txtAddress.Text;
        string City = txtCity.Text;
        DateTime RegisterDate = Convert.ToDateTime(txtRegisterDate.Text);



        String Error = "";
        //Validate the data
        Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());

        if (Error == "")
        {
            customer.CustomerId = CustomerId;
            customer.Name = Name;
            customer.Active = Active;
            customer.Phone = Phone;
            customer.Address = Address;
            customer.City = City;
            customer.RegisterDate = RegisterDate;

            clsCustomerCollection CustomerList = new clsCustomerCollection();

            if (CustomerId == -1)
            {
                CustomerList.ThisCustomer = customer;

                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(CustomerId);
                CustomerList.ThisCustomer = customer;
                CustomerList.Update();
            }


            Response.Redirect("CustomerManagementSystemList.aspx");

        }
        else
        {
            //Display the error message
            lblError.Visible = true;
            lblError.Text = Error;
        }
    }
  

    protected void btnFind_Click(object sender, EventArgs e)
    {

        //create instance of register
        clsCustomer customer = new clsCustomer();
        //create a variable to store the primary key
        Int32 CustomerId;

        //create a variable to store the result of the find operation
        Boolean Found = false;

        //get the primary key entered by the user
        CustomerId = Convert.ToInt32(txtCustomerId.Text);

        //find the record
        Found = customer.Find(CustomerId);

        // if found
        if (Found == true)
        {
            //display the values of the property in the form 
            txtCustomerId.Text = Convert.ToString(customer.CustomerId);
            txtName.Text = customer.Name;
            boxIsActive.Checked = customer.Active;
            txtPhone.Text = customer.Phone;
            txtAddress.Text = customer.Address;
            txtCity.Text = customer.City;
            txtRegisterDate.Text = Convert.ToString(customer.RegisterDate);
        }
    }






    protected void btnCancel_Click(object sender, EventArgs e)
    {
        
        
            Response.Redirect("CustomerManagementSystemList.aspx");
        
    }
}
