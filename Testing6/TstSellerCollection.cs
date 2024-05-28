using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testing6
{

    [TestClass]
    public class TstSellerCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsSellerCollection AllSeller = new clsSellerCollection();

            Assert.IsNotNull(AllSeller);
        }

        [TestMethod]
        public void FirstNameListOk()
        {
            clsSellerCollection AllSeller = new clsSellerCollection();
            List<clsSeller> TestList = new List<clsSeller>();
            clsSeller seller = new clsSeller();

            seller.Find(1);
            seller.CreatedAt = DateTime.Now;
            TestList.Add(seller);
            AllSeller.SellerList = TestList;
            Assert.AreEqual(AllSeller.SellerList, TestList);
        }

        [TestMethod]
        public void ThisSellerPropertyOk()
        {
            clsSellerCollection AllSeller = new clsSellerCollection();
            clsSeller seller = new clsSeller();
            seller.Find(1);
            seller.CreatedAt = DateTime.Now;
            AllSeller.ThisSeller = seller;
            Assert.AreEqual(seller, AllSeller.ThisSeller);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            clsSellerCollection AllSeller = new clsSellerCollection();
            List<clsSeller> TestList = new List<clsSeller>();
            clsSeller seller = new clsSeller();

            seller.Find(1);
            seller.CreatedAt = DateTime.Now;
            TestList.Add(seller);
            AllSeller.SellerList = TestList;
            Assert.AreEqual(AllSeller.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            clsSellerCollection AllSeller = new clsSellerCollection();
            clsSeller seller = new clsSeller();

            int PrimaryKey = 0;

            seller.Find(1);
            seller.CreatedAt = DateTime.Now;

            AllSeller.ThisSeller = seller;

            PrimaryKey = AllSeller.Add();

            seller.SellerID = PrimaryKey;

            AllSeller.ThisSeller.Find(PrimaryKey);

            Assert.AreEqual(AllSeller.ThisSeller, seller);

        }

        [TestMethod]
        public void UpdatedMethodOk()
        {
            clsSellerCollection AllSeller = new clsSellerCollection();
            clsSeller seller = new clsSeller();
            int PrimaryKey = 0;
            seller.Find(1);

            AllSeller.ThisSeller = seller;

            PrimaryKey = AllSeller.Add();
            seller.SellerID = PrimaryKey;
            seller.CreatedAt = DateTime.Now;
            seller.LastName = "Muneebs";
            AllSeller.ThisSeller = seller;
            AllSeller.Update();
            AllSeller.ThisSeller.Find(PrimaryKey);

            Assert.AreEqual(AllSeller.ThisSeller, seller);
        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            clsSellerCollection AllSeller = new clsSellerCollection();
            clsSeller seller = new clsSeller();
            int PrimaryKey = 0;
            seller.Find(1);
            seller.CreatedAt = DateTime.Now;
            AllSeller.ThisSeller = seller;
            PrimaryKey = AllSeller.Add();
            seller.SellerID = PrimaryKey;
            AllSeller.ThisSeller.Find(PrimaryKey);
            AllSeller.Delete();
            Boolean Found = AllSeller.ThisSeller.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByFirstNameMethodOk()
        {
            clsSellerCollection AllSeller = new clsSellerCollection();
            clsSellerCollection FilteredSeller = new clsSellerCollection();
            FilteredSeller.ReportByFirstName("");
            Assert.AreEqual(AllSeller.Count, FilteredSeller.Count);
        }

        [TestMethod]
        public void ReportByFirstNameNoneFound()
        {
            clsSellerCollection FilteredSeller = new clsSellerCollection();
            FilteredSeller.ReportByFirstName("xxx xxx");
            Assert.AreEqual(0, FilteredSeller.Count);
        }

        [TestMethod]
        public void ReportByFirstNameTestDataFound()
        {
            clsSellerCollection FilteredSeller = new clsSellerCollection();
            Boolean Ok = true;
            FilteredSeller.ReportByFirstName("muneeb968");
            if (FilteredSeller.Count == 1)
            {
                if (FilteredSeller.SellerList[0].SellerID != 1)
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
