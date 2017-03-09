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

        public int CustomerNo {
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
            //set private data member to test the data value
            mOrderNo = 1;
            mOrderDate = Convert.ToDateTime("16/02/2016");
            mCustomerName = "Jhon Wick";
            mActive = true;
            mCustomerNo = Convert.ToInt32("1");
            mNumberOfOrder = 1;

          
            //always return value
            return true;
        }
    }
}