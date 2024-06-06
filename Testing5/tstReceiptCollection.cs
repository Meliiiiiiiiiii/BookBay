using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstReceiptCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsReceiptCollection AllReceipt = new clsReceiptCollection();

            Assert.IsNotNull(AllReceipt);
        }

        [TestMethod]
        public void TransactionListOk()
        {
            clsReceiptCollection AllReceipt = new clsReceiptCollection();
            List<clsReceipt> TestList = new List<clsReceipt>();
            clsReceipt receipt = new clsReceipt();

            receipt.Find(1);
            receipt.CreatedAt = DateTime.Now;
            TestList.Add(receipt);
            AllReceipt.ReceiptList = TestList;
            Assert.AreEqual(AllReceipt.ReceiptList, TestList);
        }

        [TestMethod]
        public void ThisReceiptPropertyOk()
        {
            clsReceiptCollection AllReceipt = new clsReceiptCollection();
            clsReceipt receipt = new clsReceipt();
            receipt.Find(1);
            receipt.CreatedAt = DateTime.Now;
            AllReceipt.ThisReceipt = receipt;
            Assert.AreEqual(receipt, AllReceipt.ThisReceipt);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            clsReceiptCollection AllReceipt = new clsReceiptCollection();
            List<clsReceipt> TestList = new List<clsReceipt>(); 
            clsReceipt receipt = new clsReceipt();

            receipt.Find(1);
            receipt.CreatedAt = DateTime.Now;
            TestList.Add(receipt);
            AllReceipt.ReceiptList = TestList;
            Assert.AreEqual(AllReceipt.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            clsReceiptCollection AllReceipts = new clsReceiptCollection();
            clsReceipt receipt = new clsReceipt();

            int PrimaryKey = 0;

            receipt.Find(1);
            receipt.CreatedAt = DateTime.Now;

            AllReceipts.ThisReceipt = receipt;

            PrimaryKey = AllReceipts.Add();

            receipt.ID = PrimaryKey;

            AllReceipts.ThisReceipt.Find(PrimaryKey);

            Assert.AreEqual(AllReceipts.ThisReceipt, receipt);

        }

        [TestMethod]
        public void UpdatedMethodOk()
        {
            clsReceiptCollection AllReceipts = new clsReceiptCollection();
            clsReceipt receipt = new clsReceipt();
            int PrimaryKey = 0;
            receipt.Find(1);

            AllReceipts.ThisReceipt = receipt;

            PrimaryKey = AllReceipts.Add();
            receipt.ID = PrimaryKey;
            receipt.CreatedAt = DateTime.Now;
            receipt.Transation = Guid.NewGuid().ToString().ToUpper();
            AllReceipts.ThisReceipt = receipt;
            AllReceipts.Update();
            AllReceipts.ThisReceipt.Find(PrimaryKey);

            Assert.AreEqual(AllReceipts.ThisReceipt, receipt);
        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            clsReceiptCollection AllReceipts = new clsReceiptCollection();
            clsReceipt receipt = new clsReceipt();
            int PrimaryKey = 0;
            receipt.Find(1);
            receipt.CreatedAt = DateTime.Now;
            AllReceipts.ThisReceipt = receipt;
            PrimaryKey = AllReceipts.Add();
            receipt.ID= PrimaryKey;
            AllReceipts.ThisReceipt.Find(PrimaryKey);
            AllReceipts.Delete();
            Boolean Found = AllReceipts.ThisReceipt.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByTransactionMethodOk()
        {
            clsReceiptCollection AllReceipt = new clsReceiptCollection();
            clsReceiptCollection FilteredReceipt = new clsReceiptCollection();
            FilteredReceipt.ReportByTransaction("");
            Assert.AreEqual(AllReceipt.Count, FilteredReceipt.Count);
        }

        [TestMethod]
        public void ReportByTransactionNoneFound()
        {
            clsReceiptCollection FilteredReceipts = new clsReceiptCollection();
            FilteredReceipts.ReportByTransaction("xxx xxx");
            Assert.AreEqual(0, FilteredReceipts.Count);
        }

        [TestMethod]
        public void ReportByTransactionTestDataFound()
        {
            clsReceiptCollection FilteredReceipt = new clsReceiptCollection();
            Boolean Ok = true;
            FilteredReceipt.ReportByTransaction("F59E15E7-ABE3-4AA5-B08C-8A542733209D");
            if(FilteredReceipt.Count == 1)
            {
                if (FilteredReceipt.ReceiptList[0].ID != 1)
                {
                    Ok = false;
                }
            }
            else
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);  

        }
    }
}
