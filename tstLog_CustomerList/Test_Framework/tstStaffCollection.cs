using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ClassLibrary;

namespace Test_Framework
{

        [TestClass]
        public class tstStaffCollection
        {
            [TestMethod]
            public void InstanceOk()
            {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
                //test to see that it exists
                Assert.IsNotNull(AllStaff);
            }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //screate some test data to assign to the property
            //in this case that data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create some data 
            clsStaff TestItem = new clsStaff();
            //set properties
           
            TestItem.FirstName = "Damien";
            TestItem.LastName = "Simpson";
            TestItem.Address = "this Street";
            TestItem.Postcode = "Le3 5fa";
            TestItem.County = "Nottinghamshire";
            TestItem.PayrollNo = "P12345";
            TestItem.MobileNo = "07732785042";
            TestItem.RoleType = "Manager";
             TestItem.Active = true;
            TestItem.TrainingCompleted = "All";
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the proprty
            AllStaff.StaffList = TestList;
            //test to see that the result is correct
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    //create an instance of the class we want to create
        //    clsStaffCollection AllStaff = new clsStaffCollection();
        //    //create some test data to assign to the property
        //    Int32 SomeCount = 3;
        //    //assign the data to the property
        //    AllStaff.Count = SomeCount;
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllStaff.Count, SomeCount);
        //}
        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //screate some test data to assign to the property
            //in this case that data needs to be a list of objects
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.Active = true;
            TestStaff.FirstName = "Damien";
            TestStaff.LastName = "Simpson";
            TestStaff.Address = "this Street";
            TestStaff.Postcode = "Le3 5fa";
            TestStaff.County = "Nottinghamshire";
            TestStaff.MobileNo = "07732785042";
            TestStaff.PayrollNo = "P12345";
            TestStaff.RoleType = "Manager";
            TestStaff.TrainingCompleted = "All";
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Active = true;
            TestItem.FirstName = "Damien";
            TestItem.LastName = "Simpson";
            TestItem.Address = "this Street";
            TestItem.Postcode = "Le3 5fa";
            TestItem.County = "Nottinghamshire";
            TestItem.MobileNo = "07732785042";
            TestItem.PayrollNo = "P12345";
            TestItem.RoleType = "Manager";
            TestItem.TrainingCompleted = "All";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }
        //[TestMethod]

        //public void TwoRecordsPresents()
        //{
        //    //create an instance of the class we want to create 
        //    clsStaffCollection AllStaff = new clsStaffCollection();
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllStaff.Count, 3);


        //}

        [TestMethod]
        public void AddMethodOk()
        {
            //create an instance of of th eclass we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //var to the store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.FirstName ="Damien";
            TestItem.LastName ="Simpson";
            TestItem.Address ="this Street";
            TestItem.Postcode ="Le3 5fa";
            TestItem.County ="Nottinghamshire";
            TestItem.MobileNo ="07732785042";
            TestItem.PayrollNo ="P12345";
            TestItem.TrainingCompleted ="All";
            TestItem.Active = true;
            TestItem.RoleType ="Manager";
            TestItem.StaffID = 2;
            //set thisCusotmer to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the tets data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are th esame
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);


        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the intem of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            
            TestItem.FirstName = "Damien";
            TestItem.LastName = "Simpson";
            TestItem.Address = "this Street";
            TestItem.Postcode = "Le3 5fa";
            TestItem.County = "Nottinghamshire";
            TestItem.MobileNo = "07732785042";
            TestItem.PayrollNo = "P12345";
            TestItem.TrainingCompleted = "All";
            TestItem.Active = true;
            TestItem.RoleType = "Manager";

            //set thisStaff to the test data 
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record 
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found 
            Assert.IsFalse(Found);


        }
        [TestMethod]
        public void UpdateMethodOk()
        {
            //create an instance of of th eclass we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //var to the store the primary key
            Int32 PrimaryKey = 2;
            //set its properties
            TestItem.Active = true;
            TestItem.FirstName = "Damien";
            TestItem.LastName = "Simpson";
            TestItem.Address = "this Street";
            TestItem.Postcode = "Le3 5fa";
            TestItem.County = "Nottinghamshire";
            TestItem.MobileNo = "07732785042";
            TestItem.PayrollNo = "P12345";
            TestItem.RoleType = "Manager";
            TestItem.TrainingCompleted = "All";
            TestItem.StaffID = 2;
            //set thisCusotmer to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the tets data
            TestItem.StaffID = PrimaryKey;
            //modify the test data
            TestItem.Active = false;
            TestItem.FirstName = "Chloe";
            TestItem.LastName = "Jane";
            TestItem.Address = "this Street";
            TestItem.Postcode = "Le3 5fa";
            TestItem.County = "Nottinghamshire";
            TestItem.MobileNo = "07732785042";
            TestItem.PayrollNo = "P12345";
            TestItem.RoleType = "Manager";
            TestItem.TrainingCompleted = "All";
            TestItem.StaffID = 2;
            //set the records based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //Find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are th esame
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }

        //[TestMethod]
        //public void FilterByStaffIDMethodOk()
        //{
        //    //create an instance of the class containing unfiltered results 
        //    clsStaffCollection AllStaff = new clsStaffCollection();
        //    //create an instance of the filtered data 
        //    clsStaffCollection FilteredStaff = new clsStaffCollection();
        //    //apply a blank string (should return all records)
        //    FilteredStaff.FilterByStaffID(2);
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);

        //}


        //[TestMethod]
        //public void FilterByStaffIDNoneFound()
        //{

        //    //create an instance of the filtered data 
        //    clsStaffCollection FilteredStaff = new clsStaffCollection();
        //    //apply a blank string (should return all records)
        //    FilteredStaff.FilterByStaffID(3);
        //    //test to see that the two values are the same
        //    Assert.AreEqual(0, FilteredStaff.Count);

        //}

        //[TestMethod]
        //public void FilterByStaffIDTestDataFound()
        //{

        //    //create an instance of the filtered data 
        //    clsStaffCollection FilteredStaff = new clsStaffCollection();
        //    //var to store outcome
        //    Boolean OK = true;
        //    //apply a last name that doesnt exist
        //    FilteredStaff.FilterByStaffID(2);
        //    //check that the correct number of records are found
        //    if (FilteredStaff.Count == 2)
        //    {
        //        //check that the first record is ID 4
        //        if (FilteredStaff.StaffList[0].StaffID != 4)
        //        {
        //            OK = false;


        //        }
        //        //check that the first record is ID 2
        //        if (FilteredStaff.StaffList[0].StaffID != 2)
        //        {
        //            OK = false;
        //        }
        //        else
        //        {
        //            OK = false;
        //        }
        //        //test to see that there are no records
        //        Assert.IsTrue(OK);
        //    }


        }
    }
    

