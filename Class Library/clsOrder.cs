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

        public bool Valid(string orderDate, string customerName, string customerNo, string numberOfOrder)
        {
            //create a boolean varibale flag an error
            Boolean OK = true;
            //IF the HouseNo is blank
            if (CustomerName.Length == 0)
            {
                OK = false;
            }
            return OK;
        }
    }
}
