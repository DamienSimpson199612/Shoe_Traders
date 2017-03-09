using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;
using Class_Library;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.Name = "John Smith";
            TestItem.Address = "26 Highfields Street";
            TestItem.PostCode = "LE2 0XZ";
            TestItem.ContactNumber = "07986543211";
            TestItem.EmailAddress = "John_smith@hotmail.co.uk";
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.CustomerID = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomerCollection AllCustomers = new clsCustomerCollection();
        //    //create some test data to assign to the property
        //    Int32 SomeCount = 2;
        //    //assign the data to the property
        //    AllCustomers.Count = SomeCount;
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllCustomers.Count, SomeCount);
        //}

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.Active = true;
            TestCustomer.Name = "John Smith";
            TestCustomer.Address = "26 Highfields Street";
            TestCustomer.PostCode = "LE2 0XZ";
            TestCustomer.ContactNumber = "07986543211";
            TestCustomer.EmailAddress = "John_smith@hotmail.co.uk";
            TestCustomer.DateJoined = DateTime.Now.Date;
            TestCustomer.CustomerID = 1;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.Name = "John Smith";
            TestItem.Address = "26 Highfields Street";
            TestItem.PostCode = "LE2 0XZ";
            TestItem.ContactNumber = "07986543211";
            TestItem.EmailAddress = "John_smith@hotmail.co.uk";
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.CustomerID = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
        //[TestMethod]

        //public void TwoRecordsPresents()
        //{
        //    //create an instance of the class we want to create 
        //    clsCustomerCollection AllCustomer = new clsCustomerCollection();
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllCustomer.Count, 2);


        //}

        [TestMethod]
        public void AddMethodOk()
        {
            //create an instance of of th eclass we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //var to the store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.Name = "John Smith";
            TestItem.Address = "26 Highfields Street";
            TestItem.PostCode = "LE2 0XZ";
            TestItem.ContactNumber = "07986543211";
            TestItem.EmailAddress = "John_smith@hotmail.co.uk";
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.CustomerID = 2;
            //set thisCusotmer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the tets data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are th esame
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the intem of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.CustomerID = 2;
            TestItem.Active = false;
            TestItem.Name = "John Smith";
            TestItem.Address = "26 High Street";
            TestItem.PostCode = "LE3 1JK";
            TestItem.ContactNumber = "07986543211";
            TestItem.EmailAddress = "John23_smith@hotmail.co.uk";
            TestItem.DateJoined = DateTime.Now.Date;
            //set thiscustomer to the test data 
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record 
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found 
            Assert.IsFalse(Found);


        }

        [TestMethod]
        public void UpdateMethodOk()
        {
            //create an instance of of th eclass we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //var to the store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.Name = "John Smith";
            TestItem.Address = "26 Highfields Street";
            TestItem.PostCode = "LE2 0XZ";
            TestItem.ContactNumber = "07986543211";
            TestItem.EmailAddress = "John_smith@hotmail.co.uk";
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.CustomerID = 2;
            //set thisCusotmer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the tets data
            TestItem.CustomerID = PrimaryKey;
            //modify the test data
            TestItem.Active = false;
            TestItem.Name = "Johnathan Smith";
            TestItem.Address = "26 High Street";
            TestItem.PostCode = "LE3 1JK";
            TestItem.ContactNumber = "07986543211";
            TestItem.EmailAddress = "John23_smith@hotmail.co.uk";
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.CustomerID = 2;
            //set the records based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //Find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are th esame
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }

        [TestMethod]
        public void FilterByPostCodeMethodOk()
        {
            //create an instance of the class containing unfiltered results 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data 
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            //apply a blank string (should return all records)
            FilteredCustomer.FilterByPostCode("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomer.Count);

        }

        [TestMethod]
        public void FilterByPostCodeNoneFound()
        {

            //create an instance of the filtered data 
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            //apply a blank string (should return all records)
            FilteredCustomer.FilterByPostCode("xxxxxxxx");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredCustomer.Count);

        }

        [TestMethod]
        public void FilterByPostCodeTestDataFound()
        {

            //create an instance of the filtered data 
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a last name that doesnt exist
            FilteredCustomer.FilterByPostCode("yyy yyy");
            //check that the correct number of records are found
            if (FilteredCustomer.Count == 2)
            {
                //check that the first record is ID 4
                if (FilteredCustomer.CustomerList[0].CustomerID != 4)
                {
                    OK = false;


                }
                //check that the first record is ID 2
                if (FilteredCustomer.CustomerList[0].CustomerID != 2)
                {
                    OK = false;
                }
                else
                {
                    OK = false;
                }
                //test to see that there are no records
                Assert.IsTrue(OK);
            }


        }
    }
}