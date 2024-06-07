using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstCusomerCollection
    {
        [TestMethod]

        public void InstanceOk()
        {
            //create an instance of the class we want
            clsCustomerCollection AllCustomer = new clsCustomerCollection();

            Assert.IsNotNull(AllCustomer);
        }

        [TestMethod]
        public void CustomerListOk()
        {
            //create an instance of the class we want
            clsCustomerCollection AllCustomer = new clsCustomerCollection();

            //create some test data to assign to the property 
            //in this case a list 
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list 
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Name = "name";
            TestItem.Phone = "phone";
            TestItem.Address = "address";
            TestItem.CustomerId = 3;
            TestItem.City = "city";
            TestItem.Active = true;
            TestItem.RegisterDate = DateTime.Now;

            //add the test item to list 
            TestList.Add(TestItem);
            //asssign the data to a property
            AllCustomer.CustomerList = TestList;
            //test to see two values are th esame
            Assert.AreEqual(AllCustomer.CustomerList, TestList);
        }

        [TestMethod]

        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //test data 
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.Name = "name";
            TestCustomer.Phone = "phone";
            TestCustomer.Address = "address";
            TestCustomer.CustomerId = 3;
            TestCustomer.City = "city";
            TestCustomer.Active = true;
            TestCustomer.RegisterDate = DateTime.Now;


            //asssign the data to a property
            AllCustomer.ThisCustomer = TestCustomer;
            //test to see two values are th esame
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);
        }

        public void ListandCountOK()
        {
            //instance of customer collection class
            clsCustomerCollection AllCustomer = new clsCustomerCollection();


            //create some test data to assign to the property 
            //in this case a list 
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list 
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Name = "name";
            TestItem.Phone = "phone";
            TestItem.Address = "address";
            TestItem.CustomerId = 3;
            TestItem.City = "city";
            TestItem.Active = true;
            TestItem.RegisterDate = DateTime.Now;

            //add the test item to list 
            TestList.Add(TestItem);
            //asssign the data to a property
            AllCustomer.CustomerList = TestList;
            //test to see two values are th esame
            Assert.AreEqual(AllCustomer.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //test data 
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.Name = "name";
            TestCustomer.Phone = "phone";
            TestCustomer.Address = "address";
            TestCustomer.CustomerId = 3;
            TestCustomer.City = "city";
            TestCustomer.Active = true;
            TestCustomer.RegisterDate = DateTime.Now;


            //asssign the data to a property
            AllCustomer.ThisCustomer = TestCustomer;
            //add record
            Int32 PrimaryKey = 0;
            PrimaryKey = AllCustomer.Add();
            //set the primary key to test data
            TestCustomer.CustomerId = PrimaryKey;
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);
        }

        [TestMethod]

        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //test data 
            clsCustomer TestCustomer = new clsCustomer();

            Int32 PrimaryKey = 0;

            TestCustomer.Name = "name";
            TestCustomer.Phone = "phone";
            TestCustomer.Address = "address";
            TestCustomer.CustomerId = 3;
            TestCustomer.City = "city";
            TestCustomer.Active = true;
            TestCustomer.RegisterDate = DateTime.Now;

            //asssign the data to a property
            AllCustomer.ThisCustomer = TestCustomer;
            //add record

            PrimaryKey = AllCustomer.Add();
            //set the primary key to test data
            TestCustomer.CustomerId = PrimaryKey;
            //modyfy the record

            TestCustomer.Name = "name11";
            TestCustomer.Phone = "phone11";
            TestCustomer.Address = "address11";
            TestCustomer.CustomerId = 4;
            TestCustomer.City = "city11";
            TestCustomer.Active = true;
            TestCustomer.RegisterDate = DateTime.Now;
            AllCustomer.Update();
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);
        }

        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create a new item for test data 
            clsCustomer TestCustomer = new clsCustomer();

            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its property 

            TestCustomer.Name = "name";
            TestCustomer.Phone = "phone";
            TestCustomer.Address = "address";
            TestCustomer.CustomerId = 3;
            TestCustomer.City = "city";
            TestCustomer.Active = true;
            TestCustomer.RegisterDate = DateTime.Now;

            AllCustomer.ThisCustomer = TestCustomer;
            //add the record
            PrimaryKey = AllCustomer.Add();
            //set the primary key of the test data
            TestCustomer.CustomerId = PrimaryKey;
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //delete the record 
            AllCustomer.Delete();
            //now find the record
            Boolean Found = AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByRegisterDate()
        {
            // Create an instance of the customer collection containing all customers
            clsCustomerCollection AllCustomer = new clsCustomerCollection();

            // Create another instance to hold the unfiltered results
            clsCustomerCollection UnfilteredCustomerCollection = new clsCustomerCollection();

            // Apply an empty filter to the unfiltered customer collection
            UnfilteredCustomerCollection.Filter("");

            // Assert that the count of customers in both collections is the same
            Assert.AreNotEqual(AllCustomer.Count, UnfilteredCustomerCollection.Count);
        }

        [TestMethod]
        public void ReportByRegisterDateNoneFound()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomerCollection FilteredRegisterDate = new clsCustomerCollection();
            FilteredRegisterDate.Filter("10/10/1900");
            Assert.AreEqual(0, FilteredRegisterDate.Count);
        }

        [TestMethod]
        public void FilterByRegisterDateTestDataFound()
        {
            //create an instance of the filtered data 
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a salary that doesn't exist 
            AllCustomer.Filter("10/10/2010");
            //check that the correct number of records are found 
            if (AllCustomer.Count == 2)
            {
                //check to see that the first record is 1 
                if (AllCustomer.CustomerList[0].CustomerId != 1)
                {
                    OK = false;
                }
                if (AllCustomer.CustomerList[1].CustomerId != 10)
                {
                    OK = false;
                }

            }
            else
            {
                OK = false;
            }
                Assert.IsTrue(OK);
            
           
            
        }
    }
}