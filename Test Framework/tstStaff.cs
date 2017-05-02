using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Test_Framework
{
    [TestClass]
    public class tstStaff
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
        public void Postcode()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //create some test data tp assign to the property
            String TestData = "LE27EF";
            //asign the data to the property
            Staff.Postcode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.Postcode, TestData);

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
            Int32 StaffID = 1;
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
            Int32 StaffID = 1;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the property
            if (Staff.Active == true)
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
            Int32 StaffID = 1;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the property
            if (Staff.FirstName != "Chloe")
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
            Int32 StaffID = 1;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the property
            if (Staff.LastName != "Jane")
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
            Int32 StaffID = 1;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the property
            if (Staff.Address != "this Street")
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
            Int32 StaffID = 1;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the property
            if (Staff.County != "Nottinghamshire")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPostcodeFound()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the property
            if (Staff.Postcode != "Le3 5fa")
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
            Int32 StaffID = 1;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the property
            if (Staff.MobileNo != "07732785042")
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
            Int32 StaffID = 1;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the property
            if (Staff.PayrollNo != "P12345")
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
            Int32 StaffID = 1;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the property
            if (Staff.RoleType != "Manager")
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
            Int32 StaffID = 1;
            //invoke the method
            Found = Staff.Find(StaffID);
            //check the property
            if (Staff.TrainingCompleted != "All")
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
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }




        [TestMethod]
        public void FirstNameLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "";
            string LastName = "Simpson";
            string Address = "this Street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "a";
            string LastName = "Simpson";
            string Address = "this Street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "aa";
            string LastName = "Simpson";
            string Address = "this Street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "abcdefghijabcdefghij abcdefghijabcdefghijabcdefghi";
            string LastName = "Simpson";
            string Address = "this Street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghij";
            string LastName = "Simpson";
            string Address = "this Street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "abcdefghijabcdefghijabcde";
            string LastName = "Simpson";
            string Address = "this Street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "abcdefghijabcdefghij abcdefghijabcdefghijabcdefghija";
            string LastName = "Simpson";
            string Address = "this Street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }



        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 'a'); //should fail
            string LastName = "Simpson";
            string Address = "this Street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void LastNameLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "";
            string Address = "this Street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "a";
            string Address = "this Street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "aa";
            string Address = "this Street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghi";
            string Address = "this Street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "";
            LastName = LastName.PadLeft(50, 'a');
            string Address = "this Street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "abcdefghijabcdefghijabcde";
            string Address = "this Street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "abcdefghijabcdefghij abcdefghijabcdefghijabcdefghija";
            string Address = "this Street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }



        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "";
            LastName = LastName.PadRight(500, 'a'); //should fail
            string Address = "this Street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, MobileNo, County, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "a";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "aa";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "abcdefghijabcdefghij abcdefghijabcdefghijabcdefghi";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressNameMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghij";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void AddressNameMid()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "abcdefghijabcdefghijabcde";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "abcdefghijabcdefghij abcdefghijabcdefghijabcdefghija";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }



        [TestMethod]
        public void AddresseExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "";
            Address = Address.PadRight(500, 'a'); //should fail
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PostcodeLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PostcodeMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "a";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostcodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "aa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostcodeMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "abcefg";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostcodeNameMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "abcefgh";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PostcodeMid()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "abc";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PostcodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "abcefghi";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }



        [TestMethod]
        public void PostcodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "";
            Postcode = Postcode.PadRight(500, '0'); //should fail
            string County = "Nottinghamshire";
            string MobileNo = "";
            string PayrollNo = "07732785042";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void CountyMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "a";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CountyMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "aa";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CountyMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "";
            County = County.PadRight(49, '0'); //should fail
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CountyMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "";
            County = County.PadRight(50, '0'); //should fail
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CountyMid()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "";
            County = County.PadRight(25, '0'); //should fail
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CountyMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "";
            County = County.PadRight(51, '0'); //should fail
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "";
            TrainingCompleted = TrainingCompleted.PadRight(501, '0'); //should fail
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }



        [TestMethod]
        public void CountyExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "";
            County = County.PadRight(200, '0'); //should fail
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "";
            TrainingCompleted = TrainingCompleted.PadRight(1000, '0'); //should fail
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void MobileLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void MobileMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "0";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void MobileMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "01";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void MobileMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "01234567891";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void MobileNameMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "012345678912";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County,MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void MobileMid()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "012345";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void MobileMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "0123456789123";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }



        [TestMethod]
        public void MobileExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "";
            MobileNo = MobileNo.PadRight(500, '0'); //should fail
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PayrollNoLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PayrollNoMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "0";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PayrollNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "01";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PayrollNoMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "012345678";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PayrollNoNameMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "0123456789";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PayrollNoMid()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "01234";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PayrollNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "01234567890";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }



        [TestMethod]
        public void PayrollNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            PayrollNo = PayrollNo.PadRight(11, '0'); //should fail
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void RoleTypeNoLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void RoleTypeMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "a";
            string RoleType = "Manager";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void RoleTypeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "aa";
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void RoleTypeMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "";
            RoleType = RoleType.PadRight(49, '0'); //should fail
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void RoleTypeNameMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "";
            RoleType = RoleType.PadRight(50, '0'); //should fail
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void RoleTypeMid()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "";
            RoleType = RoleType.PadRight(25, '0'); //should fail
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void RoleTypeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "";
            RoleType = RoleType.PadRight(51, '0'); //should fail
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }



        [TestMethod]
        public void RoleTypeExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "";
            RoleType = RoleType.PadRight(200, '0'); //should fail
            string TrainingCompleted = "All";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TrainingCompletedMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "a";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TrainingCompletedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "aa";
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TrainingCompletedMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "";
            TrainingCompleted = TrainingCompleted.PadRight(499, '0'); //should fail

            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TrainingCompletedMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "";
            TrainingCompleted = TrainingCompleted.PadRight(500, '0'); //should fail
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TrainingCompletedMid()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "";
            TrainingCompleted = TrainingCompleted.PadRight(250, '0'); //should fail
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TrainingCompletedMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "";
            TrainingCompleted = TrainingCompleted.PadRight(501, '0'); //should fail
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }



        [TestMethod]
        public void TrainingCompletedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = false;
            string FirstName = "Damien";
            string LastName = "Simpson";
            string Address = "this street";
            string Postcode = "Le3 5fa";
            string County = "Nottinghamshire";
            string MobileNo = "07732785042";
            string PayrollNo = "P12345";
            string RoleType = "Manager";
            string TrainingCompleted = "";
            TrainingCompleted = TrainingCompleted.PadRight(1000, '0'); //should fail
            //invoke the method
            OK = Staff.Valid(FirstName, LastName, Address, Postcode, County, MobileNo, PayrollNo, RoleType, TrainingCompleted);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
    }
}
