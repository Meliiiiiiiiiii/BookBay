using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        //good test data
        //create some test data to pass the method
        Int32 staffId = 1;
        String staffName = "Melissa Ouamer Ali";
        String staffEmail = "ouameralimelissa@gmail.com";
        String staffPhone = "07440344684";
        String staffHireDate = DateTime.Now.ToShortDateString();
        Boolean staffIsAdmin = true;
        Int32 staffSalary = 8000;
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }
        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some data to assign to the property
            string Testdata = "Eylul";
            //assign the data to the property
            AStaff.StaffName = Testdata;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffName, Testdata);
        }
        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some data to assign to the property
            String Testdata = "ouameralimelissa@gmail.com";
            //assign the data to the property
            AStaff.StaffEmail = Testdata;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffEmail, Testdata);
        }
        [TestMethod]
        public void PhonePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some data to assign to the property
            string Testdata = "07440344684";
            //assign the data to the property
            AStaff.StaffPhone = Testdata;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffPhone, Testdata);
        }
        [TestMethod]
        public void HireDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some data to assign to the property
            DateTime Testdata = DateTime.Now.Date;
            //assign the data to the property
            AStaff.StaffHireDate = Testdata;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffHireDate, Testdata);
        }
        [TestMethod]
        public void IsAdminPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some data to assign to the property
            bool Testdata = true;
            //assign the data to the property
            AStaff.StaffIsAdmin = Testdata;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffIsAdmin, Testdata);
        }
        [TestMethod]
        public void SalaryPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some data to assign to the property
            Int32 Testdata = 2000;
            //assign the data to the property
            AStaff.StaffSalary = Testdata;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffSalary, Testdata);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a boolean variable to store the result of the validation
            bool found = false;
            //create some test data to use with the method
            int AStaffId = 1;
            //Invoke the method
            found = AStaff.Find(AStaffId);
            //test to see if the result is true
            Assert.IsTrue(found);
        }
        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create a boolean variable to store the result of the search
            bool Found = false;
            //create a boolean variable to record if the data is OK  
            bool OK = true;
            //create some test data to use with the method
            Int32 staffId = 1;
            //invoke the method
            Found = aStaff.Find(staffId);
            //check the staff name
            if (aStaff.StaffID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create a boolean variable to store the result of the search
            bool Found = false;
            //create a boolean variable to record if the data is OK  
            bool OK = true;
            //create some test data to use with the method
            Int32 staffId = 1;
            //invoke the method
            Found = aStaff.Find(staffId);
            //check the staff name
            if (aStaff.StaffName != Convert.ToString("Melissa Ouamer Ali"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffEmailFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create a boolean variable to store the result of the search
            bool Found = false;
            //create a boolean variable to record if the data is OK  
            bool OK = true;
            //create some test data to use with the method
            Int32 staffId = 1;
            //invoke the method
            Found = aStaff.Find(staffId);
            //check the staff name
            if (aStaff.StaffEmail != Convert.ToString("ouameralimelissa@gmail.com"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffPhoneFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create a boolean variable to store the result of the search
            bool Found = false;
            //create a boolean variable to record if the data is OK  
            bool OK = true;
            //create some test data to use with the method
            Int32 staffId = 1;
            //invoke the method
            Found = aStaff.Find(staffId);
            //check the staff name
            if (aStaff.StaffPhone != Convert.ToString("07440344684"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffHireDateFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create a boolean variable to store the result of the search
            bool Found = false;
            //create a boolean variable to record if the data is OK  
            bool OK = true;
            //create some test data to use with the method
            Int32 staffId = 1;
            //invoke the method
            Found = aStaff.Find(staffId);
            //check the staff name
            if (aStaff.StaffHireDate != Convert.ToDateTime("10/04/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffIsAdminFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create a boolean variable to store the result of the search
            bool Found = false;
            //create a boolean variable to record if the data is OK  
            bool OK = true;
            //create some test data to use with the method
            Int32 staffId = 1;
            //invoke the method
            Found = aStaff.Find(staffId);
            //check the staff name
            if (aStaff.StaffIsAdmin != Convert.ToBoolean(true))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffSalaryFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create a boolean variable to store the result of the search
            bool Found = false;
            //create a boolean variable to record if the data is OK  
            bool OK = true;
            //create some test data to use with the method
            Int32 staffId = 1;
            //invoke the method
            Found = aStaff.Find(staffId);
            //check the staff name
            if (aStaff.StaffSalary != 8000)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string variable to storeany error message
            string Error = "";
            //invoke the method
            Error = aStaff.Valid(staffId, staffName, staffEmail, staffPhone, staffHireDate, staffIsAdmin, staffSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMinLessOne()
        {
            //create an instance of the staff class
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test to pass to the method
            String StaffName = "";
            //invoke the method
            Error = aStaff.Valid(staffId, StaffName, staffEmail, staffPhone, staffHireDate, staffIsAdmin, staffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMin()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String StaffName = "aaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = aStaff.Valid(staffId, StaffName, staffEmail, staffPhone, staffHireDate, staffIsAdmin, staffSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "aaaaaaaaaaaaaaaa"; //this should be ok
                                                   //invoke the method
            Error = aStaff.Valid(staffId, StaffName, staffEmail, staffPhone, staffHireDate, staffIsAdmin, staffSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
                                                                          //invoke the method
            Error = aStaff.Valid(staffId, StaffName, staffEmail, staffPhone, staffHireDate, staffIsAdmin, staffSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
                                                                           //invoke the method
            Error = aStaff.Valid(staffId, StaffName, staffEmail, staffPhone, staffHireDate, staffIsAdmin, staffSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void HouseNoMid()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "aaaaaaaaaa"; //this should be ok
                                             //invoke the method
            Error = aStaff.Valid(staffId, StaffName, staffEmail, staffPhone, staffHireDate, staffIsAdmin, staffSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            //create an instance of the staff class 
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            String StaffName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method 
            Error = aStaff.Valid(staffId, StaffName, staffEmail, staffPhone, staffHireDate, staffIsAdmin, staffSalary);
            //test tosee that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameExtremeMax()
        {
            //create an instance of the staff class 
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            String StaffName = "";
            StaffName = StaffName.PadRight(50, 'a');
            //invoke the valid method
            Error = aStaff.Valid(staffId, StaffName, staffEmail, staffPhone, staffHireDate, staffIsAdmin, staffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void HiringDateExtremeMin()
        {
            //create an instance of the staff class 
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the is less 100 years
            TestDate = TestDate.AddYears(-100);
            //covert the date variable to a string variable
            String StaffHiringDate = TestDate.ToString();
            //invoke method
            Error = aStaff.Valid(staffId, staffName, staffEmail, staffPhone, StaffHiringDate, staffIsAdmin, staffSalary);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string StaffHiringDate = TestDate.ToString();
            //invoke the method
            Error = aStaff.Valid(staffId, staffName, staffEmail, staffPhone, StaffHiringDate, staffIsAdmin, staffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string StaffHiringDate = TestDate.ToString();
            //invoke the method
            Error = aStaff.Valid(staffId, staffName, staffEmail, staffPhone, StaffHiringDate, staffIsAdmin, staffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string StaffHiringDate = TestDate.ToString();
            //invoke the method
            Error = aStaff.Valid(staffId, staffName, staffEmail, staffPhone, StaffHiringDate, staffIsAdmin, staffSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string StaffHiringDate = TestDate.ToString();
            //invoke the method
            Error = aStaff.Valid(staffId, staffName, staffEmail, staffPhone, StaffHiringDate, staffIsAdmin, staffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(10);
            //convert the date variable to a string variabl
            string StaffHiringDate = TestDate.ToString();
            //invoke the method
            Error = aStaff.Valid(staffId, staffName, staffEmail, staffPhone, StaffHiringDate, staffIsAdmin, staffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
