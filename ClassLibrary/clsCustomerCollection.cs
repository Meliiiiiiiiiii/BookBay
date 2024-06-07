using System;
using System.Collections.Generic;
using System.Reflection;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //Private Data members
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();
        public clsCustomerCollection()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_CustomerTable_SelectAll");
            PopulateArray(DB);

        }

        void PopulateArray(clsDataConnection DB)
        {
            int index = 0;
            int recordCount = 0;

            recordCount = DB.Count;

            mCustomerList = new List<clsCustomer>();

            while (index < recordCount)
            {
                clsCustomer customer = new clsCustomer();
                customer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[index]["Customer_Id"]);
                customer.Name = Convert.ToString(DB.DataTable.Rows[index]["Customer_Name"]);
                customer.Active = Convert.ToBoolean(DB.DataTable.Rows[index]["Customer_Active"]);
                customer.Phone = Convert.ToString(DB.DataTable.Rows[index]["Customer_Phone"]);
                customer.Address = Convert.ToString(DB.DataTable.Rows[index]["Customer_Address"]);
                customer.City = Convert.ToString(DB.DataTable.Rows[index]["Customer_City"]);
                customer.RegisterDate = Convert.ToDateTime(DB.DataTable.Rows[index]["Customer_Register_Date"]);
                mCustomerList.Add(customer);
                index++;
            }
        }

        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {

            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@Active", mThisCustomer.Active);
            DB.AddParameter("@Phone", mThisCustomer.Phone);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@City", mThisCustomer.City);
            DB.AddParameter("@RegisterDate", mThisCustomer.RegisterDate);
            return DB.Execute("sproc_CustomerTable_Insert");
        }
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@Active", mThisCustomer.Active);
            DB.AddParameter("@Phone", mThisCustomer.Phone);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@City", mThisCustomer.City);
            DB.AddParameter("@RegisterDate", mThisCustomer.RegisterDate);
            DB.Execute("sproc_CustomerTable_Update");
        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Customer_Id", mThisCustomer.CustomerId);
            DB.Execute("sproc_CustomerTable_Delete");
        }

        public void Filter(string RegisterDate)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Register_Date", RegisterDate);
            DB.Execute("sproc_CustomerTable_FilterByRegisterDate");
            PopulateArray(DB);
        }
    }
}
