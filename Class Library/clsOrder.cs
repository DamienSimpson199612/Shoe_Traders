using System;

namespace MyClassLibrary
{
    public class clsOrder
    {
        //private data member for order No
        private Int32 mOrderNo;
        //private data member for Active
        private Boolean mActive;
        //private data member for date added
        private DateTime mOrderDate;
        //private data member for customername
        private string mCustomerName;
        //private data member customerno
        private int mCustomerNo;
        //private data 
        private int mNumberOfOrder;
        public clsOrder()
        {

        }
        public int OrderNo
        {
            get
            {
                //return private data
                return mOrderNo;
            }
            set
            {
                //set the value of the private data member
                mOrderNo = value;
            }
        }

        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set private data member
                mActive = value;
            }
        }
        public string CustomerName
        {
            get
            {
                return mCustomerName;
            }
            set
            {
                //set private data member
                mCustomerName = value;
            }
        }

        public int CustomerNo
        {
            get
            {
                return mCustomerNo;
            }
            set
            {
                //set private data member
                mCustomerNo = value;

            }
        }
        public DateTime DateAdded
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                //set private data member
                mOrderDate = value;
            }
        }
        public int NumberOfOrder
        {
            get
            {
                return mNumberOfOrder;
            }
            set
            {
                //set private data member
                mNumberOfOrder = value;
            }
        }




        public bool Find(int OrderNo)

        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the paramerter for the address no to search for
            DB.AddParameter("@OrderNo", OrderNo);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderNo");
            //If one record is found should be one or zero
            if (DB.Count == 1)

            {
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mNumberOfOrder = Convert.ToInt32(DB.DataTable.Rows[0]["NumberOfOrder"]);

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

        public bool Valid(string OrderDate, string CustomerName, string CustomerNo, string NumberOfOrder)
        {
            //create a boolean varibale flag an error
            Boolean OK = true;
            //create  atemp var to store data values
            DateTime DateTemp;
            //IF the customername is blank
            if (CustomerName.Length == 0)
            {
                OK = false;
            }
            if (CustomerName.Length > 50)
            {
                OK = false;
            }

            //IF the numberof order is blank
            if (NumberOfOrder.Length == 0)
            {
                OK = false;
            }
            if (NumberOfOrder.Length > 6)
            {
                OK = false;
            }

            //try the date validation
            try
            {
                //copy the date added value to the date temp 
                DateTemp = Convert.ToDateTime(OrderDate);
                //check to see if the data is less than todays date
                if (DateTemp < DateTime.Now.Date)
                {
                    //flag as false
                    OK = false;

                }

                //check to see if the data is greater than todays date
                if (DateTemp > DateTime.Now.Date)
                {
                    //set flag ok to false
                    OK = false;
                }
            }
            //catch teh data data to flag an error
            catch
            {
                OK = false;
            }
            
            
                return OK;
            }
    }
    }
    

