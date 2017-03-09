using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace Test_Framework
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //test to see it exists
            Assert.IsNotNull(NewStock);
        }

        [TestMethod]
        public void StockIDPropertyOK()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            NewStock.StockID = TestData;
            //test to see it exists
            Assert.AreEqual(NewStock.StockID, TestData);
        }

        [TestMethod]
        public void SizePropertyOK()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 8;
            //assign the data to the property
            NewStock.Size = TestData;
            //test to see it exists
            Assert.AreEqual(NewStock.Size, TestData);
        }

        [TestMethod]
        public void StockAmountPropertyOK()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 100;
            //assign the data to the property
            NewStock.StockAmount = TestData;
            //test to see it exists
            Assert.AreEqual(NewStock.StockAmount, TestData);
        }

        [TestMethod]
        public void BrandPropertyOK()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Nike";
            //assign the data to the property
            NewStock.Brand = TestData;
            //test to see it exists
            Assert.AreEqual(NewStock.Brand, TestData);
        }

        [TestMethod]
        public void ShoeNamePropertyOK()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Air Max";
            //assign the data to the property
            NewStock.ShoeName = TestData;
            //test to see it exists
            Assert.AreEqual(NewStock.ShoeName, TestData);
        }

        [TestMethod]
        public void ColourPropertyOK()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Black";
            //assign the data to the property
            NewStock.Colour = TestData;
            //test to see it exists
            Assert.AreEqual(NewStock.Colour, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to assign to the property
            Int32 StockID = 1;
            //invoke the method
            Found = NewStock.Find(StockID);
            //test to see it exists
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockIDFound()
        {
            //create an instance of the class we want to create
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to assign to the property
            Int32 StockID = 1;
            //invoke the method
            Found = NewStock.Find(StockID);
            //check the stock id
            if (NewStock.StockID != 1)
            {
                OK = false;
            }
            //test to see it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSizeFound()
        {
            //create an instance of the class we want to create
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to assign to the property
            Int32 StockID = 1;
            //invoke the method
            Found = NewStock.Find(StockID);
            //check the stock id
            if (NewStock.Size != 8)
            {
                OK = false;
            }
            //test to see it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockAmountFound()
        {
            //create an instance of the class we want to create
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to assign to the property
            Int32 StockID = 1;
            //invoke the method
            Found = NewStock.Find(StockID);
            //check the stock id
            if (NewStock.StockAmount != 100)
            {
                OK = false;
            }
            //test to see it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBrandFound()
        {
            //create an instance of the class we want to create
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to assign to the property
            Int32 StockID = 1;
            //invoke the method
            Found = NewStock.Find(StockID);
            //check the stock id
            if (NewStock.Brand != "Nike")
            {
                OK = false;
            }
            //test to see it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShoeNameFound()
        {
            //create an instance of the class we want to create
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to assign to the property
            Int32 StockID = 1;
            //invoke the method
            Found = NewStock.Find(StockID);
            //check the stock id
            if (NewStock.ShoeName != "Max 13")
            {
                OK = false;
            }
            //test to see it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestColourFound()
        {
            //create an instance of the class we want to create
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to assign to the property
            Int32 StockID = 1;
            //invoke the method
            Found = NewStock.Find(StockID);
            //check the stock id
            if (NewStock.Colour != "Black")
            {
                OK = false;
            }
            //test to see it exists
            Assert.IsTrue(OK);
        }
    }
}
