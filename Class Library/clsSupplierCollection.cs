using System;
using System.Collections.Generic;
using MyClassLibrary;

namespace Class_Library
{
    public class clsSupplierCollection
    {
         
        //priavte data member for the list 
        List<clsSupplierPage> mSupplierList = new List<clsSupplierPage>();
        //private data member thisStaff
        clsSupplierPage mThisSupplier = new clsSupplierPage();

        //public property for ThisStaff
        public List<clsSupplierPage> SupplierList
        {
            get
            {
                //return the private data
                return mSupplierList;
            }
         set
            {
                //set the private data
                mSupplierList = value;
            }
        }
        //
        public int Count
        {
            get
            {
                //return the count foer the list 
                return mSupplierList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }


        public clsSupplierPage ThisSupplier
        {
            get
            {
                //return the private data
                return mThisSupplier;
            }
            set
            {
                //set th eprivate data
                mThisSupplier = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisSupplier
            //set the primary key value of the new record
            mThisSupplier.SupplierNo = 123;
            //return the primary key of the new record
            return mThisSupplier.SupplierNo;
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }
}