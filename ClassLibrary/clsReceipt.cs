using System;

namespace ClassLibrary
{
    public class clsReceipt
    {
        private int id;
        private int orderID;
        private string transaction;
        private float tax;
        private string paymentMethod;
        private float totalPrice;
        private DateTime createdAt;

        public int ID { get { return id; } set { id = value; } }
        public int OrderID { get { return orderID; } set { orderID = value; } }
        public string Transation { get { return transaction; } set { transaction = value; } }
        public float Tax { get { return tax; } set { tax = value; } }
        public string PaymentMethod { get { return paymentMethod; } set { paymentMethod = value; } }
        public float TotalPrice { get { return totalPrice; } set { totalPrice = value; } }
        public DateTime CreatedAt { get { return createdAt; } set { createdAt = value; } }
        public string Valid(int ReceiptId, int OrderId, string Transaction,float Tax, string PaymentMethod, float TotalPrice, string CreatedAt)
        {
            // receipt validation
            if(ReceiptId<0)
            {
                return "Receipt cannot be a negative value";
            }
            else if(ReceiptId > 2147483647)
            {
                return "ReceiptID is out of boundary";
            }

            // order validation

            if (OrderId < 0)
            {
                return "order cannot be a negative value";
            }
            else if (OrderId > 2147483647)
            {
                return "order is out of boundary";
            }

            // transaction validation 

            if(Transaction.Length < 36)
            {
                return "transaction should not be less than 36";
            }
            else if(Transaction.Length > 36)
            {
                return "transaction should not be greater than 36";
            }

            // Tax validation
            if(Tax < 0)
            {
                return "the tax value should positive";
            }
            
            // PaymentMethod validation

            if(PaymentMethod == "")
            {
                return "payment Method cannot be empty";
            }
            else if(!(PaymentMethod.Length == 4 || PaymentMethod.Length == 12 || PaymentMethod.Length == 6))
            {
                return "payment Method name is unproper";
            }

            // TotalPrice validation

            if(TotalPrice < 0)
            {
                return "the TotalPrice value should positive";
            }

            // CreatedAt validation

            try
            {
                DateTime currentDate = DateTime.Now.Date;
                DateTime dateTime = Convert.ToDateTime(CreatedAt);
                if (dateTime < currentDate)
                {
                    return "The date cannot be in the past";
                }
                else if (dateTime > currentDate)
                {
                    return "The date cannot be in the future";
                }
            }
            catch
            {
                return "The date was not a valid date";
            }
            return "";
        }
        public bool Find(int ReceiptID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ReceiptId" , ReceiptID);
            DB.Execute("sproc_tblReceipt_FilterByReceiptId");
            if (DB.Count == 1)
            {
                ID = Convert.ToInt32(DB.DataTable.Rows[0]["Receipt_ID"]);
                OrderID = Convert.ToInt32(DB.DataTable.Rows[0]["Order_ID"]);
                Transation = Convert.ToString(DB.DataTable.Rows[0]["Receipt_Transaction"]);
                Tax = (float)Convert.ToDouble(DB.DataTable.Rows[0]["Receipt_Tax"]);
                PaymentMethod = Convert.ToString(DB.DataTable.Rows[0]["Receipt_PaymentMethod"]);
                TotalPrice = (float)Convert.ToDouble(DB.DataTable.Rows[0]["Receipt_TotalPrice"]);
                CreatedAt = Convert.ToDateTime(DB.DataTable.Rows[0]["Receipt_createdAt"]);
                return true;
            }
            else
            {
                return false;
            }
        }
/*        
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Tax", this.tax );
            DB.AddParameter("@PaymentMethod", this.paymentMethod );
            DB.AddParameter("@TotalPrice", this.totalPrice);
            DB.AddParameter("@OrderID", this.orderID);
            return DB.Execute("sproc_tblReceipt_Insert");
        }*/

    }
}