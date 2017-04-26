using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;
using System.Collections.Generic;
using MyClassLibrary;

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
        public void SupplierListOK()
        {
            //create an instance of the class we want to create 
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //screate some test data to assign to the property
            //in this case that data needs to be a list of objects
            List<clsSupplierPage> TestList = new List<clsSupplierPage>();
            //add an item to the list
            //create some data 
            clsSupplierPage TestItem = new clsSupplierPage();
            //set properties

            TestItem.SupplierName = "Nike";
            TestItem.Address = "31 Box Close";
            TestItem.TelephoneNo = "07736738271";
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.Active = true;
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the proprty
            AllSuppliers.SupplierList = TestList;
            //test to see that the result is correct
            Assert.AreEqual(AllSuppliers.SupplierList, TestList);
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
        public void ThisSupplierPropertyOK()
        {
            //create an instance of the class we want to create 
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //screate some test data to assign to the property
            //in this case that data needs to be a list of objects
            clsSupplierPage TestSupplier = new clsSupplierPage();
            //set the properties of the test object
            TestSupplier.Active = true;
            TestSupplier.SupplierName = "Nike";
            TestSupplier.Address = "31 Box Close";
            TestSupplier.TelephoneNo = "07736738271";
            TestSupplier.DeliveryDate = DateTime.Now.Date;
            //assign the data to the property
            AllSuppliers.ThisSupplier = TestSupplier;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);
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
        //[TestMethod]

        //public void TwoRecordsPresents()
        //{
        //    //create an instance of the class we want to create 
        //    clsCustomerCollection AllCustomer = new clsCustomerCollection();
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllCustomer.Count, 2);
    }
    //////////////////////[TestMethod]
    //////////////////////public void AddMethodOK()
    //////////////////////{
    //////////////////////    //create a instance 
    //////////////////////    clsSupplierCollection AllSuppliers = new clsSupplierCollection();
    //////////////////////    //create some data to assign the property
    //////////////////////    clsSupplierPage TestItem = new clsSupplierPage();
    //////////////////////    //var to store the primary key
    //////////////////////    Int32 PrimaryKey = 0;
    //////////////////////    //set the properties of the test project
    //////////////////////    TestItem.Active = true;
    //////////////////////    TestItem.SupplierName = "Nike";
    //////////////////////    TestItem.Address = "31 Box Close";
    //////////////////////    TestItem.TelephoneNo = "07736738271";
    //////////////////////    TestItem.DeliveryDate = DateTime.Now.Date;
    //////////////////////    //assign the data propety 
    //////////////////////    AllSuppliers.ThisSupplier = TestItem;
    //////////////////////    //add the record
    //////////////////////    PrimaryKey = AllSuppliers.Add();
    //////////////////////    //set the primary key for the test data
    //////////////////////    TestItem.SupplierID = PrimaryKey;
    //////////////////////    //find the record
    //////////////////////    AllSuppliers.ThisSupplier.Find(PrimaryKey);
    //////////////////////    //test to see that the two values are the same
    //////////////////////    Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
    //////////////////////}
    //////////////////////[TestMethod]
    //////////////////////public void DeleteMethodOk()
    //////////////////////{
    //////////////////////    //create an instance of the class we want to create
    //////////////////////    clsSupplierCollection AllSuppliers = new clsSupplierCollection();
    //////////////////////    //create the intem of test data
    //////////////////////    clsSupplierPage TestItem = new clsSupplierPage();
    //////////////////////    //var to store the primary key 
    //////////////////////    Int32 PrimaryKey = 0;
    //////////////////////    //set its properties 
    //////////////////////    TestItem.Active = true;
    //////////////////////    TestItem.SupplierName = "Nike";
    //////////////////////    TestItem.Address = "31 Box Close";
    //////////////////////    TestItem.TelephoneNo = "07736738271";
    //////////////////////    TestItem.DeliveryDate = DateTime.Now.Date;
    //////////////////////    //set thisStaff to the test data 
    //////////////////////    AllSuppliers.ThisSupplier = TestItem;
    //////////////////////    //add the record
    //////////////////////    PrimaryKey = AllSuppliers.Add();
    //////////////////////    //set the primary key of the test data
    //////////////////////    TestItem.SupplierID = PrimaryKey;
    //////////////////////    //find the record
    //////////////////////    AllSuppliers.ThisSupplier.Find(PrimaryKey);
    //////////////////////    //delete the record
    //////////////////////    AllSuppliers.Delete();
    //////////////////////    //now find the record 
    //////////////////////    Boolean Found = AllSuppliers.ThisSupplier.Find(PrimaryKey);
    //////////////////////    //test to see that the record was not found 
    //////////////////////    Assert.IsFalse(Found);
    //////////////////////}
}