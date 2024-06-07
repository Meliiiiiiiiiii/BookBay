using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomerUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerUser aUser = new clsCustomerUser();
            //test to see that it exists
            Assert.IsNotNull(aUser);
        }
        [TestMethod]
        public void UserIdPropertyOK()
        {
            //create an instance of the class user
            clsCustomerUser aUser = new clsCustomerUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            aUser.UserID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aUser.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomerUser aUser = new clsCustomerUser();
            //create some test data to assign to the property
            string TestData = "Mingma";
            //assign the data to the property
            aUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomerUser aUser = new clsCustomerUser();
            //create some test data to assign the property
            string TestData = "Mingma11";
            //assign the data to the property
            aUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser aUser = new clsCustomerUser();
            //create some test data to assign to the property
            string TestData = "IT";
            //assign the data to the property
            aUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aUser.Department, TestData);
        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerUser aUser = new clsCustomerUser();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            string UserName = "Mingma";
            string Password = "Mingma11";
            //invoke the method
            Found = aUser.FindUser(UserName, Password);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUserNamePWFoundOK()
        {
            //create an instance of the class we want to create 
            clsCustomerUser aUser = new clsCustomerUser();
            //create a boolean variable to store the result of the search 
            Boolean Found = false;
            //create a boolean variable to record if the data is ok 
            Boolean OK = true;
            //create some test data to use with the method 
            string UserName = "Mingma";
            string Password = "Mingma11";
            //invoke the method
            Found = aUser.FindUser(UserName, Password);
            //check the user id property
            if (aUser.UserName != UserName && aUser.Password != Password)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
