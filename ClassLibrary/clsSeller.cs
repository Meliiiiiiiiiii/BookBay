using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsSeller
    {
        private int sellerId;
        private string firstName;
        private string lastName;
        private Boolean isActive;
        private float commission;
        private float sales;
        private DateTime createdAt;

        public int SellerID { get { return sellerId; } set { sellerId = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public Boolean IsActive { get { return isActive; } set { isActive = value; } }
        public float Commission { get { return commission; } set { commission = value; } }
        public float Sales { get { return sales; } set { sales = value; } }
        public DateTime CreatedAt { get { return createdAt; } set { createdAt = value; } }

        public string Valid(int id, string firstname, string lastname,Boolean isActive, float commission, float sales, string createdAt)
        {
            if(id <= 0)
            {
                return "SellerID cannot be 0 or negative number ";
            }
            // Validate FirstName
            if (string.IsNullOrEmpty(firstName))
                return "Error message";
            if (firstName.Length < 1 || firstName.Length > 50)
                return "Error message";
            // Validate LastName
            if (string.IsNullOrEmpty(lastName))
                return "Error message";
            if (lastName.Length < 1 || lastName.Length > 50)
                return "Error message";
            // Validate Commission
            if (commission < 0.00f || commission > 100.00f)
                return "Error message";
            if (commission != Math.Round(commission, 2))
                return "Error message";
            // Validate Sales
            if (sales < 0.00f || sales > 1000000.00f)
                return "Error message";
            if (sales != Math.Round(sales, 2))
                return "Error message";
            try
            {
                DateTime currentDate = DateTime.Now.Date;
                DateTime dateTime = Convert.ToDateTime(createdAt);
                if (dateTime < currentDate)
                {
                    return "The date cannot be in the Past";
                }
                else if(dateTime > currentDate)
                {
                    return "The date cannot be in the future";
                }
            }
            catch
            {
                return " date was not a valid date";
            }
            return "";
        }
    
        public bool Find(int SellerID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SellerId", SellerID);
            DB.Execute("sproc_tblSeller_FilterBySellerId");
            if(DB.Count == 1)
            {
                this.SellerID = Convert.ToInt32(DB.DataTable.Rows[0]["Seller_ID"]);
                FirstName = Convert.ToString(DB.DataTable.Rows[0]["Seller_FirstName"]);
                LastName = Convert.ToString(DB.DataTable.Rows[0]["Seller_LastName"]);
                IsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Seller_IsActive"]);
                Commission = (float)Convert.ToDouble(DB.DataTable.Rows[0]["Seller_Commission"]);
                Sales = (float)Convert.ToDouble(DB.DataTable.Rows[0]["Seller_Sales"]);
                CreatedAt = Convert.ToDateTime(DB.DataTable.Rows[0]["Seller_CreatedAt"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
