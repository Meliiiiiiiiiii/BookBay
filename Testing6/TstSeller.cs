using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary;

namespace Testing6
{

    [TestClass]
    public class TstSeller
    {
        private int sellerID = 1;
        private string firstName = "Muneeb";
        private string lastName = "Muneeb";
        private Boolean isActive = true;
        private float commission = 3.3f;
        private float sales = 20.82f;
        private DateTime createdAt = DateTime.Now.Date;
        private clsSeller seller = new clsSeller();


        [TestMethod]
        public void InstanceOK()
        {
            clsSeller seller = new clsSeller();
            Assert.IsNotNull(seller);
        }

        [TestMethod]
        public void SellerIdOk()
        {
            clsSeller seller = new clsSeller();
            seller.SellerID = sellerID;
            Assert.AreEqual(seller.SellerID, sellerID);
        }

        [TestMethod]
        public void FirstNameOK()
        {
            clsSeller seller = new clsSeller();
            seller.FirstName = firstName;
            Assert.AreEqual(seller.FirstName, firstName);
        }

        [TestMethod]
        public void FirstName_ExtremeMin()
        {
            
            firstName = "";
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID,firstName, lastName,isActive, commission, sales, createdAt.ToString());
            Assert.AreNotEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FirstName_MinBoundary()
        {
            firstName = "a";
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FirstName_MinPlus1()
        {
            firstName= "ab";
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FirstName_MaxMinus1()
        {
            firstName = new string('a', 49);
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FirstName_MaxBoundary()
        {
            firstName = new string('a', 50);
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FirstName_MaxPlus1()
        {
            firstName = new string('a', 51);
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreNotEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FirstName_Mid()
        {
            firstName = new string('a', 25);
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FirstName_ExtremeMax()
        {
            firstName= new string('a', 100);
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreNotEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LastNameOK()
        {
            clsSeller seller = new clsSeller();
            seller.LastName = lastName;
            Assert.AreEqual(seller.LastName, lastName);
        }

        [TestMethod]
        public void LastName_ExtremeMin()
        {

            lastName = "";
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreNotEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LastName_MinBoundary()
        {
            lastName = "a";
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LastName_MinPlus1()
        {
            lastName = "ab";
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LastName_MaxMinus1()
        {
            lastName = new string('a', 49);
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LastName_MaxBoundary()
        {
            lastName = new string('a', 50);
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LastName_MaxPlus1()
        {
            lastName = new string('a', 51);
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreNotEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LastName_Mid()
        {
            lastName = new string('a', 25);
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LastName_ExtremeMax()
        {
            lastName = new string('a', 100);
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreNotEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void IsActiveOk()
        {
            clsSeller seller = new clsSeller();
            seller.IsActive = isActive;
            Assert.AreEqual(seller.IsActive, isActive);
        }

        [TestMethod]
        public void CommissionOk()
        {
            clsSeller seller = new clsSeller();
            seller.Commission = commission;
            Assert.AreEqual(seller.Commission, commission);
        }

        [TestMethod]
        public void Commission_ExtremeMin()
        {
            commission = -100.00f;
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreNotEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Commission_MinMinus1()
        {
            commission = -0.01f;
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreNotEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Commission_MinBoundary()
        {
            commission = 0.00f;
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Commission_MinPlus1()
        {
            commission = 0.01f;
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Commission_MaxMinus1()
        {
            commission = 99.99f;
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Commission_MaxBoundary()
        {
            commission = 100.00f;
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Commission_MaxPlus1()
        {
            commission = 100.01f;
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreNotEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Commission_Mid()
        {
            commission = 50.00f;
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Commission_ExtremeMax()
        {
            commission = 1000.00f;
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreNotEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Commission_InvalidDataType()
        {
            commission = -1f;
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreNotEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void SalesOk()
        {
            clsSeller seller = new clsSeller();
            seller.Sales = sales;
            Assert.AreEqual(seller.Sales, sales);
        }


        [TestMethod]
        public void Sales_ExtremeMin()
        {
            sales = -1000000.00f;
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreNotEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Sales_MinMinus1()
        {
            sales = -0.01f;
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreNotEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Sales_MinBoundary()
        {
            sales = 0.00f;
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Sales_MinPlus1()
        {
            sales = 0.01f;
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Sales_MaxMinus1()
        {
            sales = 999999.99f;
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Sales_MaxBoundary()
        {
            sales = 1000000.00f;
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Sales_MaxPlus1()
        {
            sales = 1000001.00f;
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreNotEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Sales_Mid()
        {
            sales = 500000.00f;
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Sales_ExtremeMax()
        {
            sales = 10000000.00f;
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreNotEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Sales_InvalidDataType()
        {
            sales = -1f;
            string expectedResult = "";
            string actualResult = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreNotEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CreatedAt()
        {
            clsSeller seller = new clsSeller();
            seller.CreatedAt = createdAt;
            Assert.AreEqual(seller.CreatedAt, createdAt);
        }
        [TestMethod]
        public void CreatedAtExtremeMin()
        {
            var date = DateTime.Now.Date;
            date = date.AddYears(-100);
            createdAt = date;
            string error = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void CreatedAtMinLessOne()
        {
            var date = DateTime.Now.Date;
            date = date.AddDays(-1);
            createdAt = date;
            string error = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void CreatedAtMin()
        {
            string error = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void CreatedAtMinPlusOne()
        {
            var date = DateTime.Now.Date;
            date = date.AddDays(+1);
            createdAt = date;
            string error = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void CreatedAtExtremeMax()
        {
            var date = DateTime.Now.Date;
            date = date.AddYears(+100);
            createdAt = date;
            string error = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void CreatedAtInvalidData()
        {
            string createdAtstring = "this is a date string";
            string error = seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAtstring);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ValidOK()
        {
           seller.Valid(sellerID, firstName, lastName, isActive, commission, sales, createdAt.ToString());
        }


        [TestMethod]
        public void FirstNameFound()
        {
            clsSeller seller = new clsSeller();
            bool ok = false;
            seller.Find(sellerID);
            if (seller.FirstName == "Muneeb")
            {
                ok = true;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void LastNameFound()
        {
            clsSeller seller = new clsSeller();
            bool ok = false;
            seller.Find(sellerID);
            if (seller.LastName == "Muneeb")
            {
                ok = true;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void CommissionFound()
        {
            clsSeller seller = new clsSeller();
            bool ok = false;
            seller.Find(sellerID);
            if (seller.Commission == 10f)
            {
                ok = true;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void SalesFound()
        {
            clsSeller seller = new clsSeller();
            bool ok = false;
            seller.Find(sellerID);
            if (seller.Sales == 6661f)
            {
                ok = true;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void IsActiveFound()
        {
            clsSeller seller = new clsSeller();
            bool ok = false;
            seller.Find(sellerID);
            if (seller.IsActive == true)
            {
                ok = true;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void CreatedAtFound()
        {
            clsSeller seller = new clsSeller();
            bool ok = false;
            seller.Find(sellerID);
            if (seller.CreatedAt == new DateTime(2024, 5, 28))
            {
                ok = true;
            }
            Assert.IsTrue(ok);
        }
    }
}

