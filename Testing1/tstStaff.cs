using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            Error = aStaff.Valid(staffId, staffName ,staffEmail ,staffPhone,staffHireDate,staffIsAdmin,staffSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
