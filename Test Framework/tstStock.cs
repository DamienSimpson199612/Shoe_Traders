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
    }
}
