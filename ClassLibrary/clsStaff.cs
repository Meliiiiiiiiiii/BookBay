using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        // Class Attributes
        private int staffID;
        private string staffName;
        private string staffEmail;
        private string staffPhone;
        private DateTime staffHireDate;
        private bool staffIsAdmin;
        private int staffSalary;

        // Properties
        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public string StaffName
        {
            get { return staffName; }
            set { staffName = value; }
        }

        public string StaffEmail
        {
            get { return staffEmail; }
            set { staffEmail = value; }
        }

        public string StaffPhone
        {
            get { return staffPhone; }
            set { staffPhone = value; }
        }

        public DateTime StaffHireDate
        {
            get { return staffHireDate; }
            set { staffHireDate = value; }
        }

        public int StaffSalary
        {
            get { return staffSalary; }
            set { staffSalary = value; }
        }

        public bool StaffIsAdmin
        {
            get { return staffIsAdmin; }
            set { staffIsAdmin = value; }
        }

        // Find method to search for a staff member by ID
        public bool Find(int staffId)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the staff ID to search for
            DB.AddParameter("@StaffId", staffId);
            // Execute the stored procedure
            DB.Execute("sproc_StaffTable_FilterByStaffId");

            // If one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                staffID = Convert.ToInt32(DB.DataTable.Rows[0]["Staff_Id"]);
                staffName = Convert.ToString(DB.DataTable.Rows[0]["Staff_Name"]);
                staffEmail = Convert.ToString(DB.DataTable.Rows[0]["Staff_Email"]);
                staffPhone = Convert.ToString(DB.DataTable.Rows[0]["Staff_Phone"]);
                staffHireDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Staff_Hire_Date"]);
                staffIsAdmin = Convert.ToBoolean(DB.DataTable.Rows[0]["Staff_Is_Admin"]);
                staffSalary = Convert.ToInt32(DB.DataTable.Rows[0]["Staff_Salary"]);

                // Return that everything worked ok
                return true;
            }
            else
            {
                // Return false indicating there is a problem
                return false;
            }
        }

        public string Valid(int staffId, string staffName, string staffEmail, string staffPhone, string staffHireDate,bool staffIsAdmin, int staffSalary)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary
            DateTime DateTemp;
            //if the StaffName is blank
            if (staffName.Length==0)
            {
                //record the error
                Error = Error + "The staff name may not be blank";
            }
            //if the staff name is greater than 40 characters
            if(staffName.Length>40)
            {
                //record the error
                Error = Error + "The staff name must be less than 40 characters";
            }
            //create an instance of datetime to compare with datetemp
            DateTime DateComp = DateTime.Now.Date;
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(staffHireDate);
                //check to see if the date is less than today's date
                if(DateTemp<DateComp)
                {
                    Error = Error + "The date cannot be in the past ";
                }
                //check to see if the date is greater than today's date
                if(DateTemp>DateComp) {
                    //record the error
                    Error = Error + "The date cannot be in the future";
                }
            }
            catch
            {
                //record the error 
                Error = Error + "The date is not a valid date";
            }
            //return any error message
            return Error;
        }
    }
}
