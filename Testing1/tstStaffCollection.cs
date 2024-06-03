using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class staff collection
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an item to the list
            //create the item to test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffID = 6;
            TestItem.StaffName = "Assia";
            TestItem.StaffEmail = "Assia@gmail.com";
            TestItem.StaffPhone = "0550115501";
            TestItem.StaffHireDate = DateTime.Now;
            TestItem.StaffIsAdmin = true;
            TestItem.StaffSalary = 5000;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class staff collection
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //assign the data to the property
            TestStaff.StaffID = 6;
            TestStaff.StaffName = "Assia";
            TestStaff.StaffEmail = "Assia@gmail.com";
            TestStaff.StaffPhone = "0550115501";
            TestStaff.StaffHireDate = DateTime.Now;
            TestStaff.StaffIsAdmin = true;
            TestStaff.StaffSalary = 5000;
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the staff collection class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create somne data test 
            //create a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //create an item list
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffID = 6;
            TestItem.StaffName = "Assia";
            TestItem.StaffEmail = "Assia@gmail.com";
            TestItem.StaffPhone = "0550115501";
            TestItem.StaffHireDate = DateTime.Now;
            TestItem.StaffIsAdmin = true;
            TestItem.StaffSalary = 5000;
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test if values are equal
            Assert.AreEqual(AllStaff.Count, TestList.Count);

        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the staff collection class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an item of test data
            clsStaff TestItem = new clsStaff();
            //vaiable to store the primary key
            int PrimaryKey = 0;
            //set its properties
            TestItem.StaffID = 10;
            TestItem.StaffName = "Melina";
            TestItem.StaffEmail = "Mel@gmail.com";
            TestItem.StaffPhone = "0550114444";
            TestItem.StaffHireDate = DateTime.Now;
            TestItem.StaffIsAdmin = true;
            TestItem.StaffSalary = 7000;
            //set thisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key to the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test if values are equal
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
            // Test if values are equal by comparing properties individually
            //Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the staff collection class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an item of test data
            clsStaff TestItem = new clsStaff();
            //vaiable to store the primary key
            int PrimaryKey = 0;
            //set its properties
            TestItem.StaffID = 10;
            TestItem.StaffName = "Melina";
            TestItem.StaffEmail = "Mel@gmail.com";
            TestItem.StaffPhone = "0550114444";
            TestItem.StaffHireDate = DateTime.Now;
            TestItem.StaffIsAdmin = true;
            TestItem.StaffSalary = 7000;
            //set thisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key to the test data
            TestItem.StaffID = PrimaryKey;
            //modify the test record

            TestItem.StaffName = "Maya";
            TestItem.StaffEmail = "Meill@gmail.com";
            TestItem.StaffPhone = "0440114444";
            TestItem.StaffHireDate = DateTime.Now;
            TestItem.StaffIsAdmin = false;
            TestItem.StaffSalary = 9000;
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see if this address matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {

            //create an instance of the staff collection class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an item of test data
            clsStaff TestItem = new clsStaff();
            //vaiable to store the primary key
            int PrimaryKey = 0;
            //set its properties
            TestItem.StaffID = 10;
            TestItem.StaffName = "Melina";
            TestItem.StaffEmail = "Mel@gmail.com";
            TestItem.StaffPhone = "0550114444";
            TestItem.StaffHireDate = DateTime.Now;
            TestItem.StaffIsAdmin = true;
            TestItem.StaffSalary = 7000;
            //set thisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key to the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);

        }

    }
}
