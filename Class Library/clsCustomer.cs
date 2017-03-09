using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public string Active { get; set; }
        public int ContactNumber { get; set; }
        public int CustomerID { get; set; }
        public DateTime DateJoined { get; set; }
        public string EmailAddress { get; set; }
        public string Name { get; set; }
        public string PostCode { get; set; }

        public bool Find(Int32 CustomerID)
        {
            // always return true
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