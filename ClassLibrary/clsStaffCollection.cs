﻿using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data membe for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private member data for thisStaff
        clsStaff mThisStaff = new clsStaff();
        public clsStaffCollection()
        {
           
            //object for data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_StaffTable_SelectAll");
            //populare the array list with the data table 
            PopulateArray(DB);
            
        }
       

        public List<clsStaff>StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsStaff ThisStaff 
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            //set the parameers for the stred procedue
            DB.AddParameter("@Staff_Name", mThisStaff.StaffName);
            DB.AddParameter("@Staff_Email", mThisStaff.StaffEmail);
            DB.AddParameter("@Staff_Phone", mThisStaff.StaffPhone);
            DB.AddParameter("@Staff_Hire_Date", mThisStaff.StaffHireDate);
            DB.AddParameter("@Staff_Is_Admin", mThisStaff.StaffIsAdmin);
            DB.AddParameter("@Staff_Salary", mThisStaff.StaffSalary);

            //execute the query returning the primary key value
            return DB.Execute("sproc_StaffTable_Insert");
        
        }

        public void Update()
        {
            clsDataConnection DB =new clsDataConnection();
            //set the parameters for the new stored procedure 
            DB.AddParameter("@Staff_Id", mThisStaff.StaffID);
            DB.AddParameter("@Staff_Name", mThisStaff.StaffName);
            DB.AddParameter("@Staff_Email", mThisStaff.StaffEmail);
            DB.AddParameter("@Staff_Phone", mThisStaff.StaffPhone);
            DB.AddParameter("@Staff_Hire_Date", mThisStaff.StaffHireDate);
            DB.AddParameter("@Staff_Is_Admin", mThisStaff.StaffIsAdmin);
            DB.AddParameter("@Staff_Salary", mThisStaff.StaffSalary);

            //execute the stored procedure
            DB.Execute("sproc_StaffTable_Update");
        }
        public void Delete()
        {
            //deletes the record pointed to by this staff
            //connccet the database
            clsDataConnection DB = new clsDataConnection(); 
            //set the parameters for the stored procedure
            DB.AddParameter("@Staff_Id",mThisStaff.StaffID);
            //execute the stored procedure 
            DB.Execute("sproc_StaffTable_Delete");
        }

        public void ReportBySalary(int Salary)
        {
            //filters the records based on a full or partial salary
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            
            //send the salary postcode parameter to the databse 
            DB.AddParameter("@Staff_Salary" , Salary);
            //execute the stored procedure
            DB.Execute("sproc_StaffTable_FilterBySalary");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //pupulates the array list based on the data table in the parameter DB
            //variables for the index 
            Int32 Index = 0;
            //variable to store the record count 
            Int32 RecordCount;
            //get the count of the records 
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process 
            while(Index < RecordCount)
            {
                //create a blank staff object
                clsStaff aStaff = new clsStaff();
                //read in the fields from the current record
                aStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["Staff_Id"]);
                aStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["Staff_Name"]);
                aStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["Staff_Email"]);
                aStaff.StaffPhone = Convert.ToString(DB.DataTable.Rows[Index]["Staff_Phone"]);
                aStaff.StaffHireDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["Staff_Hire_Date"]);
                aStaff.StaffIsAdmin = Convert.ToBoolean(DB.DataTable.Rows[Index]["Staff_Is_Admin"]);
                aStaff.StaffSalary = Convert.ToInt32(DB.DataTable.Rows[Index]["Staff_Salary"]);
                //add the record to the private data member
                mStaffList.Add(aStaff);
                //point at the next record
                Index++;
            }
        }
    }
 
}