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
            if (NewStock.ShoeName != "Air Max 2017")
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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "Gazelle";
            string Colour = "Red";
            string Size = "9";
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void BrandMinLessOne()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = ""; //this should trigger an error
            string ShoeName = "Gazelle";
            string Colour = "Red";
            string Size = "9";
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void BrandMin()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "a"; //this should be OK
            string ShoeName = "Gazelle";
            string Colour = "Red";
            string Size = "9";
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void BrandMinPlusOne()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "aa"; //this should be OK
            string ShoeName = "Gazelle";
            string Colour = "Red";
            string Size = "9";
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void BrandMaxLessOne()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "aaaaaaaaaaaaaaaaaaa"; //this should be OK
            string ShoeName = "Gazelle";
            string Colour = "Red";
            string Size = "9";
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void BrandMax()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "aaaaaaaaaaaaaaaaaaaa"; //this should be OK
            string ShoeName = "Gazelle";
            string Colour = "Red";
            string Size = "9";
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void BrandMid()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "aaaaaaaaaa"; //this should be OK
            string ShoeName = "Gazelle";
            string Colour = "Red";
            string Size = "9";
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void BrandMaxPlusOne()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "aaaaaaaaaaaaaaaaaaaaa"; //this should fail
            string ShoeName = "Gazelle";
            string Colour = "Red";
            string Size = "9";
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void BrandExtremeMax()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "";
            Brand = Brand.PadRight(500, 'a'); //this should fail
            string ShoeName = "Gazelle";
            string Colour = "Red";
            string Size = "9";
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ShoeNameMinLessOne()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = ""; //this should trigger an error
            string Colour = "Red";
            string Size = "9";
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ShoeNameMin()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "a"; //this should be OK
            string Colour = "Red";
            string Size = "9";
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ShoeNameMinPlusOne()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "aa"; //this should be OK
            string Colour = "Red";
            string Size = "9";
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ShoeNameMaxLessOne()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be OK
            string Colour = "Red";
            string Size = "9";
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ShoeNameMax()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be OK
            string Colour = "Red";
            string Size = "9";
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ShoeNameMid()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "aaaaaaaaaaaaaaa"; //this should be OK
            string Colour = "Red";
            string Size = "9";
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ShoeNameMaxPlusOne()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            string Colour = "Red";
            string Size = "9";
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ShoeNameExtremeMax()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "";
            ShoeName = ShoeName.PadRight(500, 'a'); //this should fail
            string Colour = "Red";
            string Size = "9";
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ColourMinLessOne()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "Gazelle";
            string Colour = ""; //this should trigger an error
            string Size = "9";
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ColourMin()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "Gazelle";
            string Colour = "a"; //this should be OK
            string Size = "9";
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ColourMinPlusOne()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "Gazelle";
            string Colour = "aa"; //this should be OK
            string Size = "9";
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ColourMaxLessOne()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "Gazelle";
            string Colour = "aaaaaaaaa"; //this should be OK
            string Size = "9";
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ColourNameMax()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "Gazelle";
            string Colour = "aaaaaaaaaa"; //this should be OK
            string Size = "9";
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ColourNameMid()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "Gazelle";
            string Colour = "aaaaa"; //this should be OK
            string Size = "9";
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ColourMaxPlusOne()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "Gazelle";
            string Colour = "aaaaaaaaaaa"; //this should fail
            string Size = "9";
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ColourExtremeMax()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "Gazelle";
            string Colour = "";
            Colour = Colour.PadRight(500, 'a'); //this should fail
            string Size = "9";
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void SizeMinLessOne()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "Gazelle";
            string Colour = "Red";
            string Size = "0"; //this should trigger an error
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void SizeMin()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "Gazelle";
            string Colour = "Red";
            string Size = "1"; //this should be OK
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SizeMinPlusOne()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "Gazelle";
            string Colour = "Red";
            string Size = "2"; //this should be OK
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SizeMaxLessOne()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "Gazelle";
            string Colour = "Red";
            string Size = "24"; //this should be OK
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SizeMax()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "Gazelle";
            string Colour = "Red";
            string Size = "25"; //this should be OK
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SizeMid()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "Gazelle";
            string Colour = "Red";
            string Size = "12"; //this should be OK
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SizeMaxPlusOne()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "Gazelle";
            string Colour = "Red";
            string Size = "26"; //this should fail
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void SizeExtremeMax()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "Gazelle";
            string Colour = "Red";
            string Size = "200"; //this should fail
            string StockAmount = "200";
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StockAmountMinLessOne()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "Gazelle";
            string Colour = "Red";
            string Size = "9";
            string StockAmount = "0"; //this should trigger an error
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StockAmountMin()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "Gazelle";
            string Colour = "Red";
            string Size = "9";
            string StockAmount = "1"; //this should be OK
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StockAmountMinPlusOne()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "Gazelle";
            string Colour = "Red";
            string Size = "9";
            string StockAmount = "2"; //this should be OK
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StockAmountMaxLessOne()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "Gazelle";
            string Colour = "Red";
            string Size = "9";
            string StockAmount = "4999"; //this should be OK
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StockAmountMax()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "Gazelle";
            string Colour = "Red";
            string Size = "9";
            string StockAmount = "5000"; //this should be OK
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StockAmountMid()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "Gazelle";
            string Colour = "Red";
            string Size = "9";
            string StockAmount = "2500"; //this should be OK
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StockAmountMaxPlusOne()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "Gazelle";
            string Colour = "Red";
            string Size = "9";
            string StockAmount = "5001"; //this should fail
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StockAmountExtremeMax()
        {
            //create an instance of the class clsStock
            clsStock NewStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string Brand = "Adidas";
            string ShoeName = "Gazelle";
            string Colour = "Red";
            string Size = "9";
            string StockAmount = "100000"; //this should fail
            //invoke the method
            OK = NewStock.Valid(Brand, ShoeName, Colour, Size, StockAmount);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }
    }
}
