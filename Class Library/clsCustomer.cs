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

        public bool Find(string postCode)
        {
            //always return true
            return true;
        }

        public bool Valid(int customerID, string name, string address)
        {
            // boolean variable
            Boolean Ok = true;
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
            return Ok;
        }
    }
}
