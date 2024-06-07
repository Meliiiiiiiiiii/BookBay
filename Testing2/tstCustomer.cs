using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Security.Cryptography;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {


        //good test data

        int CustomerID = 3;
        string Name = "Mingma";
        string Phone = "0123456789";
        string Address = "Leicestershire";
        string City = "Leicester";
        DateTime RegisterDate = DateTime.Now.Date;
        clsCustomer customer = new clsCustomer();


        /******************INSTANCE OF THE CLASS TEST******************/


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(customer);
        }

        [TestMethod]
        public void RegisterDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            customer.RegisterDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.RegisterDate, TestData);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 3;
            //assign the data to the property
            customer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.CustomerId, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Leicestershire";
            //assign the data to the property
            customer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.Address, TestData);
        }

        [TestMethod]
        public void CityPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            customer.City = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.City, TestData);
        }
        [TestMethod]
        public void PhonePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "0123456789";
            //assign the data to the property
            customer.Phone = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.Phone, TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Mingma";
            //assign the data to the property
            customer.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.Name, TestData);
        }

        [TestMethod]

        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with he method
            Int32 CustomerId = 3;
            //invoke the method
            Found = customer.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create a Boleean variable to stoe the result of the search
            Boolean Found = false;
            //crate a Boolean variable to record if the data s OK (assume it is)
            Boolean OK = true;
            //create some test datat to use with the method
            Int32 CustomerId = 3;
            //invoke the method
            Found = customer.Find(CustomerId);
            //check the customerid
            if (customer.CustomerId != 3)
            {
                OK = false;
            }
            //test to see that the result is corect
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create a Boleean variable to stoe the result of the search
            Boolean Found = false;
            //crate a Boolean variable to record if the data s OK (assume it is)
            Boolean OK = true;
            //create some test datat to use with the method
            Int32 CustomerId = 3;
            //invoke the method
            Found = customer.Find(CustomerId);
            //check the Register date property
            if (customer.Name != ("Mingma"))
            {
                OK = false;
            }
            //test to see that the result is corect
            Assert.IsTrue(OK);

        }

        /******************Parameter Tests for Name******************/
        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "a"; //this should be ok
            //invoke the method
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aa"; //this should be ok
            //invoke the method
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            string Name = new string('a', 31);  // 31 characters
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());
            Assert.AreNotEqual("", Error, "NameMaxPlusOne test failed: No error message was returned for a username exceeding the maximum length.");
        }
        [TestMethod]
        public void NameMaxLessOne()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            string Username = new string('a', 29);  // 29 characters
            //invoke the method
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = new string('a', 30);  //30 characters
            //invoke the method
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = new string('a', 15);  // 15 characters 
            //invoke the method
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        /******************Parameter Tests for Phone******************/

        [TestMethod]
        public void PhoneMin()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Phone = new string('a', 10); //10 characters for phone
                                                //invoke the method
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Phone = "122222222"; //this should be ok
            //invoke the method
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneMaxPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            string Phone = new string('a', 31);  // 31 characters
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());
            Assert.AreNotEqual("", Error, "NameMaxPlusOne test failed: No error message was returned for a username exceeding the maximum length.");
        }
        [TestMethod]
        public void PhoneMaxLessOne()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            string Phone = new string('1', 9);  // 9 characters
            //invoke the method
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMax()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = new string('1', 10);  //10 characters
            //invoke the method
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMid()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Phone = new string('5', 9);  // 5 characters 
            //invoke the method
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        /*********Parameters Tests for Address*****************/


        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "a"; //this should be ok
                                  //invoke the method
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddresssMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "aa"; //this should be ok
            //invoke the method
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            string Address = new string('a', 61);  // 61 characters
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());
            Assert.AreNotEqual("", Error, "");
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            string Address = new string('a', 59);  // 59 characters
            //invoke the method
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = new string('a', 60);  //60 characters
            //invoke the method
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = new string('a', 30);  // 30 characters 
            //invoke the method
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        /*********Parameters Tests for City*****************/


        [TestMethod]
        public void CityMin()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string City = "a"; //this should be ok
                               //invoke the method
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string City = "aa"; //this should be ok
            //invoke the method
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CityMaxPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            string City = new string('a', 21);  // 21 characters
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());
            Assert.AreNotEqual("", Error, "NameMaxPlusOne test failed: No error message was returned for a username exceeding the maximum length.");
        }
        [TestMethod]
        public void CityMaxLessOne()
        {
            clsCustomer customer = new clsCustomer();
            string Error = "";
            string City = new string('a', 19);  // 19 characters
            //invoke the method
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMax()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string City = new string('a', 20);  //20 characters
            //invoke the method
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMid()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string City = new string('a', 10);  // 10 characters 
            //invoke the method
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        /******************Parameter Tests for RegisterDate******************/
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-100);
            string RegisterDate = TestDate.ToString();
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "Invalid DateTime");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-1);
            string RegisterDate = TestDate.ToString();
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "Invalid DateTime");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            DateTime TestDate;

            TestDate = DateTime.Now.Date;


            string RegisterDate = TestDate.ToString();
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(+1);
            string RegisterDate = TestDate.ToString();
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "Invalid DateTime");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";
            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(100);
            string RegisterDate = TestDate.ToString();
            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "Invalid DateTime");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsCustomer customer = new clsCustomer();
            String Error = "";

            string RegisterDate = "this is not a date";

            Error = customer.Valid(Name, Phone, Address, City, RegisterDate.ToString());

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "Invalid DateTime");
        }
    }
}























