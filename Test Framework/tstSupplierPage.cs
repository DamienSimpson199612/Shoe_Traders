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

        [TestMethod]
        public void SupplierNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplierPage ASupplier = new clsSupplierPage();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ASupplier.SupplierNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.SupplierNo, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplierPage ASupplier = new clsSupplierPage();
            //create some test data to assign to the property
            string TestData = "An Address";
            //assign the data to the property
            ASupplier.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.Address, TestData);
        }


        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplierPage ASupplier = new clsSupplierPage();
            //create some test data to assign to the property
            string TestData = "A Name";
            //assign the data to the property
            ASupplier.SupplierName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.SupplierName, TestData);
        }

        [TestMethod]
        public void TelephonePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplierPage ASupplier = new clsSupplierPage();
            //create some test data to assign to the property
            string TestData = "07736738271";
            //assign the data to the property
            ASupplier.TelephoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.TelephoneNo, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplierPage ASupplier = new clsSupplierPage();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 SupplierNo = 1;
            //invoke the method
            Found = ASupplier.Find(SupplierNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplierPage ASupplier = new clsSupplierPage();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            string SupplierName = "Nike";
            string Address= "31 Box Close";
            string TelephoneNo = "07736738271";
            string DeliveryDate = DateTime.Now.Date.ToString();
            //invoke the method
            OK = ASupplier.Valid(SupplierName, Address, TelephoneNo, DeliveryDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SupplierNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplierPage ASupplier = new clsSupplierPage();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string SupplierName = ""; //this should be ok
            string Address = "31 Box Close";
            string TelephoneNo = "07736738271";
            string DeliveryDate = DateTime.Now.Date.ToString();
            //invoke the method
            OK = ASupplier.Valid(SupplierName, TelephoneNo, Address, DeliveryDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void SupplierNameMin()
        {
            //create an instance of the class we want to create
            clsSupplierPage ASupplier = new clsSupplierPage();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string SupplierName = "e"; //this should be ok
            string Address = "31 Box Close";
            string TelephoneNo = "07736738271";
            string DeliveryDate = DateTime.Now.Date.ToString();
            //invoke the method
            OK = ASupplier.Valid(SupplierName, TelephoneNo, Address, DeliveryDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SupplierNameplusone()
        {
            //create an instance of the class we want to create
            clsSupplierPage ASupplier = new clsSupplierPage();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string SupplierName = "ee"; //this should be ok
            string Address = "31 Box Close";
            string TelephoneNo = "07736738271";
            string DeliveryDate = DateTime.Now.Date.ToString();
            //invoke the method
            OK = ASupplier.Valid(SupplierName, TelephoneNo, Address, DeliveryDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplierPage ASupplier = new clsSupplierPage();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string SupplierName = "eeeee"; //this should be ok
            string Address = "31 Box Close";
            string TelephoneNo = "07736738271";
            string DeliveryDate = DateTime.Now.Date.ToString();
            //invoke the method
            OK = ASupplier.Valid(SupplierName, TelephoneNo, Address, DeliveryDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SupplierNameMax()
        {
            //create an instance of the class we want to create
            clsSupplierPage ASupplier = new clsSupplierPage();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string SupplierName = "eeeeee"; //this should be ok
            string Address = "31 Box Close";
            string TelephoneNo = "07736738271";
            string DeliveryDate = DateTime.Now.Date.ToString();
            //invoke the method
            OK = ASupplier.Valid(SupplierName, TelephoneNo, Address, DeliveryDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SupplierNameMid()
        {
            //create an instance of the class we want to create
            clsSupplierPage ASupplier = new clsSupplierPage();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string SupplierName = "eee"; //this should be ok
            string Address = "31 Box Close";
            string TelephoneNo = "07736738271";
            string DeliveryDate = DateTime.Now.Date.ToString();
            //invoke the method
            OK = ASupplier.Valid(SupplierName, TelephoneNo, Address, DeliveryDate);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplierPage ASupplier = new clsSupplierPage();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string SupplierName = "eeeeeeee"; //this should be ok
            string Address = "31 Box Close";
            string TelephoneNo = "07736738271";
            string DeliveryDate = DateTime.Now.Date.ToString();
            //invoke the method
            OK = ASupplier.Valid(SupplierName, TelephoneNo, Address, DeliveryDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void SupplierNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplierPage ASupplier = new clsSupplierPage();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string SupplierName = ""; 
            SupplierName = SupplierName.PadRight(500, 'e'); //shoud fail
            string Address = "31 Box Close";
            string TelephoneNo = "07736738271";
            string DeliveryDate = DateTime.Now.Date.ToString();
            //invoke the method
            OK = ASupplier.Valid(SupplierName, TelephoneNo, Address, DeliveryDate);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

    }
}
