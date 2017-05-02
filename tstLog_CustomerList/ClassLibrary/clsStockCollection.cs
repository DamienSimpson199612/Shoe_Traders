using Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //private data member ThisStock
        clsStock mThisStock = new clsStock();

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStockList.Count;
            }
            set
            {
                //we will worry about this later
            }
        }

        //public property for the stock list
        public List<clsStock> StockList
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }

        //public property for ThisStock
        public clsStock ThisStock
        {
            get
            {
                //return the private data
                return mThisStock;
            }
            set
            {
                //set the private data
                mThisStock = value;
            }
        }

        //constructor for the class
        public clsStockCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_Stock_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsStock NewStock = new clsStock();
                //read in the fields from the current record
                NewStock.Brand = Convert.ToString(DB.DataTable.Rows[Index]["Brand"]);
                NewStock.Colour = Convert.ToString(DB.DataTable.Rows[Index]["Colour"]);
                NewStock.ShoeName = Convert.ToString(DB.DataTable.Rows[Index]["ShoeName"]);
                NewStock.Size = Convert.ToInt32(DB.DataTable.Rows[Index]["Size"]);
                NewStock.StockAmount = Convert.ToInt32(DB.DataTable.Rows[Index]["StockAmount"]);
                NewStock.StockID = Convert.ToInt32(DB.DataTable.Rows[Index]["StockID"]);
                //add the record to the private data member
                mStockList.Add(NewStock);
                //increment the index by 1
                Index++;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of ThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Brand", mThisStock.Brand);
            DB.AddParameter("@ShoeName", mThisStock.ShoeName);
            DB.AddParameter("@Colour", mThisStock.Colour);
            DB.AddParameter("@Size", mThisStock.Size);
            DB.AddParameter("@StockAmount", mThisStock.StockAmount);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@StockID", mThisStock.StockID);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters
            DB.AddParameter("@StockID", mThisStock.StockID);
            DB.AddParameter("@Brand", mThisStock.Brand);
            DB.AddParameter("@ShoeName", mThisStock.ShoeName);
            DB.AddParameter("@Colour", mThisStock.Colour);
            DB.AddParameter("@Size", mThisStock.Size);
            DB.AddParameter("@StockAmount", mThisStock.StockAmount);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Update");
        }
    }
}