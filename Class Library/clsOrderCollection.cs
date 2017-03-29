using System.Collections.Generic;
using System;
using MyClassLibrary;

namespace Class_Library

{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        //public property for the address list

        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
                //for Later
            }
        }
        public List<clsOrder> OrderList
        {
            get
            {
                //RETURN PRIVATE DATA
                return mOrderList;
            }

            set
            {
                //set the private data member
                mOrderList = value;
            }
        }
        public clsOrder ThisOrder { get; set; }

        //constructer for the class 
        public clsOrderCollection()
        {
            //create items of the test data
            clsOrder TestItem = new clsOrder();
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            //EXECUTE THE STORED PROCEDURE
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the record count
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsOrder AnOrder = new clsOrder();
                //read in the feilds
                AnOrder.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnOrder.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrder.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                AnOrder.NumberOfOrder = Convert.ToInt32(DB.DataTable.Rows[Index]["NumberOfOrder"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                //add the record
                mOrderList.Add(AnOrder);
                //point the record
                Index++;




            }

        }

    }
}
   
