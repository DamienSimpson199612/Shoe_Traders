using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace Test_Framework
{
    [TestClass]
    public class TestLog_clsStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(Staff);
        }


        [TestMethod]
        public void ActiveStaffMember()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data tp assign to the property
            Boolean TestData = true;
            //asign the data to the property
            Staff.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.Active, TestData);

        }

        [TestMethod]
        public void Address()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data tp assign to the property
            String TestData = "21b";
            //asign the data to the property
            Staff.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.Address, TestData);

        }

        [TestMethod]
        public void County()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data tp assign to the property
            String TestData = "Nottinghamshire";
            //asign the data to the property
            Staff.County = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.County, TestData);

        }

        [TestMethod]
        public void FirstName()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data tp assign to the property
            String TestData = "Dez";
            //asign the data to the property
            Staff.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.FirstName, TestData);

        }

        [TestMethod]
        public void LastName()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data tp assign to the property
            String TestData = "Oppang";
            //asign the data to the property
            Staff.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.LastName, TestData);

        }

        [TestMethod]
        public void MobileNo()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data tp assign to the property
            String TestData = "1";
            //asign the data to the property
            Staff.MobileNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.MobileNo, TestData);

        }

        [TestMethod]
        public void PayrollNo()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data tp assign to the property
            String TestData = "1";
            //asign the data to the property
            Staff.PayrollNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.PayrollNo, TestData);

        }

        [TestMethod]
        public void PostCode()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data tp assign to the property
            String TestData = "LE27EF";
            //asign the data to the property
            Staff.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.PostCode, TestData);

        }

        [TestMethod]
        public void RoleType()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data tp assign to the property
            String TestData = "Manager";
            //asign the data to the property
            Staff.RoleType = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.RoleType, TestData);

        }

        [TestMethod]
        public void StaffID()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data tp assign to the property
            Int32 TestData = 1;
            //asign the data to the property
            Staff.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.StaffID, TestData);

        }

        [TestMethod]
        public void TrainingCompleted()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data tp assign to the property
            String TestData = "FirstAid";
            //asign the data to the property
            Staff.TrainingCompleted = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.TrainingCompleted, TestData);

        }

        [TestMethod]
        public void FindMethodOK()
        {

            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method
            Found = Staff.Find(StaffID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

       

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the property
            if (Staff.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the address no
            if (Staff.StaffID != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the property
            if (Staff.FirstName != "Test First Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the property
            if (Staff.LastName != "Test Last Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the property
            if (Staff.Address != "Test Address")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCountyFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the property
            if (Staff.County != "Test County")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the property
            if (Staff.PostCode != "Test12")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
 

        [TestMethod]
        public void TestMobileNoFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the property
            if (Staff.MobileNo != "1")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPayrollNoFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the property
            if (Staff.PayrollNo != "PayrollNo")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestRoleTypeFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the property
            if (Staff.RoleType != "Test RoleType")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTrainingCompletedFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the property
            if (Staff.TrainingCompleted != "Test TrainingCompleted")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some data to use with the method
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this Street";
            string Postcode = "Le3 5fa";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }




        [TestMethod]
        public void FirstNameLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            string FirstName = "";
            string LastName = "Simpson";
            string Address = "this Street";
            string Postcode = "Le3 5fa";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            string FirstName = "a";
            string LastName = "Simpson";
            string Address = "this Street";
            string Postcode = "Le3 5fa";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            string FirstName = "aa";
            string LastName = "Simpson";
            string Address = "this Street";
            string Postcode = "Le3 5fa";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FirstNameMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            string FirstName = "abcdefghijabcdefghij abcdefghijabcdefghijabcdefghi";
            string LastName = "Simpson";
            string Address = "this Street";
            string Postcode = "Le3 5fa";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            string FirstName = "abcdefghijabcdefghij abcdefghijabcdefghijabcdefghij";
            string LastName = "Simpson";
            string Address = "this Street";
            string Postcode = "Le3 5fa";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            string FirstName = "abcdefghijabcdefghij abcdefghijabcdefghijabcdefghija";
            string LastName = "Simpson";
            string Address = "this Street";
            string Postcode = "Le3 5fa";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            string FirstName = "abcdefghijabcdefghijabcde";
            string LastName = "Simpson";
            string Address = "this Street";
            string Postcode = "Le3 5fa";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            string FirstName = "abcdefghijabcdefghij abcdefghijabcdefghijabcdefghij abcdefghijabcdefghij abcdefghijabcdefghijabcdefghij abcdefghijabcdefghij abcdefghijabcdefghijabcdefghij abcdefghijabcdefghij abcdefghijabcdefghijabcdefghij";
            string LastName = "Simpson";
            string Address = "this Street";
            string Postcode = "Le3 5fa";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        //[TestMethod]
        //public void TestLastNameFound()
        //{
        //    //create an instance of the class we want to create
        //    clsStaff Staff = new clsStaff();
        //    //boolean variable to store the result of the search
        //    Boolean Found = false;
        //    //boolean variable to record if data is OK (assume it is)
        //    Boolean OK = true;
        //    //create some test data to use with the method
        //    Int32 StaffID = 21;
        //    //invoke the method
        //    Found = Staff.Find(StaffID);
        //    //check the property
        //    if (Staff.LastName != "Test Last Name")
        //    {
        //        OK = false;
        //    }
        //    //test to see that the result is correct
        //    Assert.IsTrue(OK);
        //}

        //[TestMethod]
        //public void TestAddressFound()
        //{
        //    //create an instance of the class we want to create
        //    clsStaff Staff = new clsStaff();
        //    //boolean variable to store the result of the search
        //    Boolean Found = false;
        //    //boolean variable to record if data is OK (assume it is)
        //    Boolean OK = true;
        //    //create some test data to use with the method
        //    Int32 StaffID = 21;
        //    //invoke the method
        //    Found = Staff.Find(StaffID);
        //    //check the property
        //    if (Staff.Address != "Test Address")
        //    {
        //        OK = false;
        //    }
        //    //test to see that the result is correct
        //    Assert.IsTrue(OK);
        //}
        //[TestMethod]
        //public void TestCountyFound()
        //{
        //    //create an instance of the class we want to create
        //    clsStaff Staff = new clsStaff();
        //    //boolean variable to store the result of the search
        //    Boolean Found = false;
        //    //boolean variable to record if data is OK (assume it is)
        //    Boolean OK = true;
        //    //create some test data to use with the method
        //    Int32 StaffID = 21;
        //    //invoke the method
        //    Found = Staff.Find(StaffID);
        //    //check the property
        //    if (Staff.County != "Test County")
        //    {
        //        OK = false;
        //    }
        //    //test to see that the result is correct
        //    Assert.IsTrue(OK);
        //}
        //[TestMethod]
        //public void TestPostCodeFound()
        //{
        //    //create an instance of the class we want to create
        //    clsStaff Staff = new clsStaff();
        //    //boolean variable to store the result of the search
        //    Boolean Found = false;
        //    //boolean variable to record if data is OK (assume it is)
        //    Boolean OK = true;
        //    //create some test data to use with the method
        //    Int32 StaffID = 21;
        //    //invoke the method
        //    Found = Staff.Find(StaffID);
        //    //check the property
        //    if (Staff.PostCode != "Test PostCode")
        //    {
        //        OK = false;
        //    }
        //    //test to see that the result is correct
        //    Assert.IsTrue(OK);
        //}


        //[TestMethod]
        //public void TestMobileNoFound()
        //{
        //    //create an instance of the class we want to create
        //    clsStaff Staff = new clsStaff();
        //    //boolean variable to store the result of the search
        //    Boolean Found = false;
        //    //boolean variable to record if data is OK (assume it is)
        //    Boolean OK = true;
        //    //create some test data to use with the method
        //    Int32 StaffID = 21;
        //    //invoke the method
        //    Found = Staff.Find(StaffID);
        //    //check the property
        //    if (Staff.MobileNo != 1)
        //    {
        //        OK = false;
        //    }
        //    //test to see that the result is correct
        //    Assert.IsTrue(OK);
        //}

        //[TestMethod]
        //public void TestPayrollNoFound()
        //{
        //    //create an instance of the class we want to create
        //    clsStaff Staff = new clsStaff();
        //    //boolean variable to store the result of the search
        //    Boolean Found = false;
        //    //boolean variable to record if data is OK (assume it is)
        //    Boolean OK = true;
        //    //create some test data to use with the method
        //    Int32 StaffID = 21;
        //    //invoke the method
        //    Found = Staff.Find(StaffID);
        //    //check the property
        //    if (Staff.PayrollNo != "Test PayrollNo")
        //    {
        //        OK = false;
        //    }
        //    //test to see that the result is correct
        //    Assert.IsTrue(OK);
        //}

        //[TestMethod]
        //public void TestRoleTypeFound()
        //{
        //    //create an instance of the class we want to create
        //    clsStaff Staff = new clsStaff();
        //    //boolean variable to store the result of the search
        //    Boolean Found = false;
        //    //boolean variable to record if data is OK (assume it is)
        //    Boolean OK = true;
        //    //create some test data to use with the method
        //    Int32 StaffID = 21;
        //    //invoke the method
        //    Found = Staff.Find(StaffID);
        //    //check the property
        //    if (Staff.RoleType != "Test RoleType")
        //    {
        //        OK = false;
        //    }
        //    //test to see that the result is correct
        //    Assert.IsTrue(OK);
        //}

        //[TestMethod]
        //public void TestTrainingCompletedFound()
        //{
        //    //create an instance of the class we want to create
        //    clsStaff Staff = new clsStaff();
        //    //boolean variable to store the result of the search
        //    Boolean Found = false;
        //    //boolean variable to record if data is OK (assume it is)
        //    Boolean OK = true;
        //    //create some test data to use with the method
        //    Int32 StaffID = 21;
        //    //invoke the method
        //    Found = Staff.Find(StaffID);
        //    //check the property
        //    if (Staff.TrainingCompleted != "Test TrainingCompleted")
        //    {
        //        OK = false;
        //    }
        //    //test to see that the result is correct
        //    Assert.IsTrue(OK);
        //}

    }




}

