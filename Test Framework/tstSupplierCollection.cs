using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ClassLibrary;

namespace Test_Framework
{

    [TestClass]

    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //test to see that it exists
            Assert.IsNotNull(AllSuppliers);

       
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllSuppliers.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.Count, SomeCount);
        }
        
    [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsSupplierPage> TestList = new List<clsSupplierPage>();
            //add an item to the list
            //create the item of test data
            clsSupplierPage TestItem = new clsSupplierPage();
            //set its properties
            TestItem.Active = true;
            TestItem.SupplierName = "Nike";
            TestItem.Address = "31 Box Close";
            TestItem.TelephoneNo = "07736738271";
            TestItem.DeliveryDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllSuppliers.SupplierList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.Count, TestList.Count);

       }
        [TestMethod]
        public void AddMethodOK()
        {
            //create a instance 
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some data to assign the property
            clsSupplierPage TestItem = new clsSupplierPage();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test project
            TestItem.Active = true;
            TestItem.SupplierName = "Nike";
            TestItem.Address = "31 Box Close";
            TestItem.TelephoneNo = "07736738271";
            TestItem.DeliveryDate = DateTime.Now.Date;
            //assign the data propety 
            AllSuppliers.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = AllSuppliers.Add();
            //set the primary key for the test data
            TestItem.SupplierID = PrimaryKey;
            //find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }
     }
    
 }