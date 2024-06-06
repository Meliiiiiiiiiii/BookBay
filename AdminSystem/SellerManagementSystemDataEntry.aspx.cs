using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    int SellerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        SellerID = Convert.ToInt32(Session["SellerId"]);
        if(IsPostBack == false)
        {
            if(SellerID != -1)
            {
                DisplaySeller();
            }
        }
    }

    void DisplaySeller()
    {
        clsSellerCollection Sellers = new clsSellerCollection();
        Sellers.ThisSeller.Find(SellerID);
        txtSellerID.Text = Sellers.ThisSeller.SellerID.ToString();
        txtFirstName.Text = Sellers.ThisSeller.FirstName.ToString();
        txtLastName.Text = Sellers.ThisSeller.LastName.ToString();
        txtCommission.Text = Sellers.ThisSeller.Commission.ToString();
        txtSales.Text = Sellers.ThisSeller.Sales.ToString();
        txtCreatedAt.Text = Sellers.ThisSeller.CreatedAt.ToString();
        boxIsActive.Checked = Sellers.ThisSeller.IsActive;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        int sellerID = Convert.ToInt32(txtSellerID.Text);
        string firstName = Convert.ToString(txtFirstName.Text);
        string lastName = Convert.ToString(txtLastName.Text);
        float commission = Convert.ToSingle(txtCommission.Text);
        float Sales = Convert.ToSingle(txtSales.Text);
        DateTime createdAt = Convert.ToDateTime(txtCreatedAt.Text);
        Boolean IsActive = Convert.ToBoolean(boxIsActive.Checked);

        clsSeller seller = new clsSeller();

        string response = "";

        response += seller.Valid(sellerID, firstName, lastName, IsActive, commission, Sales, createdAt.ToString());
    
        if(response == "")
        {
            seller.SellerID = sellerID;
            seller.FirstName = firstName;
            seller.LastName = lastName;
            seller.Commission = commission;
            seller.Sales = Sales;
            seller.CreatedAt = createdAt;
            seller.IsActive = IsActive;

            clsSellerCollection sellerCollection = new clsSellerCollection();

            if(SellerID == -1)
            {
                sellerCollection.ThisSeller = seller;
                sellerCollection.Add();
            }
            else
            {
                sellerCollection.ThisSeller.Find(SellerID);
                sellerCollection.ThisSeller = seller;
                sellerCollection.Update();
            }
            Response.Redirect("SellerManagementSystemList.aspx");
        }
        else
        {
            lblError.Visible = true;
            lblError.Text = response;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        int sellerID = Convert.ToInt32(txtSellerID.Text);

        clsSeller seller = new clsSeller();

        bool result = seller.Find(sellerID);

        if (result)
        {
            txtSellerID.Text = Convert.ToString(seller.SellerID);
            txtFirstName.Text = seller.FirstName;
            txtLastName.Text = seller.LastName;
            txtCommission.Text = Convert.ToString((float) (seller.Commission));
            txtSales.Text = Convert.ToString((float) (seller.Sales));
            txtCreatedAt.Text = Convert.ToString(seller.CreatedAt);
            boxIsActive.Checked = seller.IsActive;
        }
        else
        {
            lblError.Text = "User ID Not Find";
        }
    }
}