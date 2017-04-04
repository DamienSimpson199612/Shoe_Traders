using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;
using System.Collections.Generic;
using MyClassLibrary;

namespace Test_Framework
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a instance 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see if it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create a instance 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see if it exists
            //create some test data to assign the property
            //in this case the data needs needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerName = "Jhon Wick";
            TestItem.CustomerNo = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            //assign the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see th etwo values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);

        }
      
        [TestMethod]
        public void     ThisOrderPropertyOK()
        {
            //create a instance 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some data to assign the property
            clsOrder TestOrders = new clsOrder();
            //set the properties of the test project
            TestOrders.Active = true;
            TestOrders.CustomerName = "Jhon Wick";
            TestOrders.CustomerNo = 1;
            TestOrders.OrderDate = DateTime.Now.Date;
            //assign the data propety 
            AllOrders.ThisOrder = TestOrders;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrders);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create a instance 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //create some data to assign the property
            clsOrder TestOrders = new clsOrder();
            //set the properties of the test project
            TestOrders.Active = true;
            TestOrders.CustomerName = "Jhon Wick";
            TestOrders.CustomerNo = 1;
            TestOrders.OrderDate = DateTime.Now.Date;
            TestOrders.OrderNo = 1;
            TestOrders.NumberOfOrder = 1;
            //assign the data propety 
            TestList.Add(TestOrders);
            AllOrders.OrderList = TestList;
            //test to see if the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create a instance 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //create some data to assign the property
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            //set the properties of the test project
            TestItem.Active = true;
            TestItem.CustomerName = "Steven Martin";
            TestItem.CustomerNo = 3;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderNo = 1;
            TestItem.NumberOfOrder = 7;
            //assign the data propety 
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key for the test data
            TestItem.OrderNo = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create a instance 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //list of objects
            
            //create some data to assign the property
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            //set the properties of the test project
            TestItem.Active = true;
            TestItem.CustomerName = "Steven Martin";
            TestItem.CustomerNo = 3;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderNo = 1;
            TestItem.NumberOfOrder = 7;
            //assign the data propety 
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key for the test data
            TestItem.OrderNo = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }


    }
}



