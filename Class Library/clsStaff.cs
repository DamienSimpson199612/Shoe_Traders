using System;

namespace Class_Library
{
    public class clsStaff
    {
        //private data member for the StaffID property
        private Int32 mStaffID;
        //private data member for the StaffID property
        private String mCounty;
        //private data member for the StaffID property
        private String mFirstName;

        public bool Active { get; set; }
        public string Address { get; set; }
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
        public string FirstName
        {
            get
            { //return the private data 
                return mFirstName;
            }
            set
            {
                //set the value if the priavte data memeber
                mFirstName= value;
            }
        }
        public string LastName { get; set; }
        public int MobileNo { get; set; }
        public int PayrollNo { get; set; }
        public string PostCode { get; set; }
        public string RoleType { get; set; }
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
        public string TrainingCompleted { get; set; }

        public bool Find(int staffID)
        {
            //set the private data 
            mStaffID = 21;
            //set the private data 
            mCounty = "Test County";
            //set the private data 
            mFirstName = "Test First Name";
            //always return true
            return true;
        }

      
    }
}