using System;

namespace Class_Library
{
    public class clsStaff
    {
        //private data member for the StaffID property
        private Int32 mStaffID;

        public bool Active { get; set; }
        public string Address { get; set; }
        public string County { get; set; }
        public string FirstName { get; set; }
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
            //always return true
            return true;
        }
    }
}