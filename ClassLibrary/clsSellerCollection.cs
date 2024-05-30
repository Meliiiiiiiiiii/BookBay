using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsSellerCollection
    {
        List<clsSeller> mSellerList = new List<clsSeller>();
        clsSeller mThisSeller = new clsSeller();
        public clsSellerCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblSeller_SelectAll");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            int index = 0;
            int recordCount = 0;
            recordCount = DB.Count;
            mSellerList = new List<clsSeller>();
            while(index < recordCount)
            {
                clsSeller seller = new clsSeller();
                seller.SellerID = Convert.ToInt32(DB.DataTable.Rows[index]["Seller_ID"]);
                seller.FirstName = Convert.ToString(DB.DataTable.Rows[index]["Seller_FirstName"]);
                seller.LastName = Convert.ToString(DB.DataTable.Rows[index]["Seller_LastName"]);
                seller.IsActive = Convert.ToBoolean(DB.DataTable.Rows[index]["Seller_IsActive"]);
                seller.Commission = (float)Convert.ToDouble(DB.DataTable.Rows[index]["Seller_Commission"]);
                seller.Sales = (float)Convert.ToDouble(DB.DataTable.Rows[index]["Seller_Sales"]);
                seller.CreatedAt = Convert.ToDateTime(DB.DataTable.Rows[index]["Seller_CreatedAt"]);
                mSellerList.Add(seller);
                index++;
            }
        }
        public List<clsSeller> SellerList
        {
            get
            {
                return mSellerList;
            }
            set
            {
                mSellerList = value;
            }
        }
        public int Count
        {
            get
            {
                return mSellerList.Count;
            }
            set
            {

            }
        }
        public clsSeller ThisSeller
        {
            get
            {
                return mThisSeller;
            }
            set
            {
                mThisSeller = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FirstName", mThisSeller.FirstName);
            DB.AddParameter("@LastName", mThisSeller.LastName);
            DB.AddParameter("@IsActive", mThisSeller.IsActive);
            DB.AddParameter("@Commission", mThisSeller.Commission);
            DB.AddParameter("@Sales", mThisSeller.Sales);
            return DB.Execute("sproc_tblSeller_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SellerId", mThisSeller.SellerID);
            DB.AddParameter("@FirstName", mThisSeller.FirstName);
            DB.AddParameter("@LastName", mThisSeller.LastName);
            DB.AddParameter("@IsActive", mThisSeller.IsActive);
            DB.AddParameter("@Commission", mThisSeller.Commission);
            DB.AddParameter("@Sales", mThisSeller.Sales);
            DB.AddParameter("@CreatedAt", mThisSeller.CreatedAt);
            DB.Execute("sproc_tblSeller_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SellerId", mThisSeller.SellerID);
            DB.Execute("sproc_tblSeller_Delete");
        }

        public void ReportByFirstName(string firstname)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FirstName", firstname);
            DB.Execute("sproc_tblSeller_FilterByFirstName");
            PopulateArray(DB);
        }
    }
}
