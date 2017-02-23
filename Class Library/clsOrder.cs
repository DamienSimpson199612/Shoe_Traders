using System;

namespace MyClassLibrary
{
    public class clsOrder
    {
        //private data member for order No
        private Int32 mOrderNo;
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

        public bool Active { get; set; }
        public string CustomerName { get; set; }
        public int CustomerNo { get; set; }
        public DateTime DateAdded { get; set; }
        public int NumberOfOrder { get; set; }


        public int Price { get; set; }

        public bool Find(int OrderNo)
        {
            //set private data member to test the data value
            mOrderNo = 21;
            //always return value
            return true;
        }
    }
}