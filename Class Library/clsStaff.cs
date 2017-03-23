using System;

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
        private String mPostcode;
        //private data member for the StaffID property
        private String mCounty;
        //private data member for the StaffID property
        private String mMobileNo;
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


        public bool Active
        {
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

        public string Address
        {
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


        public string Postcode
        {
            get
            { //return the private data 
                return mPostcode;
            }
            set
            {
                //set the value if the priavte data memeber
                mPostcode = value;
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



        public string MobileNo
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
            staffDB.Execute("sproc_Staff_FilterByStaffID");
            //if one recird is found (there should be either one or zero)
            if (staffDB.Count == 1)
            {
                //copy the data the database to the private data members
                mActive = Convert.ToBoolean(staffDB.DataTable.Rows[0]["Active"]);
                mStaffID = Convert.ToInt32(staffDB.DataTable.Rows[0]["StaffID"]);
                mFirstName = Convert.ToString(staffDB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(staffDB.DataTable.Rows[0]["LastName"]);
                mAddress = Convert.ToString(staffDB.DataTable.Rows[0]["Address"]);
                mCounty = Convert.ToString(staffDB.DataTable.Rows[0]["County"]);
                mPostcode = Convert.ToString(staffDB.DataTable.Rows[0]["Postcode"]);
                mMobileNo = Convert.ToString(staffDB.DataTable.Rows[0]["MobileNo"]);
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

        public bool Valid(string FirstName, string LastName, string Address, string Postcode, string County, string MobileNo, string PayrollNo, string RoleType, string TrainingCompleted)
        {
            // boolean variable
            Boolean Ok = true;
            if (FirstName.Length < 1)
            {
                Ok = false;
            }
            if (FirstName.Length > 50)
            {
                Ok = false;
            }

            if (LastName.Length < 1)
            {
                Ok = false;
            }
            if (LastName.Length > 50)
            {
                Ok = false;
            }

            if (Address.Length < 1)
            {
                Ok = false;
            }
            if (Address.Length > 50)
            {
                Ok = false;
            }

            if (Postcode.Length < 1)
            {
                Ok = false;
            }
            if (Postcode.Length > 7)
            {
                Ok = false;
            }

            //if (County.Length < 1)
            //{
            //    Ok = false;
            //}
            //if (County.Length > 7)
            //{
            //    Ok = false;
            //}

            if (MobileNo.Length < 1)
            {
                Ok = false;
            }
            if (MobileNo.Length > 12)
            {
                Ok = false;
            }


        


            //if (PayrollNo.Length < 1)
            //{
            //    Ok = false;
            //}
            //if (PayrollNo.Length > 10)
            //{
            //    Ok = false;
            //}

            //if (RoleType.Length < 1)
            //{
            //    Ok = false;
            //}
            //if (RoleType.Length > 50)
            //{
            //    Ok = false;
            //}

            //if (TrainingCompleted.Length < 1)
            //{
            //    Ok = false;
            //}
            //if (TrainingCompleted.Length > 500)
            //{
            //    Ok = false;
            //}



            return Ok;
        }
    }
    }

