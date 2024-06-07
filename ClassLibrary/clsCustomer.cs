using System;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustomerId;
        private string mName;
        private Boolean mActive;
        private string mPhone;
        private string mAddress;
        private string mCity;
        private DateTime mRegisterDate;

        public Int32 CustomerId
        {
            get { return mCustomerId; }

            set { mCustomerId = value; }
        }

        public string Name
        {
            get { return mName; }

            set { mName = value; }
        }

        public Boolean Active
        {
            get { return mActive; }

            set { mActive = value; }
        }

        public string Phone
        {
            get { return mPhone; }

            set { mPhone = value; }
        }

        public string Address

        {
            get { return mAddress; }

            set { mAddress = value; }
        }
        public string City
        {
            get { return mCity; }

            set { mCity = value; }
        }
        public DateTime RegisterDate

        {
            get { return mRegisterDate; }

            set { mRegisterDate = value; }
        }



        /************** FIND METHOD**********/
        public bool Find(int CustomerId)
        {
            //create a instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Customer_Id to search for 
            DB.AddParameter("@CustomerId", CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_CustomerTable_FilterByCustomer_Id");
            //if one record is found(there should be either one or zero)
            if (DB.Count == 1)
            {
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["Customer_ID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Customer_Name"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Customer_Active"]);
                mPhone = Convert.ToString(DB.DataTable.Rows[0]["Customer_Phone"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Customer_Address"]);
                mCity = Convert.ToString(DB.DataTable.Rows[0]["Customer_City"]);
                mRegisterDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Customer_Register_Date"]);

                //return that everything worked OK
                return true;
            }
            else
            {
                //return false indicating an problem 
                return false;
            }
        }

        public string Valid(string Name, string Phone, string Address, string City, string RegisterDate)
        {
            //create a string variable to store the error
            String Error = "";
            //// Validation of Name
            //if the name is blank 
            if (Name.Length == 0)
            {
                //record the error
                Error += "Name cannot be blank";
            }

            //if the name is longer than 30 characters

            if (Name.Length > 30)
            {
                Error += "Name cannot be longer than 30 characters:";
            }




            // Validation of Phone

            if (Phone.Length == 0)
            {
                //record the error
                Error += "Phone cannot be blank";
            }

            //if the name is longer than 30 characters

            if (Phone.Length > 10)
            {
                Error += "Phone cannot be longer than 10 characters:";
            }
            if (Phone.Length < 8)
                {
                    Error += "Phone cannot be shorter than 8 characters:";
                }
            // Validating Address


            if (Address.Length == 0)
            {
                //record the error
                Error += "Address cannot be blank";
            }

            //if the name is longer than 30 characters

            if (Address.Length > 60)
            {
                Error += "Address cannot be longer than 30 characters:";
            }

            // Validating City
            if (City.Length == 0)
            {
                //record the error
                Error += "Address cannot be blank";
            }

            //if the name is longer than 30 characters

            if (City.Length > 20)
            {
                Error += "Address cannot be longer than 30 characters:";
            }
            //if (string.IsNullOrEmpty(City))
            //    return "City CANNOT BE NULL OR EMPTYA";

            //if (City.Length < 1 || City.Length > 20)
            //    return "City MUST BE BETWEEN (1-36) ONE TO THIRTY-SIX CHARACTERS";


            // Validation of RegisterDate
            //temperory variable for data values
            DateTime DateTemp;

            try
            {
                DateTemp = Convert.ToDateTime(RegisterDate);

                //check to see if the less than today's data 
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be past";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error += "The date cannot be future";
                }
            }
            catch
            {
                Error += "The date was not a valid date";
            }
            return Error;
            //public string Valid(string name, string phone, string address, string city, string registerDate)
            //{
            //    throw new NotImplementedException();
            //}
        }
    }
}

