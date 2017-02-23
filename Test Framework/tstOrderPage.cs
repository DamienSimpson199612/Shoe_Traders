﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using Class_Library;

namespace UnitTestProject
{
    /// <summary>
    /// Summary description for tstOrderPage
    /// </summary>
    [TestClass]
    public class tstOrderPage
    {
        public tstOrderPage()
        {
            //
            // TODO: Add constructor logic here
            //
        }




        [TestMethod]
        public void InstanceOK()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //test to see it exists
            Assert.IsNotNull(AnOrder);

        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //test to see it exists
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Active = TestData;
            //test to see the two halves are the same
            Assert.AreEqual(AnOrder.Active, TestData);
        }
        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //test to see it exists
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DateAdded = TestData;
            //test to see the two halves are the same
            Assert.AreEqual(AnOrder.DateAdded, TestData);
        }
        [TestMethod]
        public void OrderNoPropertyOK()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //test to see it exists
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderNo = TestData;
            //test to see the two halves are the same
            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }
        [TestMethod]
        public void NumberOfOrderPropertyOK()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //test to see it exists
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.NumberOfOrder = TestData;
            //test to see the two halves are the same
            Assert.AreEqual(AnOrder.NumberOfOrder, TestData);
        }
        [TestMethod]
        public void CustomerNamepropertyOK()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //test to see it exists
            string TestData = "JHON";
            //assign the data to the property
            AnOrder.CustomerName = TestData;
            //test to see the two halves are the same
            Assert.AreEqual(AnOrder.CustomerName, TestData);
        }
        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //test to see it exists
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.CustomerNo = TestData;
            //test to see the two halves are the same
            Assert.AreEqual(AnOrder.CustomerNo, TestData);
        }
        [TestMethod]
        public void PricePropertyOK()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //test to see it exists
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.Price = TestData;
            //test to see the two halves are the same
            Assert.AreEqual(AnOrder.Price, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = AnOrder.Find(CustomerNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCustomerNoFound()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some data to use with the method
            Boolean OK = true;
            //invoke the method
            Int32 OrderNo = 21;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the address No
            if (AnOrder.OrderNo != 21)
            {
                OK = false;
            }
            //TEST TO SEE WHAT IS CORRECT
            Assert.IsTrue(OK);
        }

    }
}

