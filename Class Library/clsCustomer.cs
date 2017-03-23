using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for th ecustomer ID property
        private Int32 mCustomerID;
        //private data member for mName
        private string mName;
        //private data member for mContactNumber
        private string mContactNumber;
        //private data member for mAddress
        private string mAddress;
        //private data member for Datejoined
        private DateTime mDateJoined;
        //private data member for memailaddress
        private string mEmailAddress;
        //private data member for mPostcode
        private string mPostCode;
        //private data member for mActive
        private bool mActive;
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }
        public string Address
        {
            get
            {
                //return the private data
                return mAddress;
            }
            set
            {
                //set the private data
                mAddress = value;
            }
        }
        public string ContactNumber
        {
            get
            {
                //return the private data
                return mContactNumber;
            }
            set
            {
                //set the private data
                mContactNumber = value;
            }
        }
        public int CustomerID
        {
            get
            {
                //return the private data
                return mCustomerID;
            }
            set
            {
                //set the private data
                mCustomerID = value;
            }
        }
        public DateTime DateJoined
        {
            get
            {
                //return the private data
                return mDateJoined;
            }
            set
            {
                //set the private data
                mDateJoined = value;
            }
        }
        public string EmailAddress
        {
            get
            {
                //return the private data
                return mEmailAddress;
            }
            set
            {
                //set the private data
                mEmailAddress = value;
            }
        }
        public string Name
        {
            get
            {
                //return the private data
                return mName;
            }
            set
            {
                //set the private data
                mName = value;
            }
        }
        public string PostCode
        {
            get
            {
                //return the private data
                return mPostCode;
            }
            set
            {
                //set the private data
                mPostCode = value;
            }
        }

        public bool Find(Int32 CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the cusotomer id to search for 
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_Customers_FilterByCustomerID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mContactNumber = Convert.ToString(DB.DataTable.Rows[0]["ContactNumber"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mDateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["DateJoined"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);

                //return that everything worked ok
                return true;
            }
            //if no record was found 
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public bool Valid(string name, string address, string postcode, string contactnumber, string emailaddress, string dateJoined)
        {
            // boolean variable
            Boolean Ok = true;
            DateTime DateTemp;
            if (name.Length == 0)
            {
                Ok = false;
            }
            if (name.Length < 4)
            {
                Ok = false;
            }
            if (name.Length > 36)
            {
                Ok = false;
            }

            if (address.Length == 0)
            {
                Ok = false;
            }
            if (address.Length < 2)
            {
                Ok = false;
            }
            if (address.Length > 26)
            {
                Ok = false;
            }

            try
            {
                DateTemp = Convert.ToDateTime(dateJoined);
                if (DateTemp > DateTime.Now.Date)
                {
                    Ok = false;
                }
                if (DateTemp < DateTime.Now.Date)
                {
                    Ok = false;
                }

            }
            catch
            {
                Ok = false;
            }

            if (postcode.Length == 0)
            {
                Ok = false;
            }
            if (postcode.Length < 6)
            {
                Ok = false;
            }
            if (postcode.Length > 12)
            {
                Ok = false;
            }
            if (contactnumber.Length == 0)
            {
                Ok = false;
            }
            if (contactnumber.Length < 11)
            {
                Ok = false;
            }
            if (contactnumber.Length > 14)
            {
                Ok = false;
            }

            if (emailaddress.Length == 0)
            {
                Ok = false;
            }
            if (emailaddress.Length < 10)
            {
                Ok = false;
            }
            if (emailaddress.Length > 40)
            {
                Ok = false;
            }



            return Ok;
        }
    }
}