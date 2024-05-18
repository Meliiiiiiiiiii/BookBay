﻿using System;

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

        public string Valid(int staffId, string staffName, string staffEmail, string staffPhone, string staffHireDate, bool staffIsAdmin, int staffSalary)
        {
            return "";
        }
    }
}
