using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class TstReceipt
    {
        private int receiptID = 1;
        private int orderID = 0;
        private string transaction = "5e7bda44-85f7-42d3-a5eb-94d43db2a6bb";
        private float tax = 0.0f;
        private string PaymentMethod = "visa";
        private float TotalPrice = 0.0f;
        private string createdAt = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOk()
        {
            clsReceipt receipt = new clsReceipt();
            Assert.IsNotNull(receipt);
        }

        [TestMethod]
        public void ReceiptIdOk()
        {
            clsReceipt receipt = new clsReceipt();
            int Data = 0;
            receipt.ID = Data;
            Assert.AreEqual(receipt.ID, Data);
        }

        [TestMethod]
        public void ReceiptMinLessOne()
        {
            clsReceipt receipt = new clsReceipt();
            receiptID = -1;
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ReceiptMin()
        {
            clsReceipt receipt = new clsReceipt();
            receiptID = 0;
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ReceiptMinPlusOne()
        {
            clsReceipt receipt = new clsReceipt();
            receiptID = 1;
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ReceiptMaxLessOne()
        {
            clsReceipt receipt = new clsReceipt();
            receiptID = 2147483646;
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ReceiptMax()
        {
            clsReceipt receipt = new clsReceipt();
            receiptID = 2147483647;
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ReceiptMid()
        {
            clsReceipt receipt = new clsReceipt();
            receiptID = 1073741824;
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ReceiptIDFound()
        {
            clsReceipt receipt = new clsReceipt();
            int receiptid = 1;
            bool ok = false;
            receipt.Find(receiptID);
            if(receipt.ID == receiptid)
            {
                ok = true;
            }
            Assert.IsTrue(ok);
        }


        [TestMethod]
        public void OrderOk()
        {
            clsReceipt receipt = new clsReceipt();
            int Data = 0;
            receipt.OrderID = Data;
            Assert.AreEqual(Data, receipt.OrderID);
        }


        [TestMethod]
        public void OrderMinLessOne()
        {
            clsReceipt receipt = new clsReceipt();
            orderID = -1;
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void OrderMin()
        {
            clsReceipt receipt = new clsReceipt();
            orderID = 0;
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void OrderMinPlusOne()
        {
            clsReceipt receipt = new clsReceipt();
            orderID = 1;
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void OrderMaxLessOne()
        {
            clsReceipt receipt = new clsReceipt();
            orderID = 2147483646;
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void OrderMax()
        {
            clsReceipt receipt = new clsReceipt();
            orderID = 2147483647;
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void OrderMid()
        {
            clsReceipt receipt = new clsReceipt();
            orderID = 1073741824;
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void OrderIDFound()
        {
            clsReceipt receipt = new clsReceipt();
            int OrderID = 8;
            bool ok = false;
            receipt.Find(receiptID);
            if (receipt.OrderID == OrderID)
            {
                ok = true;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TransactionOk()
        {
            clsReceipt receipt = new clsReceipt();
            string variable = "dfhfhfhfhhf";
            receipt.Transation = variable;
            Assert.AreEqual(variable, receipt.Transation);
        }

        public void TransactionMinLessOne()
        {
            clsReceipt receipt = new clsReceipt();
            transaction = "5e7bda44-85f7-42d3-a5eb-94d43db2a6b";
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void TransactionMin()
        {
            clsReceipt receipt = new clsReceipt();
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TransactionMinPlusOne()
        {
            clsReceipt receipt = new clsReceipt();
            transaction = "5e7bda44-85f7-42d3-a5eb-94d43db2a6bb-";
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void TransactionFound()
        {
            clsReceipt receipt = new clsReceipt();
            bool ok = false;
            receipt.Find(receiptID);
            if (receipt.Transation == "F59E15E7-ABE3-4AA5-B08C-8A542733209D")
            {
                ok = true;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TaxOk()
        {
            clsReceipt receipt = new clsReceipt();
            float variable = 0.02f;
            receipt.Tax = variable;
            Assert.AreEqual(variable, receipt.Tax);
        }

        [TestMethod]
        public void TaxMinLessOne()
        {
            clsReceipt receipt = new clsReceipt();
            tax= -0.000001f;
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void TaxMin()
        {
            clsReceipt receipt = new clsReceipt();
            tax = 0.000001f;
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TaxMinPlusOne()
        {
            clsReceipt receipt = new clsReceipt();
            tax = 0.000002f;
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TaxMaxLessOne()
        {
            clsReceipt receipt = new clsReceipt();
            tax = 3.402823465999999e+38f;
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TaxMax()
        {
            clsReceipt receipt = new clsReceipt();
            tax = 3.402823466e+38f;
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TaxMaxPlusOne()
        {
            clsReceipt receipt = new clsReceipt();
            tax = 3.402823467e+38f;
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TaxMid()
        {
            clsReceipt receipt = new clsReceipt();
            tax = 1.701411733e+38f;
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TaxFound()
        {
            clsReceipt receipt = new clsReceipt();
            bool ok = false;
            receipt.Find(receiptID);
            if (receipt.Tax == 30)
            {
                ok = true;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void PaymentMethodOk()
        {
            clsReceipt receipt = new clsReceipt();
            string variable = "dfhfhfhfhhf";
            receipt.PaymentMethod = variable;
            Assert.AreEqual(variable, receipt.PaymentMethod);
        }

        [TestMethod]
        public void PaymentMethodExtremeMin()
        {
            clsReceipt receipt = new clsReceipt();
            PaymentMethod = "";
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PaymentMethodMinLessOne()
        {
            clsReceipt receipt = new clsReceipt();
            PaymentMethod = "aaa";
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PaymentMethodMin()
        {
            clsReceipt receipt = new clsReceipt();
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PaymentMethodMinPlusOne()
        {
            clsReceipt receipt = new clsReceipt();
            PaymentMethod = "aaaaa";
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PaymentMethodMaxLessOne()
        {
            clsReceipt receipt = new clsReceipt();
            PaymentMethod = PaymentMethod.PadRight(11, 'l');
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PaymentMethodMax()
        {
            clsReceipt receipt = new clsReceipt();
            PaymentMethod = PaymentMethod.PadRight(12, 'l');
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void PaymentMethodMaxPlusOne()
        {
            clsReceipt receipt = new clsReceipt();
            PaymentMethod = PaymentMethod.PadRight(13,'l');
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PaymentMethodMid()
        {
            clsReceipt receipt = new clsReceipt();
            PaymentMethod = "ssssss";
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PaymentMethodExtremMax()
        {
            clsReceipt receipt = new clsReceipt();
            PaymentMethod = PaymentMethod.PadRight(255, 'l');
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PaymentMethodFound()
        {
            clsReceipt receipt = new clsReceipt();
            bool ok = false;
            receipt.Find(receiptID);
            if (receipt.PaymentMethod == "Visa")
            {
                ok = true;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TotalPriceOk()
        {
            clsReceipt receipt = new clsReceipt();
            float variable = (float)0.02;
            receipt.TotalPrice = variable;
            Assert.AreEqual(variable, receipt.TotalPrice);
        }

        public void TotalPriceMinLessOne()
        {
            clsReceipt receipt = new clsReceipt();
            TotalPrice = -0.000001f;
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void TotalPriceMin()
        {
            clsReceipt receipt = new clsReceipt();
            TotalPrice = 0.000001f;
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TotalPriceMinPlusOne()
        {
            clsReceipt receipt = new clsReceipt();
            TotalPrice = 0.000002f;
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TotalPriceMaxLessOne()
        {
            clsReceipt receipt = new clsReceipt();
            TotalPrice = 3.402823465999999e+38f;
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TotalPriceMax()
        {
            clsReceipt receipt = new clsReceipt();
            TotalPrice = 3.402823466e+38f;
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TotalPriceMaxPlusOne()
        {
            clsReceipt receipt = new clsReceipt();
            TotalPrice = 3.402823467e+38f;
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TotalPriceMid()
        {
            clsReceipt receipt = new clsReceipt();
            TotalPrice = 1.701411733e+38f;
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }


        [TestMethod]
        public void TotalPriceFound()
        {
            clsReceipt receipt = new clsReceipt();
            bool ok = false;
            receipt.Find(receiptID);
            if (receipt.TotalPrice == 32)
            {
                ok = true;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void CreatedAtOk()
        {
            clsReceipt receipt = new clsReceipt();
            DateTime date = new DateTime(2024,05,01);
            receipt.CreatedAt = date;
            Assert.AreEqual(date, receipt.CreatedAt);
        }

        [TestMethod]
        public void CreatedAtExtremeMin()
        {
            clsReceipt receipt = new clsReceipt();
            var date = DateTime.Now.Date;
            date = date.AddYears(-100);
            createdAt = date.ToString();
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void CreatedAtMinLessOne()
        {
            clsReceipt receipt = new clsReceipt();
            var date = DateTime.Now.Date;
            date = date.AddDays(-1);
            createdAt = date.ToString();
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void CreatedAtMin()
        {
            clsReceipt receipt = new clsReceipt();
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void CreatedAtMinPlusOne()
        {
            clsReceipt receipt = new clsReceipt();
            var date = DateTime.Now.Date;
            date = date.AddDays(+1);
            createdAt = date.ToString();
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void CreatedAtExtremeMax()
        {
            clsReceipt receipt = new clsReceipt();
            var date = DateTime.Now.Date;
            date = date.AddYears(+100);
            createdAt = date.ToString();
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void CreatedAtInvalidData()
        {
            clsReceipt receipt = new clsReceipt();
            createdAt = "this is a date string";
            string error = receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void CreatedAtFound()
        {
            clsReceipt receipt = new clsReceipt();
            bool ok = false;

            // Correctly create a DateTime object for May 16, 2024
            DateTime expectedDate = new DateTime(2024, 5, 16);

            // Assuming receiptID is defined and available
            receipt.Find(receiptID);

            // Compare receipt.CreatedAt with the expectedDate
            if (receipt.CreatedAt == expectedDate)
            {
                ok = true;
            }

            // Assert if the result is as expected
            Assert.IsTrue(ok);
        }


        [TestMethod]
        public void ValidOK()
        {
            clsReceipt receipt = new clsReceipt();
            receipt.Valid(receiptID, orderID, transaction, tax, PaymentMethod, TotalPrice, createdAt);
        }
    }
}
