using System;
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
            string TestData = "Jhon Wick";
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
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the address No
            if (AnOrder.OrderNo != 1)
            {
                OK = false;
            }
            //TEST TO SEE WHAT IS CORRECT
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some data to use with the method
            Boolean OK = true;
            //invoke the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the orderno No
            if (AnOrder.Active != true)
            {
                OK = false;
            }
            //TEST TO SEE WHAT IS CORRECT
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderDateFound()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some data to use with the method
            Boolean OK = true;
            //invoke the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the orderno No
            if (AnOrder.DateAdded != Convert.ToDateTime("16/02/2016"))
            {
                OK = false;
            }
            //TEST TO SEE WHAT IS CORRECT
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNumberOfOrderFound()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some data to use with the method
            Boolean OK = true;
            //invoke the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the orderno No
            if (AnOrder.OrderNo != 1)
            {
                OK = false;
            }
            //TEST TO SEE WHAT IS CORRECT
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerNameFound()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some data to use with the method
            Boolean OK = true;
            //invoke the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.CustomerName != "Jhon Wick")
            {
                OK = false;
            }
            //TEST TO SEE WHAT IS CORRECT
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderNumberFound()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some data to use with the method
            Boolean OK = true;
            //invoke the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.OrderNo != 1)
            {
                OK = false;
            }
            //TEST TO SEE WHAT IS CORRECT
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some data to use with the method

            string OrderDate = DateTime.Now.Date.ToString();
            string CustomerName = "Jhon Wick";
            string CustomerNo = "1";
            string NumberOfOrder = "1";
            //invoke method
            OK = AnOrder.Valid(OrderDate, CustomerName, CustomerNo, NumberOfOrder);

            //TEST TO SEE WHAT IS CORRECT
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some data to use with the method

            string OrderDate = DateTime.Now.Date.ToString();
            string CustomerName = "";
            string CustomerNo = "1";
            string NumberOfOrder = "1";
            //invoke method
            OK = AnOrder.Valid(OrderDate, CustomerName, CustomerNo, NumberOfOrder);

            //TEST TO SEE WHAT IS CORRECT
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void CustomerNameMin()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some data to use with the method

            string OrderDate = DateTime.Now.Date.ToString();
            string CustomerName = "J";
            string CustomerNo = "1";
            string NumberOfOrder = "1";
            //invoke method
            OK = AnOrder.Valid(OrderDate, CustomerName, CustomerNo, NumberOfOrder);

            //TEST TO SEE WHAT IS CORRECT
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some data to use with the method

            string OrderDate = DateTime.Now.Date.ToString();
            string CustomerName = "Jh";
            string CustomerNo = "1";
            string NumberOfOrder = "1";
            //invoke method
            OK = AnOrder.Valid(OrderDate, CustomerName, CustomerNo, NumberOfOrder);

            //TEST TO SEE WHAT IS CORRECT
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some data to use with the method

            string OrderDate = DateTime.Now.Date.ToString();
            string CustomerName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string CustomerNo = "1";
            string NumberOfOrder = "1";
            //invoke method
            OK = AnOrder.Valid(OrderDate, CustomerName, CustomerNo, NumberOfOrder);

            //TEST TO SEE WHAT IS CORRECT
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void CustomerNameMax()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some data to use with the method

            string OrderDate = DateTime.Now.Date.ToString();
            string CustomerName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string CustomerNo = "1";
            string NumberOfOrder = "1";
            //invoke method
            OK = AnOrder.Valid(OrderDate, CustomerName, CustomerNo, NumberOfOrder);

            //TEST TO SEE WHAT IS CORRECT
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void CustomerNameMid()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some data to use with the method

            string OrderDate = DateTime.Now.Date.ToString();
            string CustomerName = "Jhon Wick";
            string CustomerNo = "1";
            string NumberOfOrder = "1";
            //invoke method
            OK = AnOrder.Valid(OrderDate, CustomerName, CustomerNo, NumberOfOrder);

            //TEST TO SEE WHAT IS CORRECT
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some data to use with the method

            string OrderDate = DateTime.Now.Date.ToString();
            string CustomerName = "Jhon Wick";
            string CustomerNo = "1";
            string NumberOfOrder = "1";
            //invoke method
            OK = AnOrder.Valid(OrderDate, CustomerName, CustomerNo, NumberOfOrder);

            //TEST TO SEE WHAT IS CORRECT
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some data to use with the method
            string CustomerName = "";
            string OrderDate = DateTime.Now.Date.ToString();
            CustomerName = CustomerName.PadRight(50, 'a');
            string CustomerNo = "1";
            string NumberOfOrder = "1";
            //invoke method
            OK = AnOrder.Valid(OrderDate, CustomerName, CustomerNo, NumberOfOrder);

            //TEST TO SEE WHAT IS CORRECT
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some data to use with the method

            string CustomerName = "Jhon Wick";
            string CustomerNo = "1";
            string NumberOfOrder = "1";
            //create a variable to store the data
            DateTime TestDate;
            //set totays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the data to a variable
            string OrderDate = TestDate.ToString();
            //invoke the medthod
            OK = AnOrder.Valid(OrderDate, CustomerName, CustomerNo, NumberOfOrder);
            Assert.IsFalse(OK);


        }
        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some data to use with the method

            string CustomerName = "Jhon Wick";
            string CustomerNo = "1";
            string NumberOfOrder = "1";
            //create a variable to store the data
            DateTime TestDate;
            //set totays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the data to a variable
            string OrderDate = TestDate.ToString();
            //invoke the medthod
            OK = AnOrder.Valid(OrderDate, CustomerName, CustomerNo, NumberOfOrder);
            Assert.IsFalse(OK);


        }
        [TestMethod]
        public void OrderDateMin()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some data to use with the method

            string CustomerName = "Jhon Wick";
            string CustomerNo = "1";
            string NumberOfOrder = "1";
            //create a variable to store the data
            DateTime TestDate;
            //set totays date
            TestDate = DateTime.Now.Date;

            //convert the data to a variable
            string OrderDate = TestDate.ToString();
            //invoke the medthod
            OK = AnOrder.Valid(OrderDate, CustomerName, CustomerNo, NumberOfOrder);
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some data to use with the method

            string CustomerName = "Jhon Wick";
            string CustomerNo = "1";
            string NumberOfOrder = "1";
            //create a variable to store the data
            DateTime TestDate;
            //set totays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 100 years
            TestDate = TestDate.AddDays(1);
            //convert the data to a variable
            string OrderDate = TestDate.ToString();
            //invoke the medthod
            OK = AnOrder.Valid(OrderDate, CustomerName, CustomerNo, NumberOfOrder);
            Assert.IsFalse(OK);


        }
        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some data to use with the method

            string CustomerName = "Jhon Wick";
            string CustomerNo = "1";
            string NumberOfOrder = "1";
            //create a variable to store the data
            DateTime TestDate;
            //set totays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 100 years
            TestDate = TestDate.AddDays(100);
            //convert the data to a variable
            string OrderDate = TestDate.ToString();
            //invoke the medthod
            OK = AnOrder.Valid(OrderDate, CustomerName, CustomerNo, NumberOfOrder);
            Assert.IsFalse(OK);


        }
        [TestMethod]
        public void OrderDateInvalidData()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some data to use with the method

            string CustomerName = "Jhon Wick";
            string CustomerNo = "1";
            string NumberOfOrder = "1";
            //set teh dateadded to a non date value
            string OrderDate = "this is not  a date!";
            //invoke the method
            OK = AnOrder.Valid(OrderDate, CustomerName, CustomerNo, NumberOfOrder);
            //test to see that the results is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void NumberOfOrderLessOne()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some data to use with the method

            string OrderDate = DateTime.Now.Date.ToString();
            string CustomerName = "Jhon Wick";
            string CustomerNo = "1";
            string NumberOfOrder = "";
            //invoke method
            OK = AnOrder.Valid(OrderDate, CustomerName, CustomerNo, NumberOfOrder);

            //TEST TO SEE WHAT IS CORRECT
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void NumberOfOrderMin()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some data to use with the method

            string OrderDate = DateTime.Now.Date.ToString();
            string CustomerName = "Jhon Wick";
            string CustomerNo = "1";
            string NumberOfOrder = "1";//should be ok
            //invoke method
            OK = AnOrder.Valid(OrderDate, CustomerName, CustomerNo, NumberOfOrder);

            //TEST TO SEE WHAT IS CORRECT
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void NumberOfOrderPlusOne()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some data to use with the method

            string OrderDate = DateTime.Now.Date.ToString();
            string CustomerName = "Jhon Wick";
            string CustomerNo = "1";
            string NumberOfOrder = "2";//should be ok
            //invoke method
            OK = AnOrder.Valid(OrderDate, CustomerName, CustomerNo, NumberOfOrder);

            //TEST TO SEE WHAT IS CORRECT
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void NumberOfOrderMaxLessOne()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some data to use with the method

            string OrderDate = DateTime.Now.Date.ToString();
            string CustomerName = "Jhon Wick";
            string CustomerNo = "1";
            string NumberOfOrder = "5";//should be ok
            //invoke method
            OK = AnOrder.Valid(OrderDate, CustomerName, CustomerNo, NumberOfOrder);

            //TEST TO SEE WHAT IS CORRECT
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void NumberOfOrderMax()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some data to use with the method

            string OrderDate = DateTime.Now.Date.ToString();
            string CustomerName = "Jhon Wick";
            string CustomerNo = "1";
            string NumberOfOrder = "6";//should be ok
            //invoke method
            OK = AnOrder.Valid(OrderDate, CustomerName, CustomerNo, NumberOfOrder);

            //TEST TO SEE WHAT IS CORRECT
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void NumberOfOrderMid()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some data to use with the method

            string OrderDate = DateTime.Now.Date.ToString();
            string CustomerName = "Jhon Wick";
            string CustomerNo = "1";
            string NumberOfOrder = "3";//should be ok
            //invoke method
            OK = AnOrder.Valid(OrderDate, CustomerName, CustomerNo, NumberOfOrder);

            //TEST TO SEE WHAT IS CORRECT
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void NumberOfOrderMaxPlusOne()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some data to use with the method

            string OrderDate = DateTime.Now.Date.ToString();
            string CustomerName = "Jhon Wick";
            string CustomerNo = "1";
            string NumberOfOrder = "1111111";
            //invoke method
            OK = AnOrder.Valid(OrderDate, CustomerName, CustomerNo, NumberOfOrder);

            //TEST TO SEE WHAT IS CORRECT
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void NumberOfOrderExtremeMax()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some data to use with the method

            string OrderDate = DateTime.Now.Date.ToString();
            string CustomerName = "Jhon Wick";
            string CustomerNo = "1";
            string NumberOfOrder = "";
           NumberOfOrder= NumberOfOrder.PadRight(500,'a');
            //invoke method
            OK = AnOrder.Valid(OrderDate, CustomerName, CustomerNo, NumberOfOrder);

            //TEST TO SEE WHAT IS CORRECT
            Assert.IsFalse(OK);

        }
    }
}








