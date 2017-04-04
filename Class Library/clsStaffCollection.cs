using System.Collections.Generic;
using System;

namespace Class_Library
{
    public class clsStaffCollection
    {
        //priavte data member for the list 
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member thisStaff
        clsStaff mThisStaff = new clsStaff();

        //public property for ThisStaff
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set th eprivate data
                mThisStaff = value;
            }
        }

        //public property for the Staff list
        public int Count
        {
            get
            {
                //return the count foer the list 
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //public property for the Staff list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        public clsStaffCollection()
        {

            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            // excute the stored procedure
            DB.Execute("sproc_Staff_SelectAll");
            //populate th earray list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisStaff
            //connect to th edatabase
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("@Postcode", mThisStaff.Postcode);
            DB.AddParameter("@County", mThisStaff.County);
            DB.AddParameter("@MobileNo", mThisStaff.MobileNo);
            DB.AddParameter("@County", mThisStaff.County);
            DB.AddParameter("@PayrollNo", mThisStaff.PayrollNo);
            DB.AddParameter("@TrainingCompleted", mThisStaff.TrainingCompleted);
            DB.AddParameter("@Active", mThisStaff.Active);
            DB.AddParameter("@RoleType", mThisStaff.RoleType);


            //execute th equery returning the primary keyvalue 
            return DB.Execute("sproc_Staff_Insert");
        }

        public void Delete()
        {
            //delete the record pointed to by thisStaff
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            //excute the store procedure
            DB.Execute("sproc_Staff_Delete");
        }

        public void Update()
        {
            //adds a new record to the database based on the values of mThisStaff
            //connect to th edatabase
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("@Postcode", mThisStaff.Postcode);
            DB.AddParameter("@County", mThisStaff.County);
            DB.AddParameter("@MobileNo", mThisStaff.MobileNo);
            DB.AddParameter("@County", mThisStaff.County);
            DB.AddParameter("@PayrollNo", mThisStaff.PayrollNo);
            DB.AddParameter("@TrainingCompleted", mThisStaff.TrainingCompleted);
            DB.AddParameter("@Active", mThisStaff.Active);
            DB.AddParameter("@RoleType", mThisStaff.RoleType);

            //execute th equery returning the primary keyvalue 
            DB.Execute("sproc_Staff_Update");
        }

        public void FilterByStaffID(int StaffID)
        {
            //filters the record based on a full or partial postcode
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the lastname parameter to the database
            DB.AddParameter("@StaffID", StaffID);
            //execute the stored procedure
            DB.Execute("sproc_Staff_FilterByStaffID");
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
            StaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsStaff AnStaff = new clsStaff();
                //read in the fields from the current record
                AnStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AnStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnStaff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnStaff.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnStaff.Postcode = Convert.ToString(DB.DataTable.Rows[Index]["Postcode"]);
                AnStaff.County = Convert.ToString(DB.DataTable.Rows[Index]["County"]);
                AnStaff.MobileNo = Convert.ToString(DB.DataTable.Rows[Index]["MobileNo"]);
                AnStaff.PayrollNo = Convert.ToString(DB.DataTable.Rows[Index]["PayrollNo"]);
                AnStaff.TrainingCompleted = Convert.ToString(DB.DataTable.Rows[Index]["TrainingCompleted"]);
                AnStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnStaff.RoleType = Convert.ToString(DB.DataTable.Rows[Index]["RoleType"]);

                //add the record to the private data mamber
                StaffList.Add(AnStaff);
                //point at the next record
                Index++;
            }

        }
    }
}

    