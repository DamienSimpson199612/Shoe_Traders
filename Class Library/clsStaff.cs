﻿using System;

namespace Class_Library
{
    public class clsStaff
    {
        //private data member for the StaffID property
        private Int32 mStaffID;
        //private data member for the StaffID property
        private Boolean mActive;
        //private data member for the StaffID property
        private String mFirstName;
        //private data member for the StaffID property
        private String mLastName;
        //private data member for the StaffID property
        private String mAddress;
        //private data member for the StaffID property
        private String mPostCode;
        //private data member for the StaffID property
        private String mCounty;
        //private data member for the StaffID property
        private Int32 mMobileNo;
        //private data member for the StaffID property
        private String mPayrollNo;
        //private data member for the StaffID property
        private String mRoleType;
        //private data member for the StaffID property
        private String mTrainingCompleted;



        //public property for the Staff number
        public int StaffID
        {
            get
            {//return the private data 
                return mStaffID;
            }
            set
            {
                //set the value if the priavte data memeber
                mStaffID = value;
            }
        }


        public bool Active {
            get
            { //return the private data 
                return mActive;
            }
            set
            {
                //set the value if the priavte data memeber
                mActive = value;
            }
        }

        public string FirstName
        {
            get
            { //return the private data 
                return mFirstName;
            }
            set
            {
                //set the value if the priavte data memeber
                mFirstName = value;
            }
        }

        public string LastName
        {
            get
            { //return the private data 
                return mLastName;
            }
            set
            {
                //set the value if the priavte data memeber
                mLastName = value;
            }
        }

        public string Address {
            get
            { //return the private data 
                return mAddress;
            }
            set
            {
                //set the value if the priavte data memeber
                mAddress = value;
            }
        }


        public string PostCode
        {
            get
            { //return the private data 
                return mPostCode;
            }
            set
            {
                //set the value if the priavte data memeber
                mPostCode = value;
            }
        }


        public string County
        {
            get
            { //return the private data 
                return mCounty;
            }
            set
            {
                //set the value if the priavte data memeber
                mCounty = value;
            }
        }


      
        public int MobileNo
        {
            get
            { //return the private data 
                return mMobileNo;
            }
            set
            {
                //set the value if the priavte data memeber
                mMobileNo = value;
            }
        }
        public string PayrollNo
        {
            get
            { //return the private data 
                return mPayrollNo;
            }
            set
            {
                //set the value if the priavte data memeber
                mPayrollNo = value;
            }
        }
       
        public string RoleType
        {
            get
            {//return the private data 
                return mRoleType;
            }
            set
            {
                //set the value if the priavte data memeber
                mRoleType = value;
            }
        }
       
        public string TrainingCompleted
        {
            get
            {//return the private data 
                return mTrainingCompleted;
            }
            set
            {
                //set the value if the priavte data memeber
                mTrainingCompleted = value;
            }
        }

        public bool Find(int StaffID)
        {

            //create an instance if the data connection
            clsDataConnection staffDB = new clsDataConnection();
            //add the parameter for the staffID to search for
            staffDB.AddParameter("@StaffID", StaffID);
            //execute the stored procedure
            staffDB.Execute("sproc_tblStaff_FilterByStaffID");
            //if one recird is found (there should be either one or zero)
            if (staffDB.Count == 1)
            {
                //copy the data the database to the private data members
                mActive = Convert.ToBoolean(staffDB.DataTable.Rows[0]["Active"]);
                mStaffID = Convert.ToInt32(staffDB.DataTable.Rows[0]["StaffID"]);
                mFirstName = Convert.ToString(staffDB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(staffDB.DataTable.Rows[0]["LasttName"]);
                mAddress = Convert.ToString(staffDB.DataTable.Rows[0]["Address"]);
                mCounty = Convert.ToString(staffDB.DataTable.Rows[0]["County"]);
                mPostCode = Convert.ToString(staffDB.DataTable.Rows[0]["PostCode"]);
                mMobileNo = Convert.ToInt32(staffDB.DataTable.Rows[0]["MobileNo"]);
                mPayrollNo = Convert.ToString(staffDB.DataTable.Rows[0]["PayrollNo"]);
                mRoleType = Convert.ToString(staffDB.DataTable.Rows[0]["RoleType"]);
                mTrainingCompleted = Convert.ToString(staffDB.DataTable.Rows[0]["TrainingCompleted"]);
                //return that everything is okay worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating problem
                return false;
            }

        }
    }
}