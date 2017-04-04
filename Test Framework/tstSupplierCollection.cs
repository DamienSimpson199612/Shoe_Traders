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
    }
}
