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

        public bool Find(int staffID)
        {
            //set the private data 
            mActive =  true ;
            //set the private data 
            mStaffID = 21;
            //set the private data 
            mFirstName = "Test First Name";
            //set the private data 
            mLastName = "Test Last Name";
            //set the private data 
            mAddress = "Test Address";
            //set the private data 
            mCounty = "Test County";
            //set the private data 
            mPostCode = "Test PostCode";
           //set the private data 
            mMobileNo = 0;
            //set the private data 
            mPayrollNo = "Test PayrollNo";
            //set the private data 
            mRoleType = "Test RoleType";
            //set the private data 
            mTrainingCompleted = "Test TrainingCompleted";

            //always return true
            return true;
        }

      
    }
}