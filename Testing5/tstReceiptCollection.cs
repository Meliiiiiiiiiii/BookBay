using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
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
    }
}
