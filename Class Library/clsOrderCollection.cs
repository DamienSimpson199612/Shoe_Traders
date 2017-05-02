using System.Collections.Generic;
using System;
using MyClassLibrary;

namespace Class_Library

{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        //public property for the address list
        clsOrder mThisOrder = new clsOrder();

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
        public clsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set private data
                mThisOrder = value;
            }
        }

        //constructer for the class 
        public clsOrderCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(DB);



            

        }

        public int Add()
        {
            //adds new record to the database 
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the paramaters for the stored procedure
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@CustomerName", mThisOrder.CustomerName);
            DB.AddParameter("@Active", mThisOrder.Active);
            DB.AddParameter("@CustomerNo", mThisOrder.CustomerNo);
            DB.AddParameter("@NumberOfOrder", mThisOrder.NumberOfOrder);
            //execute query
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Delete()
        {
            //////

            //delte teh record pointed by thsi address
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Set the parametrs for the stored procedure
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            //execute teh stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void Update()
        {
            //UPDATE RECORD BASED ON VALUES OF THIS ORDER
            clsDataConnection DB = new clsDataConnection();
           
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@CustomerName", mThisOrder.CustomerName);
            DB.AddParameter("@Active", mThisOrder.Active);
            DB.AddParameter("@CustomerNo", mThisOrder.CustomerNo);
            DB.AddParameter("@NumberOfOrder", mThisOrder.NumberOfOrder);
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            //execute stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }

        public void FilterByCustomerName(string CustomerName)
        {
            //filters the record based on a full or partial postcode
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the lastname parameter to the database
            DB.AddParameter("@CustomerName", CustomerName);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByCustomerName");
            //populate the array list with data table 
            PopulateArray(DB);


        }

        void PopulateArray(clsDataConnection DB)
        {
            //Populates teh array list based on the data table in the parmater db
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the records
            RecordCount = DB.Count;
            //clear the array list 
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                AnOrder.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnOrder.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                AnOrder.NumberOfOrder = Convert.ToInt32(DB.DataTable.Rows[Index]["NumberOfOrder"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                Index++;


            }
        }
    }
}
    

   
