using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //priavte data member for the list 
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

        //public property for ThisCustomer
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set th eprivate data
                mThisCustomer = value;
            }
        }

        //public property for the customer list
        public int Count
        {
            get
            {
                //return the count foer the list 
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //public property for the customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        public clsCustomerCollection()
        {

            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            // excute the stored procedure
            DB.Execute("sproc_Customers_SelectAll");
            //populate th earray list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisCustomer
            //connect to th edatabase
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@DateJoined", mThisCustomer.DateJoined);
            DB.AddParameter("@Active", mThisCustomer.Active);
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@ContactNumber", mThisCustomer.ContactNumber);
            //execute th equery returning the primary keyvalue 
            return DB.Execute("sproc_Customers_Insert");
        }

        public void Delete()
        {
            //delete the record pointed to by thisCustomers
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //excute the store procedure
            DB.Execute("sproc_Customers_Delete");
        }

        public void Update()
        {
            //adds a new record to the database based on the values of mThisCustomer
            //connect to th edatabase
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@DateJoined", mThisCustomer.DateJoined);
            DB.AddParameter("@Active", mThisCustomer.Active);
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@ContactNumber", mThisCustomer.ContactNumber);
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute th equery returning the primary keyvalue 
            DB.Execute("sproc_Customers_Update");
        }

        public void FilterByCustomerID(int CustomerID)
        {
            //filters the record based on a full or partial postcode
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the lastname parameter to the database
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_Customers_FilterByCustomerID");
            //populate the array list with data table 
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            CustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields from the current record
                AnCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnCustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AnCustomer.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                AnCustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnCustomer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                AnCustomer.ContactNumber = Convert.ToString(DB.DataTable.Rows[Index]["ContactNumber"]);
                AnCustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnCustomer.DateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateJoined"]);
                //add the record to the private data mamber
                CustomerList.Add(AnCustomer);
                //point at the next record
                Index++;
            }

        }
    }
}
