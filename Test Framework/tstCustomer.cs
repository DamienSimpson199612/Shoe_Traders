using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomer
    { {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsCustomer Customer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(Customer);
        }
        [TestMethod]
        public void Address()
        {
            //create an instance of the class we want to create 
            clsCustomer Customer = new clsCustomer();
            //create some data to assign to the property
            string TestData = "123 High Street";
            //assign the data to the property
            Customer.Active = TestData;
            //test to see that the two values are th esame
            Assert.AreEqual(Customer.Active, TestData);
        }
        [TestMethod]
        public void ContactNumber()
        {
            //create an instance of the class we want to create 
            clsCustomer Customer = new clsCustomer();
            //create some data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            Customer.ContactNumber = TestData;
            //test to see that the two values are th esame
            Assert.AreEqual(Customer.ContactNumber, TestData);
        }
        [TestMethod]
        public void CustomerID()
        {
            //create an instance of the class we want to create 
            clsCustomer Customer = new clsCustomer();
            //create some data to assign to the property
            Int32 TestData = 11;
            //assign the data to the property
            Customer.CustomerID = TestData;
            //test to see that the two values are th esame
            Assert.AreEqual(Customer.CustomerID, TestData);
        }
        [TestMethod]
        public void DateJoined()
        {
            //create an instance of the class we want to create 
            clsCustomer Customer = new clsCustomer();
            //create some data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Customer.DateJoined = TestData;
            //test to see that the two values are th esame
            Assert.AreEqual(Customer.DateJoined, TestData);
        }
        [TestMethod]
        public void EmailAddress()
        {
            //create an instance of the class we want to create 
            clsCustomer Customer = new clsCustomer();
            //create some data to assign to the property
            string TestData = "high_123@hotmail.com";
            //assign the data to the property
            Customer.EmailAddress = TestData;
            //test to see that the two values are th esame
            Assert.AreEqual(Customer.EmailAddress, TestData);
        }
        [TestMethod]
        public void Name()
        {
            //create an instance of the class we want to create 
            clsCustomer Customer = new clsCustomer();
            //create some data to assign to the property
            string TestData = "QAYZ";
            //assign the data to the property
            Customer.Name = TestData;
            //test to see that the two values are th esame
            Assert.AreEqual(Customer.Name, TestData);
        }
        [TestMethod]
        public void PostCode()
        {
            //create an instance of the class we want to create 
            clsCustomer Customer = new clsCustomer();
            //create some data to assign to the property
            string TestData = "Le1 1SG";
            //assign the data to the property
            Customer.PostCode = TestData;
            //test to see that the two values are th esame
            Assert.AreEqual(Customer.PostCode, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some data to use with the method
            string PostCode = "LE1 1SG";
            //invoke the method
            Found = Customer.Find(PostCode);
            //test tto see that the reuslt is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some data to use with the method
            Int32 CustomerID = 11;
            string Name = "qayz";
            string Address = "123 High Street";
            //invoke the method
            OK = Customer.Valid(CustomerID, Name, Address);
            //test tto see that the reuslt is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void NameMinBoundary()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            Int32 CustomerID = 11;
            string Name = "qayz";
            string Address = "123 High Street";
            //invoke the method
            Ok = ACustomer.Valid(CustomerID, Name, Address);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void NameMinPlus1()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            Int32 CustomerID = 11;
            string Name = "qayz";
            string Address = "123 High Street";
            //invoke the method
            Ok = ACustomer.Valid(CustomerID, Name, Address);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void NameMaxlessOne()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "";
            Name = Name.PadRight(35, 'a');
            string Address = "123 High Street";
            Int32 CustomerID = 11;
            //invoke the method
            Ok = ACustomer.Valid(CustomerID, Name, Address);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void NameMaxBoundary()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "";
            Name = Name.PadRight(36, 'a');
            string Address = "123 High Street";
            Int32 CustomerID = 11;
            //invoke the method
            Ok = ACustomer.Valid(CustomerID, Name, Address);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "";
            Name = Name.PadRight(37, 'a');
            string Address = "123 High Street";
            Int32 CustomerID = 11;
            //invoke the method
            Ok = ACustomer.Valid(CustomerID, Name, Address);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void NameMid()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "";
            Name = Name.PadRight(18, 'a');
            string Address = "123 High Street";
            Int32 CustomerID = 11;
            //invoke the method
            Ok = ACustomer.Valid(CustomerID, Name, Address);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "";
            Name = Name.PadRight(100, 'a');
            string Address = "123 High Street";
            Int32 CustomerID = 11;
            //invoke the method
            Ok = ACustomer.Valid(CustomerID, Name, Address);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void AddressMinBoundary()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            Int32 CustomerID = 11;
            string Name = "qayz";
            string Address = "aa";
            //invoke the method
            Ok = ACustomer.Valid(CustomerID, Name, Address);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            Int32 CustomerID = 11;
            string Name = "qayz";
            string Address = "aaa";
            //invoke the method
            Ok = ACustomer.Valid(CustomerID, Name, Address);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressMaxMinusOne()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            Int32 CustomerID = 11;
            string Name = "qayz";
            string Address = "";
            Address = Address.PadRight(25, 'a');
            //invoke the method
            Ok = ACustomer.Valid(CustomerID, Name, Address);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void AddressMaxBoundary()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            Int32 CustomerID = 11;
            string Name = "qayz";
            string Address = "";
            Address = Address.PadRight(26, 'a');
            //invoke the method
            Ok = ACustomer.Valid(CustomerID, Name, Address);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            Int32 CustomerID = 11;
            string Name = "qayz";
            string Address = "";
            Address = Address.PadRight(27, 'a');
            //invoke the method
            Ok = ACustomer.Valid(CustomerID, Name, Address);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void AddressMid()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            Int32 CustomerID = 11;
            string Name = "qayz";
            string Address = "";
            Address = Address.PadRight(13, 'a');
            //invoke the method
            Ok = ACustomer.Valid(CustomerID, Name, Address);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            Int32 CustomerID = 11;
            string Name = "qayz";
            string Address = "";
            Address = Address.PadRight(300, 'a');
            //invoke the method
            Ok = ACustomer.Valid(CustomerID, Name, Address);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }
    }
}
