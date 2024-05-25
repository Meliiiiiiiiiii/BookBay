using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class TstReceiptUser
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsReceiptUser AnUser = new clsReceiptUser();
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDPropertyOk()
        {
            clsReceiptUser AnUser = new clsReceiptUser();
            int TestData = 1;
            AnUser.UserID = TestData;
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOk()
        {
            clsReceiptUser AnUser = new clsReceiptUser();
            string TestDate = "Wilfred";
            AnUser.UserName = TestDate;
            Assert.AreEqual(AnUser.UserName, TestDate);
        }

        [TestMethod]
        public void PasswordPropertyOk()
        {
            clsReceiptUser AnUser = new clsReceiptUser();
            string TestDate = "Wilfred234";
            AnUser.Password = TestDate;
            Assert.AreEqual(AnUser.Password, TestDate); 
        }

        [TestMethod]
        public void FindUserMethodOk()
        {
            clsReceiptUser AnUser = new clsReceiptUser();
            Boolean Found = false;
            string UserName = "Wilfred";
            string Password = "Wilfred234";
            Found =  AnUser.FindUser(UserName, Password);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            clsReceiptUser AnUser = new clsReceiptUser();
            Boolean Found = false;
            Boolean OK = true;
            string UserName = "Wilfred";
            string Password = "Wilfred234";
            Found = AnUser.FindUser(UserName, Password);
            if(AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
