using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
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
            float Testdata = 3000;
            //assign the data to the property
            AStaff.StaffSalary = Testdata;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffSalary, Testdata);
        }
    }
}
