﻿using ClassLibrary;
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
            List<clsStaff>TestList = new List<clsStaff>();
            //Add an item to the list
            //create the item to test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffName = "Assia";
            TestItem.StaffEmail = "Assia@gmail.com";
            TestItem.StaffPhone = "0550115501";
            TestItem.StaffHireDate = DateTime.Now;
            TestItem.StaffIsAdmin = true;
            TestItem.StaffSalary = 5000;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList=TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList,TestList);
        }
      
        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class staff collection
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //assign the data to the property
            TestStaff.StaffName = "Assia";
            TestStaff.StaffEmail = "Assia@gmail.com";
            TestStaff.StaffPhone = "0550115501";
            TestStaff.StaffHireDate = DateTime.Now;
            TestStaff.StaffIsAdmin = true;
            TestStaff.StaffSalary =5000;
            //assign the data to the property
            AllStaff.ThisStaff=TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff,TestStaff);
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
       
    }
}
