using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;
using ClassLibrary;

namespace tstLog_CustomerList
{
    [TestClass]
    public class SprintLog_Customer
    {
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
            Int32 CustomerID = 1;
            //invoke the method
            Found = Customer.Find(CustomerID);
            //test tto see that the reuslt is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some data to use with the method
            string Name = "qayz";
            string Address = "123 High Street";
            string Postcode = "Le3 5fa";
            string ContactNumber = "07732785042";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test tto see that the reuslt is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void NameMinBoundary()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "123 High Street";
            string Postcode = "Le3 5fa";
            string ContactNumber = "07732785042";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void NameMinimumMinus1()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qay";
            string Address = "123 High Street";
            string Postcode = "Le3 5fa";
            string ContactNumber = "07732785042";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void NameMinPlus1()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "123 High Street";
            string Postcode = "Le3 5fa";
            string ContactNumber = "07732785042";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
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
            string Postcode = "Le3 5fa";
            string ContactNumber = "07732785042";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
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
            string Postcode = "Le3 5fa";
            string ContactNumber = "07732785042";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
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
            string Postcode = "Le3 5fa";
            string ContactNumber = "07732785042";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
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
            string Postcode = "Le3 5fa";
            string ContactNumber = "07732785042";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
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
            string Postcode = "Le3 5fa";
            string ContactNumber = "07732785042";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void AddressMinimumMinus1()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "a";
            string Postcode = "Le3 5fa";
            string ContactNumber = "07732785042";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
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
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "Le3 5fa";
            string ContactNumber = "07732785042";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
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
            string Name = "qayz";
            string Address = "aaa";
            string Postcode = "Le3 5fa";
            string ContactNumber = "07732785042";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
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
            string Name = "qayz";
            string Address = "";
            Address = Address.PadRight(25, 'a');
            string Postcode = "Le3 5fa";
            string ContactNumber = "07732785042";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
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
            string Name = "qayz";
            string Address = "";
            Address = Address.PadRight(26, 'a');
            string Postcode = "Le3 5fa";
            string ContactNumber = "07732785042";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
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
            string Name = "qayz";
            string Address = "";
            Address = Address.PadRight(27, 'a');
            string Postcode = "Le3 5fa";
            string ContactNumber = "07732785042";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
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
            string Name = "qayz";
            string Address = "";
            Address = Address.PadRight(13, 'a');
            string Postcode = "Le3 5fa";
            string ContactNumber = "07732785042";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
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
            string Name = "qayz";
            string Address = "";
            Address = Address.PadRight(300, 'a');
            string Postcode = "Le3 5fa";
            string ContactNumber = "07732785042";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void PostcodeMinMinus1()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "L3 5f";
            string ContactNumber = "07732785042";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void PostcodeMinBoundary()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "LE35SF";
            string ContactNumber = "07732785042";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void PostcodeMinPlusOne()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "LE135SF";
            string ContactNumber = "07732785042";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void PostcodeMaxMinus1()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "LE13 35SGGF";
            string ContactNumber = "07732785042";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void PostcodeMaxBoundary()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "LE13 SA35SSF";
            string ContactNumber = "07732785042";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void PostcodeMaxPlus1()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "LE13 SX3X5SSF";
            string ContactNumber = "07732785042";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void PostcodeMid()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "LE1X4X";
            string ContactNumber = "07732785042";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void PostcodeExtremeMax()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "";
            Postcode = Postcode.PadRight(40, 'a');
            string ContactNumber = "07732785042";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void ContactNumberMinMius1()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "Le1 1fs";
            string ContactNumber = "0773278502";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void ContactNumberMinimumBoaundary()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "Le1 1fs";
            string ContactNumber = "07733278502";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void ContactNumberMinPlus1()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "Le1 1fs";
            string ContactNumber = "077332748502";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void ContactNumberMaxMinus1()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "Le1 1fs";
            string ContactNumber = "0773327485";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void ContactNumberMaximum()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "Le1 1fs";
            string ContactNumber = "07733274888532";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void ContactNumberMaximumPlus1()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "Le1 1fs";
            string ContactNumber = "077332748584322";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void ContactNumberMid()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "Le1 1fs";
            string ContactNumber = "0773327";
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void ContactNumberExtremeMax()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "Le1 1fs";
            string ContactNumber = "";
            ContactNumber = ContactNumber.PadRight(100, '0');
            string EmailAddress = "high_123@hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void EmailAddressMinus1()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "Le1 1fs";
            string ContactNumber = "07733567827";
            string EmailAddress = "hotmail.c";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void EmailAddressMinimumBoundary()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "Le1 1fs";
            string ContactNumber = "07733567827";
            string EmailAddress = "hotmail.co";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailAddressMinPlus1()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "Le1 1fs";
            string ContactNumber = "07733567827";
            string EmailAddress = "hotmail.com";
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailAddressMaxMinus1()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "Le1 1fs";
            string ContactNumber = "07733567827";
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(39, 'a');
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void EmailAddressMaxBoundary()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "Le1 1fs";
            string ContactNumber = "07733567827";
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(40, 'a');
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailAddressMaxPlus1()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "Le1 1fs";
            string ContactNumber = "07733567827";
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(41, 'a');
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void EmailAddressMid()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "Le1 1fs";
            string ContactNumber = "07733567827";
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(20, 'a');
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            //create instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "Le1 1fs";
            string ContactNumber = "07733567827";
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(100, 'a');
            string DateJoined = DateTime.Now.Date.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            //test to see that the result is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void DateJoinedMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results
            Boolean Ok = false;
            //create some that data that passes 
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "Le1 1fs";
            string ContactNumber = "07733567827";
            string EmailAddress = "hotmail.co";
            //var to store the date
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //set to yesterdays day
            TestDate = TestDate.AddDays(-1);
            //convert the data to string
            string DateJoined = TestDate.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void DateJoinedMinimumBoundary()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results
            Boolean Ok = false;
            //create some that data that passes 
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "Le1 1fs";
            string ContactNumber = "07733567827";
            string EmailAddress = "hotmail.co";
            //var to store the date
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //convert the data to string
            string DateJoined = TestDate.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void DateJoinedMinPlus1()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results
            Boolean Ok = false;
            //create some that data that passes 
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "Le1 1fs";
            string ContactNumber = "07733567827";
            string EmailAddress = "hotmail.co";
            //var to store the date
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //set to tomorrows date
            TestDate = TestDate.AddDays(1);
            //convert the data to string
            string DateJoined = TestDate.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void DateJoinedMaxMinus1()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results
            Boolean Ok = false;
            //create some that data that passes 
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "Le1 1fs";
            string ContactNumber = "07733567827";
            string EmailAddress = "hotmail.co";
            //var to store the date
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //set to tomorrows date
            TestDate = TestDate.AddDays(-1);
            //convert the data to string
            string DateJoined = TestDate.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            Assert.IsFalse(Ok);
        }
        public void DateJoinedMaximumBoundary()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results
            Boolean Ok = false;
            //create some that data that passes 
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "Le1 1fs";
            string ContactNumber = "07733567827";
            string EmailAddress = "hotmail.co";
            //var to store the date
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //convert the data to string
            string DateJoined = TestDate.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void DateJoinedMaxPlus1()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results
            Boolean Ok = false;
            //create some that data that passes 
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "Le1 1fs";
            string ContactNumber = "07733567827";
            string EmailAddress = "hotmail.co";
            //var to store the date
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //set to tomorrows date
            TestDate = TestDate.AddDays(1);
            //convert the data to string
            string DateJoined = TestDate.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void DateJoinedMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results
            Boolean Ok = false;
            //create some that data that passes 
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "Le1 1fs";
            string ContactNumber = "07733567827";
            string EmailAddress = "hotmail.co";
            //var to store the date
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //convert the data to string
            string DateJoined = TestDate.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void DateJoinedExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results
            Boolean Ok = false;
            //create some that data that passes 
            string Name = "qayz";
            string Address = "aa";
            string Postcode = "Le1 1fs";
            string ContactNumber = "07733567827";
            string EmailAddress = "hotmail.co";
            //var to store the date
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //change the dat eto whatevrr the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the data to string
            string DateJoined = TestDate.ToString();
            //invoke the method
            Ok = ACustomer.Valid(Name, Address, Postcode, ContactNumber, EmailAddress, DateJoined);
            Assert.IsFalse(Ok);
        }
    }
}