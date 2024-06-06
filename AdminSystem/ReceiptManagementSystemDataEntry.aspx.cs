
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_DataEntry : System.Web.UI.Page
{
    int ReceiptID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ReceiptID = Convert.ToInt32(Session["ReceiptId"]);
        if(IsPostBack ==  false)
        {
            if(ReceiptID != -1)
            {
                DisplayReceipt();
            }
        }
    }

    void DisplayReceipt()
    {
        clsReceiptCollection Receipts = new clsReceiptCollection();
        Receipts.ThisReceipt.Find(ReceiptID);
        txtReceiptID.Text = Receipts.ThisReceipt.ID.ToString();
        txtOrderID.Text = Receipts.ThisReceipt.OrderID.ToString();
        txtPaymentMethod.Text = Receipts.ThisReceipt.PaymentMethod.ToString();
        txtTransaction.Text = Receipts.ThisReceipt.Transation.ToString();
        txtTotalPrice.Text = Receipts.ThisReceipt.TotalPrice.ToString();
        txtTax.Text = Receipts.ThisReceipt.Tax.ToString();
        txtCreatedAt.Text = Receipts.ThisReceipt.CreatedAt.ToString();
    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        int receiptID = Convert.ToInt32( txtReceiptID.Text);
        int OrderID = Convert.ToInt32( txtOrderID.Text);
        string transaction = txtTransaction.Text;
        float Tax = (float)Convert.ToDouble(txtTax.Text);
        string PaymentMethod = txtPaymentMethod.Text;
        float TotalPrice = (float)Convert.ToDouble(txtTotalPrice.Text);
        string createdAt = txtCreatedAt.Text;

        clsReceipt receipt = new clsReceipt();

      


        string response = "";

        response += receipt.Valid(receiptID,OrderID, transaction, Tax, PaymentMethod, TotalPrice, createdAt);

        if(response == "")
        {
            receipt.ID = ReceiptID;
            receipt.OrderID = OrderID;
            receipt.Transation = transaction;
            receipt.PaymentMethod = PaymentMethod;
            receipt.Tax = Tax;
            receipt.TotalPrice = TotalPrice;
            receipt.CreatedAt = Convert.ToDateTime(createdAt);

            clsReceiptCollection receiptCollection = new clsReceiptCollection();
            
            if(ReceiptID == -1)
            {
                receiptCollection.ThisReceipt = receipt;

                receiptCollection.Add();
            }
            else
            {
                receiptCollection.ThisReceipt.Find(ReceiptID);
                receiptCollection.ThisReceipt = receipt;
                receiptCollection.Update();
            }



            Response.Redirect("ReceiptManagementSystemList.aspx");
        }
        else
        {
            lblError.Visible = true; 
            lblError.Text = response;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        int receiptID = Convert.ToInt32( txtReceiptID.Text);

        clsReceipt receipt = new clsReceipt();

        bool result = receipt.Find(receiptID);
        if (result)
        {
            txtReceiptID.Text = Convert.ToString(receipt.ID); 
            txtOrderID.Text = Convert.ToString(receipt.OrderID);
            txtTransaction.Text = receipt.Transation;
            txtTax.Text = Convert.ToString(receipt.Tax);
            txtPaymentMethod.Text = receipt.PaymentMethod;
            txtTotalPrice.Text = Convert.ToString(receipt.TotalPrice);
            txtCreatedAt.Text = Convert.ToString(receipt.CreatedAt);
        }
        else
        {
            lblError.Text = "User ID Not Find";
        }
    }
}