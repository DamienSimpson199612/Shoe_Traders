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
        private DateTime mDateAdded;
        //private data member DateAdded
        private Int64 mTelephone;

        public Int32 SupplierID;

        public clsSupplierPage()
        {

        }

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
        public DateTime DateAdded
        {
            get
            {
                //return data
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
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
        public Int64 TelephoneNo
        {
            get
            {
                //return data
                return mTelephone;
            }
            set
            {
                mTelephone = value;
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
            DB.Execute("sproc_tblSupplier_FilterSupplierNo");
            //If one record is found should be one or zero
            if (DB.Count == 1)

            {
                mSupplierNo = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierNo"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mTelephone = Convert.ToInt64(DB.DataTable.Rows[0]["Telephone"]);
                mDeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DeliveryDate"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);

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
    }
}





