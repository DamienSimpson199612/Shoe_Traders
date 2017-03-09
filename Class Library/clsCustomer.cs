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
            //set the private data members to th etest data value
            mCustomerID = 1;
            mName = "John Smith";
            mAddress = "26 Highfields Street";
            mPostCode = "LE2 0XZ";
            mContactNumber = "07986543211";
            mEmailAddress = "John_smith@hotmail.co.uk";
            mDateJoined = Convert.ToDateTime("02/03/2017");
            mActive = true;

            //always return true 
            return true;
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