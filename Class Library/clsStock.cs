using System;

namespace Class_Library
{
    public class clsStock
    {
        //private data member for the StockID property
        private Int32 mStockID;
        //private data member for the Size property
        private Int32 mSize;
        //private data member for the StockAmount property
        private Int32 mStockAmount;
        //private data member for the Brand property
        private string mBrand;
        //private data member for the ShoeName property
        private string mShoeName;
        //private data member for the Colour property
        private string mColour;


        //public property for the stock id
        public int StockID
        {
            get
            {
                //return the private data
                return mStockID;
            }

            set
            {
                //set the value of the private data member
                mStockID = value;
            }
        }

        //public property for the brand
        public string Brand
        {
            get
            {
                //return the private data
                return mBrand;
            }

            set
            {
                //set the value of the private data member
                mBrand = value;
            }
        }

        //public property for the colour
        public string Colour
        {
            get
            {
                //return the private data
                return mColour;
            }

            set
            {
                //set the value of the private data member
                mColour = value;
            }
        }

        //public property for the shoe name
        public string ShoeName
        {
            get
            {
                //return the private data
                return mShoeName;
            }

            set
            {
                //set the value of the private data member
                mShoeName = value;
            }
        }

        //public property for the size
        public int Size
        {
            get
            {
                //return the private data
                return mSize;
            }

            set
            {
                //set the value of the private data member
                mSize = value;
            }
        }

        //public property for the stock amount
        public int StockAmount
        {
            get
            {
                //return the private data
                return mStockAmount;
            }

            set
            {
                //set the value of the private data member
                mStockAmount = value;
            }
        }

        public bool Find(Int32 StockID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the stock id to search for
            DB.AddParameter("@StockID", StockID);
            //execute the stored procedure
            DB.Execute("sproc_Stock_FilterByStockID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStockID = Convert.ToInt32(DB.DataTable.Rows[0]["StockID"]);
                mSize = Convert.ToInt32(DB.DataTable.Rows[0]["Size"]);
                mStockAmount = Convert.ToInt32(DB.DataTable.Rows[0]["StockAmount"]);
                mBrand = Convert.ToString(DB.DataTable.Rows[0]["Brand"]);
                mShoeName = Convert.ToString(DB.DataTable.Rows[0]["ShoeName"]);
                mColour = Convert.ToString(DB.DataTable.Rows[0]["Colour"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
    }
}