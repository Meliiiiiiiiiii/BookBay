﻿using System;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;

public partial class _1Viewer : System.Web.UI.Page
{
    public class Receipt
    {

        private int orderID;
        private float tax;
        private string paymentMethod;
        private float totalPrice;

        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }
        public float Tax
        {
            get { return tax; }
            set { tax = value; }
        }

        public string PaymentMethod
        {
            get { return paymentMethod; }
            set { paymentMethod = value; }
        }

        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
    }

    public class DatabaseHelper
    {
        private static readonly string connectionString = "Data Source=v00egd00002l.lec-admin.dmu.ac.uk;" +
"Initial Catalog=p2790115;" +
"User id=p2790115;" +
"TheLibraryTeam123;";

        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error connectibg to database" + e.Message);
            }
            return conn;
        }

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand cmd;


        Receipt Receipt = new Receipt();
        var open = DatabaseHelper.GetConnection();
        HtmlGenericControl tBody = (HtmlGenericControl)FindControl("tableBody");
        if (!String.IsNullOrEmpty(Request.QueryString["OrderID"]))
        {
            if (tBody != null)
            {
                
            }

        }


        

    }
}