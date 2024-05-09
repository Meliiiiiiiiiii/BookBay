using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IdentityModel.Protocols.WSTrust;
using System.Web.UI.HtmlControls;

public partial class _1Viewer : System.Web.UI.Page
{
    public class Order
    {
        private int order_ID;
        private int customer_ID;
        private int book_ID;
        private string order_Date;
        private double order_Price;
        private string order_Statut;

        public int Order_ID
        {
            get { return order_ID; }
            set { order_ID = value; }
        }

        public int Customer_ID
        {
            get { return customer_ID; }
            set { customer_ID = value; }
        }
        public int Book_ID
        {
            get { return book_ID; }
            set { book_ID = value; }
        }

        public string Order_Date
        {
            get { 
                string[] listOrderDate = order_Date.Split(' ');
                return listOrderDate[0]; 
            }
            set { order_Date = value; }
        }

        public double Order_Price
        {
            get { return order_Price; }
            set { order_Price = value; }
        }

        public string Order_Statut
        {
            get { return order_Statut; }
            set { order_Statut = value; }
        }
    }
    
    public class Receipt
    {
        private int ID;
        private int orderID;
        private string transation;
        private double tax;
        private string paymentMethod;
        private double totalPrice;
        private string createdAt;

        public Receipt(int Rcpt_ID, int OrderID, string Rcpt_Tsn, double Rcpt_Tax, string Rcpt_PM , double Rcpt_TotalP, string Rcpt_CreatedAT)
        {
            ID = Rcpt_ID;
            orderID = OrderID;
            transation = Rcpt_Tsn;
            tax = Rcpt_Tax;
            paymentMethod = Rcpt_PM;
            totalPrice = Rcpt_TotalP;
            createdAt = Rcpt_CreatedAT;
        }

        public Receipt(int OrderID, double Rcpt_Tax, string Rcpt_PM, double Rcpt_TotalP)
        {
            orderID = OrderID;
            tax = Rcpt_Tax;
            paymentMethod = Rcpt_PM;
            totalPrice = Rcpt_TotalP;
        }

        public int GetID
        {
            get { return ID; }
        }

        public int GetOrderID
        {
            get { return orderID; }
        }

        public string GetTransaction
        {
            get { return transation; }
        }

        public double GetTax
        {
            get { return tax; }
        }

        public string GetPaymentMethod
        {
            get { return paymentMethod; }
        }

        public double GetTotalPrice
        { 
            get { return totalPrice; } 
        }

        public string GetCreatedAt
        {
            get
            {
                string[] listCreatedAt = createdAt.Split(' ');
                return listCreatedAt[0];
            }
        }
    }

    public static List<Order> GetAllOrders()
    {            
        var OrderArray = new List<Order>();
        SqlCommand cmd;
        SqlDataReader dataReader;
        var conn = DatabaseHelper.GetConnection();
        string sql = "select * from dbo.OrderTable;";
        try
        {

            cmd = new SqlCommand(sql, conn);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Order order = new Order();
                order.Order_ID = Convert.ToInt32(dataReader.GetValue(0));
                order.Customer_ID = Convert.ToInt32(dataReader.GetValue(1));
                order.Book_ID = Convert.ToInt32(dataReader.GetValue(2));
                order.Order_Date = Convert.ToString( dataReader.GetValue(3));
                order.Order_Price = Convert.ToDouble( dataReader.GetValue(4));
                order.Order_Statut = Convert.ToString( dataReader.GetValue(5));
                OrderArray.Add(order);
            }
            dataReader.Close();
            
            return OrderArray;
        }
        catch(Exception ex) 
        {
            Console.WriteLine(ex.Message); 
            return null;
        }
        finally
        {
            if(conn != null)
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }

    public static List<Receipt> GetAllReceipts()
    {
        List<Receipt> receipts = new List<Receipt>();
        SqlCommand cmd;
        SqlDataReader dataReader;
        SqlConnection conn = DatabaseHelper.GetConnection();
        string sql = "select * from dbo.ReceiptTable;";
        try
        {
            cmd = new SqlCommand(sql, conn);
            dataReader = cmd.ExecuteReader();
            while(dataReader.Read()) {
                Receipt receipt = new Receipt(
                   Convert.ToInt32( dataReader.GetValue(0)),
                   Convert.ToInt32(dataReader.GetValue(1)),
                   Convert.ToString(dataReader.GetValue(2)),
                   Convert.ToDouble(dataReader.GetValue(3)),
                   Convert.ToString(dataReader.GetValue(4)),
                   Convert.ToDouble(dataReader.GetValue(5)),
                   Convert.ToString(dataReader.GetValue(6))
                    );
                receipts.Add( receipt );
            }
            dataReader.Close();
            return receipts;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
        finally
        {
            if(conn != null)
            {
                conn.Close();
                conn.Dispose();   
            }
        }
    }

    // creating a new Customize structure BoolString
    public struct BoolString
    {
        public bool BoolValue { get; set; }
        public string StringValue { get; set; }
    }


    // creating a function that creates a receipt
    public static BoolString CreateReceipt(Receipt receipt)
    {
        bool status = true;
        string message = "";
        SqlCommand cmd;
        SqlConnection conn = DatabaseHelper.GetConnection();
        string sqlQuery = "INSERT INTO dbo.ReceiptTable (Order_ID,Receipt_Tax,Receipt_PaymentMethod,Receipt_TotalPrice) VALUES  (@OrderID, @Rcpt_Tax, @Rcpt_PM, @Rcpt_TotalP);";
        try
        {
            cmd = new SqlCommand(sqlQuery, conn);

            cmd.Parameters.AddWithValue("@OrderID",receipt.GetOrderID);
            cmd.Parameters.AddWithValue("@Rcpt_Tax", receipt.GetTax );
            cmd.Parameters.AddWithValue("@Rcpt_PM", receipt.GetPaymentMethod);
            cmd.Parameters.AddWithValue("@Rcpt_TotalP", receipt.GetTotalPrice);

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                status = true;
                message = "Sucessfull in creating Receipt";
                return new BoolString { BoolValue = status, StringValue = message };
            }
            else
            {
                status = false;
                message = "Could not create Reiceipt";
                return new BoolString { BoolValue = status, StringValue = message };
            }
        }
        catch(Exception ex)
        {
            message = ex.Message;
            status = false;
            return new BoolString { BoolValue = status, StringValue = message };
        }

        finally
        {
            if(conn != null) { 
                conn.Close( );
                conn.Dispose();
            }
        }
    }

    public class DatabaseHelper
    {
        /*        private static readonly string connectionString = @"Data Source=v00egd00002l.lec-admin.dmu.ac.uk;" +
        "Initial Catalog=p2790115;" +
        "User id=p2790115;" +
        "TheLibraryTeam123;";*/
        private static readonly string connectString = @"Data Source=v00egd00002l.lec-admin.dmu.ac.uk; Initial Catalog=p2790115;User ID=p2790115;Password=TheLibraryTeam123";

        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectString);
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

        //Receipt Receipt = new Receipt();

        List<Order> OrderList = GetAllOrders();
        List<Receipt> ReceiptList = GetAllReceipts();

        HtmlGenericControl tBody = (HtmlGenericControl)FindControl("tableBody");





        if (!String.IsNullOrEmpty(Request.QueryString["OrderID"]))
        {
            if (tBody != null)
            {
                
            }

        }   
    }
    
    protected void createReceiptBtn_Click(object sender, EventArgs e)
    {
        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Hello from C#!');", true);
    }
}