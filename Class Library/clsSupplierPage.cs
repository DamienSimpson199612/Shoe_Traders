using System;

namespace MyClassLibrary
{
    public class clsSupplierPage
    {
        //private data member for order No
        private Int32 mSupplierNo;
        //private data member for Active
        private Boolean mActive;
        //private data member for date added
        private DateTime mDeliveryDate;
        //private data member for customername
        private string mSupplierName;
        //private data member for Address
        private string mAddress;
        //private data member DateAdded
        private string mTelephoneNo;

        public Int32 SupplierID;


        public bool Active
        {
            get
            {
                //return data
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }
        public string Address
        {
            get
            {
                //return data
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }

        public DateTime DeliveryDate
        {
            get
            {
                //return data
                return mDeliveryDate;
            }
            set
            {
                mDeliveryDate = value;
            }
        }
        public string SupplierName
        {
            get
            {
                //return data
                return mSupplierName;
            }
            set
            {
                mSupplierName = value;
            }
        }

        public int SupplierNo
        {
            get
            {
                //return data
                return mSupplierNo;
            }
            set
            {
                mSupplierNo = value;
            }
        }
        public string TelephoneNo
        {
            get
            {
                //return data
                return mTelephoneNo;
            }
            set
            {
                mTelephoneNo = value;
            }
        
        }

        public bool Valid(int numOfSupplier, DateTime DeliveryDate)
        {

            Boolean Ok = true;
            DateTime tempDate;
            if (numOfSupplier == 0)
            {
                Ok = false;
            }
            if (numOfSupplier > 100)
            {
                Ok = false;

            }
            if (numOfSupplier < 0)
            {
                Ok = false;
            }

            try
            {
                tempDate = Convert.ToDateTime(DeliveryDate);
                if (tempDate < DateTime.Now.Date)
                {
                    Ok = false;
                }

                if (tempDate > DateTime.Now.Date)
                {
                    Ok = false;
                }
            }

            catch
            { }
            return Ok;

        }

        public bool Find(int SupplierNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the paramerter for the address no to search for
            DB.AddParameter("@SupplierNo", SupplierNo);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterBySupplierNo");
            //If one record is found should be one or zero
            if (DB.Count == 1)

            {
                mSupplierNo = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierNo"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mTelephoneNo = Convert.ToString(DB.DataTable.Rows[0]["Telephone"]);
                mDeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DeliveryDate"]);


                //always return value
                return true;
            }
            //if no record was found
            else
            {
                //return false indicate problem
                return false;
            }
        }

        public bool Valid(string supplierName,string telephoneNo,string address, string deliveryDate)
        {
            //create a boolean var to show error
            Boolean OK = true;
            //create a temporary variable to store the data values
            DateTime DateTemp;
            //if
            if (supplierName.Length == 0)
            {
                OK = false;
            }
            if (supplierName.Length > 6)
            {
                OK = false;
            }
            //try the date validation assuming the data is valid date
            try
            {
                //copy the DeliveryDate value to the DateTemp varaible
                DateTemp = Convert.ToDateTime(deliveryDate);
                //check to see if the date is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    OK = false;
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //set the flag OK to false
                    OK = false;

                }
            }
            //the data was not a date so flag error
            catch
            {
                //set the flag Ok to false
                OK = false;

            }
            //is the address blank
            if (address.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the address is too long
            if (address.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
           // is the address blank
            if (telephoneNo.Length < 11)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the address is too long
            if (telephoneNo.Length > 12)
            {
                //set the flag OK to false
                OK = false;
            }
            //return value Ok
            return OK;
           }
        }  
    }






