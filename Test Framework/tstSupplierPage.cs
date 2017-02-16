using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using Class_Library;

namespace MyTestFramework
{
    /// <summary>
    /// Summary description for tstSupplierPage
    /// </summary>
    [TestClass]
    public class tstSupplierPage
    {
        public tstSupplierPage()
        {
            //
            // TODO: Add constructor logic here
            //
        }



        [TestMethod]
        public void InstanceOK()
        {
            clsSupplierPage NewPage = new clsSupplierPage();
            Assert.IsNotNull(NewPage);
        }

        [TestMethod]
        public void DeliveryDate()
        {
            clsSupplierPage TestDeliveryDate = new clsSupplierPage();
            DateTime TestData = Convert.ToDateTime("1/1/1990");
            TestDeliveryDate.DeliveryDate = TestData;
            Assert.AreEqual(TestDeliveryDate.DeliveryDate, TestData);
        }
        [TestMethod]
        public void NumberOfSuppliers()
        {
            clsSupplierPage TestNumberOfSupplier = new clsSupplierPage();
            Int32 TestData = 100;
            TestNumberOfSupplier.SupplierID = TestData;
            Assert.AreEqual(TestNumberOfSupplier.SupplierID, TestData);
        }
        [TestMethod]
        public void Valid()
        {

            clsSupplierPage TestNumOfOrder = new clsSupplierPage();
            Boolean Ok;
            Int32 NumOfSupplier;
            NumOfSupplier = 20;
            DateTime DeliveryDate;
            DeliveryDate = DateTime.Now.Date;
            Ok = TestNumOfOrder.Valid(NumOfSupplier, DeliveryDate);
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SupplierID()
        {

            clsSupplierPage TestSupplierID = new clsSupplierPage();
            //Int32 TestData = Convert.ToInt32("5");
            Int32 TestData = 123456;
            TestSupplierID.SupplierID = TestData;
            Assert.AreEqual(TestSupplierID.SupplierID, TestData);

        }

        [TestMethod]
        public void NumberOfTelephones()
        {
            clsSupplierPage TestNumberOfTelephones = new clsSupplierPage();
            Int32 TestData = 70;
            TestNumberOfTelephones.SupplierID = TestData;
            Assert.AreEqual(TestNumberOfTelephones.SupplierID, TestData);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplierPage ASupplier = new clsSupplierPage();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data of the property
            ASupplier.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.Active, TestData);

        }
    }
}
